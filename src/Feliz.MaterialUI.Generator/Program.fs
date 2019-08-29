[<EntryPoint>]
let main argv =
  //HtmlCache.refreshApiCache()
  Classes.generateAll ()
  ThemeOverrides.generateAll ()
  Props.generateAll ()
  Mui.generateAll ()
  0
