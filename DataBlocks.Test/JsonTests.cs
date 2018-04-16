using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

using Xunit;

using DataBlocks.Core;
using DataBlocks.Json;
using DataBlocks.Prelude;

namespace DataBlocks.Test
{
  using static DataBlocks.Json.JsonCodec;

  public class JsonTests
  {
    [Theory]
    [InlineData("true", "bool", true)]
    [InlineData("false", "bool", false)]
    [InlineData("1", "decimal", 1)]
    [InlineData("1.51", "decimal", 1.51)]
    [InlineData("-1.51", "decimal", -1.51)]
    [InlineData("\"9fb89383-eddd-4eca-b10d-339eaac1d29f\"", "guid", "9fb89383-eddd-4eca-b10d-339eaac1d29f")]
    [InlineData("1", "int", 1)]
    [InlineData("100", "int", 100)]
    [InlineData("-100", "int", -100)]
    [InlineData("0", "int", 0)]
    [InlineData("\"test\"", "string", "test")]
    [InlineData("\"\"", "string", "")]
    public void FixedValueCodecs_AppropriateData_Decodes(string json, string type, object expected)
    {
      object result = null;
      switch (type)
      {
        case "bool":
          result = Bool.DecodeString(json).Match(x => (object)x, e => (object)e);
          break;
        case "decimal":
          expected = Convert.ToDecimal(expected);
          result = Decimal.DecodeString(json).Match(x => (object)x, e => (object)e);
          break;
        case "guid":
          expected = new Guid((string)expected);
          result = Guid.DecodeString(json).Match(x => (object)x, e => (object)e);
          break;
        case "int":
          result = Int.DecodeString(json).Match(x => (object)x, e => (object)e);
          break;
        case "string":
          result = String.DecodeString(json).Match(x => (object)x, e => (object)e);
          break;
      }
      Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("true", "bool", true)]
    [InlineData("false", "bool", false)]
    [InlineData("1.0", "decimal", 1)]
    [InlineData("1.51", "decimal", 1.51)]
    [InlineData("-1.51", "decimal", -1.51)]
    [InlineData("\"9fb89383-eddd-4eca-b10d-339eaac1d29f\"", "guid", "9fb89383-eddd-4eca-b10d-339eaac1d29f")]
    [InlineData("1", "int", 1)]
    [InlineData("100", "int", 100)]
    [InlineData("-100", "int", -100)]
    [InlineData("0", "int", 0)]
    [InlineData("\"test\"", "string", "test")]
    [InlineData("\"\"", "string", "")]
    public void FixedValueCodecs_EncodesProperly(string expected, string type, object input)
    {
      var result = "";
      switch (type)
      {
        case "bool":
          result = Bool.EncodeString((bool)input);
          break;
        case "decimal":
          result = Decimal.EncodeString(Convert.ToDecimal(expected));
          break;
        case "guid":
          result = Guid.EncodeString(new Guid((string)input));
          break;
        case "int":
          result = Int.EncodeString((int)input);
          break;
        case "string":
          result = String.EncodeString((string)input);
          break;
      }
      Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("null")]
    [InlineData("1.0")]
    [InlineData("1.51")]
    [InlineData("-1.51")]
    [InlineData("\"9fb89383-eddd-4eca-b10d-339eaac1d29f\"")]
    [InlineData("1")]
    [InlineData("100")]
    [InlineData("-100")]
    [InlineData("0")]
    [InlineData("\"test\"")]
    [InlineData("\"\"")]
    public void Bool_InapropriateData_DoesNotDecode(string input)
    {
      Assert.Equal("Expected a boolean value", Bool.DecodeString(input).Match(x => "", x => x.Errors.First().Message));
    }

    [Theory]
    [InlineData("null")]
    [InlineData("true")]
    [InlineData("false")]
    [InlineData("\"9fb89383-eddd-4eca-b10d-339eaac1d29f\"")]
    [InlineData("\"test\"")]
    [InlineData("\"\"")]
    public void Decimal_InapropriateData_DoesNotDecode(string input)
    {
      Assert.Equal("Expected a decimal value", Decimal.DecodeString(input).Match(x => "", x => x.Errors.First().Message));
    }

