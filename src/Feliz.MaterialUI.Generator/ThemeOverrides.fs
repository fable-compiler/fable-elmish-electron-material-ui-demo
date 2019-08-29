module ThemeOverrides

open System
open System.IO
open System.Text.RegularExpressions
open FSharp.Data

let outFile = @"..\..\..\..\Feliz.MaterialUI\ThemeOverrides.fs"



let generateInterface (url: string) =
  use w = new StringWriter()
  let page = ComponentApiPage.Load(url)
  try
    // This can fail with KeyNotFoundException if there are no classes
    let table = page.Tables.CSS

    let stylesheetNamePascalCase =
      Regex.Match(page.Html.Body().ToString(), "Style sheet name:\s*\<code\>(.+?)\<\/code\>")
        .Groups.[1].Value
    let stylesheetNameCamelCase = stylesheetNamePascalCase.Substring(0, 1).ToLower() + stylesheetNamePascalCase.Substring(1)

    w.printfn "type I%sOverrideRule = interface end" stylesheetNamePascalCase

    w.ToString ()

  with :? System.Collections.Generic.KeyNotFoundException -> ""


let generateMembers (url: string) =
  use w = new StringWriter()
  let page = ComponentApiPage.Load(url)
  try
    // This can fail with KeyNotFoundException if there are no classes
    let table = page.Tables.CSS

    let stylesheetNamePascalCase =
      Regex.Match(page.Html.Body().ToString(), "Style sheet name:\s*\<code\>(.+?)\<\/code\>")
        .Groups.[1].Value
    let stylesheetNameCamelCase = stylesheetNamePascalCase.Substring(0, 1).ToLower() + stylesheetNamePascalCase.Substring(1)

    w.printfn """  static member inline %s (rules: I%sOverrideRule list) : IOverrideStyleSheet = unbox ("%s", createObj !!rules)""" stylesheetNameCamelCase stylesheetNamePascalCase stylesheetNamePascalCase

    w.ToString ()

  with :? System.Collections.Generic.KeyNotFoundException -> ""


let generateType (url: String) =
  use w = new StringWriter()
  let page = ComponentApiPage.Load(url)

  try
    // This can fail with KeyNotFoundException if there are no classes
    let table = page.Tables.CSS

    let stylesheetNamePascalCase =
      Regex.Match(page.Html.Body().ToString(), "Style sheet name:\s*\<code\>(.+?)\<\/code\>")
        .Groups.[1].Value
    let stylesheetNameCamelCase = stylesheetNamePascalCase.Substring(0, 1).ToLower() + stylesheetNamePascalCase.Substring(1)

    w.printfn "  [<Erase>]"
    w.printfn "  type %s =" stylesheetNameCamelCase

    for i, row in Seq.indexed table.Rows do
      let markdownDoc =
        table.Html.CssSelect("tbody > tr").[i].CssSelect("td").[2].Elements()
        |> docElementsToMarkdown

      let ruleName = row.``Rule name``

      let safeName = 
        ruleName
        |> kebabCaseToCamelCase
        |> appendApostropheToReservedKeywords

      let docString = getDocString 4 markdownDoc 
      if docString <> "" then
        w.WriteLine docString

      w.printfn """    static member inline %s(styles: IStyleAttribute list) : I%sOverrideRule = unbox ("%s", createObj !!styles)""" safeName stylesheetNamePascalCase ruleName

    w.ToString ()

  with :? System.Collections.Generic.KeyNotFoundException -> ""

let generateAll () =
  Console.WriteLine("\n\nGENERATING OVERRIDES\n")
  use w = new StringWriter()
  w.printfn """namespace Feliz.MaterialUI
  
(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz
  
type IOverrideStyleSheet = interface end
"""

  HtmlCache.getCachedPages () |> Array.map (fun path -> 
    Console.WriteLine(sprintf "Processing %s" path)
    generateInterface path
  )
  |> Array.iter w.Write

  w.printfn ""
  w.printfn "[<Erase>]"
  w.printfn "type overrides ="

  HtmlCache.getCachedPages () |> Array.map (fun path ->
    Console.WriteLine(sprintf "Processing %s" path)
    generateMembers path
  )
  |> Array.iter w.Write

  w.printfn ""
  w.printfn "module overrides ="
  w.printfn ""
  HtmlCache.getCachedPages () |> Array.map (fun path ->
    Console.WriteLine(sprintf "Processing %s" path)
    generateType path
  )
  |> Array.iter w.WriteLine

  System.IO.File.WriteAllText(outFile, w.ToString())
