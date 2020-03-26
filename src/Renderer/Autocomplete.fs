module Autocomplete

open System
open Fable.Import
open Fable.Import.MatchSorter
open Fable.React
open Feliz
open Feliz.MaterialUI


type Country =
  { Id: Guid
    Name: string
    Description: string }


let matchSortCountries : string -> Country [] -> Country list =
  MSOpts.empty
  |> MSOpts.addKeySpec (KeySpec.create (fun c -> c.Name))
  |> MSOpts.withThreshold Ranking.Contains
  |> matchSortWith

type Model =
  { Countries: Country []
    MyText: string
    LastSelected: Guid option }

let lastSelectedCountry model =
  model.LastSelected
  |> Option.bind (fun cid -> model.Countries |> Array.tryFind (fun c -> c.Id = cid))

type Msg =
  | SetText of string
  | Select of Guid

let init () =
  { Countries =
      [|"Afghanistan"; "Aland Islands"; "Albania"; "Algeria"; "American Samoa"; "Andorra"; "Angola"; "Anguilla"; "Antarctica"; "Antigua and Barbuda"; "Argentina"; "Armenia"; "Aruba"; "Australia"; "Austria"; "Azerbaijan"|]
      |> Array.map (fun s ->
        { Id = Guid.NewGuid(); Name = s; Description = sprintf "Description of %s" s }
      )
    MyText = ""
    LastSelected = None }

let update msg m =
  match msg with
  | SetText s -> { m with MyText = s }
  | Select s ->
      { m with
          LastSelected =
            m.Countries |> Array.tryPick (fun x -> if x.Id = s then Some x.Id else None)
      }


let private useStyles = Styles.makeStyles(fun styles theme ->
  {|
    formControl = styles.create [
      style.marginBottom (theme.spacing 2)
    ]
    textField = styles.create [
      style.width (length.px 400)
    ]
    //menu = styles.create [
    //  style.maxHeight (length.px 500)
    //  style.overflow.auto
    //]
    //noResults = styles.create [
    //  style.padding (theme.spacing 2)
    //]
    //selectedItem = styles.create [
    //  style.fontWeight.bold
    //]
    highlight = styles.create [
      style.fontWeight.bold
    ]
  |}
)


let filterOptions options input =
  matchSortCountries input options |> List.toArray


let AutocompletePage = FunctionComponent.Of((fun (model, dispatch) ->
  let c = useStyles ()
  Html.div [
    Mui.typography [
      typography.paragraph true
      typography.children "Autocomplete control implemented using Material-UI's Autocomplete with autosuggest-highlight and match-sorter."
    ]
    Mui.typography [
      typography.paragraph true
      typography.children "The behavior is configured with free-solo mode to emulate free-text entry with autocomplete (does not revert to empty string or selected item)."
    ]
    Html.form [
      prop.onSubmit preventDefault
      prop.children [
        Mui.formControl [
          formControl.classes.root c.formControl
          formControl.children [
            Mui.autocomplete [
              autocomplete.options model.Countries
              autocomplete.getOptionLabel (function Some e -> e.Name | None -> "")
              autocomplete.freeSolo true
              autocomplete.onInputChange (SetText >> dispatch)
              autocomplete.inputValue model.MyText
              autocomplete.disableClearable true
              autocomplete.filterOptions filterOptions
              autocomplete.renderInput (fun props ->
                Mui.textField [
                  yield! props.felizProps
                  textField.classes.root c.textField
                ]
              )
              autocomplete.onChange (fun item -> Select item.Id |> dispatch)
              autocomplete.value (lastSelectedCountry model)
              autocomplete.renderOption(fun option state ->
                let parts = AutosuggestHighlight.getParts state.inputValue option.Name
                Mui.listItem [
                  Mui.listItemText [
                    listItemText.primary (
                      parts |> List.mapi (fun i (s, highlighted) ->
                        Html.span [
                          prop.key i
                          if highlighted then prop.className c.highlight
                          prop.text s
                        ]
                      )
                    )
                    listItemText.secondary option.Description
                  ]
                ]
              )
            ]
          ]
        ]
        Mui.typography [
          typography.children [
            Html.text "Latest selected country: "
            Html.text (lastSelectedCountry model |> Option.map (fun c -> c.Name) |> Option.defaultValue "none")
          ]
        ]
      ]
    ]
  ]
), "AutocompletePage", memoEqualsButFunctions)
