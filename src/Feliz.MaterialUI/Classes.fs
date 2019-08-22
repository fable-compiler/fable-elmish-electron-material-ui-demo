namespace Feliz.MaterialUI
  
//////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
//////////////////////////////////

open Fable.Core
  
type IClassName = interface end
  
/// Override or extend the styles applied to components.
module classes =

  type IAppBarClasses = interface end

  let inline private mkAppBarClasses (key: string) (value: IClassName) : IAppBarClasses = unbox (key, value)

  [<Erase>]
  type appBar =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkAppBarClasses "root" value
    /// Styles applied to the root element if `position="fixed"`.
    static member inline positionFixed(value: IClassName) = mkAppBarClasses "positionFixed" value
    /// Styles applied to the root element if `position="absolute"`.
    static member inline positionAbsolute(value: IClassName) = mkAppBarClasses "positionAbsolute" value
    /// Styles applied to the root element if `position="sticky"`.
    static member inline positionSticky(value: IClassName) = mkAppBarClasses "positionSticky" value
    /// Styles applied to the root element if `position="static"`.
    static member inline positionStatic(value: IClassName) = mkAppBarClasses "positionStatic" value
    /// Styles applied to the root element if `position="relative"`.
    static member inline positionRelative(value: IClassName) = mkAppBarClasses "positionRelative" value
    /// Styles applied to the root element if `color="default"`.
    static member inline colorDefault(value: IClassName) = mkAppBarClasses "colorDefault" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkAppBarClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: IClassName) = mkAppBarClasses "colorSecondary" value


  type IAvatarClasses = interface end

  let inline private mkAvatarClasses (key: string) (value: IClassName) : IAvatarClasses = unbox (key, value)

  [<Erase>]
  type avatar =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkAvatarClasses "root" value
    /// Styles applied to the root element if there are children and not `src` or `srcSet`.
    static member inline colorDefault(value: IClassName) = mkAvatarClasses "colorDefault" value
    /// Styles applied to the img element if either `src` or `srcSet` is defined.
    static member inline img(value: IClassName) = mkAvatarClasses "img" value


  type IBackdropClasses = interface end

  let inline private mkBackdropClasses (key: string) (value: IClassName) : IBackdropClasses = unbox (key, value)

  [<Erase>]
  type backdrop =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkBackdropClasses "root" value
    /// Styles applied to the root element if `invisible={true}`.
    static member inline invisible(value: IClassName) = mkBackdropClasses "invisible" value


  type IBadgeClasses = interface end

  let inline private mkBadgeClasses (key: string) (value: IClassName) : IBadgeClasses = unbox (key, value)

  [<Erase>]
  type badge =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkBadgeClasses "root" value
    /// Styles applied to the badge `span` element.
    static member inline badge(value: IClassName) = mkBadgeClasses "badge" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkBadgeClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: IClassName) = mkBadgeClasses "colorSecondary" value
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: IClassName) = mkBadgeClasses "colorError" value
    /// Styles applied to the badge `span` element if `invisible={true}`.
    static member inline invisible(value: IClassName) = mkBadgeClasses "invisible" value
    /// Styles applied to the root element if `variant="dot"`.
    static member inline dot(value: IClassName) = mkBadgeClasses "dot" value


  type IBottomNavigationClasses = interface end

  let inline private mkBottomNavigationClasses (key: string) (value: IClassName) : IBottomNavigationClasses = unbox (key, value)

  [<Erase>]
  type bottomNavigation =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkBottomNavigationClasses "root" value


  type IBottomNavigationActionClasses = interface end

  let inline private mkBottomNavigationActionClasses (key: string) (value: IClassName) : IBottomNavigationActionClasses = unbox (key, value)

  [<Erase>]
  type bottomNavigationAction =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkBottomNavigationActionClasses "root" value
    /// Pseudo-class applied to the root element if selected.
    static member inline selected(value: IClassName) = mkBottomNavigationActionClasses "selected" value
    /// Pseudo-class applied to the root element if `showLabel={false}` and not selected.
    static member inline iconOnly(value: IClassName) = mkBottomNavigationActionClasses "iconOnly" value
    /// Styles applied to the span element that wraps the icon and label.
    static member inline wrapper(value: IClassName) = mkBottomNavigationActionClasses "wrapper" value
    /// Styles applied to the label's span element.
    static member inline label(value: IClassName) = mkBottomNavigationActionClasses "label" value


  type IBreadcrumbsClasses = interface end

  let inline private mkBreadcrumbsClasses (key: string) (value: IClassName) : IBreadcrumbsClasses = unbox (key, value)

  [<Erase>]
  type breadcrumbs =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkBreadcrumbsClasses "root" value
    /// Styles applied to the ol element.
    static member inline ol(value: IClassName) = mkBreadcrumbsClasses "ol" value
    /// Styles applied to the li element.
    static member inline li(value: IClassName) = mkBreadcrumbsClasses "li" value
    /// Styles applied to the separator element.
    static member inline separator(value: IClassName) = mkBreadcrumbsClasses "separator" value


  type IButtonClasses = interface end

  let inline private mkButtonClasses (key: string) (value: IClassName) : IButtonClasses = unbox (key, value)

  [<Erase>]
  type button =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkButtonClasses "root" value
    /// Styles applied to the span element that wraps the children.
    static member inline label(value: IClassName) = mkButtonClasses "label" value
    /// Styles applied to the root element if `variant="text"`.
    static member inline text(value: IClassName) = mkButtonClasses "text" value
    /// Styles applied to the root element if `variant="text"` and `color="primary"`.
    static member inline textPrimary(value: IClassName) = mkButtonClasses "textPrimary" value
    /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
    static member inline textSecondary(value: IClassName) = mkButtonClasses "textSecondary" value
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(value: IClassName) = mkButtonClasses "outlined" value
    /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
    static member inline outlinedPrimary(value: IClassName) = mkButtonClasses "outlinedPrimary" value
    /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
    static member inline outlinedSecondary(value: IClassName) = mkButtonClasses "outlinedSecondary" value
    /// Styles applied to the root element if `variant="contained"`.
    static member inline contained(value: IClassName) = mkButtonClasses "contained" value
    /// Styles applied to the root element if `variant="contained"` and `color="primary"`.
    static member inline containedPrimary(value: IClassName) = mkButtonClasses "containedPrimary" value
    /// Styles applied to the root element if `variant="contained"` and `color="secondary"`.
    static member inline containedSecondary(value: IClassName) = mkButtonClasses "containedSecondary" value
    /// Pseudo-class applied to the ButtonBase root element if the button is keyboard focused.
    static member inline focusVisible(value: IClassName) = mkButtonClasses "focusVisible" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkButtonClasses "disabled" value
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: IClassName) = mkButtonClasses "colorInherit" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: IClassName) = mkButtonClasses "sizeSmall" value
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(value: IClassName) = mkButtonClasses "sizeLarge" value
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: IClassName) = mkButtonClasses "fullWidth" value


  type IButtonBaseClasses = interface end

  let inline private mkButtonBaseClasses (key: string) (value: IClassName) : IButtonBaseClasses = unbox (key, value)

  [<Erase>]
  type buttonBase =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkButtonBaseClasses "root" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkButtonBaseClasses "disabled" value
    /// Pseudo-class applied to the root element if keyboard focused.
    static member inline focusVisible(value: IClassName) = mkButtonBaseClasses "focusVisible" value


  type IButtonGroupClasses = interface end

  let inline private mkButtonGroupClasses (key: string) (value: IClassName) : IButtonGroupClasses = unbox (key, value)

  [<Erase>]
  type buttonGroup =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkButtonGroupClasses "root" value
    /// Styles applied to the root element if variant="contained".
    static member inline contained(value: IClassName) = mkButtonGroupClasses "contained" value
    /// Styles applied to the root element if fullWidth={true}.
    static member inline fullWidth(value: IClassName) = mkButtonGroupClasses "fullWidth" value
    /// Styles applied to the children.
    static member inline grouped(value: IClassName) = mkButtonGroupClasses "grouped" value
    /// Styles applied to the children if variant="outlined".
    static member inline groupedOutlined(value: IClassName) = mkButtonGroupClasses "groupedOutlined" value
    /// Styles applied to the children if variant="outlined"& color="primary".
    static member inline groupedOutlinedPrimary(value: IClassName) = mkButtonGroupClasses "groupedOutlinedPrimary" value
    /// Styles applied to the children if variant="outlined"& color="secondary".
    static member inline groupedOutlinedSecondary(value: IClassName) = mkButtonGroupClasses "groupedOutlinedSecondary" value
    /// Styles applied to the children if variant="contained".
    static member inline groupedContained(value: IClassName) = mkButtonGroupClasses "groupedContained" value
    /// Styles applied to the children if variant="contained"& color="primary".
    static member inline groupedContainedPrimary(value: IClassName) = mkButtonGroupClasses "groupedContainedPrimary" value
    /// Styles applied to the children if variant="contained"& color="secondary".
    static member inline groupedContainedSecondary(value: IClassName) = mkButtonGroupClasses "groupedContainedSecondary" value


  type ICardClasses = interface end

  let inline private mkCardClasses (key: string) (value: IClassName) : ICardClasses = unbox (key, value)

  [<Erase>]
  type card =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkCardClasses "root" value


  type ICardActionAreaClasses = interface end

  let inline private mkCardActionAreaClasses (key: string) (value: IClassName) : ICardActionAreaClasses = unbox (key, value)

  [<Erase>]
  type cardActionArea =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkCardActionAreaClasses "root" value
    /// Pseudo-class applied to the ButtonBase root element if the action area is keyboard focused.
    static member inline focusVisible(value: IClassName) = mkCardActionAreaClasses "focusVisible" value
    /// Styles applied to the overlay that covers the action area when it is keyboard focused.
    static member inline focusHighlight(value: IClassName) = mkCardActionAreaClasses "focusHighlight" value


  type ICardActionsClasses = interface end

  let inline private mkCardActionsClasses (key: string) (value: IClassName) : ICardActionsClasses = unbox (key, value)

  [<Erase>]
  type cardActions =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkCardActionsClasses "root" value
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(value: IClassName) = mkCardActionsClasses "spacing" value


  type ICardContentClasses = interface end

  let inline private mkCardContentClasses (key: string) (value: IClassName) : ICardContentClasses = unbox (key, value)

  [<Erase>]
  type cardContent =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkCardContentClasses "root" value


  type ICardHeaderClasses = interface end

  let inline private mkCardHeaderClasses (key: string) (value: IClassName) : ICardHeaderClasses = unbox (key, value)

  [<Erase>]
  type cardHeader =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkCardHeaderClasses "root" value
    /// Styles applied to the avatar element.
    static member inline avatar(value: IClassName) = mkCardHeaderClasses "avatar" value
    /// Styles applied to the action element.
    static member inline action(value: IClassName) = mkCardHeaderClasses "action" value
    /// Styles applied to the content wrapper element.
    static member inline content(value: IClassName) = mkCardHeaderClasses "content" value
    /// Styles applied to the title Typography element.
    static member inline title(value: IClassName) = mkCardHeaderClasses "title" value
    /// Styles applied to the subheader Typography element.
    static member inline subheader(value: IClassName) = mkCardHeaderClasses "subheader" value


  type ICardMediaClasses = interface end

  let inline private mkCardMediaClasses (key: string) (value: IClassName) : ICardMediaClasses = unbox (key, value)

  [<Erase>]
  type cardMedia =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkCardMediaClasses "root" value
    /// Styles applied to the root element if `component="video, audio, picture, iframe, or img"`.
    static member inline media(value: IClassName) = mkCardMediaClasses "media" value


  type ICheckboxClasses = interface end

  let inline private mkCheckboxClasses (key: string) (value: IClassName) : ICheckboxClasses = unbox (key, value)

  [<Erase>]
  type checkbox =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkCheckboxClasses "root" value
    /// Pseudo-class applied to the root element if `checked={true}`.
    static member inline checked'(value: IClassName) = mkCheckboxClasses "checked" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkCheckboxClasses "disabled" value
    /// Pseudo-class applied to the root element if `indeterminate={true}`.
    static member inline indeterminate(value: IClassName) = mkCheckboxClasses "indeterminate" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkCheckboxClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: IClassName) = mkCheckboxClasses "colorSecondary" value


  type IChipClasses = interface end

  let inline private mkChipClasses (key: string) (value: IClassName) : IChipClasses = unbox (key, value)

  [<Erase>]
  type chip =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkChipClasses "root" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: IClassName) = mkChipClasses "sizeSmall" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkChipClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: IClassName) = mkChipClasses "colorSecondary" value
    /// Styles applied to the root element if `onClick` is defined or `clickable={true}`.
    static member inline clickable(value: IClassName) = mkChipClasses "clickable" value
    /// Styles applied to the root element if `onClick` and `color="primary"` is defined or `clickable={true}`.
    static member inline clickableColorPrimary(value: IClassName) = mkChipClasses "clickableColorPrimary" value
    /// Styles applied to the root element if `onClick` and `color="secondary"` is defined or `clickable={true}`.
    static member inline clickableColorSecondary(value: IClassName) = mkChipClasses "clickableColorSecondary" value
    /// Styles applied to the root element if `onDelete` is defined.
    static member inline deletable(value: IClassName) = mkChipClasses "deletable" value
    /// Styles applied to the root element if `onDelete` and `color="primary"` is defined.
    static member inline deletableColorPrimary(value: IClassName) = mkChipClasses "deletableColorPrimary" value
    /// Styles applied to the root element if `onDelete` and `color="secondary"` is defined.
    static member inline deletableColorSecondary(value: IClassName) = mkChipClasses "deletableColorSecondary" value
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(value: IClassName) = mkChipClasses "outlined" value
    /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
    static member inline outlinedPrimary(value: IClassName) = mkChipClasses "outlinedPrimary" value
    /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
    static member inline outlinedSecondary(value: IClassName) = mkChipClasses "outlinedSecondary" value
    /// Styles applied to the `avatar` element.
    static member inline avatar(value: IClassName) = mkChipClasses "avatar" value
    static member inline avatarSmall(value: IClassName) = mkChipClasses "avatarSmall" value
    /// Styles applied to the `avatar` element if `color="primary"`.
    static member inline avatarColorPrimary(value: IClassName) = mkChipClasses "avatarColorPrimary" value
    /// Styles applied to the `avatar` element if `color="secondary"`.
    static member inline avatarColorSecondary(value: IClassName) = mkChipClasses "avatarColorSecondary" value
    /// Styles applied to the `avatar` elements children.
    static member inline avatarChildren(value: IClassName) = mkChipClasses "avatarChildren" value
    /// Styles applied to the `icon` element.
    static member inline icon(value: IClassName) = mkChipClasses "icon" value
    static member inline iconSmall(value: IClassName) = mkChipClasses "iconSmall" value
    /// Styles applied to the `icon` element if `color="primary"`.
    static member inline iconColorPrimary(value: IClassName) = mkChipClasses "iconColorPrimary" value
    /// Styles applied to the `icon` element if `color="secondary"`.
    static member inline iconColorSecondary(value: IClassName) = mkChipClasses "iconColorSecondary" value
    /// Styles applied to the label `span` element`.
    static member inline label(value: IClassName) = mkChipClasses "label" value
    static member inline labelSmall(value: IClassName) = mkChipClasses "labelSmall" value
    /// Styles applied to the `deleteIcon` element.
    static member inline deleteIcon(value: IClassName) = mkChipClasses "deleteIcon" value
    static member inline deleteIconSmall(value: IClassName) = mkChipClasses "deleteIconSmall" value
    /// Styles applied to the deleteIcon element if `color="primary"` and `variant="default"`.
    static member inline deleteIconColorPrimary(value: IClassName) = mkChipClasses "deleteIconColorPrimary" value
    /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="default"`.
    static member inline deleteIconColorSecondary(value: IClassName) = mkChipClasses "deleteIconColorSecondary" value
    /// Styles applied to the deleteIcon element if `color="primary"` and `variant="outlined"`.
    static member inline deleteIconOutlinedColorPrimary(value: IClassName) = mkChipClasses "deleteIconOutlinedColorPrimary" value
    /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="outlined"`.
    static member inline deleteIconOutlinedColorSecondary(value: IClassName) = mkChipClasses "deleteIconOutlinedColorSecondary" value


  type ICircularProgressClasses = interface end

  let inline private mkCircularProgressClasses (key: string) (value: IClassName) : ICircularProgressClasses = unbox (key, value)

  [<Erase>]
  type circularProgress =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkCircularProgressClasses "root" value
    /// Styles applied to the root element if `variant="static"`.
    static member inline static'(value: IClassName) = mkCircularProgressClasses "static" value
    /// Styles applied to the root element if `variant="indeterminate"`.
    static member inline indeterminate(value: IClassName) = mkCircularProgressClasses "indeterminate" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkCircularProgressClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: IClassName) = mkCircularProgressClasses "colorSecondary" value
    /// Styles applied to the `svg` element.
    static member inline svg(value: IClassName) = mkCircularProgressClasses "svg" value
    /// Styles applied to the `circle` svg path.
    static member inline circle(value: IClassName) = mkCircularProgressClasses "circle" value
    /// Styles applied to the `circle` svg path if `variant="static"`.
    static member inline circleStatic(value: IClassName) = mkCircularProgressClasses "circleStatic" value
    /// Styles applied to the `circle` svg path if `variant="indeterminate"`.
    static member inline circleIndeterminate(value: IClassName) = mkCircularProgressClasses "circleIndeterminate" value
    /// Styles applied to the `circle` svg path if `disableShrink={true}`.
    static member inline circleDisableShrink(value: IClassName) = mkCircularProgressClasses "circleDisableShrink" value


  type IClickAwayListenerClasses = interface end


  type ICollapseClasses = interface end

  let inline private mkCollapseClasses (key: string) (value: IClassName) : ICollapseClasses = unbox (key, value)

  [<Erase>]
  type collapse =
    /// Styles applied to the container element.
    static member inline container(value: IClassName) = mkCollapseClasses "container" value
    /// Styles applied to the container element when the transition has entered.
    static member inline entered(value: IClassName) = mkCollapseClasses "entered" value
    /// Styles applied to the container element when the transition has exited and `collapsedHeight` != 0px.
    static member inline hidden(value: IClassName) = mkCollapseClasses "hidden" value
    /// Styles applied to the outer wrapper element.
    static member inline wrapper(value: IClassName) = mkCollapseClasses "wrapper" value
    /// Styles applied to the inner wrapper element.
    static member inline wrapperInner(value: IClassName) = mkCollapseClasses "wrapperInner" value


  type IContainerClasses = interface end

  let inline private mkContainerClasses (key: string) (value: IClassName) : IContainerClasses = unbox (key, value)

  [<Erase>]
  type container =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkContainerClasses "root" value
    /// Styles applied to the root element if `fixed={true}`.
    static member inline fixed'(value: IClassName) = mkContainerClasses "fixed" value
    /// Styles applied to the root element if `maxWidth="xs"`.
    static member inline maxWidthXs(value: IClassName) = mkContainerClasses "maxWidthXs" value
    /// Styles applied to the root element if `maxWidth="sm"`.
    static member inline maxWidthSm(value: IClassName) = mkContainerClasses "maxWidthSm" value
    /// Styles applied to the root element if `maxWidth="md"`.
    static member inline maxWidthMd(value: IClassName) = mkContainerClasses "maxWidthMd" value
    /// Styles applied to the root element if `maxWidth="lg"`.
    static member inline maxWidthLg(value: IClassName) = mkContainerClasses "maxWidthLg" value
    /// Styles applied to the root element if `maxWidth="xl"`.
    static member inline maxWidthXl(value: IClassName) = mkContainerClasses "maxWidthXl" value


  type ICssBaselineClasses = interface end


  type IDialogClasses = interface end

  let inline private mkDialogClasses (key: string) (value: IClassName) : IDialogClasses = unbox (key, value)

  [<Erase>]
  type dialog =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkDialogClasses "root" value
    /// Styles applied to the container element if `scroll="paper"`.
    static member inline scrollPaper(value: IClassName) = mkDialogClasses "scrollPaper" value
    /// Styles applied to the container element if `scroll="body"`.
    static member inline scrollBody(value: IClassName) = mkDialogClasses "scrollBody" value
    /// Styles applied to the container element.
    static member inline container(value: IClassName) = mkDialogClasses "container" value
    /// Styles applied to the `Paper` component.
    static member inline paper(value: IClassName) = mkDialogClasses "paper" value
    /// Styles applied to the `Paper` component if `scroll="paper"`.
    static member inline paperScrollPaper(value: IClassName) = mkDialogClasses "paperScrollPaper" value
    /// Styles applied to the `Paper` component if `scroll="body"`.
    static member inline paperScrollBody(value: IClassName) = mkDialogClasses "paperScrollBody" value
    /// Styles applied to the `Paper` component if `maxWidth=false`.
    static member inline paperWidthFalse(value: IClassName) = mkDialogClasses "paperWidthFalse" value
    /// Styles applied to the `Paper` component if `maxWidth="xs"`.
    static member inline paperWidthXs(value: IClassName) = mkDialogClasses "paperWidthXs" value
    /// Styles applied to the `Paper` component if `maxWidth="sm"`.
    static member inline paperWidthSm(value: IClassName) = mkDialogClasses "paperWidthSm" value
    /// Styles applied to the `Paper` component if `maxWidth="md"`.
    static member inline paperWidthMd(value: IClassName) = mkDialogClasses "paperWidthMd" value
    /// Styles applied to the `Paper` component if `maxWidth="lg"`.
    static member inline paperWidthLg(value: IClassName) = mkDialogClasses "paperWidthLg" value
    /// Styles applied to the `Paper` component if `maxWidth="xl"`.
    static member inline paperWidthXl(value: IClassName) = mkDialogClasses "paperWidthXl" value
    /// Styles applied to the `Paper` component if `fullWidth={true}`.
    static member inline paperFullWidth(value: IClassName) = mkDialogClasses "paperFullWidth" value
    /// Styles applied to the `Paper` component if `fullScreen={true}`.
    static member inline paperFullScreen(value: IClassName) = mkDialogClasses "paperFullScreen" value


  type IDialogActionsClasses = interface end

  let inline private mkDialogActionsClasses (key: string) (value: IClassName) : IDialogActionsClasses = unbox (key, value)

  [<Erase>]
  type dialogActions =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkDialogActionsClasses "root" value
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(value: IClassName) = mkDialogActionsClasses "spacing" value


  type IDialogContentClasses = interface end

  let inline private mkDialogContentClasses (key: string) (value: IClassName) : IDialogContentClasses = unbox (key, value)

  [<Erase>]
  type dialogContent =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkDialogContentClasses "root" value
    /// Styles applied to the root element if `dividers={true}`.
    static member inline dividers(value: IClassName) = mkDialogContentClasses "dividers" value


  type IDialogContentTextClasses = interface end

  let inline private mkDialogContentTextClasses (key: string) (value: IClassName) : IDialogContentTextClasses = unbox (key, value)

  [<Erase>]
  type dialogContentText =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkDialogContentTextClasses "root" value


  type IDialogTitleClasses = interface end

  let inline private mkDialogTitleClasses (key: string) (value: IClassName) : IDialogTitleClasses = unbox (key, value)

  [<Erase>]
  type dialogTitle =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkDialogTitleClasses "root" value


  type IDividerClasses = interface end

  let inline private mkDividerClasses (key: string) (value: IClassName) : IDividerClasses = unbox (key, value)

  [<Erase>]
  type divider =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkDividerClasses "root" value
    /// Styles applied to the root element if `absolute={true}`.
    static member inline absolute(value: IClassName) = mkDividerClasses "absolute" value
    /// Styles applied to the root element if `variant="inset"`.
    static member inline inset(value: IClassName) = mkDividerClasses "inset" value
    /// Styles applied to the root element if `light={true}`.
    static member inline light(value: IClassName) = mkDividerClasses "light" value
    /// Styles applied to the root element if `variant="middle"`.
    static member inline middle(value: IClassName) = mkDividerClasses "middle" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: IClassName) = mkDividerClasses "vertical" value


  type IDrawerClasses = interface end

  let inline private mkDrawerClasses (key: string) (value: IClassName) : IDrawerClasses = unbox (key, value)

  [<Erase>]
  type drawer =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkDrawerClasses "root" value
    /// Styles applied to the root element if `variant="permanent or persistent"`.
    static member inline docked(value: IClassName) = mkDrawerClasses "docked" value
    /// Styles applied to the `Paper` component.
    static member inline paper(value: IClassName) = mkDrawerClasses "paper" value
    /// Styles applied to the `Paper` component if `anchor="left"`.
    static member inline paperAnchorLeft(value: IClassName) = mkDrawerClasses "paperAnchorLeft" value
    /// Styles applied to the `Paper` component if `anchor="right"`.
    static member inline paperAnchorRight(value: IClassName) = mkDrawerClasses "paperAnchorRight" value
    /// Styles applied to the `Paper` component if `anchor="top"`.
    static member inline paperAnchorTop(value: IClassName) = mkDrawerClasses "paperAnchorTop" value
    /// Styles applied to the `Paper` component if `anchor="bottom"`.
    static member inline paperAnchorBottom(value: IClassName) = mkDrawerClasses "paperAnchorBottom" value
    /// Styles applied to the `Paper` component if `anchor="left"`&`variant` is not "temporary".
    static member inline paperAnchorDockedLeft(value: IClassName) = mkDrawerClasses "paperAnchorDockedLeft" value
    /// Styles applied to the `Paper` component if `anchor="top"`&`variant` is not "temporary".
    static member inline paperAnchorDockedTop(value: IClassName) = mkDrawerClasses "paperAnchorDockedTop" value
    /// Styles applied to the `Paper` component if `anchor="right"`&`variant` is not "temporary".
    static member inline paperAnchorDockedRight(value: IClassName) = mkDrawerClasses "paperAnchorDockedRight" value
    /// Styles applied to the `Paper` component if `anchor="bottom"`&`variant` is not "temporary".
    static member inline paperAnchorDockedBottom(value: IClassName) = mkDrawerClasses "paperAnchorDockedBottom" value
    /// Styles applied to the `Modal` component.
    static member inline modal(value: IClassName) = mkDrawerClasses "modal" value


  type IExpansionPanelClasses = interface end

  let inline private mkExpansionPanelClasses (key: string) (value: IClassName) : IExpansionPanelClasses = unbox (key, value)

  [<Erase>]
  type expansionPanel =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkExpansionPanelClasses "root" value
    /// Styles applied to the root element if `square={false}`.
    static member inline rounded(value: IClassName) = mkExpansionPanelClasses "rounded" value
    /// Styles applied to the root element if `expanded={true}`.
    static member inline expanded(value: IClassName) = mkExpansionPanelClasses "expanded" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkExpansionPanelClasses "disabled" value


  type IExpansionPanelActionsClasses = interface end

  let inline private mkExpansionPanelActionsClasses (key: string) (value: IClassName) : IExpansionPanelActionsClasses = unbox (key, value)

  [<Erase>]
  type expansionPanelActions =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkExpansionPanelActionsClasses "root" value
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(value: IClassName) = mkExpansionPanelActionsClasses "spacing" value


  type IExpansionPanelDetailsClasses = interface end

  let inline private mkExpansionPanelDetailsClasses (key: string) (value: IClassName) : IExpansionPanelDetailsClasses = unbox (key, value)

  [<Erase>]
  type expansionPanelDetails =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkExpansionPanelDetailsClasses "root" value


  type IExpansionPanelSummaryClasses = interface end

  let inline private mkExpansionPanelSummaryClasses (key: string) (value: IClassName) : IExpansionPanelSummaryClasses = unbox (key, value)

  [<Erase>]
  type expansionPanelSummary =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkExpansionPanelSummaryClasses "root" value
    /// Styles applied to the root element, children wrapper element and `IconButton` component if `expanded={true}`.
    static member inline expanded(value: IClassName) = mkExpansionPanelSummaryClasses "expanded" value
    /// Styles applied to the root and children wrapper elements when focused.
    static member inline focused(value: IClassName) = mkExpansionPanelSummaryClasses "focused" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkExpansionPanelSummaryClasses "disabled" value
    /// Styles applied to the children wrapper element.
    static member inline content(value: IClassName) = mkExpansionPanelSummaryClasses "content" value
    /// Styles applied to the `IconButton` component when `expandIcon` is supplied.
    static member inline expandIcon(value: IClassName) = mkExpansionPanelSummaryClasses "expandIcon" value


  type IFabClasses = interface end

  let inline private mkFabClasses (key: string) (value: IClassName) : IFabClasses = unbox (key, value)

  [<Erase>]
  type fab =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkFabClasses "root" value
    /// Styles applied to the span element that wraps the children.
    static member inline label(value: IClassName) = mkFabClasses "label" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline primary(value: IClassName) = mkFabClasses "primary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline secondary(value: IClassName) = mkFabClasses "secondary" value
    /// Styles applied to the root element if `variant="extended"`.
    static member inline extended(value: IClassName) = mkFabClasses "extended" value
    /// Pseudo-class applied to the ButtonBase root element if the button is keyboard focused.
    static member inline focusVisible(value: IClassName) = mkFabClasses "focusVisible" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkFabClasses "disabled" value
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: IClassName) = mkFabClasses "colorInherit" value
    /// Styles applied to the root element if `size="small"``.
    static member inline sizeSmall(value: IClassName) = mkFabClasses "sizeSmall" value
    /// Styles applied to the root element if `size="medium"``.
    static member inline sizeMedium(value: IClassName) = mkFabClasses "sizeMedium" value


  type IFadeClasses = interface end


  type IFilledInputClasses = interface end

  let inline private mkFilledInputClasses (key: string) (value: IClassName) : IFilledInputClasses = unbox (key, value)

  [<Erase>]
  type filledInput =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkFilledInputClasses "root" value
    /// Styles applied to the root element if `disableUnderline={false}`.
    static member inline underline(value: IClassName) = mkFilledInputClasses "underline" value
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: IClassName) = mkFilledInputClasses "focused" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkFilledInputClasses "disabled" value
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(value: IClassName) = mkFilledInputClasses "adornedStart" value
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(value: IClassName) = mkFilledInputClasses "adornedEnd" value
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: IClassName) = mkFilledInputClasses "error" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(value: IClassName) = mkFilledInputClasses "marginDense" value
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: IClassName) = mkFilledInputClasses "multiline" value
    /// Styles applied to the `input` element.
    static member inline input(value: IClassName) = mkFilledInputClasses "input" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: IClassName) = mkFilledInputClasses "inputMarginDense" value
    /// Styles applied to the `input` if in ``.
    static member inline inputHiddenLabel(value: IClassName) = mkFilledInputClasses "inputHiddenLabel" value
    /// Styles applied to the `input` element if `select={true}`.
    static member inline inputSelect(value: IClassName) = mkFilledInputClasses "inputSelect" value
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: IClassName) = mkFilledInputClasses "inputMultiline" value
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(value: IClassName) = mkFilledInputClasses "inputAdornedStart" value
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(value: IClassName) = mkFilledInputClasses "inputAdornedEnd" value


  type IFormControlClasses = interface end

  let inline private mkFormControlClasses (key: string) (value: IClassName) : IFormControlClasses = unbox (key, value)

  [<Erase>]
  type formControl =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkFormControlClasses "root" value
    /// Styles applied to the root element if `margin="normal"`.
    static member inline marginNormal(value: IClassName) = mkFormControlClasses "marginNormal" value
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(value: IClassName) = mkFormControlClasses "marginDense" value
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: IClassName) = mkFormControlClasses "fullWidth" value


  type IFormControlLabelClasses = interface end

  let inline private mkFormControlLabelClasses (key: string) (value: IClassName) : IFormControlLabelClasses = unbox (key, value)

  [<Erase>]
  type formControlLabel =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkFormControlLabelClasses "root" value
    /// Styles applied to the root element if `labelPlacement="start"`.
    static member inline labelPlacementStart(value: IClassName) = mkFormControlLabelClasses "labelPlacementStart" value
    /// Styles applied to the root element if `labelPlacement="top"`.
    static member inline labelPlacementTop(value: IClassName) = mkFormControlLabelClasses "labelPlacementTop" value
    /// Styles applied to the root element if `labelPlacement="bottom"`.
    static member inline labelPlacementBottom(value: IClassName) = mkFormControlLabelClasses "labelPlacementBottom" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkFormControlLabelClasses "disabled" value
    /// Styles applied to the label's Typography component.
    static member inline label(value: IClassName) = mkFormControlLabelClasses "label" value


  type IFormGroupClasses = interface end

  let inline private mkFormGroupClasses (key: string) (value: IClassName) : IFormGroupClasses = unbox (key, value)

  [<Erase>]
  type formGroup =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkFormGroupClasses "root" value
    /// Styles applied to the root element if `row={true}`.
    static member inline row(value: IClassName) = mkFormGroupClasses "row" value


  type IFormHelperTextClasses = interface end

  let inline private mkFormHelperTextClasses (key: string) (value: IClassName) : IFormHelperTextClasses = unbox (key, value)

  [<Erase>]
  type formHelperText =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkFormHelperTextClasses "root" value
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: IClassName) = mkFormHelperTextClasses "error" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkFormHelperTextClasses "disabled" value
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(value: IClassName) = mkFormHelperTextClasses "marginDense" value
    /// Styles applied to the root element if `variant="filled"` or `variant="outlined"`.
    static member inline contained(value: IClassName) = mkFormHelperTextClasses "contained" value
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(value: IClassName) = mkFormHelperTextClasses "focused" value
    /// Pseudo-class applied to the root element if `filled={true}`.
    static member inline filled(value: IClassName) = mkFormHelperTextClasses "filled" value
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(value: IClassName) = mkFormHelperTextClasses "required" value


  type IFormLabelClasses = interface end

  let inline private mkFormLabelClasses (key: string) (value: IClassName) : IFormLabelClasses = unbox (key, value)

  [<Erase>]
  type formLabel =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkFormLabelClasses "root" value
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(value: IClassName) = mkFormLabelClasses "focused" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkFormLabelClasses "disabled" value
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: IClassName) = mkFormLabelClasses "error" value
    /// Pseudo-class applied to the root element if `filled={true}`.
    static member inline filled(value: IClassName) = mkFormLabelClasses "filled" value
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(value: IClassName) = mkFormLabelClasses "required" value
    /// Styles applied to the asterisk element.
    static member inline asterisk(value: IClassName) = mkFormLabelClasses "asterisk" value


  type IGridClasses = interface end

  let inline private mkGridClasses (key: string) (value: IClassName) : IGridClasses = unbox (key, value)

  [<Erase>]
  type grid =
    /// Styles applied to the root element
    static member inline root(value: IClassName) = mkGridClasses "root" value
    /// Styles applied to the root element if `container={true}`.
    static member inline container(value: IClassName) = mkGridClasses "container" value
    /// Styles applied to the root element if `item={true}`.
    static member inline item(value: IClassName) = mkGridClasses "item" value
    /// Styles applied to the root element if `zeroMinWidth={true}`.
    static member inline zeroMinWidth(value: IClassName) = mkGridClasses "zeroMinWidth" value
    static member inline directionXsColumn(value: IClassName) = mkGridClasses "direction-xs-column" value
    static member inline directionXsColumnReverse(value: IClassName) = mkGridClasses "direction-xs-column-reverse" value
    static member inline directionXsRowReverse(value: IClassName) = mkGridClasses "direction-xs-row-reverse" value
    static member inline wrapXsNowrap(value: IClassName) = mkGridClasses "wrap-xs-nowrap" value
    static member inline wrapXsWrapReverse(value: IClassName) = mkGridClasses "wrap-xs-wrap-reverse" value
    static member inline alignItemsXsCenter(value: IClassName) = mkGridClasses "align-items-xs-center" value
    static member inline alignItemsXsFlexStart(value: IClassName) = mkGridClasses "align-items-xs-flex-start" value
    static member inline alignItemsXsFlexEnd(value: IClassName) = mkGridClasses "align-items-xs-flex-end" value
    static member inline alignItemsXsBaseline(value: IClassName) = mkGridClasses "align-items-xs-baseline" value
    static member inline alignContentXsCenter(value: IClassName) = mkGridClasses "align-content-xs-center" value
    static member inline alignContentXsFlexStart(value: IClassName) = mkGridClasses "align-content-xs-flex-start" value
    static member inline alignContentXsFlexEnd(value: IClassName) = mkGridClasses "align-content-xs-flex-end" value
    static member inline alignContentXsSpaceBetween(value: IClassName) = mkGridClasses "align-content-xs-space-between" value
    static member inline alignContentXsSpaceAround(value: IClassName) = mkGridClasses "align-content-xs-space-around" value
    static member inline justifyXsCenter(value: IClassName) = mkGridClasses "justify-xs-center" value
    static member inline justifyXsFlexEnd(value: IClassName) = mkGridClasses "justify-xs-flex-end" value
    static member inline justifyXsSpaceBetween(value: IClassName) = mkGridClasses "justify-xs-space-between" value
    static member inline justifyXsSpaceAround(value: IClassName) = mkGridClasses "justify-xs-space-around" value
    static member inline justifyXsSpaceEvenly(value: IClassName) = mkGridClasses "justify-xs-space-evenly" value
    static member inline spacingXs1(value: IClassName) = mkGridClasses "spacing-xs-1" value
    static member inline spacingXs2(value: IClassName) = mkGridClasses "spacing-xs-2" value
    static member inline spacingXs3(value: IClassName) = mkGridClasses "spacing-xs-3" value
    static member inline spacingXs4(value: IClassName) = mkGridClasses "spacing-xs-4" value
    static member inline spacingXs5(value: IClassName) = mkGridClasses "spacing-xs-5" value
    static member inline spacingXs6(value: IClassName) = mkGridClasses "spacing-xs-6" value
    static member inline spacingXs7(value: IClassName) = mkGridClasses "spacing-xs-7" value
    static member inline spacingXs8(value: IClassName) = mkGridClasses "spacing-xs-8" value
    static member inline spacingXs9(value: IClassName) = mkGridClasses "spacing-xs-9" value
    static member inline spacingXs10(value: IClassName) = mkGridClasses "spacing-xs-10" value
    static member inline gridXsAuto(value: IClassName) = mkGridClasses "grid-xs-auto" value
    static member inline gridXsTrue(value: IClassName) = mkGridClasses "grid-xs-true" value
    static member inline gridXs1(value: IClassName) = mkGridClasses "grid-xs-1" value
    static member inline gridXs2(value: IClassName) = mkGridClasses "grid-xs-2" value
    static member inline gridXs3(value: IClassName) = mkGridClasses "grid-xs-3" value
    static member inline gridXs4(value: IClassName) = mkGridClasses "grid-xs-4" value
    static member inline gridXs5(value: IClassName) = mkGridClasses "grid-xs-5" value
    static member inline gridXs6(value: IClassName) = mkGridClasses "grid-xs-6" value
    static member inline gridXs7(value: IClassName) = mkGridClasses "grid-xs-7" value
    static member inline gridXs8(value: IClassName) = mkGridClasses "grid-xs-8" value
    static member inline gridXs9(value: IClassName) = mkGridClasses "grid-xs-9" value
    static member inline gridXs10(value: IClassName) = mkGridClasses "grid-xs-10" value
    static member inline gridXs11(value: IClassName) = mkGridClasses "grid-xs-11" value
    static member inline gridXs12(value: IClassName) = mkGridClasses "grid-xs-12" value


  type IGridListClasses = interface end

  let inline private mkGridListClasses (key: string) (value: IClassName) : IGridListClasses = unbox (key, value)

  [<Erase>]
  type gridList =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkGridListClasses "root" value


  type IGridListTileClasses = interface end

  let inline private mkGridListTileClasses (key: string) (value: IClassName) : IGridListTileClasses = unbox (key, value)

  [<Erase>]
  type gridListTile =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkGridListTileClasses "root" value
    /// Styles applied to the `div` element that wraps the children.
    static member inline tile(value: IClassName) = mkGridListTileClasses "tile" value
    /// Styles applied to an `img` element child, if needed to ensure it covers the tile.
    static member inline imgFullHeight(value: IClassName) = mkGridListTileClasses "imgFullHeight" value
    /// Styles applied to an `img` element child, if needed to ensure it covers the tile.
    static member inline imgFullWidth(value: IClassName) = mkGridListTileClasses "imgFullWidth" value


  type IGridListTileBarClasses = interface end

  let inline private mkGridListTileBarClasses (key: string) (value: IClassName) : IGridListTileBarClasses = unbox (key, value)

  [<Erase>]
  type gridListTileBar =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkGridListTileBarClasses "root" value
    /// Styles applied to the root element if `titlePosition="bottom"`.
    static member inline titlePositionBottom(value: IClassName) = mkGridListTileBarClasses "titlePositionBottom" value
    /// Styles applied to the root element if `titlePosition="top"`.
    static member inline titlePositionTop(value: IClassName) = mkGridListTileBarClasses "titlePositionTop" value
    /// Styles applied to the root element if a `subtitle` is provided.
    static member inline rootSubtitle(value: IClassName) = mkGridListTileBarClasses "rootSubtitle" value
    /// Styles applied to the title and subtitle container element.
    static member inline titleWrap(value: IClassName) = mkGridListTileBarClasses "titleWrap" value
    /// Styles applied to the container element if `actionPosition="left"`.
    static member inline titleWrapActionPosLeft(value: IClassName) = mkGridListTileBarClasses "titleWrapActionPosLeft" value
    /// Styles applied to the container element if `actionPosition="right"`.
    static member inline titleWrapActionPosRight(value: IClassName) = mkGridListTileBarClasses "titleWrapActionPosRight" value
    /// Styles applied to the title container element.
    static member inline title(value: IClassName) = mkGridListTileBarClasses "title" value
    /// Styles applied to the subtitle container element.
    static member inline subtitle(value: IClassName) = mkGridListTileBarClasses "subtitle" value
    /// Styles applied to the actionIcon if supplied.
    static member inline actionIcon(value: IClassName) = mkGridListTileBarClasses "actionIcon" value
    /// Styles applied to the actionIcon if `actionPosition="left"`.
    static member inline actionIconActionPosLeft(value: IClassName) = mkGridListTileBarClasses "actionIconActionPosLeft" value


  type IGrowClasses = interface end


  type IHiddenClasses = interface end


  type IIconClasses = interface end

  let inline private mkIconClasses (key: string) (value: IClassName) : IIconClasses = unbox (key, value)

  [<Erase>]
  type icon =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkIconClasses "root" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkIconClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: IClassName) = mkIconClasses "colorSecondary" value
    /// Styles applied to the root element if `color="action"`.
    static member inline colorAction(value: IClassName) = mkIconClasses "colorAction" value
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: IClassName) = mkIconClasses "colorError" value
    /// Styles applied to the root element if `color="disabled"`.
    static member inline colorDisabled(value: IClassName) = mkIconClasses "colorDisabled" value
    static member inline fontSizeInherit(value: IClassName) = mkIconClasses "fontSizeInherit" value
    /// Styles applied to the root element if `fontSize="small"`.
    static member inline fontSizeSmall(value: IClassName) = mkIconClasses "fontSizeSmall" value
    /// Styles applied to the root element if `fontSize="large"`.
    static member inline fontSizeLarge(value: IClassName) = mkIconClasses "fontSizeLarge" value


  type IIconButtonClasses = interface end

  let inline private mkIconButtonClasses (key: string) (value: IClassName) : IIconButtonClasses = unbox (key, value)

  [<Erase>]
  type iconButton =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkIconButtonClasses "root" value
    /// Styles applied to the root element if `edge="start"`.
    static member inline edgeStart(value: IClassName) = mkIconButtonClasses "edgeStart" value
    /// Styles applied to the root element if `edge="end"`.
    static member inline edgeEnd(value: IClassName) = mkIconButtonClasses "edgeEnd" value
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: IClassName) = mkIconButtonClasses "colorInherit" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkIconButtonClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: IClassName) = mkIconButtonClasses "colorSecondary" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkIconButtonClasses "disabled" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: IClassName) = mkIconButtonClasses "sizeSmall" value
    /// Styles applied to the children container element.
    static member inline label(value: IClassName) = mkIconButtonClasses "label" value


  type IInputClasses = interface end

  let inline private mkInputClasses (key: string) (value: IClassName) : IInputClasses = unbox (key, value)

  [<Erase>]
  type input =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkInputClasses "root" value
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(value: IClassName) = mkInputClasses "formControl" value
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: IClassName) = mkInputClasses "focused" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkInputClasses "disabled" value
    /// Styles applied to the root element if `disableUnderline={false}`.
    static member inline underline(value: IClassName) = mkInputClasses "underline" value
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: IClassName) = mkInputClasses "error" value
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: IClassName) = mkInputClasses "multiline" value
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: IClassName) = mkInputClasses "fullWidth" value
    /// Styles applied to the `input` element.
    static member inline input(value: IClassName) = mkInputClasses "input" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: IClassName) = mkInputClasses "inputMarginDense" value
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: IClassName) = mkInputClasses "inputMultiline" value
    /// Styles applied to the `input` element if `type="search"`.
    static member inline inputTypeSearch(value: IClassName) = mkInputClasses "inputTypeSearch" value


  type IInputAdornmentClasses = interface end

  let inline private mkInputAdornmentClasses (key: string) (value: IClassName) : IInputAdornmentClasses = unbox (key, value)

  [<Erase>]
  type inputAdornment =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkInputAdornmentClasses "root" value
    /// Styles applied to the root element if `variant="filled"`.
    static member inline filled(value: IClassName) = mkInputAdornmentClasses "filled" value
    /// Styles applied to the root element if `position="start"`.
    static member inline positionStart(value: IClassName) = mkInputAdornmentClasses "positionStart" value
    /// Styles applied to the root element if `position="end"`.
    static member inline positionEnd(value: IClassName) = mkInputAdornmentClasses "positionEnd" value
    /// Styles applied to the root element if `disablePointerEvents=true`.
    static member inline disablePointerEvents(value: IClassName) = mkInputAdornmentClasses "disablePointerEvents" value
    /// Styles applied if the adornment is used inside <formcontrol hiddenlabel=""></formcontrol>.
    static member inline hiddenLabel(value: IClassName) = mkInputAdornmentClasses "hiddenLabel" value
    /// Styles applied if the adornment is used inside <formcontrol margin="dense"></formcontrol>.
    static member inline marginDense(value: IClassName) = mkInputAdornmentClasses "marginDense" value


  type IInputBaseClasses = interface end

  let inline private mkInputBaseClasses (key: string) (value: IClassName) : IInputBaseClasses = unbox (key, value)

  [<Erase>]
  type inputBase =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkInputBaseClasses "root" value
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(value: IClassName) = mkInputBaseClasses "formControl" value
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: IClassName) = mkInputBaseClasses "focused" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkInputBaseClasses "disabled" value
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(value: IClassName) = mkInputBaseClasses "adornedStart" value
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(value: IClassName) = mkInputBaseClasses "adornedEnd" value
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: IClassName) = mkInputBaseClasses "error" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(value: IClassName) = mkInputBaseClasses "marginDense" value
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: IClassName) = mkInputBaseClasses "multiline" value
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: IClassName) = mkInputBaseClasses "fullWidth" value
    /// Styles applied to the `input` element.
    static member inline input(value: IClassName) = mkInputBaseClasses "input" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: IClassName) = mkInputBaseClasses "inputMarginDense" value
    /// Styles applied to the `input` element if `select={true}`.
    static member inline inputSelect(value: IClassName) = mkInputBaseClasses "inputSelect" value
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: IClassName) = mkInputBaseClasses "inputMultiline" value
    /// Styles applied to the `input` element if `type="search"`.
    static member inline inputTypeSearch(value: IClassName) = mkInputBaseClasses "inputTypeSearch" value
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(value: IClassName) = mkInputBaseClasses "inputAdornedStart" value
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(value: IClassName) = mkInputBaseClasses "inputAdornedEnd" value
    /// Styles applied to the `input` element if `hiddenLabel={true}`.
    static member inline inputHiddenLabel(value: IClassName) = mkInputBaseClasses "inputHiddenLabel" value


  type IInputLabelClasses = interface end

  let inline private mkInputLabelClasses (key: string) (value: IClassName) : IInputLabelClasses = unbox (key, value)

  [<Erase>]
  type inputLabel =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkInputLabelClasses "root" value
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(value: IClassName) = mkInputLabelClasses "focused" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkInputLabelClasses "disabled" value
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: IClassName) = mkInputLabelClasses "error" value
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(value: IClassName) = mkInputLabelClasses "required" value
    /// Pseudo-class applied to the asterisk element.
    static member inline asterisk(value: IClassName) = mkInputLabelClasses "asterisk" value
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(value: IClassName) = mkInputLabelClasses "formControl" value
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(value: IClassName) = mkInputLabelClasses "marginDense" value
    /// Styles applied to the `input` element if `shrink={true}`.
    static member inline shrink(value: IClassName) = mkInputLabelClasses "shrink" value
    /// Styles applied to the `input` element if `disableAnimation={false}`.
    static member inline animated(value: IClassName) = mkInputLabelClasses "animated" value
    /// Styles applied to the root element if `variant="filled"`.
    static member inline filled(value: IClassName) = mkInputLabelClasses "filled" value
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(value: IClassName) = mkInputLabelClasses "outlined" value


  type ILinearProgressClasses = interface end

  let inline private mkLinearProgressClasses (key: string) (value: IClassName) : ILinearProgressClasses = unbox (key, value)

  [<Erase>]
  type linearProgress =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkLinearProgressClasses "root" value
    /// Styles applied to the root & bar2 element if `color="primary"`; bar2 if `variant-"buffer"`.
    static member inline colorPrimary(value: IClassName) = mkLinearProgressClasses "colorPrimary" value
    /// Styles applied to the root & bar2 elements if `color="secondary"`; bar2 if `variant="buffer"`.
    static member inline colorSecondary(value: IClassName) = mkLinearProgressClasses "colorSecondary" value
    /// Styles applied to the root element if `variant="determinate"`.
    static member inline determinate(value: IClassName) = mkLinearProgressClasses "determinate" value
    /// Styles applied to the root element if `variant="indeterminate"`.
    static member inline indeterminate(value: IClassName) = mkLinearProgressClasses "indeterminate" value
    /// Styles applied to the root element if `variant="buffer"`.
    static member inline buffer(value: IClassName) = mkLinearProgressClasses "buffer" value
    /// Styles applied to the root element if `variant="query"`.
    static member inline query(value: IClassName) = mkLinearProgressClasses "query" value
    /// Styles applied to the additional bar element if `variant="buffer"`.
    static member inline dashed(value: IClassName) = mkLinearProgressClasses "dashed" value
    /// Styles applied to the additional bar element if `variant="buffer"`&`color="primary"`.
    static member inline dashedColorPrimary(value: IClassName) = mkLinearProgressClasses "dashedColorPrimary" value
    /// Styles applied to the additional bar element if `variant="buffer"`&`color="secondary"`.
    static member inline dashedColorSecondary(value: IClassName) = mkLinearProgressClasses "dashedColorSecondary" value
    /// Styles applied to the layered bar1 & bar2 elements.
    static member inline bar(value: IClassName) = mkLinearProgressClasses "bar" value
    /// Styles applied to the bar elements if `color="primary"`; bar2 if `variant` not "buffer".
    static member inline barColorPrimary(value: IClassName) = mkLinearProgressClasses "barColorPrimary" value
    /// Styles applied to the bar elements if `color="secondary"`; bar2 if `variant` not "buffer".
    static member inline barColorSecondary(value: IClassName) = mkLinearProgressClasses "barColorSecondary" value
    /// Styles applied to the bar1 element if `variant="indeterminate or query"`.
    static member inline bar1Indeterminate(value: IClassName) = mkLinearProgressClasses "bar1Indeterminate" value
    /// Styles applied to the bar1 element if `variant="determinate"`.
    static member inline bar1Determinate(value: IClassName) = mkLinearProgressClasses "bar1Determinate" value
    /// Styles applied to the bar1 element if `variant="buffer"`.
    static member inline bar1Buffer(value: IClassName) = mkLinearProgressClasses "bar1Buffer" value
    /// Styles applied to the bar2 element if `variant="indeterminate or query"`.
    static member inline bar2Indeterminate(value: IClassName) = mkLinearProgressClasses "bar2Indeterminate" value
    /// Styles applied to the bar2 element if `variant="buffer"`.
    static member inline bar2Buffer(value: IClassName) = mkLinearProgressClasses "bar2Buffer" value


  type ILinkClasses = interface end

  let inline private mkLinkClasses (key: string) (value: IClassName) : ILinkClasses = unbox (key, value)

  [<Erase>]
  type link =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkLinkClasses "root" value
    /// Styles applied to the root element if `underline="none"`.
    static member inline underlineNone(value: IClassName) = mkLinkClasses "underlineNone" value
    /// Styles applied to the root element if `underline="hover"`.
    static member inline underlineHover(value: IClassName) = mkLinkClasses "underlineHover" value
    /// Styles applied to the root element if `underline="always"`.
    static member inline underlineAlways(value: IClassName) = mkLinkClasses "underlineAlways" value
    /// Styles applied to the root element if `component="button"`.
    static member inline button(value: IClassName) = mkLinkClasses "button" value
    /// Pseudo-class applied to the root element if the link is keyboard focused.
    static member inline focusVisible(value: IClassName) = mkLinkClasses "focusVisible" value


  type IListClasses = interface end

  let inline private mkListClasses (key: string) (value: IClassName) : IListClasses = unbox (key, value)

  [<Erase>]
  type list =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkListClasses "root" value
    /// Styles applied to the root element if `disablePadding={false}`.
    static member inline padding(value: IClassName) = mkListClasses "padding" value
    /// Styles applied to the root element if dense.
    static member inline dense(value: IClassName) = mkListClasses "dense" value
    /// Styles applied to the root element if a `subheader` is provided.
    static member inline subheader(value: IClassName) = mkListClasses "subheader" value


  type IListItemClasses = interface end

  let inline private mkListItemClasses (key: string) (value: IClassName) : IListItemClasses = unbox (key, value)

  [<Erase>]
  type listItem =
    /// Styles applied to the (normally root) `component` element. May be wrapped by a `container`.
    static member inline root(value: IClassName) = mkListItemClasses "root" value
    /// Styles applied to the `container` element if `children` includes `ListItemSecondaryAction`.
    static member inline container(value: IClassName) = mkListItemClasses "container" value
    /// Pseudo-class applied to the `component`'s `focusVisibleClassName` prop if `button={true}`.
    static member inline focusVisible(value: IClassName) = mkListItemClasses "focusVisible" value
    /// Styles applied to the `component` element if dense.
    static member inline dense(value: IClassName) = mkListItemClasses "dense" value
    /// Styles applied to the `component` element if `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(value: IClassName) = mkListItemClasses "alignItemsFlexStart" value
    /// Pseudo-class applied to the inner `component` element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkListItemClasses "disabled" value
    /// Styles applied to the inner `component` element if `divider={true}`.
    static member inline divider(value: IClassName) = mkListItemClasses "divider" value
    /// Styles applied to the inner `component` element if `disableGutters={false}`.
    static member inline gutters(value: IClassName) = mkListItemClasses "gutters" value
    /// Styles applied to the inner `component` element if `button={true}`.
    static member inline button(value: IClassName) = mkListItemClasses "button" value
    /// Styles applied to the `component` element if `children` includes `ListItemSecondaryAction`.
    static member inline secondaryAction(value: IClassName) = mkListItemClasses "secondaryAction" value
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(value: IClassName) = mkListItemClasses "selected" value


  type IListItemAvatarClasses = interface end

  let inline private mkListItemAvatarClasses (key: string) (value: IClassName) : IListItemAvatarClasses = unbox (key, value)

  [<Erase>]
  type listItemAvatar =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkListItemAvatarClasses "root" value
    /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(value: IClassName) = mkListItemAvatarClasses "alignItemsFlexStart" value


  type IListItemIconClasses = interface end

  let inline private mkListItemIconClasses (key: string) (value: IClassName) : IListItemIconClasses = unbox (key, value)

  [<Erase>]
  type listItemIcon =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkListItemIconClasses "root" value
    /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(value: IClassName) = mkListItemIconClasses "alignItemsFlexStart" value


  type IListItemSecondaryActionClasses = interface end

  let inline private mkListItemSecondaryActionClasses (key: string) (value: IClassName) : IListItemSecondaryActionClasses = unbox (key, value)

  [<Erase>]
  type listItemSecondaryAction =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkListItemSecondaryActionClasses "root" value


  type IListItemTextClasses = interface end

  let inline private mkListItemTextClasses (key: string) (value: IClassName) : IListItemTextClasses = unbox (key, value)

  [<Erase>]
  type listItemText =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkListItemTextClasses "root" value
    /// Styles applied to the `Typography` components if primary and secondary are set.
    static member inline multiline(value: IClassName) = mkListItemTextClasses "multiline" value
    /// Styles applied to the `Typography` components if dense.
    static member inline dense(value: IClassName) = mkListItemTextClasses "dense" value
    /// Styles applied to the root element if `inset={true}`.
    static member inline inset(value: IClassName) = mkListItemTextClasses "inset" value
    /// Styles applied to the primary `Typography` component.
    static member inline primary(value: IClassName) = mkListItemTextClasses "primary" value
    /// Styles applied to the secondary `Typography` component.
    static member inline secondary(value: IClassName) = mkListItemTextClasses "secondary" value


  type IListSubheaderClasses = interface end

  let inline private mkListSubheaderClasses (key: string) (value: IClassName) : IListSubheaderClasses = unbox (key, value)

  [<Erase>]
  type listSubheader =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkListSubheaderClasses "root" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkListSubheaderClasses "colorPrimary" value
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: IClassName) = mkListSubheaderClasses "colorInherit" value
    /// Styles applied to the inner `component` element if `disableGutters={false}`.
    static member inline gutters(value: IClassName) = mkListSubheaderClasses "gutters" value
    /// Styles applied to the root element if `inset={true}`.
    static member inline inset(value: IClassName) = mkListSubheaderClasses "inset" value
    /// Styles applied to the root element if `disableSticky={false}`.
    static member inline sticky(value: IClassName) = mkListSubheaderClasses "sticky" value


  type IMenuClasses = interface end

  let inline private mkMenuClasses (key: string) (value: IClassName) : IMenuClasses = unbox (key, value)

  [<Erase>]
  type menu =
    /// Styles applied to the `Paper` component.
    static member inline paper(value: IClassName) = mkMenuClasses "paper" value
    /// Styles applied to the `List` component via `MenuList`.
    static member inline list(value: IClassName) = mkMenuClasses "list" value


  type IMenuItemClasses = interface end

  let inline private mkMenuItemClasses (key: string) (value: IClassName) : IMenuItemClasses = unbox (key, value)

  [<Erase>]
  type menuItem =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkMenuItemClasses "root" value
    /// Styles applied to the root element if `disableGutters={false}`.
    static member inline gutters(value: IClassName) = mkMenuItemClasses "gutters" value
    /// Styles applied to the root element if `selected={true}`.
    static member inline selected(value: IClassName) = mkMenuItemClasses "selected" value
    /// Styles applied to the root element if dense.
    static member inline dense(value: IClassName) = mkMenuItemClasses "dense" value


  type IMenuListClasses = interface end


  type IMobileStepperClasses = interface end

  let inline private mkMobileStepperClasses (key: string) (value: IClassName) : IMobileStepperClasses = unbox (key, value)

  [<Erase>]
  type mobileStepper =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkMobileStepperClasses "root" value
    /// Styles applied to the root element if `position="bottom"`.
    static member inline positionBottom(value: IClassName) = mkMobileStepperClasses "positionBottom" value
    /// Styles applied to the root element if `position="top"`.
    static member inline positionTop(value: IClassName) = mkMobileStepperClasses "positionTop" value
    /// Styles applied to the root element if `position="static"`.
    static member inline positionStatic(value: IClassName) = mkMobileStepperClasses "positionStatic" value
    /// Styles applied to the dots container if `variant="dots"`.
    static member inline dots(value: IClassName) = mkMobileStepperClasses "dots" value
    /// Styles applied to each dot if `variant="dots"`.
    static member inline dot(value: IClassName) = mkMobileStepperClasses "dot" value
    /// Styles applied to a dot if `variant="dots"` and this is the active step.
    static member inline dotActive(value: IClassName) = mkMobileStepperClasses "dotActive" value
    /// Styles applied to the Linear Progress component if `variant="progress"`.
    static member inline progress(value: IClassName) = mkMobileStepperClasses "progress" value


  type IModalClasses = interface end


  type INativeSelectClasses = interface end

  let inline private mkNativeSelectClasses (key: string) (value: IClassName) : INativeSelectClasses = unbox (key, value)

  [<Erase>]
  type nativeSelect =
    /// Styles applied to the select component `root` class.
    static member inline root(value: IClassName) = mkNativeSelectClasses "root" value
    /// Styles applied to the select component `select` class.
    static member inline select(value: IClassName) = mkNativeSelectClasses "select" value
    /// Styles applied to the select component if `variant="filled"`.
    static member inline filled(value: IClassName) = mkNativeSelectClasses "filled" value
    /// Styles applied to the select component if `variant="outlined"`.
    static member inline outlined(value: IClassName) = mkNativeSelectClasses "outlined" value
    /// Styles applied to the select component `selectMenu` class.
    static member inline selectMenu(value: IClassName) = mkNativeSelectClasses "selectMenu" value
    /// Pseudo-class applied to the select component `disabled` class.
    static member inline disabled(value: IClassName) = mkNativeSelectClasses "disabled" value
    /// Styles applied to the select component `icon` class.
    static member inline icon(value: IClassName) = mkNativeSelectClasses "icon" value


  type INoSsrClasses = interface end


  type IOutlinedInputClasses = interface end

  let inline private mkOutlinedInputClasses (key: string) (value: IClassName) : IOutlinedInputClasses = unbox (key, value)

  [<Erase>]
  type outlinedInput =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkOutlinedInputClasses "root" value
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: IClassName) = mkOutlinedInputClasses "focused" value
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkOutlinedInputClasses "disabled" value
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(value: IClassName) = mkOutlinedInputClasses "adornedStart" value
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(value: IClassName) = mkOutlinedInputClasses "adornedEnd" value
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: IClassName) = mkOutlinedInputClasses "error" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(value: IClassName) = mkOutlinedInputClasses "marginDense" value
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: IClassName) = mkOutlinedInputClasses "multiline" value
    /// Styles applied to the `NotchedOutline` element.
    static member inline notchedOutline(value: IClassName) = mkOutlinedInputClasses "notchedOutline" value
    /// Styles applied to the `input` element.
    static member inline input(value: IClassName) = mkOutlinedInputClasses "input" value
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: IClassName) = mkOutlinedInputClasses "inputMarginDense" value
    /// Styles applied to the `input` element if `select={true}`.
    static member inline inputSelect(value: IClassName) = mkOutlinedInputClasses "inputSelect" value
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: IClassName) = mkOutlinedInputClasses "inputMultiline" value
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(value: IClassName) = mkOutlinedInputClasses "inputAdornedStart" value
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(value: IClassName) = mkOutlinedInputClasses "inputAdornedEnd" value


  type IPaperClasses = interface end

  let inline private mkPaperClasses (key: string) (value: IClassName) : IPaperClasses = unbox (key, value)

  [<Erase>]
  type paper =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkPaperClasses "root" value
    /// Styles applied to the root element if `square={false}`.
    static member inline rounded(value: IClassName) = mkPaperClasses "rounded" value
    static member inline elevation0(value: IClassName) = mkPaperClasses "elevation0" value
    static member inline elevation1(value: IClassName) = mkPaperClasses "elevation1" value
    static member inline elevation2(value: IClassName) = mkPaperClasses "elevation2" value
    static member inline elevation3(value: IClassName) = mkPaperClasses "elevation3" value
    static member inline elevation4(value: IClassName) = mkPaperClasses "elevation4" value
    static member inline elevation5(value: IClassName) = mkPaperClasses "elevation5" value
    static member inline elevation6(value: IClassName) = mkPaperClasses "elevation6" value
    static member inline elevation7(value: IClassName) = mkPaperClasses "elevation7" value
    static member inline elevation8(value: IClassName) = mkPaperClasses "elevation8" value
    static member inline elevation9(value: IClassName) = mkPaperClasses "elevation9" value
    static member inline elevation10(value: IClassName) = mkPaperClasses "elevation10" value
    static member inline elevation11(value: IClassName) = mkPaperClasses "elevation11" value
    static member inline elevation12(value: IClassName) = mkPaperClasses "elevation12" value
    static member inline elevation13(value: IClassName) = mkPaperClasses "elevation13" value
    static member inline elevation14(value: IClassName) = mkPaperClasses "elevation14" value
    static member inline elevation15(value: IClassName) = mkPaperClasses "elevation15" value
    static member inline elevation16(value: IClassName) = mkPaperClasses "elevation16" value
    static member inline elevation17(value: IClassName) = mkPaperClasses "elevation17" value
    static member inline elevation18(value: IClassName) = mkPaperClasses "elevation18" value
    static member inline elevation19(value: IClassName) = mkPaperClasses "elevation19" value
    static member inline elevation20(value: IClassName) = mkPaperClasses "elevation20" value
    static member inline elevation21(value: IClassName) = mkPaperClasses "elevation21" value
    static member inline elevation22(value: IClassName) = mkPaperClasses "elevation22" value
    static member inline elevation23(value: IClassName) = mkPaperClasses "elevation23" value
    static member inline elevation24(value: IClassName) = mkPaperClasses "elevation24" value


  type IPopoverClasses = interface end

  let inline private mkPopoverClasses (key: string) (value: IClassName) : IPopoverClasses = unbox (key, value)

  [<Erase>]
  type popover =
    /// Styles applied to the `Paper` component.
    static member inline paper(value: IClassName) = mkPopoverClasses "paper" value


  type IPopperClasses = interface end


  type IPortalClasses = interface end


  type IRadioClasses = interface end

  let inline private mkRadioClasses (key: string) (value: IClassName) : IRadioClasses = unbox (key, value)

  [<Erase>]
  type radio =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkRadioClasses "root" value
    /// Pseudo-class applied to the root element if `checked={true}`.
    static member inline checked'(value: IClassName) = mkRadioClasses "checked" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkRadioClasses "disabled" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkRadioClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: IClassName) = mkRadioClasses "colorSecondary" value


  type IRadioGroupClasses = interface end


  type IRatingClasses = interface end

  let inline private mkRatingClasses (key: string) (value: IClassName) : IRatingClasses = unbox (key, value)

  [<Erase>]
  type rating =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkRatingClasses "root" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: IClassName) = mkRatingClasses "sizeSmall" value
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(value: IClassName) = mkRatingClasses "sizeLarge" value
    /// Styles applied to the root element if `readOnly={true}`.
    static member inline readOnly(value: IClassName) = mkRatingClasses "readOnly" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkRatingClasses "disabled" value
    /// Pseudo-class applied to the root element if keyboard focused.
    static member inline focusVisible(value: IClassName) = mkRatingClasses "focusVisible" value
    /// Visually hide an element.
    static member inline visuallyhidden(value: IClassName) = mkRatingClasses "visuallyhidden" value
    /// Styles applied to the pristine label.
    static member inline pristine(value: IClassName) = mkRatingClasses "pristine" value
    /// Styles applied to the label elements.
    static member inline label(value: IClassName) = mkRatingClasses "label" value
    /// Styles applied to the icon wrapping elements.
    static member inline icon(value: IClassName) = mkRatingClasses "icon" value
    /// Styles applied to the icon wrapping elements when empty.
    static member inline iconEmpty(value: IClassName) = mkRatingClasses "iconEmpty" value
    /// Styles applied to the icon wrapping elements when filled.
    static member inline iconFilled(value: IClassName) = mkRatingClasses "iconFilled" value
    /// Styles applied to the icon wrapping elements when hover.
    static member inline iconHover(value: IClassName) = mkRatingClasses "iconHover" value
    /// Styles applied to the icon wrapping elements when focus.
    static member inline iconFocus(value: IClassName) = mkRatingClasses "iconFocus" value
    /// Styles applied to the icon wrapping elements when active.
    static member inline iconActive(value: IClassName) = mkRatingClasses "iconActive" value
    /// Styles applied to the icon wrapping elements when decimals are necessary.
    static member inline decimal(value: IClassName) = mkRatingClasses "decimal" value


  type IRootRefClasses = interface end


  type ISelectClasses = interface end

  let inline private mkSelectClasses (key: string) (value: IClassName) : ISelectClasses = unbox (key, value)

  [<Erase>]
  type select =
    /// Styles applied to the select component `root` class.
    static member inline root(value: IClassName) = mkSelectClasses "root" value
    /// Styles applied to the select component `select` class.
    static member inline select(value: IClassName) = mkSelectClasses "select" value
    /// Styles applied to the select component if `variant="filled"`.
    static member inline filled(value: IClassName) = mkSelectClasses "filled" value
    /// Styles applied to the select component if `variant="outlined"`.
    static member inline outlined(value: IClassName) = mkSelectClasses "outlined" value
    /// Styles applied to the select component `selectMenu` class.
    static member inline selectMenu(value: IClassName) = mkSelectClasses "selectMenu" value
    /// Pseudo-class applied to the select component `disabled` class.
    static member inline disabled(value: IClassName) = mkSelectClasses "disabled" value
    /// Styles applied to the select component `icon` class.
    static member inline icon(value: IClassName) = mkSelectClasses "icon" value


  type ISkeletonClasses = interface end

  let inline private mkSkeletonClasses (key: string) (value: IClassName) : ISkeletonClasses = unbox (key, value)

  [<Erase>]
  type skeleton =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkSkeletonClasses "root" value
    /// Styles applied to the root element if `variant="text"`.
    static member inline text(value: IClassName) = mkSkeletonClasses "text" value
    /// Styles applied to the root element if `variant="rect"`.
    static member inline rect(value: IClassName) = mkSkeletonClasses "rect" value
    /// Styles applied to the root element if `variant="circle"`.
    static member inline circle(value: IClassName) = mkSkeletonClasses "circle" value
    /// Styles applied to the root element if `disabledAnimate={false}`.
    static member inline animate(value: IClassName) = mkSkeletonClasses "animate" value


  type ISlideClasses = interface end


  type ISliderClasses = interface end

  let inline private mkSliderClasses (key: string) (value: IClassName) : ISliderClasses = unbox (key, value)

  [<Erase>]
  type slider =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkSliderClasses "root" value
    /// Styles applied to the root element if `marks` is provided with at least one label.
    static member inline marked(value: IClassName) = mkSliderClasses "marked" value
    /// Pseudo-class applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: IClassName) = mkSliderClasses "vertical" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkSliderClasses "disabled" value
    /// Styles applied to the rail element.
    static member inline rail(value: IClassName) = mkSliderClasses "rail" value
    /// Styles applied to the track element.
    static member inline track(value: IClassName) = mkSliderClasses "track" value
    /// Styles applied to the thumb element.
    static member inline thumb(value: IClassName) = mkSliderClasses "thumb" value
    /// Pseudo-class applied to the thumb element if it's active.
    static member inline active(value: IClassName) = mkSliderClasses "active" value
    /// Pseudo-class applied to the thumb element if keyboard focused.
    static member inline focusVisible(value: IClassName) = mkSliderClasses "focusVisible" value
    /// Styles applied to the thumb label element.
    static member inline valueLabel(value: IClassName) = mkSliderClasses "valueLabel" value
    /// Styles applied to the mark element.
    static member inline mark(value: IClassName) = mkSliderClasses "mark" value
    /// Styles applied to the mark element if active (depending on the value).
    static member inline markActive(value: IClassName) = mkSliderClasses "markActive" value
    /// Styles applied to the mark label element.
    static member inline markLabel(value: IClassName) = mkSliderClasses "markLabel" value
    /// Styles applied to the mark label element if active (depending on the value).
    static member inline markLabelActive(value: IClassName) = mkSliderClasses "markLabelActive" value


  type ISnackbarClasses = interface end

  let inline private mkSnackbarClasses (key: string) (value: IClassName) : ISnackbarClasses = unbox (key, value)

  [<Erase>]
  type snackbar =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkSnackbarClasses "root" value
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'center' }}`.
    static member inline anchorOriginTopCenter(value: IClassName) = mkSnackbarClasses "anchorOriginTopCenter" value
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'center' }}`.
    static member inline anchorOriginBottomCenter(value: IClassName) = mkSnackbarClasses "anchorOriginBottomCenter" value
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }}`.
    static member inline anchorOriginTopRight(value: IClassName) = mkSnackbarClasses "anchorOriginTopRight" value
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }}`.
    static member inline anchorOriginBottomRight(value: IClassName) = mkSnackbarClasses "anchorOriginBottomRight" value
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }}`.
    static member inline anchorOriginTopLeft(value: IClassName) = mkSnackbarClasses "anchorOriginTopLeft" value
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }}`.
    static member inline anchorOriginBottomLeft(value: IClassName) = mkSnackbarClasses "anchorOriginBottomLeft" value


  type ISnackbarContentClasses = interface end

  let inline private mkSnackbarContentClasses (key: string) (value: IClassName) : ISnackbarContentClasses = unbox (key, value)

  [<Erase>]
  type snackbarContent =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkSnackbarContentClasses "root" value
    /// Styles applied to the message wrapper element.
    static member inline message(value: IClassName) = mkSnackbarContentClasses "message" value
    /// Styles applied to the action wrapper element if `action` is provided.
    static member inline action(value: IClassName) = mkSnackbarContentClasses "action" value


  type ISpeedDialClasses = interface end

  let inline private mkSpeedDialClasses (key: string) (value: IClassName) : ISpeedDialClasses = unbox (key, value)

  [<Erase>]
  type speedDial =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkSpeedDialClasses "root" value
    /// Styles applied to the Button component.
    static member inline fab(value: IClassName) = mkSpeedDialClasses "fab" value
    /// Styles applied to the root and action container elements when direction="up"
    static member inline directionUp(value: IClassName) = mkSpeedDialClasses "directionUp" value
    /// Styles applied to the root and action container elements when direction="down"
    static member inline directionDown(value: IClassName) = mkSpeedDialClasses "directionDown" value
    /// Styles applied to the root and action container elements when direction="left"
    static member inline directionLeft(value: IClassName) = mkSpeedDialClasses "directionLeft" value
    /// Styles applied to the root and action container elements when direction="right"
    static member inline directionRight(value: IClassName) = mkSpeedDialClasses "directionRight" value
    /// Styles applied to the actions (`children` wrapper) element.
    static member inline actions(value: IClassName) = mkSpeedDialClasses "actions" value
    /// Styles applied to the actions (`children` wrapper) element if `open={false}`.
    static member inline actionsClosed(value: IClassName) = mkSpeedDialClasses "actionsClosed" value


  type ISpeedDialActionClasses = interface end

  let inline private mkSpeedDialActionClasses (key: string) (value: IClassName) : ISpeedDialActionClasses = unbox (key, value)

  [<Erase>]
  type speedDialAction =
    /// Styles applied to the `Button` component.
    static member inline button(value: IClassName) = mkSpeedDialActionClasses "button" value
    /// Styles applied to the `Button` component if `open={false}`.
    static member inline buttonClosed(value: IClassName) = mkSpeedDialActionClasses "buttonClosed" value


  type ISpeedDialIconClasses = interface end

  let inline private mkSpeedDialIconClasses (key: string) (value: IClassName) : ISpeedDialIconClasses = unbox (key, value)

  [<Erase>]
  type speedDialIcon =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkSpeedDialIconClasses "root" value
    /// Styles applied to the icon component.
    static member inline icon(value: IClassName) = mkSpeedDialIconClasses "icon" value
    /// Styles applied to the icon component if `open={true}`.
    static member inline iconOpen(value: IClassName) = mkSpeedDialIconClasses "iconOpen" value
    /// Styles applied to the icon when and `openIcon` is provided & if `open={true}`.
    static member inline iconWithOpenIconOpen(value: IClassName) = mkSpeedDialIconClasses "iconWithOpenIconOpen" value
    /// Styles applied to the `openIcon` if provided.
    static member inline openIcon(value: IClassName) = mkSpeedDialIconClasses "openIcon" value
    /// Styles applied to the `openIcon` if provided & if `open={true}`.
    static member inline openIconOpen(value: IClassName) = mkSpeedDialIconClasses "openIconOpen" value


  type IStepClasses = interface end

  let inline private mkStepClasses (key: string) (value: IClassName) : IStepClasses = unbox (key, value)

  [<Erase>]
  type step =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkStepClasses "root" value
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: IClassName) = mkStepClasses "horizontal" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: IClassName) = mkStepClasses "vertical" value
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: IClassName) = mkStepClasses "alternativeLabel" value
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(value: IClassName) = mkStepClasses "completed" value


  type IStepButtonClasses = interface end

  let inline private mkStepButtonClasses (key: string) (value: IClassName) : IStepButtonClasses = unbox (key, value)

  [<Erase>]
  type stepButton =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkStepButtonClasses "root" value
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: IClassName) = mkStepButtonClasses "horizontal" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: IClassName) = mkStepButtonClasses "vertical" value
    /// Styles applied to the `ButtonBase` touch-ripple.
    static member inline touchRipple(value: IClassName) = mkStepButtonClasses "touchRipple" value


  type IStepConnectorClasses = interface end

  let inline private mkStepConnectorClasses (key: string) (value: IClassName) : IStepConnectorClasses = unbox (key, value)

  [<Erase>]
  type stepConnector =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkStepConnectorClasses "root" value
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: IClassName) = mkStepConnectorClasses "horizontal" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: IClassName) = mkStepConnectorClasses "vertical" value
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: IClassName) = mkStepConnectorClasses "alternativeLabel" value
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(value: IClassName) = mkStepConnectorClasses "active" value
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(value: IClassName) = mkStepConnectorClasses "completed" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkStepConnectorClasses "disabled" value
    /// Styles applied to the line element.
    static member inline line(value: IClassName) = mkStepConnectorClasses "line" value
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline lineHorizontal(value: IClassName) = mkStepConnectorClasses "lineHorizontal" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline lineVertical(value: IClassName) = mkStepConnectorClasses "lineVertical" value


  type IStepContentClasses = interface end

  let inline private mkStepContentClasses (key: string) (value: IClassName) : IStepContentClasses = unbox (key, value)

  [<Erase>]
  type stepContent =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkStepContentClasses "root" value
    /// Styles applied to the root element if `last={true}` (controlled by `Step`).
    static member inline last(value: IClassName) = mkStepContentClasses "last" value
    /// Styles applied to the Transition component.
    static member inline transition(value: IClassName) = mkStepContentClasses "transition" value


  type IStepIconClasses = interface end

  let inline private mkStepIconClasses (key: string) (value: IClassName) : IStepIconClasses = unbox (key, value)

  [<Erase>]
  type stepIcon =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkStepIconClasses "root" value
    /// Styles applied to the SVG text element.
    static member inline text(value: IClassName) = mkStepIconClasses "text" value
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(value: IClassName) = mkStepIconClasses "active" value
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(value: IClassName) = mkStepIconClasses "completed" value
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: IClassName) = mkStepIconClasses "error" value


  type IStepLabelClasses = interface end

  let inline private mkStepLabelClasses (key: string) (value: IClassName) : IStepLabelClasses = unbox (key, value)

  [<Erase>]
  type stepLabel =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkStepLabelClasses "root" value
    /// Styles applied to the root element if `orientation="horizontal".
    static member inline horizontal(value: IClassName) = mkStepLabelClasses "horizontal" value
    /// Styles applied to the root element if `orientation="vertical".
    static member inline vertical(value: IClassName) = mkStepLabelClasses "vertical" value
    /// Styles applied to the `Typography` component which wraps `children`.
    static member inline label(value: IClassName) = mkStepLabelClasses "label" value
    /// Pseudo-class applied to the `Typography` component if `active={true}`.
    static member inline active(value: IClassName) = mkStepLabelClasses "active" value
    /// Pseudo-class applied to the `Typography` component if `completed={true}`.
    static member inline completed(value: IClassName) = mkStepLabelClasses "completed" value
    /// Pseudo-class applied to the root element and `Typography` component if `error={true}`.
    static member inline error(value: IClassName) = mkStepLabelClasses "error" value
    /// Pseudo-class applied to the root element and `Typography` component if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkStepLabelClasses "disabled" value
    /// Styles applied to the `icon` container element.
    static member inline iconContainer(value: IClassName) = mkStepLabelClasses "iconContainer" value
    /// Pseudo-class applied to the root & icon container and `Typography` if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: IClassName) = mkStepLabelClasses "alternativeLabel" value
    /// Styles applied to the container element which wraps `Typography` and `optional`.
    static member inline labelContainer(value: IClassName) = mkStepLabelClasses "labelContainer" value


  type IStepperClasses = interface end

  let inline private mkStepperClasses (key: string) (value: IClassName) : IStepperClasses = unbox (key, value)

  [<Erase>]
  type stepper =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkStepperClasses "root" value
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: IClassName) = mkStepperClasses "horizontal" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: IClassName) = mkStepperClasses "vertical" value
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: IClassName) = mkStepperClasses "alternativeLabel" value


  type ISvgIconClasses = interface end

  let inline private mkSvgIconClasses (key: string) (value: IClassName) : ISvgIconClasses = unbox (key, value)

  [<Erase>]
  type svgIcon =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkSvgIconClasses "root" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkSvgIconClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: IClassName) = mkSvgIconClasses "colorSecondary" value
    /// Styles applied to the root element if `color="action"`.
    static member inline colorAction(value: IClassName) = mkSvgIconClasses "colorAction" value
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: IClassName) = mkSvgIconClasses "colorError" value
    /// Styles applied to the root element if `color="disabled"`.
    static member inline colorDisabled(value: IClassName) = mkSvgIconClasses "colorDisabled" value
    /// Styles applied to the root element if `fontSize="inherit"`.
    static member inline fontSizeInherit(value: IClassName) = mkSvgIconClasses "fontSizeInherit" value
    /// Styles applied to the root element if `fontSize="small"`.
    static member inline fontSizeSmall(value: IClassName) = mkSvgIconClasses "fontSizeSmall" value
    /// Styles applied to the root element if `fontSize="large"`.
    static member inline fontSizeLarge(value: IClassName) = mkSvgIconClasses "fontSizeLarge" value


  type ISwipeableDrawerClasses = interface end


  type ISwitchClasses = interface end

  let inline private mkSwitchClasses (key: string) (value: IClassName) : ISwitchClasses = unbox (key, value)

  [<Erase>]
  type switch =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkSwitchClasses "root" value
    /// Styles applied to the root element if `edge="start"`.
    static member inline edgeStart(value: IClassName) = mkSwitchClasses "edgeStart" value
    /// Styles applied to the root element if `edge="end"`.
    static member inline edgeEnd(value: IClassName) = mkSwitchClasses "edgeEnd" value
    /// Styles applied to the internal `SwitchBase` component's `root` class.
    static member inline switchBase(value: IClassName) = mkSwitchClasses "switchBase" value
    /// Styles applied to the internal SwitchBase component's root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkSwitchClasses "colorPrimary" value
    /// Styles applied to the internal SwitchBase component's root element if `color="secondary"`.
    static member inline colorSecondary(value: IClassName) = mkSwitchClasses "colorSecondary" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: IClassName) = mkSwitchClasses "sizeSmall" value
    /// Pseudo-class applied to the internal `SwitchBase` component's `checked` class.
    static member inline checked'(value: IClassName) = mkSwitchClasses "checked" value
    /// Pseudo-class applied to the internal SwitchBase component's disabled class.
    static member inline disabled(value: IClassName) = mkSwitchClasses "disabled" value
    /// Styles applied to the internal SwitchBase component's input element.
    static member inline input(value: IClassName) = mkSwitchClasses "input" value
    /// Styles used to create the thumb passed to the internal `SwitchBase` component `icon` prop.
    static member inline thumb(value: IClassName) = mkSwitchClasses "thumb" value
    /// Styles applied to the track element.
    static member inline track(value: IClassName) = mkSwitchClasses "track" value


  type ITabClasses = interface end

  let inline private mkTabClasses (key: string) (value: IClassName) : ITabClasses = unbox (key, value)

  [<Erase>]
  type tab =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTabClasses "root" value
    /// Styles applied to the root element if both `icon` and `label` are provided.
    static member inline labelIcon(value: IClassName) = mkTabClasses "labelIcon" value
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="inherit"`.
    static member inline textColorInherit(value: IClassName) = mkTabClasses "textColorInherit" value
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="primary"`.
    static member inline textColorPrimary(value: IClassName) = mkTabClasses "textColorPrimary" value
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="secondary"`.
    static member inline textColorSecondary(value: IClassName) = mkTabClasses "textColorSecondary" value
    /// Pseudo-class applied to the root element if `selected={true}` (controlled by the Tabs component).
    static member inline selected(value: IClassName) = mkTabClasses "selected" value
    /// Pseudo-class applied to the root element if `disabled={true}` (controlled by the Tabs component).
    static member inline disabled(value: IClassName) = mkTabClasses "disabled" value
    /// Styles applied to the root element if `fullWidth={true}` (controlled by the Tabs component).
    static member inline fullWidth(value: IClassName) = mkTabClasses "fullWidth" value
    /// Styles applied to the root element if `wrapped={true}`.
    static member inline wrapped(value: IClassName) = mkTabClasses "wrapped" value
    /// Styles applied to the `icon` and `label`'s wrapper element.
    static member inline wrapper(value: IClassName) = mkTabClasses "wrapper" value


  type ITableClasses = interface end

  let inline private mkTableClasses (key: string) (value: IClassName) : ITableClasses = unbox (key, value)

  [<Erase>]
  type table =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTableClasses "root" value


  type ITableBodyClasses = interface end

  let inline private mkTableBodyClasses (key: string) (value: IClassName) : ITableBodyClasses = unbox (key, value)

  [<Erase>]
  type tableBody =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTableBodyClasses "root" value


  type ITableCellClasses = interface end

  let inline private mkTableCellClasses (key: string) (value: IClassName) : ITableCellClasses = unbox (key, value)

  [<Erase>]
  type tableCell =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTableCellClasses "root" value
    /// Styles applied to the root element if `variant="head"` or `context.table.head`.
    static member inline head(value: IClassName) = mkTableCellClasses "head" value
    /// Styles applied to the root element if `variant="body"` or `context.table.body`.
    static member inline body(value: IClassName) = mkTableCellClasses "body" value
    /// Styles applied to the root element if `variant="footer"` or `context.table.footer`.
    static member inline footer(value: IClassName) = mkTableCellClasses "footer" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: IClassName) = mkTableCellClasses "sizeSmall" value
    /// Styles applied to the root element if `padding="checkbox"`.
    static member inline paddingCheckbox(value: IClassName) = mkTableCellClasses "paddingCheckbox" value
    /// Styles applied to the root element if `padding="none"`.
    static member inline paddingNone(value: IClassName) = mkTableCellClasses "paddingNone" value
    /// Styles applied to the root element if `align="left"`.
    static member inline alignLeft(value: IClassName) = mkTableCellClasses "alignLeft" value
    /// Styles applied to the root element if `align="center"`.
    static member inline alignCenter(value: IClassName) = mkTableCellClasses "alignCenter" value
    /// Styles applied to the root element if `align="right"`.
    static member inline alignRight(value: IClassName) = mkTableCellClasses "alignRight" value
    /// Styles applied to the root element if `align="justify"`.
    static member inline alignJustify(value: IClassName) = mkTableCellClasses "alignJustify" value


  type ITableFooterClasses = interface end

  let inline private mkTableFooterClasses (key: string) (value: IClassName) : ITableFooterClasses = unbox (key, value)

  [<Erase>]
  type tableFooter =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTableFooterClasses "root" value


  type ITableHeadClasses = interface end

  let inline private mkTableHeadClasses (key: string) (value: IClassName) : ITableHeadClasses = unbox (key, value)

  [<Erase>]
  type tableHead =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTableHeadClasses "root" value


  type ITablePaginationClasses = interface end

  let inline private mkTablePaginationClasses (key: string) (value: IClassName) : ITablePaginationClasses = unbox (key, value)

  [<Erase>]
  type tablePagination =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTablePaginationClasses "root" value
    /// Styles applied to the Toolbar component.
    static member inline toolbar(value: IClassName) = mkTablePaginationClasses "toolbar" value
    /// Styles applied to the spacer element.
    static member inline spacer(value: IClassName) = mkTablePaginationClasses "spacer" value
    /// Styles applied to the caption Typography components if `variant="caption"`.
    static member inline caption(value: IClassName) = mkTablePaginationClasses "caption" value
    /// Styles applied to the Select component root element.
    static member inline selectRoot(value: IClassName) = mkTablePaginationClasses "selectRoot" value
    /// Styles applied to the Select component `select` class.
    static member inline select(value: IClassName) = mkTablePaginationClasses "select" value
    /// Styles applied to the Select component `icon` class.
    static member inline selectIcon(value: IClassName) = mkTablePaginationClasses "selectIcon" value
    /// Styles applied to the `InputBase` component.
    static member inline input(value: IClassName) = mkTablePaginationClasses "input" value
    /// Styles applied to the MenuItem component.
    static member inline menuItem(value: IClassName) = mkTablePaginationClasses "menuItem" value
    /// Styles applied to the internal `TablePaginationActions` component.
    static member inline actions(value: IClassName) = mkTablePaginationClasses "actions" value


  type ITableRowClasses = interface end

  let inline private mkTableRowClasses (key: string) (value: IClassName) : ITableRowClasses = unbox (key, value)

  [<Erase>]
  type tableRow =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTableRowClasses "root" value
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(value: IClassName) = mkTableRowClasses "selected" value
    /// Pseudo-class applied to the root element if `hover={true}`.
    static member inline hover(value: IClassName) = mkTableRowClasses "hover" value
    /// Styles applied to the root element if table variant="head".
    static member inline head(value: IClassName) = mkTableRowClasses "head" value
    /// Styles applied to the root element if table variant="footer".
    static member inline footer(value: IClassName) = mkTableRowClasses "footer" value


  type ITableSortLabelClasses = interface end

  let inline private mkTableSortLabelClasses (key: string) (value: IClassName) : ITableSortLabelClasses = unbox (key, value)

  [<Erase>]
  type tableSortLabel =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTableSortLabelClasses "root" value
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(value: IClassName) = mkTableSortLabelClasses "active" value
    /// Styles applied to the icon component.
    static member inline icon(value: IClassName) = mkTableSortLabelClasses "icon" value
    /// Styles applied to the icon component if `direction="desc"`.
    static member inline iconDirectionDesc(value: IClassName) = mkTableSortLabelClasses "iconDirectionDesc" value
    /// Styles applied to the icon component if `direction="asc"`.
    static member inline iconDirectionAsc(value: IClassName) = mkTableSortLabelClasses "iconDirectionAsc" value


  type ITabsClasses = interface end

  let inline private mkTabsClasses (key: string) (value: IClassName) : ITabsClasses = unbox (key, value)

  [<Erase>]
  type tabs =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTabsClasses "root" value
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: IClassName) = mkTabsClasses "vertical" value
    /// Styles applied to the flex container element.
    static member inline flexContainer(value: IClassName) = mkTabsClasses "flexContainer" value
    /// Styles applied to the flex container element if `orientation="vertical"`.
    static member inline flexContainerVertical(value: IClassName) = mkTabsClasses "flexContainerVertical" value
    /// Styles applied to the flex container element if `centered={true}`&`!variant="scrollable"`.
    static member inline centered(value: IClassName) = mkTabsClasses "centered" value
    /// Styles applied to the tablist element.
    static member inline scroller(value: IClassName) = mkTabsClasses "scroller" value
    /// Styles applied to the tablist element if `!variant="scrollable"`.
    static member inline fixed'(value: IClassName) = mkTabsClasses "fixed" value
    /// Styles applied to the tablist element if `variant="scrollable"`.
    static member inline scrollable(value: IClassName) = mkTabsClasses "scrollable" value
    /// Styles applied to the `ScrollButtonComponent` component.
    static member inline scrollButtons(value: IClassName) = mkTabsClasses "scrollButtons" value
    /// Styles applied to the `ScrollButtonComponent` component if `scrollButtons="auto"` or scrollButtons="desktop"`.
    static member inline scrollButtonsDesktop(value: IClassName) = mkTabsClasses "scrollButtonsDesktop" value
    /// Styles applied to the `TabIndicator` component.
    static member inline indicator(value: IClassName) = mkTabsClasses "indicator" value


  type ITextareaAutosizeClasses = interface end


  type ITextFieldClasses = interface end

  let inline private mkTextFieldClasses (key: string) (value: IClassName) : ITextFieldClasses = unbox (key, value)

  [<Erase>]
  type textField =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTextFieldClasses "root" value


  type IToggleButtonClasses = interface end

  let inline private mkToggleButtonClasses (key: string) (value: IClassName) : IToggleButtonClasses = unbox (key, value)

  [<Erase>]
  type toggleButton =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkToggleButtonClasses "root" value
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: IClassName) = mkToggleButtonClasses "disabled" value
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(value: IClassName) = mkToggleButtonClasses "selected" value
    /// Styles applied to the `label` wrapper element.
    static member inline label(value: IClassName) = mkToggleButtonClasses "label" value
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: IClassName) = mkToggleButtonClasses "sizeSmall" value
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(value: IClassName) = mkToggleButtonClasses "sizeLarge" value


  type IToggleButtonGroupClasses = interface end

  let inline private mkToggleButtonGroupClasses (key: string) (value: IClassName) : IToggleButtonGroupClasses = unbox (key, value)

  [<Erase>]
  type toggleButtonGroup =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkToggleButtonGroupClasses "root" value


  type IToolbarClasses = interface end

  let inline private mkToolbarClasses (key: string) (value: IClassName) : IToolbarClasses = unbox (key, value)

  [<Erase>]
  type toolbar =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkToolbarClasses "root" value
    /// Styles applied to the root element if `disableGutters={false}`.
    static member inline gutters(value: IClassName) = mkToolbarClasses "gutters" value
    /// Styles applied to the root element if `variant="regular"`.
    static member inline regular(value: IClassName) = mkToolbarClasses "regular" value
    /// Styles applied to the root element if `variant="dense"`.
    static member inline dense(value: IClassName) = mkToolbarClasses "dense" value


  type ITooltipClasses = interface end

  let inline private mkTooltipClasses (key: string) (value: IClassName) : ITooltipClasses = unbox (key, value)

  [<Erase>]
  type tooltip =
    /// Styles applied to the Popper component.
    static member inline popper(value: IClassName) = mkTooltipClasses "popper" value
    /// Styles applied to the Popper component if `interactive={true}`.
    static member inline popperInteractive(value: IClassName) = mkTooltipClasses "popperInteractive" value
    /// Styles applied to the tooltip (label wrapper) element.
    static member inline tooltip(value: IClassName) = mkTooltipClasses "tooltip" value
    /// Styles applied to the tooltip (label wrapper) element if the tooltip is opened by touch.
    static member inline touch(value: IClassName) = mkTooltipClasses "touch" value
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "left".
    static member inline tooltipPlacementLeft(value: IClassName) = mkTooltipClasses "tooltipPlacementLeft" value
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "right".
    static member inline tooltipPlacementRight(value: IClassName) = mkTooltipClasses "tooltipPlacementRight" value
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "top".
    static member inline tooltipPlacementTop(value: IClassName) = mkTooltipClasses "tooltipPlacementTop" value
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "bottom".
    static member inline tooltipPlacementBottom(value: IClassName) = mkTooltipClasses "tooltipPlacementBottom" value


  type ITouchRippleClasses = interface end

  let inline private mkTouchRippleClasses (key: string) (value: IClassName) : ITouchRippleClasses = unbox (key, value)

  [<Erase>]
  type touchRipple =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTouchRippleClasses "root" value
    /// Styles applied to the internal `Ripple` components `ripple` class.
    static member inline ripple(value: IClassName) = mkTouchRippleClasses "ripple" value
    /// Styles applied to the internal `Ripple` components `rippleVisible` class.
    static member inline rippleVisible(value: IClassName) = mkTouchRippleClasses "rippleVisible" value
    /// Styles applied to the internal `Ripple` components `ripplePulsate` class.
    static member inline ripplePulsate(value: IClassName) = mkTouchRippleClasses "ripplePulsate" value
    /// Styles applied to the internal `Ripple` components `child` class.
    static member inline child(value: IClassName) = mkTouchRippleClasses "child" value
    /// Styles applied to the internal `Ripple` components `childLeaving` class.
    static member inline childLeaving(value: IClassName) = mkTouchRippleClasses "childLeaving" value
    /// Styles applied to the internal `Ripple` components `childPulsate` class.
    static member inline childPulsate(value: IClassName) = mkTouchRippleClasses "childPulsate" value


  type ITreeItemClasses = interface end

  let inline private mkTreeItemClasses (key: string) (value: IClassName) : ITreeItemClasses = unbox (key, value)

  [<Erase>]
  type treeItem =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTreeItemClasses "root" value
    /// Styles applied to the `role="group"` element.
    static member inline group(value: IClassName) = mkTreeItemClasses "group" value
    /// Styles applied to the tree node content.
    static member inline content(value: IClassName) = mkTreeItemClasses "content" value
    /// Styles applied to the tree node icon and collapse/expand icon.
    static member inline iconContainer(value: IClassName) = mkTreeItemClasses "iconContainer" value
    /// Styles applied to the label element.
    static member inline label(value: IClassName) = mkTreeItemClasses "label" value


  type ITreeViewClasses = interface end

  let inline private mkTreeViewClasses (key: string) (value: IClassName) : ITreeViewClasses = unbox (key, value)

  [<Erase>]
  type treeView =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTreeViewClasses "root" value


  type ITypographyClasses = interface end

  let inline private mkTypographyClasses (key: string) (value: IClassName) : ITypographyClasses = unbox (key, value)

  [<Erase>]
  type typography =
    /// Styles applied to the root element.
    static member inline root(value: IClassName) = mkTypographyClasses "root" value
    /// Styles applied to the root element if `variant="body2"`.
    static member inline body2(value: IClassName) = mkTypographyClasses "body2" value
    /// Styles applied to the root element if `variant="body1"`.
    static member inline body1(value: IClassName) = mkTypographyClasses "body1" value
    /// Styles applied to the root element if `variant="caption"`.
    static member inline caption(value: IClassName) = mkTypographyClasses "caption" value
    /// Styles applied to the root element if `variant="button"`.
    static member inline button(value: IClassName) = mkTypographyClasses "button" value
    /// Styles applied to the root element if `variant="h1"`.
    static member inline h1(value: IClassName) = mkTypographyClasses "h1" value
    /// Styles applied to the root element if `variant="h2"`.
    static member inline h2(value: IClassName) = mkTypographyClasses "h2" value
    /// Styles applied to the root element if `variant="h3"`.
    static member inline h3(value: IClassName) = mkTypographyClasses "h3" value
    /// Styles applied to the root element if `variant="h4"`.
    static member inline h4(value: IClassName) = mkTypographyClasses "h4" value
    /// Styles applied to the root element if `variant="h5"`.
    static member inline h5(value: IClassName) = mkTypographyClasses "h5" value
    /// Styles applied to the root element if `variant="h6"`.
    static member inline h6(value: IClassName) = mkTypographyClasses "h6" value
    /// Styles applied to the root element if `variant="subtitle1"`.
    static member inline subtitle1(value: IClassName) = mkTypographyClasses "subtitle1" value
    /// Styles applied to the root element if `variant="subtitle2"`.
    static member inline subtitle2(value: IClassName) = mkTypographyClasses "subtitle2" value
    /// Styles applied to the root element if `variant="overline"`.
    static member inline overline(value: IClassName) = mkTypographyClasses "overline" value
    /// Styles applied to the root element if `variant="srOnly"`. Only accessible to screen readers.
    static member inline srOnly(value: IClassName) = mkTypographyClasses "srOnly" value
    /// Styles applied to the root element if `align="left"`.
    static member inline alignLeft(value: IClassName) = mkTypographyClasses "alignLeft" value
    /// Styles applied to the root element if `align="center"`.
    static member inline alignCenter(value: IClassName) = mkTypographyClasses "alignCenter" value
    /// Styles applied to the root element if `align="right"`.
    static member inline alignRight(value: IClassName) = mkTypographyClasses "alignRight" value
    /// Styles applied to the root element if `align="justify"`.
    static member inline alignJustify(value: IClassName) = mkTypographyClasses "alignJustify" value
    /// Styles applied to the root element if `align="nowrap"`.
    static member inline noWrap(value: IClassName) = mkTypographyClasses "noWrap" value
    /// Styles applied to the root element if `gutterBottom={true}`.
    static member inline gutterBottom(value: IClassName) = mkTypographyClasses "gutterBottom" value
    /// Styles applied to the root element if `paragraph={true}`.
    static member inline paragraph(value: IClassName) = mkTypographyClasses "paragraph" value
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: IClassName) = mkTypographyClasses "colorInherit" value
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: IClassName) = mkTypographyClasses "colorPrimary" value
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: IClassName) = mkTypographyClasses "colorSecondary" value
    /// Styles applied to the root element if `color="textPrimary"`.
    static member inline colorTextPrimary(value: IClassName) = mkTypographyClasses "colorTextPrimary" value
    /// Styles applied to the root element if `color="textSecondary"`.
    static member inline colorTextSecondary(value: IClassName) = mkTypographyClasses "colorTextSecondary" value
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: IClassName) = mkTypographyClasses "colorError" value
    /// Styles applied to the root element if `display="inline"`.
    static member inline displayInline(value: IClassName) = mkTypographyClasses "displayInline" value
    /// Styles applied to the root element if `display="block"`.
    static member inline displayBlock(value: IClassName) = mkTypographyClasses "displayBlock" value


  type IZoomClasses = interface end

