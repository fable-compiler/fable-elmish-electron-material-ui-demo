module Entry

open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.HMR

Program.mkSimple App.emptyModel App.update App.view
|> Program.withReact "app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run
