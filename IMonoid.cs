namespace DataBlocks
{

  public interface IMonoid<T> where T : struct, IMonoid<T>
  {

    T Zero { get; }
    T Append(T b);

  }

}