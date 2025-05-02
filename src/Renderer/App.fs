module App

open Electron
open Elmish
open Elmish.React
open Fable.Core.JsInterop
open Fable.React
open Feliz
open Feliz.MaterialUI
open Fable.MaterialUI.Icons
open Fable.MaterialUI.MaterialDesignIcons


type Page =
  | Home
  | Autocomplete
  | Badges
  | Dialogs
  | SaveLoad
  | Selects
  | Snackbars
  | StaticAssets
  | TextFields
  static member All =
    [ Home; Autocomplete; Badges; Dialogs; SaveLoad; Selects;
      Snackbars; StaticAssets; TextFields ]

let pageTitle = function
  | Home -> "Home"
  | Autocomplete -> "Autocomplete"
  | Badges -> "Badges"
  | Dialogs -> "Dialogs"
  | SaveLoad -> "Save/load"
  | Selects -> "Selects"
  | StaticAssets -> "Static assets"
  | Snackbars -> "Snackbars"
  | TextFields -> "Text fields"

type ThemeMode =
  | Light
  | Dark

type Msg =
  | Navigate of Page
  | SetSystemThemeMode of ThemeMode
  | ToggleCustomThemeMode
  | AutoCompleteMsg of Autocomplete.Msg
  | BadgesMsg of Badges.Msg
  | DialogsMsg of Dialogs.Msg
  | SaveLoadMsg of SaveLoad.Msg
  | SelectsMsg of Selects.Msg
  | SnackbarsMsg of Snackbars.Msg
  | TextFieldsMsg of TextFields.Msg

type Model =
  { Page: Page
    SystemThemeMode: ThemeMode
    CustomThemeMode: ThemeMode option
    Autocomplete: Autocomplete.Model
    Badges: Badges.Model
    Dialogs: Dialogs.Model
    SaveLoad: SaveLoad.Model
    Selects: Selects.Model
    Snackbars: Snackbars.Model
    TextFields: TextFields.Model }

