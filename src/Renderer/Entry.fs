module Entry

open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.HMR

Program.mkProgram App.init App.update App.view
|> Program.withReactSynchronous "app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run
