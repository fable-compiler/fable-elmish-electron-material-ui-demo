module Dialogs

open System
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


type Dialog =
  | Alert
  | Select
  | Form


type Model =
  { CurrentDialog: Dialog option
    AlertResponse: bool option
    AvailableSelectValues: string list
    SelectResponse: string option
    FormText: string
    FormResponse: string option }

type Msg =
  | OpenDialog of Dialog
  | AbortDialog
  | SetAlertResponse of bool
  | SetSelectResponse of string
  | FormTextEntered of string
  | ConfirmFormDialog

let init () =
  { CurrentDialog = None
    AlertResponse = None
    AvailableSelectValues = ["Option 1"; "Option 2"; "Option 3"]
    SelectResponse = None
    FormText = ""
    FormResponse = None }

let update msg m =
  match msg with
  | OpenDialog d -> { m with CurrentDialog = Some d }
  | AbortDialog -> { m with CurrentDialog = None }
  | SetAlertResponse s -> { m with CurrentDialog = None; AlertResponse = Some s }
  | SetSelectResponse s -> { m with CurrentDialog = None; SelectResponse = Some s }
  | FormTextEntered s -> { m with FormText = s }
  | ConfirmFormDialog -> { m with CurrentDialog = None; FormResponse = Some m.FormText }


// Domain/Elmish above, view below


let private styles (theme: ITheme) : IStyles list =
  []


let private alertDialog model dispatch =
  dialog [
    Open (model.CurrentDialog = Some Alert)
    MaterialProp.OnClose (fun _ -> dispatch AbortDialog)
  ] [
    dialogTitle [] [ str "Do you agree?" ]
    dialogContent [] [
      dialogContentText [] [
        str "Please indicate whether you agree."
      ]
    ]
    dialogActions [] [
      button [
        OnClick (fun _ -> SetAlertResponse false |> dispatch)
        MaterialProp.Color ComponentColor.Primary
      ] [ str "Disagree" ]
      button [
        OnClick (fun _ -> SetAlertResponse true |> dispatch)
        MaterialProp.Color ComponentColor.Primary
      ] [ str "Agree" ]
    ]
  ]


let private selectDialog model dispatch =
  dialog [
    Open (model.CurrentDialog = Some Select)
    MaterialProp.OnClose (fun _ -> dispatch AbortDialog)
  ] [
    dialogTitle [] [ str "Choose an option" ]
    list [] [
      model.AvailableSelectValues |> List.map (fun value ->
        listItem [
          ListItemProp.Button true
          OnClick (fun _ -> SetSelectResponse value |> dispatch)
          Key value
        ] [
          listItemText [ ] [ str value ]
        ]
      )
      |> ofList
    ]
  ]


let private formDialog model dispatch =
  dialog [
    Open (model.CurrentDialog = Some Form)
    MaterialProp.OnClose (fun _ -> dispatch AbortDialog)
  ] [
    dialogTitle [] [ str "Write your response" ]
    dialogContent [] [
      dialogContentText [] [ str "Please enter your response in the form below." ]
      textField [
        AutoFocus true
        MaterialProp.Margin FormControlMargin.Dense
        Label (str "Your reponse")
        FullWidth true
        DOMAttr.OnChange (fun ev -> ev.Value |> FormTextEntered |> dispatch)
      ] []
    ]
    dialogActions [] [
      button [
        OnClick (fun _ -> dispatch AbortDialog)
        MaterialProp.Color ComponentColor.Primary
      ] [ str "Cancel" ]
      button [
        OnClick (fun _ -> dispatch ConfirmFormDialog)
        MaterialProp.Color ComponentColor.Primary
      ] [ str "Submit" ]
    ]
  ]


let private view' (classes: IClasses) model dispatch =
  div [] [
    // Alert dialog
    button [
      OnClick (fun _ -> OpenDialog Alert |> dispatch)
      MaterialProp.Color ComponentColor.Primary
    ] [ str "Open alert dialog" ]
    typography [ Paragraph true ] [ str "Alert response is "; str (string model.AlertResponse) ]
    alertDialog model dispatch

    // Select dialog
    button [
      OnClick (fun _ -> OpenDialog Select |> dispatch)
      MaterialProp.Color ComponentColor.Primary
    ] [ str "Open select dialog" ]
    typography [ Paragraph true ] [ str "Select response is "; str (string model.SelectResponse) ]
    selectDialog model dispatch

    // Form dialog
    button [
      OnClick (fun _ -> OpenDialog Form |> dispatch)
      MaterialProp.Color ComponentColor.Primary
    ] [ str "Open form dialog" ]
    typography [ Paragraph true ] [ str "Form response is "; str (string model.FormResponse) ]
    formDialog model dispatch
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
