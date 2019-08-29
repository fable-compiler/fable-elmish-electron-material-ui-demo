[<EntryPoint>]
let main argv =
  //HtmlCache.refreshApiCache()
  Classes.generateAll ()
  ThemeOverrides.generateAll ()
  ThemeProps.generateAll ()
  Props.generateAll ()
  Mui.generateAll ()
  0