let update msg m =
  match msg with
  | Navigate p ->
      { m with Page = p }, Cmd.none
  | SetSystemThemeMode mode ->
      { m with SystemThemeMode = mode }, Cmd.none
  | ToggleCustomThemeMode ->
      { m with
          CustomThemeMode =
            match m.CustomThemeMode with
            | None -> Some Dark
            | Some Dark -> Some Light
            | Some Light -> None
      }, Cmd.none
  | AutoCompleteMsg msg' ->
      { m with Autocomplete = Autocomplete.update msg' m.Autocomplete }, Cmd.none
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


module Theme =


  // Not used, but shows how to use style and prop overrides. The returned theme
  // can for example be used as the `theme` prop of `Mui.muiThemeProvider`.
  let example = Styles.createMuiTheme([
    theme.palette.type'.dark
    theme.palette.primary Colors.blueGrey
    theme.palette.secondary Colors.purple

    // Globally override component styles
    theme.overrides.muiButtonBase.root [
      style.fontWeight.bold
      style.inner "&$disabled" [
        style.backgroundColor.aquaMarine
      ]
    ]
    theme.overrides.muiAvatar.img [
      style.borderWidth 10
      style.borderColor.black
      style.borderStyle.solid
    ]

    // Globally override component props
    theme.props.muiButton [
      button.size.small
    ]
    theme.props.muiDialog [
      dialog.fullScreen true
    ]

  ])



  let light = Styles.createMuiTheme([
    theme.palette.type'.light
    theme.palette.primary Colors.indigo
    theme.palette.secondary Colors.pink
  ])

  let dark = Styles.createMuiTheme([
    theme.palette.type'.dark
    theme.palette.primary Colors.lightBlue
    theme.palette.secondary Colors.pink
    theme.props.muiAppBar [
      appBar.color.default'
    ]
  ])


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
  | Autocomplete -> Autocomplete.AutocompletePage(model.Autocomplete, AutoCompleteMsg >> dispatch)
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


let private useToolbarTyles = Styles.makeStyles(fun styles theme ->
  {|
    appBarTitle = styles.create [
      style.flexGrow 1
    ]
  |}
)

let Toolbar = FunctionComponent.Of((fun (page, customThemeMode, dispatch) ->
  let c = useToolbarTyles ()
  Mui.toolbar [
    Mui.typography [
      typography.variant.h6
      typography.color.inherit'
      typography.children (pageTitle page)
      typography.classes.root c.appBarTitle
    ]
    Mui.tooltip [
      tooltip.title(
        match customThemeMode with
        | None -> "Using system light/dark theme"
        | Some Light -> "Using light theme"
        | Some Dark -> "Using dark theme"
      )
      tooltip.children(
        Mui.iconButton [
          prop.onClick (fun _ -> dispatch ToggleCustomThemeMode)
          iconButton.color.inherit'
          iconButton.children [
            match customThemeMode with
            | None -> brightnessAutoIcon []
            | Some Light -> brightness7Icon []
            | Some Dark -> brightness4Icon []
          ]
        ]
      )
    ]
  ]
), "Toolbar", memoEqualsButFunctions)


let private useRootViewStyles = Styles.makeStyles(fun styles theme ->
  let drawerWidth = 240
  {|
    root = styles.create (fun model -> [
      style.display.flex
      style.userSelect.none
      if model.Page = Home then style.color Colors.green.``300``
    ])
    appBar = styles.create [
      style.zIndex (theme.zIndex.drawer + 1)
    ]
    appBarTitle = styles.create [
      style.flexGrow 1
    ]
    drawer = styles.create [
      style.width (length.px drawerWidth)
      style.flexShrink 0
    ]
    drawerPaper = styles.create [
      style.width (length.px drawerWidth)
      // Example of breakpoint media queries
      style.inner theme.breakpoints.downXs [
        style.backgroundColor.red
      ]
    ]
    content = styles.create [
      style.flexGrow 1
      style.padding (theme.spacing 3)
    ]
    toolbar = styles.create [
      yield! theme.mixins.toolbar
    ]
  |}
)

let RootView = FunctionComponent.Of((fun (model, dispatch) ->
  let c = useRootViewStyles model
  Mui.themeProvider [
    themeProvider.theme (
      match model.CustomThemeMode |> Option.defaultValue model.SystemThemeMode with
      | Dark -> Theme.dark
      | Light -> Theme.light
    )
    themeProvider.children [
      Html.div [
        prop.className c.root
        prop.children [
          Mui.cssBaseline []
          Mui.appBar [
            appBar.classes.root c.appBar
            appBar.position.fixed'
            appBar.children [
              Toolbar(model.Page, model.CustomThemeMode, dispatch)
            ]
          ]
          Mui.drawer [
            drawer.variant.permanent
            drawer.classes.root c.drawer
            drawer.classes.paper c.drawerPaper
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
    ]
  ]
), "RootView", memoEqualsButFunctions)

let updateSystemTheme dispatch =
   dispatch (SetSystemThemeMode Light)
  // let dispatchCurrentMode () =
  //   if renderer.remote.nativeTheme.shouldUseDarkColors
  //   then dispatch (SetSystemThemeMode Dark)
  //   else dispatch (SetSystemThemeMode Light)
  // renderer.remote.nativeTheme.onUpdated(fun _ -> dispatchCurrentMode ()) |> ignore
  // dispatchCurrentMode ()

let init () =
  let m =
    { Page = Home
      SystemThemeMode = Light
      CustomThemeMode = None
      Autocomplete = Autocomplete.init ()
      Badges = Badges.init ()
      Dialogs = Dialogs.init ()
      SaveLoad = SaveLoad.init ()
      Selects = Selects.init ()
      Snackbars = Snackbars.init ()
      TextFields = TextFields.init () }
  m, Cmd.ofSub updateSystemTheme

let view model dispatch =
  RootView (model, dispatch)
