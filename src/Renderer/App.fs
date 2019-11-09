module App

open Elmish
open Elmish.React
open Fable.Core.JsInterop
open Fable.React
open Feliz
open Feliz.MaterialUI


type Page =
  | Home
  | AutoComplete
  | Badges
  | Dialogs
  | SaveLoad
  | Selects
  | Snackbars
  | StaticAssets
  | TextFields
  static member All =
    [ Home; AutoComplete; Badges; Dialogs; SaveLoad; Selects;
      Snackbars; StaticAssets; TextFields ]

let pageTitle = function
  | Home -> "Home"
  | AutoComplete -> "Autocomplete"
  | Badges -> "Badges"
  | Dialogs -> "Dialogs"
  | SaveLoad -> "Save/load"
  | Selects -> "Selects"
  | StaticAssets -> "Static assets"
  | Snackbars -> "Snackbars"
  | TextFields -> "Text fields"

type Msg =
  | Navigate of Page
  | AutoCompleteMsg of AutoComplete.Msg
  | BadgesMsg of Badges.Msg
  | DialogsMsg of Dialogs.Msg
  | SaveLoadMsg of SaveLoad.Msg
  | SelectsMsg of Selects.Msg
  | SnackbarsMsg of Snackbars.Msg
  | TextFieldsMsg of TextFields.Msg

type Model =
  { Page: Page
    AutoCompleteDownshift: AutoComplete.Model
    Badges: Badges.Model
    Dialogs: Dialogs.Model
    SaveLoad: SaveLoad.Model
    Selects: Selects.Model
    Snackbars: Snackbars.Model
    TextFields: TextFields.Model }

let init () =
  let m =
    { Page = Home
      AutoCompleteDownshift = AutoComplete.init ()
      Badges = Badges.init ()
      Dialogs = Dialogs.init ()
      SaveLoad = SaveLoad.init ()
      Selects = Selects.init ()
      Snackbars = Snackbars.init ()
      TextFields = TextFields.init () }
  m, Cmd.none