    [Theory]
    [InlineData("null")]
    [InlineData("true")]
    [InlineData("false")]
    [InlineData("1.0")]
    [InlineData("1.51")]
    [InlineData("-1.51")]
    [InlineData("1")]
    [InlineData("100")]
    [InlineData("-100")]
    [InlineData("0")]
    [InlineData("\"test\"")]
    [InlineData("\"\"")]
    public void Guid_InapropriateData_DoesNotDecode(string input)
    {
      Assert.Equal("Expected a GUID value", Guid.DecodeString(input).Match(x => "", x => x.Errors.First().Message));
    }

    [Theory]
    [InlineData("null")]
    [InlineData("true")]
    [InlineData("false")]
    [InlineData("1.0")]
    [InlineData("1.51")]
    [InlineData("-1.51")]
    [InlineData("\"9fb89383-eddd-4eca-b10d-339eaac1d29f\"")]
    [InlineData("\"test\"")]
    [InlineData("\"\"")]
    public void Int_InapropriateData_DoesNotDecode(string input)
    {
      Assert.Equal("Expected an integer value", Int.DecodeString(input).Match(x => "", x => x.Errors.First().Message));
    }

    [Theory]
    [InlineData("null")]
    [InlineData("true")]
    [InlineData("false")]
    [InlineData("1.0")]
    [InlineData("1.51")]
    [InlineData("-1.51")]
    [InlineData("1")]
    [InlineData("100")]
    [InlineData("-100")]
    [InlineData("0")]
    public void String_InapropriateData_DoesNotDecode(string input)
    {
      Assert.Equal("Expected a string value", String.DecodeString(input).Match(x => "", x => x.Errors.First().Message));
    }

    [Theory]
    [InlineData("null", null)]
    [InlineData("\"test\"", "test")]
    public void Nullable_ApropriateData_Decodes(string input, string expected)
    {
      Nullable(String)
          .DecodeString(input)
          .Match<object>(
              v => { Assert.Equal(expected, v.Match(x => x, () => null)); return null; },
              e => throw new Xunit.Sdk.AssertActualExpectedException(expected, e, "Decode failed.")
          );
    }

    [Theory]
    [InlineData("null", null)]
    [InlineData("\"test\"", "test")]
    public void Nullable_Encodes(string expected, string input)
    {
      Assert.Equal(expected, Nullable(String).EncodeString(input == null ? Maybe<string>.None : Maybe<string>.Some(input)));
    }

    [Fact]
    public void Nullable_InapropriateData_DoesNotDecode()
    {
      Nullable(String)
          .DecodeString("true")
          .Match<object>(
              v => throw new Xunit.Sdk.AssertActualExpectedException("A Failure", v, "Expected the decoding to fail."),
              e => { Assert.Equal("Expected a string value", string.Join("", e.Errors.Select(x => x.Message))); return null; }
          );
    }

    [Theory]
    [InlineData("[]", new string[0])]
    [InlineData("[\"test\"]", new[] { "test" })]
    [InlineData("[\"test\", \"foo\", \"bar\"]", new[] { "test", "foo", "bar" })]
    public void Array_ApropriateData_Decodes(string input, IEnumerable<string> expected)
    {
      Array(String)
          .DecodeString(input)
          .Match<object>(
              v => { Assert.Equal(expected, v); return null; },
              e => throw new Xunit.Sdk.AssertActualExpectedException(expected, e, "Decode failed.")
          );
    }

    [Theory]
    [InlineData("[]", new string[0])]
    [InlineData("[\"test\"]", new[] { "test" })]
    [InlineData("[\"test\",\"foo\",\"bar\"]", new[] { "test", "foo", "bar" })]
    public void Array_ApropriateData_Encodes(string expected, IEnumerable<string> input)
    {
      Assert.Equal(expected, Array(String).EncodeString(input, Formatting.None));
    }

    [Theory]
    [InlineData("null")]
    [InlineData("true")]
    [InlineData("false")]
    [InlineData("1.0")]
    [InlineData("1.51")]
    [InlineData("-1.51")]
    [InlineData("\"9fb89383-eddd-4eca-b10d-339eaac1d29f\"")]
    [InlineData("1")]
    [InlineData("100")]
    [InlineData("-100")]
    [InlineData("0")]
    [InlineData("\"test\"")]
    [InlineData("\"\"")]
    public void Array_InapropriateData_DoesNotDecode(string input)
    {
      Array(String)
          .DecodeString(input)
          .Match<object>(
              v => throw new Xunit.Sdk.AssertActualExpectedException("A Failure", v, "Expected the decoding to fail."),
              e => { Assert.Equal("Expected an array", string.Join("", e.Errors.Select(x => x.Message))); return null; }
          );
    }

