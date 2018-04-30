# DataBlocks
`DataBlocks` is a library for creating highly composable `Codecs` in C#
using pure functional programming. It is heavily inspired by Elm's JSON
decoder library. A `Codec` is a sort of bidiorectional function that can
both decode and encode raw data. As an example, a very simple decoder
written in C# might look like this:

```cs
static int DecodeInt(string s)
{
    return int.Parse(s);
}
```

And its inverse encoder might look like this:

```cs
static string EncodeInt(int i)
{
    return int.Parse(s);
}
```

A codec that combines these would look something like this:

```cs
var intCodec = new
{
    Decode = new Func<string, int>(DecodeInt),
    Encode = new Func<int, string>(EncodeInt)
};

intCodec.Decode("1"); // 1
intCodec.Encode(1); // "1"
```

# Fundamental Types

The fundamental building blocks of this library are, in essence, functions. Functions
are particularly well suited for creating `Codecs`, as they way they can be composed
very closely resembles the way data structures can be composed. Indeed, this is the
fundamental philosophy of functional programming. The resulting code tends to resemble
formal documentation describing how an application's data is structured, with the added
benefit of being able to execute said documentation.

## Decoders

A `Decoder` is a function that reads raw data and attempts to convert it to a structured
format.  This operation may fail, as the raw format may fail to express the domain data
in a valid way.  The characteristic of a `Decoder` is that is may return a collection of
errors describing what went wrong if the conversion failed.

```cs
var d = new Decoder<string, int>((id, stringData) =>
        int.TryParse(stringData, out int i)
            ? (Either<DecoderErrors, int>)i // Uses LanguageExt.Either
            : DecoderErrors.Single(id, "Expected an integer"))
    .SetId("theSpecificDataBeingDecoded");

d.Decode("1"); // Right(1)
d.Decode("foo"); // Left({theSpecificDataBeingDecoded: Expected an integer})
```

## Encoders

An `Encoder` is a function that reverses a decoder. It writes data to a raw format.
The only difference between an `Encoder` and a `Decoder` is that the operation never
fails. This implies that the raw data format should be able to represent any imaginable
domain data.  For example, all `ints` can be represented by a `string`, but not all
`strings` can be parsed to an `int`.

```cs
var e = new Encoder<string, int>(i => i.ToString());

e.Encode(1); // "1"
```

## Codecs

A `Codec` is simply a matching pair of a `Decoder` and an `Encoder`.  `Decoder` + `Encoder` = `Codec`.

```cs
var codec = new Codec<string, int>(d, e).SetId("newId");

codec.Decode("1"); // Right(1)
codec.Decode("foo"); // Left({newId: Expected an integer})

codec.Encode(1); // "1"
```

# Fundamental Operations

So far, these examples probably don't seem very exciting. That's because they are
absolutely basic. The fact that they are so basic however means that they are also
incredibly flexible. They snap together like building blocks (hence the name of the
library). Here are some of the most common ways this is accomplished.

## Invmap

Given a `Codec<TRaw, T1>`, provide a function `T1 -> T2` to invoke on the result of
its decoder, and and inverse function `T2 -> T1` to invoke on the input of its encoder
to create a `Codec<TRaw, T2>`

```cs
// Using our codec from above
codec.Invmap(i => i * 2, i => i / 2); // Codec<string, int> Decode doubles the input, and Encode halves it.
codec.Invmap(Convert.ToDecimal, Convert.ToInt); // Codec<string, decimal>
```

## ChainValidation

Given a `Codec<TRaw, T1>`, provide a function `T1 -> Either<string, T2>` to invoke on
the result of its decoder, and and inverse function `T2 -> T1` to invoke on the input
of its encoder to create a `Codec<TRaw, T2>`.  This can be used to progressively validate
input data and output a type that is more specific.

