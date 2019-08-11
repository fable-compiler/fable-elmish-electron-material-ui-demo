module Mui

open System
open System.Text
open System.IO
open FSharp.Data

let outFile = @"..\..\..\..\Feliz.MaterialUI\Mui.fs"

let generatePage (url: String) =
  let code = ComponentApiPage.Load(url).Html.CssSelect("pre").[0].InnerText()
  let matches = RegularExpressions.Regex.Match(code, "import (.+) from'(.+)'")
  let componentName =
    let s = matches.Groups.[1].Value
    s.Substring(0, 1).ToLower() + s.Substring(1)
  let importPath = matches.Groups.[2].Value
  sprintf "  static member inline %s = createElement (importDefault \"%s\")" componentName importPath

let generateAll () =
  Console.WriteLine("\n\nGENERATING COMPONENTS\n")
  use w = new StringWriter()
  w.printfn("""namespace Feliz.MaterialUI

//////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
//////////////////////////////////

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz

[<AutoOpen>]
module MuiHelpers =

  [<System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>]
  let reactElement (el: ReactElementType) (props: 'a) : ReactElement =
    import "createElement" "react"
  
  [<System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>]
  let createElement (el: ReactElementType) (properties: IReactProperty list) : ReactElement =
    reactElement el (createObj !!properties)

[<Erase>]
type Mui =
""")

  HtmlCache.getCachedPages () |> Array.Parallel.mapi (fun i path -> 
    Console.WriteLine(sprintf "Processing #%i: %s" i path)
    generatePage path
  )
  |> Array.iter w.WriteLine
  System.IO.File.WriteAllText(outFile, w.ToString())