let update msg m =
  match msg with
  | Navigate p ->
      { m with Page = p }, Cmd.none
  | AutoCompleteMsg msg' ->
      { m with AutoCompleteDownshift = AutoComplete.update msg' m.AutoCompleteDownshift }, Cmd.none
  | BadgesMsg msg' ->
      { m with Badges = Badges.update msg' m.Badges }, Cmd.none
  | DialogsMsg msg' ->
      { m with Dialogs = Dialogs.update msg' m.Dialogs }, Cmd.none
  | SaveLoadMsg msg' ->
      let m', cmd = SaveLoad.update msg' m.SaveLoad
      { m with SaveLoad = m' }, Cmd.map SaveLoadMsg cmd
  | SelectsMsg msg' ->
      { m with Selects = Selects.update msg' m.Selects }, Cmd.none
  | SnackbarsMsg msg' ->
      let m', cmd = Snackbars.update msg' m.Snackbars
      { m with Snackbars = m' }, Cmd.map SnackbarsMsg cmd
  | TextFieldsMsg msg' ->
      { m with TextFields = TextFields.update msg' m.TextFields }, Cmd.none


// Domain/Elmish above, view below


let private useStyles = Styles.makeStyles(fun theme ->
  let drawerWidth = 240
  {|
    root = Styles.create (fun model -> [
      style.display.flex
      style.userSelect.none
      if model.Page = Home then style.color Colors.green.``300``
    ])
    appBar = Styles.create [
      style.zIndex (theme.zIndex.drawer + 1)
    ]
    drawer = Styles.create [
      style.width (length.px drawerWidth)
      style.flexShrink 0
    ]
    drawerPaper = Styles.create [
      style.width (length.px drawerWidth)
      // Example of breakpoint media queries
      style.inner theme.breakpoints.downXs [
        style.backgroundColor.red
      ]
    ]
    content = Styles.create [
      style.flexGrow 1
      style.padding (theme.spacing 3)
    ]
    toolbar = Styles.create [
      yield! theme.mixins.toolbarStyles
    ]
  |}
)


// Not used, but shows how to use style and prop overrides. The returned theme
// can for example be used as the `theme` prop of `Mui.muiThemeProvider`.
let theme = Styles.createMuiTheme(jsOptions<Theme>(fun t ->
  t.palette <- jsOptions<Palette>(fun p ->
    p.``type`` <- PaletteType.Dark
    p.primary <- !^Colors.blueGrey
    p.secondary <- !^Colors.purple
  )

  // Globally override component styles
  t.setOverrides [
    overrides.muiButtonBase [
      overrides.muiButtonBase.root [
        style.fontWeight.bold
        style.inner "&$disabled" [
          style.backgroundColor.aquaMarine
        ]
      ]
    ]
    overrides.muiAvatar [
      overrides.muiAvatar.img [
        style.borderWidth 10
        style.borderColor.black
        style.borderStyle.solid
      ]
    ]
  ]

  // Globally override component props
  t.setProps [
    themeProps.muiButton [
      button.size.small
    ]
    themeProps.muiDialog [
      dialog.fullScreen true
    ]
  ]
))



let private pageListItem model dispatch page =
  Mui.listItem [
    prop.key (pageTitle page)
    prop.onClick (fun _ -> Navigate page |> dispatch)
    listItem.button true
    listItem.divider ((page = Home))
    listItem.selected (model.Page = page)
    listItem.children [
      Mui.listItemText (pageTitle page)
    ]
  ]

let private pageView model dispatch =
  match model.Page with
  | Home -> Mui.typography "This app contains simple demos showing how certain Material-UI components can be used with Elmish."
  | AutoComplete -> lazyView2 AutoComplete.view model.AutoCompleteDownshift (AutoCompleteMsg >> dispatch)
  | Badges -> Badges.BadgesPage(model.Badges, BadgesMsg >> dispatch)
  | Dialogs -> Dialogs.DialogsPage(model.Dialogs, DialogsMsg >> dispatch)
  | SaveLoad -> SaveLoad.SaveLoadPage (model.SaveLoad, SaveLoadMsg >> dispatch)
  | Selects -> Selects.SelectsPage (model.Selects, SelectsMsg >> dispatch)
  | Snackbars -> Snackbars.SnackbarPage (model.Snackbars, SnackbarsMsg >> dispatch)
  | StaticAssets ->
      Html.div [
        Mui.typography [
          typography.paragraph true
          typography.children (str "This demo shows how to use static assets such as images.")
        ]
        Mui.avatar [
          avatar.src (getStatic "avatar.jpg")
        ]
      ]
  | TextFields -> TextFields.TextFieldPage (model.TextFields, TextFieldsMsg >> dispatch)


let RootView = FunctionComponent.Of((fun (model, dispatch) ->
  let c = useStyles model
  Html.div [
    prop.className c.root
    prop.children [
      Mui.cssBaseline []
      Mui.appBar [
        prop.className c.appBar
        appBar.position.fixed'
        appBar.children [
          Mui.toolbar [
            Mui.typography [
              typography.variant.h6
              typography.color.inherit'
              typography.children (pageTitle model.Page)
            ]
          ]
        ]
      ]
      Mui.drawer [
        prop.className c.drawer
        drawer.variant.permanent
        drawer.classes [
          classes.drawer.paper c.drawerPaper
        ]
        drawer.children [
          Html.div [ prop.className c.toolbar ]
          Mui.list [
            list.component' "nav"
            list.children (Page.All |> List.map (pageListItem model dispatch) |> ofList)
          ]
        ]
      ]
      Html.main [
        prop.className c.content
        prop.children [
          Html.div [ prop.className c.toolbar ]
          pageView model dispatch
        ]
      ]
    ]
  ]
), "RootView", memoEqualsButFunctions)

let view model dispatch =
  RootView (model, dispatch)
