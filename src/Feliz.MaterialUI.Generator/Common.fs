[<AutoOpen>]
module Common

open System.IO
open System.Text.RegularExpressions
open FSharp.Data
open ReverseMarkdown

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


let hasNonInlineMembers s =
  Regex.IsMatch(s, "static member (?!inline )")


let private markdownConverter =
  Converter(
    Config(
      GithubFlavored=true,
      RemoveComments=true,
      SmartHrefHandling=true,
      UnknownTags=Config.UnknownTagsOption.PassThrough
    )
  )

let docElementsToMarkdown (nodes: HtmlNode list) =
  (nodes
  |> Seq.map (fun x -> x.ToString().Replace("\r\n", "<br><br>"))
  |> String.concat ""
  |> fun s -> s.Replace("href=\"/", "href=\"https://material-ui.com/")
  |> fun s -> s.Replace("</code><code>", "</code> <code>")
  |> markdownConverter.Convert)
   .Replace("<br>", "\r\n")
  |> fun s -> System.Text.RegularExpressions.Regex.Replace(s, "\r\n\r\n(\r\n)+", "\r\n\r\n")


let getDocString indentSpaces (markdown: string) =
  if markdown = "" then ""
  else
    (markdown.Trim('\r', '\n').Split("\r\n")
    |> Array.map (fun s -> String.replicate indentSpaces " " + "/// " + s)
    |> Array.map (fun s -> s.TrimEnd())
    |> String.concat ("\r\n"))
