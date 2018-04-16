for i in [18 .. 65] do
  let targs = ([1..i] |> List.map (sprintf "T%d") |> String.concat ", ")
  let delegateName = sprintf "Delegate%d" i
  let delegateTargs = ([1..i+1] |> List.map (sprintf "T%d") |> String.concat ", ")
  let tupleType = sprintf "%sT1 t1, T2 t2)%s" (String.replicate (i - 1) "(") ([3..i] |> List.map (fun i -> sprintf ", T%d t%d)" i i) |> String.concat "")
  let dParamArgs = sprintf "%s, TRich" targs
  let delegateArgs = ([1..i] |> List.map (fun i -> sprintf "T%d t%d" i i) |> String.concat ", ")
  printfn "    public delegate T%d %s<%s>(%s);" (i + 1) delegateName delegateTargs delegateArgs
  printfn "    public static Codec<TRaw, TRich> Construct<TRaw, TRich, %s>(" targs
  printfn "      this Codec<TRaw, TRich, %s> codec," tupleType
  printfn "      %s<%s> f)" delegateName dParamArgs
  printfn "      where TRaw : struct, IMonoid<TRaw>"
  printfn "    {"
  printfn "      return new Codec<TRaw, TRich>("
  printfn "        codec.Decoder.Map(t => f("
  printfn "          t%s.t1," (String.replicate (i - 2) ".Item1")
  printfn "          t%s.t2," (String.replicate (i - 2) ".Item1")
  for j in [3 .. i - 1] do printfn "          t%s.t%d," (String.replicate (i - j) ".Item1") j
  printfn "          t.t%d))," i
  printfn "        codec.Encoder"
  printfn "      );"
  printfn "    }"
  printfn ""