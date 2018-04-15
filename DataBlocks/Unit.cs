namespace DataBlocks
{

  public struct Unit : IMonoid<Unit>
  {

    public readonly static Unit Default = default(Unit);

    public Unit Zero => Default;

    public Unit Append(Unit b)
    {
      return Default;
    }
  }

}