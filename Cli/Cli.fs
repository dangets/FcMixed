module FcMixed.Cli

open System

let println (input: string) =
    Console.WriteLine input

[<EntryPoint>]
let main argv =
    println (FcMixed.CsLib.csLibFn ())
    println (FcMixed.FsLib.fsLibFn ())
    0 // return an integer exit code
