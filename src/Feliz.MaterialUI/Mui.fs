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
  static member inline appBar = createElement (importDefault "@material-ui/core/AppBar';// orimport{ AppBar }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline avatar = createElement (importDefault "@material-ui/core/Avatar';// orimport{ Avatar }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline backdrop = createElement (importDefault "@material-ui/core/Backdrop';// orimport{ Backdrop }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline badge = createElement (importDefault "@material-ui/core/Badge';// orimport{ Badge }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline bottomNavigation = createElement (importDefault "@material-ui/core/BottomNavigation';// orimport{ BottomNavigation }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline bottomNavigationAction = createElement (importDefault "@material-ui/core/BottomNavigationAction';// orimport{ BottomNavigationAction }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline breadcrumbs = createElement (importDefault "@material-ui/core/Breadcrumbs';// orimport{ Breadcrumbs }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline button = createElement (importDefault "@material-ui/core/Button';// orimport{ Button }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline buttonBase = createElement (importDefault "@material-ui/core/ButtonBase';// orimport{ ButtonBase }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline buttonGroup = createElement (importDefault "@material-ui/core/ButtonGroup';// orimport{ ButtonGroup }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline card = createElement (importDefault "@material-ui/core/Card';// orimport{ Card }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline cardActionArea = createElement (importDefault "@material-ui/core/CardActionArea';// orimport{ CardActionArea }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardActions = createElement (importDefault "@material-ui/core/CardActions';// orimport{ CardActions }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardContent = createElement (importDefault "@material-ui/core/CardContent';// orimport{ CardContent }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardHeader = createElement (importDefault "@material-ui/core/CardHeader';// orimport{ CardHeader }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline cardMedia = createElement (importDefault "@material-ui/core/CardMedia';// orimport{ CardMedia }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  static member inline checkbox = createElement (importDefault "@material-ui/core/Checkbox';// orimport{ Checkbox }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline chip = createElement (importDefault "@material-ui/core/Chip';// orimport{ Chip }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline circularProgress = createElement (importDefault "@material-ui/core/CircularProgress';// orimport{ CircularProgress }from'@material-ui/core")

  /// The component cannot hold a ref.
  static member inline clickAwayListener = createElement (importDefault "@material-ui/core/ClickAwayListener';// orimport{ ClickAwayListener }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline collapse = createElement (importDefault "@material-ui/core/Collapse';// orimport{ Collapse }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline container = createElement (importDefault "@material-ui/core/Container';// orimport{ Container }from'@material-ui/core")

  /// The component cannot hold a ref.
  static member inline cssBaseline = createElement (importDefault "@material-ui/core/CssBaseline';// orimport{ CssBaseline }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Modal](https://material-ui.com/api/modal/)).
  static member inline dialog = createElement (importDefault "@material-ui/core/Dialog';// orimport{ Dialog }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogActions = createElement (importDefault "@material-ui/core/DialogActions';// orimport{ DialogActions }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogContent = createElement (importDefault "@material-ui/core/DialogContent';// orimport{ DialogContent }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  static member inline dialogContentText = createElement (importDefault "@material-ui/core/DialogContentText';// orimport{ DialogContentText }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline dialogTitle = createElement (importDefault "@material-ui/core/DialogTitle';// orimport{ DialogTitle }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline divider = createElement (importDefault "@material-ui/core/Divider';// orimport{ Divider }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline drawer = createElement (importDefault "@material-ui/core/Drawer';// orimport{ Drawer }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline expansionPanel = createElement (importDefault "@material-ui/core/ExpansionPanel';// orimport{ ExpansionPanel }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline expansionPanelActions = createElement (importDefault "@material-ui/core/ExpansionPanelActions';// orimport{ ExpansionPanelActions }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline expansionPanelDetails = createElement (importDefault "@material-ui/core/ExpansionPanelDetails';// orimport{ ExpansionPanelDetails }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline expansionPanelSummary = createElement (importDefault "@material-ui/core/ExpansionPanelSummary';// orimport{ ExpansionPanelSummary }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline fab = createElement (importDefault "@material-ui/core/Fab';// orimport{ Fab }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline fade = createElement (importDefault "@material-ui/core/Fade';// orimport{ Fade }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  static member inline filledInput = createElement (importDefault "@material-ui/core/FilledInput';// orimport{ FilledInput }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formControl = createElement (importDefault "@material-ui/core/FormControl';// orimport{ FormControl }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formControlLabel = createElement (importDefault "@material-ui/core/FormControlLabel';// orimport{ FormControlLabel }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formGroup = createElement (importDefault "@material-ui/core/FormGroup';// orimport{ FormGroup }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formHelperText = createElement (importDefault "@material-ui/core/FormHelperText';// orimport{ FormHelperText }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline formLabel = createElement (importDefault "@material-ui/core/FormLabel';// orimport{ FormLabel }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline grid = createElement (importDefault "@material-ui/core/Grid';// orimport{ Grid }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline gridList = createElement (importDefault "@material-ui/core/GridList';// orimport{ GridList }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline gridListTile = createElement (importDefault "@material-ui/core/GridListTile';// orimport{ GridListTile }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline gridListTileBar = createElement (importDefault "@material-ui/core/GridListTileBar';// orimport{ GridListTileBar }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline grow = createElement (importDefault "@material-ui/core/Grow';// orimport{ Grow }from'@material-ui/core")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline hidden = createElement (importDefault "@material-ui/core/Hidden';// orimport{ Hidden }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline icon = createElement (importDefault "@material-ui/core/Icon';// orimport{ Icon }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline iconButton = createElement (importDefault "@material-ui/core/IconButton';// orimport{ IconButton }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  static member inline input = createElement (importDefault "@material-ui/core/Input';// orimport{ Input }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline inputAdornment = createElement (importDefault "@material-ui/core/InputAdornment';// orimport{ InputAdornment }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline inputBase = createElement (importDefault "@material-ui/core/InputBase';// orimport{ InputBase }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormLabel](https://material-ui.com/api/form-label/)).
  static member inline inputLabel = createElement (importDefault "@material-ui/core/InputLabel';// orimport{ InputLabel }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline linearProgress = createElement (importDefault "@material-ui/core/LinearProgress';// orimport{ LinearProgress }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Typography](https://material-ui.com/api/typography/)).
  static member inline link = createElement (importDefault "@material-ui/core/Link';// orimport{ Link }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline list = createElement (importDefault "@material-ui/core/List';// orimport{ List }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItem = createElement (importDefault "@material-ui/core/ListItem';// orimport{ ListItem }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemAvatar = createElement (importDefault "@material-ui/core/ListItemAvatar';// orimport{ ListItemAvatar }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemIcon = createElement (importDefault "@material-ui/core/ListItemIcon';// orimport{ ListItemIcon }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemSecondaryAction = createElement (importDefault "@material-ui/core/ListItemSecondaryAction';// orimport{ ListItemSecondaryAction }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listItemText = createElement (importDefault "@material-ui/core/ListItemText';// orimport{ ListItemText }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline listSubheader = createElement (importDefault "@material-ui/core/ListSubheader';// orimport{ ListSubheader }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Popover](https://material-ui.com/api/popover/)).
  static member inline menu = createElement (importDefault "@material-ui/core/Menu';// orimport{ Menu }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ListItem](https://material-ui.com/api/list-item/)).
  static member inline menuItem = createElement (importDefault "@material-ui/core/MenuItem';// orimport{ MenuItem }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([List](https://material-ui.com/api/list/)).
  static member inline menuList = createElement (importDefault "@material-ui/core/MenuList';// orimport{ MenuList }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline mobileStepper = createElement (importDefault "@material-ui/core/MobileStepper';// orimport{ MobileStepper }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline modal = createElement (importDefault "@material-ui/core/Modal';// orimport{ Modal }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Input](https://material-ui.com/api/input/)).
  static member inline nativeSelect = createElement (importDefault "@material-ui/core/NativeSelect';// orimport{ NativeSelect }from'@material-ui/core")

  /// The component cannot hold a ref.
  static member inline noSsr = createElement (importDefault "@material-ui/core/NoSsr';// orimport{ NoSsr }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([InputBase](https://material-ui.com/api/input-base/)).
  static member inline outlinedInput = createElement (importDefault "@material-ui/core/OutlinedInput';// orimport{ OutlinedInput }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline paper = createElement (importDefault "@material-ui/core/Paper';// orimport{ Paper }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Modal](https://material-ui.com/api/modal/)).
  static member inline popover = createElement (importDefault "@material-ui/core/Popover';// orimport{ Popover }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline popper = createElement (importDefault "@material-ui/core/Popper';// orimport{ Popper }from'@material-ui/core")

  /// The component cannot hold a ref.
  static member inline portal = createElement (importDefault "@material-ui/core/Portal';// orimport{ Portal }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  static member inline radio = createElement (importDefault "@material-ui/core/Radio';// orimport{ Radio }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormGroup](https://material-ui.com/api/form-group/)).
  static member inline radioGroup = createElement (importDefault "@material-ui/core/RadioGroup';// orimport{ RadioGroup }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline rating = createElement (importDefault "@material-ui/lab/Rating';// orimport{ Rating }from'@material-ui/lab")

  /// The component cannot hold a ref.
  static member inline rootRef = createElement (importDefault "@material-ui/core/RootRef';// orimport{ RootRef }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Input](https://material-ui.com/api/input/)).
  static member inline select = createElement (importDefault "@material-ui/core/Select';// orimport{ Select }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline skeleton = createElement (importDefault "@material-ui/lab/Skeleton';// orimport{ Skeleton }from'@material-ui/lab")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline slide = createElement (importDefault "@material-ui/core/Slide';// orimport{ Slide }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline slider = createElement (importDefault "@material-ui/core/Slider';// orimport{ Slider }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline snackbar = createElement (importDefault "@material-ui/core/Snackbar';// orimport{ Snackbar }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline snackbarContent = createElement (importDefault "@material-ui/core/SnackbarContent';// orimport{ SnackbarContent }from'@material-ui/core")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline speedDial = createElement (importDefault "@material-ui/lab/SpeedDial';// orimport{ SpeedDial }from'@material-ui/lab")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element ([Tooltip](https://material-ui.com/api/tooltip/)).
  static member inline speedDialAction = createElement (importDefault "@material-ui/lab/SpeedDialAction';// orimport{ SpeedDialAction }from'@material-ui/lab")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline speedDialIcon = createElement (importDefault "@material-ui/lab/SpeedDialIcon';// orimport{ SpeedDialIcon }from'@material-ui/lab")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline step = createElement (importDefault "@material-ui/core/Step';// orimport{ Step }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline stepButton = createElement (importDefault "@material-ui/core/StepButton';// orimport{ StepButton }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepConnector = createElement (importDefault "@material-ui/core/StepConnector';// orimport{ StepConnector }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepContent = createElement (importDefault "@material-ui/core/StepContent';// orimport{ StepContent }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepIcon = createElement (importDefault "@material-ui/core/StepIcon';// orimport{ StepIcon }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline stepLabel = createElement (importDefault "@material-ui/core/StepLabel';// orimport{ StepLabel }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Paper](https://material-ui.com/api/paper/)).
  static member inline stepper = createElement (importDefault "@material-ui/core/Stepper';// orimport{ Stepper }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline svgIcon = createElement (importDefault "@material-ui/core/SvgIcon';// orimport{ SvgIcon }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Drawer](https://material-ui.com/api/drawer/)).
  static member inline swipeableDrawer = createElement (importDefault "@material-ui/core/SwipeableDrawer';// orimport{ SwipeableDrawer }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([IconButton](https://material-ui.com/api/icon-button/)).
  static member inline switch = createElement (importDefault "@material-ui/core/Switch';// orimport{ Switch }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline tab = createElement (importDefault "@material-ui/core/Tab';// orimport{ Tab }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline table = createElement (importDefault "@material-ui/core/Table';// orimport{ Table }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableBody = createElement (importDefault "@material-ui/core/TableBody';// orimport{ TableBody }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableCell = createElement (importDefault "@material-ui/core/TableCell';// orimport{ TableCell }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableFooter = createElement (importDefault "@material-ui/core/TableFooter';// orimport{ TableFooter }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableHead = createElement (importDefault "@material-ui/core/TableHead';// orimport{ TableHead }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([TableCell](https://material-ui.com/api/table-cell/)).
  static member inline tablePagination = createElement (importDefault "@material-ui/core/TablePagination';// orimport{ TablePagination }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tableRow = createElement (importDefault "@material-ui/core/TableRow';// orimport{ TableRow }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline tableSortLabel = createElement (importDefault "@material-ui/core/TableSortLabel';// orimport{ TableSortLabel }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tabs = createElement (importDefault "@material-ui/core/Tabs';// orimport{ Tabs }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline textareaAutosize = createElement (importDefault "@material-ui/core/TextareaAutosize';// orimport{ TextareaAutosize }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([FormControl](https://material-ui.com/api/form-control/)).
  static member inline textField = createElement (importDefault "@material-ui/core/TextField';// orimport{ TextField }from'@material-ui/core")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element ([ButtonBase](https://material-ui.com/api/button-base/)).
  static member inline toggleButton = createElement (importDefault "@material-ui/lab/ToggleButton';// orimport{ ToggleButton }from'@material-ui/lab")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline toggleButtonGroup = createElement (importDefault "@material-ui/lab/ToggleButtonGroup';// orimport{ ToggleButtonGroup }from'@material-ui/lab")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline toolbar = createElement (importDefault "@material-ui/core/Toolbar';// orimport{ Toolbar }from'@material-ui/core")

  /// The component cannot hold a ref.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline tooltip = createElement (importDefault "@material-ui/core/Tooltip';// orimport{ Tooltip }from'@material-ui/core")

  /// The `ref` is attached to an Imperative Handle. Have a look at the [implementation of the component](https://github.com/mui-org/material-ui/blob/master/packages/material-ui/src/ButtonBase/TouchRipple.js) for more detail.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline touchRipple = createElement (importDefault "@material-ui/core/ButtonBase/TouchRipple.js/TouchRipple';// orimport{ TouchRipple }from'@material-ui/core/ButtonBase/TouchRipple.js")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline treeItem = createElement (importDefault "@material-ui/lab/TreeItem';// orimport{ TreeItem }from'@material-ui/lab")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline treeView = createElement (importDefault "@material-ui/lab/TreeView';// orimport{ TreeView }from'@material-ui/lab")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element (native element).
  static member inline typography = createElement (importDefault "@material-ui/core/Typography';// orimport{ Typography }from'@material-ui/core")

  /// The `ref` is forwarded to the root element.
  ///
  /// Any other props supplied will be provided to the root element ([Transition](https://reactcommunity.org/react-transition-group/transition/#Transition-props)).
  static member inline zoom = createElement (importDefault "@material-ui/core/Zoom';// orimport{ Zoom }from'@material-ui/core")

