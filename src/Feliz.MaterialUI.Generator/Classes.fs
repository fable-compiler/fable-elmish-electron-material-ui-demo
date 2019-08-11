module Classes

open System
open System.IO
open FSharp.Data

let outFile = @"..\..\..\..\Feliz.MaterialUI\Classes.fs"

let generatePage (url: String) =
  use w = new StringWriter()
  let page = ComponentApiPage.Load(url)
  let componentNamePascalCase = page.Html.CssSelect("h1").[0].InnerText().Split(" ").[0]
  let componentNameCamelCase = componentNamePascalCase.Substring(0, 1).ToLower() + componentNamePascalCase.Substring(1)

  w.printfn ""
  w.printfn "  type I%sClasses = interface end" componentNamePascalCase

  try
    // This can fail with KeyNotFoundException if there are no classes, but we
    // still want to generate the IXClasses above, because other props may refer
    // to it (e.g. IModalClasses which is referred to by
    // props.popover.ModalClasses even though modal doesn't have any classes).
    let table = page.Tables.CSS

    w.printfn ""
    w.printfn "  let inline private mk%sClasses (key: string) (value: IClassName) : I%sClasses = unbox (key, value)" componentNamePascalCase componentNamePascalCase
    w.printfn ""
    w.printfn "  [<Erase>]"
    w.printfn "  type %s =" componentNameCamelCase

    for i, row in Seq.indexed table.Rows do
      let docStrings =
        table.Html.CssSelect("tbody > tr").[i].CssSelect("td").[2].Elements()
        |> docElementsToDocStringParagraphs

      let ruleName = row.``Rule name``

      let safeName = 
        ruleName
        |> kebabCaseToCamelCase
        |> appendApostropheToReservedKeywords

      let docString = getDocString 4 docStrings 
      if docString <> "" then
        w.WriteLine docString

      w.printfn """    static member inline %s(value: IClassName) = mk%sClasses "%s" value""" safeName componentNamePascalCase ruleName

  with :? System.Collections.Generic.KeyNotFoundException -> ()
  w.ToString ()

let generateAll () =
  Console.WriteLine("\n\nGENERATING CLASSES\n")
  use w = new StringWriter()
  w.printfn """namespace Feliz.MaterialUI
  
//////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
//////////////////////////////////

open Fable.Core
  
type IClassName = interface end
  
/// Override or extend the styles applied to components.
module classes ="""

  HtmlCache.getCachedPages () |> Array.Parallel.mapi (fun i path -> 
    Console.WriteLine(sprintf "Processing #%i: %s" i path)
    generatePage path
  )
  |> Array.iter w.WriteLine
  System.IO.File.WriteAllText(outFile, w.ToString())
