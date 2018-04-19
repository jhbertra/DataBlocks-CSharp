namespace DataBlocks.Prelude
{

  public static class Duple
  {
    public static Duple<T1, T2> Create<T1, T2>(T1 t1, T2 t2)
    {
      return new Duple<T1, T2>(t1, t2);
    }
  }
  
  public struct Duple<T1, T2>
  {

    public Duple(T1 t1, T2 t2)
    {
      this._1 = t1;
      this._2 = t2;
    }

    public readonly T1 _1;
    public readonly T2 _2;

  }

}