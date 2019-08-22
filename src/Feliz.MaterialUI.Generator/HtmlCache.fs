module HtmlCache

open System
open System.IO

let apiFolder = @"..\..\..\Html\Api"

let refreshApiCache () =
  apiPageUrls |> List.toArray |> Array.Parallel.iteri (fun i url -> 
    Console.WriteLine(sprintf "Processing #%i: %s" i url)
    use client = new System.Net.Http.HttpClient()
    let html = client.GetStringAsync(url).Result
    let name =
      url.Split("/", StringSplitOptions.RemoveEmptyEntries)
      |> Array.last
    let filename = sprintf @"%s\%s.html" apiFolder name
    File.WriteAllText(filename, html, Text.Encoding.UTF8)
  )

let getCachedPages () =
  Directory.GetFiles(apiFolder, "*.html")
  |> Array.sortBy (fun s -> s.Substring(0, s.LastIndexOf ".").Replace("-", ""))
