module Dialogs

open Fable.React
open Feliz
open Feliz.MaterialUI


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


let private AlertDialog = FunctionComponent.Of((fun(model, dispatch) ->
  Mui.dialog [
    dialog.open' (model.CurrentDialog = Some Alert)
    dialog.onClose (fun _ _ -> dispatch AbortDialog)
    dialog.children [
      Mui.dialogTitle "Do you agree?"
      Mui.dialogContent [
        Mui.dialogContentText "Please indicate whether you agree."
      ]
      Mui.dialogActions [
        Mui.button [
          prop.onClick (fun _ -> SetAlertResponse false |> dispatch)
          button.color.primary
          button.children "Disagree"
        ]
        Mui.button [
          prop.onClick (fun _ -> SetAlertResponse true |> dispatch)
          button.color.primary
          button.children "Agree"
        ]
      ]
    ]
  ]
), "AlertDialog")


let private SelectDialog = FunctionComponent.Of((fun(model, dispatch) ->
  Mui.dialog [
    dialog.open' (model.CurrentDialog = Some Select)
    dialog.onClose (fun _ _ -> dispatch AbortDialog)
    dialog.children [
      Mui.dialogTitle "Choose an option"
      Mui.list [
        model.AvailableSelectValues |> List.map (fun value ->
          Mui.listItem [
            prop.key value
            prop.onClick (fun _ -> SetSelectResponse value |> dispatch)
            listItem.button true
            listItem.children [ Mui.listItemText value ]
          ]
        ) |> ofList
      ]
    ]
  ]
), "SelectDialog")


let private FormDialog = FunctionComponent.Of((fun(model, dispatch) ->
  Mui.dialog [
    dialog.open' (model.CurrentDialog = Some Form)
    dialog.onClose (fun _ _ -> dispatch AbortDialog)
    dialog.children [
      Mui.dialogTitle "Write your response"
      Mui.dialogContent [
        Mui.dialogContentText "Please enter your response in the form below."
        Mui.textField [
          textField.autoFocus true
          textField.margin.dense
          textField.label "Your response"
          textField.fullWidth true
          textField.onChange (FormTextEntered >> dispatch)
        ]
      ]
      Mui.dialogActions [
        Mui.button [
          prop.onClick (fun _ -> dispatch AbortDialog)
          button.color.primary
          button.children "Cancel"
        ]
        Mui.button [
          prop.onClick (fun _ -> dispatch ConfirmFormDialog)
          button.color.primary
          button.children "Submit"
        ]
      ]
    ]
  ]
), "FormDialog")


let DialogsPage = FunctionComponent.Of((fun (model, dispatch) ->
  Html.div [
    // Alert dialog
    Mui.button [
      prop.onClick (fun _ -> OpenDialog Alert |> dispatch)
      button.color.primary
      button.children "Open alert dialog"
    ]
    Mui.typography [
      typography.paragraph true
      typography.children ["Alert response is "; string model.AlertResponse]
    ]
    AlertDialog(model, dispatch)

    // Select dialog
    Mui.button [
      prop.onClick (fun _ -> OpenDialog Select |> dispatch)
      button.color.primary
      button.children "Open select dialog"
    ]
    Mui.typography [
      typography.paragraph true
      typography.children ["Select response is "; string model.SelectResponse]
    ]
    SelectDialog(model, dispatch)

    // Form dialog
    Mui.button [
      prop.onClick (fun _ -> OpenDialog Form |> dispatch)
      button.color.primary
      button.children "Open form dialog"
    ]
    Mui.typography [
      typography.paragraph true
      typography.children ["Form response is "; string model.FormResponse]
    ]
    FormDialog(model, dispatch)
  ]
), "DialogsPage", memoEqualsButFunctions)
