[<AutoOpen>]
module Utils

open Fable.Core
open Fable.Helpers.React
open Fable.Import.React

[<Emit("__static + \"/\" + $0")>]
let private stat' (s: string) : string = jsNative

/// Prefixes the string with the static asset root path.
let stat (s: string) =
  #if DEBUG
  s
  #else
  stat' s
  #endif


/// Casts a ReactElement to a ReactNode (erased at runtime)
let elNode (el: ReactElement ) =
  el |> ReactChild.Case1 |> ReactNode.Case1

/// Casts a string to a ReactNode (erased at runtime).
let strNode (s: string) =
  s |> str |> elNode

/// Casts an integer to a ReactNode (erased at runtime).
let intNode (i: int) =
  i |> ofInt |> elNode


[<AutoOpen>]
module Extensions =

  type Result<'T,'TError> with

    member this.IsOk =
      match this with Ok _ -> true | Error _ -> false

    member this.IsError =
      match this with Error _ -> true | Ok _ -> false

    member this.ErrorOr value =
      match this with Ok _ -> value | Error err -> err
