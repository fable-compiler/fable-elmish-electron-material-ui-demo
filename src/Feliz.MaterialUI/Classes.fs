namespace Feliz.MaterialUI
  
(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
  
/// Override or extend the styles applied to components.
module classes =

  type IAppBarClasses = interface end

  let inline private mkAppBarClasses (key: string) (value: string) : IAppBarClasses = unbox (key, value)

  [<Erase>]
  type appBar =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkAppBarClasses "root" value
    /// Styles applied to the root element if `position="fixed"`.
    static member inline positionFixed(value: string) = mkAppBarClasses "positionFixed" value
    /// Styles applied to the root element if `position="absolute"`.
    static member inline positionAbsolute(value: string) = mkAppBarClasses "positionAbsolute" value
    /// Styles applied to the root element if `position="sticky"`.
    static member inline positionSticky(value: string) = mkAppBarClasses "positionSticky" value
    /// Styles applied to the root element if `position="static"`.
    static member inline positionStatic(value: string) = mkAppBarClasses "positionStatic" value
    /// Styles applied to the root element if `position="relative"`.
    static member inline positionRelative(value: string) = mkAppBarClasses "positionRelative" value
    /// Styles applied to the root element if `color="default"`.
    static member inline colorDefault(value: string) = mkAppBarClasses "colorDefault" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkAppBarClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) = mkAppBarClasses "colorSecondary" value


  type IAvatarClasses = interface end

  let inline private mkAvatarClasses (key: string) (value: string) : IAvatarClasses = unbox (key, value)

  [<Erase>]
  type avatar =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkAvatarClasses "root" value
    /// Styles applied to the root element if there are children and not `src` or `srcSet`.
    static member inline colorDefault(value: string) = mkAvatarClasses "colorDefault" value
    /// Styles applied to the img element if either `src` or `srcSet` is defined.
    static member inline img(value: string) = mkAvatarClasses "img" value


  type IBackdropClasses = interface end

  let inline private mkBackdropClasses (key: string) (value: string) : IBackdropClasses = unbox (key, value)

  [<Erase>]
  type backdrop =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkBackdropClasses "root" value
    /// Styles applied to the root element if `invisible={true}`.
    static member inline invisible(value: string) = mkBackdropClasses "invisible" value


  type IBadgeClasses = interface end

  let inline private mkBadgeClasses (key: string) (value: string) : IBadgeClasses = unbox (key, value)

  [<Erase>]
  type badge =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkBadgeClasses "root" value
    /// Styles applied to the badge `span` element.
    static member inline badge(value: string) = mkBadgeClasses "badge" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkBadgeClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) = mkBadgeClasses "colorSecondary" value
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: string) = mkBadgeClasses "colorError" value
    /// Styles applied to the badge `span` element if `invisible={true}`.
    static member inline invisible(value: string) = mkBadgeClasses "invisible" value
    /// Styles applied to the root element if `variant="dot"`.
    static member inline dot(value: string) = mkBadgeClasses "dot" value


  type IBottomNavigationClasses = interface end

  let inline private mkBottomNavigationClasses (key: string) (value: string) : IBottomNavigationClasses = unbox (key, value)

  [<Erase>]
  type bottomNavigation =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkBottomNavigationClasses "root" value


  type IBottomNavigationActionClasses = interface end

  let inline private mkBottomNavigationActionClasses (key: string) (value: string) : IBottomNavigationActionClasses = unbox (key, value)

  [<Erase>]
  type bottomNavigationAction =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkBottomNavigationActionClasses "root" value
    /// Pseudo-class applied to the root element if selected.
    static member inline selected(value: string) = mkBottomNavigationActionClasses "selected" value
    /// Pseudo-class applied to the root element if `showLabel={false}` and not selected.
    static member inline iconOnly(value: string) = mkBottomNavigationActionClasses "iconOnly" value
    /// Styles applied to the span element that wraps the icon and label.
    static member inline wrapper(value: string) = mkBottomNavigationActionClasses "wrapper" value
    /// Styles applied to the label's span element.
    static member inline label(value: string) = mkBottomNavigationActionClasses "label" value


  type IBreadcrumbsClasses = interface end

  let inline private mkBreadcrumbsClasses (key: string) (value: string) : IBreadcrumbsClasses = unbox (key, value)

  [<Erase>]
  type breadcrumbs =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkBreadcrumbsClasses "root" value
    /// Styles applied to the ol element.
    static member inline ol(value: string) = mkBreadcrumbsClasses "ol" value
    /// Styles applied to the li element.
    static member inline li(value: string) = mkBreadcrumbsClasses "li" value
    /// Styles applied to the separator element.
    static member inline separator(value: string) = mkBreadcrumbsClasses "separator" value


  type IButtonClasses = interface end

  let inline private mkButtonClasses (key: string) (value: string) : IButtonClasses = unbox (key, value)

  [<Erase>]
  type button =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkButtonClasses "root" value
    /// Styles applied to the span element that wraps the children.
    static member inline label(value: string) = mkButtonClasses "label" value
    /// Styles applied to the root element if `variant="text"`.
    static member inline text(value: string) = mkButtonClasses "text" value
    /// Styles applied to the root element if `variant="text"` and `color="primary"`.
    static member inline textPrimary(value: string) = mkButtonClasses "textPrimary" value
    /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
    static member inline textSecondary(value: string) = mkButtonClasses "textSecondary" value
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(value: string) = mkButtonClasses "outlined" value
    /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
    static member inline outlinedPrimary(value: string) = mkButtonClasses "outlinedPrimary" value
    /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
    static member inline outlinedSecondary(value: string) = mkButtonClasses "outlinedSecondary" value
    /// Styles applied to the root element if `variant="contained"`.
    static member inline contained(value: string) = mkButtonClasses "contained" value
    /// Styles applied to the root element if `variant="contained"` and `color="primary"`.
    static member inline containedPrimary(value: string) = mkButtonClasses "containedPrimary" value
    /// Styles applied to the root element if `variant="contained"` and `color="secondary"`.
    static member inline containedSecondary(value: string) = mkButtonClasses "containedSecondary" value
    /// Pseudo-class applied to the ButtonBase root element if the button is keyboard focused.
    static member inline focusVisible(value: string) = mkButtonClasses "focusVisible" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkButtonClasses "disabled" value
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: string) = mkButtonClasses "colorInherit" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) = mkButtonClasses "sizeSmall" value
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(value: string) = mkButtonClasses "sizeLarge" value
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: string) = mkButtonClasses "fullWidth" value


  type IButtonBaseClasses = interface end

  let inline private mkButtonBaseClasses (key: string) (value: string) : IButtonBaseClasses = unbox (key, value)

  [<Erase>]
  type buttonBase =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkButtonBaseClasses "root" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkButtonBaseClasses "disabled" value
    /// Pseudo-class applied to the root element if keyboard focused.
    static member inline focusVisible(value: string) = mkButtonBaseClasses "focusVisible" value


  type IButtonGroupClasses = interface end

  let inline private mkButtonGroupClasses (key: string) (value: string) : IButtonGroupClasses = unbox (key, value)

  [<Erase>]
  type buttonGroup =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkButtonGroupClasses "root" value
    /// Styles applied to the root element if variant="contained".
    static member inline contained(value: string) = mkButtonGroupClasses "contained" value
    /// Styles applied to the root element if fullWidth={true}.
    static member inline fullWidth(value: string) = mkButtonGroupClasses "fullWidth" value
    /// Styles applied to the children.
    static member inline grouped(value: string) = mkButtonGroupClasses "grouped" value
    /// Styles applied to the children if variant="outlined".
    static member inline groupedOutlined(value: string) = mkButtonGroupClasses "groupedOutlined" value
    /// Styles applied to the children if variant="outlined"& color="primary".
    static member inline groupedOutlinedPrimary(value: string) = mkButtonGroupClasses "groupedOutlinedPrimary" value
    /// Styles applied to the children if variant="outlined"& color="secondary".
    static member inline groupedOutlinedSecondary(value: string) = mkButtonGroupClasses "groupedOutlinedSecondary" value
    /// Styles applied to the children if variant="contained".
    static member inline groupedContained(value: string) = mkButtonGroupClasses "groupedContained" value
    /// Styles applied to the children if variant="contained"& color="primary".
    static member inline groupedContainedPrimary(value: string) = mkButtonGroupClasses "groupedContainedPrimary" value
    /// Styles applied to the children if variant="contained"& color="secondary".
    static member inline groupedContainedSecondary(value: string) = mkButtonGroupClasses "groupedContainedSecondary" value
    /// Pseudo-class applied to child elements if `disabled={true}`.
    static member inline disabled(value: string) = mkButtonGroupClasses "disabled" value


  type ICardClasses = interface end

  let inline private mkCardClasses (key: string) (value: string) : ICardClasses = unbox (key, value)

  [<Erase>]
  type card =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkCardClasses "root" value


  type ICardActionAreaClasses = interface end

  let inline private mkCardActionAreaClasses (key: string) (value: string) : ICardActionAreaClasses = unbox (key, value)

  [<Erase>]
  type cardActionArea =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkCardActionAreaClasses "root" value
    /// Pseudo-class applied to the ButtonBase root element if the action area is keyboard focused.
    static member inline focusVisible(value: string) = mkCardActionAreaClasses "focusVisible" value
    /// Styles applied to the overlay that covers the action area when it is keyboard focused.
    static member inline focusHighlight(value: string) = mkCardActionAreaClasses "focusHighlight" value


  type ICardActionsClasses = interface end

  let inline private mkCardActionsClasses (key: string) (value: string) : ICardActionsClasses = unbox (key, value)

  [<Erase>]
  type cardActions =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkCardActionsClasses "root" value
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(value: string) = mkCardActionsClasses "spacing" value


  type ICardContentClasses = interface end

  let inline private mkCardContentClasses (key: string) (value: string) : ICardContentClasses = unbox (key, value)

  [<Erase>]
  type cardContent =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkCardContentClasses "root" value


  type ICardHeaderClasses = interface end

  let inline private mkCardHeaderClasses (key: string) (value: string) : ICardHeaderClasses = unbox (key, value)

  [<Erase>]
  type cardHeader =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkCardHeaderClasses "root" value
    /// Styles applied to the avatar element.
    static member inline avatar(value: string) = mkCardHeaderClasses "avatar" value
    /// Styles applied to the action element.
    static member inline action(value: string) = mkCardHeaderClasses "action" value
    /// Styles applied to the content wrapper element.
    static member inline content(value: string) = mkCardHeaderClasses "content" value
    /// Styles applied to the title Typography element.
    static member inline title(value: string) = mkCardHeaderClasses "title" value
    /// Styles applied to the subheader Typography element.
    static member inline subheader(value: string) = mkCardHeaderClasses "subheader" value


  type ICardMediaClasses = interface end

  let inline private mkCardMediaClasses (key: string) (value: string) : ICardMediaClasses = unbox (key, value)

  [<Erase>]
  type cardMedia =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkCardMediaClasses "root" value
    /// Styles applied to the root element if `component="video, audio, picture, iframe, or img"`.
    static member inline media(value: string) = mkCardMediaClasses "media" value


  type ICheckboxClasses = interface end

  let inline private mkCheckboxClasses (key: string) (value: string) : ICheckboxClasses = unbox (key, value)

  [<Erase>]
  type checkbox =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkCheckboxClasses "root" value
    /// Pseudo-class applied to the root element if `checked={true}`.
    static member inline checked'(value: string) = mkCheckboxClasses "checked" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkCheckboxClasses "disabled" value
    /// Pseudo-class applied to the root element if `indeterminate={true}`.
    static member inline indeterminate(value: string) = mkCheckboxClasses "indeterminate" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkCheckboxClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) = mkCheckboxClasses "colorSecondary" value


  type IChipClasses = interface end

  let inline private mkChipClasses (key: string) (value: string) : IChipClasses = unbox (key, value)

  [<Erase>]
  type chip =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkChipClasses "root" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) = mkChipClasses "sizeSmall" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkChipClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) = mkChipClasses "colorSecondary" value
    /// Styles applied to the root element if `onClick` is defined or `clickable={true}`.
    static member inline clickable(value: string) = mkChipClasses "clickable" value
    /// Styles applied to the root element if `onClick` and `color="primary"` is defined or `clickable={true}`.
    static member inline clickableColorPrimary(value: string) = mkChipClasses "clickableColorPrimary" value
    /// Styles applied to the root element if `onClick` and `color="secondary"` is defined or `clickable={true}`.
    static member inline clickableColorSecondary(value: string) = mkChipClasses "clickableColorSecondary" value
    /// Styles applied to the root element if `onDelete` is defined.
    static member inline deletable(value: string) = mkChipClasses "deletable" value
    /// Styles applied to the root element if `onDelete` and `color="primary"` is defined.
    static member inline deletableColorPrimary(value: string) = mkChipClasses "deletableColorPrimary" value
    /// Styles applied to the root element if `onDelete` and `color="secondary"` is defined.
    static member inline deletableColorSecondary(value: string) = mkChipClasses "deletableColorSecondary" value
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(value: string) = mkChipClasses "outlined" value
    /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
    static member inline outlinedPrimary(value: string) = mkChipClasses "outlinedPrimary" value
    /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
    static member inline outlinedSecondary(value: string) = mkChipClasses "outlinedSecondary" value
    /// Styles applied to the `avatar` element.
    static member inline avatar(value: string) = mkChipClasses "avatar" value
    static member inline avatarSmall(value: string) = mkChipClasses "avatarSmall" value
    /// Styles applied to the `avatar` element if `color="primary"`.
    static member inline avatarColorPrimary(value: string) = mkChipClasses "avatarColorPrimary" value
    /// Styles applied to the `avatar` element if `color="secondary"`.
    static member inline avatarColorSecondary(value: string) = mkChipClasses "avatarColorSecondary" value
    /// Styles applied to the `avatar` elements children.
    static member inline avatarChildren(value: string) = mkChipClasses "avatarChildren" value
    /// Styles applied to the `icon` element.
    static member inline icon(value: string) = mkChipClasses "icon" value
    static member inline iconSmall(value: string) = mkChipClasses "iconSmall" value
    /// Styles applied to the `icon` element if `color="primary"`.
    static member inline iconColorPrimary(value: string) = mkChipClasses "iconColorPrimary" value
    /// Styles applied to the `icon` element if `color="secondary"`.
    static member inline iconColorSecondary(value: string) = mkChipClasses "iconColorSecondary" value
    /// Styles applied to the label `span` element`.
    static member inline label(value: string) = mkChipClasses "label" value
    static member inline labelSmall(value: string) = mkChipClasses "labelSmall" value
    /// Styles applied to the `deleteIcon` element.
    static member inline deleteIcon(value: string) = mkChipClasses "deleteIcon" value
    static member inline deleteIconSmall(value: string) = mkChipClasses "deleteIconSmall" value
    /// Styles applied to the deleteIcon element if `color="primary"` and `variant="default"`.
    static member inline deleteIconColorPrimary(value: string) = mkChipClasses "deleteIconColorPrimary" value
    /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="default"`.
    static member inline deleteIconColorSecondary(value: string) = mkChipClasses "deleteIconColorSecondary" value
    /// Styles applied to the deleteIcon element if `color="primary"` and `variant="outlined"`.
    static member inline deleteIconOutlinedColorPrimary(value: string) = mkChipClasses "deleteIconOutlinedColorPrimary" value
    /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="outlined"`.
    static member inline deleteIconOutlinedColorSecondary(value: string) = mkChipClasses "deleteIconOutlinedColorSecondary" value


  type ICircularProgressClasses = interface end

  let inline private mkCircularProgressClasses (key: string) (value: string) : ICircularProgressClasses = unbox (key, value)

  [<Erase>]
  type circularProgress =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkCircularProgressClasses "root" value
    /// Styles applied to the root element if `variant="static"`.
    static member inline static'(value: string) = mkCircularProgressClasses "static" value
    /// Styles applied to the root element if `variant="indeterminate"`.
    static member inline indeterminate(value: string) = mkCircularProgressClasses "indeterminate" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkCircularProgressClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) = mkCircularProgressClasses "colorSecondary" value
    /// Styles applied to the `svg` element.
    static member inline svg(value: string) = mkCircularProgressClasses "svg" value
    /// Styles applied to the `circle` svg path.
    static member inline circle(value: string) = mkCircularProgressClasses "circle" value
    /// Styles applied to the `circle` svg path if `variant="static"`.
    static member inline circleStatic(value: string) = mkCircularProgressClasses "circleStatic" value
    /// Styles applied to the `circle` svg path if `variant="indeterminate"`.
    static member inline circleIndeterminate(value: string) = mkCircularProgressClasses "circleIndeterminate" value
    /// Styles applied to the `circle` svg path if `disableShrink={true}`.
    static member inline circleDisableShrink(value: string) = mkCircularProgressClasses "circleDisableShrink" value


  type IClickAwayListenerClasses = interface end


  type ICollapseClasses = interface end

  let inline private mkCollapseClasses (key: string) (value: string) : ICollapseClasses = unbox (key, value)

  [<Erase>]
  type collapse =
    /// Styles applied to the container element.
    static member inline container(value: string) = mkCollapseClasses "container" value
    /// Styles applied to the container element when the transition has entered.
    static member inline entered(value: string) = mkCollapseClasses "entered" value
    /// Styles applied to the container element when the transition has exited and `collapsedHeight` != 0px.
    static member inline hidden(value: string) = mkCollapseClasses "hidden" value
    /// Styles applied to the outer wrapper element.
    static member inline wrapper(value: string) = mkCollapseClasses "wrapper" value
    /// Styles applied to the inner wrapper element.
    static member inline wrapperInner(value: string) = mkCollapseClasses "wrapperInner" value


  type IContainerClasses = interface end

  let inline private mkContainerClasses (key: string) (value: string) : IContainerClasses = unbox (key, value)

  [<Erase>]
  type container =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkContainerClasses "root" value
    /// Styles applied to the root element if `fixed={true}`.
    static member inline fixed'(value: string) = mkContainerClasses "fixed" value
    /// Styles applied to the root element if `maxWidth="xs"`.
    static member inline maxWidthXs(value: string) = mkContainerClasses "maxWidthXs" value
    /// Styles applied to the root element if `maxWidth="sm"`.
    static member inline maxWidthSm(value: string) = mkContainerClasses "maxWidthSm" value
    /// Styles applied to the root element if `maxWidth="md"`.
    static member inline maxWidthMd(value: string) = mkContainerClasses "maxWidthMd" value
    /// Styles applied to the root element if `maxWidth="lg"`.
    static member inline maxWidthLg(value: string) = mkContainerClasses "maxWidthLg" value
    /// Styles applied to the root element if `maxWidth="xl"`.
    static member inline maxWidthXl(value: string) = mkContainerClasses "maxWidthXl" value


  type ICssBaselineClasses = interface end


  type IDialogClasses = interface end

  let inline private mkDialogClasses (key: string) (value: string) : IDialogClasses = unbox (key, value)

  [<Erase>]
  type dialog =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkDialogClasses "root" value
    /// Styles applied to the container element if `scroll="paper"`.
    static member inline scrollPaper(value: string) = mkDialogClasses "scrollPaper" value
    /// Styles applied to the container element if `scroll="body"`.
    static member inline scrollBody(value: string) = mkDialogClasses "scrollBody" value
    /// Styles applied to the container element.
    static member inline container(value: string) = mkDialogClasses "container" value
    /// Styles applied to the `Paper` component.
    static member inline paper(value: string) = mkDialogClasses "paper" value
    /// Styles applied to the `Paper` component if `scroll="paper"`.
    static member inline paperScrollPaper(value: string) = mkDialogClasses "paperScrollPaper" value
    /// Styles applied to the `Paper` component if `scroll="body"`.
    static member inline paperScrollBody(value: string) = mkDialogClasses "paperScrollBody" value
    /// Styles applied to the `Paper` component if `maxWidth=false`.
    static member inline paperWidthFalse(value: string) = mkDialogClasses "paperWidthFalse" value
    /// Styles applied to the `Paper` component if `maxWidth="xs"`.
    static member inline paperWidthXs(value: string) = mkDialogClasses "paperWidthXs" value
    /// Styles applied to the `Paper` component if `maxWidth="sm"`.
    static member inline paperWidthSm(value: string) = mkDialogClasses "paperWidthSm" value
    /// Styles applied to the `Paper` component if `maxWidth="md"`.
    static member inline paperWidthMd(value: string) = mkDialogClasses "paperWidthMd" value
    /// Styles applied to the `Paper` component if `maxWidth="lg"`.
    static member inline paperWidthLg(value: string) = mkDialogClasses "paperWidthLg" value
    /// Styles applied to the `Paper` component if `maxWidth="xl"`.
    static member inline paperWidthXl(value: string) = mkDialogClasses "paperWidthXl" value
    /// Styles applied to the `Paper` component if `fullWidth={true}`.
    static member inline paperFullWidth(value: string) = mkDialogClasses "paperFullWidth" value
    /// Styles applied to the `Paper` component if `fullScreen={true}`.
    static member inline paperFullScreen(value: string) = mkDialogClasses "paperFullScreen" value


  type IDialogActionsClasses = interface end

  let inline private mkDialogActionsClasses (key: string) (value: string) : IDialogActionsClasses = unbox (key, value)

  [<Erase>]
  type dialogActions =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkDialogActionsClasses "root" value
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(value: string) = mkDialogActionsClasses "spacing" value


  type IDialogContentClasses = interface end

  let inline private mkDialogContentClasses (key: string) (value: string) : IDialogContentClasses = unbox (key, value)

  [<Erase>]
  type dialogContent =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkDialogContentClasses "root" value
    /// Styles applied to the root element if `dividers={true}`.
    static member inline dividers(value: string) = mkDialogContentClasses "dividers" value


  type IDialogContentTextClasses = interface end

  let inline private mkDialogContentTextClasses (key: string) (value: string) : IDialogContentTextClasses = unbox (key, value)

  [<Erase>]
  type dialogContentText =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkDialogContentTextClasses "root" value


  type IDialogTitleClasses = interface end

  let inline private mkDialogTitleClasses (key: string) (value: string) : IDialogTitleClasses = unbox (key, value)

  [<Erase>]
  type dialogTitle =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkDialogTitleClasses "root" value


  type IDividerClasses = interface end

  let inline private mkDividerClasses (key: string) (value: string) : IDividerClasses = unbox (key, value)

  [<Erase>]
  type divider =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkDividerClasses "root" value
    /// Styles applied to the root element if `absolute={true}`.
    static member inline absolute(value: string) = mkDividerClasses "absolute" value
    /// Styles applied to the root element if `variant="inset"`.
    static member inline inset(value: string) = mkDividerClasses "inset" value
    /// Styles applied to the root element if `light={true}`.
    static member inline light(value: string) = mkDividerClasses "light" value
    /// Styles applied to the root element if `variant="middle"`.
    static member inline middle(value: string) = mkDividerClasses "middle" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) = mkDividerClasses "vertical" value


  type IDrawerClasses = interface end

  let inline private mkDrawerClasses (key: string) (value: string) : IDrawerClasses = unbox (key, value)

  [<Erase>]
  type drawer =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkDrawerClasses "root" value
    /// Styles applied to the root element if `variant="permanent or persistent"`.
    static member inline docked(value: string) = mkDrawerClasses "docked" value
    /// Styles applied to the `Paper` component.
    static member inline paper(value: string) = mkDrawerClasses "paper" value
    /// Styles applied to the `Paper` component if `anchor="left"`.
    static member inline paperAnchorLeft(value: string) = mkDrawerClasses "paperAnchorLeft" value
    /// Styles applied to the `Paper` component if `anchor="right"`.
    static member inline paperAnchorRight(value: string) = mkDrawerClasses "paperAnchorRight" value
    /// Styles applied to the `Paper` component if `anchor="top"`.
    static member inline paperAnchorTop(value: string) = mkDrawerClasses "paperAnchorTop" value
    /// Styles applied to the `Paper` component if `anchor="bottom"`.
    static member inline paperAnchorBottom(value: string) = mkDrawerClasses "paperAnchorBottom" value
    /// Styles applied to the `Paper` component if `anchor="left"`&`variant` is not "temporary".
    static member inline paperAnchorDockedLeft(value: string) = mkDrawerClasses "paperAnchorDockedLeft" value
    /// Styles applied to the `Paper` component if `anchor="top"`&`variant` is not "temporary".
    static member inline paperAnchorDockedTop(value: string) = mkDrawerClasses "paperAnchorDockedTop" value
    /// Styles applied to the `Paper` component if `anchor="right"`&`variant` is not "temporary".
    static member inline paperAnchorDockedRight(value: string) = mkDrawerClasses "paperAnchorDockedRight" value
    /// Styles applied to the `Paper` component if `anchor="bottom"`&`variant` is not "temporary".
    static member inline paperAnchorDockedBottom(value: string) = mkDrawerClasses "paperAnchorDockedBottom" value
    /// Styles applied to the `Modal` component.
    static member inline modal(value: string) = mkDrawerClasses "modal" value


  type IExpansionPanelClasses = interface end

  let inline private mkExpansionPanelClasses (key: string) (value: string) : IExpansionPanelClasses = unbox (key, value)

  [<Erase>]
  type expansionPanel =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkExpansionPanelClasses "root" value
    /// Styles applied to the root element if `square={false}`.
    static member inline rounded(value: string) = mkExpansionPanelClasses "rounded" value
    /// Styles applied to the root element if `expanded={true}`.
    static member inline expanded(value: string) = mkExpansionPanelClasses "expanded" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkExpansionPanelClasses "disabled" value


  type IExpansionPanelActionsClasses = interface end

  let inline private mkExpansionPanelActionsClasses (key: string) (value: string) : IExpansionPanelActionsClasses = unbox (key, value)

  [<Erase>]
  type expansionPanelActions =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkExpansionPanelActionsClasses "root" value
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(value: string) = mkExpansionPanelActionsClasses "spacing" value


  type IExpansionPanelDetailsClasses = interface end

  let inline private mkExpansionPanelDetailsClasses (key: string) (value: string) : IExpansionPanelDetailsClasses = unbox (key, value)

  [<Erase>]
  type expansionPanelDetails =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkExpansionPanelDetailsClasses "root" value


  type IExpansionPanelSummaryClasses = interface end

  let inline private mkExpansionPanelSummaryClasses (key: string) (value: string) : IExpansionPanelSummaryClasses = unbox (key, value)

  [<Erase>]
  type expansionPanelSummary =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkExpansionPanelSummaryClasses "root" value
    /// Styles applied to the root element, children wrapper element and `IconButton` component if `expanded={true}`.
    static member inline expanded(value: string) = mkExpansionPanelSummaryClasses "expanded" value
    /// Styles applied to the root and children wrapper elements when focused.
    static member inline focused(value: string) = mkExpansionPanelSummaryClasses "focused" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkExpansionPanelSummaryClasses "disabled" value
    /// Styles applied to the children wrapper element.
    static member inline content(value: string) = mkExpansionPanelSummaryClasses "content" value
    /// Styles applied to the `IconButton` component when `expandIcon` is supplied.
    static member inline expandIcon(value: string) = mkExpansionPanelSummaryClasses "expandIcon" value


  type IFabClasses = interface end

  let inline private mkFabClasses (key: string) (value: string) : IFabClasses = unbox (key, value)

  [<Erase>]
  type fab =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkFabClasses "root" value
    /// Styles applied to the span element that wraps the children.
    static member inline label(value: string) = mkFabClasses "label" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline primary(value: string) = mkFabClasses "primary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline secondary(value: string) = mkFabClasses "secondary" value
    /// Styles applied to the root element if `variant="extended"`.
    static member inline extended(value: string) = mkFabClasses "extended" value
    /// Pseudo-class applied to the ButtonBase root element if the button is keyboard focused.
    static member inline focusVisible(value: string) = mkFabClasses "focusVisible" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkFabClasses "disabled" value
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: string) = mkFabClasses "colorInherit" value
    /// Styles applied to the root element if `size="small"``.
    static member inline sizeSmall(value: string) = mkFabClasses "sizeSmall" value
    /// Styles applied to the root element if `size="medium"``.
    static member inline sizeMedium(value: string) = mkFabClasses "sizeMedium" value


  type IFadeClasses = interface end


  type IFilledInputClasses = interface end

  let inline private mkFilledInputClasses (key: string) (value: string) : IFilledInputClasses = unbox (key, value)

  [<Erase>]
  type filledInput =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkFilledInputClasses "root" value
    /// Styles applied to the root element if `disableUnderline={false}`.
    static member inline underline(value: string) = mkFilledInputClasses "underline" value
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: string) = mkFilledInputClasses "focused" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkFilledInputClasses "disabled" value
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(value: string) = mkFilledInputClasses "adornedStart" value
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(value: string) = mkFilledInputClasses "adornedEnd" value
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: string) = mkFilledInputClasses "error" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(value: string) = mkFilledInputClasses "marginDense" value
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: string) = mkFilledInputClasses "multiline" value
    /// Styles applied to the `input` element.
    static member inline input(value: string) = mkFilledInputClasses "input" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: string) = mkFilledInputClasses "inputMarginDense" value
    /// Styles applied to the `input` if in ``.
    static member inline inputHiddenLabel(value: string) = mkFilledInputClasses "inputHiddenLabel" value
    /// Styles applied to the `input` element if `select={true}`.
    static member inline inputSelect(value: string) = mkFilledInputClasses "inputSelect" value
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: string) = mkFilledInputClasses "inputMultiline" value
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(value: string) = mkFilledInputClasses "inputAdornedStart" value
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(value: string) = mkFilledInputClasses "inputAdornedEnd" value


  type IFormControlClasses = interface end

  let inline private mkFormControlClasses (key: string) (value: string) : IFormControlClasses = unbox (key, value)

  [<Erase>]
  type formControl =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkFormControlClasses "root" value
    /// Styles applied to the root element if `margin="normal"`.
    static member inline marginNormal(value: string) = mkFormControlClasses "marginNormal" value
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(value: string) = mkFormControlClasses "marginDense" value
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: string) = mkFormControlClasses "fullWidth" value


  type IFormControlLabelClasses = interface end

  let inline private mkFormControlLabelClasses (key: string) (value: string) : IFormControlLabelClasses = unbox (key, value)

  [<Erase>]
  type formControlLabel =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkFormControlLabelClasses "root" value
    /// Styles applied to the root element if `labelPlacement="start"`.
    static member inline labelPlacementStart(value: string) = mkFormControlLabelClasses "labelPlacementStart" value
    /// Styles applied to the root element if `labelPlacement="top"`.
    static member inline labelPlacementTop(value: string) = mkFormControlLabelClasses "labelPlacementTop" value
    /// Styles applied to the root element if `labelPlacement="bottom"`.
    static member inline labelPlacementBottom(value: string) = mkFormControlLabelClasses "labelPlacementBottom" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkFormControlLabelClasses "disabled" value
    /// Styles applied to the label's Typography component.
    static member inline label(value: string) = mkFormControlLabelClasses "label" value


  type IFormGroupClasses = interface end

  let inline private mkFormGroupClasses (key: string) (value: string) : IFormGroupClasses = unbox (key, value)

  [<Erase>]
  type formGroup =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkFormGroupClasses "root" value
    /// Styles applied to the root element if `row={true}`.
    static member inline row(value: string) = mkFormGroupClasses "row" value


  type IFormHelperTextClasses = interface end

  let inline private mkFormHelperTextClasses (key: string) (value: string) : IFormHelperTextClasses = unbox (key, value)

  [<Erase>]
  type formHelperText =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkFormHelperTextClasses "root" value
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: string) = mkFormHelperTextClasses "error" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkFormHelperTextClasses "disabled" value
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(value: string) = mkFormHelperTextClasses "marginDense" value
    /// Styles applied to the root element if `variant="filled"` or `variant="outlined"`.
    static member inline contained(value: string) = mkFormHelperTextClasses "contained" value
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(value: string) = mkFormHelperTextClasses "focused" value
    /// Pseudo-class applied to the root element if `filled={true}`.
    static member inline filled(value: string) = mkFormHelperTextClasses "filled" value
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(value: string) = mkFormHelperTextClasses "required" value


  type IFormLabelClasses = interface end

  let inline private mkFormLabelClasses (key: string) (value: string) : IFormLabelClasses = unbox (key, value)

  [<Erase>]
  type formLabel =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkFormLabelClasses "root" value
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(value: string) = mkFormLabelClasses "focused" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkFormLabelClasses "disabled" value
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: string) = mkFormLabelClasses "error" value
    /// Pseudo-class applied to the root element if `filled={true}`.
    static member inline filled(value: string) = mkFormLabelClasses "filled" value
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(value: string) = mkFormLabelClasses "required" value
    /// Styles applied to the asterisk element.
    static member inline asterisk(value: string) = mkFormLabelClasses "asterisk" value


  type IGridClasses = interface end

  let inline private mkGridClasses (key: string) (value: string) : IGridClasses = unbox (key, value)

  [<Erase>]
  type grid =
    /// Styles applied to the root element
    static member inline root(value: string) = mkGridClasses "root" value
    /// Styles applied to the root element if `container={true}`.
    static member inline container(value: string) = mkGridClasses "container" value
    /// Styles applied to the root element if `item={true}`.
    static member inline item(value: string) = mkGridClasses "item" value
    /// Styles applied to the root element if `zeroMinWidth={true}`.
    static member inline zeroMinWidth(value: string) = mkGridClasses "zeroMinWidth" value
    static member inline directionXsColumn(value: string) = mkGridClasses "direction-xs-column" value
    static member inline directionXsColumnReverse(value: string) = mkGridClasses "direction-xs-column-reverse" value
    static member inline directionXsRowReverse(value: string) = mkGridClasses "direction-xs-row-reverse" value
    static member inline wrapXsNowrap(value: string) = mkGridClasses "wrap-xs-nowrap" value
    static member inline wrapXsWrapReverse(value: string) = mkGridClasses "wrap-xs-wrap-reverse" value
    static member inline alignItemsXsCenter(value: string) = mkGridClasses "align-items-xs-center" value
    static member inline alignItemsXsFlexStart(value: string) = mkGridClasses "align-items-xs-flex-start" value
    static member inline alignItemsXsFlexEnd(value: string) = mkGridClasses "align-items-xs-flex-end" value
    static member inline alignItemsXsBaseline(value: string) = mkGridClasses "align-items-xs-baseline" value
    static member inline alignContentXsCenter(value: string) = mkGridClasses "align-content-xs-center" value
    static member inline alignContentXsFlexStart(value: string) = mkGridClasses "align-content-xs-flex-start" value
    static member inline alignContentXsFlexEnd(value: string) = mkGridClasses "align-content-xs-flex-end" value
    static member inline alignContentXsSpaceBetween(value: string) = mkGridClasses "align-content-xs-space-between" value
    static member inline alignContentXsSpaceAround(value: string) = mkGridClasses "align-content-xs-space-around" value
    static member inline justifyXsCenter(value: string) = mkGridClasses "justify-xs-center" value
    static member inline justifyXsFlexEnd(value: string) = mkGridClasses "justify-xs-flex-end" value
    static member inline justifyXsSpaceBetween(value: string) = mkGridClasses "justify-xs-space-between" value
    static member inline justifyXsSpaceAround(value: string) = mkGridClasses "justify-xs-space-around" value
    static member inline justifyXsSpaceEvenly(value: string) = mkGridClasses "justify-xs-space-evenly" value
    static member inline spacingXs1(value: string) = mkGridClasses "spacing-xs-1" value
    static member inline spacingXs2(value: string) = mkGridClasses "spacing-xs-2" value
    static member inline spacingXs3(value: string) = mkGridClasses "spacing-xs-3" value
    static member inline spacingXs4(value: string) = mkGridClasses "spacing-xs-4" value
    static member inline spacingXs5(value: string) = mkGridClasses "spacing-xs-5" value
    static member inline spacingXs6(value: string) = mkGridClasses "spacing-xs-6" value
    static member inline spacingXs7(value: string) = mkGridClasses "spacing-xs-7" value
    static member inline spacingXs8(value: string) = mkGridClasses "spacing-xs-8" value
    static member inline spacingXs9(value: string) = mkGridClasses "spacing-xs-9" value
    static member inline spacingXs10(value: string) = mkGridClasses "spacing-xs-10" value
    static member inline gridXsAuto(value: string) = mkGridClasses "grid-xs-auto" value
    static member inline gridXsTrue(value: string) = mkGridClasses "grid-xs-true" value
    static member inline gridXs1(value: string) = mkGridClasses "grid-xs-1" value
    static member inline gridXs2(value: string) = mkGridClasses "grid-xs-2" value
    static member inline gridXs3(value: string) = mkGridClasses "grid-xs-3" value
    static member inline gridXs4(value: string) = mkGridClasses "grid-xs-4" value
    static member inline gridXs5(value: string) = mkGridClasses "grid-xs-5" value
    static member inline gridXs6(value: string) = mkGridClasses "grid-xs-6" value
    static member inline gridXs7(value: string) = mkGridClasses "grid-xs-7" value
    static member inline gridXs8(value: string) = mkGridClasses "grid-xs-8" value
    static member inline gridXs9(value: string) = mkGridClasses "grid-xs-9" value
    static member inline gridXs10(value: string) = mkGridClasses "grid-xs-10" value
    static member inline gridXs11(value: string) = mkGridClasses "grid-xs-11" value
    static member inline gridXs12(value: string) = mkGridClasses "grid-xs-12" value


  type IGridListClasses = interface end

  let inline private mkGridListClasses (key: string) (value: string) : IGridListClasses = unbox (key, value)

  [<Erase>]
  type gridList =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkGridListClasses "root" value


  type IGridListTileClasses = interface end

  let inline private mkGridListTileClasses (key: string) (value: string) : IGridListTileClasses = unbox (key, value)

  [<Erase>]
  type gridListTile =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkGridListTileClasses "root" value
    /// Styles applied to the `div` element that wraps the children.
    static member inline tile(value: string) = mkGridListTileClasses "tile" value
    /// Styles applied to an `img` element child, if needed to ensure it covers the tile.
    static member inline imgFullHeight(value: string) = mkGridListTileClasses "imgFullHeight" value
    /// Styles applied to an `img` element child, if needed to ensure it covers the tile.
    static member inline imgFullWidth(value: string) = mkGridListTileClasses "imgFullWidth" value


  type IGridListTileBarClasses = interface end

  let inline private mkGridListTileBarClasses (key: string) (value: string) : IGridListTileBarClasses = unbox (key, value)

  [<Erase>]
  type gridListTileBar =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkGridListTileBarClasses "root" value
    /// Styles applied to the root element if `titlePosition="bottom"`.
    static member inline titlePositionBottom(value: string) = mkGridListTileBarClasses "titlePositionBottom" value
    /// Styles applied to the root element if `titlePosition="top"`.
    static member inline titlePositionTop(value: string) = mkGridListTileBarClasses "titlePositionTop" value
    /// Styles applied to the root element if a `subtitle` is provided.
    static member inline rootSubtitle(value: string) = mkGridListTileBarClasses "rootSubtitle" value
    /// Styles applied to the title and subtitle container element.
    static member inline titleWrap(value: string) = mkGridListTileBarClasses "titleWrap" value
    /// Styles applied to the container element if `actionPosition="left"`.
    static member inline titleWrapActionPosLeft(value: string) = mkGridListTileBarClasses "titleWrapActionPosLeft" value
    /// Styles applied to the container element if `actionPosition="right"`.
    static member inline titleWrapActionPosRight(value: string) = mkGridListTileBarClasses "titleWrapActionPosRight" value
    /// Styles applied to the title container element.
    static member inline title(value: string) = mkGridListTileBarClasses "title" value
    /// Styles applied to the subtitle container element.
    static member inline subtitle(value: string) = mkGridListTileBarClasses "subtitle" value
    /// Styles applied to the actionIcon if supplied.
    static member inline actionIcon(value: string) = mkGridListTileBarClasses "actionIcon" value
    /// Styles applied to the actionIcon if `actionPosition="left"`.
    static member inline actionIconActionPosLeft(value: string) = mkGridListTileBarClasses "actionIconActionPosLeft" value


  type IGrowClasses = interface end


  type IHiddenClasses = interface end


  type IIconClasses = interface end

  let inline private mkIconClasses (key: string) (value: string) : IIconClasses = unbox (key, value)

  [<Erase>]
  type icon =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkIconClasses "root" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkIconClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) = mkIconClasses "colorSecondary" value
    /// Styles applied to the root element if `color="action"`.
    static member inline colorAction(value: string) = mkIconClasses "colorAction" value
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: string) = mkIconClasses "colorError" value
    /// Styles applied to the root element if `color="disabled"`.
    static member inline colorDisabled(value: string) = mkIconClasses "colorDisabled" value
    static member inline fontSizeInherit(value: string) = mkIconClasses "fontSizeInherit" value
    /// Styles applied to the root element if `fontSize="small"`.
    static member inline fontSizeSmall(value: string) = mkIconClasses "fontSizeSmall" value
    /// Styles applied to the root element if `fontSize="large"`.
    static member inline fontSizeLarge(value: string) = mkIconClasses "fontSizeLarge" value


  type IIconButtonClasses = interface end

  let inline private mkIconButtonClasses (key: string) (value: string) : IIconButtonClasses = unbox (key, value)

  [<Erase>]
  type iconButton =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkIconButtonClasses "root" value
    /// Styles applied to the root element if `edge="start"`.
    static member inline edgeStart(value: string) = mkIconButtonClasses "edgeStart" value
    /// Styles applied to the root element if `edge="end"`.
    static member inline edgeEnd(value: string) = mkIconButtonClasses "edgeEnd" value
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: string) = mkIconButtonClasses "colorInherit" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkIconButtonClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) = mkIconButtonClasses "colorSecondary" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkIconButtonClasses "disabled" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) = mkIconButtonClasses "sizeSmall" value
    /// Styles applied to the children container element.
    static member inline label(value: string) = mkIconButtonClasses "label" value


  type IInputClasses = interface end

  let inline private mkInputClasses (key: string) (value: string) : IInputClasses = unbox (key, value)

  [<Erase>]
  type input =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkInputClasses "root" value
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(value: string) = mkInputClasses "formControl" value
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: string) = mkInputClasses "focused" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkInputClasses "disabled" value
    /// Styles applied to the root element if `disableUnderline={false}`.
    static member inline underline(value: string) = mkInputClasses "underline" value
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: string) = mkInputClasses "error" value
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: string) = mkInputClasses "multiline" value
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: string) = mkInputClasses "fullWidth" value
    /// Styles applied to the `input` element.
    static member inline input(value: string) = mkInputClasses "input" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: string) = mkInputClasses "inputMarginDense" value
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: string) = mkInputClasses "inputMultiline" value
    /// Styles applied to the `input` element if `type="search"`.
    static member inline inputTypeSearch(value: string) = mkInputClasses "inputTypeSearch" value


  type IInputAdornmentClasses = interface end

  let inline private mkInputAdornmentClasses (key: string) (value: string) : IInputAdornmentClasses = unbox (key, value)

  [<Erase>]
  type inputAdornment =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkInputAdornmentClasses "root" value
    /// Styles applied to the root element if `variant="filled"`.
    static member inline filled(value: string) = mkInputAdornmentClasses "filled" value
    /// Styles applied to the root element if `position="start"`.
    static member inline positionStart(value: string) = mkInputAdornmentClasses "positionStart" value
    /// Styles applied to the root element if `position="end"`.
    static member inline positionEnd(value: string) = mkInputAdornmentClasses "positionEnd" value
    /// Styles applied to the root element if `disablePointerEvents=true`.
    static member inline disablePointerEvents(value: string) = mkInputAdornmentClasses "disablePointerEvents" value
    /// Styles applied if the adornment is used inside <formcontrol hiddenlabel=""></formcontrol>.
    static member inline hiddenLabel(value: string) = mkInputAdornmentClasses "hiddenLabel" value
    /// Styles applied if the adornment is used inside <formcontrol margin="dense"></formcontrol>.
    static member inline marginDense(value: string) = mkInputAdornmentClasses "marginDense" value


  type IInputBaseClasses = interface end

  let inline private mkInputBaseClasses (key: string) (value: string) : IInputBaseClasses = unbox (key, value)

  [<Erase>]
  type inputBase =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkInputBaseClasses "root" value
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(value: string) = mkInputBaseClasses "formControl" value
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: string) = mkInputBaseClasses "focused" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkInputBaseClasses "disabled" value
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(value: string) = mkInputBaseClasses "adornedStart" value
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(value: string) = mkInputBaseClasses "adornedEnd" value
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: string) = mkInputBaseClasses "error" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(value: string) = mkInputBaseClasses "marginDense" value
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: string) = mkInputBaseClasses "multiline" value
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: string) = mkInputBaseClasses "fullWidth" value
    /// Styles applied to the `input` element.
    static member inline input(value: string) = mkInputBaseClasses "input" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: string) = mkInputBaseClasses "inputMarginDense" value
    /// Styles applied to the `input` element if `select={true}`.
    static member inline inputSelect(value: string) = mkInputBaseClasses "inputSelect" value
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: string) = mkInputBaseClasses "inputMultiline" value
    /// Styles applied to the `input` element if `type="search"`.
    static member inline inputTypeSearch(value: string) = mkInputBaseClasses "inputTypeSearch" value
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(value: string) = mkInputBaseClasses "inputAdornedStart" value
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(value: string) = mkInputBaseClasses "inputAdornedEnd" value
    /// Styles applied to the `input` element if `hiddenLabel={true}`.
    static member inline inputHiddenLabel(value: string) = mkInputBaseClasses "inputHiddenLabel" value


  type IInputLabelClasses = interface end

  let inline private mkInputLabelClasses (key: string) (value: string) : IInputLabelClasses = unbox (key, value)

  [<Erase>]
  type inputLabel =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkInputLabelClasses "root" value
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(value: string) = mkInputLabelClasses "focused" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkInputLabelClasses "disabled" value
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: string) = mkInputLabelClasses "error" value
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(value: string) = mkInputLabelClasses "required" value
    /// Pseudo-class applied to the asterisk element.
    static member inline asterisk(value: string) = mkInputLabelClasses "asterisk" value
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(value: string) = mkInputLabelClasses "formControl" value
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(value: string) = mkInputLabelClasses "marginDense" value
    /// Styles applied to the `input` element if `shrink={true}`.
    static member inline shrink(value: string) = mkInputLabelClasses "shrink" value
    /// Styles applied to the `input` element if `disableAnimation={false}`.
    static member inline animated(value: string) = mkInputLabelClasses "animated" value
    /// Styles applied to the root element if `variant="filled"`.
    static member inline filled(value: string) = mkInputLabelClasses "filled" value
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(value: string) = mkInputLabelClasses "outlined" value


  type ILinearProgressClasses = interface end

  let inline private mkLinearProgressClasses (key: string) (value: string) : ILinearProgressClasses = unbox (key, value)

  [<Erase>]
  type linearProgress =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkLinearProgressClasses "root" value
    /// Styles applied to the root & bar2 element if `color="primary"`; bar2 if `variant-"buffer"`.
    static member inline colorPrimary(value: string) = mkLinearProgressClasses "colorPrimary" value
    /// Styles applied to the root & bar2 elements if `color="secondary"`; bar2 if `variant="buffer"`.
    static member inline colorSecondary(value: string) = mkLinearProgressClasses "colorSecondary" value
    /// Styles applied to the root element if `variant="determinate"`.
    static member inline determinate(value: string) = mkLinearProgressClasses "determinate" value
    /// Styles applied to the root element if `variant="indeterminate"`.
    static member inline indeterminate(value: string) = mkLinearProgressClasses "indeterminate" value
    /// Styles applied to the root element if `variant="buffer"`.
    static member inline buffer(value: string) = mkLinearProgressClasses "buffer" value
    /// Styles applied to the root element if `variant="query"`.
    static member inline query(value: string) = mkLinearProgressClasses "query" value
    /// Styles applied to the additional bar element if `variant="buffer"`.
    static member inline dashed(value: string) = mkLinearProgressClasses "dashed" value
    /// Styles applied to the additional bar element if `variant="buffer"`&`color="primary"`.
    static member inline dashedColorPrimary(value: string) = mkLinearProgressClasses "dashedColorPrimary" value
    /// Styles applied to the additional bar element if `variant="buffer"`&`color="secondary"`.
    static member inline dashedColorSecondary(value: string) = mkLinearProgressClasses "dashedColorSecondary" value
    /// Styles applied to the layered bar1 & bar2 elements.
    static member inline bar(value: string) = mkLinearProgressClasses "bar" value
    /// Styles applied to the bar elements if `color="primary"`; bar2 if `variant` not "buffer".
    static member inline barColorPrimary(value: string) = mkLinearProgressClasses "barColorPrimary" value
    /// Styles applied to the bar elements if `color="secondary"`; bar2 if `variant` not "buffer".
    static member inline barColorSecondary(value: string) = mkLinearProgressClasses "barColorSecondary" value
    /// Styles applied to the bar1 element if `variant="indeterminate or query"`.
    static member inline bar1Indeterminate(value: string) = mkLinearProgressClasses "bar1Indeterminate" value
    /// Styles applied to the bar1 element if `variant="determinate"`.
    static member inline bar1Determinate(value: string) = mkLinearProgressClasses "bar1Determinate" value
    /// Styles applied to the bar1 element if `variant="buffer"`.
    static member inline bar1Buffer(value: string) = mkLinearProgressClasses "bar1Buffer" value
    /// Styles applied to the bar2 element if `variant="indeterminate or query"`.
    static member inline bar2Indeterminate(value: string) = mkLinearProgressClasses "bar2Indeterminate" value
    /// Styles applied to the bar2 element if `variant="buffer"`.
    static member inline bar2Buffer(value: string) = mkLinearProgressClasses "bar2Buffer" value


  type ILinkClasses = interface end

  let inline private mkLinkClasses (key: string) (value: string) : ILinkClasses = unbox (key, value)

  [<Erase>]
  type link =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkLinkClasses "root" value
    /// Styles applied to the root element if `underline="none"`.
    static member inline underlineNone(value: string) = mkLinkClasses "underlineNone" value
    /// Styles applied to the root element if `underline="hover"`.
    static member inline underlineHover(value: string) = mkLinkClasses "underlineHover" value
    /// Styles applied to the root element if `underline="always"`.
    static member inline underlineAlways(value: string) = mkLinkClasses "underlineAlways" value
    /// Styles applied to the root element if `component="button"`.
    static member inline button(value: string) = mkLinkClasses "button" value
    /// Pseudo-class applied to the root element if the link is keyboard focused.
    static member inline focusVisible(value: string) = mkLinkClasses "focusVisible" value


  type IListClasses = interface end

  let inline private mkListClasses (key: string) (value: string) : IListClasses = unbox (key, value)

  [<Erase>]
  type list =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkListClasses "root" value
    /// Styles applied to the root element if `disablePadding={false}`.
    static member inline padding(value: string) = mkListClasses "padding" value
    /// Styles applied to the root element if dense.
    static member inline dense(value: string) = mkListClasses "dense" value
    /// Styles applied to the root element if a `subheader` is provided.
    static member inline subheader(value: string) = mkListClasses "subheader" value


  type IListItemClasses = interface end

  let inline private mkListItemClasses (key: string) (value: string) : IListItemClasses = unbox (key, value)

  [<Erase>]
  type listItem =
    /// Styles applied to the (normally root) `component` element. May be wrapped by a `container`.
    static member inline root(value: string) = mkListItemClasses "root" value
    /// Styles applied to the `container` element if `children` includes `ListItemSecondaryAction`.
    static member inline container(value: string) = mkListItemClasses "container" value
    /// Pseudo-class applied to the `component`'s `focusVisibleClassName` prop if `button={true}`.
    static member inline focusVisible(value: string) = mkListItemClasses "focusVisible" value
    /// Styles applied to the `component` element if dense.
    static member inline dense(value: string) = mkListItemClasses "dense" value
    /// Styles applied to the `component` element if `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(value: string) = mkListItemClasses "alignItemsFlexStart" value
    /// Pseudo-class applied to the inner `component` element if `disabled={true}`.
    static member inline disabled(value: string) = mkListItemClasses "disabled" value
    /// Styles applied to the inner `component` element if `divider={true}`.
    static member inline divider(value: string) = mkListItemClasses "divider" value
    /// Styles applied to the inner `component` element if `disableGutters={false}`.
    static member inline gutters(value: string) = mkListItemClasses "gutters" value
    /// Styles applied to the inner `component` element if `button={true}`.
    static member inline button(value: string) = mkListItemClasses "button" value
    /// Styles applied to the `component` element if `children` includes `ListItemSecondaryAction`.
    static member inline secondaryAction(value: string) = mkListItemClasses "secondaryAction" value
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(value: string) = mkListItemClasses "selected" value


  type IListItemAvatarClasses = interface end

  let inline private mkListItemAvatarClasses (key: string) (value: string) : IListItemAvatarClasses = unbox (key, value)

  [<Erase>]
  type listItemAvatar =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkListItemAvatarClasses "root" value
    /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(value: string) = mkListItemAvatarClasses "alignItemsFlexStart" value


  type IListItemIconClasses = interface end

  let inline private mkListItemIconClasses (key: string) (value: string) : IListItemIconClasses = unbox (key, value)

  [<Erase>]
  type listItemIcon =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkListItemIconClasses "root" value
    /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(value: string) = mkListItemIconClasses "alignItemsFlexStart" value


  type IListItemSecondaryActionClasses = interface end

  let inline private mkListItemSecondaryActionClasses (key: string) (value: string) : IListItemSecondaryActionClasses = unbox (key, value)

  [<Erase>]
  type listItemSecondaryAction =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkListItemSecondaryActionClasses "root" value


  type IListItemTextClasses = interface end

  let inline private mkListItemTextClasses (key: string) (value: string) : IListItemTextClasses = unbox (key, value)

  [<Erase>]
  type listItemText =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkListItemTextClasses "root" value
    /// Styles applied to the `Typography` components if primary and secondary are set.
    static member inline multiline(value: string) = mkListItemTextClasses "multiline" value
    /// Styles applied to the `Typography` components if dense.
    static member inline dense(value: string) = mkListItemTextClasses "dense" value
    /// Styles applied to the root element if `inset={true}`.
    static member inline inset(value: string) = mkListItemTextClasses "inset" value
    /// Styles applied to the primary `Typography` component.
    static member inline primary(value: string) = mkListItemTextClasses "primary" value
    /// Styles applied to the secondary `Typography` component.
    static member inline secondary(value: string) = mkListItemTextClasses "secondary" value


  type IListSubheaderClasses = interface end

  let inline private mkListSubheaderClasses (key: string) (value: string) : IListSubheaderClasses = unbox (key, value)

  [<Erase>]
  type listSubheader =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkListSubheaderClasses "root" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkListSubheaderClasses "colorPrimary" value
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: string) = mkListSubheaderClasses "colorInherit" value
    /// Styles applied to the inner `component` element if `disableGutters={false}`.
    static member inline gutters(value: string) = mkListSubheaderClasses "gutters" value
    /// Styles applied to the root element if `inset={true}`.
    static member inline inset(value: string) = mkListSubheaderClasses "inset" value
    /// Styles applied to the root element if `disableSticky={false}`.
    static member inline sticky(value: string) = mkListSubheaderClasses "sticky" value


  type IMenuClasses = interface end

  let inline private mkMenuClasses (key: string) (value: string) : IMenuClasses = unbox (key, value)

  [<Erase>]
  type menu =
    /// Styles applied to the `Paper` component.
    static member inline paper(value: string) = mkMenuClasses "paper" value
    /// Styles applied to the `List` component via `MenuList`.
    static member inline list(value: string) = mkMenuClasses "list" value


  type IMenuItemClasses = interface end

  let inline private mkMenuItemClasses (key: string) (value: string) : IMenuItemClasses = unbox (key, value)

  [<Erase>]
  type menuItem =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkMenuItemClasses "root" value
    /// Styles applied to the root element if `disableGutters={false}`.
    static member inline gutters(value: string) = mkMenuItemClasses "gutters" value
    /// Styles applied to the root element if `selected={true}`.
    static member inline selected(value: string) = mkMenuItemClasses "selected" value
    /// Styles applied to the root element if dense.
    static member inline dense(value: string) = mkMenuItemClasses "dense" value


  type IMenuListClasses = interface end


  type IMobileStepperClasses = interface end

  let inline private mkMobileStepperClasses (key: string) (value: string) : IMobileStepperClasses = unbox (key, value)

  [<Erase>]
  type mobileStepper =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkMobileStepperClasses "root" value
    /// Styles applied to the root element if `position="bottom"`.
    static member inline positionBottom(value: string) = mkMobileStepperClasses "positionBottom" value
    /// Styles applied to the root element if `position="top"`.
    static member inline positionTop(value: string) = mkMobileStepperClasses "positionTop" value
    /// Styles applied to the root element if `position="static"`.
    static member inline positionStatic(value: string) = mkMobileStepperClasses "positionStatic" value
    /// Styles applied to the dots container if `variant="dots"`.
    static member inline dots(value: string) = mkMobileStepperClasses "dots" value
    /// Styles applied to each dot if `variant="dots"`.
    static member inline dot(value: string) = mkMobileStepperClasses "dot" value
    /// Styles applied to a dot if `variant="dots"` and this is the active step.
    static member inline dotActive(value: string) = mkMobileStepperClasses "dotActive" value
    /// Styles applied to the Linear Progress component if `variant="progress"`.
    static member inline progress(value: string) = mkMobileStepperClasses "progress" value


  type IModalClasses = interface end


  type INativeSelectClasses = interface end

  let inline private mkNativeSelectClasses (key: string) (value: string) : INativeSelectClasses = unbox (key, value)

  [<Erase>]
  type nativeSelect =
    /// Styles applied to the select component `root` class.
    static member inline root(value: string) = mkNativeSelectClasses "root" value
    /// Styles applied to the select component `select` class.
    static member inline select(value: string) = mkNativeSelectClasses "select" value
    /// Styles applied to the select component if `variant="filled"`.
    static member inline filled(value: string) = mkNativeSelectClasses "filled" value
    /// Styles applied to the select component if `variant="outlined"`.
    static member inline outlined(value: string) = mkNativeSelectClasses "outlined" value
    /// Styles applied to the select component `selectMenu` class.
    static member inline selectMenu(value: string) = mkNativeSelectClasses "selectMenu" value
    /// Pseudo-class applied to the select component `disabled` class.
    static member inline disabled(value: string) = mkNativeSelectClasses "disabled" value
    /// Styles applied to the select component `icon` class.
    static member inline icon(value: string) = mkNativeSelectClasses "icon" value


  type INoSsrClasses = interface end


  type IOutlinedInputClasses = interface end

  let inline private mkOutlinedInputClasses (key: string) (value: string) : IOutlinedInputClasses = unbox (key, value)

  [<Erase>]
  type outlinedInput =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkOutlinedInputClasses "root" value
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: string) = mkOutlinedInputClasses "focused" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkOutlinedInputClasses "disabled" value
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(value: string) = mkOutlinedInputClasses "adornedStart" value
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(value: string) = mkOutlinedInputClasses "adornedEnd" value
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: string) = mkOutlinedInputClasses "error" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(value: string) = mkOutlinedInputClasses "marginDense" value
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: string) = mkOutlinedInputClasses "multiline" value
    /// Styles applied to the `NotchedOutline` element.
    static member inline notchedOutline(value: string) = mkOutlinedInputClasses "notchedOutline" value
    /// Styles applied to the `input` element.
    static member inline input(value: string) = mkOutlinedInputClasses "input" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: string) = mkOutlinedInputClasses "inputMarginDense" value
    /// Styles applied to the `input` element if `select={true}`.
    static member inline inputSelect(value: string) = mkOutlinedInputClasses "inputSelect" value
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: string) = mkOutlinedInputClasses "inputMultiline" value
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(value: string) = mkOutlinedInputClasses "inputAdornedStart" value
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(value: string) = mkOutlinedInputClasses "inputAdornedEnd" value


  type IPaperClasses = interface end

  let inline private mkPaperClasses (key: string) (value: string) : IPaperClasses = unbox (key, value)

  [<Erase>]
  type paper =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkPaperClasses "root" value
    /// Styles applied to the root element if `square={false}`.
    static member inline rounded(value: string) = mkPaperClasses "rounded" value
    static member inline elevation0(value: string) = mkPaperClasses "elevation0" value
    static member inline elevation1(value: string) = mkPaperClasses "elevation1" value
    static member inline elevation2(value: string) = mkPaperClasses "elevation2" value
    static member inline elevation3(value: string) = mkPaperClasses "elevation3" value
    static member inline elevation4(value: string) = mkPaperClasses "elevation4" value
    static member inline elevation5(value: string) = mkPaperClasses "elevation5" value
    static member inline elevation6(value: string) = mkPaperClasses "elevation6" value
    static member inline elevation7(value: string) = mkPaperClasses "elevation7" value
    static member inline elevation8(value: string) = mkPaperClasses "elevation8" value
    static member inline elevation9(value: string) = mkPaperClasses "elevation9" value
    static member inline elevation10(value: string) = mkPaperClasses "elevation10" value
    static member inline elevation11(value: string) = mkPaperClasses "elevation11" value
    static member inline elevation12(value: string) = mkPaperClasses "elevation12" value
    static member inline elevation13(value: string) = mkPaperClasses "elevation13" value
    static member inline elevation14(value: string) = mkPaperClasses "elevation14" value
    static member inline elevation15(value: string) = mkPaperClasses "elevation15" value
    static member inline elevation16(value: string) = mkPaperClasses "elevation16" value
    static member inline elevation17(value: string) = mkPaperClasses "elevation17" value
    static member inline elevation18(value: string) = mkPaperClasses "elevation18" value
    static member inline elevation19(value: string) = mkPaperClasses "elevation19" value
    static member inline elevation20(value: string) = mkPaperClasses "elevation20" value
    static member inline elevation21(value: string) = mkPaperClasses "elevation21" value
    static member inline elevation22(value: string) = mkPaperClasses "elevation22" value
    static member inline elevation23(value: string) = mkPaperClasses "elevation23" value
    static member inline elevation24(value: string) = mkPaperClasses "elevation24" value


  type IPopoverClasses = interface end

  let inline private mkPopoverClasses (key: string) (value: string) : IPopoverClasses = unbox (key, value)

  [<Erase>]
  type popover =
    /// Styles applied to the `Paper` component.
    static member inline paper(value: string) = mkPopoverClasses "paper" value


  type IPopperClasses = interface end


  type IPortalClasses = interface end


  type IRadioClasses = interface end

  let inline private mkRadioClasses (key: string) (value: string) : IRadioClasses = unbox (key, value)

  [<Erase>]
  type radio =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkRadioClasses "root" value
    /// Pseudo-class applied to the root element if `checked={true}`.
    static member inline checked'(value: string) = mkRadioClasses "checked" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkRadioClasses "disabled" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkRadioClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) = mkRadioClasses "colorSecondary" value


  type IRadioGroupClasses = interface end


  type IRatingClasses = interface end

  let inline private mkRatingClasses (key: string) (value: string) : IRatingClasses = unbox (key, value)

  [<Erase>]
  type rating =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkRatingClasses "root" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) = mkRatingClasses "sizeSmall" value
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(value: string) = mkRatingClasses "sizeLarge" value
    /// Styles applied to the root element if `readOnly={true}`.
    static member inline readOnly(value: string) = mkRatingClasses "readOnly" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkRatingClasses "disabled" value
    /// Pseudo-class applied to the root element if keyboard focused.
    static member inline focusVisible(value: string) = mkRatingClasses "focusVisible" value
    /// Visually hide an element.
    static member inline visuallyhidden(value: string) = mkRatingClasses "visuallyhidden" value
    /// Styles applied to the pristine label.
    static member inline pristine(value: string) = mkRatingClasses "pristine" value
    /// Styles applied to the label elements.
    static member inline label(value: string) = mkRatingClasses "label" value
    /// Styles applied to the icon wrapping elements.
    static member inline icon(value: string) = mkRatingClasses "icon" value
    /// Styles applied to the icon wrapping elements when empty.
    static member inline iconEmpty(value: string) = mkRatingClasses "iconEmpty" value
    /// Styles applied to the icon wrapping elements when filled.
    static member inline iconFilled(value: string) = mkRatingClasses "iconFilled" value
    /// Styles applied to the icon wrapping elements when hover.
    static member inline iconHover(value: string) = mkRatingClasses "iconHover" value
    /// Styles applied to the icon wrapping elements when focus.
    static member inline iconFocus(value: string) = mkRatingClasses "iconFocus" value
    /// Styles applied to the icon wrapping elements when active.
    static member inline iconActive(value: string) = mkRatingClasses "iconActive" value
    /// Styles applied to the icon wrapping elements when decimals are necessary.
    static member inline decimal(value: string) = mkRatingClasses "decimal" value


  type IRootRefClasses = interface end


  type ISelectClasses = interface end

  let inline private mkSelectClasses (key: string) (value: string) : ISelectClasses = unbox (key, value)

  [<Erase>]
  type select =
    /// Styles applied to the select component `root` class.
    static member inline root(value: string) = mkSelectClasses "root" value
    /// Styles applied to the select component `select` class.
    static member inline select(value: string) = mkSelectClasses "select" value
    /// Styles applied to the select component if `variant="filled"`.
    static member inline filled(value: string) = mkSelectClasses "filled" value
    /// Styles applied to the select component if `variant="outlined"`.
    static member inline outlined(value: string) = mkSelectClasses "outlined" value
    /// Styles applied to the select component `selectMenu` class.
    static member inline selectMenu(value: string) = mkSelectClasses "selectMenu" value
    /// Pseudo-class applied to the select component `disabled` class.
    static member inline disabled(value: string) = mkSelectClasses "disabled" value
    /// Styles applied to the select component `icon` class.
    static member inline icon(value: string) = mkSelectClasses "icon" value


  type ISkeletonClasses = interface end

  let inline private mkSkeletonClasses (key: string) (value: string) : ISkeletonClasses = unbox (key, value)

  [<Erase>]
  type skeleton =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkSkeletonClasses "root" value
    /// Styles applied to the root element if `variant="text"`.
    static member inline text(value: string) = mkSkeletonClasses "text" value
    /// Styles applied to the root element if `variant="rect"`.
    static member inline rect(value: string) = mkSkeletonClasses "rect" value
    /// Styles applied to the root element if `variant="circle"`.
    static member inline circle(value: string) = mkSkeletonClasses "circle" value
    /// Styles applied to the root element if `disabledAnimate={false}`.
    static member inline animate(value: string) = mkSkeletonClasses "animate" value


  type ISlideClasses = interface end


  type ISliderClasses = interface end

  let inline private mkSliderClasses (key: string) (value: string) : ISliderClasses = unbox (key, value)

  [<Erase>]
  type slider =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkSliderClasses "root" value
    /// Styles applied to the root element if `marks` is provided with at least one label.
    static member inline marked(value: string) = mkSliderClasses "marked" value
    /// Pseudo-class applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) = mkSliderClasses "vertical" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkSliderClasses "disabled" value
    /// Styles applied to the rail element.
    static member inline rail(value: string) = mkSliderClasses "rail" value
    /// Styles applied to the track element.
    static member inline track(value: string) = mkSliderClasses "track" value
    /// Styles applied to the thumb element.
    static member inline thumb(value: string) = mkSliderClasses "thumb" value
    /// Pseudo-class applied to the thumb element if it's active.
    static member inline active(value: string) = mkSliderClasses "active" value
    /// Pseudo-class applied to the thumb element if keyboard focused.
    static member inline focusVisible(value: string) = mkSliderClasses "focusVisible" value
    /// Styles applied to the thumb label element.
    static member inline valueLabel(value: string) = mkSliderClasses "valueLabel" value
    /// Styles applied to the mark element.
    static member inline mark(value: string) = mkSliderClasses "mark" value
    /// Styles applied to the mark element if active (depending on the value).
    static member inline markActive(value: string) = mkSliderClasses "markActive" value
    /// Styles applied to the mark label element.
    static member inline markLabel(value: string) = mkSliderClasses "markLabel" value
    /// Styles applied to the mark label element if active (depending on the value).
    static member inline markLabelActive(value: string) = mkSliderClasses "markLabelActive" value


  type ISnackbarClasses = interface end

  let inline private mkSnackbarClasses (key: string) (value: string) : ISnackbarClasses = unbox (key, value)

  [<Erase>]
  type snackbar =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkSnackbarClasses "root" value
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'center' }}`.
    static member inline anchorOriginTopCenter(value: string) = mkSnackbarClasses "anchorOriginTopCenter" value
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'center' }}`.
    static member inline anchorOriginBottomCenter(value: string) = mkSnackbarClasses "anchorOriginBottomCenter" value
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }}`.
    static member inline anchorOriginTopRight(value: string) = mkSnackbarClasses "anchorOriginTopRight" value
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }}`.
    static member inline anchorOriginBottomRight(value: string) = mkSnackbarClasses "anchorOriginBottomRight" value
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }}`.
    static member inline anchorOriginTopLeft(value: string) = mkSnackbarClasses "anchorOriginTopLeft" value
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }}`.
    static member inline anchorOriginBottomLeft(value: string) = mkSnackbarClasses "anchorOriginBottomLeft" value


  type ISnackbarContentClasses = interface end

  let inline private mkSnackbarContentClasses (key: string) (value: string) : ISnackbarContentClasses = unbox (key, value)

  [<Erase>]
  type snackbarContent =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkSnackbarContentClasses "root" value
    /// Styles applied to the message wrapper element.
    static member inline message(value: string) = mkSnackbarContentClasses "message" value
    /// Styles applied to the action wrapper element if `action` is provided.
    static member inline action(value: string) = mkSnackbarContentClasses "action" value


  type ISpeedDialClasses = interface end

  let inline private mkSpeedDialClasses (key: string) (value: string) : ISpeedDialClasses = unbox (key, value)

  [<Erase>]
  type speedDial =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkSpeedDialClasses "root" value
    /// Styles applied to the Button component.
    static member inline fab(value: string) = mkSpeedDialClasses "fab" value
    /// Styles applied to the root and action container elements when direction="up"
    static member inline directionUp(value: string) = mkSpeedDialClasses "directionUp" value
    /// Styles applied to the root and action container elements when direction="down"
    static member inline directionDown(value: string) = mkSpeedDialClasses "directionDown" value
    /// Styles applied to the root and action container elements when direction="left"
    static member inline directionLeft(value: string) = mkSpeedDialClasses "directionLeft" value
    /// Styles applied to the root and action container elements when direction="right"
    static member inline directionRight(value: string) = mkSpeedDialClasses "directionRight" value
    /// Styles applied to the actions (`children` wrapper) element.
    static member inline actions(value: string) = mkSpeedDialClasses "actions" value
    /// Styles applied to the actions (`children` wrapper) element if `open={false}`.
    static member inline actionsClosed(value: string) = mkSpeedDialClasses "actionsClosed" value


  type ISpeedDialActionClasses = interface end

  let inline private mkSpeedDialActionClasses (key: string) (value: string) : ISpeedDialActionClasses = unbox (key, value)

  [<Erase>]
  type speedDialAction =
    /// Styles applied to the `Button` component.
    static member inline button(value: string) = mkSpeedDialActionClasses "button" value
    /// Styles applied to the `Button` component if `open={false}`.
    static member inline buttonClosed(value: string) = mkSpeedDialActionClasses "buttonClosed" value


  type ISpeedDialIconClasses = interface end

  let inline private mkSpeedDialIconClasses (key: string) (value: string) : ISpeedDialIconClasses = unbox (key, value)

  [<Erase>]
  type speedDialIcon =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkSpeedDialIconClasses "root" value
    /// Styles applied to the icon component.
    static member inline icon(value: string) = mkSpeedDialIconClasses "icon" value
    /// Styles applied to the icon component if `open={true}`.
    static member inline iconOpen(value: string) = mkSpeedDialIconClasses "iconOpen" value
    /// Styles applied to the icon when and `openIcon` is provided & if `open={true}`.
    static member inline iconWithOpenIconOpen(value: string) = mkSpeedDialIconClasses "iconWithOpenIconOpen" value
    /// Styles applied to the `openIcon` if provided.
    static member inline openIcon(value: string) = mkSpeedDialIconClasses "openIcon" value
    /// Styles applied to the `openIcon` if provided & if `open={true}`.
    static member inline openIconOpen(value: string) = mkSpeedDialIconClasses "openIconOpen" value


  type IStepClasses = interface end

  let inline private mkStepClasses (key: string) (value: string) : IStepClasses = unbox (key, value)

  [<Erase>]
  type step =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkStepClasses "root" value
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: string) = mkStepClasses "horizontal" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) = mkStepClasses "vertical" value
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: string) = mkStepClasses "alternativeLabel" value
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(value: string) = mkStepClasses "completed" value


  type IStepButtonClasses = interface end

  let inline private mkStepButtonClasses (key: string) (value: string) : IStepButtonClasses = unbox (key, value)

  [<Erase>]
  type stepButton =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkStepButtonClasses "root" value
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: string) = mkStepButtonClasses "horizontal" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) = mkStepButtonClasses "vertical" value
    /// Styles applied to the `ButtonBase` touch-ripple.
    static member inline touchRipple(value: string) = mkStepButtonClasses "touchRipple" value


  type IStepConnectorClasses = interface end

  let inline private mkStepConnectorClasses (key: string) (value: string) : IStepConnectorClasses = unbox (key, value)

  [<Erase>]
  type stepConnector =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkStepConnectorClasses "root" value
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: string) = mkStepConnectorClasses "horizontal" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) = mkStepConnectorClasses "vertical" value
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: string) = mkStepConnectorClasses "alternativeLabel" value
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(value: string) = mkStepConnectorClasses "active" value
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(value: string) = mkStepConnectorClasses "completed" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkStepConnectorClasses "disabled" value
    /// Styles applied to the line element.
    static member inline line(value: string) = mkStepConnectorClasses "line" value
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline lineHorizontal(value: string) = mkStepConnectorClasses "lineHorizontal" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline lineVertical(value: string) = mkStepConnectorClasses "lineVertical" value


  type IStepContentClasses = interface end

  let inline private mkStepContentClasses (key: string) (value: string) : IStepContentClasses = unbox (key, value)

  [<Erase>]
  type stepContent =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkStepContentClasses "root" value
    /// Styles applied to the root element if `last={true}` (controlled by `Step`).
    static member inline last(value: string) = mkStepContentClasses "last" value
    /// Styles applied to the Transition component.
    static member inline transition(value: string) = mkStepContentClasses "transition" value


  type IStepIconClasses = interface end

  let inline private mkStepIconClasses (key: string) (value: string) : IStepIconClasses = unbox (key, value)

  [<Erase>]
  type stepIcon =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkStepIconClasses "root" value
    /// Styles applied to the SVG text element.
    static member inline text(value: string) = mkStepIconClasses "text" value
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(value: string) = mkStepIconClasses "active" value
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(value: string) = mkStepIconClasses "completed" value
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: string) = mkStepIconClasses "error" value


  type IStepLabelClasses = interface end

  let inline private mkStepLabelClasses (key: string) (value: string) : IStepLabelClasses = unbox (key, value)

  [<Erase>]
  type stepLabel =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkStepLabelClasses "root" value
    /// Styles applied to the root element if `orientation="horizontal".
    static member inline horizontal(value: string) = mkStepLabelClasses "horizontal" value
    /// Styles applied to the root element if `orientation="vertical".
    static member inline vertical(value: string) = mkStepLabelClasses "vertical" value
    /// Styles applied to the `Typography` component which wraps `children`.
    static member inline label(value: string) = mkStepLabelClasses "label" value
    /// Pseudo-class applied to the `Typography` component if `active={true}`.
    static member inline active(value: string) = mkStepLabelClasses "active" value
    /// Pseudo-class applied to the `Typography` component if `completed={true}`.
    static member inline completed(value: string) = mkStepLabelClasses "completed" value
    /// Pseudo-class applied to the root element and `Typography` component if `error={true}`.
    static member inline error(value: string) = mkStepLabelClasses "error" value
    /// Pseudo-class applied to the root element and `Typography` component if `disabled={true}`.
    static member inline disabled(value: string) = mkStepLabelClasses "disabled" value
    /// Styles applied to the `icon` container element.
    static member inline iconContainer(value: string) = mkStepLabelClasses "iconContainer" value
    /// Pseudo-class applied to the root & icon container and `Typography` if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: string) = mkStepLabelClasses "alternativeLabel" value
    /// Styles applied to the container element which wraps `Typography` and `optional`.
    static member inline labelContainer(value: string) = mkStepLabelClasses "labelContainer" value


  type IStepperClasses = interface end

  let inline private mkStepperClasses (key: string) (value: string) : IStepperClasses = unbox (key, value)

  [<Erase>]
  type stepper =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkStepperClasses "root" value
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: string) = mkStepperClasses "horizontal" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) = mkStepperClasses "vertical" value
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: string) = mkStepperClasses "alternativeLabel" value


  type ISvgIconClasses = interface end

  let inline private mkSvgIconClasses (key: string) (value: string) : ISvgIconClasses = unbox (key, value)

  [<Erase>]
  type svgIcon =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkSvgIconClasses "root" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkSvgIconClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) = mkSvgIconClasses "colorSecondary" value
    /// Styles applied to the root element if `color="action"`.
    static member inline colorAction(value: string) = mkSvgIconClasses "colorAction" value
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: string) = mkSvgIconClasses "colorError" value
    /// Styles applied to the root element if `color="disabled"`.
    static member inline colorDisabled(value: string) = mkSvgIconClasses "colorDisabled" value
    /// Styles applied to the root element if `fontSize="inherit"`.
    static member inline fontSizeInherit(value: string) = mkSvgIconClasses "fontSizeInherit" value
    /// Styles applied to the root element if `fontSize="small"`.
    static member inline fontSizeSmall(value: string) = mkSvgIconClasses "fontSizeSmall" value
    /// Styles applied to the root element if `fontSize="large"`.
    static member inline fontSizeLarge(value: string) = mkSvgIconClasses "fontSizeLarge" value


  type ISwipeableDrawerClasses = interface end


  type ISwitchClasses = interface end

  let inline private mkSwitchClasses (key: string) (value: string) : ISwitchClasses = unbox (key, value)

  [<Erase>]
  type switch =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkSwitchClasses "root" value
    /// Styles applied to the root element if `edge="start"`.
    static member inline edgeStart(value: string) = mkSwitchClasses "edgeStart" value
    /// Styles applied to the root element if `edge="end"`.
    static member inline edgeEnd(value: string) = mkSwitchClasses "edgeEnd" value
    /// Styles applied to the internal `SwitchBase` component's `root` class.
    static member inline switchBase(value: string) = mkSwitchClasses "switchBase" value
    /// Styles applied to the internal SwitchBase component's root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkSwitchClasses "colorPrimary" value
    /// Styles applied to the internal SwitchBase component's root element if `color="secondary"`.
    static member inline colorSecondary(value: string) = mkSwitchClasses "colorSecondary" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) = mkSwitchClasses "sizeSmall" value
    /// Pseudo-class applied to the internal `SwitchBase` component's `checked` class.
    static member inline checked'(value: string) = mkSwitchClasses "checked" value
    /// Pseudo-class applied to the internal SwitchBase component's disabled class.
    static member inline disabled(value: string) = mkSwitchClasses "disabled" value
    /// Styles applied to the internal SwitchBase component's input element.
    static member inline input(value: string) = mkSwitchClasses "input" value
    /// Styles used to create the thumb passed to the internal `SwitchBase` component `icon` prop.
    static member inline thumb(value: string) = mkSwitchClasses "thumb" value
    /// Styles applied to the track element.
    static member inline track(value: string) = mkSwitchClasses "track" value


  type ITabClasses = interface end

  let inline private mkTabClasses (key: string) (value: string) : ITabClasses = unbox (key, value)

  [<Erase>]
  type tab =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTabClasses "root" value
    /// Styles applied to the root element if both `icon` and `label` are provided.
    static member inline labelIcon(value: string) = mkTabClasses "labelIcon" value
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="inherit"`.
    static member inline textColorInherit(value: string) = mkTabClasses "textColorInherit" value
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="primary"`.
    static member inline textColorPrimary(value: string) = mkTabClasses "textColorPrimary" value
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="secondary"`.
    static member inline textColorSecondary(value: string) = mkTabClasses "textColorSecondary" value
    /// Pseudo-class applied to the root element if `selected={true}` (controlled by the Tabs component).
    static member inline selected(value: string) = mkTabClasses "selected" value
    /// Pseudo-class applied to the root element if `disabled={true}` (controlled by the Tabs component).
    static member inline disabled(value: string) = mkTabClasses "disabled" value
    /// Styles applied to the root element if `fullWidth={true}` (controlled by the Tabs component).
    static member inline fullWidth(value: string) = mkTabClasses "fullWidth" value
    /// Styles applied to the root element if `wrapped={true}`.
    static member inline wrapped(value: string) = mkTabClasses "wrapped" value
    /// Styles applied to the `icon` and `label`'s wrapper element.
    static member inline wrapper(value: string) = mkTabClasses "wrapper" value


  type ITableClasses = interface end

  let inline private mkTableClasses (key: string) (value: string) : ITableClasses = unbox (key, value)

  [<Erase>]
  type table =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTableClasses "root" value


  type ITableBodyClasses = interface end

  let inline private mkTableBodyClasses (key: string) (value: string) : ITableBodyClasses = unbox (key, value)

  [<Erase>]
  type tableBody =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTableBodyClasses "root" value


  type ITableCellClasses = interface end

  let inline private mkTableCellClasses (key: string) (value: string) : ITableCellClasses = unbox (key, value)

  [<Erase>]
  type tableCell =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTableCellClasses "root" value
    /// Styles applied to the root element if `variant="head"` or `context.table.head`.
    static member inline head(value: string) = mkTableCellClasses "head" value
    /// Styles applied to the root element if `variant="body"` or `context.table.body`.
    static member inline body(value: string) = mkTableCellClasses "body" value
    /// Styles applied to the root element if `variant="footer"` or `context.table.footer`.
    static member inline footer(value: string) = mkTableCellClasses "footer" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) = mkTableCellClasses "sizeSmall" value
    /// Styles applied to the root element if `padding="checkbox"`.
    static member inline paddingCheckbox(value: string) = mkTableCellClasses "paddingCheckbox" value
    /// Styles applied to the root element if `padding="none"`.
    static member inline paddingNone(value: string) = mkTableCellClasses "paddingNone" value
    /// Styles applied to the root element if `align="left"`.
    static member inline alignLeft(value: string) = mkTableCellClasses "alignLeft" value
    /// Styles applied to the root element if `align="center"`.
    static member inline alignCenter(value: string) = mkTableCellClasses "alignCenter" value
    /// Styles applied to the root element if `align="right"`.
    static member inline alignRight(value: string) = mkTableCellClasses "alignRight" value
    /// Styles applied to the root element if `align="justify"`.
    static member inline alignJustify(value: string) = mkTableCellClasses "alignJustify" value


  type ITableFooterClasses = interface end

  let inline private mkTableFooterClasses (key: string) (value: string) : ITableFooterClasses = unbox (key, value)

  [<Erase>]
  type tableFooter =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTableFooterClasses "root" value


  type ITableHeadClasses = interface end

  let inline private mkTableHeadClasses (key: string) (value: string) : ITableHeadClasses = unbox (key, value)

  [<Erase>]
  type tableHead =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTableHeadClasses "root" value


  type ITablePaginationClasses = interface end

  let inline private mkTablePaginationClasses (key: string) (value: string) : ITablePaginationClasses = unbox (key, value)

  [<Erase>]
  type tablePagination =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTablePaginationClasses "root" value
    /// Styles applied to the Toolbar component.
    static member inline toolbar(value: string) = mkTablePaginationClasses "toolbar" value
    /// Styles applied to the spacer element.
    static member inline spacer(value: string) = mkTablePaginationClasses "spacer" value
    /// Styles applied to the caption Typography components if `variant="caption"`.
    static member inline caption(value: string) = mkTablePaginationClasses "caption" value
    /// Styles applied to the Select component root element.
    static member inline selectRoot(value: string) = mkTablePaginationClasses "selectRoot" value
    /// Styles applied to the Select component `select` class.
    static member inline select(value: string) = mkTablePaginationClasses "select" value
    /// Styles applied to the Select component `icon` class.
    static member inline selectIcon(value: string) = mkTablePaginationClasses "selectIcon" value
    /// Styles applied to the `InputBase` component.
    static member inline input(value: string) = mkTablePaginationClasses "input" value
    /// Styles applied to the MenuItem component.
    static member inline menuItem(value: string) = mkTablePaginationClasses "menuItem" value
    /// Styles applied to the internal `TablePaginationActions` component.
    static member inline actions(value: string) = mkTablePaginationClasses "actions" value


  type ITableRowClasses = interface end

  let inline private mkTableRowClasses (key: string) (value: string) : ITableRowClasses = unbox (key, value)

  [<Erase>]
  type tableRow =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTableRowClasses "root" value
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(value: string) = mkTableRowClasses "selected" value
    /// Pseudo-class applied to the root element if `hover={true}`.
    static member inline hover(value: string) = mkTableRowClasses "hover" value
    /// Styles applied to the root element if table variant="head".
    static member inline head(value: string) = mkTableRowClasses "head" value
    /// Styles applied to the root element if table variant="footer".
    static member inline footer(value: string) = mkTableRowClasses "footer" value


  type ITableSortLabelClasses = interface end

  let inline private mkTableSortLabelClasses (key: string) (value: string) : ITableSortLabelClasses = unbox (key, value)

  [<Erase>]
  type tableSortLabel =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTableSortLabelClasses "root" value
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(value: string) = mkTableSortLabelClasses "active" value
    /// Styles applied to the icon component.
    static member inline icon(value: string) = mkTableSortLabelClasses "icon" value
    /// Styles applied to the icon component if `direction="desc"`.
    static member inline iconDirectionDesc(value: string) = mkTableSortLabelClasses "iconDirectionDesc" value
    /// Styles applied to the icon component if `direction="asc"`.
    static member inline iconDirectionAsc(value: string) = mkTableSortLabelClasses "iconDirectionAsc" value


  type ITabsClasses = interface end

  let inline private mkTabsClasses (key: string) (value: string) : ITabsClasses = unbox (key, value)

  [<Erase>]
  type tabs =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTabsClasses "root" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) = mkTabsClasses "vertical" value
    /// Styles applied to the flex container element.
    static member inline flexContainer(value: string) = mkTabsClasses "flexContainer" value
    /// Styles applied to the flex container element if `orientation="vertical"`.
    static member inline flexContainerVertical(value: string) = mkTabsClasses "flexContainerVertical" value
    /// Styles applied to the flex container element if `centered={true}`&`!variant="scrollable"`.
    static member inline centered(value: string) = mkTabsClasses "centered" value
    /// Styles applied to the tablist element.
    static member inline scroller(value: string) = mkTabsClasses "scroller" value
    /// Styles applied to the tablist element if `!variant="scrollable"`.
    static member inline fixed'(value: string) = mkTabsClasses "fixed" value
    /// Styles applied to the tablist element if `variant="scrollable"`.
    static member inline scrollable(value: string) = mkTabsClasses "scrollable" value
    /// Styles applied to the `ScrollButtonComponent` component.
    static member inline scrollButtons(value: string) = mkTabsClasses "scrollButtons" value
    /// Styles applied to the `ScrollButtonComponent` component if `scrollButtons="auto"` or scrollButtons="desktop"`.
    static member inline scrollButtonsDesktop(value: string) = mkTabsClasses "scrollButtonsDesktop" value
    /// Styles applied to the `TabIndicator` component.
    static member inline indicator(value: string) = mkTabsClasses "indicator" value


  type ITextareaAutosizeClasses = interface end


  type ITextFieldClasses = interface end

  let inline private mkTextFieldClasses (key: string) (value: string) : ITextFieldClasses = unbox (key, value)

  [<Erase>]
  type textField =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTextFieldClasses "root" value


  type IToggleButtonClasses = interface end

  let inline private mkToggleButtonClasses (key: string) (value: string) : IToggleButtonClasses = unbox (key, value)

  [<Erase>]
  type toggleButton =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkToggleButtonClasses "root" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) = mkToggleButtonClasses "disabled" value
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(value: string) = mkToggleButtonClasses "selected" value
    /// Styles applied to the `label` wrapper element.
    static member inline label(value: string) = mkToggleButtonClasses "label" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) = mkToggleButtonClasses "sizeSmall" value
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(value: string) = mkToggleButtonClasses "sizeLarge" value


  type IToggleButtonGroupClasses = interface end

  let inline private mkToggleButtonGroupClasses (key: string) (value: string) : IToggleButtonGroupClasses = unbox (key, value)

  [<Erase>]
  type toggleButtonGroup =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkToggleButtonGroupClasses "root" value


  type IToolbarClasses = interface end

  let inline private mkToolbarClasses (key: string) (value: string) : IToolbarClasses = unbox (key, value)

  [<Erase>]
  type toolbar =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkToolbarClasses "root" value
    /// Styles applied to the root element if `disableGutters={false}`.
    static member inline gutters(value: string) = mkToolbarClasses "gutters" value
    /// Styles applied to the root element if `variant="regular"`.
    static member inline regular(value: string) = mkToolbarClasses "regular" value
    /// Styles applied to the root element if `variant="dense"`.
    static member inline dense(value: string) = mkToolbarClasses "dense" value


  type ITooltipClasses = interface end

  let inline private mkTooltipClasses (key: string) (value: string) : ITooltipClasses = unbox (key, value)

  [<Erase>]
  type tooltip =
    /// Styles applied to the Popper component.
    static member inline popper(value: string) = mkTooltipClasses "popper" value
    /// Styles applied to the Popper component if `interactive={true}`.
    static member inline popperInteractive(value: string) = mkTooltipClasses "popperInteractive" value
    /// Styles applied to the tooltip (label wrapper) element.
    static member inline tooltip(value: string) = mkTooltipClasses "tooltip" value
    /// Styles applied to the tooltip (label wrapper) element if the tooltip is opened by touch.
    static member inline touch(value: string) = mkTooltipClasses "touch" value
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "left".
    static member inline tooltipPlacementLeft(value: string) = mkTooltipClasses "tooltipPlacementLeft" value
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "right".
    static member inline tooltipPlacementRight(value: string) = mkTooltipClasses "tooltipPlacementRight" value
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "top".
    static member inline tooltipPlacementTop(value: string) = mkTooltipClasses "tooltipPlacementTop" value
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "bottom".
    static member inline tooltipPlacementBottom(value: string) = mkTooltipClasses "tooltipPlacementBottom" value


  type ITouchRippleClasses = interface end

  let inline private mkTouchRippleClasses (key: string) (value: string) : ITouchRippleClasses = unbox (key, value)

  [<Erase>]
  type touchRipple =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTouchRippleClasses "root" value
    /// Styles applied to the internal `Ripple` components `ripple` class.
    static member inline ripple(value: string) = mkTouchRippleClasses "ripple" value
    /// Styles applied to the internal `Ripple` components `rippleVisible` class.
    static member inline rippleVisible(value: string) = mkTouchRippleClasses "rippleVisible" value
    /// Styles applied to the internal `Ripple` components `ripplePulsate` class.
    static member inline ripplePulsate(value: string) = mkTouchRippleClasses "ripplePulsate" value
    /// Styles applied to the internal `Ripple` components `child` class.
    static member inline child(value: string) = mkTouchRippleClasses "child" value
    /// Styles applied to the internal `Ripple` components `childLeaving` class.
    static member inline childLeaving(value: string) = mkTouchRippleClasses "childLeaving" value
    /// Styles applied to the internal `Ripple` components `childPulsate` class.
    static member inline childPulsate(value: string) = mkTouchRippleClasses "childPulsate" value


  type ITreeItemClasses = interface end

  let inline private mkTreeItemClasses (key: string) (value: string) : ITreeItemClasses = unbox (key, value)

  [<Erase>]
  type treeItem =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTreeItemClasses "root" value
    /// Pseudo-class applied to the root element when expanded.
    static member inline expanded(value: string) = mkTreeItemClasses "expanded" value
    /// Styles applied to the `role="group"` element.
    static member inline group(value: string) = mkTreeItemClasses "group" value
    /// Styles applied to the tree node content.
    static member inline content(value: string) = mkTreeItemClasses "content" value
    /// Styles applied to the tree node icon and collapse/expand icon.
    static member inline iconContainer(value: string) = mkTreeItemClasses "iconContainer" value
    /// Styles applied to the label element.
    static member inline label(value: string) = mkTreeItemClasses "label" value


  type ITreeViewClasses = interface end

  let inline private mkTreeViewClasses (key: string) (value: string) : ITreeViewClasses = unbox (key, value)

  [<Erase>]
  type treeView =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTreeViewClasses "root" value


  type ITypographyClasses = interface end

  let inline private mkTypographyClasses (key: string) (value: string) : ITypographyClasses = unbox (key, value)

  [<Erase>]
  type typography =
    /// Styles applied to the root element.
    static member inline root(value: string) = mkTypographyClasses "root" value
    /// Styles applied to the root element if `variant="body2"`.
    static member inline body2(value: string) = mkTypographyClasses "body2" value
    /// Styles applied to the root element if `variant="body1"`.
    static member inline body1(value: string) = mkTypographyClasses "body1" value
    /// Styles applied to the root element if `variant="caption"`.
    static member inline caption(value: string) = mkTypographyClasses "caption" value
    /// Styles applied to the root element if `variant="button"`.
    static member inline button(value: string) = mkTypographyClasses "button" value
    /// Styles applied to the root element if `variant="h1"`.
    static member inline h1(value: string) = mkTypographyClasses "h1" value
    /// Styles applied to the root element if `variant="h2"`.
    static member inline h2(value: string) = mkTypographyClasses "h2" value
    /// Styles applied to the root element if `variant="h3"`.
    static member inline h3(value: string) = mkTypographyClasses "h3" value
    /// Styles applied to the root element if `variant="h4"`.
    static member inline h4(value: string) = mkTypographyClasses "h4" value
    /// Styles applied to the root element if `variant="h5"`.
    static member inline h5(value: string) = mkTypographyClasses "h5" value
    /// Styles applied to the root element if `variant="h6"`.
    static member inline h6(value: string) = mkTypographyClasses "h6" value
    /// Styles applied to the root element if `variant="subtitle1"`.
    static member inline subtitle1(value: string) = mkTypographyClasses "subtitle1" value
    /// Styles applied to the root element if `variant="subtitle2"`.
    static member inline subtitle2(value: string) = mkTypographyClasses "subtitle2" value
    /// Styles applied to the root element if `variant="overline"`.
    static member inline overline(value: string) = mkTypographyClasses "overline" value
    /// Styles applied to the root element if `variant="srOnly"`. Only accessible to screen readers.
    static member inline srOnly(value: string) = mkTypographyClasses "srOnly" value
    /// Styles applied to the root element if `align="left"`.
    static member inline alignLeft(value: string) = mkTypographyClasses "alignLeft" value
    /// Styles applied to the root element if `align="center"`.
    static member inline alignCenter(value: string) = mkTypographyClasses "alignCenter" value
    /// Styles applied to the root element if `align="right"`.
    static member inline alignRight(value: string) = mkTypographyClasses "alignRight" value
    /// Styles applied to the root element if `align="justify"`.
    static member inline alignJustify(value: string) = mkTypographyClasses "alignJustify" value
    /// Styles applied to the root element if `align="nowrap"`.
    static member inline noWrap(value: string) = mkTypographyClasses "noWrap" value
    /// Styles applied to the root element if `gutterBottom={true}`.
    static member inline gutterBottom(value: string) = mkTypographyClasses "gutterBottom" value
    /// Styles applied to the root element if `paragraph={true}`.
    static member inline paragraph(value: string) = mkTypographyClasses "paragraph" value
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: string) = mkTypographyClasses "colorInherit" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) = mkTypographyClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) = mkTypographyClasses "colorSecondary" value
    /// Styles applied to the root element if `color="textPrimary"`.
    static member inline colorTextPrimary(value: string) = mkTypographyClasses "colorTextPrimary" value
    /// Styles applied to the root element if `color="textSecondary"`.
    static member inline colorTextSecondary(value: string) = mkTypographyClasses "colorTextSecondary" value
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: string) = mkTypographyClasses "colorError" value
    /// Styles applied to the root element if `display="inline"`.
    static member inline displayInline(value: string) = mkTypographyClasses "displayInline" value
    /// Styles applied to the root element if `display="block"`.
    static member inline displayBlock(value: string) = mkTypographyClasses "displayBlock" value


  type IZoomClasses = interface end

