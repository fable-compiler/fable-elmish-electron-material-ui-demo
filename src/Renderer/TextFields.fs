module TextFields

open System
open Fable.React
open Feliz
open Feliz.MaterialUI

let required s =
  if String.IsNullOrEmpty s then Error "Please enter a value" else Ok s

let validInt s =
  match Int32.TryParse s with
  | true, i -> Ok i
  | false, _ -> Error "Please enter a valid integer"

let mustBe target i =
  if i = target then Ok i else sprintf "Please enter %i" target |> Error

let validate =
  required
  >> Result.bind validInt
  >> Result.bind (mustBe 42)


type Model =
  { SimpleText: string
    ValidatedTextRaw: string
    ValidatedTextResult: Result<int, string> }

    // Notes on validation:
    //
    // Raw value should always be in Elmish model to support domain validation,
    // but it's optional to keep the validation result here.
    //
    // Benefits of having validation result in model:
    //   The validation result is only calculated once, so it's more performant
    //   without needing memoization or similar, and there is less chance of
    //   calling the wrong validation function (imagine if you have 10 validated
    //   fields and lots of places in the view function that need the validated value).
    //
    // Drawbacks of having validation result in model:
    //   The validation result represent duplicated state (since it's derivable
    //   from the raw value), so there is increased possibility of invalid state
    //   where ValidatedTextRaw and ValidatedTextResult are not updated together
    //   (not a likely problem here, since it only happens for one message).
    //
    // To avoid the drawbacks above, one could also create separate records for
    // all validated values, containing the raw and validated value, and only
    // creatable through a function that performs the validation. This could lead
    // to lots of types, though.

type Msg =
  | SetSimpleText of string
  | SetValidatedText of string

let init () =
  { SimpleText = ""
    ValidatedTextRaw = ""
    ValidatedTextResult = validate "" }

let update msg m =
  match msg with
  | SetSimpleText s -> { m with SimpleText = s }
  | SetValidatedText s -> { m with ValidatedTextRaw = s; ValidatedTextResult = validate s }


// Domain/Elmish above, view below


let private useStyles = Styles.makeStyles(fun theme ->
  {|
    form = Styles.create [
      style.flexWrap.wrap
    ]
    textField = Styles.create [
      style.marginLeft (theme.spacing 1)
      style.marginRight (theme.spacing 1)
      style.width 200
    ]
  |}
)

let TextFieldPage = FunctionComponent.Of((fun (model, dispatch) ->
  let c = useStyles ()
  Html.form [
    prop.onSubmit preventDefault
    prop.className c.form
    prop.children [
      Mui.textField [
        prop.className c.textField
        textField.label "Simple input"
        textField.value model.SimpleText
        textField.onChange (SetSimpleText >> dispatch)
        textField.helperText ["Current value: "; model.SimpleText]
      ]
      Mui.textField [
        prop.className c.textField
        textField.label "Validated input"
        textField.required true
        textField.value model.ValidatedTextRaw
        textField.error model.ValidatedTextResult.IsError
        textField.onChange (SetValidatedText >> dispatch)
        textField.helperText (model.ValidatedTextResult.ErrorOr "Value OK")
      ]
    ]
  ]
), "TextFieldPage", memoEqualsButFunctions)
