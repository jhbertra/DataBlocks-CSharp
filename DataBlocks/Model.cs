using System.Collections.Generic;

using DataBlocks.Prelude;

namespace DataBlocks
{

  public struct ValueString : IMonoid<ValueString>
  {

    public ValueString(string s)
    {
      this._value = s;
    }

    public ValueString Zero => "";

    public ValueString Append(ValueString b)
    {
      return this._value + b._value;
    }

    public static implicit operator string(ValueString s) => s._value;

    public static implicit operator ValueString(string s) => new ValueString(s);

    private readonly string _value;
  }

  public sealed class Natural
  {

    public static Result<ValueString, Natural> Create(int value)
    {
      return value > 0
        ? Result<ValueString, Natural>.Ok(new Natural(value))
        : Result<ValueString, Natural>.Error("Value must be positive.");
    }

    private Natural(int value)
    {
      this.Value = value;
    }

    public readonly int Value;

  }

  public sealed class ChildFieldType
  {

    public static ChildFieldType Case1(int value)
    {
      return new ChildFieldType(Maybe<int>.Some(value), Maybe<string>.None);
    }

    public static ChildFieldType Case2(string value)
    {
      return new ChildFieldType(Maybe<int>.None, Maybe<string>.Some(value));
    }

    private ChildFieldType(Maybe<int> case1, Maybe<string> case2)
    {
      this.Int = case1;
      this.Str = case2;
    }

    public readonly Maybe<int> Int;
    public readonly Maybe<string> Str;

  }

  public sealed class SuperAdvancedOptions
  {
    public static SuperAdvancedOptions Create(ChildFieldType childField)
    {
      return new SuperAdvancedOptions(childField);
    }

    private SuperAdvancedOptions(ChildFieldType childField)
    {
      this.ChildField = childField;
    }

    public readonly ChildFieldType ChildField;
  }

  public sealed class AdvancedOptions
  {
    public static AdvancedOptions Create(bool allowNonsecure, SuperAdvancedOptions superAdvanced)
    {
      return new AdvancedOptions(allowNonsecure, superAdvanced);
    }

    private AdvancedOptions(bool allowNonsecure, SuperAdvancedOptions superAdvanced)
    {
      this.AllowNonsecure = allowNonsecure;
      this.SuperAdvanced = superAdvanced;
    }

    public readonly bool AllowNonsecure;
    public readonly SuperAdvancedOptions SuperAdvanced;
  }

  public sealed class ImaginationConfig
  {

    public static ImaginationConfig Create(
      string url,
      Natural connectionLimit,
      IEnumerable<string> trustedUrls,
      Maybe<string> email,
      AdvancedOptions advanced)
    {
      return new ImaginationConfig(
        url,
        connectionLimit,
        trustedUrls,
        email,
        advanced
      );
    }

    private ImaginationConfig(
      string url,
      Natural connectionLimit,
      IEnumerable<string> trustedUrls,
      Maybe<string> email,
      AdvancedOptions advanced)
    {
      this.Url = url;
      this.ConnectionLimit = connectionLimit;
      this.TrustedUrls = trustedUrls;
      this.Email = email;
      this.Advanced = advanced;
    }

    public readonly string Url;
    public readonly Natural ConnectionLimit;
    public readonly IEnumerable<string> TrustedUrls;
    public readonly Maybe<string> Email;
    public readonly AdvancedOptions Advanced;
  }

}