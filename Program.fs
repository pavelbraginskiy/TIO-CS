﻿// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open MoreLinq
open System.Linq
open MathNet.Symbolics
open Newtonsoft.Json.Linq

open Operators

[<EntryPoint>]
let main argv =
    MoreEnumerable.Random().First() |> printfn "%d"
    @"{""foo"":42}" |> JObject.Parse |> printfn "%O"

    let x = symbol "x"
    x*x |> Infix.format |> printfn "%s" 

    0 // return an integer exit code