    private static readonly Codec<JsonWrapper, Natural> NaturalCodec = Int.EpimapRichStringError(Natural.Create, x => x.Value);

    private static readonly Codec<JsonWrapper, ChildFieldType> ChildFieldTypeCodec =
        Switch<ChildFieldType>()
            .Case(x => x.Int, ChildFieldType.Case1, Int)
            .Case(x => x.Str, ChildFieldType.Case2, String);

    private static readonly Codec<JsonWrapper, SuperAdvancedOptions> SuperAdvancedOptionsCodec =
        Object<SuperAdvancedOptions>()
            .Required("childField", x => x.ChildField, ChildFieldTypeCodec)
            .Construct(SuperAdvancedOptions.Create);

    private static readonly Codec<JsonWrapper, AdvancedOptions> AdvancedOptionsCodec =
        Object<AdvancedOptions>()
            .Required("allowNonsecure", x => x.AllowNonsecure, Bool)
            .Required("superAdvanced", x => x.SuperAdvanced, SuperAdvancedOptionsCodec)
            .Construct(AdvancedOptions.Create);

    private static readonly Codec<JsonWrapper, ImaginationConfig> ImaginationConfigCodec =
        Object<ImaginationConfig>()
            .Required("url", x => x.Url, String)
            .Required("connectionLimit", x => x.ConnectionLimit, NaturalCodec)
            .Required("trustedUrls", x => x.TrustedUrls, Array(String))
            .Optional("email", x => x.Email, String)
            .Required("advanced", x => x.Advanced, AdvancedOptionsCodec)
            .Construct(ImaginationConfig.Create);

    [Fact]
    public void Composition_AppropriateData_Decodes()
    {
        var actual = ImaginationConfigCodec
            .DecodeString(@"{
                'url': 'http://www.google.com',
                'connectionLimit': 1,
                'trustedUrls': ['url1'],
                'email': 'asdf@test.com',
                'advanced': {
                    'allowNonsecure': false,
                    'superAdvanced': { 'childField': 1 }
                }
            }")
            .Match(
                v => v,
                e => null
            );

        var expected = ImaginationConfig.Create(
            "http://www.google.com",
            Natural.Create(1).Match(x => x, _ => null),
            new[] { "url1" },
            Maybe<string>.Some("asdf@test.com"),
            AdvancedOptions.Create(
                false,
                SuperAdvancedOptions.Create(
                    ChildFieldType.Case1(1)
                )
            )
        );

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Composition_InappropriateData_DoesNotDecode()
    {
        var actual = ImaginationConfigCodec
            .DecodeString(@"{
                'url': 1,
                'connectionLimit': -1,
                'email': false,
                'advanced': {
                    'allowNonsecure': false,
                    'superAdvanced': { 'childField': true }
                }
            }")
            .Match(
                v => default(DecoderError).Zero,
                e => e
            );

        var expected = 
          DecoderError.Single("url", "Expected a string value")
            .Append(DecoderError.Single("connectionLimit", "Value must be positive"))
            .Append(DecoderError.Single("trustedUrls", "Value is required"))
            .Append(DecoderError.Single("email", "Expected a string value"))
            .Append(DecoderError.Single("advanced.superAdvanced.childField", "Expected a string value"));

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Composition_Encodes()
    {
        var actual = ImaginationConfigCodec
            .EncodeString(ImaginationConfig.Create(
                "http://www.google.com",
                Natural.Create(1).Match(x => x, _ => null),
                new[] { "url1" },
                Maybe<string>.Some("asdf@test.com"),
                AdvancedOptions.Create(
                    false,
                    SuperAdvancedOptions.Create(
                        ChildFieldType.Case1(1)
                    )
                )
            ));

        var expected =
@"{
  ""url"": ""http://www.google.com"",
  ""connectionLimit"": 1,
  ""trustedUrls"": [
    ""url1""
  ],
  ""email"": ""asdf@test.com"",
  ""advanced"": {
    ""allowNonsecure"": false,
    ""superAdvanced"": {
      ""childField"": 1
    }
  }
}".Replace("\r\n", "\n");

        Assert.Equal(expected, actual);
    }
  }
}
