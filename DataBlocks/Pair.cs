namespace DataBlocks.Prelude
{

  public static class Pair
  {
    public static Pair<T1, T2> Create<T1, T2>(T1 t1, T2 t2)
    {
      return new Pair<T1, T2>(t1, t2);
    }
  }
  
  public struct Pair<T1, T2>
  {

    public Pair(T1 t1, T2 t2)
    {
      this._1 = t1;
      this._2 = t2;
    }

    public readonly T1 _1;
    public readonly T2 _2;

  }

}