```cs
struct Natural
{
    readonly int Value;

    public Natural(int i) { this.Value = i; }

    static Either<string, Natural> Create(int i)
    {
        return i > 0
            ? new Natural(i)
            : (Either<string, Natural>) "Value must be positive";
    }
}

// Using our codec from above
var naturalCodec = codec
    .ChainValidation(Natural.Create, n => n.Value) // Codec<string, Natural>
    .SetId("nat");

naturalCodec.Decode("1"); // Right(Natural(1))
naturalCodec.Decode("0"); // Left({nat: Value must be positive})
naturalCodec.Decode("foo"); // Left({nat: Expected an integer})

naturalCodec.Encode(new Natural(1)); // "1"
```

## Switch + Case

Create a `Codec` that can handle multiple valid representations.

```cs
interface IContactInfo {}
struct EmailContactInfo : IContactInfo { ... }
struct PhoneContactInfo : IContactInfo { ... }

var emailCodec = ...;
var phoneCodec = ...;

Option<TSub> DownCast<TBase, TSub>(TBase x) where TSub : TBase => x as TSub;
TBase UpCast<TBase, TSub>(TSub x) where TSub : TBase => (TSub)x;

var contactInfoCodec = Codec.Switch<string, IContactInfo>()
    .Case(DownCast<IContactInfo, EmailContactInfo>, UpCast<EmailContactInfo, IContactInfo>, emailCodec)
    .Case(DownCast<IContactInfo, PhoneContactInfo>, UpCast<PhoneContactInfo, IContactInfo>, phoneCodec)
    .SetId("contactInfo");

contactInfoCodec.Decode("555-1234"); // Right(PhoneContactInfo(555, 1234))
contactInfoCodec.Decode("asdf@test.com"); // Right(EmailContactInfo("asdf", "test.com"))
contactInfoCodec.Decode("123 Imagination St."); // Left({contactInfo: Expected a phone number})

contactInfoCodec.Encode(new EmailContactInfo("asdf", "test.com")) // "asdf@test.com"
contactInfoCodec.Encode(new PhoneContactInfo(555, 1234)) // "555-1234"
```

## BeginConstruction + Part + Construct

Create a `Codec` that can handle large composite data structures by
combining codecs for their fields.

```cs
struct Contact
{
    public Contact(string name, IContactInfo info)
    {
        this.Name = name;
        this.Info = info;
    }

    public readonly string Name;

    public readonly IContactInfo Info;
}

static Codec<IDictionary<string, TRaw>, T> DictCodec<TRaw, T>(string key, Codec<string, T> elementCodec)
{
    return new Codec<TRaw[], T>(
        new Decoder<TRaw[], T>((id, dict) =>
            dict.ContainsKey(key)
                ? elementCodec.Decoder.Run($"[{key}]", dict[key])
                : DecoderErrors(id, $"Key not found")),
        data => new Dictionary<string, TRaw>
        {
            [key] = elementCodec.Encode(data)
        });
}

var contactCodec = BeginConstruction<IDictionary<string, string>, Contact>(
        emptyRaw: new new Dictionary<string, TRaw>(),
        appendRaw: (a, b) => new[] { a, b } // merging dictionaries
            .SelectMany(dict => dict)
            .ToDictionary(pair => pair.Key, pair => pair.Value);)
    .Part(x => x.Name, DictCodec("name", stringCodec))
    .Part(x => x.Info, DictCodec("info", contactInfoCodec))
    .Construct((name, info) => new Contact(name, info)); // Codec<IDictionary<string, string>, Contact>

contactCodec.Decode(new Dictionary<string, string>
{
    ["name"] = "Peter Joe",
    ["info"] = "555-1234"
}); // Right(Contact("Peter Joe", PhoneContactInfo(555, 1234)))

contactCodec.Decode(new Dictionary<string, string>
{
    ["name"] = "Peter Joe"
}); // Left({info: Key not found})

contactCodec.Encode(new Contact("Peter Joe", new EmailContact("asdf", "test.com"))); // { "name": "Peter Joe", "info": "asdf@test.com" }
```