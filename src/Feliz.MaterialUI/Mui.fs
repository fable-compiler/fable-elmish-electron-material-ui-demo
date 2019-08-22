namespace Feliz.MaterialUI

//////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
//////////////////////////////////

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

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline appBar = createElement (importDefault "@material-ui/core/AppBar")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline avatar = createElement (importDefault "@material-ui/core/Avatar")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline backdrop = createElement (importDefault "@material-ui/core/Backdrop")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline badge = createElement (importDefault "@material-ui/core/Badge")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline bottomNavigation = createElement (importDefault "@material-ui/core/BottomNavigation")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline bottomNavigationAction = createElement (importDefault "@material-ui/core/BottomNavigationAction")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline breadcrumbs = createElement (importDefault "@material-ui/core/Breadcrumbs")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline button = createElement (importDefault "@material-ui/core/Button")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline buttonBase = createElement (importDefault "@material-ui/core/ButtonBase")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline buttonGroup = createElement (importDefault "@material-ui/core/ButtonGroup")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline card = createElement (importDefault "@material-ui/core/Card")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline cardActionArea = createElement (importDefault "@material-ui/core/CardActionArea")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline cardActions = createElement (importDefault "@material-ui/core/CardActions")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline cardContent = createElement (importDefault "@material-ui/core/CardContent")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline cardHeader = createElement (importDefault "@material-ui/core/CardHeader")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline cardMedia = createElement (importDefault "@material-ui/core/CardMedia")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline checkbox = createElement (importDefault "@material-ui/core/Checkbox")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline chip = createElement (importDefault "@material-ui/core/Chip")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline circularProgress = createElement (importDefault "@material-ui/core/CircularProgress")

  /// The component cannot hold a ref.
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline clickAwayListener = createElement (importDefault "@material-ui/core/ClickAwayListener")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline collapse = createElement (importDefault "@material-ui/core/Collapse")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline container = createElement (importDefault "@material-ui/core/Container")

  /// The component cannot hold a ref.
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline cssBaseline = createElement (importDefault "@material-ui/core/CssBaseline")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Modal](https://material-ui.com/api/modal/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline dialog = createElement (importDefault "@material-ui/core/Dialog")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline dialogActions = createElement (importDefault "@material-ui/core/DialogActions")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline dialogContent = createElement (importDefault "@material-ui/core/DialogContent")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline dialogContentText = createElement (importDefault "@material-ui/core/DialogContentText")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline dialogTitle = createElement (importDefault "@material-ui/core/DialogTitle")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline divider = createElement (importDefault "@material-ui/core/Divider")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline drawer = createElement (importDefault "@material-ui/core/Drawer")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline expansionPanel = createElement (importDefault "@material-ui/core/ExpansionPanel")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline expansionPanelActions = createElement (importDefault "@material-ui/core/ExpansionPanelActions")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline expansionPanelDetails = createElement (importDefault "@material-ui/core/ExpansionPanelDetails")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline expansionPanelSummary = createElement (importDefault "@material-ui/core/ExpansionPanelSummary")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline fab = createElement (importDefault "@material-ui/core/Fab")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline fade = createElement (importDefault "@material-ui/core/Fade")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline filledInput = createElement (importDefault "@material-ui/core/FilledInput")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline formControl = createElement (importDefault "@material-ui/core/FormControl")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline formControlLabel = createElement (importDefault "@material-ui/core/FormControlLabel")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline formGroup = createElement (importDefault "@material-ui/core/FormGroup")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline formHelperText = createElement (importDefault "@material-ui/core/FormHelperText")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline formLabel = createElement (importDefault "@material-ui/core/FormLabel")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline grid = createElement (importDefault "@material-ui/core/Grid")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline gridList = createElement (importDefault "@material-ui/core/GridList")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline gridListTile = createElement (importDefault "@material-ui/core/GridListTile")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline gridListTileBar = createElement (importDefault "@material-ui/core/GridListTileBar")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline grow = createElement (importDefault "@material-ui/core/Grow")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline hidden = createElement (importDefault "@material-ui/core/Hidden")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline icon = createElement (importDefault "@material-ui/core/Icon")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline iconButton = createElement (importDefault "@material-ui/core/IconButton")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline input = createElement (importDefault "@material-ui/core/Input")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline inputAdornment = createElement (importDefault "@material-ui/core/InputAdornment")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline inputBase = createElement (importDefault "@material-ui/core/InputBase")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormLabel](https://material-ui.com/api/form-label/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline inputLabel = createElement (importDefault "@material-ui/core/InputLabel")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline linearProgress = createElement (importDefault "@material-ui/core/LinearProgress")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline link = createElement (importDefault "@material-ui/core/Link")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline list = createElement (importDefault "@material-ui/core/List")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline listItem = createElement (importDefault "@material-ui/core/ListItem")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline listItemAvatar = createElement (importDefault "@material-ui/core/ListItemAvatar")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline listItemIcon = createElement (importDefault "@material-ui/core/ListItemIcon")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline listItemSecondaryAction = createElement (importDefault "@material-ui/core/ListItemSecondaryAction")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline listItemText = createElement (importDefault "@material-ui/core/ListItemText")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline listSubheader = createElement (importDefault "@material-ui/core/ListSubheader")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Popover](https://material-ui.com/api/popover/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline menu = createElement (importDefault "@material-ui/core/Menu")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ListItem](https://material-ui.com/api/list-item/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline menuItem = createElement (importDefault "@material-ui/core/MenuItem")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([List](https://material-ui.com/api/list/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline menuList = createElement (importDefault "@material-ui/core/MenuList")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline mobileStepper = createElement (importDefault "@material-ui/core/MobileStepper")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline modal = createElement (importDefault "@material-ui/core/Modal")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Input](https://material-ui.com/api/input/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline nativeSelect = createElement (importDefault "@material-ui/core/NativeSelect")

  /// The component cannot hold a ref.
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline noSsr = createElement (importDefault "@material-ui/core/NoSsr")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline outlinedInput = createElement (importDefault "@material-ui/core/OutlinedInput")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline paper = createElement (importDefault "@material-ui/core/Paper")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Modal](https://material-ui.com/api/modal/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline popover = createElement (importDefault "@material-ui/core/Popover")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline popper = createElement (importDefault "@material-ui/core/Popper")

  /// The component cannot hold a ref.
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline portal = createElement (importDefault "@material-ui/core/Portal")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline radio = createElement (importDefault "@material-ui/core/Radio")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormGroup](https://material-ui.com/api/form-group/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline radioGroup = createElement (importDefault "@material-ui/core/RadioGroup")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline rating = createElement (importDefault "@material-ui/lab/Rating")

  /// The component cannot hold a ref.
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline rootRef = createElement (importDefault "@material-ui/core/RootRef")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Input](https://material-ui.com/api/input/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline select = createElement (importDefault "@material-ui/core/Select")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline skeleton = createElement (importDefault "@material-ui/lab/Skeleton")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline slide = createElement (importDefault "@material-ui/core/Slide")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline slider = createElement (importDefault "@material-ui/core/Slider")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline snackbar = createElement (importDefault "@material-ui/core/Snackbar")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline snackbarContent = createElement (importDefault "@material-ui/core/SnackbarContent")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline speedDial = createElement (importDefault "@material-ui/lab/SpeedDial")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element ([Tooltip](https://material-ui.com/api/tooltip/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline speedDialAction = createElement (importDefault "@material-ui/lab/SpeedDialAction")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline speedDialIcon = createElement (importDefault "@material-ui/lab/SpeedDialIcon")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline step = createElement (importDefault "@material-ui/core/Step")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline stepButton = createElement (importDefault "@material-ui/core/StepButton")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline stepConnector = createElement (importDefault "@material-ui/core/StepConnector")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline stepContent = createElement (importDefault "@material-ui/core/StepContent")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline stepIcon = createElement (importDefault "@material-ui/core/StepIcon")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline stepLabel = createElement (importDefault "@material-ui/core/StepLabel")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline stepper = createElement (importDefault "@material-ui/core/Stepper")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline svgIcon = createElement (importDefault "@material-ui/core/SvgIcon")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Drawer](https://material-ui.com/api/drawer/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline swipeableDrawer = createElement (importDefault "@material-ui/core/SwipeableDrawer")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline switch = createElement (importDefault "@material-ui/core/Switch")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline tab = createElement (importDefault "@material-ui/core/Tab")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline table = createElement (importDefault "@material-ui/core/Table")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline tableBody = createElement (importDefault "@material-ui/core/TableBody")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline tableCell = createElement (importDefault "@material-ui/core/TableCell")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline tableFooter = createElement (importDefault "@material-ui/core/TableFooter")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline tableHead = createElement (importDefault "@material-ui/core/TableHead")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([TableCell](https://material-ui.com/api/table-cell/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline tablePagination = createElement (importDefault "@material-ui/core/TablePagination")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline tableRow = createElement (importDefault "@material-ui/core/TableRow")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline tableSortLabel = createElement (importDefault "@material-ui/core/TableSortLabel")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline tabs = createElement (importDefault "@material-ui/core/Tabs")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline textareaAutosize = createElement (importDefault "@material-ui/core/TextareaAutosize")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormControl](https://material-ui.com/api/form-control/)).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline textField = createElement (importDefault "@material-ui/core/TextField")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline toggleButton = createElement (importDefault "@material-ui/lab/ToggleButton")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline toggleButtonGroup = createElement (importDefault "@material-ui/lab/ToggleButtonGroup")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline toolbar = createElement (importDefault "@material-ui/core/Toolbar")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline tooltip = createElement (importDefault "@material-ui/core/Tooltip")

  /// The `ref` is attached to an Imperative Handle. Have a look at the [implementation of the component](https://github.com/mui-org/material-ui/blob/master/packages/material-ui/src/ButtonBase/TouchRipple.js) for more detail.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline touchRipple = createElement (importDefault "@material-ui/core/ButtonBase/TouchRipple.js/TouchRipple")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline treeItem = createElement (importDefault "@material-ui/lab/TreeItem")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline treeView = createElement (importDefault "@material-ui/lab/TreeView")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  ///
  /// The component is fully [StrictMode](https://reactjs.org/docs/strict-mode.html) compatible.
  static member inline typography = createElement (importDefault "@material-ui/core/Typography")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  ///
  /// The component can cause issues in [StrictMode](https://reactjs.org/docs/strict-mode.html).
  static member inline zoom = createElement (importDefault "@material-ui/core/Zoom")

