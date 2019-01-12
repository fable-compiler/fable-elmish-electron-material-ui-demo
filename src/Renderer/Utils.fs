[<AutoOpen>]
module Utils

open Fable.Core
open Fable.Helpers.React
open Fable.Import
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


[<Emit("undefined")>]
let undefined<'a> : 'a = jsNative


/// Casts a ReactElement to a ReactNode (erased at runtime)
let elNode (el: ReactElement ) =
  el |> ReactChild.Case1 |> ReactNode.Case1

/// Casts a string to a ReactNode (erased at runtime).
let strNode (s: string) =
  s |> str |> elNode

/// Casts an integer to a ReactNode (erased at runtime).
let intNode (i: int) =
  i |> ofInt |> elNode


// TODO: why must we use JS here? Create (non-working) repro with F# code and report Fable bug?
[<Emit("
const prototype = Object.getPrototypeOf($0);
const prototypeValueSetter = Object.getOwnPropertyDescriptor(prototype, 'value').set;
prototypeValueSetter.call($0, $1);
$0.dispatchEvent(new Event('input', { bubbles: true }));
")>]
let setValueAndTriggerOnChanged (element: Browser.HTMLInputElement) (value: string) : unit = jsNative


let memoize2RefEq (f: 'a -> 'b -> 'c) =
  let mutable a' = Unchecked.defaultof<'a>
  let mutable b' = Unchecked.defaultof<'b>
  let mutable c' = Unchecked.defaultof<'c>
  fun a b ->
    if LanguagePrimitives.PhysicalEquality a a'
       && LanguagePrimitives.PhysicalEquality b b'
    then c'
    else
      a' <- a
      b' <- b
      c' <- f a b
      c'


[<AutoOpen>]
module Extensions =

  type Result<'T,'TError> with

    member this.IsOk =
      match this with Ok _ -> true | Error _ -> false

    member this.IsError =
      match this with Error _ -> true | Ok _ -> false

    member this.ErrorOr value =
      match this with Ok _ -> value | Error err -> err
