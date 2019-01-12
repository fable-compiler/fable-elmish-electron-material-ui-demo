module Badges

open System
open Elmish.React
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.React
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.MaterialUI
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props
open Fable.MaterialUI.MaterialDesignIcons
open Fable.MaterialUI.Icons


type Model =
  { Count: int }

type Msg =
  | Increment
  | Decrement

let init () =
  { Count = 2 }

let update msg m =
  match msg with
  | Increment -> { m with Count = m.Count + 1 }
  | Decrement -> { m with Count = m.Count - 1 }


// Domain/Elmish above, view below


let private styles (theme: ITheme) : IStyles list =
  [
    Styles.Custom ("description", [
      MarginBottom (theme.spacing.unit * 3)
    ])
    Styles.Custom ("margin", [
      MarginRight (theme.spacing.unit * 2)
    ])
  ]


let private view' (classes: IClasses) model dispatch =
  div [] [
    div [ Class classes?description ] [
      typography [ Paragraph true ] [ str "The badge becomes invisible when count = 0." ]
    ]
    div [] [
      iconButton [ Class classes?margin ] [
        badge [
          BadgeProp.Invisible (model.Count = 0)
          BadgeProp.Color BadgeColor.Secondary
          BadgeContent (intNode model.Count)
        ] [ notificationsIcon [] ]
      ]
      iconButton [
        DOMAttr.OnClick (fun _ -> dispatch Decrement)
        HTMLAttr.Disabled (model.Count <= 0)
      ] [ minusIcon [] ]
      iconButton [
        DOMAttr.OnClick (fun _ -> dispatch Increment)
      ] [ plusIcon [] ]
    ]
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
  let inputWithStyles = withStyles (StyleType.Func styles) [] viewFun
  override this.render() = from inputWithStyles this.props []

let view (model: Model) (dispatch: Msg -> unit) : ReactElement =
  let props = jsOptions<IProps>(fun p ->
    p.model <- model
    p.dispatch <- dispatch)
  ofType<Component,_,_> props []
