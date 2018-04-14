namespace AfeCodec
{

  public interface IEncoder<in TRich, out TRaw>
  {

    TRaw Run(TRich input);

  }

}