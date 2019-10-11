module Selects

open System
open Fable.React
open Feliz
open Feliz.MaterialUI


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
      [ {Id = Guid.NewGuid (); Name = "Entity 1"; Description = "Description for entity 1"}
        {Id = Guid.NewGuid (); Name = "Entity 2"; Description = "Description for entity 2"} ]
    SelectedId = None }

let update msg m =
  match msg with
  | SelectEntity eid -> { m with SelectedId = eid }


// Domain/Elmish above, view below

let private useStyles = Styles.makeStyles(fun theme ->
  {|
    formControl = Styles.create [
      style.minWidth (length.px 120)
    ]
  |}
)

let private selectItem e =
  Mui.menuItem [
    prop.key e.Id
    prop.value (unbox<string> e.Id)
    menuItem.children [
      Html.div [
        Mui.typography e.Name
        Mui.typography [
          typography.variant.caption
          typography.children e.Description
        ]
      ]
    ]
  ]

let SelectsPage = FunctionComponent.Of((fun (model, dispatch: Elmish.Dispatch<Msg>) ->
  let c = useStyles ()
  Html.form [
    prop.onSubmit preventDefault
    prop.children [
      Mui.formControl [
        prop.className c.formControl
        formControl.required true
        formControl.error model.SelectedId.IsNone
        formControl.children [
          Mui.inputLabel "Entity"
          Mui.select [
            select.value (emptyStringIfNone model.SelectedId)
            select.onChange (SelectEntity >> dispatch)
            select.children [
              model.Entities
              |> List.sortBy (fun e -> e.Name)
              |> List.map selectItem
              |> ofList
            ]
          ]
          Mui.formHelperText
            (if model.SelectedId.IsNone then "Please select a value" else "Value OK")
        ]
      ]
    ]
  ]
), "SelectsPage", memoEqualsButFunctions)
