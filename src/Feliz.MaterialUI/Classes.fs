namespace Feliz.MaterialUI
  
(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
  
/// Override or extend the styles applied to components.
module classes =

  type IAppBarClasses = interface end

  [<Erase>]
  type appBar =
    /// Styles applied to the root element.
    static member inline root(value: string) : IAppBarClasses = unbox ("root", value)
    /// Styles applied to the root element if `position="fixed"`.
    static member inline positionFixed(value: string) : IAppBarClasses = unbox ("positionFixed", value)
    /// Styles applied to the root element if `position="absolute"`.
    static member inline positionAbsolute(value: string) : IAppBarClasses = unbox ("positionAbsolute", value)
    /// Styles applied to the root element if `position="sticky"`.
    static member inline positionSticky(value: string) : IAppBarClasses = unbox ("positionSticky", value)
    /// Styles applied to the root element if `position="static"`.
    static member inline positionStatic(value: string) : IAppBarClasses = unbox ("positionStatic", value)
    /// Styles applied to the root element if `position="relative"`.
    static member inline positionRelative(value: string) : IAppBarClasses = unbox ("positionRelative", value)
    /// Styles applied to the root element if `color="default"`.
    static member inline colorDefault(value: string) : IAppBarClasses = unbox ("colorDefault", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) : IAppBarClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) : IAppBarClasses = unbox ("colorSecondary", value)


  type IAvatarClasses = interface end

  [<Erase>]
  type avatar =
    /// Styles applied to the root element.
    static member inline root(value: string) : IAvatarClasses = unbox ("root", value)
    /// Styles applied to the root element if there are children and not `src` or `srcSet`.
    static member inline colorDefault(value: string) : IAvatarClasses = unbox ("colorDefault", value)
    /// Styles applied to the img element if either `src` or `srcSet` is defined.
    static member inline img(value: string) : IAvatarClasses = unbox ("img", value)


  type IBackdropClasses = interface end

  [<Erase>]
  type backdrop =
    /// Styles applied to the root element.
    static member inline root(value: string) : IBackdropClasses = unbox ("root", value)
    /// Styles applied to the root element if `invisible={true}`.
    static member inline invisible(value: string) : IBackdropClasses = unbox ("invisible", value)


  type IBadgeClasses = interface end

  [<Erase>]
  type badge =
    /// Styles applied to the root element.
    static member inline root(value: string) : IBadgeClasses = unbox ("root", value)
    /// Styles applied to the badge `span` element.
    static member inline badge(value: string) : IBadgeClasses = unbox ("badge", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) : IBadgeClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) : IBadgeClasses = unbox ("colorSecondary", value)
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: string) : IBadgeClasses = unbox ("colorError", value)
    /// Styles applied to the badge `span` element if `invisible={true}`.
    static member inline invisible(value: string) : IBadgeClasses = unbox ("invisible", value)
    /// Styles applied to the root element if `variant="dot"`.
    static member inline dot(value: string) : IBadgeClasses = unbox ("dot", value)


  type IBottomNavigationClasses = interface end

  [<Erase>]
  type bottomNavigation =
    /// Styles applied to the root element.
    static member inline root(value: string) : IBottomNavigationClasses = unbox ("root", value)


  type IBottomNavigationActionClasses = interface end

  [<Erase>]
  type bottomNavigationAction =
    /// Styles applied to the root element.
    static member inline root(value: string) : IBottomNavigationActionClasses = unbox ("root", value)
    /// Pseudo-class applied to the root element if selected.
    static member inline selected(value: string) : IBottomNavigationActionClasses = unbox ("selected", value)
    /// Pseudo-class applied to the root element if `showLabel={false}` and not selected.
    static member inline iconOnly(value: string) : IBottomNavigationActionClasses = unbox ("iconOnly", value)
    /// Styles applied to the span element that wraps the icon and label.
    static member inline wrapper(value: string) : IBottomNavigationActionClasses = unbox ("wrapper", value)
    /// Styles applied to the label's span element.
    static member inline label(value: string) : IBottomNavigationActionClasses = unbox ("label", value)


  type IBreadcrumbsClasses = interface end

  [<Erase>]
  type breadcrumbs =
    /// Styles applied to the root element.
    static member inline root(value: string) : IBreadcrumbsClasses = unbox ("root", value)
    /// Styles applied to the ol element.
    static member inline ol(value: string) : IBreadcrumbsClasses = unbox ("ol", value)
    /// Styles applied to the li element.
    static member inline li(value: string) : IBreadcrumbsClasses = unbox ("li", value)
    /// Styles applied to the separator element.
    static member inline separator(value: string) : IBreadcrumbsClasses = unbox ("separator", value)


  type IButtonClasses = interface end

  [<Erase>]
  type button =
    /// Styles applied to the root element.
    static member inline root(value: string) : IButtonClasses = unbox ("root", value)
    /// Styles applied to the span element that wraps the children.
    static member inline label(value: string) : IButtonClasses = unbox ("label", value)
    /// Styles applied to the root element if `variant="text"`.
    static member inline text(value: string) : IButtonClasses = unbox ("text", value)
    /// Styles applied to the root element if `variant="text"` and `color="primary"`.
    static member inline textPrimary(value: string) : IButtonClasses = unbox ("textPrimary", value)
    /// Styles applied to the root element if `variant="text"` and `color="secondary"`.
    static member inline textSecondary(value: string) : IButtonClasses = unbox ("textSecondary", value)
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(value: string) : IButtonClasses = unbox ("outlined", value)
    /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
    static member inline outlinedPrimary(value: string) : IButtonClasses = unbox ("outlinedPrimary", value)
    /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
    static member inline outlinedSecondary(value: string) : IButtonClasses = unbox ("outlinedSecondary", value)
    /// Styles applied to the root element if `variant="contained"`.
    static member inline contained(value: string) : IButtonClasses = unbox ("contained", value)
    /// Styles applied to the root element if `variant="contained"` and `color="primary"`.
    static member inline containedPrimary(value: string) : IButtonClasses = unbox ("containedPrimary", value)
    /// Styles applied to the root element if `variant="contained"` and `color="secondary"`.
    static member inline containedSecondary(value: string) : IButtonClasses = unbox ("containedSecondary", value)
    /// Pseudo-class applied to the ButtonBase root element if the button is keyboard focused.
    static member inline focusVisible(value: string) : IButtonClasses = unbox ("focusVisible", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IButtonClasses = unbox ("disabled", value)
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: string) : IButtonClasses = unbox ("colorInherit", value)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) : IButtonClasses = unbox ("sizeSmall", value)
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(value: string) : IButtonClasses = unbox ("sizeLarge", value)
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: string) : IButtonClasses = unbox ("fullWidth", value)


  type IButtonBaseClasses = interface end

  [<Erase>]
  type buttonBase =
    /// Styles applied to the root element.
    static member inline root(value: string) : IButtonBaseClasses = unbox ("root", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IButtonBaseClasses = unbox ("disabled", value)
    /// Pseudo-class applied to the root element if keyboard focused.
    static member inline focusVisible(value: string) : IButtonBaseClasses = unbox ("focusVisible", value)


  type IButtonGroupClasses = interface end

  [<Erase>]
  type buttonGroup =
    /// Styles applied to the root element.
    static member inline root(value: string) : IButtonGroupClasses = unbox ("root", value)
    /// Styles applied to the root element if variant="contained".
    static member inline contained(value: string) : IButtonGroupClasses = unbox ("contained", value)
    /// Styles applied to the root element if fullWidth={true}.
    static member inline fullWidth(value: string) : IButtonGroupClasses = unbox ("fullWidth", value)
    /// Styles applied to the children.
    static member inline grouped(value: string) : IButtonGroupClasses = unbox ("grouped", value)
    /// Styles applied to the children if variant="outlined".
    static member inline groupedOutlined(value: string) : IButtonGroupClasses = unbox ("groupedOutlined", value)
    /// Styles applied to the children if variant="outlined"& color="primary".
    static member inline groupedOutlinedPrimary(value: string) : IButtonGroupClasses = unbox ("groupedOutlinedPrimary", value)
    /// Styles applied to the children if variant="outlined"& color="secondary".
    static member inline groupedOutlinedSecondary(value: string) : IButtonGroupClasses = unbox ("groupedOutlinedSecondary", value)
    /// Styles applied to the children if variant="contained".
    static member inline groupedContained(value: string) : IButtonGroupClasses = unbox ("groupedContained", value)
    /// Styles applied to the children if variant="contained"& color="primary".
    static member inline groupedContainedPrimary(value: string) : IButtonGroupClasses = unbox ("groupedContainedPrimary", value)
    /// Styles applied to the children if variant="contained"& color="secondary".
    static member inline groupedContainedSecondary(value: string) : IButtonGroupClasses = unbox ("groupedContainedSecondary", value)
    /// Pseudo-class applied to child elements if `disabled={true}`.
    static member inline disabled(value: string) : IButtonGroupClasses = unbox ("disabled", value)


  type ICardClasses = interface end

  [<Erase>]
  type card =
    /// Styles applied to the root element.
    static member inline root(value: string) : ICardClasses = unbox ("root", value)


  type ICardActionAreaClasses = interface end

  [<Erase>]
  type cardActionArea =
    /// Styles applied to the root element.
    static member inline root(value: string) : ICardActionAreaClasses = unbox ("root", value)
    /// Pseudo-class applied to the ButtonBase root element if the action area is keyboard focused.
    static member inline focusVisible(value: string) : ICardActionAreaClasses = unbox ("focusVisible", value)
    /// Styles applied to the overlay that covers the action area when it is keyboard focused.
    static member inline focusHighlight(value: string) : ICardActionAreaClasses = unbox ("focusHighlight", value)


  type ICardActionsClasses = interface end

  [<Erase>]
  type cardActions =
    /// Styles applied to the root element.
    static member inline root(value: string) : ICardActionsClasses = unbox ("root", value)
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(value: string) : ICardActionsClasses = unbox ("spacing", value)


  type ICardContentClasses = interface end

  [<Erase>]
  type cardContent =
    /// Styles applied to the root element.
    static member inline root(value: string) : ICardContentClasses = unbox ("root", value)


  type ICardHeaderClasses = interface end

  [<Erase>]
  type cardHeader =
    /// Styles applied to the root element.
    static member inline root(value: string) : ICardHeaderClasses = unbox ("root", value)
    /// Styles applied to the avatar element.
    static member inline avatar(value: string) : ICardHeaderClasses = unbox ("avatar", value)
    /// Styles applied to the action element.
    static member inline action(value: string) : ICardHeaderClasses = unbox ("action", value)
    /// Styles applied to the content wrapper element.
    static member inline content(value: string) : ICardHeaderClasses = unbox ("content", value)
    /// Styles applied to the title Typography element.
    static member inline title(value: string) : ICardHeaderClasses = unbox ("title", value)
    /// Styles applied to the subheader Typography element.
    static member inline subheader(value: string) : ICardHeaderClasses = unbox ("subheader", value)


  type ICardMediaClasses = interface end

  [<Erase>]
  type cardMedia =
    /// Styles applied to the root element.
    static member inline root(value: string) : ICardMediaClasses = unbox ("root", value)
    /// Styles applied to the root element if `component="video, audio, picture, iframe, or img"`.
    static member inline media(value: string) : ICardMediaClasses = unbox ("media", value)


  type ICheckboxClasses = interface end

  [<Erase>]
  type checkbox =
    /// Styles applied to the root element.
    static member inline root(value: string) : ICheckboxClasses = unbox ("root", value)
    /// Pseudo-class applied to the root element if `checked={true}`.
    static member inline checked'(value: string) : ICheckboxClasses = unbox ("checked", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : ICheckboxClasses = unbox ("disabled", value)
    /// Pseudo-class applied to the root element if `indeterminate={true}`.
    static member inline indeterminate(value: string) : ICheckboxClasses = unbox ("indeterminate", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) : ICheckboxClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) : ICheckboxClasses = unbox ("colorSecondary", value)


  type IChipClasses = interface end

  [<Erase>]
  type chip =
    /// Styles applied to the root element.
    static member inline root(value: string) : IChipClasses = unbox ("root", value)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) : IChipClasses = unbox ("sizeSmall", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) : IChipClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) : IChipClasses = unbox ("colorSecondary", value)
    /// Styles applied to the root element if `onClick` is defined or `clickable={true}`.
    static member inline clickable(value: string) : IChipClasses = unbox ("clickable", value)
    /// Styles applied to the root element if `onClick` and `color="primary"` is defined or `clickable={true}`.
    static member inline clickableColorPrimary(value: string) : IChipClasses = unbox ("clickableColorPrimary", value)
    /// Styles applied to the root element if `onClick` and `color="secondary"` is defined or `clickable={true}`.
    static member inline clickableColorSecondary(value: string) : IChipClasses = unbox ("clickableColorSecondary", value)
    /// Styles applied to the root element if `onDelete` is defined.
    static member inline deletable(value: string) : IChipClasses = unbox ("deletable", value)
    /// Styles applied to the root element if `onDelete` and `color="primary"` is defined.
    static member inline deletableColorPrimary(value: string) : IChipClasses = unbox ("deletableColorPrimary", value)
    /// Styles applied to the root element if `onDelete` and `color="secondary"` is defined.
    static member inline deletableColorSecondary(value: string) : IChipClasses = unbox ("deletableColorSecondary", value)
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(value: string) : IChipClasses = unbox ("outlined", value)
    /// Styles applied to the root element if `variant="outlined"` and `color="primary"`.
    static member inline outlinedPrimary(value: string) : IChipClasses = unbox ("outlinedPrimary", value)
    /// Styles applied to the root element if `variant="outlined"` and `color="secondary"`.
    static member inline outlinedSecondary(value: string) : IChipClasses = unbox ("outlinedSecondary", value)
    /// Styles applied to the `avatar` element.
    static member inline avatar(value: string) : IChipClasses = unbox ("avatar", value)
    static member inline avatarSmall(value: string) : IChipClasses = unbox ("avatarSmall", value)
    /// Styles applied to the `avatar` element if `color="primary"`.
    static member inline avatarColorPrimary(value: string) : IChipClasses = unbox ("avatarColorPrimary", value)
    /// Styles applied to the `avatar` element if `color="secondary"`.
    static member inline avatarColorSecondary(value: string) : IChipClasses = unbox ("avatarColorSecondary", value)
    /// Styles applied to the `avatar` elements children.
    static member inline avatarChildren(value: string) : IChipClasses = unbox ("avatarChildren", value)
    /// Styles applied to the `icon` element.
    static member inline icon(value: string) : IChipClasses = unbox ("icon", value)
    static member inline iconSmall(value: string) : IChipClasses = unbox ("iconSmall", value)
    /// Styles applied to the `icon` element if `color="primary"`.
    static member inline iconColorPrimary(value: string) : IChipClasses = unbox ("iconColorPrimary", value)
    /// Styles applied to the `icon` element if `color="secondary"`.
    static member inline iconColorSecondary(value: string) : IChipClasses = unbox ("iconColorSecondary", value)
    /// Styles applied to the label `span` element`.
    static member inline label(value: string) : IChipClasses = unbox ("label", value)
    static member inline labelSmall(value: string) : IChipClasses = unbox ("labelSmall", value)
    /// Styles applied to the `deleteIcon` element.
    static member inline deleteIcon(value: string) : IChipClasses = unbox ("deleteIcon", value)
    static member inline deleteIconSmall(value: string) : IChipClasses = unbox ("deleteIconSmall", value)
    /// Styles applied to the deleteIcon element if `color="primary"` and `variant="default"`.
    static member inline deleteIconColorPrimary(value: string) : IChipClasses = unbox ("deleteIconColorPrimary", value)
    /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="default"`.
    static member inline deleteIconColorSecondary(value: string) : IChipClasses = unbox ("deleteIconColorSecondary", value)
    /// Styles applied to the deleteIcon element if `color="primary"` and `variant="outlined"`.
    static member inline deleteIconOutlinedColorPrimary(value: string) : IChipClasses = unbox ("deleteIconOutlinedColorPrimary", value)
    /// Styles applied to the deleteIcon element if `color="secondary"` and `variant="outlined"`.
    static member inline deleteIconOutlinedColorSecondary(value: string) : IChipClasses = unbox ("deleteIconOutlinedColorSecondary", value)


  type ICircularProgressClasses = interface end

  [<Erase>]
  type circularProgress =
    /// Styles applied to the root element.
    static member inline root(value: string) : ICircularProgressClasses = unbox ("root", value)
    /// Styles applied to the root element if `variant="static"`.
    static member inline static'(value: string) : ICircularProgressClasses = unbox ("static", value)
    /// Styles applied to the root element if `variant="indeterminate"`.
    static member inline indeterminate(value: string) : ICircularProgressClasses = unbox ("indeterminate", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) : ICircularProgressClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) : ICircularProgressClasses = unbox ("colorSecondary", value)
    /// Styles applied to the `svg` element.
    static member inline svg(value: string) : ICircularProgressClasses = unbox ("svg", value)
    /// Styles applied to the `circle` svg path.
    static member inline circle(value: string) : ICircularProgressClasses = unbox ("circle", value)
    /// Styles applied to the `circle` svg path if `variant="static"`.
    static member inline circleStatic(value: string) : ICircularProgressClasses = unbox ("circleStatic", value)
    /// Styles applied to the `circle` svg path if `variant="indeterminate"`.
    static member inline circleIndeterminate(value: string) : ICircularProgressClasses = unbox ("circleIndeterminate", value)
    /// Styles applied to the `circle` svg path if `disableShrink={true}`.
    static member inline circleDisableShrink(value: string) : ICircularProgressClasses = unbox ("circleDisableShrink", value)


  type IClickAwayListenerClasses = interface end


  type ICollapseClasses = interface end

  [<Erase>]
  type collapse =
    /// Styles applied to the container element.
    static member inline container(value: string) : ICollapseClasses = unbox ("container", value)
    /// Styles applied to the container element when the transition has entered.
    static member inline entered(value: string) : ICollapseClasses = unbox ("entered", value)
    /// Styles applied to the container element when the transition has exited and `collapsedHeight` != 0px.
    static member inline hidden(value: string) : ICollapseClasses = unbox ("hidden", value)
    /// Styles applied to the outer wrapper element.
    static member inline wrapper(value: string) : ICollapseClasses = unbox ("wrapper", value)
    /// Styles applied to the inner wrapper element.
    static member inline wrapperInner(value: string) : ICollapseClasses = unbox ("wrapperInner", value)


  type IContainerClasses = interface end

  [<Erase>]
  type container =
    /// Styles applied to the root element.
    static member inline root(value: string) : IContainerClasses = unbox ("root", value)
    /// Styles applied to the root element if `fixed={true}`.
    static member inline fixed'(value: string) : IContainerClasses = unbox ("fixed", value)
    /// Styles applied to the root element if `maxWidth="xs"`.
    static member inline maxWidthXs(value: string) : IContainerClasses = unbox ("maxWidthXs", value)
    /// Styles applied to the root element if `maxWidth="sm"`.
    static member inline maxWidthSm(value: string) : IContainerClasses = unbox ("maxWidthSm", value)
    /// Styles applied to the root element if `maxWidth="md"`.
    static member inline maxWidthMd(value: string) : IContainerClasses = unbox ("maxWidthMd", value)
    /// Styles applied to the root element if `maxWidth="lg"`.
    static member inline maxWidthLg(value: string) : IContainerClasses = unbox ("maxWidthLg", value)
    /// Styles applied to the root element if `maxWidth="xl"`.
    static member inline maxWidthXl(value: string) : IContainerClasses = unbox ("maxWidthXl", value)


  type ICssBaselineClasses = interface end


  type IDialogClasses = interface end

  [<Erase>]
  type dialog =
    /// Styles applied to the root element.
    static member inline root(value: string) : IDialogClasses = unbox ("root", value)
    /// Styles applied to the container element if `scroll="paper"`.
    static member inline scrollPaper(value: string) : IDialogClasses = unbox ("scrollPaper", value)
    /// Styles applied to the container element if `scroll="body"`.
    static member inline scrollBody(value: string) : IDialogClasses = unbox ("scrollBody", value)
    /// Styles applied to the container element.
    static member inline container(value: string) : IDialogClasses = unbox ("container", value)
    /// Styles applied to the `Paper` component.
    static member inline paper(value: string) : IDialogClasses = unbox ("paper", value)
    /// Styles applied to the `Paper` component if `scroll="paper"`.
    static member inline paperScrollPaper(value: string) : IDialogClasses = unbox ("paperScrollPaper", value)
    /// Styles applied to the `Paper` component if `scroll="body"`.
    static member inline paperScrollBody(value: string) : IDialogClasses = unbox ("paperScrollBody", value)
    /// Styles applied to the `Paper` component if `maxWidth=false`.
    static member inline paperWidthFalse(value: string) : IDialogClasses = unbox ("paperWidthFalse", value)
    /// Styles applied to the `Paper` component if `maxWidth="xs"`.
    static member inline paperWidthXs(value: string) : IDialogClasses = unbox ("paperWidthXs", value)
    /// Styles applied to the `Paper` component if `maxWidth="sm"`.
    static member inline paperWidthSm(value: string) : IDialogClasses = unbox ("paperWidthSm", value)
    /// Styles applied to the `Paper` component if `maxWidth="md"`.
    static member inline paperWidthMd(value: string) : IDialogClasses = unbox ("paperWidthMd", value)
    /// Styles applied to the `Paper` component if `maxWidth="lg"`.
    static member inline paperWidthLg(value: string) : IDialogClasses = unbox ("paperWidthLg", value)
    /// Styles applied to the `Paper` component if `maxWidth="xl"`.
    static member inline paperWidthXl(value: string) : IDialogClasses = unbox ("paperWidthXl", value)
    /// Styles applied to the `Paper` component if `fullWidth={true}`.
    static member inline paperFullWidth(value: string) : IDialogClasses = unbox ("paperFullWidth", value)
    /// Styles applied to the `Paper` component if `fullScreen={true}`.
    static member inline paperFullScreen(value: string) : IDialogClasses = unbox ("paperFullScreen", value)


  type IDialogActionsClasses = interface end

  [<Erase>]
  type dialogActions =
    /// Styles applied to the root element.
    static member inline root(value: string) : IDialogActionsClasses = unbox ("root", value)
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(value: string) : IDialogActionsClasses = unbox ("spacing", value)


  type IDialogContentClasses = interface end

  [<Erase>]
  type dialogContent =
    /// Styles applied to the root element.
    static member inline root(value: string) : IDialogContentClasses = unbox ("root", value)
    /// Styles applied to the root element if `dividers={true}`.
    static member inline dividers(value: string) : IDialogContentClasses = unbox ("dividers", value)


  type IDialogContentTextClasses = interface end

  [<Erase>]
  type dialogContentText =
    /// Styles applied to the root element.
    static member inline root(value: string) : IDialogContentTextClasses = unbox ("root", value)


  type IDialogTitleClasses = interface end

  [<Erase>]
  type dialogTitle =
    /// Styles applied to the root element.
    static member inline root(value: string) : IDialogTitleClasses = unbox ("root", value)


  type IDividerClasses = interface end

  [<Erase>]
  type divider =
    /// Styles applied to the root element.
    static member inline root(value: string) : IDividerClasses = unbox ("root", value)
    /// Styles applied to the root element if `absolute={true}`.
    static member inline absolute(value: string) : IDividerClasses = unbox ("absolute", value)
    /// Styles applied to the root element if `variant="inset"`.
    static member inline inset(value: string) : IDividerClasses = unbox ("inset", value)
    /// Styles applied to the root element if `light={true}`.
    static member inline light(value: string) : IDividerClasses = unbox ("light", value)
    /// Styles applied to the root element if `variant="middle"`.
    static member inline middle(value: string) : IDividerClasses = unbox ("middle", value)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) : IDividerClasses = unbox ("vertical", value)


  type IDrawerClasses = interface end

  [<Erase>]
  type drawer =
    /// Styles applied to the root element.
    static member inline root(value: string) : IDrawerClasses = unbox ("root", value)
    /// Styles applied to the root element if `variant="permanent or persistent"`.
    static member inline docked(value: string) : IDrawerClasses = unbox ("docked", value)
    /// Styles applied to the `Paper` component.
    static member inline paper(value: string) : IDrawerClasses = unbox ("paper", value)
    /// Styles applied to the `Paper` component if `anchor="left"`.
    static member inline paperAnchorLeft(value: string) : IDrawerClasses = unbox ("paperAnchorLeft", value)
    /// Styles applied to the `Paper` component if `anchor="right"`.
    static member inline paperAnchorRight(value: string) : IDrawerClasses = unbox ("paperAnchorRight", value)
    /// Styles applied to the `Paper` component if `anchor="top"`.
    static member inline paperAnchorTop(value: string) : IDrawerClasses = unbox ("paperAnchorTop", value)
    /// Styles applied to the `Paper` component if `anchor="bottom"`.
    static member inline paperAnchorBottom(value: string) : IDrawerClasses = unbox ("paperAnchorBottom", value)
    /// Styles applied to the `Paper` component if `anchor="left"`&`variant` is not "temporary".
    static member inline paperAnchorDockedLeft(value: string) : IDrawerClasses = unbox ("paperAnchorDockedLeft", value)
    /// Styles applied to the `Paper` component if `anchor="top"`&`variant` is not "temporary".
    static member inline paperAnchorDockedTop(value: string) : IDrawerClasses = unbox ("paperAnchorDockedTop", value)
    /// Styles applied to the `Paper` component if `anchor="right"`&`variant` is not "temporary".
    static member inline paperAnchorDockedRight(value: string) : IDrawerClasses = unbox ("paperAnchorDockedRight", value)
    /// Styles applied to the `Paper` component if `anchor="bottom"`&`variant` is not "temporary".
    static member inline paperAnchorDockedBottom(value: string) : IDrawerClasses = unbox ("paperAnchorDockedBottom", value)
    /// Styles applied to the `Modal` component.
    static member inline modal(value: string) : IDrawerClasses = unbox ("modal", value)


  type IExpansionPanelClasses = interface end

  [<Erase>]
  type expansionPanel =
    /// Styles applied to the root element.
    static member inline root(value: string) : IExpansionPanelClasses = unbox ("root", value)
    /// Styles applied to the root element if `square={false}`.
    static member inline rounded(value: string) : IExpansionPanelClasses = unbox ("rounded", value)
    /// Styles applied to the root element if `expanded={true}`.
    static member inline expanded(value: string) : IExpansionPanelClasses = unbox ("expanded", value)
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IExpansionPanelClasses = unbox ("disabled", value)


  type IExpansionPanelActionsClasses = interface end

  [<Erase>]
  type expansionPanelActions =
    /// Styles applied to the root element.
    static member inline root(value: string) : IExpansionPanelActionsClasses = unbox ("root", value)
    /// Styles applied to the root element if `disableSpacing={false}`.
    static member inline spacing(value: string) : IExpansionPanelActionsClasses = unbox ("spacing", value)


  type IExpansionPanelDetailsClasses = interface end

  [<Erase>]
  type expansionPanelDetails =
    /// Styles applied to the root element.
    static member inline root(value: string) : IExpansionPanelDetailsClasses = unbox ("root", value)


  type IExpansionPanelSummaryClasses = interface end

  [<Erase>]
  type expansionPanelSummary =
    /// Styles applied to the root element.
    static member inline root(value: string) : IExpansionPanelSummaryClasses = unbox ("root", value)
    /// Styles applied to the root element, children wrapper element and `IconButton` component if `expanded={true}`.
    static member inline expanded(value: string) : IExpansionPanelSummaryClasses = unbox ("expanded", value)
    /// Styles applied to the root and children wrapper elements when focused.
    static member inline focused(value: string) : IExpansionPanelSummaryClasses = unbox ("focused", value)
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IExpansionPanelSummaryClasses = unbox ("disabled", value)
    /// Styles applied to the children wrapper element.
    static member inline content(value: string) : IExpansionPanelSummaryClasses = unbox ("content", value)
    /// Styles applied to the `IconButton` component when `expandIcon` is supplied.
    static member inline expandIcon(value: string) : IExpansionPanelSummaryClasses = unbox ("expandIcon", value)


  type IFabClasses = interface end

  [<Erase>]
  type fab =
    /// Styles applied to the root element.
    static member inline root(value: string) : IFabClasses = unbox ("root", value)
    /// Styles applied to the span element that wraps the children.
    static member inline label(value: string) : IFabClasses = unbox ("label", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline primary(value: string) : IFabClasses = unbox ("primary", value)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline secondary(value: string) : IFabClasses = unbox ("secondary", value)
    /// Styles applied to the root element if `variant="extended"`.
    static member inline extended(value: string) : IFabClasses = unbox ("extended", value)
    /// Pseudo-class applied to the ButtonBase root element if the button is keyboard focused.
    static member inline focusVisible(value: string) : IFabClasses = unbox ("focusVisible", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IFabClasses = unbox ("disabled", value)
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: string) : IFabClasses = unbox ("colorInherit", value)
    /// Styles applied to the root element if `size="small"``.
    static member inline sizeSmall(value: string) : IFabClasses = unbox ("sizeSmall", value)
    /// Styles applied to the root element if `size="medium"``.
    static member inline sizeMedium(value: string) : IFabClasses = unbox ("sizeMedium", value)


  type IFadeClasses = interface end


  type IFilledInputClasses = interface end

  [<Erase>]
  type filledInput =
    /// Styles applied to the root element.
    static member inline root(value: string) : IFilledInputClasses = unbox ("root", value)
    /// Styles applied to the root element if `disableUnderline={false}`.
    static member inline underline(value: string) : IFilledInputClasses = unbox ("underline", value)
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: string) : IFilledInputClasses = unbox ("focused", value)
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IFilledInputClasses = unbox ("disabled", value)
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(value: string) : IFilledInputClasses = unbox ("adornedStart", value)
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(value: string) : IFilledInputClasses = unbox ("adornedEnd", value)
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: string) : IFilledInputClasses = unbox ("error", value)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(value: string) : IFilledInputClasses = unbox ("marginDense", value)
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: string) : IFilledInputClasses = unbox ("multiline", value)
    /// Styles applied to the `input` element.
    static member inline input(value: string) : IFilledInputClasses = unbox ("input", value)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: string) : IFilledInputClasses = unbox ("inputMarginDense", value)
    /// Styles applied to the `input` if in ``.
    static member inline inputHiddenLabel(value: string) : IFilledInputClasses = unbox ("inputHiddenLabel", value)
    /// Styles applied to the `input` element if `select={true}`.
    static member inline inputSelect(value: string) : IFilledInputClasses = unbox ("inputSelect", value)
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: string) : IFilledInputClasses = unbox ("inputMultiline", value)
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(value: string) : IFilledInputClasses = unbox ("inputAdornedStart", value)
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(value: string) : IFilledInputClasses = unbox ("inputAdornedEnd", value)


  type IFormControlClasses = interface end

  [<Erase>]
  type formControl =
    /// Styles applied to the root element.
    static member inline root(value: string) : IFormControlClasses = unbox ("root", value)
    /// Styles applied to the root element if `margin="normal"`.
    static member inline marginNormal(value: string) : IFormControlClasses = unbox ("marginNormal", value)
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(value: string) : IFormControlClasses = unbox ("marginDense", value)
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: string) : IFormControlClasses = unbox ("fullWidth", value)


  type IFormControlLabelClasses = interface end

  [<Erase>]
  type formControlLabel =
    /// Styles applied to the root element.
    static member inline root(value: string) : IFormControlLabelClasses = unbox ("root", value)
    /// Styles applied to the root element if `labelPlacement="start"`.
    static member inline labelPlacementStart(value: string) : IFormControlLabelClasses = unbox ("labelPlacementStart", value)
    /// Styles applied to the root element if `labelPlacement="top"`.
    static member inline labelPlacementTop(value: string) : IFormControlLabelClasses = unbox ("labelPlacementTop", value)
    /// Styles applied to the root element if `labelPlacement="bottom"`.
    static member inline labelPlacementBottom(value: string) : IFormControlLabelClasses = unbox ("labelPlacementBottom", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IFormControlLabelClasses = unbox ("disabled", value)
    /// Styles applied to the label's Typography component.
    static member inline label(value: string) : IFormControlLabelClasses = unbox ("label", value)


  type IFormGroupClasses = interface end

  [<Erase>]
  type formGroup =
    /// Styles applied to the root element.
    static member inline root(value: string) : IFormGroupClasses = unbox ("root", value)
    /// Styles applied to the root element if `row={true}`.
    static member inline row(value: string) : IFormGroupClasses = unbox ("row", value)


  type IFormHelperTextClasses = interface end

  [<Erase>]
  type formHelperText =
    /// Styles applied to the root element.
    static member inline root(value: string) : IFormHelperTextClasses = unbox ("root", value)
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: string) : IFormHelperTextClasses = unbox ("error", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IFormHelperTextClasses = unbox ("disabled", value)
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(value: string) : IFormHelperTextClasses = unbox ("marginDense", value)
    /// Styles applied to the root element if `variant="filled"` or `variant="outlined"`.
    static member inline contained(value: string) : IFormHelperTextClasses = unbox ("contained", value)
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(value: string) : IFormHelperTextClasses = unbox ("focused", value)
    /// Pseudo-class applied to the root element if `filled={true}`.
    static member inline filled(value: string) : IFormHelperTextClasses = unbox ("filled", value)
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(value: string) : IFormHelperTextClasses = unbox ("required", value)


  type IFormLabelClasses = interface end

  [<Erase>]
  type formLabel =
    /// Styles applied to the root element.
    static member inline root(value: string) : IFormLabelClasses = unbox ("root", value)
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(value: string) : IFormLabelClasses = unbox ("focused", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IFormLabelClasses = unbox ("disabled", value)
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: string) : IFormLabelClasses = unbox ("error", value)
    /// Pseudo-class applied to the root element if `filled={true}`.
    static member inline filled(value: string) : IFormLabelClasses = unbox ("filled", value)
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(value: string) : IFormLabelClasses = unbox ("required", value)
    /// Styles applied to the asterisk element.
    static member inline asterisk(value: string) : IFormLabelClasses = unbox ("asterisk", value)


  type IGridClasses = interface end

  [<Erase>]
  type grid =
    /// Styles applied to the root element
    static member inline root(value: string) : IGridClasses = unbox ("root", value)
    /// Styles applied to the root element if `container={true}`.
    static member inline container(value: string) : IGridClasses = unbox ("container", value)
    /// Styles applied to the root element if `item={true}`.
    static member inline item(value: string) : IGridClasses = unbox ("item", value)
    /// Styles applied to the root element if `zeroMinWidth={true}`.
    static member inline zeroMinWidth(value: string) : IGridClasses = unbox ("zeroMinWidth", value)
    static member inline directionXsColumn(value: string) : IGridClasses = unbox ("direction-xs-column", value)
    static member inline directionXsColumnReverse(value: string) : IGridClasses = unbox ("direction-xs-column-reverse", value)
    static member inline directionXsRowReverse(value: string) : IGridClasses = unbox ("direction-xs-row-reverse", value)
    static member inline wrapXsNowrap(value: string) : IGridClasses = unbox ("wrap-xs-nowrap", value)
    static member inline wrapXsWrapReverse(value: string) : IGridClasses = unbox ("wrap-xs-wrap-reverse", value)
    static member inline alignItemsXsCenter(value: string) : IGridClasses = unbox ("align-items-xs-center", value)
    static member inline alignItemsXsFlexStart(value: string) : IGridClasses = unbox ("align-items-xs-flex-start", value)
    static member inline alignItemsXsFlexEnd(value: string) : IGridClasses = unbox ("align-items-xs-flex-end", value)
    static member inline alignItemsXsBaseline(value: string) : IGridClasses = unbox ("align-items-xs-baseline", value)
    static member inline alignContentXsCenter(value: string) : IGridClasses = unbox ("align-content-xs-center", value)
    static member inline alignContentXsFlexStart(value: string) : IGridClasses = unbox ("align-content-xs-flex-start", value)
    static member inline alignContentXsFlexEnd(value: string) : IGridClasses = unbox ("align-content-xs-flex-end", value)
    static member inline alignContentXsSpaceBetween(value: string) : IGridClasses = unbox ("align-content-xs-space-between", value)
    static member inline alignContentXsSpaceAround(value: string) : IGridClasses = unbox ("align-content-xs-space-around", value)
    static member inline justifyXsCenter(value: string) : IGridClasses = unbox ("justify-xs-center", value)
    static member inline justifyXsFlexEnd(value: string) : IGridClasses = unbox ("justify-xs-flex-end", value)
    static member inline justifyXsSpaceBetween(value: string) : IGridClasses = unbox ("justify-xs-space-between", value)
    static member inline justifyXsSpaceAround(value: string) : IGridClasses = unbox ("justify-xs-space-around", value)
    static member inline justifyXsSpaceEvenly(value: string) : IGridClasses = unbox ("justify-xs-space-evenly", value)
    static member inline spacingXs1(value: string) : IGridClasses = unbox ("spacing-xs-1", value)
    static member inline spacingXs2(value: string) : IGridClasses = unbox ("spacing-xs-2", value)
    static member inline spacingXs3(value: string) : IGridClasses = unbox ("spacing-xs-3", value)
    static member inline spacingXs4(value: string) : IGridClasses = unbox ("spacing-xs-4", value)
    static member inline spacingXs5(value: string) : IGridClasses = unbox ("spacing-xs-5", value)
    static member inline spacingXs6(value: string) : IGridClasses = unbox ("spacing-xs-6", value)
    static member inline spacingXs7(value: string) : IGridClasses = unbox ("spacing-xs-7", value)
    static member inline spacingXs8(value: string) : IGridClasses = unbox ("spacing-xs-8", value)
    static member inline spacingXs9(value: string) : IGridClasses = unbox ("spacing-xs-9", value)
    static member inline spacingXs10(value: string) : IGridClasses = unbox ("spacing-xs-10", value)
    static member inline gridXsAuto(value: string) : IGridClasses = unbox ("grid-xs-auto", value)
    static member inline gridXsTrue(value: string) : IGridClasses = unbox ("grid-xs-true", value)
    static member inline gridXs1(value: string) : IGridClasses = unbox ("grid-xs-1", value)
    static member inline gridXs2(value: string) : IGridClasses = unbox ("grid-xs-2", value)
    static member inline gridXs3(value: string) : IGridClasses = unbox ("grid-xs-3", value)
    static member inline gridXs4(value: string) : IGridClasses = unbox ("grid-xs-4", value)
    static member inline gridXs5(value: string) : IGridClasses = unbox ("grid-xs-5", value)
    static member inline gridXs6(value: string) : IGridClasses = unbox ("grid-xs-6", value)
    static member inline gridXs7(value: string) : IGridClasses = unbox ("grid-xs-7", value)
    static member inline gridXs8(value: string) : IGridClasses = unbox ("grid-xs-8", value)
    static member inline gridXs9(value: string) : IGridClasses = unbox ("grid-xs-9", value)
    static member inline gridXs10(value: string) : IGridClasses = unbox ("grid-xs-10", value)
    static member inline gridXs11(value: string) : IGridClasses = unbox ("grid-xs-11", value)
    static member inline gridXs12(value: string) : IGridClasses = unbox ("grid-xs-12", value)


  type IGridListClasses = interface end

  [<Erase>]
  type gridList =
    /// Styles applied to the root element.
    static member inline root(value: string) : IGridListClasses = unbox ("root", value)


  type IGridListTileClasses = interface end

  [<Erase>]
  type gridListTile =
    /// Styles applied to the root element.
    static member inline root(value: string) : IGridListTileClasses = unbox ("root", value)
    /// Styles applied to the `div` element that wraps the children.
    static member inline tile(value: string) : IGridListTileClasses = unbox ("tile", value)
    /// Styles applied to an `img` element child, if needed to ensure it covers the tile.
    static member inline imgFullHeight(value: string) : IGridListTileClasses = unbox ("imgFullHeight", value)
    /// Styles applied to an `img` element child, if needed to ensure it covers the tile.
    static member inline imgFullWidth(value: string) : IGridListTileClasses = unbox ("imgFullWidth", value)


  type IGridListTileBarClasses = interface end

  [<Erase>]
  type gridListTileBar =
    /// Styles applied to the root element.
    static member inline root(value: string) : IGridListTileBarClasses = unbox ("root", value)
    /// Styles applied to the root element if `titlePosition="bottom"`.
    static member inline titlePositionBottom(value: string) : IGridListTileBarClasses = unbox ("titlePositionBottom", value)
    /// Styles applied to the root element if `titlePosition="top"`.
    static member inline titlePositionTop(value: string) : IGridListTileBarClasses = unbox ("titlePositionTop", value)
    /// Styles applied to the root element if a `subtitle` is provided.
    static member inline rootSubtitle(value: string) : IGridListTileBarClasses = unbox ("rootSubtitle", value)
    /// Styles applied to the title and subtitle container element.
    static member inline titleWrap(value: string) : IGridListTileBarClasses = unbox ("titleWrap", value)
    /// Styles applied to the container element if `actionPosition="left"`.
    static member inline titleWrapActionPosLeft(value: string) : IGridListTileBarClasses = unbox ("titleWrapActionPosLeft", value)
    /// Styles applied to the container element if `actionPosition="right"`.
    static member inline titleWrapActionPosRight(value: string) : IGridListTileBarClasses = unbox ("titleWrapActionPosRight", value)
    /// Styles applied to the title container element.
    static member inline title(value: string) : IGridListTileBarClasses = unbox ("title", value)
    /// Styles applied to the subtitle container element.
    static member inline subtitle(value: string) : IGridListTileBarClasses = unbox ("subtitle", value)
    /// Styles applied to the actionIcon if supplied.
    static member inline actionIcon(value: string) : IGridListTileBarClasses = unbox ("actionIcon", value)
    /// Styles applied to the actionIcon if `actionPosition="left"`.
    static member inline actionIconActionPosLeft(value: string) : IGridListTileBarClasses = unbox ("actionIconActionPosLeft", value)


  type IGrowClasses = interface end


  type IHiddenClasses = interface end


  type IIconClasses = interface end

  [<Erase>]
  type icon =
    /// Styles applied to the root element.
    static member inline root(value: string) : IIconClasses = unbox ("root", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) : IIconClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) : IIconClasses = unbox ("colorSecondary", value)
    /// Styles applied to the root element if `color="action"`.
    static member inline colorAction(value: string) : IIconClasses = unbox ("colorAction", value)
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: string) : IIconClasses = unbox ("colorError", value)
    /// Styles applied to the root element if `color="disabled"`.
    static member inline colorDisabled(value: string) : IIconClasses = unbox ("colorDisabled", value)
    static member inline fontSizeInherit(value: string) : IIconClasses = unbox ("fontSizeInherit", value)
    /// Styles applied to the root element if `fontSize="small"`.
    static member inline fontSizeSmall(value: string) : IIconClasses = unbox ("fontSizeSmall", value)
    /// Styles applied to the root element if `fontSize="large"`.
    static member inline fontSizeLarge(value: string) : IIconClasses = unbox ("fontSizeLarge", value)


  type IIconButtonClasses = interface end

  [<Erase>]
  type iconButton =
    /// Styles applied to the root element.
    static member inline root(value: string) : IIconButtonClasses = unbox ("root", value)
    /// Styles applied to the root element if `edge="start"`.
    static member inline edgeStart(value: string) : IIconButtonClasses = unbox ("edgeStart", value)
    /// Styles applied to the root element if `edge="end"`.
    static member inline edgeEnd(value: string) : IIconButtonClasses = unbox ("edgeEnd", value)
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: string) : IIconButtonClasses = unbox ("colorInherit", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) : IIconButtonClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) : IIconButtonClasses = unbox ("colorSecondary", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IIconButtonClasses = unbox ("disabled", value)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) : IIconButtonClasses = unbox ("sizeSmall", value)
    /// Styles applied to the children container element.
    static member inline label(value: string) : IIconButtonClasses = unbox ("label", value)


  type IInputClasses = interface end

  [<Erase>]
  type input =
    /// Styles applied to the root element.
    static member inline root(value: string) : IInputClasses = unbox ("root", value)
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(value: string) : IInputClasses = unbox ("formControl", value)
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: string) : IInputClasses = unbox ("focused", value)
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IInputClasses = unbox ("disabled", value)
    /// Styles applied to the root element if `disableUnderline={false}`.
    static member inline underline(value: string) : IInputClasses = unbox ("underline", value)
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: string) : IInputClasses = unbox ("error", value)
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: string) : IInputClasses = unbox ("multiline", value)
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: string) : IInputClasses = unbox ("fullWidth", value)
    /// Styles applied to the `input` element.
    static member inline input(value: string) : IInputClasses = unbox ("input", value)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: string) : IInputClasses = unbox ("inputMarginDense", value)
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: string) : IInputClasses = unbox ("inputMultiline", value)
    /// Styles applied to the `input` element if `type="search"`.
    static member inline inputTypeSearch(value: string) : IInputClasses = unbox ("inputTypeSearch", value)


  type IInputAdornmentClasses = interface end

  [<Erase>]
  type inputAdornment =
    /// Styles applied to the root element.
    static member inline root(value: string) : IInputAdornmentClasses = unbox ("root", value)
    /// Styles applied to the root element if `variant="filled"`.
    static member inline filled(value: string) : IInputAdornmentClasses = unbox ("filled", value)
    /// Styles applied to the root element if `position="start"`.
    static member inline positionStart(value: string) : IInputAdornmentClasses = unbox ("positionStart", value)
    /// Styles applied to the root element if `position="end"`.
    static member inline positionEnd(value: string) : IInputAdornmentClasses = unbox ("positionEnd", value)
    /// Styles applied to the root element if `disablePointerEvents=true`.
    static member inline disablePointerEvents(value: string) : IInputAdornmentClasses = unbox ("disablePointerEvents", value)
    /// Styles applied if the adornment is used inside <formcontrol hiddenlabel=""></formcontrol>.
    static member inline hiddenLabel(value: string) : IInputAdornmentClasses = unbox ("hiddenLabel", value)
    /// Styles applied if the adornment is used inside <formcontrol margin="dense"></formcontrol>.
    static member inline marginDense(value: string) : IInputAdornmentClasses = unbox ("marginDense", value)


  type IInputBaseClasses = interface end

  [<Erase>]
  type inputBase =
    /// Styles applied to the root element.
    static member inline root(value: string) : IInputBaseClasses = unbox ("root", value)
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(value: string) : IInputBaseClasses = unbox ("formControl", value)
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: string) : IInputBaseClasses = unbox ("focused", value)
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IInputBaseClasses = unbox ("disabled", value)
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(value: string) : IInputBaseClasses = unbox ("adornedStart", value)
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(value: string) : IInputBaseClasses = unbox ("adornedEnd", value)
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: string) : IInputBaseClasses = unbox ("error", value)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(value: string) : IInputBaseClasses = unbox ("marginDense", value)
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: string) : IInputBaseClasses = unbox ("multiline", value)
    /// Styles applied to the root element if `fullWidth={true}`.
    static member inline fullWidth(value: string) : IInputBaseClasses = unbox ("fullWidth", value)
    /// Styles applied to the `input` element.
    static member inline input(value: string) : IInputBaseClasses = unbox ("input", value)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: string) : IInputBaseClasses = unbox ("inputMarginDense", value)
    /// Styles applied to the `input` element if `select={true}`.
    static member inline inputSelect(value: string) : IInputBaseClasses = unbox ("inputSelect", value)
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: string) : IInputBaseClasses = unbox ("inputMultiline", value)
    /// Styles applied to the `input` element if `type="search"`.
    static member inline inputTypeSearch(value: string) : IInputBaseClasses = unbox ("inputTypeSearch", value)
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(value: string) : IInputBaseClasses = unbox ("inputAdornedStart", value)
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(value: string) : IInputBaseClasses = unbox ("inputAdornedEnd", value)
    /// Styles applied to the `input` element if `hiddenLabel={true}`.
    static member inline inputHiddenLabel(value: string) : IInputBaseClasses = unbox ("inputHiddenLabel", value)


  type IInputLabelClasses = interface end

  [<Erase>]
  type inputLabel =
    /// Styles applied to the root element.
    static member inline root(value: string) : IInputLabelClasses = unbox ("root", value)
    /// Pseudo-class applied to the root element if `focused={true}`.
    static member inline focused(value: string) : IInputLabelClasses = unbox ("focused", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IInputLabelClasses = unbox ("disabled", value)
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: string) : IInputLabelClasses = unbox ("error", value)
    /// Pseudo-class applied to the root element if `required={true}`.
    static member inline required(value: string) : IInputLabelClasses = unbox ("required", value)
    /// Pseudo-class applied to the asterisk element.
    static member inline asterisk(value: string) : IInputLabelClasses = unbox ("asterisk", value)
    /// Styles applied to the root element if the component is a descendant of `FormControl`.
    static member inline formControl(value: string) : IInputLabelClasses = unbox ("formControl", value)
    /// Styles applied to the root element if `margin="dense"`.
    static member inline marginDense(value: string) : IInputLabelClasses = unbox ("marginDense", value)
    /// Styles applied to the `input` element if `shrink={true}`.
    static member inline shrink(value: string) : IInputLabelClasses = unbox ("shrink", value)
    /// Styles applied to the `input` element if `disableAnimation={false}`.
    static member inline animated(value: string) : IInputLabelClasses = unbox ("animated", value)
    /// Styles applied to the root element if `variant="filled"`.
    static member inline filled(value: string) : IInputLabelClasses = unbox ("filled", value)
    /// Styles applied to the root element if `variant="outlined"`.
    static member inline outlined(value: string) : IInputLabelClasses = unbox ("outlined", value)


  type ILinearProgressClasses = interface end

  [<Erase>]
  type linearProgress =
    /// Styles applied to the root element.
    static member inline root(value: string) : ILinearProgressClasses = unbox ("root", value)
    /// Styles applied to the root & bar2 element if `color="primary"`; bar2 if `variant-"buffer"`.
    static member inline colorPrimary(value: string) : ILinearProgressClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root & bar2 elements if `color="secondary"`; bar2 if `variant="buffer"`.
    static member inline colorSecondary(value: string) : ILinearProgressClasses = unbox ("colorSecondary", value)
    /// Styles applied to the root element if `variant="determinate"`.
    static member inline determinate(value: string) : ILinearProgressClasses = unbox ("determinate", value)
    /// Styles applied to the root element if `variant="indeterminate"`.
    static member inline indeterminate(value: string) : ILinearProgressClasses = unbox ("indeterminate", value)
    /// Styles applied to the root element if `variant="buffer"`.
    static member inline buffer(value: string) : ILinearProgressClasses = unbox ("buffer", value)
    /// Styles applied to the root element if `variant="query"`.
    static member inline query(value: string) : ILinearProgressClasses = unbox ("query", value)
    /// Styles applied to the additional bar element if `variant="buffer"`.
    static member inline dashed(value: string) : ILinearProgressClasses = unbox ("dashed", value)
    /// Styles applied to the additional bar element if `variant="buffer"`&`color="primary"`.
    static member inline dashedColorPrimary(value: string) : ILinearProgressClasses = unbox ("dashedColorPrimary", value)
    /// Styles applied to the additional bar element if `variant="buffer"`&`color="secondary"`.
    static member inline dashedColorSecondary(value: string) : ILinearProgressClasses = unbox ("dashedColorSecondary", value)
    /// Styles applied to the layered bar1 & bar2 elements.
    static member inline bar(value: string) : ILinearProgressClasses = unbox ("bar", value)
    /// Styles applied to the bar elements if `color="primary"`; bar2 if `variant` not "buffer".
    static member inline barColorPrimary(value: string) : ILinearProgressClasses = unbox ("barColorPrimary", value)
    /// Styles applied to the bar elements if `color="secondary"`; bar2 if `variant` not "buffer".
    static member inline barColorSecondary(value: string) : ILinearProgressClasses = unbox ("barColorSecondary", value)
    /// Styles applied to the bar1 element if `variant="indeterminate or query"`.
    static member inline bar1Indeterminate(value: string) : ILinearProgressClasses = unbox ("bar1Indeterminate", value)
    /// Styles applied to the bar1 element if `variant="determinate"`.
    static member inline bar1Determinate(value: string) : ILinearProgressClasses = unbox ("bar1Determinate", value)
    /// Styles applied to the bar1 element if `variant="buffer"`.
    static member inline bar1Buffer(value: string) : ILinearProgressClasses = unbox ("bar1Buffer", value)
    /// Styles applied to the bar2 element if `variant="indeterminate or query"`.
    static member inline bar2Indeterminate(value: string) : ILinearProgressClasses = unbox ("bar2Indeterminate", value)
    /// Styles applied to the bar2 element if `variant="buffer"`.
    static member inline bar2Buffer(value: string) : ILinearProgressClasses = unbox ("bar2Buffer", value)


  type ILinkClasses = interface end

  [<Erase>]
  type link =
    /// Styles applied to the root element.
    static member inline root(value: string) : ILinkClasses = unbox ("root", value)
    /// Styles applied to the root element if `underline="none"`.
    static member inline underlineNone(value: string) : ILinkClasses = unbox ("underlineNone", value)
    /// Styles applied to the root element if `underline="hover"`.
    static member inline underlineHover(value: string) : ILinkClasses = unbox ("underlineHover", value)
    /// Styles applied to the root element if `underline="always"`.
    static member inline underlineAlways(value: string) : ILinkClasses = unbox ("underlineAlways", value)
    /// Styles applied to the root element if `component="button"`.
    static member inline button(value: string) : ILinkClasses = unbox ("button", value)
    /// Pseudo-class applied to the root element if the link is keyboard focused.
    static member inline focusVisible(value: string) : ILinkClasses = unbox ("focusVisible", value)


  type IListClasses = interface end

  [<Erase>]
  type list =
    /// Styles applied to the root element.
    static member inline root(value: string) : IListClasses = unbox ("root", value)
    /// Styles applied to the root element if `disablePadding={false}`.
    static member inline padding(value: string) : IListClasses = unbox ("padding", value)
    /// Styles applied to the root element if dense.
    static member inline dense(value: string) : IListClasses = unbox ("dense", value)
    /// Styles applied to the root element if a `subheader` is provided.
    static member inline subheader(value: string) : IListClasses = unbox ("subheader", value)


  type IListItemClasses = interface end

  [<Erase>]
  type listItem =
    /// Styles applied to the (normally root) `component` element. May be wrapped by a `container`.
    static member inline root(value: string) : IListItemClasses = unbox ("root", value)
    /// Styles applied to the `container` element if `children` includes `ListItemSecondaryAction`.
    static member inline container(value: string) : IListItemClasses = unbox ("container", value)
    /// Pseudo-class applied to the `component`'s `focusVisibleClassName` prop if `button={true}`.
    static member inline focusVisible(value: string) : IListItemClasses = unbox ("focusVisible", value)
    /// Styles applied to the `component` element if dense.
    static member inline dense(value: string) : IListItemClasses = unbox ("dense", value)
    /// Styles applied to the `component` element if `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(value: string) : IListItemClasses = unbox ("alignItemsFlexStart", value)
    /// Pseudo-class applied to the inner `component` element if `disabled={true}`.
    static member inline disabled(value: string) : IListItemClasses = unbox ("disabled", value)
    /// Styles applied to the inner `component` element if `divider={true}`.
    static member inline divider(value: string) : IListItemClasses = unbox ("divider", value)
    /// Styles applied to the inner `component` element if `disableGutters={false}`.
    static member inline gutters(value: string) : IListItemClasses = unbox ("gutters", value)
    /// Styles applied to the inner `component` element if `button={true}`.
    static member inline button(value: string) : IListItemClasses = unbox ("button", value)
    /// Styles applied to the `component` element if `children` includes `ListItemSecondaryAction`.
    static member inline secondaryAction(value: string) : IListItemClasses = unbox ("secondaryAction", value)
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(value: string) : IListItemClasses = unbox ("selected", value)


  type IListItemAvatarClasses = interface end

  [<Erase>]
  type listItemAvatar =
    /// Styles applied to the root element.
    static member inline root(value: string) : IListItemAvatarClasses = unbox ("root", value)
    /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(value: string) : IListItemAvatarClasses = unbox ("alignItemsFlexStart", value)


  type IListItemIconClasses = interface end

  [<Erase>]
  type listItemIcon =
    /// Styles applied to the root element.
    static member inline root(value: string) : IListItemIconClasses = unbox ("root", value)
    /// Styles applied to the root element when the parent `ListItem` uses `alignItems="flex-start"`.
    static member inline alignItemsFlexStart(value: string) : IListItemIconClasses = unbox ("alignItemsFlexStart", value)


  type IListItemSecondaryActionClasses = interface end

  [<Erase>]
  type listItemSecondaryAction =
    /// Styles applied to the root element.
    static member inline root(value: string) : IListItemSecondaryActionClasses = unbox ("root", value)


  type IListItemTextClasses = interface end

  [<Erase>]
  type listItemText =
    /// Styles applied to the root element.
    static member inline root(value: string) : IListItemTextClasses = unbox ("root", value)
    /// Styles applied to the `Typography` components if primary and secondary are set.
    static member inline multiline(value: string) : IListItemTextClasses = unbox ("multiline", value)
    /// Styles applied to the `Typography` components if dense.
    static member inline dense(value: string) : IListItemTextClasses = unbox ("dense", value)
    /// Styles applied to the root element if `inset={true}`.
    static member inline inset(value: string) : IListItemTextClasses = unbox ("inset", value)
    /// Styles applied to the primary `Typography` component.
    static member inline primary(value: string) : IListItemTextClasses = unbox ("primary", value)
    /// Styles applied to the secondary `Typography` component.
    static member inline secondary(value: string) : IListItemTextClasses = unbox ("secondary", value)


  type IListSubheaderClasses = interface end

  [<Erase>]
  type listSubheader =
    /// Styles applied to the root element.
    static member inline root(value: string) : IListSubheaderClasses = unbox ("root", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) : IListSubheaderClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: string) : IListSubheaderClasses = unbox ("colorInherit", value)
    /// Styles applied to the inner `component` element if `disableGutters={false}`.
    static member inline gutters(value: string) : IListSubheaderClasses = unbox ("gutters", value)
    /// Styles applied to the root element if `inset={true}`.
    static member inline inset(value: string) : IListSubheaderClasses = unbox ("inset", value)
    /// Styles applied to the root element if `disableSticky={false}`.
    static member inline sticky(value: string) : IListSubheaderClasses = unbox ("sticky", value)


  type IMenuClasses = interface end

  [<Erase>]
  type menu =
    /// Styles applied to the `Paper` component.
    static member inline paper(value: string) : IMenuClasses = unbox ("paper", value)
    /// Styles applied to the `List` component via `MenuList`.
    static member inline list(value: string) : IMenuClasses = unbox ("list", value)


  type IMenuItemClasses = interface end

  [<Erase>]
  type menuItem =
    /// Styles applied to the root element.
    static member inline root(value: string) : IMenuItemClasses = unbox ("root", value)
    /// Styles applied to the root element if `disableGutters={false}`.
    static member inline gutters(value: string) : IMenuItemClasses = unbox ("gutters", value)
    /// Styles applied to the root element if `selected={true}`.
    static member inline selected(value: string) : IMenuItemClasses = unbox ("selected", value)
    /// Styles applied to the root element if dense.
    static member inline dense(value: string) : IMenuItemClasses = unbox ("dense", value)


  type IMenuListClasses = interface end


  type IMobileStepperClasses = interface end

  [<Erase>]
  type mobileStepper =
    /// Styles applied to the root element.
    static member inline root(value: string) : IMobileStepperClasses = unbox ("root", value)
    /// Styles applied to the root element if `position="bottom"`.
    static member inline positionBottom(value: string) : IMobileStepperClasses = unbox ("positionBottom", value)
    /// Styles applied to the root element if `position="top"`.
    static member inline positionTop(value: string) : IMobileStepperClasses = unbox ("positionTop", value)
    /// Styles applied to the root element if `position="static"`.
    static member inline positionStatic(value: string) : IMobileStepperClasses = unbox ("positionStatic", value)
    /// Styles applied to the dots container if `variant="dots"`.
    static member inline dots(value: string) : IMobileStepperClasses = unbox ("dots", value)
    /// Styles applied to each dot if `variant="dots"`.
    static member inline dot(value: string) : IMobileStepperClasses = unbox ("dot", value)
    /// Styles applied to a dot if `variant="dots"` and this is the active step.
    static member inline dotActive(value: string) : IMobileStepperClasses = unbox ("dotActive", value)
    /// Styles applied to the Linear Progress component if `variant="progress"`.
    static member inline progress(value: string) : IMobileStepperClasses = unbox ("progress", value)


  type IModalClasses = interface end


  type INativeSelectClasses = interface end

  [<Erase>]
  type nativeSelect =
    /// Styles applied to the select component `root` class.
    static member inline root(value: string) : INativeSelectClasses = unbox ("root", value)
    /// Styles applied to the select component `select` class.
    static member inline select(value: string) : INativeSelectClasses = unbox ("select", value)
    /// Styles applied to the select component if `variant="filled"`.
    static member inline filled(value: string) : INativeSelectClasses = unbox ("filled", value)
    /// Styles applied to the select component if `variant="outlined"`.
    static member inline outlined(value: string) : INativeSelectClasses = unbox ("outlined", value)
    /// Styles applied to the select component `selectMenu` class.
    static member inline selectMenu(value: string) : INativeSelectClasses = unbox ("selectMenu", value)
    /// Pseudo-class applied to the select component `disabled` class.
    static member inline disabled(value: string) : INativeSelectClasses = unbox ("disabled", value)
    /// Styles applied to the select component `icon` class.
    static member inline icon(value: string) : INativeSelectClasses = unbox ("icon", value)


  type INoSsrClasses = interface end


  type IOutlinedInputClasses = interface end

  [<Erase>]
  type outlinedInput =
    /// Styles applied to the root element.
    static member inline root(value: string) : IOutlinedInputClasses = unbox ("root", value)
    /// Styles applied to the root element if the component is focused.
    static member inline focused(value: string) : IOutlinedInputClasses = unbox ("focused", value)
    /// Styles applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IOutlinedInputClasses = unbox ("disabled", value)
    /// Styles applied to the root element if `startAdornment` is provided.
    static member inline adornedStart(value: string) : IOutlinedInputClasses = unbox ("adornedStart", value)
    /// Styles applied to the root element if `endAdornment` is provided.
    static member inline adornedEnd(value: string) : IOutlinedInputClasses = unbox ("adornedEnd", value)
    /// Styles applied to the root element if `error={true}`.
    static member inline error(value: string) : IOutlinedInputClasses = unbox ("error", value)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline marginDense(value: string) : IOutlinedInputClasses = unbox ("marginDense", value)
    /// Styles applied to the root element if `multiline={true}`.
    static member inline multiline(value: string) : IOutlinedInputClasses = unbox ("multiline", value)
    /// Styles applied to the `NotchedOutline` element.
    static member inline notchedOutline(value: string) : IOutlinedInputClasses = unbox ("notchedOutline", value)
    /// Styles applied to the `input` element.
    static member inline input(value: string) : IOutlinedInputClasses = unbox ("input", value)
    /// Styles applied to the `input` element if `margin="dense"`.
    static member inline inputMarginDense(value: string) : IOutlinedInputClasses = unbox ("inputMarginDense", value)
    /// Styles applied to the `input` element if `select={true}`.
    static member inline inputSelect(value: string) : IOutlinedInputClasses = unbox ("inputSelect", value)
    /// Styles applied to the `input` element if `multiline={true}`.
    static member inline inputMultiline(value: string) : IOutlinedInputClasses = unbox ("inputMultiline", value)
    /// Styles applied to the `input` element if `startAdornment` is provided.
    static member inline inputAdornedStart(value: string) : IOutlinedInputClasses = unbox ("inputAdornedStart", value)
    /// Styles applied to the `input` element if `endAdornment` is provided.
    static member inline inputAdornedEnd(value: string) : IOutlinedInputClasses = unbox ("inputAdornedEnd", value)


  type IPaperClasses = interface end

  [<Erase>]
  type paper =
    /// Styles applied to the root element.
    static member inline root(value: string) : IPaperClasses = unbox ("root", value)
    /// Styles applied to the root element if `square={false}`.
    static member inline rounded(value: string) : IPaperClasses = unbox ("rounded", value)
    static member inline elevation0(value: string) : IPaperClasses = unbox ("elevation0", value)
    static member inline elevation1(value: string) : IPaperClasses = unbox ("elevation1", value)
    static member inline elevation2(value: string) : IPaperClasses = unbox ("elevation2", value)
    static member inline elevation3(value: string) : IPaperClasses = unbox ("elevation3", value)
    static member inline elevation4(value: string) : IPaperClasses = unbox ("elevation4", value)
    static member inline elevation5(value: string) : IPaperClasses = unbox ("elevation5", value)
    static member inline elevation6(value: string) : IPaperClasses = unbox ("elevation6", value)
    static member inline elevation7(value: string) : IPaperClasses = unbox ("elevation7", value)
    static member inline elevation8(value: string) : IPaperClasses = unbox ("elevation8", value)
    static member inline elevation9(value: string) : IPaperClasses = unbox ("elevation9", value)
    static member inline elevation10(value: string) : IPaperClasses = unbox ("elevation10", value)
    static member inline elevation11(value: string) : IPaperClasses = unbox ("elevation11", value)
    static member inline elevation12(value: string) : IPaperClasses = unbox ("elevation12", value)
    static member inline elevation13(value: string) : IPaperClasses = unbox ("elevation13", value)
    static member inline elevation14(value: string) : IPaperClasses = unbox ("elevation14", value)
    static member inline elevation15(value: string) : IPaperClasses = unbox ("elevation15", value)
    static member inline elevation16(value: string) : IPaperClasses = unbox ("elevation16", value)
    static member inline elevation17(value: string) : IPaperClasses = unbox ("elevation17", value)
    static member inline elevation18(value: string) : IPaperClasses = unbox ("elevation18", value)
    static member inline elevation19(value: string) : IPaperClasses = unbox ("elevation19", value)
    static member inline elevation20(value: string) : IPaperClasses = unbox ("elevation20", value)
    static member inline elevation21(value: string) : IPaperClasses = unbox ("elevation21", value)
    static member inline elevation22(value: string) : IPaperClasses = unbox ("elevation22", value)
    static member inline elevation23(value: string) : IPaperClasses = unbox ("elevation23", value)
    static member inline elevation24(value: string) : IPaperClasses = unbox ("elevation24", value)


  type IPopoverClasses = interface end

  [<Erase>]
  type popover =
    /// Styles applied to the `Paper` component.
    static member inline paper(value: string) : IPopoverClasses = unbox ("paper", value)


  type IPopperClasses = interface end


  type IPortalClasses = interface end


  type IRadioClasses = interface end

  [<Erase>]
  type radio =
    /// Styles applied to the root element.
    static member inline root(value: string) : IRadioClasses = unbox ("root", value)
    /// Pseudo-class applied to the root element if `checked={true}`.
    static member inline checked'(value: string) : IRadioClasses = unbox ("checked", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IRadioClasses = unbox ("disabled", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) : IRadioClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) : IRadioClasses = unbox ("colorSecondary", value)


  type IRadioGroupClasses = interface end


  type IRatingClasses = interface end

  [<Erase>]
  type rating =
    /// Styles applied to the root element.
    static member inline root(value: string) : IRatingClasses = unbox ("root", value)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) : IRatingClasses = unbox ("sizeSmall", value)
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(value: string) : IRatingClasses = unbox ("sizeLarge", value)
    /// Styles applied to the root element if `readOnly={true}`.
    static member inline readOnly(value: string) : IRatingClasses = unbox ("readOnly", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IRatingClasses = unbox ("disabled", value)
    /// Pseudo-class applied to the root element if keyboard focused.
    static member inline focusVisible(value: string) : IRatingClasses = unbox ("focusVisible", value)
    /// Visually hide an element.
    static member inline visuallyhidden(value: string) : IRatingClasses = unbox ("visuallyhidden", value)
    /// Styles applied to the pristine label.
    static member inline pristine(value: string) : IRatingClasses = unbox ("pristine", value)
    /// Styles applied to the label elements.
    static member inline label(value: string) : IRatingClasses = unbox ("label", value)
    /// Styles applied to the icon wrapping elements.
    static member inline icon(value: string) : IRatingClasses = unbox ("icon", value)
    /// Styles applied to the icon wrapping elements when empty.
    static member inline iconEmpty(value: string) : IRatingClasses = unbox ("iconEmpty", value)
    /// Styles applied to the icon wrapping elements when filled.
    static member inline iconFilled(value: string) : IRatingClasses = unbox ("iconFilled", value)
    /// Styles applied to the icon wrapping elements when hover.
    static member inline iconHover(value: string) : IRatingClasses = unbox ("iconHover", value)
    /// Styles applied to the icon wrapping elements when focus.
    static member inline iconFocus(value: string) : IRatingClasses = unbox ("iconFocus", value)
    /// Styles applied to the icon wrapping elements when active.
    static member inline iconActive(value: string) : IRatingClasses = unbox ("iconActive", value)
    /// Styles applied to the icon wrapping elements when decimals are necessary.
    static member inline decimal(value: string) : IRatingClasses = unbox ("decimal", value)


  type IRootRefClasses = interface end


  type ISelectClasses = interface end

  [<Erase>]
  type select =
    /// Styles applied to the select component `root` class.
    static member inline root(value: string) : ISelectClasses = unbox ("root", value)
    /// Styles applied to the select component `select` class.
    static member inline select(value: string) : ISelectClasses = unbox ("select", value)
    /// Styles applied to the select component if `variant="filled"`.
    static member inline filled(value: string) : ISelectClasses = unbox ("filled", value)
    /// Styles applied to the select component if `variant="outlined"`.
    static member inline outlined(value: string) : ISelectClasses = unbox ("outlined", value)
    /// Styles applied to the select component `selectMenu` class.
    static member inline selectMenu(value: string) : ISelectClasses = unbox ("selectMenu", value)
    /// Pseudo-class applied to the select component `disabled` class.
    static member inline disabled(value: string) : ISelectClasses = unbox ("disabled", value)
    /// Styles applied to the select component `icon` class.
    static member inline icon(value: string) : ISelectClasses = unbox ("icon", value)


  type ISkeletonClasses = interface end

  [<Erase>]
  type skeleton =
    /// Styles applied to the root element.
    static member inline root(value: string) : ISkeletonClasses = unbox ("root", value)
    /// Styles applied to the root element if `variant="text"`.
    static member inline text(value: string) : ISkeletonClasses = unbox ("text", value)
    /// Styles applied to the root element if `variant="rect"`.
    static member inline rect(value: string) : ISkeletonClasses = unbox ("rect", value)
    /// Styles applied to the root element if `variant="circle"`.
    static member inline circle(value: string) : ISkeletonClasses = unbox ("circle", value)
    /// Styles applied to the root element if `disabledAnimate={false}`.
    static member inline animate(value: string) : ISkeletonClasses = unbox ("animate", value)


  type ISlideClasses = interface end


  type ISliderClasses = interface end

  [<Erase>]
  type slider =
    /// Styles applied to the root element.
    static member inline root(value: string) : ISliderClasses = unbox ("root", value)
    /// Styles applied to the root element if `marks` is provided with at least one label.
    static member inline marked(value: string) : ISliderClasses = unbox ("marked", value)
    /// Pseudo-class applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) : ISliderClasses = unbox ("vertical", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : ISliderClasses = unbox ("disabled", value)
    /// Styles applied to the rail element.
    static member inline rail(value: string) : ISliderClasses = unbox ("rail", value)
    /// Styles applied to the track element.
    static member inline track(value: string) : ISliderClasses = unbox ("track", value)
    /// Styles applied to the thumb element.
    static member inline thumb(value: string) : ISliderClasses = unbox ("thumb", value)
    /// Pseudo-class applied to the thumb element if it's active.
    static member inline active(value: string) : ISliderClasses = unbox ("active", value)
    /// Pseudo-class applied to the thumb element if keyboard focused.
    static member inline focusVisible(value: string) : ISliderClasses = unbox ("focusVisible", value)
    /// Styles applied to the thumb label element.
    static member inline valueLabel(value: string) : ISliderClasses = unbox ("valueLabel", value)
    /// Styles applied to the mark element.
    static member inline mark(value: string) : ISliderClasses = unbox ("mark", value)
    /// Styles applied to the mark element if active (depending on the value).
    static member inline markActive(value: string) : ISliderClasses = unbox ("markActive", value)
    /// Styles applied to the mark label element.
    static member inline markLabel(value: string) : ISliderClasses = unbox ("markLabel", value)
    /// Styles applied to the mark label element if active (depending on the value).
    static member inline markLabelActive(value: string) : ISliderClasses = unbox ("markLabelActive", value)


  type ISnackbarClasses = interface end

  [<Erase>]
  type snackbar =
    /// Styles applied to the root element.
    static member inline root(value: string) : ISnackbarClasses = unbox ("root", value)
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'center' }}`.
    static member inline anchorOriginTopCenter(value: string) : ISnackbarClasses = unbox ("anchorOriginTopCenter", value)
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'center' }}`.
    static member inline anchorOriginBottomCenter(value: string) : ISnackbarClasses = unbox ("anchorOriginBottomCenter", value)
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'right' }}`.
    static member inline anchorOriginTopRight(value: string) : ISnackbarClasses = unbox ("anchorOriginTopRight", value)
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'right' }}`.
    static member inline anchorOriginBottomRight(value: string) : ISnackbarClasses = unbox ("anchorOriginBottomRight", value)
    /// Styles applied to the root element if `anchorOrigin={{ 'top', 'left' }}`.
    static member inline anchorOriginTopLeft(value: string) : ISnackbarClasses = unbox ("anchorOriginTopLeft", value)
    /// Styles applied to the root element if `anchorOrigin={{ 'bottom', 'left' }}`.
    static member inline anchorOriginBottomLeft(value: string) : ISnackbarClasses = unbox ("anchorOriginBottomLeft", value)


  type ISnackbarContentClasses = interface end

  [<Erase>]
  type snackbarContent =
    /// Styles applied to the root element.
    static member inline root(value: string) : ISnackbarContentClasses = unbox ("root", value)
    /// Styles applied to the message wrapper element.
    static member inline message(value: string) : ISnackbarContentClasses = unbox ("message", value)
    /// Styles applied to the action wrapper element if `action` is provided.
    static member inline action(value: string) : ISnackbarContentClasses = unbox ("action", value)


  type ISpeedDialClasses = interface end

  [<Erase>]
  type speedDial =
    /// Styles applied to the root element.
    static member inline root(value: string) : ISpeedDialClasses = unbox ("root", value)
    /// Styles applied to the Button component.
    static member inline fab(value: string) : ISpeedDialClasses = unbox ("fab", value)
    /// Styles applied to the root and action container elements when direction="up"
    static member inline directionUp(value: string) : ISpeedDialClasses = unbox ("directionUp", value)
    /// Styles applied to the root and action container elements when direction="down"
    static member inline directionDown(value: string) : ISpeedDialClasses = unbox ("directionDown", value)
    /// Styles applied to the root and action container elements when direction="left"
    static member inline directionLeft(value: string) : ISpeedDialClasses = unbox ("directionLeft", value)
    /// Styles applied to the root and action container elements when direction="right"
    static member inline directionRight(value: string) : ISpeedDialClasses = unbox ("directionRight", value)
    /// Styles applied to the actions (`children` wrapper) element.
    static member inline actions(value: string) : ISpeedDialClasses = unbox ("actions", value)
    /// Styles applied to the actions (`children` wrapper) element if `open={false}`.
    static member inline actionsClosed(value: string) : ISpeedDialClasses = unbox ("actionsClosed", value)


  type ISpeedDialActionClasses = interface end

  [<Erase>]
  type speedDialAction =
    /// Styles applied to the `Button` component.
    static member inline button(value: string) : ISpeedDialActionClasses = unbox ("button", value)
    /// Styles applied to the `Button` component if `open={false}`.
    static member inline buttonClosed(value: string) : ISpeedDialActionClasses = unbox ("buttonClosed", value)


  type ISpeedDialIconClasses = interface end

  [<Erase>]
  type speedDialIcon =
    /// Styles applied to the root element.
    static member inline root(value: string) : ISpeedDialIconClasses = unbox ("root", value)
    /// Styles applied to the icon component.
    static member inline icon(value: string) : ISpeedDialIconClasses = unbox ("icon", value)
    /// Styles applied to the icon component if `open={true}`.
    static member inline iconOpen(value: string) : ISpeedDialIconClasses = unbox ("iconOpen", value)
    /// Styles applied to the icon when and `openIcon` is provided & if `open={true}`.
    static member inline iconWithOpenIconOpen(value: string) : ISpeedDialIconClasses = unbox ("iconWithOpenIconOpen", value)
    /// Styles applied to the `openIcon` if provided.
    static member inline openIcon(value: string) : ISpeedDialIconClasses = unbox ("openIcon", value)
    /// Styles applied to the `openIcon` if provided & if `open={true}`.
    static member inline openIconOpen(value: string) : ISpeedDialIconClasses = unbox ("openIconOpen", value)


  type IStepClasses = interface end

  [<Erase>]
  type step =
    /// Styles applied to the root element.
    static member inline root(value: string) : IStepClasses = unbox ("root", value)
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: string) : IStepClasses = unbox ("horizontal", value)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) : IStepClasses = unbox ("vertical", value)
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: string) : IStepClasses = unbox ("alternativeLabel", value)
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(value: string) : IStepClasses = unbox ("completed", value)


  type IStepButtonClasses = interface end

  [<Erase>]
  type stepButton =
    /// Styles applied to the root element.
    static member inline root(value: string) : IStepButtonClasses = unbox ("root", value)
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: string) : IStepButtonClasses = unbox ("horizontal", value)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) : IStepButtonClasses = unbox ("vertical", value)
    /// Styles applied to the `ButtonBase` touch-ripple.
    static member inline touchRipple(value: string) : IStepButtonClasses = unbox ("touchRipple", value)


  type IStepConnectorClasses = interface end

  [<Erase>]
  type stepConnector =
    /// Styles applied to the root element.
    static member inline root(value: string) : IStepConnectorClasses = unbox ("root", value)
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: string) : IStepConnectorClasses = unbox ("horizontal", value)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) : IStepConnectorClasses = unbox ("vertical", value)
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: string) : IStepConnectorClasses = unbox ("alternativeLabel", value)
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(value: string) : IStepConnectorClasses = unbox ("active", value)
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(value: string) : IStepConnectorClasses = unbox ("completed", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IStepConnectorClasses = unbox ("disabled", value)
    /// Styles applied to the line element.
    static member inline line(value: string) : IStepConnectorClasses = unbox ("line", value)
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline lineHorizontal(value: string) : IStepConnectorClasses = unbox ("lineHorizontal", value)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline lineVertical(value: string) : IStepConnectorClasses = unbox ("lineVertical", value)


  type IStepContentClasses = interface end

  [<Erase>]
  type stepContent =
    /// Styles applied to the root element.
    static member inline root(value: string) : IStepContentClasses = unbox ("root", value)
    /// Styles applied to the root element if `last={true}` (controlled by `Step`).
    static member inline last(value: string) : IStepContentClasses = unbox ("last", value)
    /// Styles applied to the Transition component.
    static member inline transition(value: string) : IStepContentClasses = unbox ("transition", value)


  type IStepIconClasses = interface end

  [<Erase>]
  type stepIcon =
    /// Styles applied to the root element.
    static member inline root(value: string) : IStepIconClasses = unbox ("root", value)
    /// Styles applied to the SVG text element.
    static member inline text(value: string) : IStepIconClasses = unbox ("text", value)
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(value: string) : IStepIconClasses = unbox ("active", value)
    /// Pseudo-class applied to the root element if `completed={true}`.
    static member inline completed(value: string) : IStepIconClasses = unbox ("completed", value)
    /// Pseudo-class applied to the root element if `error={true}`.
    static member inline error(value: string) : IStepIconClasses = unbox ("error", value)


  type IStepLabelClasses = interface end

  [<Erase>]
  type stepLabel =
    /// Styles applied to the root element.
    static member inline root(value: string) : IStepLabelClasses = unbox ("root", value)
    /// Styles applied to the root element if `orientation="horizontal".
    static member inline horizontal(value: string) : IStepLabelClasses = unbox ("horizontal", value)
    /// Styles applied to the root element if `orientation="vertical".
    static member inline vertical(value: string) : IStepLabelClasses = unbox ("vertical", value)
    /// Styles applied to the `Typography` component which wraps `children`.
    static member inline label(value: string) : IStepLabelClasses = unbox ("label", value)
    /// Pseudo-class applied to the `Typography` component if `active={true}`.
    static member inline active(value: string) : IStepLabelClasses = unbox ("active", value)
    /// Pseudo-class applied to the `Typography` component if `completed={true}`.
    static member inline completed(value: string) : IStepLabelClasses = unbox ("completed", value)
    /// Pseudo-class applied to the root element and `Typography` component if `error={true}`.
    static member inline error(value: string) : IStepLabelClasses = unbox ("error", value)
    /// Pseudo-class applied to the root element and `Typography` component if `disabled={true}`.
    static member inline disabled(value: string) : IStepLabelClasses = unbox ("disabled", value)
    /// Styles applied to the `icon` container element.
    static member inline iconContainer(value: string) : IStepLabelClasses = unbox ("iconContainer", value)
    /// Pseudo-class applied to the root & icon container and `Typography` if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: string) : IStepLabelClasses = unbox ("alternativeLabel", value)
    /// Styles applied to the container element which wraps `Typography` and `optional`.
    static member inline labelContainer(value: string) : IStepLabelClasses = unbox ("labelContainer", value)


  type IStepperClasses = interface end

  [<Erase>]
  type stepper =
    /// Styles applied to the root element.
    static member inline root(value: string) : IStepperClasses = unbox ("root", value)
    /// Styles applied to the root element if `orientation="horizontal"`.
    static member inline horizontal(value: string) : IStepperClasses = unbox ("horizontal", value)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) : IStepperClasses = unbox ("vertical", value)
    /// Styles applied to the root element if `alternativeLabel={true}`.
    static member inline alternativeLabel(value: string) : IStepperClasses = unbox ("alternativeLabel", value)


  type ISvgIconClasses = interface end

  [<Erase>]
  type svgIcon =
    /// Styles applied to the root element.
    static member inline root(value: string) : ISvgIconClasses = unbox ("root", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) : ISvgIconClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) : ISvgIconClasses = unbox ("colorSecondary", value)
    /// Styles applied to the root element if `color="action"`.
    static member inline colorAction(value: string) : ISvgIconClasses = unbox ("colorAction", value)
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: string) : ISvgIconClasses = unbox ("colorError", value)
    /// Styles applied to the root element if `color="disabled"`.
    static member inline colorDisabled(value: string) : ISvgIconClasses = unbox ("colorDisabled", value)
    /// Styles applied to the root element if `fontSize="inherit"`.
    static member inline fontSizeInherit(value: string) : ISvgIconClasses = unbox ("fontSizeInherit", value)
    /// Styles applied to the root element if `fontSize="small"`.
    static member inline fontSizeSmall(value: string) : ISvgIconClasses = unbox ("fontSizeSmall", value)
    /// Styles applied to the root element if `fontSize="large"`.
    static member inline fontSizeLarge(value: string) : ISvgIconClasses = unbox ("fontSizeLarge", value)


  type ISwipeableDrawerClasses = interface end


  type ISwitchClasses = interface end

  [<Erase>]
  type switch =
    /// Styles applied to the root element.
    static member inline root(value: string) : ISwitchClasses = unbox ("root", value)
    /// Styles applied to the root element if `edge="start"`.
    static member inline edgeStart(value: string) : ISwitchClasses = unbox ("edgeStart", value)
    /// Styles applied to the root element if `edge="end"`.
    static member inline edgeEnd(value: string) : ISwitchClasses = unbox ("edgeEnd", value)
    /// Styles applied to the internal `SwitchBase` component's `root` class.
    static member inline switchBase(value: string) : ISwitchClasses = unbox ("switchBase", value)
    /// Styles applied to the internal SwitchBase component's root element if `color="primary"`.
    static member inline colorPrimary(value: string) : ISwitchClasses = unbox ("colorPrimary", value)
    /// Styles applied to the internal SwitchBase component's root element if `color="secondary"`.
    static member inline colorSecondary(value: string) : ISwitchClasses = unbox ("colorSecondary", value)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) : ISwitchClasses = unbox ("sizeSmall", value)
    /// Pseudo-class applied to the internal `SwitchBase` component's `checked` class.
    static member inline checked'(value: string) : ISwitchClasses = unbox ("checked", value)
    /// Pseudo-class applied to the internal SwitchBase component's disabled class.
    static member inline disabled(value: string) : ISwitchClasses = unbox ("disabled", value)
    /// Styles applied to the internal SwitchBase component's input element.
    static member inline input(value: string) : ISwitchClasses = unbox ("input", value)
    /// Styles used to create the thumb passed to the internal `SwitchBase` component `icon` prop.
    static member inline thumb(value: string) : ISwitchClasses = unbox ("thumb", value)
    /// Styles applied to the track element.
    static member inline track(value: string) : ISwitchClasses = unbox ("track", value)


  type ITabClasses = interface end

  [<Erase>]
  type tab =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITabClasses = unbox ("root", value)
    /// Styles applied to the root element if both `icon` and `label` are provided.
    static member inline labelIcon(value: string) : ITabClasses = unbox ("labelIcon", value)
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="inherit"`.
    static member inline textColorInherit(value: string) : ITabClasses = unbox ("textColorInherit", value)
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="primary"`.
    static member inline textColorPrimary(value: string) : ITabClasses = unbox ("textColorPrimary", value)
    /// Styles applied to the root element if the parent [`Tabs`](https://material-ui.com/api/tabs/) has `textColor="secondary"`.
    static member inline textColorSecondary(value: string) : ITabClasses = unbox ("textColorSecondary", value)
    /// Pseudo-class applied to the root element if `selected={true}` (controlled by the Tabs component).
    static member inline selected(value: string) : ITabClasses = unbox ("selected", value)
    /// Pseudo-class applied to the root element if `disabled={true}` (controlled by the Tabs component).
    static member inline disabled(value: string) : ITabClasses = unbox ("disabled", value)
    /// Styles applied to the root element if `fullWidth={true}` (controlled by the Tabs component).
    static member inline fullWidth(value: string) : ITabClasses = unbox ("fullWidth", value)
    /// Styles applied to the root element if `wrapped={true}`.
    static member inline wrapped(value: string) : ITabClasses = unbox ("wrapped", value)
    /// Styles applied to the `icon` and `label`'s wrapper element.
    static member inline wrapper(value: string) : ITabClasses = unbox ("wrapper", value)


  type ITableClasses = interface end

  [<Erase>]
  type table =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITableClasses = unbox ("root", value)


  type ITableBodyClasses = interface end

  [<Erase>]
  type tableBody =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITableBodyClasses = unbox ("root", value)


  type ITableCellClasses = interface end

  [<Erase>]
  type tableCell =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITableCellClasses = unbox ("root", value)
    /// Styles applied to the root element if `variant="head"` or `context.table.head`.
    static member inline head(value: string) : ITableCellClasses = unbox ("head", value)
    /// Styles applied to the root element if `variant="body"` or `context.table.body`.
    static member inline body(value: string) : ITableCellClasses = unbox ("body", value)
    /// Styles applied to the root element if `variant="footer"` or `context.table.footer`.
    static member inline footer(value: string) : ITableCellClasses = unbox ("footer", value)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) : ITableCellClasses = unbox ("sizeSmall", value)
    /// Styles applied to the root element if `padding="checkbox"`.
    static member inline paddingCheckbox(value: string) : ITableCellClasses = unbox ("paddingCheckbox", value)
    /// Styles applied to the root element if `padding="none"`.
    static member inline paddingNone(value: string) : ITableCellClasses = unbox ("paddingNone", value)
    /// Styles applied to the root element if `align="left"`.
    static member inline alignLeft(value: string) : ITableCellClasses = unbox ("alignLeft", value)
    /// Styles applied to the root element if `align="center"`.
    static member inline alignCenter(value: string) : ITableCellClasses = unbox ("alignCenter", value)
    /// Styles applied to the root element if `align="right"`.
    static member inline alignRight(value: string) : ITableCellClasses = unbox ("alignRight", value)
    /// Styles applied to the root element if `align="justify"`.
    static member inline alignJustify(value: string) : ITableCellClasses = unbox ("alignJustify", value)


  type ITableFooterClasses = interface end

  [<Erase>]
  type tableFooter =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITableFooterClasses = unbox ("root", value)


  type ITableHeadClasses = interface end

  [<Erase>]
  type tableHead =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITableHeadClasses = unbox ("root", value)


  type ITablePaginationClasses = interface end

  [<Erase>]
  type tablePagination =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITablePaginationClasses = unbox ("root", value)
    /// Styles applied to the Toolbar component.
    static member inline toolbar(value: string) : ITablePaginationClasses = unbox ("toolbar", value)
    /// Styles applied to the spacer element.
    static member inline spacer(value: string) : ITablePaginationClasses = unbox ("spacer", value)
    /// Styles applied to the caption Typography components if `variant="caption"`.
    static member inline caption(value: string) : ITablePaginationClasses = unbox ("caption", value)
    /// Styles applied to the Select component root element.
    static member inline selectRoot(value: string) : ITablePaginationClasses = unbox ("selectRoot", value)
    /// Styles applied to the Select component `select` class.
    static member inline select(value: string) : ITablePaginationClasses = unbox ("select", value)
    /// Styles applied to the Select component `icon` class.
    static member inline selectIcon(value: string) : ITablePaginationClasses = unbox ("selectIcon", value)
    /// Styles applied to the `InputBase` component.
    static member inline input(value: string) : ITablePaginationClasses = unbox ("input", value)
    /// Styles applied to the MenuItem component.
    static member inline menuItem(value: string) : ITablePaginationClasses = unbox ("menuItem", value)
    /// Styles applied to the internal `TablePaginationActions` component.
    static member inline actions(value: string) : ITablePaginationClasses = unbox ("actions", value)


  type ITableRowClasses = interface end

  [<Erase>]
  type tableRow =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITableRowClasses = unbox ("root", value)
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(value: string) : ITableRowClasses = unbox ("selected", value)
    /// Pseudo-class applied to the root element if `hover={true}`.
    static member inline hover(value: string) : ITableRowClasses = unbox ("hover", value)
    /// Styles applied to the root element if table variant="head".
    static member inline head(value: string) : ITableRowClasses = unbox ("head", value)
    /// Styles applied to the root element if table variant="footer".
    static member inline footer(value: string) : ITableRowClasses = unbox ("footer", value)


  type ITableSortLabelClasses = interface end

  [<Erase>]
  type tableSortLabel =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITableSortLabelClasses = unbox ("root", value)
    /// Pseudo-class applied to the root element if `active={true}`.
    static member inline active(value: string) : ITableSortLabelClasses = unbox ("active", value)
    /// Styles applied to the icon component.
    static member inline icon(value: string) : ITableSortLabelClasses = unbox ("icon", value)
    /// Styles applied to the icon component if `direction="desc"`.
    static member inline iconDirectionDesc(value: string) : ITableSortLabelClasses = unbox ("iconDirectionDesc", value)
    /// Styles applied to the icon component if `direction="asc"`.
    static member inline iconDirectionAsc(value: string) : ITableSortLabelClasses = unbox ("iconDirectionAsc", value)


  type ITabsClasses = interface end

  [<Erase>]
  type tabs =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITabsClasses = unbox ("root", value)
    /// Styles applied to the root element if `orientation="vertical"`.
    static member inline vertical(value: string) : ITabsClasses = unbox ("vertical", value)
    /// Styles applied to the flex container element.
    static member inline flexContainer(value: string) : ITabsClasses = unbox ("flexContainer", value)
    /// Styles applied to the flex container element if `orientation="vertical"`.
    static member inline flexContainerVertical(value: string) : ITabsClasses = unbox ("flexContainerVertical", value)
    /// Styles applied to the flex container element if `centered={true}`&`!variant="scrollable"`.
    static member inline centered(value: string) : ITabsClasses = unbox ("centered", value)
    /// Styles applied to the tablist element.
    static member inline scroller(value: string) : ITabsClasses = unbox ("scroller", value)
    /// Styles applied to the tablist element if `!variant="scrollable"`.
    static member inline fixed'(value: string) : ITabsClasses = unbox ("fixed", value)
    /// Styles applied to the tablist element if `variant="scrollable"`.
    static member inline scrollable(value: string) : ITabsClasses = unbox ("scrollable", value)
    /// Styles applied to the `ScrollButtonComponent` component.
    static member inline scrollButtons(value: string) : ITabsClasses = unbox ("scrollButtons", value)
    /// Styles applied to the `ScrollButtonComponent` component if `scrollButtons="auto"` or scrollButtons="desktop"`.
    static member inline scrollButtonsDesktop(value: string) : ITabsClasses = unbox ("scrollButtonsDesktop", value)
    /// Styles applied to the `TabIndicator` component.
    static member inline indicator(value: string) : ITabsClasses = unbox ("indicator", value)


  type ITextareaAutosizeClasses = interface end


  type ITextFieldClasses = interface end

  [<Erase>]
  type textField =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITextFieldClasses = unbox ("root", value)


  type IToggleButtonClasses = interface end

  [<Erase>]
  type toggleButton =
    /// Styles applied to the root element.
    static member inline root(value: string) : IToggleButtonClasses = unbox ("root", value)
    /// Pseudo-class applied to the root element if `disabled={true}`.
    static member inline disabled(value: string) : IToggleButtonClasses = unbox ("disabled", value)
    /// Pseudo-class applied to the root element if `selected={true}`.
    static member inline selected(value: string) : IToggleButtonClasses = unbox ("selected", value)
    /// Styles applied to the `label` wrapper element.
    static member inline label(value: string) : IToggleButtonClasses = unbox ("label", value)
    /// Styles applied to the root element if `size="small"`.
    static member inline sizeSmall(value: string) : IToggleButtonClasses = unbox ("sizeSmall", value)
    /// Styles applied to the root element if `size="large"`.
    static member inline sizeLarge(value: string) : IToggleButtonClasses = unbox ("sizeLarge", value)


  type IToggleButtonGroupClasses = interface end

  [<Erase>]
  type toggleButtonGroup =
    /// Styles applied to the root element.
    static member inline root(value: string) : IToggleButtonGroupClasses = unbox ("root", value)


  type IToolbarClasses = interface end

  [<Erase>]
  type toolbar =
    /// Styles applied to the root element.
    static member inline root(value: string) : IToolbarClasses = unbox ("root", value)
    /// Styles applied to the root element if `disableGutters={false}`.
    static member inline gutters(value: string) : IToolbarClasses = unbox ("gutters", value)
    /// Styles applied to the root element if `variant="regular"`.
    static member inline regular(value: string) : IToolbarClasses = unbox ("regular", value)
    /// Styles applied to the root element if `variant="dense"`.
    static member inline dense(value: string) : IToolbarClasses = unbox ("dense", value)


  type ITooltipClasses = interface end

  [<Erase>]
  type tooltip =
    /// Styles applied to the Popper component.
    static member inline popper(value: string) : ITooltipClasses = unbox ("popper", value)
    /// Styles applied to the Popper component if `interactive={true}`.
    static member inline popperInteractive(value: string) : ITooltipClasses = unbox ("popperInteractive", value)
    /// Styles applied to the tooltip (label wrapper) element.
    static member inline tooltip(value: string) : ITooltipClasses = unbox ("tooltip", value)
    /// Styles applied to the tooltip (label wrapper) element if the tooltip is opened by touch.
    static member inline touch(value: string) : ITooltipClasses = unbox ("touch", value)
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "left".
    static member inline tooltipPlacementLeft(value: string) : ITooltipClasses = unbox ("tooltipPlacementLeft", value)
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "right".
    static member inline tooltipPlacementRight(value: string) : ITooltipClasses = unbox ("tooltipPlacementRight", value)
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "top".
    static member inline tooltipPlacementTop(value: string) : ITooltipClasses = unbox ("tooltipPlacementTop", value)
    /// Styles applied to the tooltip (label wrapper) element if `placement` contains "bottom".
    static member inline tooltipPlacementBottom(value: string) : ITooltipClasses = unbox ("tooltipPlacementBottom", value)


  type ITouchRippleClasses = interface end

  [<Erase>]
  type touchRipple =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITouchRippleClasses = unbox ("root", value)
    /// Styles applied to the internal `Ripple` components `ripple` class.
    static member inline ripple(value: string) : ITouchRippleClasses = unbox ("ripple", value)
    /// Styles applied to the internal `Ripple` components `rippleVisible` class.
    static member inline rippleVisible(value: string) : ITouchRippleClasses = unbox ("rippleVisible", value)
    /// Styles applied to the internal `Ripple` components `ripplePulsate` class.
    static member inline ripplePulsate(value: string) : ITouchRippleClasses = unbox ("ripplePulsate", value)
    /// Styles applied to the internal `Ripple` components `child` class.
    static member inline child(value: string) : ITouchRippleClasses = unbox ("child", value)
    /// Styles applied to the internal `Ripple` components `childLeaving` class.
    static member inline childLeaving(value: string) : ITouchRippleClasses = unbox ("childLeaving", value)
    /// Styles applied to the internal `Ripple` components `childPulsate` class.
    static member inline childPulsate(value: string) : ITouchRippleClasses = unbox ("childPulsate", value)


  type ITreeItemClasses = interface end

  [<Erase>]
  type treeItem =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITreeItemClasses = unbox ("root", value)
    /// Pseudo-class applied to the root element when expanded.
    static member inline expanded(value: string) : ITreeItemClasses = unbox ("expanded", value)
    /// Styles applied to the `role="group"` element.
    static member inline group(value: string) : ITreeItemClasses = unbox ("group", value)
    /// Styles applied to the tree node content.
    static member inline content(value: string) : ITreeItemClasses = unbox ("content", value)
    /// Styles applied to the tree node icon and collapse/expand icon.
    static member inline iconContainer(value: string) : ITreeItemClasses = unbox ("iconContainer", value)
    /// Styles applied to the label element.
    static member inline label(value: string) : ITreeItemClasses = unbox ("label", value)


  type ITreeViewClasses = interface end

  [<Erase>]
  type treeView =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITreeViewClasses = unbox ("root", value)


  type ITypographyClasses = interface end

  [<Erase>]
  type typography =
    /// Styles applied to the root element.
    static member inline root(value: string) : ITypographyClasses = unbox ("root", value)
    /// Styles applied to the root element if `variant="body2"`.
    static member inline body2(value: string) : ITypographyClasses = unbox ("body2", value)
    /// Styles applied to the root element if `variant="body1"`.
    static member inline body1(value: string) : ITypographyClasses = unbox ("body1", value)
    /// Styles applied to the root element if `variant="caption"`.
    static member inline caption(value: string) : ITypographyClasses = unbox ("caption", value)
    /// Styles applied to the root element if `variant="button"`.
    static member inline button(value: string) : ITypographyClasses = unbox ("button", value)
    /// Styles applied to the root element if `variant="h1"`.
    static member inline h1(value: string) : ITypographyClasses = unbox ("h1", value)
    /// Styles applied to the root element if `variant="h2"`.
    static member inline h2(value: string) : ITypographyClasses = unbox ("h2", value)
    /// Styles applied to the root element if `variant="h3"`.
    static member inline h3(value: string) : ITypographyClasses = unbox ("h3", value)
    /// Styles applied to the root element if `variant="h4"`.
    static member inline h4(value: string) : ITypographyClasses = unbox ("h4", value)
    /// Styles applied to the root element if `variant="h5"`.
    static member inline h5(value: string) : ITypographyClasses = unbox ("h5", value)
    /// Styles applied to the root element if `variant="h6"`.
    static member inline h6(value: string) : ITypographyClasses = unbox ("h6", value)
    /// Styles applied to the root element if `variant="subtitle1"`.
    static member inline subtitle1(value: string) : ITypographyClasses = unbox ("subtitle1", value)
    /// Styles applied to the root element if `variant="subtitle2"`.
    static member inline subtitle2(value: string) : ITypographyClasses = unbox ("subtitle2", value)
    /// Styles applied to the root element if `variant="overline"`.
    static member inline overline(value: string) : ITypographyClasses = unbox ("overline", value)
    /// Styles applied to the root element if `variant="srOnly"`. Only accessible to screen readers.
    static member inline srOnly(value: string) : ITypographyClasses = unbox ("srOnly", value)
    /// Styles applied to the root element if `align="left"`.
    static member inline alignLeft(value: string) : ITypographyClasses = unbox ("alignLeft", value)
    /// Styles applied to the root element if `align="center"`.
    static member inline alignCenter(value: string) : ITypographyClasses = unbox ("alignCenter", value)
    /// Styles applied to the root element if `align="right"`.
    static member inline alignRight(value: string) : ITypographyClasses = unbox ("alignRight", value)
    /// Styles applied to the root element if `align="justify"`.
    static member inline alignJustify(value: string) : ITypographyClasses = unbox ("alignJustify", value)
    /// Styles applied to the root element if `align="nowrap"`.
    static member inline noWrap(value: string) : ITypographyClasses = unbox ("noWrap", value)
    /// Styles applied to the root element if `gutterBottom={true}`.
    static member inline gutterBottom(value: string) : ITypographyClasses = unbox ("gutterBottom", value)
    /// Styles applied to the root element if `paragraph={true}`.
    static member inline paragraph(value: string) : ITypographyClasses = unbox ("paragraph", value)
    /// Styles applied to the root element if `color="inherit"`.
    static member inline colorInherit(value: string) : ITypographyClasses = unbox ("colorInherit", value)
    /// Styles applied to the root element if `color="primary"`.
    static member inline colorPrimary(value: string) : ITypographyClasses = unbox ("colorPrimary", value)
    /// Styles applied to the root element if `color="secondary"`.
    static member inline colorSecondary(value: string) : ITypographyClasses = unbox ("colorSecondary", value)
    /// Styles applied to the root element if `color="textPrimary"`.
    static member inline colorTextPrimary(value: string) : ITypographyClasses = unbox ("colorTextPrimary", value)
    /// Styles applied to the root element if `color="textSecondary"`.
    static member inline colorTextSecondary(value: string) : ITypographyClasses = unbox ("colorTextSecondary", value)
    /// Styles applied to the root element if `color="error"`.
    static member inline colorError(value: string) : ITypographyClasses = unbox ("colorError", value)
    /// Styles applied to the root element if `display="inline"`.
    static member inline displayInline(value: string) : ITypographyClasses = unbox ("displayInline", value)
    /// Styles applied to the root element if `display="block"`.
    static member inline displayBlock(value: string) : ITypographyClasses = unbox ("displayBlock", value)


  type IZoomClasses = interface end

