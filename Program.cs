using System;

namespace DataBlocks
{
  using System.Collections.Generic;
  using static Codec;

    class Program
    {

        static Codec<ValueString, Unit, T> Switch<T>() => Codec.Switch<ValueString, Unit, T>();
        static Codec<ValueString, Unit, T> Lift<T>(Func<ValueString, T> f, Func<T, ValueString> g) => Codec.Lift<ValueString, Unit, T>(f, g);
        static Codec<ValueString, Unit, T, Unit> BeginConstruction<T>() => Codec.BeginConstruction<ValueString, Unit, T>();

        static void Main(string[] args)
        {
            var childFieldTypeCodec = 
                Switch<ChildFieldType>()
                    .Case(x => x.Int, ChildFieldType.Case1, Lift(_ => 1, x => x.ToString()))
                    .Case(x => x.Str, ChildFieldType.Case2, Lift<string>(x => x, x => x));

            var superAdvancedOptionsCodec =
                childFieldTypeCodec.InvmapRich(SuperAdvancedOptions.Create, x => x.ChildField);

            var advancedOptionsCodec =
                BeginConstruction<AdvancedOptions>()
                    .Part(x => x.AllowNonsecure, Lift(_ => true, x => x.ToString()))
                    .Part(x => x.SuperAdvanced, superAdvancedOptionsCodec)
                    .Construct(AdvancedOptions.Create);

            var imaginationConfigCodec =
                BeginConstruction<ImaginationConfig>()
                    .Part(x => x.Url, Lift(_ => "test", x => x))
                    .Part(x => x.ConnectionLimit, Lift(_ => 1, x => x.ToString()).EpimapRich(x => Natural.Create(x).MapError(_ => Unit.Default), x => x.Value))
                    .Part(x => x.TrustedUrls, Lift<IEnumerable<string>>(_ => new[] { "test1" }, x => $"[{string.Join(", ", x)}]"))
                    .Part(x => x.Email, Lift(_ => Maybe<string>.Some("email"), x => x.Match(y => y, () => "[None]")))
                    .Part(x => x.Advanced, advancedOptionsCodec)
                    .Construct(ImaginationConfig.Create);

            Natural.Create(1)
                .Map(nat =>
                {
                    Console.WriteLine(imaginationConfigCodec.Encode(ImaginationConfig.Create("url", nat, new [] { "asdf" }, Maybe<string>.None, AdvancedOptions.Create(true, SuperAdvancedOptions.Create(ChildFieldType.Case1(2))))));
                    return 1;
                });
        }
    }
}
