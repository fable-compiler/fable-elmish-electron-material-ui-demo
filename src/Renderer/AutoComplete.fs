module AutoComplete

open System
open Browser.Types
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.MatchSorter
open Fable.Import.Downshift
open Fable.React
open Fable.React.Props
open Fable.MaterialUI
open Fable.MaterialUI.Core
open Fable.MaterialUI.Props


type Country =
  { Id: Guid
    Name: string
    Description: string }


let matchSortCountries =
  MSOpts.empty
  |> MSOpts.addKeySpec (KeySpec.create (fun c -> c.Name))
  |> MSOpts.withThreshold Ranking.Contains
  |> matchSortWith


type Model =
  { Countries: Country list
    MyText: string
    LastSelected: Country option }

type Msg =
  | SetText of string
  | Select of Guid

let init () =
  { Countries =
      ["Afghanistan"; "Aland Islands"; "Albania"; "Algeria"; "American Samoa"; "Andorra"; "Angola"; "Anguilla"; "Antarctica"; "Antigua and Barbuda"; "Argentina"; "Armenia"; "Aruba"; "Australia"; "Austria"; "Azerbaijan"]
      |> List.map (fun s ->
        { Id = Guid.NewGuid(); Name = s; Description = sprintf "Description of %s" s }
      )
    MyText = ""
    LastSelected = None }

let update msg m =
  match msg with
  | SetText s -> { m with MyText = s }
  | Select s -> { m with LastSelected = m.Countries |> List.tryFind (fun x -> x.Id = s) }


let private styles (theme: ITheme) : IStyles list =
  [
    Styles.Custom ("formControl", [
      MarginBottom (theme.spacing.unit * 2)
    ])
    Styles.Custom ("menu", [
      MaxHeight "500px"
      Overflow "auto"
    ])
    Styles.Custom ("noResults", [
      CSSProp.Padding (theme.spacing.unit * 2)
    ])
    Styles.Custom ("selectedItem", [
      CSSProp.FontWeight "bold"
    ])
    Styles.Custom ("highlight", [
      CSSProp.FontWeight "bold"
    ])
  ]

let mutable private textFieldRef = null

let private view' (classes: IClasses) model dispatch =
  div [] [
    typography [ Paragraph true ] [ str "Autocomplete control implemented using downshift, autosuggest-highlight, and popper." ]
    typography [ Paragraph true ] [ str "Downshift behavior configured to emulate free-text entry with autocomplete (does not revert to empty string or selected item)." ]
    form [ OnSubmit (fun e -> e.preventDefault()) ] [
      formControl [ Class classes?formControl ] [
        downshift [
          OnInputValueChange (fun s _ -> SetText s |> dispatch)
          InputValue model.MyText
          ItemToString (function Some e -> e.Name | None -> "")
          // OnChange, SelectedItem, and StateReducer used like below will enable
          // dispatching actions when an item is selected, but otherwise keep normal
          // input behavior (the default Downshift behavior is to revert the
          // input value to empty or the selected item on blur.)
          DownshiftProps.OnChange (fun item _ -> Select item.Id |> dispatch)
          SelectedItem None
          StateReducer (fun s c ->
            match c.``type`` with
            // This list of change types might not be exhaustive
            | StateChangeTypes.BlurInput
            | StateChangeTypes.MouseUp
            | StateChangeTypes.KeyDownEscape ->
                c.inputValue <- s.inputValue
            | _ -> ()
            upcast c
          )
        ] (fun ds ->
          let filteredCountries = model.Countries |> matchSortCountries ds.inputValue
          div [] [
            textField (ds.getInputProps [
              Label (str "Country name")
              HelperText (str "Start with 'a'")
              OnFocus(fun ev -> textFieldRef <- ev.target)
            ]) []
            div (ds.getMenuProps []) [
              popper [
                Class classes?menu
                MaterialProp.Open ds.isOpen
                Placement PlacementType.TopStart
                AnchorEl !^textFieldRef
              ] !^[
                paper [ ] [
                  list [] (
                    if not ds.isOpen then []
                    elif filteredCountries.IsEmpty then
                      [ listItem [] [ typography [] [ str "No results" ] ] ]
                    else
                      filteredCountries |> List.mapi (fun i e ->
                        listItem
                          (ds.getItemProps e [
                            Index i
                            ListItemProp.Button true
                            HTMLAttr.Selected (ds.highlightedIndex = Some i)
                          ]) [
                            listItemText [
                              Classes [
                                if ds.selectedItem |> Option.map (fun e -> e.Id) = Some e.Id then
                                  yield ClassNames.Primary classes?selectedItem
                              ]
                              ListItemTextProp.Primary (
                                e.Name
                                |> AutosuggestHighlight.getParts ds.inputValue
                                |> List.map (fun (s, hl) -> span [ if hl then yield Class classes?highlight ] [ str s ] )
                                |> fragment []
                              )
                              ListItemTextProp.Secondary (str e.Description)
                            ] [ ]
                          ]
                      )
                  )
                ]
              ]
            ]
          ]
        )
      ]
      typography [] [
        str "Latest selected country: "
        model.LastSelected |> Option.map (fun c -> c.Name) |> Option.defaultValue "none" |> str
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
  let viewWithStyles = withStyles (StyleType.Func styles) [] viewFun
  override this.render() = ReactElementType.create viewWithStyles this.props []


let view (model: Model) (dispatch: Msg -> unit) : ReactElement =
  let props = jsOptions<IProps>(fun p ->
    p.model <- model
    p.dispatch <- dispatch)
  ofType<Component,_,_> props []
