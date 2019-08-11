module HtmlCache

open System

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
    System.IO.File.WriteAllText(filename, html, Text.Encoding.UTF8)
  )

let getCachedPages () =
  System.IO.Directory.GetFiles(apiFolder, "*.html")
