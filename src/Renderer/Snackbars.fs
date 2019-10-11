module Snackbars

open Elmish
open Fable.React
open Feliz
open Feliz.MaterialUI


type Msg =
  | SnackMsg of Snack.Msg<Msg>
  | ShowSnackbar
  | CustomActionStart
  | CustomActionEnd


type Model =
  { Snack: Snack.Model<Msg>
    CustomActionOngoing: bool }


let init () =
  { Snack = Snack.init ()
    CustomActionOngoing = false }

let update msg m =
  match msg with
  | ShowSnackbar ->
      let cmd =
        Snack.create "Click button to perform an operation"
        |> Snack.withCustomAction "Calculate" CustomActionStart
        |> Snack.add
      m, Cmd.map SnackMsg cmd
  | CustomActionStart ->
      let asyncWork =
        async {
          do! Async.Sleep 1000
          return CustomActionEnd
        }
      let cmd = Cmd.OfAsync.result asyncWork
      { m with CustomActionOngoing = true }, cmd
  | CustomActionEnd -> { m with CustomActionOngoing = false }, Cmd.none
  | SnackMsg msg' ->
      let m', cmd, actionCmd = Snack.update msg' m.Snack
      { m with Snack = m' }, Cmd.batch [Cmd.map SnackMsg cmd; actionCmd]



// Domain/Elmish above, view below


let SnackbarPage = FunctionComponent.Of((fun (model, dispatch) ->
  Html.div [
    prop.children [
      Snack.Snackbar(model.Snack, SnackMsg >> dispatch)
      Mui.button [
        prop.onClick (fun _ -> dispatch ShowSnackbar)
        button.children "Show snackbar"
      ]
      if model.CustomActionOngoing then
        Mui.circularProgress []
    ]
  ]
), "SnackbarPage", memoEqualsButFunctions)
