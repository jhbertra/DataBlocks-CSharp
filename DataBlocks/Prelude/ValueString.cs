namespace DataBlocks.Prelude
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
}