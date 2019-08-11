namespace Feliz.MaterialUI

open Fable.Core
open Feliz

// TODO: These are not particularly useful before we implement createMuiTheme
// and all necessary supporting stuff

// TODO: auto-generate these

type IOverrideStyles = interface end

[<Erase>]
type overrides =

  static member inline MuiAppBar styles : IOverrideStyles =
    style.inner "MuiAppBar" styles |> unbox

  static member inline MuiAvatar styles : IOverrideStyles =
    style.inner "MuiAvatar" styles |> unbox

  static member inline MuiBackdrop styles : IOverrideStyles =
    style.inner "MuiBackdrop" styles |> unbox

  static member inline MuiBadge styles : IOverrideStyles =
    style.inner "MuiBadge" styles |> unbox

  static member inline MuiBottomNavigation styles : IOverrideStyles =
    style.inner "MuiBottomNavigation" styles |> unbox

  static member inline MuiBottomNavigationAction styles : IOverrideStyles =
    style.inner "MuiBottomNavigationAction" styles |> unbox

  static member inline MuiButton styles : IOverrideStyles =
    style.inner "MuiButton" styles |> unbox

  static member inline MuiButtonBase styles : IOverrideStyles =
    style.inner "MuiButtonBase" styles |> unbox

  static member inline MuiCard styles : IOverrideStyles =
    style.inner "MuiCard" styles |> unbox

  static member inline MuiCardActionArea styles : IOverrideStyles =
    style.inner "MuiCardActionArea" styles |> unbox

  static member inline MuiCardActions styles : IOverrideStyles =
    style.inner "MuiCardActions" styles |> unbox

  static member inline MuiCardContent styles : IOverrideStyles =
    style.inner "MuiCardContent" styles |> unbox

  static member inline MuiCardHeader styles : IOverrideStyles =
    style.inner "MuiCardHeader" styles |> unbox

  static member inline MuiCardMedia styles : IOverrideStyles =
    style.inner "MuiCardMedia" styles |> unbox

  static member inline MuiCheckbox styles : IOverrideStyles =
    style.inner "MuiCheckbox" styles |> unbox

  static member inline MuiChip styles : IOverrideStyles =
    style.inner "MuiChip" styles |> unbox

  static member inline MuiCircularProgress styles : IOverrideStyles =
    style.inner "MuiCircularProgress" styles |> unbox

  static member inline MuiCollapse styles : IOverrideStyles =
    style.inner "MuiCollapse" styles |> unbox

  static member inline MuiCssBaseline styles : IOverrideStyles =
    style.inner "MuiCssBaseline" styles |> unbox

  static member inline MuiDialog styles : IOverrideStyles =
    style.inner "MuiDialog" styles |> unbox

  static member inline MuiDialogActions styles : IOverrideStyles =
    style.inner "MuiDialogActions" styles |> unbox

  static member inline MuiDialogContent styles : IOverrideStyles =
    style.inner "MuiDialogContent" styles |> unbox

  static member inline MuiDialogContentText styles : IOverrideStyles =
    style.inner "MuiDialogContentText" styles |> unbox

  static member inline MuiDialogTitle styles : IOverrideStyles =
    style.inner "MuiDialogTitle" styles |> unbox

  static member inline MuiDivider styles : IOverrideStyles =
    style.inner "MuiDivider" styles |> unbox

  static member inline MuiDrawer styles : IOverrideStyles =
    style.inner "MuiDrawer" styles |> unbox

  static member inline MuiExpansionPanel styles : IOverrideStyles =
    style.inner "MuiExpansionPanel" styles |> unbox

  static member inline MuiExpansionPanelActions styles : IOverrideStyles =
    style.inner "MuiExpansionPanelActions" styles |> unbox

  static member inline MuiExpansionPanelDetails styles : IOverrideStyles =
    style.inner "MuiExpansionPanelDetails" styles |> unbox

  static member inline MuiExpansionPanelSummary styles : IOverrideStyles =
    style.inner "MuiExpansionPanelSummary" styles |> unbox

  static member inline MuiFab styles : IOverrideStyles =
    style.inner "MuiFab" styles |> unbox

  static member inline MuiFilledInput styles : IOverrideStyles =
    style.inner "MuiFilledInput" styles |> unbox

  static member inline MuiFormControl styles : IOverrideStyles =
    style.inner "MuiFormControl" styles |> unbox

  static member inline MuiFormControlLabel styles : IOverrideStyles =
    style.inner "MuiFormControlLabel" styles |> unbox

  static member inline MuiFormGroup styles : IOverrideStyles =
    style.inner "MuiFormGroup" styles |> unbox

  static member inline MuiFormHelperText styles : IOverrideStyles =
    style.inner "MuiFormHelperText" styles |> unbox

  static member inline MuiFormLabel styles : IOverrideStyles =
    style.inner "MuiFormLabel" styles |> unbox

  static member inline MuiGrid styles : IOverrideStyles =
    style.inner "MuiGrid" styles |> unbox

  static member inline MuiGridList styles : IOverrideStyles =
    style.inner "MuiGridList" styles |> unbox

  static member inline MuiGridListTile styles : IOverrideStyles =
    style.inner "MuiGridListTile" styles |> unbox

  static member inline MuiGridListTileBar styles : IOverrideStyles =
    style.inner "MuiGridListTileBar" styles |> unbox

  static member inline MuiIcon styles : IOverrideStyles =
    style.inner "MuiIcon" styles |> unbox

  static member inline MuiIconButton styles : IOverrideStyles =
    style.inner "MuiIconButton" styles |> unbox

  static member inline MuiInput styles : IOverrideStyles =
    style.inner "MuiInput" styles |> unbox

  static member inline MuiInputAdornment styles : IOverrideStyles =
    style.inner "MuiInputAdornment" styles |> unbox

  static member inline MuiInputLabel styles : IOverrideStyles =
    style.inner "MuiInputLabel" styles |> unbox

  static member inline MuiLinearProgress styles : IOverrideStyles =
    style.inner "MuiLinearProgress" styles |> unbox

  static member inline MuiLink styles : IOverrideStyles =
    style.inner "MuiLink" styles |> unbox

  static member inline MuiList styles : IOverrideStyles =
    style.inner "MuiList" styles |> unbox

  static member inline MuiListItem styles : IOverrideStyles =
    style.inner "MuiListItem" styles |> unbox

  static member inline MuiListItemAvatar styles : IOverrideStyles =
    style.inner "MuiListItemAvatar" styles |> unbox

  static member inline MuiListItemIcon styles : IOverrideStyles =
    style.inner "MuiListItemIcon" styles |> unbox

  static member inline MuiListItemSecondaryAction styles : IOverrideStyles =
    style.inner "MuiListItemSecondaryAction" styles |> unbox

  static member inline MuiListItemText styles : IOverrideStyles =
    style.inner "MuiListItemText" styles |> unbox

  static member inline MuiListSubheader styles : IOverrideStyles =
    style.inner "MuiListSubheader" styles |> unbox

  static member inline MuiMenu styles : IOverrideStyles =
    style.inner "MuiMenu" styles |> unbox

  static member inline MuiMenuItem styles : IOverrideStyles =
    style.inner "MuiMenuItem" styles |> unbox

  static member inline MuiMobileStepper styles : IOverrideStyles =
    style.inner "MuiMobileStepper" styles |> unbox

  static member inline MuiModal styles : IOverrideStyles =
    style.inner "MuiModal" styles |> unbox

  static member inline MuiNativeSelect styles : IOverrideStyles =
    style.inner "MuiNativeSelect" styles |> unbox

  static member inline MuiOutlinedInput styles : IOverrideStyles =
    style.inner "MuiOutlinedInput" styles |> unbox

  static member inline MuiPaper styles : IOverrideStyles =
    style.inner "MuiPaper" styles |> unbox

  static member inline MuiPopover styles : IOverrideStyles =
    style.inner "MuiPopover" styles |> unbox

  static member inline MuiRadio styles : IOverrideStyles =
    style.inner "MuiRadio" styles |> unbox

  static member inline MuiSelect styles : IOverrideStyles =
    style.inner "MuiSelect" styles |> unbox

  static member inline MuiSnackbar styles : IOverrideStyles =
    style.inner "MuiSnackbar" styles |> unbox

  static member inline MuiSnackbarContent styles : IOverrideStyles =
    style.inner "MuiSnackbarContent" styles |> unbox

  static member inline MuiStep styles : IOverrideStyles =
    style.inner "MuiStep" styles |> unbox

  static member inline MuiStepButton styles : IOverrideStyles =
    style.inner "MuiStepButton" styles |> unbox

  static member inline MuiStepConnector styles : IOverrideStyles =
    style.inner "MuiStepConnector" styles |> unbox

  static member inline MuiStepContent styles : IOverrideStyles =
    style.inner "MuiStepContent" styles |> unbox

  static member inline MuiStepIcon styles : IOverrideStyles =
    style.inner "MuiStepIcon" styles |> unbox

  static member inline MuiStepLabel styles : IOverrideStyles =
    style.inner "MuiStepLabel" styles |> unbox

  static member inline MuiStepper styles : IOverrideStyles =
    style.inner "MuiStepper" styles |> unbox

  static member inline MuiSvgIcon styles : IOverrideStyles =
    style.inner "MuiSvgIcon" styles |> unbox

  static member inline MuiSwitch styles : IOverrideStyles =
    style.inner "MuiSwitch" styles |> unbox

  static member inline MuiTab styles : IOverrideStyles =
    style.inner "MuiTab" styles |> unbox

  static member inline MuiTable styles : IOverrideStyles =
    style.inner "MuiTable" styles |> unbox

  static member inline MuiTableBody styles : IOverrideStyles =
    style.inner "MuiTableBody" styles |> unbox

  static member inline MuiTableCell styles : IOverrideStyles =
    style.inner "MuiTableCell" styles |> unbox

  static member inline MuiTableFooter styles : IOverrideStyles =
    style.inner "MuiTableFooter" styles |> unbox

  static member inline MuiTablePagination styles : IOverrideStyles =
    style.inner "MuiTablePagination" styles |> unbox

  static member inline MuiTableRow styles : IOverrideStyles =
    style.inner "MuiTableRow" styles |> unbox

  static member inline MuiTableSortLabel styles : IOverrideStyles =
    style.inner "MuiTableSortLabel" styles |> unbox

  static member inline MuiTabs styles : IOverrideStyles =
    style.inner "MuiTabs" styles |> unbox

  static member inline MuiToolbar styles : IOverrideStyles =
    style.inner "MuiToolbar" styles |> unbox

  static member inline MuiTooltip styles : IOverrideStyles =
    style.inner "MuiTooltip" styles |> unbox

  static member inline MuiTouchRipple styles : IOverrideStyles =
    style.inner "MuiTouchRipple" styles |> unbox

  static member inline MuiTypography styles : IOverrideStyles =
    style.inner "MuiTypography" styles |> unbox

