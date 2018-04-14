namespace AfeCodec
{

  public interface ICodec<TRaw, TRich, TError>
    where TError : struct, IMonoid<TError>
  {
      
    TRaw Enocde(TRich input);
    Result<TError, TRich> Decode(TRaw input);

  }

}