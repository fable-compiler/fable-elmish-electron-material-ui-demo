namespace Feliz.MaterialUI

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz

[<AutoOpen>]
module MuiHelpers =

  [<System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>]
  let reactElement (el: ReactElementType) (props: 'a) : ReactElement =
    import "createElement" "react"

  [<System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>]
  let createElement (el: ReactElementType) (properties: IReactProperty list) : ReactElement =
    reactElement el (createObj !!properties)

[<Erase>]
type Mui =

  static member inline muiThemeProvider props = createElement (importDefault "@material-ui/core/styles/MuiThemeProvider") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline appBar props = createElement (importDefault "@material-ui/core/AppBar") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline avatar props = createElement (importDefault "@material-ui/core/Avatar") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline backdrop props = createElement (importDefault "@material-ui/core/Backdrop") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline badge props = createElement (importDefault "@material-ui/core/Badge") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline bottomNavigation props = createElement (importDefault "@material-ui/core/BottomNavigation") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline bottomNavigationAction props = createElement (importDefault "@material-ui/core/BottomNavigationAction") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline breadcrumbs props = createElement (importDefault "@material-ui/core/Breadcrumbs") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline button props = createElement (importDefault "@material-ui/core/Button") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline buttonBase props = createElement (importDefault "@material-ui/core/ButtonBase") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline buttonGroup props = createElement (importDefault "@material-ui/core/ButtonGroup") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline card props = createElement (importDefault "@material-ui/core/Card") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline cardActionArea props = createElement (importDefault "@material-ui/core/CardActionArea") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardActions props = createElement (importDefault "@material-ui/core/CardActions") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardContent props = createElement (importDefault "@material-ui/core/CardContent") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardHeader props = createElement (importDefault "@material-ui/core/CardHeader") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardMedia props = createElement (importDefault "@material-ui/core/CardMedia") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  static member inline checkbox props = createElement (importDefault "@material-ui/core/Checkbox") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline chip props = createElement (importDefault "@material-ui/core/Chip") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline circularProgress props = createElement (importDefault "@material-ui/core/CircularProgress") props

  /// The component cannot hold a ref.
  static member inline clickAwayListener props = createElement (importDefault "@material-ui/core/ClickAwayListener") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline collapse props = createElement (importDefault "@material-ui/core/Collapse") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline container props = createElement (importDefault "@material-ui/core/Container") props

  /// The component cannot hold a ref.
  static member inline cssBaseline props = createElement (importDefault "@material-ui/core/CssBaseline") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Modal](https://material-ui.com/api/modal/)).
  static member inline dialog props = createElement (importDefault "@material-ui/core/Dialog") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogActions props = createElement (importDefault "@material-ui/core/DialogActions") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogContent props = createElement (importDefault "@material-ui/core/DialogContent") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  static member inline dialogContentText props = createElement (importDefault "@material-ui/core/DialogContentText") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  static member inline dialogContentText (text: string) = createElement (importDefault "@material-ui/core/DialogContentText") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogTitle props = createElement (importDefault "@material-ui/core/DialogTitle") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogTitle (text: string) = createElement (importDefault "@material-ui/core/DialogTitle") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline divider props = createElement (importDefault "@material-ui/core/Divider") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline drawer props = createElement (importDefault "@material-ui/core/Drawer") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline expansionPanel props = createElement (importDefault "@material-ui/core/ExpansionPanel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline expansionPanelActions props = createElement (importDefault "@material-ui/core/ExpansionPanelActions") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline expansionPanelDetails props = createElement (importDefault "@material-ui/core/ExpansionPanelDetails") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline expansionPanelSummary props = createElement (importDefault "@material-ui/core/ExpansionPanelSummary") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline fab props = createElement (importDefault "@material-ui/core/Fab") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline fade props = createElement (importDefault "@material-ui/core/Fade") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  static member inline filledInput props = createElement (importDefault "@material-ui/core/FilledInput") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formControl props = createElement (importDefault "@material-ui/core/FormControl") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formControlLabel props = createElement (importDefault "@material-ui/core/FormControlLabel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formGroup props = createElement (importDefault "@material-ui/core/FormGroup") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formHelperText props = createElement (importDefault "@material-ui/core/FormHelperText") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formHelperText (text: string) = createElement (importDefault "@material-ui/core/FormHelperText") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formLabel props = createElement (importDefault "@material-ui/core/FormLabel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formLabel (text: string) = createElement (importDefault "@material-ui/core/FormLabel") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline grid props = createElement (importDefault "@material-ui/core/Grid") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline gridList props = createElement (importDefault "@material-ui/core/GridList") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline gridListTile props = createElement (importDefault "@material-ui/core/GridListTile") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline gridListTileBar props = createElement (importDefault "@material-ui/core/GridListTileBar") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline grow props = createElement (importDefault "@material-ui/core/Grow") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline hidden props = createElement (importDefault "@material-ui/core/Hidden") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline icon props = createElement (importDefault "@material-ui/core/Icon") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline icon (name: string) = createElement (importDefault "@material-ui/core/Icon") [ prop.children (Html.text name) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline iconButton props = createElement (importDefault "@material-ui/core/IconButton") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  static member inline input props = createElement (importDefault "@material-ui/core/Input") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline inputAdornment props = createElement (importDefault "@material-ui/core/InputAdornment") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline inputBase props = createElement (importDefault "@material-ui/core/InputBase") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormLabel](https://material-ui.com/api/form-label/)).
  static member inline inputLabel props = createElement (importDefault "@material-ui/core/InputLabel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormLabel](https://material-ui.com/api/form-label/)).
  static member inline inputLabel (text: string) = createElement (importDefault "@material-ui/core/InputLabel") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline linearProgress props = createElement (importDefault "@material-ui/core/LinearProgress") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  static member inline link props = createElement (importDefault "@material-ui/core/Link") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline list props = createElement (importDefault "@material-ui/core/List") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItem props = createElement (importDefault "@material-ui/core/ListItem") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemAvatar props = createElement (importDefault "@material-ui/core/ListItemAvatar") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemIcon props = createElement (importDefault "@material-ui/core/ListItemIcon") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemSecondaryAction props = createElement (importDefault "@material-ui/core/ListItemSecondaryAction") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemText props = createElement (importDefault "@material-ui/core/ListItemText") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemText (primary: string) = createElement (importDefault "@material-ui/core/ListItemText") [ listItemText.primary primary ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listSubheader props = createElement (importDefault "@material-ui/core/ListSubheader") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listSubheader (text: string) = createElement (importDefault "@material-ui/core/ListSubheader") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Popover](https://material-ui.com/api/popover/)).
  static member inline menu props = createElement (importDefault "@material-ui/core/Menu") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ListItem](https://material-ui.com/api/list-item/)).
  static member inline menuItem props = createElement (importDefault "@material-ui/core/MenuItem") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([List](https://material-ui.com/api/list/)).
  static member inline menuList props = createElement (importDefault "@material-ui/core/MenuList") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline mobileStepper props = createElement (importDefault "@material-ui/core/MobileStepper") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline modal props = createElement (importDefault "@material-ui/core/Modal") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Input](https://material-ui.com/api/input/)).
  static member inline nativeSelect props = createElement (importDefault "@material-ui/core/NativeSelect") props

  /// The component cannot hold a ref.
  static member inline noSsr props = createElement (importDefault "@material-ui/core/NoSsr") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  static member inline outlinedInput props = createElement (importDefault "@material-ui/core/OutlinedInput") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline paper props = createElement (importDefault "@material-ui/core/Paper") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Modal](https://material-ui.com/api/modal/)).
  static member inline popover props = createElement (importDefault "@material-ui/core/Popover") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline popper props = createElement (importDefault "@material-ui/core/Popper") props

  /// The component cannot hold a ref.
  static member inline portal props = createElement (importDefault "@material-ui/core/Portal") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  static member inline radio props = createElement (importDefault "@material-ui/core/Radio") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormGroup](https://material-ui.com/api/form-group/)).
  static member inline radioGroup props = createElement (importDefault "@material-ui/core/RadioGroup") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline rating props = createElement (importDefault "@material-ui/lab/Rating") props

  /// The component cannot hold a ref.
  static member inline rootRef props = createElement (importDefault "@material-ui/core/RootRef") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Input](https://material-ui.com/api/input/)).
  static member inline select props = createElement (importDefault "@material-ui/core/Select") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline skeleton props = createElement (importDefault "@material-ui/lab/Skeleton") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline slide props = createElement (importDefault "@material-ui/core/Slide") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline slider props = createElement (importDefault "@material-ui/core/Slider") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline snackbar props = createElement (importDefault "@material-ui/core/Snackbar") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline snackbarContent props = createElement (importDefault "@material-ui/core/SnackbarContent") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline speedDial props = createElement (importDefault "@material-ui/lab/SpeedDial") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element ([Tooltip](https://material-ui.com/api/tooltip/)).
  static member inline speedDialAction props = createElement (importDefault "@material-ui/lab/SpeedDialAction") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline speedDialIcon props = createElement (importDefault "@material-ui/lab/SpeedDialIcon") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline step props = createElement (importDefault "@material-ui/core/Step") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline stepButton props = createElement (importDefault "@material-ui/core/StepButton") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepConnector props = createElement (importDefault "@material-ui/core/StepConnector") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepContent props = createElement (importDefault "@material-ui/core/StepContent") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepIcon props = createElement (importDefault "@material-ui/core/StepIcon") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepLabel props = createElement (importDefault "@material-ui/core/StepLabel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepLabel (text: string) = createElement (importDefault "@material-ui/core/StepLabel") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline stepper props = createElement (importDefault "@material-ui/core/Stepper") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline svgIcon props = createElement (importDefault "@material-ui/core/SvgIcon") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Drawer](https://material-ui.com/api/drawer/)).
  static member inline swipeableDrawer props = createElement (importDefault "@material-ui/core/SwipeableDrawer") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  static member inline switch props = createElement (importDefault "@material-ui/core/Switch") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline tab props = createElement (importDefault "@material-ui/core/Tab") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline table props = createElement (importDefault "@material-ui/core/Table") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableBody props = createElement (importDefault "@material-ui/core/TableBody") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableCell props = createElement (importDefault "@material-ui/core/TableCell") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableCell (text: string) = createElement (importDefault "@material-ui/core/TableCell") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableFooter props = createElement (importDefault "@material-ui/core/TableFooter") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableHead props = createElement (importDefault "@material-ui/core/TableHead") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([TableCell](https://material-ui.com/api/table-cell/)).
  static member inline tablePagination props = createElement (importDefault "@material-ui/core/TablePagination") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableRow props = createElement (importDefault "@material-ui/core/TableRow") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline tableSortLabel props = createElement (importDefault "@material-ui/core/TableSortLabel") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tabs props = createElement (importDefault "@material-ui/core/Tabs") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline textareaAutosize props = createElement (importDefault "@material-ui/core/TextareaAutosize") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormControl](https://material-ui.com/api/form-control/)).
  static member inline textField props = createElement (importDefault "@material-ui/core/TextField") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline toggleButton props = createElement (importDefault "@material-ui/lab/ToggleButton") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline toggleButtonGroup props = createElement (importDefault "@material-ui/lab/ToggleButtonGroup") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline toolbar props = createElement (importDefault "@material-ui/core/Toolbar") props

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tooltip props = createElement (importDefault "@material-ui/core/Tooltip") props

  /// The `ref` is attached to an Imperative Handle. Have a look at the [implementation of the component](https://github.com/mui-org/material-ui/blob/master/packages/material-ui/src/ButtonBase/TouchRipple.js) for more detail.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline touchRipple props = createElement (importDefault "@material-ui/core/ButtonBase/TouchRipple.js/TouchRipple") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline treeItem props = createElement (importDefault "@material-ui/lab/TreeItem") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline treeView props = createElement (importDefault "@material-ui/lab/TreeView") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline typography props = createElement (importDefault "@material-ui/core/Typography") props

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline typography (text: string) = createElement (importDefault "@material-ui/core/Typography") [ prop.children (Html.text text) ]

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline zoom props = createElement (importDefault "@material-ui/core/Zoom") props

