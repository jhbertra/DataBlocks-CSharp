using System.Collections.Generic;
using System.Linq;
using LanguageExt;

namespace DataBlocks.Test
{

  public sealed class Natural
  {

    public static Either<string, Natural> Create(int value)
    {
      return value > 0
        ? (Either<string, Natural>) new Natural(value)
        : "Value must be positive";
    }

    private Natural(int value)
    {
      this.Value = value;
    }

    public readonly int Value;

    public override bool Equals(object obj)
    {
      return obj is Natural other && this == other;
    }

    public static bool operator ==(Natural a, Natural b)
    {
      return a.Value == b.Value;
    }

    public static bool operator !=(Natural a, Natural b)
    {
      return !(a == b);
    }

  }

  public sealed class ChildFieldType
  {

    public static ChildFieldType Case1(int value)
    {
      return new ChildFieldType(Option<int>.Some(value), Option<string>.None);
    }

    public static ChildFieldType Case2(string value)
    {
      return new ChildFieldType(Option<int>.None, Option<string>.Some(value));
    }

    private ChildFieldType(Option<int> case1, Option<string> case2)
    {
      this.Int = case1;
      this.Str = case2;
    }

    public override bool Equals(object obj)
    {
      return obj is ChildFieldType other && this == other;
    }

    public static bool operator ==(ChildFieldType a, ChildFieldType b)
    {
      return a.Int == b.Int
        && a.Str == b.Str;
    }

    public static bool operator !=(ChildFieldType a, ChildFieldType b)
    {
      return !(a == b);
    }

    public readonly Option<int> Int;
    public readonly Option<string> Str;

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

    public override bool Equals(object obj)
    {
      return obj is SuperAdvancedOptions other && this == other;
    }

    public static bool operator ==(SuperAdvancedOptions a, SuperAdvancedOptions b)
    {
      return a.ChildField == b.ChildField;
    }

    public static bool operator !=(SuperAdvancedOptions a, SuperAdvancedOptions b)
    {
      return !(a == b);
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

    public override bool Equals(object obj)
    {
      return obj is AdvancedOptions other && this == other;
    }

    public static bool operator ==(AdvancedOptions a, AdvancedOptions b)
    {
      return a.AllowNonsecure == b.AllowNonsecure
        && a.SuperAdvanced == b.SuperAdvanced;
    }

    public static bool operator !=(AdvancedOptions a, AdvancedOptions b)
    {
      return !(a == b);
    }
  }

  public sealed class ImaginationConfig
  {

    public static ImaginationConfig Create(
      string url,
      Natural connectionLimit,
      IEnumerable<string> trustedUrls,
      Option<string> email,
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
      Option<string> email,
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
    public readonly Option<string> Email;
    public readonly AdvancedOptions Advanced;

    public override bool Equals(object obj)
    {
      return obj is ImaginationConfig other && this == other;
    }

    public static bool operator ==(ImaginationConfig a, ImaginationConfig b)
    {
      return a.Url == b.Url
        && a.ConnectionLimit == b.ConnectionLimit
        && a.TrustedUrls.SequenceEqual(b.TrustedUrls)
        && a.Email == b.Email
        && a.Advanced == b.Advanced;
    }

    public static bool operator !=(ImaginationConfig a, ImaginationConfig b)
    {
      return !(a == b);
    }
  }

}