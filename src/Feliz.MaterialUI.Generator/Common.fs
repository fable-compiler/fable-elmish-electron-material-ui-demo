[<AutoOpen>]
module Common

open System.IO
open System.Text.RegularExpressions
open FSharp.Data

type TextWriter with
  member this.printf fmt = fprintf this fmt
  member this.printfn fmt = fprintfn this fmt

type ComponentApiPage = HtmlProvider<"Html/Api/app-bar.html">

let baseUrl = "https://material-ui.com"
let apiPageUrls =
  ComponentApiPage.GetSample().Html.CssSelect("nav ul li").[2].CssSelect("ul li")
  |> List.map (fun x -> 
    let relUrl = x.CssSelect("a").[0].AttributeValue("href")
    baseUrl + relUrl
  )

let appendApostropheToReservedKeywords (s: string) =
  let reserved =
    ["checked"; "static"; "fixed"; "inline"; "default"; "component"; "inherit"; "open"; "type"; "true"; "false"; "in"; "end"]
    |> Set.ofList
  if reserved.Contains s then s + "'" else s

let prefixUnderscoreToNumbers (s: string) =
  if s = "" then s
  elif s |> Seq.head |> System.Char.IsNumber then "_" + s
  else s

let kebabCaseToCamelCase (s: string) =
  let pieces = s.Split("-")
  if pieces.Length > 1 then
    pieces |> Array.iteri (fun i piece ->
      if i > 0 then
        pieces.[i] <- piece.Substring(0, 1).ToUpper() + piece.Substring(1)
    )
    pieces |> String.concat ""
  else s

let stripLinks s =
  Regex.Replace(s, "\<a href=\".+?\"\>\s*(.+?)\s*\<\/a\>", "$1")

let newlinesToSpace (s: string) =
  s.Replace("\r", "").Replace("\n", " ")

let codeToMarkdown (s: string) =
  s.Replace("<code>", "`").Replace("</code>", "`")

let docElementsToDocStringParagraphs (nodes: HtmlNode list) =
  (nodes
  |> Seq.map (fun x -> x.ToString())
  |> String.concat ""
  |> codeToMarkdown
  |> newlinesToSpace
  |> stripLinks)
    .Split("<br>")

let getDocString indentSpaces (paragraphs: string []) =
  paragraphs
  |> Array.map (fun s -> String.replicate indentSpaces " " + "/// " + s)
  |> String.concat ("\r\n" + String.replicate indentSpaces " " + "/// ")
