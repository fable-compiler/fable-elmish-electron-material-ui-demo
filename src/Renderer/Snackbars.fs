module Snackbars

open System
open Elmish
open Elmish.React
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props
open Fable.MaterialUI
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.MaterialDesignIcons
open Fable.MaterialUI.Icons


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


let private styles (theme: ITheme) : IStyles list =
  []


let private view' (classes: IClasses) model dispatch =
  div [] [
    yield lazyView2 Snack.view model.Snack (SnackMsg >> dispatch)
    yield button [ OnClick (fun _ -> dispatch ShowSnackbar) ] [ str "Show snackbar" ]
    if model.CustomActionOngoing then yield circularProgress []
  ]


// Workaround for using JSS with Elmish
// https://github.com/mvsmal/fable-material-ui/issues/4#issuecomment-422781471
type private IProps =
  abstract member model: Model with get, set
  abstract member dispatch: (Msg -> unit) with get, set
  inherit IClassesProps

type private Component(p) =
  inherit PureStatelessComponent<IProps>(p)
  let viewFun (p: IProps) = view' p.classes p.model p.dispatch
  let viewWithStyles = withStyles (StyleType.Func styles) [] viewFun
  override this.render() = ReactElementType.create viewWithStyles this.props []


let view (model: Model) (dispatch: Msg -> unit) : ReactElement =
  let props = jsOptions<IProps>(fun p ->
    p.model <- model
    p.dispatch <- dispatch)
  ofType<Component,_,_> props []
