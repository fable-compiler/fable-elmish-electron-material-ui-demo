[<EntryPoint>]
let main argv =
  //HtmlCache.refreshApiCache()
  Classes.generateAll ()
  Props.generateAll ()
  Mui.generateAll ()
  0
