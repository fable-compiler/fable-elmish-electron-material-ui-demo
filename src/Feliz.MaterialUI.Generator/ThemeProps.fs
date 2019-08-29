module ThemeProps

open System
open System.IO
open System.Text.RegularExpressions
open FSharp.Data

let outFile = @"..\..\..\..\Feliz.MaterialUI\ThemeProps.fs"


let generateMembers (url: string) =
  use w = new StringWriter()
  let page = ComponentApiPage.Load(url)
  let code = page.Html.CssSelect("pre").[0].InnerText()
  let matches = Regex.Match(code, "import (.+) from'(.+?)'")
  let componentNamePascalCase = "Mui" + matches.Groups.[1].Value
  let componentNameCamelCase = componentNamePascalCase.Substring(0, 1).ToLower() + componentNamePascalCase.Substring(1)
  w.printfn """  static member inline %s(props: IReactProperty list) : IThemeProps = unbox ("%s", createObj !!props)""" componentNameCamelCase componentNamePascalCase
  w.ToString ()


let generateAll () =
  Console.WriteLine("\n\nGENERATING THEME PROPS\n")
  use w = new StringWriter()
  w.printfn """namespace Feliz.MaterialUI
  
(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz
  
type IThemeProps = interface end
"""

  w.printfn ""
  w.printfn "[<Erase>]"
  w.printfn "type themeProps ="

  HtmlCache.getCachedPages () |> Array.map (fun path ->
    Console.WriteLine(sprintf "Processing %s" path)
    generateMembers path
  )
  |> Array.iter w.Write

  System.IO.File.WriteAllText(outFile, w.ToString())
