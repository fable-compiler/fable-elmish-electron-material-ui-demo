module Mui

open System
open System.Text
open System.IO
open FSharp.Data

let outFile = @"..\..\..\..\Feliz.MaterialUI\Mui.fs"

let generatePage (url: String) =
  use w = new StringWriter()
  let html = ComponentApiPage.Load(url).Html
  let code = html.CssSelect("pre").[0].InnerText()
  let matches = RegularExpressions.Regex.Match(code, "import (.+) from'(.+?)'")
  let componentName =
    let s = matches.Groups.[1].Value
    s.Substring(0, 1).ToLower() + s.Substring(1)
  let importPath = matches.Groups.[2].Value

  let noteNodes1 =
    html.CssSelect(".markdown-body").[0].Elements()
    |> List.skipWhile (fun n -> n.Name() <> "table")
    |> fun l -> if l.IsEmpty then l else List.skip 1 l
    |> List.takeWhile (fun n -> n.Name() = "p")
  let noteNodes2 =
    html.CssSelect(".markdown-body").[0].Elements()
    |> List.skipWhile (fun n -> n.Name() <> "h2" || n.InnerText() <> "Notes")
    |> fun l -> if l.IsEmpty then l else List.skip 1 l
    |> List.takeWhile (fun n -> n.Name() = "p")
  let docString = noteNodes1 @ noteNodes2 |> docElementsToMarkdown |> getDocString 2

  w.WriteLine docString
  w.printfn "  static member inline %s props = createElement (importDefault \"%s\") props" componentName importPath

  match componentName with
  | "dialogContentText"
  | "dialogTitle"
  | "formHelperText"
  | "formLabel"
  | "inputLabel"
  | "listSubheader"
  | "stepLabel"
  | "tableCell"
  | "typography" ->
      w.printfn ""
      w.WriteLine docString
      w.printfn "  static member inline %s (text: string) = createElement (importDefault \"%s\") [ prop.children (Html.text text) ]" componentName importPath
  | "icon" ->
      w.printfn ""
      w.WriteLine docString
      w.printfn "  static member inline %s (name: string) = createElement (importDefault \"%s\") [ prop.children (Html.text name) ]" componentName importPath
  | "listItemText" ->
      w.printfn ""
      w.WriteLine docString
      w.printfn "  static member inline %s (primary: string) = createElement (importDefault \"%s\") [ listItemText.primary primary ]" componentName importPath
  | _ -> ()

  w.ToString()


let generateAll () =
  Console.WriteLine("\n\nGENERATING COMPONENTS\n")
  use w = new StringWriter()
  w.printfn("""namespace Feliz.MaterialUI

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

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

  static member inline muiThemeProvider props = createElement (importDefault "@material-ui/core/styles/MuiThemeProvider") props
""")

  HtmlCache.getCachedPages () |> Array.map (fun path ->
    Console.WriteLine(sprintf "Processing %s" path)
    generatePage path
  )
  |> Array.iter w.WriteLine
  System.IO.File.WriteAllText(outFile, w.ToString())
