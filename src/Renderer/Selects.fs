module Selects

open System
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.MaterialUI.Core
open Fable.Import.React
open Fable.MaterialUI


let private tryParseGuid str =
  match Guid.TryParse str with
  | false, _ -> None
  | true, guid -> Some guid


type DomainEntity =
  { Id: Guid
    Name: string
    Description: string }

type Model =
  { Entities: DomainEntity list
    SelectedId: Guid option }

type Msg =
  | SelectEntity of Guid option

let init () =
  { Entities =
      [ {Id = Guid.NewGuid(); Name = "Entity 1"; Description = "Description for entity 1"}
        {Id = Guid.NewGuid(); Name = "Entity 2"; Description = "Description for entity 2"} ]
    SelectedId = None }

let update msg m =
  match msg with
  | SelectEntity eid -> { m with SelectedId = eid }


// Domain/Elmish above, view below


let private styles (theme: ITheme) : IStyles list =
  [
    Styles.FormControl [
      MinWidth "120px"
    ]
  ]


let private selectItem e =
  menuItem [
    HTMLAttr.Value e.Id
    Key (string e.Id)
  ] [
    div [] [
      typography [] [ str e.Name ]
      typography [ TypographyProp.Variant TypographyVariant.Caption ] [ str e.Description ]
    ]
  ]

let private view' (classes: IClasses) model dispatch =
  form [ OnSubmit (fun e -> e.preventDefault()) ] [
    formControl [
      Class classes?formControl
      HTMLAttr.Required true
      MaterialProp.Error model.SelectedId.IsNone
    ] [
      inputLabel [ ] [ str "Entity" ]
      select [
        HTMLAttr.Value (model.SelectedId |> Option.map string |> Option.defaultValue "")
        DOMAttr.OnChange (fun ev -> ev.Value |> tryParseGuid |> SelectEntity |> dispatch)
      ] [
        model.Entities
        |> List.sortBy (fun e -> e.Name)
        |> List.map selectItem
        |> ofList
      ]
      formHelperText [] [
        str (if model.SelectedId.IsNone then "Please select a value" else "Value OK")
      ]
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
