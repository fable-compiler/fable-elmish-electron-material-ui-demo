namespace Feliz.MaterialUI

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz

[<StringEnum; RequireQualifiedAccess>]
type DialogCloseReason =
  | EscapeKeyDown
  | BackdropClick

[<StringEnum; RequireQualifiedAccess>]
type MenuCloseReason =
  | EscapeKeyDown
  | BackdropClick
  | TabKeyDown

[<StringEnum; RequireQualifiedAccess>]
type ModalCloseReason =
  | EscapeKeyDown
  | BackdropClick

[<StringEnum; RequireQualifiedAccess>]
type PopoverCloseReason =
  | EscapeKeyDown
  | BackdropClick

[<StringEnum; RequireQualifiedAccess>]
type SnackbarCloseReason =
  | Timeout
  | Clickaway


[<Erase>]
type muiThemeProvider =
  /// Your component tree.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// A theme object. You can provide a function to extend the outer theme.
  static member inline theme(theme: Theme) = Interop.mkAttr "theme" theme
  /// A theme object. You can provide a function to extend the outer theme.
  static member inline theme(extendTheme: Theme -> Theme) = Interop.mkAttr "theme" extendTheme


[<Erase>]
type appBar =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.appBar` to specify class names.
  static member inline classes(classNames: classes.IAppBarClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)

module appBar =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The positioning type. The behavior of the different options is described [in the MDN web docs](https://developer.mozilla.org/en-US/docs/Learn/CSS/CSS_layout/Positioning). Note: `sticky` is not universally supported and will fall back to `static` when unavailable.
  [<Erase>]
  type position =
    static member inline absolute = Interop.mkAttr "position" "absolute"
    static member inline fixed' = Interop.mkAttr "position" "fixed"
    static member inline relative = Interop.mkAttr "position" "relative"
    static member inline static' = Interop.mkAttr "position" "static"
    static member inline sticky = Interop.mkAttr "position" "sticky"


[<Erase>]
type avatar =
  /// Used in combination with `src` or `srcSet` to provide an alt attribute for the rendered `img` element.
  static member inline alt(value: string) = Interop.mkAttr "alt" value
  /// Used to render icon or text elements inside the Avatar. `src` and `alt` props will not be used and no `img` will be rendered by default.
  ///
  /// This can be an element, or just a string.
  static member inline children(element: ReactElement) = prop.children element
  /// Used to render icon or text elements inside the Avatar. `src` and `alt` props will not be used and no `img` will be rendered by default.
  ///
  /// This can be an element, or just a string.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Used to render icon or text elements inside the Avatar. `src` and `alt` props will not be used and no `img` will be rendered by default.
  ///
  /// This can be an element, or just a string.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Used to render icon or text elements inside the Avatar. `src` and `alt` props will not be used and no `img` will be rendered by default.
  ///
  /// This can be an element, or just a string.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Used to render icon or text elements inside the Avatar. `src` and `alt` props will not be used and no `img` will be rendered by default.
  ///
  /// This can be an element, or just a string.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Used to render icon or text elements inside the Avatar. `src` and `alt` props will not be used and no `img` will be rendered by default.
  ///
  /// This can be an element, or just a string.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.avatar` to specify class names.
  static member inline classes(classNames: classes.IAvatarClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Attributes applied to the `img` element if the component is used to display an image.
  static member inline imgProps(props: IReactProperty list) = Interop.mkAttr "imgProps" (createObj !!props)
  /// The `sizes` attribute for the `img` element.
  static member inline sizes(value: string) = Interop.mkAttr "sizes" value
  /// The `src` attribute for the `img` element.
  static member inline src(value: string) = Interop.mkAttr "src" value
  /// The `srcSet` attribute for the `img` element.
  static member inline srcSet(value: string) = Interop.mkAttr "srcSet" value


type backdrop =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.backdrop` to specify class names.
  static member inline classes(classNames: classes.IBackdropClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the backdrop is invisible. It can be used when rendering a popover or a custom select component.
  static member inline invisible(value: bool) = Interop.mkAttr "invisible" value
  /// If `true`, the backdrop is open.
  static member inline open'(value: bool) = Interop.mkAttr "open" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration(value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member transitionDuration(?appear: int, ?enter: int, ?exit: int) = [if appear.IsSome then yield "appear" ==> appear.Value; if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "transitionDuration"


[<Erase>]
type badge =
  /// The content rendered within the badge.
  static member inline badgeContent(value: ReactElement) = Interop.mkAttr "badgeContent" value
  /// The content rendered within the badge.
  static member inline badgeContent(values: ReactElement seq) = Interop.mkAttr "badgeContent" values
  /// The content rendered within the badge.
  static member inline badgeContent(value: string) = Interop.mkAttr "badgeContent" value
  /// The content rendered within the badge.
  static member inline badgeContent(values: string seq) = Interop.mkAttr "badgeContent" values
  /// The content rendered within the badge.
  static member inline badgeContent(value: int) = Interop.mkAttr "badgeContent" value
  /// The content rendered within the badge.
  static member inline badgeContent(value: float) = Interop.mkAttr "badgeContent" value
  /// The badge will be added relative to this node.
  static member inline children(element: ReactElement) = prop.children element
  /// The badge will be added relative to this node.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The badge will be added relative to this node.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The badge will be added relative to this node.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The badge will be added relative to this node.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The badge will be added relative to this node.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.badge` to specify class names.
  static member inline classes(classNames: classes.IBadgeClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the badge will be invisible.
  static member inline invisible(value: bool) = Interop.mkAttr "invisible" value
  /// Max count to show.
  static member inline max(value: int) = Interop.mkAttr "max" value
  /// Controls whether the badge is hidden when `badgeContent` is zero.
  static member inline showZero(value: bool) = Interop.mkAttr "showZero" value

module badge =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline dot = Interop.mkAttr "variant" "dot"
    static member inline standard = Interop.mkAttr "variant" "standard"


[<Erase>]
type bottomNavigation =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.bottomNavigation` to specify class names.
  static member inline classes(classNames: classes.IBottomNavigationClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* We default to the index of the child
  static member inline onChange(handler: Event -> 'a -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* We default to the index of the child
  static member inline onChange(handler: 'a -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> (fun _ v -> handler v))
  /// If `true`, all `BottomNavigationAction`s will show their labels. By default, only the selected `BottomNavigationAction` will show its label.
  static member inline showLabels(value: bool) = Interop.mkAttr "showLabels" value
  /// The value of the currently selected `BottomNavigationAction`.
  static member inline value(value: 'a) = Interop.mkAttr "value" value


[<Erase>]
type bottomNavigationAction =
  /// Override or extend the styles applied to the component. Use `classes.bottomNavigationAction` to specify class names.
  static member inline classes(classNames: classes.IBottomNavigationActionClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The icon element.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element
  /// The label element.
  static member inline label(value: ReactElement) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label(values: ReactElement seq) = Interop.mkAttr "label" values
  /// The label element.
  static member inline label(value: string) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label(values: string seq) = Interop.mkAttr "label" values
  /// The label element.
  static member inline label(value: int) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label(value: float) = Interop.mkAttr "label" value
  /// If `true`, the `BottomNavigationAction` will show its label. By default, only the selected `BottomNavigationAction` inside `BottomNavigation` will show its label.
  static member inline showLabel(value: bool) = Interop.mkAttr "showLabel" value
  /// You can provide your own value. Otherwise, we fallback to the child position index.
  static member inline value(value: 'a) = Interop.mkAttr "value" value


[<Erase>]
type breadcrumbs =
  /// The breadcrumb children.
  static member inline children(element: ReactElement) = prop.children element
  /// The breadcrumb children.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The breadcrumb children.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The breadcrumb children.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The breadcrumb children.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The breadcrumb children.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.breadcrumbs` to specify class names.
  static member inline classes(classNames: classes.IBreadcrumbsClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component. By default, it maps the variant to a good default headline component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component. By default, it maps the variant to a good default headline component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If max items is exceeded, the number of items to show after the ellipsis.
  static member inline itemsAfterCollapse(value: int) = Interop.mkAttr "itemsAfterCollapse" value
  /// If max items is exceeded, the number of items to show before the ellipsis.
  static member inline itemsBeforeCollapse(value: int) = Interop.mkAttr "itemsBeforeCollapse" value
  /// Specifies the maximum number of breadcrumbs to display. When there are more than the maximum number, only the first and last will be shown, with an ellipsis in between.
  static member inline maxItems(value: int) = Interop.mkAttr "maxItems" value
  /// Custom separator node.
  static member inline separator(value: ReactElement) = Interop.mkAttr "separator" value
  /// Custom separator node.
  static member inline separator(values: ReactElement seq) = Interop.mkAttr "separator" values
  /// Custom separator node.
  static member inline separator(value: string) = Interop.mkAttr "separator" value
  /// Custom separator node.
  static member inline separator(values: string seq) = Interop.mkAttr "separator" values
  /// Custom separator node.
  static member inline separator(value: int) = Interop.mkAttr "separator" value
  /// Custom separator node.
  static member inline separator(value: float) = Interop.mkAttr "separator" value


[<Erase>]
type button =
  /// The content of the button.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the button.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the button.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the button.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.button` to specify class names.
  static member inline classes(classNames: classes.IButtonClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the button will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the keyboard focus ripple will be disabled. `disableRipple` must also be true.
  static member inline disableFocusRipple(value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the ripple effect will be disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `focusVisibleClassName`.
  static member inline disableRipple(value: bool) = Interop.mkAttr "disableRipple" value
  /// If `true`, the button will take up the full width of its container.
  static member inline fullWidth(value: bool) = Interop.mkAttr "fullWidth" value
  /// The URL to link to when the button is clicked. If defined, an `a` element will be used as the root node.
  static member inline href(value: string) = Interop.mkAttr "href" value

module button =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The size of the button. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline text = Interop.mkAttr "variant" "text"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline contained = Interop.mkAttr "variant" "contained"


[<Erase>]
type buttonBase =
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action(ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr "action" ref
  /// A ref for imperative actions. It currently only supports `focusVisible()` action.
  static member inline action(handler: ButtonBaseActions -> unit) = Interop.mkAttr "action" handler
  /// Use that prop to pass a ref callback to the native button component.
  static member inline buttonRef(ref: IRefValue<HTMLButtonElement option>) = Interop.mkAttr "buttonRef" ref
  /// Use that prop to pass a ref callback to the native button component.
  static member inline buttonRef(handler: HTMLButtonElement -> unit) = Interop.mkAttr "buttonRef" handler
  /// If `true`, the ripples will be centered. They won't start at the cursor interaction position.
  static member inline centerRipple(value: bool) = Interop.mkAttr "centerRipple" value
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.buttonBase` to specify class names.
  static member inline classes(classNames: classes.IButtonBaseClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the base button will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the ripple effect will be disabled.
  ///
  /// ⚠️ Without a ripple there is no styling for :focus-visible by default. Be sure to highlight the element by applying separate styles with the `focusVisibleClassName`.
  static member inline disableRipple(value: bool) = Interop.mkAttr "disableRipple" value
  /// If `true`, the touch ripple effect will be disabled.
  static member inline disableTouchRipple(value: bool) = Interop.mkAttr "disableTouchRipple" value
  /// If `true`, the base button will have a keyboard focus ripple. `disableRipple` must also be `false`.
  static member inline focusRipple(value: bool) = Interop.mkAttr "focusRipple" value
  /// This prop can help a person know which element has the keyboard focus. The class name will be applied when the element gain the focus through a keyboard interaction. It's a polyfill for the [CSS :focus-visible selector](https://drafts.csswg.org/selectors-4/#the-focus-visible-pseudo). The rationale for using this feature [is explained here](https://github.com/WICG/focus-visible/blob/master/explainer.md). A [polyfill can be used](https://github.com/WICG/focus-visible) to apply a `focus-visible` class to other components if needed.
  static member inline focusVisibleClassName(value: string) = Interop.mkAttr "focusVisibleClassName" value
  /// Callback fired when the component is focused with a keyboard. We trigger a `onFocus` callback too.
  static member inline onFocusVisible(handler: Event -> unit) = Interop.mkAttr "onFocusVisible" handler
  /// Props applied to the `TouchRipple` element.
  static member inline TouchRippleProps(props: IReactProperty list) = Interop.mkAttr "TouchRippleProps" (createObj !!props)

module buttonBase =

  /// Used to control the button's purpose. This prop passes the value to the `type` attribute of the native button component.
  [<Erase>]
  type type' =
    static member inline submit = Interop.mkAttr "type" "submit"
    static member inline reset = Interop.mkAttr "type" "reset"
    static member inline button = Interop.mkAttr "type" "button"


[<Erase>]
type buttonGroup =
  /// The content of the button group.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the button group.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the button group.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the button group.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the button group.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the button group.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.buttonGroup` to specify class names.
  static member inline classes(classNames: classes.IButtonGroupClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the buttons will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the button keyboard focus ripple will be disabled. `disableRipple` must also be true.
  static member inline disableFocusRipple(value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the button ripple effect will be disabled.
  static member inline disableRipple(value: bool) = Interop.mkAttr "disableRipple" value
  /// If `true`, the buttons will take up the full width of its container.
  static member inline fullWidth(value: bool) = Interop.mkAttr "fullWidth" value

module buttonGroup =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The size of the button. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline contained = Interop.mkAttr "variant" "contained"


[<Erase>]
type card =
  /// Override or extend the styles applied to the component. Use `classes.card` to specify class names.
  static member inline classes(classNames: classes.ICardClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the card will use raised styling.
  static member inline raised(value: bool) = Interop.mkAttr "raised" value


[<Erase>]
type cardActionArea =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.cardActionArea` to specify class names.
  static member inline classes(classNames: classes.ICardActionAreaClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)


[<Erase>]
type cardActions =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.cardActions` to specify class names.
  static member inline classes(classNames: classes.ICardActionsClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the actions do not have additional margin.
  static member inline disableSpacing(value: bool) = Interop.mkAttr "disableSpacing" value


[<Erase>]
type cardContent =
  /// Override or extend the styles applied to the component. Use `classes.cardContent` to specify class names.
  static member inline classes(classNames: classes.ICardContentClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value


[<Erase>]
type cardHeader =
  /// The action to display in the card header.
  static member inline action(value: ReactElement) = Interop.mkAttr "action" value
  /// The action to display in the card header.
  static member inline action(values: ReactElement seq) = Interop.mkAttr "action" values
  /// The action to display in the card header.
  static member inline action(value: string) = Interop.mkAttr "action" value
  /// The action to display in the card header.
  static member inline action(values: string seq) = Interop.mkAttr "action" values
  /// The action to display in the card header.
  static member inline action(value: int) = Interop.mkAttr "action" value
  /// The action to display in the card header.
  static member inline action(value: float) = Interop.mkAttr "action" value
  /// The Avatar for the Card Header.
  static member inline avatar(value: ReactElement) = Interop.mkAttr "avatar" value
  /// The Avatar for the Card Header.
  static member inline avatar(values: ReactElement seq) = Interop.mkAttr "avatar" values
  /// The Avatar for the Card Header.
  static member inline avatar(value: string) = Interop.mkAttr "avatar" value
  /// The Avatar for the Card Header.
  static member inline avatar(values: string seq) = Interop.mkAttr "avatar" values
  /// The Avatar for the Card Header.
  static member inline avatar(value: int) = Interop.mkAttr "avatar" value
  /// The Avatar for the Card Header.
  static member inline avatar(value: float) = Interop.mkAttr "avatar" value
  /// Override or extend the styles applied to the component. Use `classes.cardHeader` to specify class names.
  static member inline classes(classNames: classes.ICardHeaderClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, `subheader` and `title` won't be wrapped by a Typography component. This can be useful to render an alternative Typography variant by wrapping the `title` text, and optional `subheader` text with the Typography component.
  static member inline disableTypography(value: bool) = Interop.mkAttr "disableTypography" value
  /// The content of the component.
  static member inline subheader(value: ReactElement) = Interop.mkAttr "subheader" value
  /// The content of the component.
  static member inline subheader(values: ReactElement seq) = Interop.mkAttr "subheader" values
  /// The content of the component.
  static member inline subheader(value: string) = Interop.mkAttr "subheader" value
  /// The content of the component.
  static member inline subheader(values: string seq) = Interop.mkAttr "subheader" values
  /// The content of the component.
  static member inline subheader(value: int) = Interop.mkAttr "subheader" value
  /// The content of the component.
  static member inline subheader(value: float) = Interop.mkAttr "subheader" value
  /// These props will be forwarded to the subheader (as long as disableTypography is not `true`).
  static member inline subheaderTypographyProps(props: IReactProperty list) = Interop.mkAttr "subheaderTypographyProps" (createObj !!props)
  /// The content of the Card Title.
  static member inline title(value: ReactElement) = Interop.mkAttr "title" value
  /// The content of the Card Title.
  static member inline title(values: ReactElement seq) = Interop.mkAttr "title" values
  /// The content of the Card Title.
  static member inline title(value: string) = Interop.mkAttr "title" value
  /// The content of the Card Title.
  static member inline title(values: string seq) = Interop.mkAttr "title" values
  /// The content of the Card Title.
  static member inline title(value: int) = Interop.mkAttr "title" value
  /// The content of the Card Title.
  static member inline title(value: float) = Interop.mkAttr "title" value
  /// These props will be forwarded to the title (as long as disableTypography is not `true`).
  static member inline titleTypographyProps(props: IReactProperty list) = Interop.mkAttr "titleTypographyProps" (createObj !!props)


[<Erase>]
type cardMedia =
  /// Override or extend the styles applied to the component. Use `classes.cardMedia` to specify class names.
  static member inline classes(classNames: classes.ICardMediaClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Component for rendering image. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// Component for rendering image. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Image to be displayed as a background image. Either `image` or `src` prop must be specified. Note that caller must specify height otherwise the image will not be visible.
  static member inline image(value: string) = Interop.mkAttr "image" value
  /// An alias for `image` property. Available only with media components. Media components: `video`, `audio`, `picture`, `iframe`, `img`.
  static member inline src(value: string) = Interop.mkAttr "src" value


[<Erase>]
type checkbox =
  /// If `true`, the component is checked.
  static member inline checked'(value: bool) = Interop.mkAttr "checked" value
  /// The icon to display when the component is checked.
  static member inline checkedIcon(element: ReactElement) = Interop.mkAttr "checkedIcon" element
  /// Override or extend the styles applied to the component. Use `classes.checkbox` to specify class names.
  static member inline classes(classNames: classes.ICheckboxClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the switch will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple(value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon to display when the component is unchecked.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element
  /// The id of the `input` element.
  static member inline id(value: string) = Interop.mkAttr "id" value
  /// If `true`, the component appears indeterminate. This does not set the native input element to indeterminate due to inconsistent behavior across browsers. However, we set a `data-indeterminate` attribute on the input.
  static member inline indeterminate(value: bool) = Interop.mkAttr "indeterminate" value
  /// The icon to display when the component is indeterminate.
  static member inline indeterminateIcon(element: ReactElement) = Interop.mkAttr "indeterminateIcon" element
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps(props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(ref: IRefValue<HTMLInputElement option>) = Interop.mkAttr "inputRef" ref
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(handler: HTMLInputElement -> unit) = Interop.mkAttr "inputRef" handler
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, checked: boolean) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.target.checked`.
  ///
  /// *checked:* The `checked` value of the switch
  static member inline onChange(handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, checked: boolean) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.target.checked`.
  ///
  /// *checked:* The `checked` value of the switch
  static member inline onChange(handler: bool -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Checked)
  /// If `true`, the `input` element will be required.
  static member inline required(value: bool) = Interop.mkAttr "required" value
  /// The input component prop `type`.
  static member inline type'(value: string) = Interop.mkAttr "type" value
  /// The value of the component. The DOM API casts this to a string.
  static member inline value(value: string) = Interop.mkAttr "value" value

module checkbox =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline default' = Interop.mkAttr "color" "default"


[<Erase>]
type chip =
  /// Avatar element.
  static member inline avatar(value: ReactElement) = Interop.mkAttr "avatar" value
  /// Override or extend the styles applied to the component. Use `classes.chip` to specify class names.
  static member inline classes(classNames: classes.IChipClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If true, the chip will appear clickable, and will raise when pressed, even if the onClick prop is not defined. If false, the chip will not be clickable, even if onClick prop is defined. This can be used, for example, along with the component prop to indicate an anchor Chip is clickable.
  static member inline clickable(value: bool) = Interop.mkAttr "clickable" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Override the default delete icon element. Shown only if `onDelete` is set.
  static member inline deleteIcon(value: ReactElement) = Interop.mkAttr "deleteIcon" value
  /// Icon element.
  static member inline icon(value: ReactElement) = Interop.mkAttr "icon" value
  /// The content of the label.
  static member inline label(value: ReactElement) = Interop.mkAttr "label" value
  /// The content of the label.
  static member inline label(values: ReactElement seq) = Interop.mkAttr "label" values
  /// The content of the label.
  static member inline label(value: string) = Interop.mkAttr "label" value
  /// The content of the label.
  static member inline label(values: string seq) = Interop.mkAttr "label" values
  /// The content of the label.
  static member inline label(value: int) = Interop.mkAttr "label" value
  /// The content of the label.
  static member inline label(value: float) = Interop.mkAttr "label" value
  /// Callback function fired when the delete icon is clicked. If set, the delete icon will be shown.
  static member inline onDelete(handler: Event -> unit) = Interop.mkAttr "onDelete" handler

module chip =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The size of the chip.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline default' = Interop.mkAttr "variant" "default"
    static member inline outlined = Interop.mkAttr "variant" "outlined"


[<Erase>]
type circularProgress =
  /// Override or extend the styles applied to the component. Use `classes.circularProgress` to specify class names.
  static member inline classes(classNames: classes.ICircularProgressClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the shrink animation is disabled. This only works if variant is `indeterminate`.
  static member inline disableShrink(value: bool) = Interop.mkAttr "disableShrink" value
  /// The size of the circle. If using a number, the pixel unit is assumed. If using a string, you need to provide the CSS unit, e.g '3rem'.
  static member inline size(value: int) = Interop.mkAttr "size" value
  /// The size of the circle. If using a number, the pixel unit is assumed. If using a string, you need to provide the CSS unit, e.g '3rem'.
  static member inline size(value: Styles.ICssUnit) = Interop.mkAttr "size" value
  /// The thickness of the circle.
  static member inline thickness(value: int) = Interop.mkAttr "thickness" value
  /// The value of the progress indicator for the determinate and static variants. Value between 0 and 100.
  static member inline value(value: int) = Interop.mkAttr "value" value

module circularProgress =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline inherit' = Interop.mkAttr "color" "inherit"

  /// The variant to use. Use indeterminate when there is no progress value.
  [<Erase>]
  type variant =
    static member inline determinate = Interop.mkAttr "variant" "determinate"
    static member inline indeterminate = Interop.mkAttr "variant" "indeterminate"
    static member inline static' = Interop.mkAttr "variant" "static"


[<Erase>]
type clickAwayListener =
  /// The wrapped element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline children(value: ReactElement) = Interop.mkAttr "children" value
  /// Callback fired when a "click away" event is detected.
  static member inline onClickAway(handler: Event -> unit) = Interop.mkAttr "onClickAway" handler

module clickAwayListener =

  /// The mouse event to listen to. You can disable the listener by providing `false`.
  [<Erase>]
  type mouseEvent =
    static member inline onClick = Interop.mkAttr "mouseEvent" "onClick"
    static member inline onMouseDown = Interop.mkAttr "mouseEvent" "onMouseDown"
    static member inline onMouseUp = Interop.mkAttr "mouseEvent" "onMouseUp"
    static member inline false' = Interop.mkAttr "mouseEvent" false

  /// The touch event to listen to. You can disable the listener by providing `false`.
  [<Erase>]
  type touchEvent =
    static member inline onTouchStart = Interop.mkAttr "touchEvent" "onTouchStart"
    static member inline onTouchEnd = Interop.mkAttr "touchEvent" "onTouchEnd"
    static member inline false' = Interop.mkAttr "touchEvent" false


type collapse =
  /// The content node to be collapsed.
  static member inline children(element: ReactElement) = prop.children element
  /// The content node to be collapsed.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content node to be collapsed.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content node to be collapsed.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content node to be collapsed.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content node to be collapsed.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.collapse` to specify class names.
  static member inline classes(classNames: classes.ICollapseClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The height of the container when collapsed.
  static member inline collapsedHeight(value: Styles.ICssUnit) = Interop.mkAttr "collapsedHeight" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the component will transition in.
  static member inline in'(value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline timeout(value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member timeout(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "timeout"

module collapse =

  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  [<Erase>]
  type timeout =
    static member inline auto = Interop.mkAttr "timeout" "auto"


[<Erase>]
type container =
  static member inline children(element: ReactElement) = prop.children element
  static member inline children(elements: ReactElement seq) = prop.children elements
  static member inline children(value: string) = Interop.mkAttr "children" value
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  static member inline children(value: int) = Interop.mkAttr "children" value
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.container` to specify class names.
  static member inline classes(classNames: classes.IContainerClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Set the max-width to match the min-width of the current breakpoint. This is useful if you'd prefer to design for a fixed set of sizes instead of trying to accommodate a fully fluid viewport. It's fluid by default.
  static member inline fixed'(value: bool) = Interop.mkAttr "fixed" value

module container =

  /// Determine the max-width of the container. The container width grows with the size of the screen. Set to `false` to disable `maxWidth`.
  [<Erase>]
  type maxWidth =
    static member inline xs = Interop.mkAttr "maxWidth" "xs"
    static member inline sm = Interop.mkAttr "maxWidth" "sm"
    static member inline md = Interop.mkAttr "maxWidth" "md"
    static member inline lg = Interop.mkAttr "maxWidth" "lg"
    static member inline xl = Interop.mkAttr "maxWidth" "xl"
    static member inline false' = Interop.mkAttr "maxWidth" false


[<Erase>]
type cssBaseline =
  /// You can wrap a node.
  static member inline children(element: ReactElement) = prop.children element
  /// You can wrap a node.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// You can wrap a node.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// You can wrap a node.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// You can wrap a node.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// You can wrap a node.
  static member inline children(value: float) = Interop.mkAttr "children" value


type dialog =
  /// Dialog children, usually the included sub-components.
  static member inline children(element: ReactElement) = prop.children element
  /// Dialog children, usually the included sub-components.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Dialog children, usually the included sub-components.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Dialog children, usually the included sub-components.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Dialog children, usually the included sub-components.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Dialog children, usually the included sub-components.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.dialog` to specify class names.
  static member inline classes(classNames: classes.IDialogClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, clicking the backdrop will not fire the `onClose` callback.
  static member inline disableBackdropClick(value: bool) = Interop.mkAttr "disableBackdropClick" value
  /// If `true`, hitting escape will not fire the `onClose` callback.
  static member inline disableEscapeKeyDown(value: bool) = Interop.mkAttr "disableEscapeKeyDown" value
  /// If `true`, the dialog will be full-screen
  static member inline fullScreen(value: bool) = Interop.mkAttr "fullScreen" value
  /// If `true`, the dialog stretches to `maxWidth`.
  static member inline fullWidth(value: bool) = Interop.mkAttr "fullWidth" value
  /// Callback fired when the backdrop is clicked.
  static member inline onBackdropClick(handler: Event -> unit) = Interop.mkAttr "onBackdropClick" handler
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *reason:* Can be:`"escapeKeyDown"`, `"backdropClick"`
  static member inline onClose(handler: Event -> DialogCloseReason -> unit) = Interop.mkAttr "onClose" (System.Func<_,_,_> handler)
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *reason:* Can be:`"escapeKeyDown"`, `"backdropClick"`
  static member inline onClose(handler: DialogCloseReason -> unit) = Interop.mkAttr "onClose" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired before the dialog enters.
  static member inline onEnter(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEnter" handler
  /// Callback fired when the dialog has entered.
  static member inline onEntered(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntered" handler
  /// Callback fired when the dialog is entering.
  static member inline onEntering(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntering" handler
  /// Callback fired when the escape key is pressed, `disableKeyboard` is false and the modal is in focus.
  static member inline onEscapeKeyDown(handler: Event -> unit) = Interop.mkAttr "onEscapeKeyDown" handler
  /// Callback fired before the dialog exits.
  static member inline onExit(handler: ReactElement -> unit) = Interop.mkAttr "onExit" handler
  /// Callback fired when the dialog has exited.
  static member inline onExited(handler: ReactElement -> unit) = Interop.mkAttr "onExited" handler
  /// Callback fired when the dialog is exiting.
  static member inline onExiting(handler: ReactElement -> unit) = Interop.mkAttr "onExiting" handler
  /// If `true`, the Dialog is open.
  static member inline open'(value: bool) = Interop.mkAttr "open" value
  /// The component used to render the body of the dialog.
  static member inline PaperComponent(value: ReactElementType) = Interop.mkAttr "PaperComponent" value
  /// Props applied to the [`Paper`](https://material-ui.com/api/paper/) element.
  static member inline PaperProps(props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// The component used for the transition.
  static member inline TransitionComponent(value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration(value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member transitionDuration(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "transitionDuration"
  /// Props applied to the `Transition` element.
  static member inline TransitionProps(props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module dialog =

  /// Determine the max-width of the dialog. The dialog width grows with the size of the screen. Set to `false` to disable `maxWidth`.
  [<Erase>]
  type maxWidth =
    static member inline xs = Interop.mkAttr "maxWidth" "xs"
    static member inline sm = Interop.mkAttr "maxWidth" "sm"
    static member inline md = Interop.mkAttr "maxWidth" "md"
    static member inline lg = Interop.mkAttr "maxWidth" "lg"
    static member inline xl = Interop.mkAttr "maxWidth" "xl"
    static member inline false' = Interop.mkAttr "maxWidth" false

  /// Determine the container for scrolling the dialog.
  [<Erase>]
  type scroll =
    static member inline body = Interop.mkAttr "scroll" "body"
    static member inline paper = Interop.mkAttr "scroll" "paper"


[<Erase>]
type dialogActions =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.dialogActions` to specify class names.
  static member inline classes(classNames: classes.IDialogActionsClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the actions do not have additional margin.
  static member inline disableSpacing(value: bool) = Interop.mkAttr "disableSpacing" value


[<Erase>]
type dialogContent =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.dialogContent` to specify class names.
  static member inline classes(classNames: classes.IDialogContentClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Display the top and bottom dividers.
  static member inline dividers(value: bool) = Interop.mkAttr "dividers" value


[<Erase>]
type dialogContentText =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.dialogContentText` to specify class names.
  static member inline classes(classNames: classes.IDialogContentTextClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)


[<Erase>]
type dialogTitle =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.dialogTitle` to specify class names.
  static member inline classes(classNames: classes.IDialogTitleClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the children won't be wrapped by a typography component. For instance, this can be useful to render an h4 instead of the default h2.
  static member inline disableTypography(value: bool) = Interop.mkAttr "disableTypography" value


[<Erase>]
type divider =
  /// Absolutely position the element.
  static member inline absolute(value: bool) = Interop.mkAttr "absolute" value
  /// Override or extend the styles applied to the component. Use `classes.divider` to specify class names.
  static member inline classes(classNames: classes.IDividerClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the divider will have a lighter color.
  static member inline light(value: bool) = Interop.mkAttr "light" value

module divider =

  /// The divider orientation.
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline fullWidth = Interop.mkAttr "variant" "fullWidth"
    static member inline inset = Interop.mkAttr "variant" "inset"
    static member inline middle = Interop.mkAttr "variant" "middle"


type drawer =
  /// The contents of the drawer.
  static member inline children(element: ReactElement) = prop.children element
  /// The contents of the drawer.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The contents of the drawer.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The contents of the drawer.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The contents of the drawer.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The contents of the drawer.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.drawer` to specify class names.
  static member inline classes(classNames: classes.IDrawerClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The elevation of the drawer.
  static member inline elevation(value: int) = Interop.mkAttr "elevation" value
  /// Props applied to the [`Modal`](https://material-ui.com/api/modal/) element.
  static member inline ModalProps(props: IReactProperty list) = Interop.mkAttr "ModalProps" (createObj !!props)
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback
  static member inline onClose(handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// If `true`, the drawer is open.
  static member inline open'(value: bool) = Interop.mkAttr "open" value
  /// Props applied to the [`Paper`](https://material-ui.com/api/paper/) element.
  static member inline PaperProps(props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// Props applied to the [`Slide`](https://material-ui.com/api/slide/) element.
  static member inline SlideProps(props: IReactProperty list) = Interop.mkAttr "SlideProps" (createObj !!props)
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration(value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member transitionDuration(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "transitionDuration"

module drawer =

  /// Side from which the drawer will appear.
  [<Erase>]
  type anchor =
    static member inline left = Interop.mkAttr "anchor" "left"
    static member inline top = Interop.mkAttr "anchor" "top"
    static member inline right = Interop.mkAttr "anchor" "right"
    static member inline bottom = Interop.mkAttr "anchor" "bottom"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline permanent = Interop.mkAttr "variant" "permanent"
    static member inline persistent = Interop.mkAttr "variant" "persistent"
    static member inline temporary = Interop.mkAttr "variant" "temporary"


[<Erase>]
type expansionPanel =
  /// The content of the expansion panel.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the expansion panel.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the expansion panel.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the expansion panel.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the expansion panel.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the expansion panel.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.expansionPanel` to specify class names.
  static member inline classes(classNames: classes.IExpansionPanelClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, expands the panel by default.
  static member inline defaultExpanded(value: bool) = Interop.mkAttr "defaultExpanded" value
  /// If `true`, the panel will be displayed in a disabled state.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, expands the panel, otherwise collapse it. Setting this prop enables control over the panel.
  static member inline expanded(value: bool) = Interop.mkAttr "expanded" value
  /// Callback fired when the expand/collapse state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, expanded: boolean) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *expanded:* The `expanded` state of the panel
  static member inline onChange(handler: Event -> bool -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> handler)
  /// Callback fired when the expand/collapse state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, expanded: boolean) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *expanded:* The `expanded` state of the panel
  static member inline onChange(handler: bool -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> (fun _ v -> handler v))
  /// The component used for the collapse effect.
  static member inline TransitionComponent(value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Props applied to the `Transition` element.
  static member inline TransitionProps(props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)


[<Erase>]
type expansionPanelActions =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.expansionPanelActions` to specify class names.
  static member inline classes(classNames: classes.IExpansionPanelActionsClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the actions do not have additional margin.
  static member inline disableSpacing(value: bool) = Interop.mkAttr "disableSpacing" value


[<Erase>]
type expansionPanelDetails =
  /// The content of the expansion panel details.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the expansion panel details.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the expansion panel details.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the expansion panel details.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the expansion panel details.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the expansion panel details.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.expansionPanelDetails` to specify class names.
  static member inline classes(classNames: classes.IExpansionPanelDetailsClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)


[<Erase>]
type expansionPanelSummary =
  /// The content of the expansion panel summary.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the expansion panel summary.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the expansion panel summary.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the expansion panel summary.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the expansion panel summary.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the expansion panel summary.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.expansionPanelSummary` to specify class names.
  static member inline classes(classNames: classes.IExpansionPanelSummaryClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The icon to display as the expand indicator.
  static member inline expandIcon(element: ReactElement) = Interop.mkAttr "expandIcon" element
  /// Props applied to the `IconButton` element wrapping the expand icon.
  static member inline IconButtonProps(props: IReactProperty list) = Interop.mkAttr "IconButtonProps" (createObj !!props)


[<Erase>]
type fab =
  /// The content of the button.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the button.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the button.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the button.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.fab` to specify class names.
  static member inline classes(classNames: classes.IFabClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the button will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the keyboard focus ripple will be disabled. `disableRipple` must also be true.
  static member inline disableFocusRipple(value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple(value: bool) = Interop.mkAttr "disableRipple" value
  /// The URL to link to when the button is clicked. If defined, an `a` element will be used as the root node.
  static member inline href(value: string) = Interop.mkAttr "href" value

module fab =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The size of the button. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline round = Interop.mkAttr "variant" "round"
    static member inline extended = Interop.mkAttr "variant" "extended"


type fade =
  /// A single child content element.
  static member inline children(value: ReactElement) = Interop.mkAttr "children" value
  /// If `true`, the component will transition in.
  static member inline in'(value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout(value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  static member timeout(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "timeout"


[<Erase>]
type filledInput =
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete(value: string) = Interop.mkAttr "autoComplete" value
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus(value: bool) = Interop.mkAttr "autoFocus" value
  /// Override or extend the styles applied to the component. Use `classes.filledInput` to specify class names.
  static member inline classes(classNames: classes.IFilledInputClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The CSS class name of the wrapper element.
  static member inline className(value: string) = Interop.mkAttr "className" value
  /// The default `input` element value. Use when the component is not controlled.
  static member inline defaultValue(value: 'a) = Interop.mkAttr "defaultValue" value
  /// If `true`, the `input` element will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the input will not have an underline.
  static member inline disableUnderline(value: bool) = Interop.mkAttr "disableUnderline" value
  /// End `InputAdornment` for this component.
  static member inline endAdornment(element: ReactElement) = Interop.mkAttr "endAdornment" element
  /// If `true`, the input will indicate an error. This is normally obtained via context from FormControl.
  static member inline error(value: bool) = Interop.mkAttr "error" value
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth(value: bool) = Interop.mkAttr "fullWidth" value
  /// The id of the `input` element.
  static member inline id(value: string) = Interop.mkAttr "id" value
  /// The component used for the native input. Either a string to use a DOM element or a component.
  static member inline inputComponent(value: string) = Interop.mkAttr "inputComponent" value
  /// The component used for the native input. Either a string to use a DOM element or a component.
  static member inline inputComponent(value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps(props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(ref: IRefValue<HTMLInputElement option>) = Interop.mkAttr "inputRef" ref
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(handler: HTMLInputElement -> unit) = Interop.mkAttr "inputRef" handler
  /// If `true`, a textarea element will be rendered.
  static member inline multiline(value: bool) = Interop.mkAttr "multiline" value
  /// Name attribute of the `input` element.
  static member inline name(value: string) = Interop.mkAttr "name" value
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder(value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly(value: bool) = Interop.mkAttr "readOnly" value
  /// If `true`, the `input` element will be required.
  static member inline required(value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows(value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax(value: int) = Interop.mkAttr "rowsMax" value
  /// Start `InputAdornment` for this component.
  static member inline startAdornment(element: ReactElement) = Interop.mkAttr "startAdornment" element
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type'(value: string) = Interop.mkAttr "type" value
  /// The value of the `input` element, required for a controlled component.
  static member inline value(value: 'a) = Interop.mkAttr "value" value

module filledInput =

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


[<Erase>]
type formControl =
  /// The contents of the form control.
  static member inline children(element: ReactElement) = prop.children element
  /// The contents of the form control.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Override or extend the styles applied to the component. Use `classes.formControl` to specify class names.
  static member inline classes(classNames: classes.IFormControlClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the label, input and helper text should be displayed in a disabled state.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the label should be displayed in an error state.
  static member inline error(value: bool) = Interop.mkAttr "error" value
  /// If `true`, the component will take up the full width of its container.
  static member inline fullWidth(value: bool) = Interop.mkAttr "fullWidth" value
  /// If `true`, the label will be hidden. This is used to increase density for a `FilledInput`. Be sure to add `aria-label` to the `input` element.
  static member inline hiddenLabel(value: bool) = Interop.mkAttr "hiddenLabel" value
  /// If `true`, the label will indicate that the input is required.
  static member inline required(value: bool) = Interop.mkAttr "required" value

module formControl =

  /// If `dense` or `normal`, will adjust vertical spacing of this and contained components.
  [<Erase>]
  type margin =
    static member inline none = Interop.mkAttr "margin" "none"
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline normal = Interop.mkAttr "margin" "normal"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline filled = Interop.mkAttr "variant" "filled"


[<Erase>]
type formControlLabel =
  /// If `true`, the component appears selected.
  static member inline checked'(value: bool) = Interop.mkAttr "checked" value
  /// Override or extend the styles applied to the component. Use `classes.formControlLabel` to specify class names.
  static member inline classes(classNames: classes.IFormControlLabelClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// A control element. For instance, it can be be a `Radio`, a `Switch` or a `Checkbox`.
  static member inline control(value: ReactElement) = Interop.mkAttr "control" value
  /// If `true`, the control will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(ref: IRefValue<HTMLInputElement option>) = Interop.mkAttr "inputRef" ref
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(handler: HTMLInputElement -> unit) = Interop.mkAttr "inputRef" handler
  /// The text to be used in an enclosing label element.
  static member inline label(value: ReactElement) = Interop.mkAttr "label" value
  /// The text to be used in an enclosing label element.
  static member inline label(values: ReactElement seq) = Interop.mkAttr "label" values
  /// The text to be used in an enclosing label element.
  static member inline label(value: string) = Interop.mkAttr "label" value
  /// The text to be used in an enclosing label element.
  static member inline label(values: string seq) = Interop.mkAttr "label" values
  /// The text to be used in an enclosing label element.
  static member inline label(value: int) = Interop.mkAttr "label" value
  /// The text to be used in an enclosing label element.
  static member inline label(value: float) = Interop.mkAttr "label" value
  static member inline name(value: string) = Interop.mkAttr "name" value
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, checked: boolean) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.target.checked`.
  ///
  /// *checked:* The `checked` value of the switch
  static member inline onChange(handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, checked: boolean) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.target.checked`.
  ///
  /// *checked:* The `checked` value of the switch
  static member inline onChange(handler: bool -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Checked)
  /// The value of the component.
  static member inline value(value: 'a) = Interop.mkAttr "value" value

module formControlLabel =

  /// The position of the label.
  [<Erase>]
  type labelPlacement =
    static member inline end' = Interop.mkAttr "labelPlacement" "end"
    static member inline start = Interop.mkAttr "labelPlacement" "start"
    static member inline top = Interop.mkAttr "labelPlacement" "top"
    static member inline bottom = Interop.mkAttr "labelPlacement" "bottom"


[<Erase>]
type formGroup =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.formGroup` to specify class names.
  static member inline classes(classNames: classes.IFormGroupClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Display group of elements in a compact row.
  static member inline row(value: bool) = Interop.mkAttr "row" value


[<Erase>]
type formHelperText =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.formHelperText` to specify class names.
  static member inline classes(classNames: classes.IFormHelperTextClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the helper text should be displayed in a disabled state.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, helper text should be displayed in an error state.
  static member inline error(value: bool) = Interop.mkAttr "error" value
  /// If `true`, the helper text should use filled classes key.
  static member inline filled(value: bool) = Interop.mkAttr "filled" value
  /// If `true`, the helper text should use focused classes key.
  static member inline focused(value: bool) = Interop.mkAttr "focused" value
  /// If `true`, the helper text should use required classes key.
  static member inline required(value: bool) = Interop.mkAttr "required" value

module formHelperText =

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline filled = Interop.mkAttr "variant" "filled"


[<Erase>]
type formLabel =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.formLabel` to specify class names.
  static member inline classes(classNames: classes.IFormLabelClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the label should be displayed in a disabled state.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the label should be displayed in an error state.
  static member inline error(value: bool) = Interop.mkAttr "error" value
  /// If `true`, the label should use filled classes key.
  static member inline filled(value: bool) = Interop.mkAttr "filled" value
  /// If `true`, the input of this label is focused (used by `FormGroup` components).
  static member inline focused(value: bool) = Interop.mkAttr "focused" value
  /// If `true`, the label will indicate that the input is required.
  static member inline required(value: bool) = Interop.mkAttr "required" value


[<Erase>]
type grid =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.grid` to specify class names.
  static member inline classes(classNames: classes.IGridClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the component will have the flex *container* behavior. You should be wrapping *items* with a *container*.
  static member inline container(value: bool) = Interop.mkAttr "container" value
  /// If `true`, the component will have the flex *item* behavior. You should be wrapping *items* with a *container*.
  static member inline item(value: bool) = Interop.mkAttr "item" value
  /// If `true`, it sets `min-width: 0` on the item. Refer to the limitations section of the documentation to better understand the use case.
  static member inline zeroMinWidth(value: bool) = Interop.mkAttr "zeroMinWidth" value

module grid =

  /// Defines the `align-content` style property. It's applied for all screen sizes.
  [<Erase>]
  type alignContent =
    static member inline stretch = Interop.mkAttr "alignContent" "stretch"
    static member inline center = Interop.mkAttr "alignContent" "center"
    static member inline flexStart = Interop.mkAttr "alignContent" "flex-start"
    static member inline flexEnd = Interop.mkAttr "alignContent" "flex-end"
    static member inline spaceBetween = Interop.mkAttr "alignContent" "space-between"
    static member inline spaceAround = Interop.mkAttr "alignContent" "space-around"

  /// Defines the `align-items` style property. It's applied for all screen sizes.
  [<Erase>]
  type alignItems =
    static member inline flexStart = Interop.mkAttr "alignItems" "flex-start"
    static member inline center = Interop.mkAttr "alignItems" "center"
    static member inline flexEnd = Interop.mkAttr "alignItems" "flex-end"
    static member inline stretch = Interop.mkAttr "alignItems" "stretch"
    static member inline baseline = Interop.mkAttr "alignItems" "baseline"

  /// Defines the `flex-direction` style property. It is applied for all screen sizes.
  [<Erase>]
  type direction =
    static member inline row = Interop.mkAttr "direction" "row"
    static member inline rowReverse = Interop.mkAttr "direction" "row-reverse"
    static member inline column = Interop.mkAttr "direction" "column"
    static member inline columnReverse = Interop.mkAttr "direction" "column-reverse"

  /// Defines the `justify-content` style property. It is applied for all screen sizes.
  [<Erase>]
  type justify =
    static member inline flexStart = Interop.mkAttr "justify" "flex-start"
    static member inline center = Interop.mkAttr "justify" "center"
    static member inline flexEnd = Interop.mkAttr "justify" "flex-end"
    static member inline spaceBetween = Interop.mkAttr "justify" "space-between"
    static member inline spaceAround = Interop.mkAttr "justify" "space-around"
    static member inline spaceEvenly = Interop.mkAttr "justify" "space-evenly"

  /// Defines the number of grids the component is going to use. It's applied for the `lg` breakpoint and wider screens if not overridden.
  [<Erase>]
  type lg =
    static member inline false' = Interop.mkAttr "lg" false
    static member inline auto = Interop.mkAttr "lg" "auto"
    static member inline true' = Interop.mkAttr "lg" true
    static member inline _1 = Interop.mkAttr "lg" 1
    static member inline _2 = Interop.mkAttr "lg" 2
    static member inline _3 = Interop.mkAttr "lg" 3
    static member inline _4 = Interop.mkAttr "lg" 4
    static member inline _5 = Interop.mkAttr "lg" 5
    static member inline _6 = Interop.mkAttr "lg" 6
    static member inline _7 = Interop.mkAttr "lg" 7
    static member inline _8 = Interop.mkAttr "lg" 8
    static member inline _9 = Interop.mkAttr "lg" 9
    static member inline _10 = Interop.mkAttr "lg" 10
    static member inline _11 = Interop.mkAttr "lg" 11
    static member inline _12 = Interop.mkAttr "lg" 12

  /// Defines the number of grids the component is going to use. It's applied for the `md` breakpoint and wider screens if not overridden.
  [<Erase>]
  type md =
    static member inline false' = Interop.mkAttr "md" false
    static member inline auto = Interop.mkAttr "md" "auto"
    static member inline true' = Interop.mkAttr "md" true
    static member inline _1 = Interop.mkAttr "md" 1
    static member inline _2 = Interop.mkAttr "md" 2
    static member inline _3 = Interop.mkAttr "md" 3
    static member inline _4 = Interop.mkAttr "md" 4
    static member inline _5 = Interop.mkAttr "md" 5
    static member inline _6 = Interop.mkAttr "md" 6
    static member inline _7 = Interop.mkAttr "md" 7
    static member inline _8 = Interop.mkAttr "md" 8
    static member inline _9 = Interop.mkAttr "md" 9
    static member inline _10 = Interop.mkAttr "md" 10
    static member inline _11 = Interop.mkAttr "md" 11
    static member inline _12 = Interop.mkAttr "md" 12

  /// Defines the number of grids the component is going to use. It's applied for the `sm` breakpoint and wider screens if not overridden.
  [<Erase>]
  type sm =
    static member inline false' = Interop.mkAttr "sm" false
    static member inline auto = Interop.mkAttr "sm" "auto"
    static member inline true' = Interop.mkAttr "sm" true
    static member inline _1 = Interop.mkAttr "sm" 1
    static member inline _2 = Interop.mkAttr "sm" 2
    static member inline _3 = Interop.mkAttr "sm" 3
    static member inline _4 = Interop.mkAttr "sm" 4
    static member inline _5 = Interop.mkAttr "sm" 5
    static member inline _6 = Interop.mkAttr "sm" 6
    static member inline _7 = Interop.mkAttr "sm" 7
    static member inline _8 = Interop.mkAttr "sm" 8
    static member inline _9 = Interop.mkAttr "sm" 9
    static member inline _10 = Interop.mkAttr "sm" 10
    static member inline _11 = Interop.mkAttr "sm" 11
    static member inline _12 = Interop.mkAttr "sm" 12

  /// Defines the space between the type `item` component. It can only be used on a type `container` component.
  [<Erase>]
  type spacing =
    static member inline _0 = Interop.mkAttr "spacing" 0
    static member inline _1 = Interop.mkAttr "spacing" 1
    static member inline _2 = Interop.mkAttr "spacing" 2
    static member inline _3 = Interop.mkAttr "spacing" 3
    static member inline _4 = Interop.mkAttr "spacing" 4
    static member inline _5 = Interop.mkAttr "spacing" 5
    static member inline _6 = Interop.mkAttr "spacing" 6
    static member inline _7 = Interop.mkAttr "spacing" 7
    static member inline _8 = Interop.mkAttr "spacing" 8
    static member inline _9 = Interop.mkAttr "spacing" 9
    static member inline _10 = Interop.mkAttr "spacing" 10

  /// Defines the `flex-wrap` style property. It's applied for all screen sizes.
  [<Erase>]
  type wrap =
    static member inline nowrap = Interop.mkAttr "wrap" "nowrap"
    static member inline wrap = Interop.mkAttr "wrap" "wrap"
    static member inline wrapReverse = Interop.mkAttr "wrap" "wrap-reverse"

  /// Defines the number of grids the component is going to use. It's applied for the `xl` breakpoint and wider screens.
  [<Erase>]
  type xl =
    static member inline false' = Interop.mkAttr "xl" false
    static member inline auto = Interop.mkAttr "xl" "auto"
    static member inline true' = Interop.mkAttr "xl" true
    static member inline _1 = Interop.mkAttr "xl" 1
    static member inline _2 = Interop.mkAttr "xl" 2
    static member inline _3 = Interop.mkAttr "xl" 3
    static member inline _4 = Interop.mkAttr "xl" 4
    static member inline _5 = Interop.mkAttr "xl" 5
    static member inline _6 = Interop.mkAttr "xl" 6
    static member inline _7 = Interop.mkAttr "xl" 7
    static member inline _8 = Interop.mkAttr "xl" 8
    static member inline _9 = Interop.mkAttr "xl" 9
    static member inline _10 = Interop.mkAttr "xl" 10
    static member inline _11 = Interop.mkAttr "xl" 11
    static member inline _12 = Interop.mkAttr "xl" 12

  /// Defines the number of grids the component is going to use. It's applied for all the screen sizes with the lowest priority.
  [<Erase>]
  type xs =
    static member inline false' = Interop.mkAttr "xs" false
    static member inline auto = Interop.mkAttr "xs" "auto"
    static member inline true' = Interop.mkAttr "xs" true
    static member inline _1 = Interop.mkAttr "xs" 1
    static member inline _2 = Interop.mkAttr "xs" 2
    static member inline _3 = Interop.mkAttr "xs" 3
    static member inline _4 = Interop.mkAttr "xs" 4
    static member inline _5 = Interop.mkAttr "xs" 5
    static member inline _6 = Interop.mkAttr "xs" 6
    static member inline _7 = Interop.mkAttr "xs" 7
    static member inline _8 = Interop.mkAttr "xs" 8
    static member inline _9 = Interop.mkAttr "xs" 9
    static member inline _10 = Interop.mkAttr "xs" 10
    static member inline _11 = Interop.mkAttr "xs" 11
    static member inline _12 = Interop.mkAttr "xs" 12


[<Erase>]
type gridList =
  /// Number of px for one cell height. You can set `'auto'` if you want to let the children determine the height.
  static member inline cellHeight(value: int) = Interop.mkAttr "cellHeight" value
  /// Grid Tiles that will be in Grid List.
  static member inline children(element: ReactElement) = prop.children element
  /// Grid Tiles that will be in Grid List.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Grid Tiles that will be in Grid List.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Grid Tiles that will be in Grid List.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Grid Tiles that will be in Grid List.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Grid Tiles that will be in Grid List.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.gridList` to specify class names.
  static member inline classes(classNames: classes.IGridListClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Number of columns.
  static member inline cols(value: int) = Interop.mkAttr "cols" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Number of px for the spacing between tiles.
  static member inline spacing(value: int) = Interop.mkAttr "spacing" value

module gridList =

  /// Number of px for one cell height. You can set `'auto'` if you want to let the children determine the height.
  [<Erase>]
  type cellHeight =
    static member inline auto = Interop.mkAttr "cellHeight" "auto"


[<Erase>]
type gridListTile =
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children(element: ReactElement) = prop.children element
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Theoretically you can pass any node as children, but the main use case is to pass an img, in which case GridListTile takes care of making the image "cover" available space (similar to `background-size: cover` or to `object-fit: cover`).
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.gridListTile` to specify class names.
  static member inline classes(classNames: classes.IGridListTileClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Width of the tile in number of grid cells.
  static member inline cols(value: int) = Interop.mkAttr "cols" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Height of the tile in number of grid cells.
  static member inline rows(value: int) = Interop.mkAttr "rows" value


[<Erase>]
type gridListTileBar =
  /// An IconButton element to be used as secondary action target (primary action target is the tile itself).
  static member inline actionIcon(element: ReactElement) = Interop.mkAttr "actionIcon" element
  /// Override or extend the styles applied to the component. Use `classes.gridListTileBar` to specify class names.
  static member inline classes(classNames: classes.IGridListTileBarClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// String or element serving as subtitle (support text).
  static member inline subtitle(value: ReactElement) = Interop.mkAttr "subtitle" value
  /// String or element serving as subtitle (support text).
  static member inline subtitle(values: ReactElement seq) = Interop.mkAttr "subtitle" values
  /// String or element serving as subtitle (support text).
  static member inline subtitle(value: string) = Interop.mkAttr "subtitle" value
  /// String or element serving as subtitle (support text).
  static member inline subtitle(values: string seq) = Interop.mkAttr "subtitle" values
  /// String or element serving as subtitle (support text).
  static member inline subtitle(value: int) = Interop.mkAttr "subtitle" value
  /// String or element serving as subtitle (support text).
  static member inline subtitle(value: float) = Interop.mkAttr "subtitle" value
  /// Title to be displayed on tile.
  static member inline title(value: ReactElement) = Interop.mkAttr "title" value
  /// Title to be displayed on tile.
  static member inline title(values: ReactElement seq) = Interop.mkAttr "title" values
  /// Title to be displayed on tile.
  static member inline title(value: string) = Interop.mkAttr "title" value
  /// Title to be displayed on tile.
  static member inline title(values: string seq) = Interop.mkAttr "title" values
  /// Title to be displayed on tile.
  static member inline title(value: int) = Interop.mkAttr "title" value
  /// Title to be displayed on tile.
  static member inline title(value: float) = Interop.mkAttr "title" value

module gridListTileBar =

  /// Position of secondary action IconButton.
  [<Erase>]
  type actionPosition =
    static member inline left = Interop.mkAttr "actionPosition" "left"
    static member inline right = Interop.mkAttr "actionPosition" "right"

  /// Position of the title bar.
  [<Erase>]
  type titlePosition =
    static member inline top = Interop.mkAttr "titlePosition" "top"
    static member inline bottom = Interop.mkAttr "titlePosition" "bottom"


type grow =
  /// A single child content element.
  static member inline children(value: ReactElement) = Interop.mkAttr "children" value
  /// If `true`, show the component; triggers the enter or exit animation.
  static member inline in'(value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline timeout(value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member timeout(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "timeout"

module grow =

  /// The duration for the transition, in milliseconds.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  [<Erase>]
  type timeout =
    static member inline auto = Interop.mkAttr "timeout" "auto"


[<Erase>]
type hidden =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// If true, screens this size and down will be hidden.
  static member inline lgDown(value: bool) = Interop.mkAttr "lgDown" value
  /// If true, screens this size and up will be hidden.
  static member inline lgUp(value: bool) = Interop.mkAttr "lgUp" value
  /// If true, screens this size and down will be hidden.
  static member inline mdDown(value: bool) = Interop.mkAttr "mdDown" value
  /// If true, screens this size and up will be hidden.
  static member inline mdUp(value: bool) = Interop.mkAttr "mdUp" value
  /// Hide the given breakpoint(s).
  static member inline only([<ParamArray>] values: BreakpointKey []) = Interop.mkAttr "only" values
  /// If true, screens this size and down will be hidden.
  static member inline smDown(value: bool) = Interop.mkAttr "smDown" value
  /// If true, screens this size and up will be hidden.
  static member inline smUp(value: bool) = Interop.mkAttr "smUp" value
  /// If true, screens this size and down will be hidden.
  static member inline xlDown(value: bool) = Interop.mkAttr "xlDown" value
  /// If true, screens this size and up will be hidden.
  static member inline xlUp(value: bool) = Interop.mkAttr "xlUp" value
  /// If true, screens this size and down will be hidden.
  static member inline xsDown(value: bool) = Interop.mkAttr "xsDown" value
  /// If true, screens this size and up will be hidden.
  static member inline xsUp(value: bool) = Interop.mkAttr "xsUp" value

module hidden =

  /// Specify which implementation to use. 'js' is the default, 'css' works better for server-side rendering.
  [<Erase>]
  type implementation =
    static member inline js = Interop.mkAttr "implementation" "js"
    static member inline css = Interop.mkAttr "implementation" "css"

  /// You can use this prop when choosing the `js` implementation with server-side rendering.
  ///
  /// As `window.innerWidth` is unavailable on the server, we default to rendering an empty component during the first mount. You might want to use an heuristic to approximate the screen width of the client browser screen width.
  ///
  /// For instance, you could be using the user-agent or the client-hints. https://caniuse.com/#search=client%20hint
  [<Erase>]
  type initialWidth =
    static member inline xs = Interop.mkAttr "initialWidth" "xs"
    static member inline sm = Interop.mkAttr "initialWidth" "sm"
    static member inline md = Interop.mkAttr "initialWidth" "md"
    static member inline lg = Interop.mkAttr "initialWidth" "lg"
    static member inline xl = Interop.mkAttr "initialWidth" "xl"

  /// Hide the given breakpoint(s).
  [<Erase>]
  type only =
    static member inline xs = Interop.mkAttr "only" "xs"
    static member inline sm = Interop.mkAttr "only" "sm"
    static member inline md = Interop.mkAttr "only" "md"
    static member inline lg = Interop.mkAttr "only" "lg"
    static member inline xl = Interop.mkAttr "only" "xl"


[<Erase>]
type icon =
  /// The name of the icon font ligature.
  static member inline children(element: ReactElement) = prop.children element
  /// The name of the icon font ligature.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The name of the icon font ligature.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The name of the icon font ligature.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The name of the icon font ligature.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The name of the icon font ligature.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.icon` to specify class names.
  static member inline classes(classNames: classes.IIconClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value

module icon =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline action = Interop.mkAttr "color" "action"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline disabled = Interop.mkAttr "color" "disabled"

  /// The fontSize applied to the icon. Defaults to 24px, but can be configure to inherit font size.
  [<Erase>]
  type fontSize =
    static member inline inherit' = Interop.mkAttr "fontSize" "inherit"
    static member inline default' = Interop.mkAttr "fontSize" "default"
    static member inline small = Interop.mkAttr "fontSize" "small"
    static member inline large = Interop.mkAttr "fontSize" "large"


[<Erase>]
type iconButton =
  /// The icon element.
  static member inline children(element: ReactElement) = prop.children element
  /// The icon element.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The icon element.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The icon element.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The icon element.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The icon element.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.iconButton` to specify class names.
  static member inline classes(classNames: classes.IIconButtonClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the button will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the keyboard focus ripple will be disabled. `disableRipple` must also be true.
  static member inline disableFocusRipple(value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple(value: bool) = Interop.mkAttr "disableRipple" value

module iconButton =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// If given, uses a negative margin to counteract the padding on one side (this is often helpful for aligning the left or right side of the icon with content above or below, without ruining the border size and shape).
  [<Erase>]
  type edge =
    static member inline start = Interop.mkAttr "edge" "start"
    static member inline end' = Interop.mkAttr "edge" "end"
    static member inline false' = Interop.mkAttr "edge" false

  /// The size of the button. `small` is equivalent to the dense button styling.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"


[<Erase>]
type input =
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete(value: string) = Interop.mkAttr "autoComplete" value
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus(value: bool) = Interop.mkAttr "autoFocus" value
  /// Override or extend the styles applied to the component. Use `classes.input` to specify class names.
  static member inline classes(classNames: classes.IInputClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The CSS class name of the wrapper element.
  static member inline className(value: string) = Interop.mkAttr "className" value
  /// The default `input` element value. Use when the component is not controlled.
  static member inline defaultValue(value: 'a) = Interop.mkAttr "defaultValue" value
  /// If `true`, the `input` element will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the input will not have an underline.
  static member inline disableUnderline(value: bool) = Interop.mkAttr "disableUnderline" value
  /// End `InputAdornment` for this component.
  static member inline endAdornment(element: ReactElement) = Interop.mkAttr "endAdornment" element
  /// If `true`, the input will indicate an error. This is normally obtained via context from FormControl.
  static member inline error(value: bool) = Interop.mkAttr "error" value
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth(value: bool) = Interop.mkAttr "fullWidth" value
  /// The id of the `input` element.
  static member inline id(value: string) = Interop.mkAttr "id" value
  /// The component used for the native input. Either a string to use a DOM element or a component.
  static member inline inputComponent(value: string) = Interop.mkAttr "inputComponent" value
  /// The component used for the native input. Either a string to use a DOM element or a component.
  static member inline inputComponent(value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps(props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(ref: IRefValue<HTMLInputElement option>) = Interop.mkAttr "inputRef" ref
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(handler: HTMLInputElement -> unit) = Interop.mkAttr "inputRef" handler
  /// If `true`, a textarea element will be rendered.
  static member inline multiline(value: bool) = Interop.mkAttr "multiline" value
  /// Name attribute of the `input` element.
  static member inline name(value: string) = Interop.mkAttr "name" value
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder(value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly(value: bool) = Interop.mkAttr "readOnly" value
  /// If `true`, the `input` element will be required.
  static member inline required(value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows(value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax(value: int) = Interop.mkAttr "rowsMax" value
  /// Start `InputAdornment` for this component.
  static member inline startAdornment(element: ReactElement) = Interop.mkAttr "startAdornment" element
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type'(value: string) = Interop.mkAttr "type" value
  /// The value of the `input` element, required for a controlled component.
  static member inline value(value: 'a) = Interop.mkAttr "value" value

module input =

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


[<Erase>]
type inputAdornment =
  /// The content of the component, normally an `IconButton` or string.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component, normally an `IconButton` or string.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component, normally an `IconButton` or string.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component, normally an `IconButton` or string.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component, normally an `IconButton` or string.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component, normally an `IconButton` or string.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.inputAdornment` to specify class names.
  static member inline classes(classNames: classes.IInputAdornmentClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Disable pointer events on the root. This allows for the content of the adornment to focus the input on click.
  static member inline disablePointerEvents(value: bool) = Interop.mkAttr "disablePointerEvents" value
  /// If children is a string then disable wrapping in a Typography component.
  static member inline disableTypography(value: bool) = Interop.mkAttr "disableTypography" value

module inputAdornment =

  /// The position this adornment should appear relative to the `Input`.
  [<Erase>]
  type position =
    static member inline start = Interop.mkAttr "position" "start"
    static member inline end' = Interop.mkAttr "position" "end"

  /// The variant to use. Note: If you are using the `TextField` component or the `FormControl` component you do not have to set this manually.
  [<Erase>]
  type variant =
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline filled = Interop.mkAttr "variant" "filled"


[<Erase>]
type inputBase =
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete(value: string) = Interop.mkAttr "autoComplete" value
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus(value: bool) = Interop.mkAttr "autoFocus" value
  /// Override or extend the styles applied to the component. Use `classes.inputBase` to specify class names.
  static member inline classes(classNames: classes.IInputBaseClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The CSS class name of the wrapper element.
  static member inline className(value: string) = Interop.mkAttr "className" value
  /// The default `input` element value. Use when the component is not controlled.
  static member inline defaultValue(value: 'a) = Interop.mkAttr "defaultValue" value
  /// If `true`, the `input` element will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// End `InputAdornment` for this component.
  static member inline endAdornment(element: ReactElement) = Interop.mkAttr "endAdornment" element
  /// If `true`, the input will indicate an error. This is normally obtained via context from FormControl.
  static member inline error(value: bool) = Interop.mkAttr "error" value
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth(value: bool) = Interop.mkAttr "fullWidth" value
  /// The id of the `input` element.
  static member inline id(value: string) = Interop.mkAttr "id" value
  /// The component used for the `input` element. Either a string to use a DOM element or a component.
  static member inline inputComponent(value: string) = Interop.mkAttr "inputComponent" value
  /// The component used for the `input` element. Either a string to use a DOM element or a component.
  static member inline inputComponent(value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps(props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(ref: IRefValue<HTMLInputElement option>) = Interop.mkAttr "inputRef" ref
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(handler: HTMLInputElement -> unit) = Interop.mkAttr "inputRef" handler
  /// If `true`, a textarea element will be rendered.
  static member inline multiline(value: bool) = Interop.mkAttr "multiline" value
  /// Name attribute of the `input` element.
  static member inline name(value: string) = Interop.mkAttr "name" value
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder(value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly(value: bool) = Interop.mkAttr "readOnly" value
  /// If `true`, the `input` element will be required.
  static member inline required(value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows(value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax(value: int) = Interop.mkAttr "rowsMax" value
  /// Should be `true` when the component hosts a select.
  static member inline select(value: bool) = Interop.mkAttr "select" value
  /// Start `InputAdornment` for this component.
  static member inline startAdornment(element: ReactElement) = Interop.mkAttr "startAdornment" element
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type'(value: string) = Interop.mkAttr "type" value
  /// The value of the `input` element, required for a controlled component.
  static member inline value(value: 'a) = Interop.mkAttr "value" value

module inputBase =

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


[<Erase>]
type inputLabel =
  /// The contents of the `InputLabel`.
  static member inline children(element: ReactElement) = prop.children element
  /// The contents of the `InputLabel`.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The contents of the `InputLabel`.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The contents of the `InputLabel`.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The contents of the `InputLabel`.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The contents of the `InputLabel`.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.inputLabel` to specify class names.
  static member inline classes(classNames: classes.IInputLabelClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the transition animation is disabled.
  static member inline disableAnimation(value: bool) = Interop.mkAttr "disableAnimation" value
  /// If `true`, apply disabled class.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the label will be displayed in an error state.
  static member inline error(value: bool) = Interop.mkAttr "error" value
  /// If `true`, the input of this label is focused.
  static member inline focused(value: bool) = Interop.mkAttr "focused" value
  /// if `true`, the label will indicate that the input is required.
  static member inline required(value: bool) = Interop.mkAttr "required" value
  /// If `true`, the label is shrunk.
  static member inline shrink(value: bool) = Interop.mkAttr "shrink" value

module inputLabel =

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline filled = Interop.mkAttr "variant" "filled"


[<Erase>]
type linearProgress =
  /// Override or extend the styles applied to the component. Use `classes.linearProgress` to specify class names.
  static member inline classes(classNames: classes.ILinearProgressClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The value of the progress indicator for the determinate and buffer variants. Value between 0 and 100.
  static member inline value(value: int) = Interop.mkAttr "value" value
  /// The value for the buffer variant. Value between 0 and 100.
  static member inline valueBuffer(value: int) = Interop.mkAttr "valueBuffer" value

module linearProgress =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"

  /// The variant to use. Use indeterminate or query when there is no progress value.
  [<Erase>]
  type variant =
    static member inline determinate = Interop.mkAttr "variant" "determinate"
    static member inline indeterminate = Interop.mkAttr "variant" "indeterminate"
    static member inline buffer = Interop.mkAttr "variant" "buffer"
    static member inline query = Interop.mkAttr "variant" "query"


[<Erase>]
type link =
  /// The content of the link.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the link.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the link.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the link.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the link.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the link.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.link` to specify class names.
  static member inline classes(classNames: classes.ILinkClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// `classes` prop applied to the [`Typography`](https://material-ui.com/api/typography/) element.
  static member inline TypographyClasses(classNames: classes.ITypographyClasses list) = Interop.mkAttr "TypographyClasses" (createObj !!classNames)
  /// Applies the theme typography styles.
  static member inline variant(value: string) = Interop.mkAttr "variant" value

module link =

  /// The color of the link.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline textPrimary = Interop.mkAttr "color" "textPrimary"
    static member inline textSecondary = Interop.mkAttr "color" "textSecondary"

  /// Controls when the link should have an underline.
  [<Erase>]
  type underline =
    static member inline none = Interop.mkAttr "underline" "none"
    static member inline hover = Interop.mkAttr "underline" "hover"
    static member inline always = Interop.mkAttr "underline" "always"


[<Erase>]
type list =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.list` to specify class names.
  static member inline classes(classNames: classes.IListClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, compact vertical padding designed for keyboard and mouse input will be used for the list and list items. The prop is available to descendant components as the `dense` context.
  static member inline dense(value: bool) = Interop.mkAttr "dense" value
  /// If `true`, vertical padding will be removed from the list.
  static member inline disablePadding(value: bool) = Interop.mkAttr "disablePadding" value
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader(value: ReactElement) = Interop.mkAttr "subheader" value
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader(values: ReactElement seq) = Interop.mkAttr "subheader" values
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader(value: string) = Interop.mkAttr "subheader" value
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader(values: string seq) = Interop.mkAttr "subheader" values
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader(value: int) = Interop.mkAttr "subheader" value
  /// The content of the subheader, normally `ListSubheader`.
  static member inline subheader(value: float) = Interop.mkAttr "subheader" value


[<Erase>]
type listItem =
  /// If `true`, the list item will be focused during the first mount. Focus will also be triggered if the value changes from false to true.
  static member inline autoFocus(value: bool) = Interop.mkAttr "autoFocus" value
  /// If `true`, the list item will be a button (using `ButtonBase`).
  static member inline button(value: bool) = Interop.mkAttr "button" value
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component. If a `ListItemSecondaryAction` is used it must be the last child.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.listItem` to specify class names.
  static member inline classes(classNames: classes.IListItemClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component. By default, it's a `li` when `button` is `false` and a `div` when `button` is `true`.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component. By default, it's a `li` when `button` is `false` and a `div` when `button` is `true`.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// The container component used when a `ListItemSecondaryAction` is the last child.
  static member inline ContainerComponent(value: ReactElementType) = Interop.mkAttr "ContainerComponent" value
  /// Props applied to the container component if used.
  static member inline ContainerProps(props: IReactProperty list) = Interop.mkAttr "ContainerProps" (createObj !!props)
  /// If `true`, compact vertical padding designed for keyboard and mouse input will be used.
  static member inline dense(value: bool) = Interop.mkAttr "dense" value
  /// If `true`, the list item will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the left and right padding is removed.
  static member inline disableGutters(value: bool) = Interop.mkAttr "disableGutters" value
  /// If `true`, a 1px light border is added to the bottom of the list item.
  static member inline divider(value: bool) = Interop.mkAttr "divider" value
  /// Use to apply selected styling.
  static member inline selected(value: bool) = Interop.mkAttr "selected" value

module listItem =

  /// Defines the `align-items` style property.
  [<Erase>]
  type alignItems =
    static member inline flexStart = Interop.mkAttr "alignItems" "flex-start"
    static member inline center = Interop.mkAttr "alignItems" "center"


[<Erase>]
type listItemAvatar =
  /// The content of the component – normally `Avatar`.
  static member inline children(value: ReactElement) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.listItemAvatar` to specify class names.
  static member inline classes(classNames: classes.IListItemAvatarClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)


[<Erase>]
type listItemIcon =
  /// The content of the component, normally `Icon`, `SvgIcon`, or a `@material-ui/icons` SVG icon element.
  static member inline children(value: ReactElement) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.listItemIcon` to specify class names.
  static member inline classes(classNames: classes.IListItemIconClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)


[<Erase>]
type listItemSecondaryAction =
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component, normally an `IconButton` or selection control.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.listItemSecondaryAction` to specify class names.
  static member inline classes(classNames: classes.IListItemSecondaryActionClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)


[<Erase>]
type listItemText =
  /// Alias for the `primary` property.
  static member inline children(element: ReactElement) = prop.children element
  /// Alias for the `primary` property.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Alias for the `primary` property.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Alias for the `primary` property.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Alias for the `primary` property.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Alias for the `primary` property.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.listItemText` to specify class names.
  static member inline classes(classNames: classes.IListItemTextClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the children won't be wrapped by a Typography component. This can be useful to render an alternative Typography variant by wrapping the `children` (or `primary`) text, and optional `secondary` text with the Typography component.
  static member inline disableTypography(value: bool) = Interop.mkAttr "disableTypography" value
  /// If `true`, the children will be indented. This should be used if there is no left avatar or left icon.
  static member inline inset(value: bool) = Interop.mkAttr "inset" value
  /// The main content element.
  static member inline primary(value: ReactElement) = Interop.mkAttr "primary" value
  /// The main content element.
  static member inline primary(values: ReactElement seq) = Interop.mkAttr "primary" values
  /// The main content element.
  static member inline primary(value: string) = Interop.mkAttr "primary" value
  /// The main content element.
  static member inline primary(values: string seq) = Interop.mkAttr "primary" values
  /// The main content element.
  static member inline primary(value: int) = Interop.mkAttr "primary" value
  /// The main content element.
  static member inline primary(value: float) = Interop.mkAttr "primary" value
  /// These props will be forwarded to the primary typography component (as long as disableTypography is not `true`).
  static member inline primaryTypographyProps(props: IReactProperty list) = Interop.mkAttr "primaryTypographyProps" (createObj !!props)
  /// The secondary content element.
  static member inline secondary(value: ReactElement) = Interop.mkAttr "secondary" value
  /// The secondary content element.
  static member inline secondary(values: ReactElement seq) = Interop.mkAttr "secondary" values
  /// The secondary content element.
  static member inline secondary(value: string) = Interop.mkAttr "secondary" value
  /// The secondary content element.
  static member inline secondary(values: string seq) = Interop.mkAttr "secondary" values
  /// The secondary content element.
  static member inline secondary(value: int) = Interop.mkAttr "secondary" value
  /// The secondary content element.
  static member inline secondary(value: float) = Interop.mkAttr "secondary" value
  /// These props will be forwarded to the secondary typography component (as long as disableTypography is not `true`).
  static member inline secondaryTypographyProps(props: IReactProperty list) = Interop.mkAttr "secondaryTypographyProps" (createObj !!props)


[<Erase>]
type listSubheader =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.listSubheader` to specify class names.
  static member inline classes(classNames: classes.IListSubheaderClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the List Subheader will not have gutters.
  static member inline disableGutters(value: bool) = Interop.mkAttr "disableGutters" value
  /// If `true`, the List Subheader will not stick to the top during scroll.
  static member inline disableSticky(value: bool) = Interop.mkAttr "disableSticky" value
  /// If `true`, the List Subheader will be indented.
  static member inline inset(value: bool) = Interop.mkAttr "inset" value

module listSubheader =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline default' = Interop.mkAttr "color" "default"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline inherit' = Interop.mkAttr "color" "inherit"


type menu =
  /// The DOM element used to set the position of the menu.
  static member inline anchorEl(value: Element option) = Interop.mkAttr "anchorEl" value
  /// The DOM element used to set the position of the menu.
  static member inline anchorEl(handler: unit -> Element option) = Interop.mkAttr "anchorEl" handler
  /// The DOM element used to set the position of the menu.
  static member inline anchorEl(ref: IRefValue<Element option>) = Interop.mkAttr "anchorEl" (fun () -> ref.current)
  /// If `true` (default), the menu list (possibly a particular item depending on the menu variant) will receive focus on open.
  static member inline autoFocus(value: bool) = Interop.mkAttr "autoFocus" value
  /// Menu contents, normally `MenuItem`s.
  static member inline children(element: ReactElement) = prop.children element
  /// Menu contents, normally `MenuItem`s.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Menu contents, normally `MenuItem`s.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Menu contents, normally `MenuItem`s.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Menu contents, normally `MenuItem`s.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Menu contents, normally `MenuItem`s.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.menu` to specify class names.
  static member inline classes(classNames: classes.IMenuClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Same as `autoFocus=false`.
  static member inline disableAutoFocusItem(value: bool) = Interop.mkAttr "disableAutoFocusItem" value
  /// Props applied to the [`MenuList`](https://material-ui.com/api/menu-list/) element.
  static member inline MenuListProps(props: IReactProperty list) = Interop.mkAttr "MenuListProps" (createObj !!props)
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *reason:* Can be:`"escapeKeyDown"`, `"backdropClick"`, `"tabKeyDown"`
  static member inline onClose(handler: Event -> MenuCloseReason -> unit) = Interop.mkAttr "onClose" (System.Func<_,_,_> handler)
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *reason:* Can be:`"escapeKeyDown"`, `"backdropClick"`, `"tabKeyDown"`
  static member inline onClose(handler: MenuCloseReason -> unit) = Interop.mkAttr "onClose" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired before the Menu enters.
  static member inline onEnter(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEnter" handler
  /// Callback fired when the Menu has entered.
  static member inline onEntered(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntered" handler
  /// Callback fired when the Menu is entering.
  static member inline onEntering(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntering" handler
  /// Callback fired before the Menu exits.
  static member inline onExit(handler: ReactElement -> unit) = Interop.mkAttr "onExit" handler
  /// Callback fired when the Menu has exited.
  static member inline onExited(handler: ReactElement -> unit) = Interop.mkAttr "onExited" handler
  /// Callback fired when the Menu is exiting.
  static member inline onExiting(handler: ReactElement -> unit) = Interop.mkAttr "onExiting" handler
  /// If `true`, the menu is visible.
  static member inline open'(value: bool) = Interop.mkAttr "open" value
  /// `classes` prop applied to the [`Popover`](https://material-ui.com/api/popover/) element.
  static member inline PopoverClasses(classNames: classes.IPopoverClasses list) = Interop.mkAttr "PopoverClasses" (createObj !!classNames)
  /// The length of the transition in `ms`, or 'auto'
  static member inline transitionDuration(value: int) = Interop.mkAttr "transitionDuration" value
  /// The length of the transition in `ms`, or 'auto'
  static member transitionDuration(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "transitionDuration"

module menu =

  /// The length of the transition in `ms`, or 'auto'
  [<Erase>]
  type transitionDuration =
    static member inline auto = Interop.mkAttr "transitionDuration" "auto"

  /// The variant to use. Use `menu` to prevent selected items from impacting the initial focus and the vertical alignment relative to the anchor element.
  [<Erase>]
  type variant =
    static member inline menu = Interop.mkAttr "variant" "menu"
    static member inline selectedMenu = Interop.mkAttr "variant" "selectedMenu"


[<Erase>]
type menuItem =
  /// Menu item contents.
  static member inline children(element: ReactElement) = prop.children element
  /// Menu item contents.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Menu item contents.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Menu item contents.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Menu item contents.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Menu item contents.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.menuItem` to specify class names.
  static member inline classes(classNames: classes.IMenuItemClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, compact vertical padding designed for keyboard and mouse input will be used.
  static member inline dense(value: bool) = Interop.mkAttr "dense" value
  /// If `true`, the left and right padding is removed.
  static member inline disableGutters(value: bool) = Interop.mkAttr "disableGutters" value


[<Erase>]
type menuList =
  /// If `true`, the list will be focused during the first mount. Focus will also be triggered if the value changes from false to true.
  static member inline autoFocus(value: bool) = Interop.mkAttr "autoFocus" value
  /// MenuList contents, normally `MenuItem`s.
  static member inline children(element: ReactElement) = prop.children element
  /// MenuList contents, normally `MenuItem`s.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// MenuList contents, normally `MenuItem`s.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// MenuList contents, normally `MenuItem`s.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// MenuList contents, normally `MenuItem`s.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// MenuList contents, normally `MenuItem`s.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// If `true`, the menu items will not wrap focus.
  static member inline disableListWrap(value: bool) = Interop.mkAttr "disableListWrap" value


[<Erase>]
type mobileStepper =
  /// Set the active step (zero based index). Defines which dot is highlighted when the variant is 'dots'.
  static member inline activeStep(value: int) = Interop.mkAttr "activeStep" value
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton(value: ReactElement) = Interop.mkAttr "backButton" value
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton(values: ReactElement seq) = Interop.mkAttr "backButton" values
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton(value: string) = Interop.mkAttr "backButton" value
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton(values: string seq) = Interop.mkAttr "backButton" values
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton(value: int) = Interop.mkAttr "backButton" value
  /// A back button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline backButton(value: float) = Interop.mkAttr "backButton" value
  /// Override or extend the styles applied to the component. Use `classes.mobileStepper` to specify class names.
  static member inline classes(classNames: classes.IMobileStepperClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Props applied to the `LinearProgress` element.
  static member inline LinearProgressProps(props: IReactProperty list) = Interop.mkAttr "LinearProgressProps" (createObj !!props)
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton(value: ReactElement) = Interop.mkAttr "nextButton" value
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton(values: ReactElement seq) = Interop.mkAttr "nextButton" values
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton(value: string) = Interop.mkAttr "nextButton" value
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton(values: string seq) = Interop.mkAttr "nextButton" values
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton(value: int) = Interop.mkAttr "nextButton" value
  /// A next button element. For instance, it can be a `Button` or an `IconButton`.
  static member inline nextButton(value: float) = Interop.mkAttr "nextButton" value
  /// The total steps.
  static member inline steps(value: int) = Interop.mkAttr "steps" value

module mobileStepper =

  /// Set the positioning type.
  [<Erase>]
  type position =
    static member inline bottom = Interop.mkAttr "position" "bottom"
    static member inline top = Interop.mkAttr "position" "top"
    static member inline static' = Interop.mkAttr "position" "static"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline text = Interop.mkAttr "variant" "text"
    static member inline dots = Interop.mkAttr "variant" "dots"
    static member inline progress = Interop.mkAttr "variant" "progress"


[<Erase>]
type modal =
  /// A backdrop component. This prop enables custom backdrop rendering.
  static member inline BackdropComponent(value: ReactElementType) = Interop.mkAttr "BackdropComponent" value
  /// Props applied to the [`Backdrop`](https://material-ui.com/api/backdrop/) element.
  static member inline BackdropProps(props: IReactProperty list) = Interop.mkAttr "BackdropProps" (createObj !!props)
  /// A single child content element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline children(value: ReactElement) = Interop.mkAttr "children" value
  /// When set to true the Modal waits until a nested Transition is completed before closing.
  static member inline closeAfterTransition(value: bool) = Interop.mkAttr "closeAfterTransition" value
  /// A node, component instance, or function that returns either. The `container` will have the portal children appended to it.
  static member inline container(element: Element option) = Interop.mkAttr "container" element
  /// A node, component instance, or function that returns either. The `container` will have the portal children appended to it.
  static member inline container(element: ReactElement option) = Interop.mkAttr "container" element
  /// A node, component instance, or function that returns either. The `container` will have the portal children appended to it.
  static member inline container(getElement: unit -> Element option) = Interop.mkAttr "container" getElement
  /// A node, component instance, or function that returns either. The `container` will have the portal children appended to it.
  static member inline container(getElement: unit -> ReactElement option) = Interop.mkAttr "container" getElement
  /// If `true`, the modal will not automatically shift focus to itself when it opens, and replace it to the last focused element when it closes. This also works correctly with any modal children that have the `disableAutoFocus` prop.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableAutoFocus(value: bool) = Interop.mkAttr "disableAutoFocus" value
  /// If `true`, clicking the backdrop will not fire any callback.
  static member inline disableBackdropClick(value: bool) = Interop.mkAttr "disableBackdropClick" value
  /// If `true`, the modal will not prevent focus from leaving the modal while open.
  ///
  /// Generally this should never be set to `true` as it makes the modal less accessible to assistive technologies, like screen readers.
  static member inline disableEnforceFocus(value: bool) = Interop.mkAttr "disableEnforceFocus" value
  /// If `true`, hitting escape will not fire any callback.
  static member inline disableEscapeKeyDown(value: bool) = Interop.mkAttr "disableEscapeKeyDown" value
  /// Disable the portal behavior. The children stay within it's parent DOM hierarchy.
  static member inline disablePortal(value: bool) = Interop.mkAttr "disablePortal" value
  /// If `true`, the modal will not restore focus to previously focused element once modal is hidden.
  static member inline disableRestoreFocus(value: bool) = Interop.mkAttr "disableRestoreFocus" value
  /// Disable the scroll lock behavior.
  static member inline disableScrollLock(value: bool) = Interop.mkAttr "disableScrollLock" value
  /// If `true`, the backdrop is not rendered.
  static member inline hideBackdrop(value: bool) = Interop.mkAttr "hideBackdrop" value
  /// Always keep the children in the DOM. This prop can be useful in SEO situation or when you want to maximize the responsiveness of the Modal.
  static member inline keepMounted(value: bool) = Interop.mkAttr "keepMounted" value
  /// Callback fired when the backdrop is clicked.
  static member inline onBackdropClick(handler: Event -> unit) = Interop.mkAttr "onBackdropClick" handler
  /// Callback fired when the component requests to be closed. The `reason` parameter can optionally be used to control the response to `onClose`.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *reason:* Can be:`"escapeKeyDown"`, `"backdropClick"`
  static member inline onClose(handler: Event -> ModalCloseReason -> unit) = Interop.mkAttr "onClose" (System.Func<_,_,_> handler)
  /// Callback fired when the component requests to be closed. The `reason` parameter can optionally be used to control the response to `onClose`.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *reason:* Can be:`"escapeKeyDown"`, `"backdropClick"`
  static member inline onClose(handler: ModalCloseReason -> unit) = Interop.mkAttr "onClose" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired when the escape key is pressed, `disableEscapeKeyDown` is false and the modal is in focus.
  static member inline onEscapeKeyDown(handler: Event -> unit) = Interop.mkAttr "onEscapeKeyDown" handler
  /// If `true`, the modal is open.
  static member inline open'(value: bool) = Interop.mkAttr "open" value


[<Erase>]
type nativeSelect =
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children(element: ReactElement) = prop.children element
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The option elements to populate the select with. Can be some `<option>` elements.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.nativeSelect` to specify class names.
  static member inline classes(classNames: classes.INativeSelectClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The icon that displays the arrow.
  static member inline IconComponent(value: ReactElementType) = Interop.mkAttr "IconComponent" value
  /// An `Input` element; does not have to be a material-ui specific `Input`.
  static member inline input(value: ReactElement) = Interop.mkAttr "input" value
  /// Attributes applied to the `select` element.
  static member inline inputProps(props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// Callback function fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback function fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The input value.
  static member inline value(value: 'a) = Interop.mkAttr "value" value

module nativeSelect =

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline filled = Interop.mkAttr "variant" "filled"


[<Erase>]
type noSsr =
  /// You can wrap a node.
  static member inline children(element: ReactElement) = prop.children element
  /// You can wrap a node.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// You can wrap a node.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// You can wrap a node.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// You can wrap a node.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// You can wrap a node.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// If `true`, the component will not only prevent server-side rendering. It will also defer the rendering of the children into a different screen frame.
  static member inline defer(value: bool) = Interop.mkAttr "defer" value
  /// The fallback content to display.
  static member inline fallback(value: ReactElement) = Interop.mkAttr "fallback" value
  /// The fallback content to display.
  static member inline fallback(values: ReactElement seq) = Interop.mkAttr "fallback" values
  /// The fallback content to display.
  static member inline fallback(value: string) = Interop.mkAttr "fallback" value
  /// The fallback content to display.
  static member inline fallback(values: string seq) = Interop.mkAttr "fallback" values
  /// The fallback content to display.
  static member inline fallback(value: int) = Interop.mkAttr "fallback" value
  /// The fallback content to display.
  static member inline fallback(value: float) = Interop.mkAttr "fallback" value


[<Erase>]
type outlinedInput =
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete(value: string) = Interop.mkAttr "autoComplete" value
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus(value: bool) = Interop.mkAttr "autoFocus" value
  /// Override or extend the styles applied to the component. Use `classes.outlinedInput` to specify class names.
  static member inline classes(classNames: classes.IOutlinedInputClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The CSS class name of the wrapper element.
  static member inline className(value: string) = Interop.mkAttr "className" value
  /// The default `input` element value. Use when the component is not controlled.
  static member inline defaultValue(value: 'a) = Interop.mkAttr "defaultValue" value
  /// If `true`, the `input` element will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// End `InputAdornment` for this component.
  static member inline endAdornment(element: ReactElement) = Interop.mkAttr "endAdornment" element
  /// If `true`, the input will indicate an error. This is normally obtained via context from FormControl.
  static member inline error(value: bool) = Interop.mkAttr "error" value
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth(value: bool) = Interop.mkAttr "fullWidth" value
  /// The id of the `input` element.
  static member inline id(value: string) = Interop.mkAttr "id" value
  /// The component used for the native input. Either a string to use a DOM element or a component.
  static member inline inputComponent(value: ReactElementType) = Interop.mkAttr "inputComponent" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps(props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(ref: IRefValue<HTMLInputElement option>) = Interop.mkAttr "inputRef" ref
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(handler: HTMLInputElement -> unit) = Interop.mkAttr "inputRef" handler
  /// The width of the label.
  static member inline labelWidth(value: int) = Interop.mkAttr "labelWidth" value
  /// If `true`, a textarea element will be rendered.
  static member inline multiline(value: bool) = Interop.mkAttr "multiline" value
  /// Name attribute of the `input` element.
  static member inline name(value: string) = Interop.mkAttr "name" value
  /// If `true`, the outline is notched to accommodate the label.
  static member inline notched(value: bool) = Interop.mkAttr "notched" value
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder(value: string) = Interop.mkAttr "placeholder" value
  /// It prevents the user from changing the value of the field (not from interacting with the field).
  static member inline readOnly(value: bool) = Interop.mkAttr "readOnly" value
  /// If `true`, the `input` element will be required.
  static member inline required(value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows(value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax(value: int) = Interop.mkAttr "rowsMax" value
  /// Start `InputAdornment` for this component.
  static member inline startAdornment(element: ReactElement) = Interop.mkAttr "startAdornment" element
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type'(value: string) = Interop.mkAttr "type" value
  /// The value of the `input` element, required for a controlled component.
  static member inline value(value: 'a) = Interop.mkAttr "value" value

module outlinedInput =

  /// If `dense`, will adjust vertical spacing. This is normally obtained via context from FormControl.
  [<Erase>]
  type margin =
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline none = Interop.mkAttr "margin" "none"


[<Erase>]
type paper =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.paper` to specify class names.
  static member inline classes(classNames: classes.IPaperClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Shadow depth, corresponds to `dp` in the spec. It accepts values between 0 and 24 inclusive.
  static member inline elevation(value: int) = Interop.mkAttr "elevation" value
  /// If `true`, rounded corners are disabled.
  static member inline square(value: bool) = Interop.mkAttr "square" value


type popover =
  /// This is callback prop. It's called by the component on mount. This is useful when you want to trigger an action programmatically. It currently only supports updatePosition() action.
  static member inline action(ref: IRefValue<PopoverActions option>) = Interop.mkAttr "action" ref
  /// This is callback prop. It's called by the component on mount. This is useful when you want to trigger an action programmatically. It currently only supports updatePosition() action.
  static member inline action(handler: PopoverActions -> unit) = Interop.mkAttr "action" handler
  /// This is the DOM element, or a function that returns the DOM element, that may be used to set the position of the popover.
  static member inline anchorEl(value: Element option) = Interop.mkAttr "anchorEl" value
  /// This is the DOM element, or a function that returns the DOM element, that may be used to set the position of the popover.
  static member inline anchorEl(handler: unit -> Element option) = Interop.mkAttr "anchorEl" handler
  /// This is the DOM element, or a function that returns the DOM element, that may be used to set the position of the popover.
  static member inline anchorEl(ref: IRefValue<Element option>) = Interop.mkAttr "anchorEl" (fun () -> ref.current)
  /// This is the position that may be used to set the position of the popover. The coordinates are relative to the application's client area.
  static member anchorPosition(left: int, top: int) = [yield "left" ==> left; yield "top" ==> top] |> createObj |> Interop.mkAttr "anchorPosition"
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.popover` to specify class names.
  static member inline classes(classNames: classes.IPopoverClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// A node, component instance, or function that returns either. The `container` will passed to the Modal component. By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container(element: Element option) = Interop.mkAttr "container" element
  /// A node, component instance, or function that returns either. The `container` will passed to the Modal component. By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container(element: ReactElement option) = Interop.mkAttr "container" element
  /// A node, component instance, or function that returns either. The `container` will passed to the Modal component. By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container(getElement: unit -> Element option) = Interop.mkAttr "container" getElement
  /// A node, component instance, or function that returns either. The `container` will passed to the Modal component. By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container(getElement: unit -> ReactElement option) = Interop.mkAttr "container" getElement
  /// The elevation of the popover.
  static member inline elevation(value: int) = Interop.mkAttr "elevation" value
  /// This function is called in order to retrieve the content anchor element. It's the opposite of the `anchorEl` prop. The content anchor element should be an element inside the popover. It's used to correctly scroll and set the position of the popover. The positioning strategy tries to make the content anchor element just above the anchor element.
  static member inline getContentAnchorEl(handler: Element option -> unit) = Interop.mkAttr "getContentAnchorEl" handler
  /// Specifies how close to the edge of the window the popover can appear.
  static member inline marginThreshold(value: int) = Interop.mkAttr "marginThreshold" value
  /// `classes` prop applied to the [`Modal`](https://material-ui.com/api/modal/) element.
  static member inline ModalClasses(classNames: classes.IModalClasses list) = Interop.mkAttr "ModalClasses" (createObj !!classNames)
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be:`"escapeKeyDown"`, `"backdropClick"`
  static member inline onClose(handler: Event -> PopoverCloseReason -> unit) = Interop.mkAttr "onClose" (System.Func<_,_,_> handler)
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback.
  ///
  /// *reason:* Can be:`"escapeKeyDown"`, `"backdropClick"`
  static member inline onClose(handler: PopoverCloseReason -> unit) = Interop.mkAttr "onClose" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired before the component is entering.
  static member inline onEnter(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEnter" handler
  /// Callback fired when the component has entered.
  static member inline onEntered(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntered" handler
  /// Callback fired when the component is entering.
  static member inline onEntering(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntering" handler
  /// Callback fired before the component is exiting.
  static member inline onExit(handler: ReactElement -> unit) = Interop.mkAttr "onExit" handler
  /// Callback fired when the component has exited.
  static member inline onExited(handler: ReactElement -> unit) = Interop.mkAttr "onExited" handler
  /// Callback fired when the component is exiting.
  static member inline onExiting(handler: ReactElement -> unit) = Interop.mkAttr "onExiting" handler
  /// If `true`, the popover is visible.
  static member inline open'(value: bool) = Interop.mkAttr "open" value
  /// Props applied to the [`Paper`](https://material-ui.com/api/paper/) element.
  static member inline PaperProps(props: IReactProperty list) = Interop.mkAttr "PaperProps" (createObj !!props)
  /// The component used for the transition.
  static member inline TransitionComponent(value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline transitionDuration(value: int) = Interop.mkAttr "transitionDuration" value
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member transitionDuration(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "transitionDuration"
  /// Props applied to the `Transition` element.
  static member inline TransitionProps(props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module popover =

  /// This is the point on the anchor where the popover's `anchorEl` will attach to. This is not used when the anchorReference is 'anchorPosition'.
  ///
  /// Options: vertical: [top, center, bottom]; horizontal: [left, center, right].
  [<Erase>]
  type anchorOrigin =
    static member inline topLeft = Interop.mkAttr "anchorOrigin" {| vertical = "top"; horizontal = "left" |}
    static member inline topCenter = Interop.mkAttr "anchorOrigin" {| vertical = "top"; horizontal = "center" |}
    static member inline topRight = Interop.mkAttr "anchorOrigin" {| vertical = "top"; horizontal = "right" |}
    static member inline centerLeft = Interop.mkAttr "anchorOrigin" {| vertical = "center"; horizontal = "left" |}
    static member inline centerCenter = Interop.mkAttr "anchorOrigin" {| vertical = "center"; horizontal = "center" |}
    static member inline centerRight = Interop.mkAttr "anchorOrigin" {| vertical = "center"; horizontal = "right" |}
    static member inline bottomLeft = Interop.mkAttr "anchorOrigin" {| vertical = "bottom"; horizontal = "left" |}
    static member inline bottomCenter = Interop.mkAttr "anchorOrigin" {| vertical = "bottom"; horizontal = "center" |}
    static member inline bottomRight = Interop.mkAttr "anchorOrigin" {| vertical = "bottom"; horizontal = "right" |}
    static member inline custom(horizontal: int, vertical: int) = Interop.mkAttr "anchorOrigin" {| vertical = vertical; horizontal = horizontal |}
    static member inline topCustom(horizontal: int) = Interop.mkAttr "anchorOrigin" {| vertical = "top"; horizontal = horizontal |}
    static member inline centerCustom(horizontal: int) = Interop.mkAttr "anchorOrigin" {| vertical = "center"; horizontal = horizontal |}
    static member inline bottomCustom(horizontal: int) = Interop.mkAttr "anchorOrigin" {| vertical = "bottom"; horizontal = horizontal |}
    static member inline customLeft(vertical: int) = Interop.mkAttr "anchorOrigin" {| vertical = vertical; horizontal = "left" |}
    static member inline customCenter(vertical: int) = Interop.mkAttr "anchorOrigin" {| vertical = vertical; horizontal = "center" |}
    static member inline customRight(vertical: int) = Interop.mkAttr "anchorOrigin" {| vertical = vertical; horizontal = "right" |}

  [<Erase>]
  type anchorReference =
    static member inline anchorEl = Interop.mkAttr "anchorReference" "anchorEl"
    static member inline anchorPosition = Interop.mkAttr "anchorReference" "anchorPosition"
    static member inline none = Interop.mkAttr "anchorReference" "none"

  /// This is the point on the popover which will attach to the anchor's origin.
  ///
  /// Options: vertical: [top, center, bottom, x(px)]; horizontal: [left, center, right, x(px)].
  [<Erase>]
  type transformOrigin =
    static member inline topLeft = Interop.mkAttr "transformOrigin" {| vertical = "top"; horizontal = "left" |}
    static member inline topCenter = Interop.mkAttr "transformOrigin" {| vertical = "top"; horizontal = "center" |}
    static member inline topRight = Interop.mkAttr "transformOrigin" {| vertical = "top"; horizontal = "right" |}
    static member inline centerLeft = Interop.mkAttr "transformOrigin" {| vertical = "center"; horizontal = "left" |}
    static member inline centerCenter = Interop.mkAttr "transformOrigin" {| vertical = "center"; horizontal = "center" |}
    static member inline centerRight = Interop.mkAttr "transformOrigin" {| vertical = "center"; horizontal = "right" |}
    static member inline bottomLeft = Interop.mkAttr "transformOrigin" {| vertical = "bottom"; horizontal = "left" |}
    static member inline bottomCenter = Interop.mkAttr "transformOrigin" {| vertical = "bottom"; horizontal = "center" |}
    static member inline bottomRight = Interop.mkAttr "transformOrigin" {| vertical = "bottom"; horizontal = "right" |}
    static member inline custom(horizontal: int, vertical: int) = Interop.mkAttr "transformOrigin" {| vertical = vertical; horizontal = horizontal |}
    static member inline topCustom(horizontal: int) = Interop.mkAttr "transformOrigin" {| vertical = "top"; horizontal = horizontal |}
    static member inline centerCustom(horizontal: int) = Interop.mkAttr "transformOrigin" {| vertical = "center"; horizontal = horizontal |}
    static member inline bottomCustom(horizontal: int) = Interop.mkAttr "transformOrigin" {| vertical = "bottom"; horizontal = horizontal |}
    static member inline customLeft(vertical: int) = Interop.mkAttr "transformOrigin" {| vertical = vertical; horizontal = "left" |}
    static member inline customCenter(vertical: int) = Interop.mkAttr "transformOrigin" {| vertical = vertical; horizontal = "center" |}
    static member inline customRight(vertical: int) = Interop.mkAttr "transformOrigin" {| vertical = vertical; horizontal = "right" |}

  /// Set to 'auto' to automatically calculate transition time based on height.
  [<Erase>]
  type transitionDuration =
    static member inline auto = Interop.mkAttr "transitionDuration" "auto"


[<Erase>]
type popper =
  /// This is the reference element, or a function that returns the reference element, that may be used to set the position of the popover. The return value will passed as the reference object of the Popper instance.
  ///
  /// The reference element should be an HTML Element instance or a referenceObject: https://popper.js.org/popper-documentation.html#referenceObject.
  static member inline anchorEl(value: Element option) = Interop.mkAttr "anchorEl" value
  /// This is the reference element, or a function that returns the reference element, that may be used to set the position of the popover. The return value will passed as the reference object of the Popper instance.
  ///
  /// The reference element should be an HTML Element instance or a referenceObject: https://popper.js.org/popper-documentation.html#referenceObject.
  static member inline anchorEl(handler: unit -> Element option) = Interop.mkAttr "anchorEl" handler
  /// This is the reference element, or a function that returns the reference element, that may be used to set the position of the popover. The return value will passed as the reference object of the Popper instance.
  ///
  /// The reference element should be an HTML Element instance or a referenceObject: https://popper.js.org/popper-documentation.html#referenceObject.
  static member inline anchorEl(ref: IRefValue<Element option>) = Interop.mkAttr "anchorEl" (fun () -> ref.current)
  /// Popper render function or node.
  static member inline children(element: ReactElement) = prop.children element
  /// Popper render function or node.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Popper render function or node.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Popper render function or node.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Popper render function or node.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Popper render function or node.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// A node, component instance, or function that returns either. The `container` will passed to the Modal component. By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container(element: Element option) = Interop.mkAttr "container" element
  /// A node, component instance, or function that returns either. The `container` will passed to the Modal component. By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container(element: ReactElement option) = Interop.mkAttr "container" element
  /// A node, component instance, or function that returns either. The `container` will passed to the Modal component. By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container(getElement: unit -> Element option) = Interop.mkAttr "container" getElement
  /// A node, component instance, or function that returns either. The `container` will passed to the Modal component. By default, it uses the body of the anchorEl's top-level document object, so it's simply `document.body` most of the time.
  static member inline container(getElement: unit -> ReactElement option) = Interop.mkAttr "container" getElement
  /// Disable the portal behavior. The children stay within it's parent DOM hierarchy.
  static member inline disablePortal(value: bool) = Interop.mkAttr "disablePortal" value
  /// Always keep the children in the DOM. This prop can be useful in SEO situation or when you want to maximize the responsiveness of the Popper.
  static member inline keepMounted(value: bool) = Interop.mkAttr "keepMounted" value
  /// Popper.js is based on a "plugin-like" architecture, most of its features are fully encapsulated "modifiers".
  ///
  /// A modifier is a function that is called each time Popper.js needs to compute the position of the popper. For this reason, modifiers should be very performant to avoid bottlenecks. To learn how to create a modifier, [read the modifiers documentation](https://github.com/FezVrasta/popper.js/blob/master/docs/_includes/popper-documentation.md#modifiers--object).
  static member inline modifiers(value: 'a) = Interop.mkAttr "modifiers" value
  /// If `true`, the popper is visible.
  static member inline open'(value: bool) = Interop.mkAttr "open" value
  /// Options provided to the [`popper.js`](https://github.com/FezVrasta/popper.js) instance.
  static member inline popperOptions(value: 'a) = Interop.mkAttr "popperOptions" value
  /// Callback fired when a new popper instance is used.
  static member inline popperRef(ref: IRefValue<Element option>) = Interop.mkAttr "popperRef" ref
  /// Callback fired when a new popper instance is used.
  static member inline popperRef(handler: Element -> unit) = Interop.mkAttr "popperRef" handler
  /// Help supporting a react-transition-group/Transition component.
  static member inline transition(value: bool) = Interop.mkAttr "transition" value

module popper =

  /// Popper placement.
  [<Erase>]
  type placement =
    static member inline bottomEnd = Interop.mkAttr "placement" "bottom-end"
    static member inline bottomStart = Interop.mkAttr "placement" "bottom-start"
    static member inline bottom = Interop.mkAttr "placement" "bottom"
    static member inline leftEnd = Interop.mkAttr "placement" "left-end"
    static member inline leftStart = Interop.mkAttr "placement" "left-start"
    static member inline left = Interop.mkAttr "placement" "left"
    static member inline rightEnd = Interop.mkAttr "placement" "right-end"
    static member inline rightStart = Interop.mkAttr "placement" "right-start"
    static member inline right = Interop.mkAttr "placement" "right"
    static member inline topEnd = Interop.mkAttr "placement" "top-end"
    static member inline topStart = Interop.mkAttr "placement" "top-start"
    static member inline top = Interop.mkAttr "placement" "top"


[<Erase>]
type portal =
  /// The children to render into the `container`.
  static member inline children(element: ReactElement) = prop.children element
  /// The children to render into the `container`.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The children to render into the `container`.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The children to render into the `container`.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The children to render into the `container`.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The children to render into the `container`.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// A node, component instance, or function that returns either. The `container` will have the portal children appended to it. By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container(element: Element option) = Interop.mkAttr "container" element
  /// A node, component instance, or function that returns either. The `container` will have the portal children appended to it. By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container(element: ReactElement option) = Interop.mkAttr "container" element
  /// A node, component instance, or function that returns either. The `container` will have the portal children appended to it. By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container(getElement: unit -> Element option) = Interop.mkAttr "container" getElement
  /// A node, component instance, or function that returns either. The `container` will have the portal children appended to it. By default, it uses the body of the top-level document object, so it's simply `document.body` most of the time.
  static member inline container(getElement: unit -> ReactElement option) = Interop.mkAttr "container" getElement
  /// Disable the portal behavior. The children stay within it's parent DOM hierarchy.
  static member inline disablePortal(value: bool) = Interop.mkAttr "disablePortal" value


[<Erase>]
type radio =
  /// If `true`, the component is checked.
  static member inline checked'(value: bool) = Interop.mkAttr "checked" value
  /// The icon to display when the component is checked.
  static member inline checkedIcon(element: ReactElement) = Interop.mkAttr "checkedIcon" element
  /// Override or extend the styles applied to the component. Use `classes.radio` to specify class names.
  static member inline classes(classNames: classes.IRadioClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the switch will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple(value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon to display when the component is unchecked.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element
  /// The id of the `input` element.
  static member inline id(value: string) = Interop.mkAttr "id" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps(props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(ref: IRefValue<HTMLInputElement option>) = Interop.mkAttr "inputRef" ref
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(handler: HTMLInputElement -> unit) = Interop.mkAttr "inputRef" handler
  /// Name attribute of the `input` element.
  static member inline name(value: string) = Interop.mkAttr "name" value
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, checked: boolean) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  ///
  /// *checked:* The `checked` value of the switch
  static member inline onChange(handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// If `true`, the `input` element will be required.
  static member inline required(value: bool) = Interop.mkAttr "required" value
  /// The input component prop `type`.
  static member inline type'(value: string) = Interop.mkAttr "type" value
  /// The value of the component.
  static member inline value(value: 'a) = Interop.mkAttr "value" value

module radio =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline default' = Interop.mkAttr "color" "default"


[<Erase>]
type radioGroup =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// The default `input` element value. Use when the component is not controlled.
  static member inline defaultValue(value: 'a) = Interop.mkAttr "defaultValue" value
  /// The name used to reference the value of the control.
  static member inline name(value: string) = Interop.mkAttr "name" value
  /// Callback fired when a radio button is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: string) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  ///
  /// *value:* The `value` of the selected radio button
  static member inline onChange(handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when a radio button is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: string) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  ///
  /// *value:* The `value` of the selected radio button
  static member inline onChange(handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// Value of the selected radio button.
  static member inline value(value: string) = Interop.mkAttr "value" value


[<Erase>]
type rating =
  /// Override or extend the styles applied to the component. Use `classes.rating` to specify class names.
  static member inline classes(classNames: classes.IRatingClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the rating will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// The icon to display when empty.
  static member inline emptyIcon(element: ReactElement) = Interop.mkAttr "emptyIcon" element
  /// Accepts a function which returns a string value that provides a user-friendly name for the current value of the rating.
  ///
  /// **Signature:**
  ///
  /// `function(value: number) => string`
  ///
  /// *value:* The rating label's value to format
  static member inline getLabelText(getText: int -> string) = Interop.mkAttr "getLabelText" getText
  /// Accepts a function which returns a string value that provides a user-friendly name for the current value of the rating.
  ///
  /// **Signature:**
  ///
  /// `function(value: number) => string`
  ///
  /// *value:* The rating label's value to format
  static member inline getLabelText(getText: float -> string) = Interop.mkAttr "getLabelText" getText
  /// The icon to display.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element
  /// The component containing the icon.
  static member inline IconContainerComponent(value: ReactElementType) = Interop.mkAttr "IconContainerComponent" value
  /// Maximum rating.
  static member inline max(value: int) = Interop.mkAttr "max" value
  /// The name attribute of the radio `input` elements. If `readOnly` is false, the prop is required, this input name`should be unique within the parent form.
  static member inline name(value: string) = Interop.mkAttr "name" value
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChange(handler: Event -> int -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChange(handler: Event -> float -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChange(handler: int -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChange(handler: float -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChangeActive(handler: Event -> int -> unit) = Interop.mkAttr "onChangeActive" (System.Func<_,_,_> handler)
  /// Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChangeActive(handler: Event -> float -> unit) = Interop.mkAttr "onChangeActive" (System.Func<_,_,_> handler)
  /// Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChangeActive(handler: int -> unit) = Interop.mkAttr "onChangeActive" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the hover state changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: number) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChangeActive(handler: float -> unit) = Interop.mkAttr "onChangeActive" (System.Func<_,_,_> (fun _ v -> handler v))
  /// The minimum increment value change allowed.
  static member inline precision(value: int) = Interop.mkAttr "precision" value
  /// Removes all hover effects and pointer events.
  static member inline readOnly(value: bool) = Interop.mkAttr "readOnly" value
  /// The rating value.
  static member inline value(value: int) = Interop.mkAttr "value" value

module rating =

  /// The size of the rating.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"


[<Erase>]
type rootRef =
  /// The wrapped element.
  static member inline children(value: ReactElement) = Interop.mkAttr "children" value
  /// Provide a way to access the DOM node of the wrapped element. You can provide a callback ref or a `React.createRef()` ref.
  static member inline rootRef(ref: IRefValue<Element option>) = Interop.mkAttr "rootRef" ref
  /// Provide a way to access the DOM node of the wrapped element. You can provide a callback ref or a `React.createRef()` ref.
  static member inline rootRef(handler: Element -> unit) = Interop.mkAttr "rootRef" handler


[<Erase>]
type select =
  /// If true, the width of the popover will automatically be set according to the items inside the menu, otherwise it will be at least the width of the select input.
  static member inline autoWidth(value: bool) = Interop.mkAttr "autoWidth" value
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children(element: ReactElement) = prop.children element
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The option elements to populate the select with. Can be some `MenuItem` when `native` is false and `option` when `native` is true.
  ///
  /// ⚠️The `MenuItem` elements **must** be direct descendants when `native` is false.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.select` to specify class names.
  static member inline classes(classNames: classes.ISelectClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, a value is displayed even if no items are selected.
  ///
  /// In order to display a meaningful value, a function should be passed to the `renderValue` prop which returns the value to be displayed when no items are selected. You can only use it when the `native` prop is `false` (default).
  static member inline displayEmpty(value: bool) = Interop.mkAttr "displayEmpty" value
  /// The icon that displays the arrow.
  static member inline IconComponent(value: ReactElementType) = Interop.mkAttr "IconComponent" value
  /// An `Input` element; does not have to be a material-ui specific `Input`.
  static member inline input(value: ReactElement) = Interop.mkAttr "input" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element. When `native` is `true`, the attributes are applied on the `select` element.
  static member inline inputProps(props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// Props applied to the [`Menu`](https://material-ui.com/api/menu/) element.
  static member inline MenuProps(props: IReactProperty list) = Interop.mkAttr "MenuProps" (createObj !!props)
  /// If true, `value` must be an array and the menu will support multiple selections.
  static member inline multiple(value: bool) = Interop.mkAttr "multiple" value
  /// If `true`, the component will be using a native `select` element.
  static member inline native(value: bool) = Interop.mkAttr "native" value
  /// Callback function fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, child?: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  ///
  /// *child:* The react element that was selected when `native` is `false` (default).
  static member inline onChange(handler: Event -> ReactElement -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> handler)
  /// Callback function fired when a menu item is selected.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, child?: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  ///
  /// *child:* The react element that was selected when `native` is `false` (default).
  static member inline onChange(handler: 'a -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> (fun (e: Event) _ -> handler !!e.Value))
  /// Callback fired when the component requests to be closed. Use in controlled mode (see open).
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback
  static member inline onClose(handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback fired when the component requests to be opened. Use in controlled mode (see open).
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback
  static member inline onOpen(handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// Control `select` open state. You can only use it when the `native` prop is `false` (default).
  static member inline open'(value: bool) = Interop.mkAttr "open" value
  /// Render the selected value. You can only use it when the `native` prop is `false` (default).
  ///
  /// **Signature:**
  ///
  /// `function(value: any) => ReactElement`
  ///
  /// *value:* The `value` provided to the component.
  static member inline renderValue(render: 'a -> ReactElement) = Interop.mkAttr "renderValue" render
  /// Props applied to the clickable div element.
  static member inline SelectDisplayProps(props: IReactProperty list) = Interop.mkAttr "SelectDisplayProps" (createObj !!props)
  /// The input value. This prop is required when the `native` prop is `false` (default).
  static member inline value(value: 'a) = Interop.mkAttr "value" value

module select =

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline filled = Interop.mkAttr "variant" "filled"


[<Erase>]
type skeleton =
  /// Override or extend the styles applied to the component. Use `classes.skeleton` to specify class names.
  static member inline classes(classNames: classes.ISkeletonClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true` the animation effect is disabled.
  static member inline disableAnimate(value: bool) = Interop.mkAttr "disableAnimate" value
  /// Height of the skeleton. Useful when you don't want to adapt the skeleton to a text element but for instance a card.
  static member inline height(value: int) = Interop.mkAttr "height" value
  /// Height of the skeleton. Useful when you don't want to adapt the skeleton to a text element but for instance a card.
  static member inline height(value: Styles.ICssUnit) = Interop.mkAttr "height" value
  /// Width of the skeleton. Useful when the skeleton is inside an inline element with no width of its own.
  static member inline width(value: int) = Interop.mkAttr "width" value
  /// Width of the skeleton. Useful when the skeleton is inside an inline element with no width of its own.
  static member inline width(value: Styles.ICssUnit) = Interop.mkAttr "width" value

module skeleton =

  /// The type of content that will be rendered.
  [<Erase>]
  type variant =
    static member inline text = Interop.mkAttr "variant" "text"
    static member inline rect = Interop.mkAttr "variant" "rect"
    static member inline circle = Interop.mkAttr "variant" "circle"


type slide =
  /// A single child content element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline children(value: ReactElement) = Interop.mkAttr "children" value
  /// If `true`, show the component; triggers the enter or exit animation.
  static member inline in'(value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout(value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  static member timeout(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "timeout"

module slide =

  /// Direction the child node will enter from.
  [<Erase>]
  type direction =
    static member inline left = Interop.mkAttr "direction" "left"
    static member inline right = Interop.mkAttr "direction" "right"
    static member inline up = Interop.mkAttr "direction" "up"
    static member inline down = Interop.mkAttr "direction" "down"


[<Erase>]
type slider =
  /// The label of the slider.
  static member inline ariaLabel(value: string) = Interop.mkAttr "aria-label" value
  /// The id of the element containing a label for the slider.
  static member inline ariaLabelledby(value: string) = Interop.mkAttr "aria-labelledby" value
  /// A string value that provides a user-friendly name for the current value of the slider.
  static member inline ariaValuetext(value: string) = Interop.mkAttr "aria-valuetext" value
  /// Override or extend the styles applied to the component. Use `classes.slider` to specify class names.
  static member inline classes(classNames: classes.ISliderClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// The default element value. Use when the component is not controlled.
  static member inline defaultValue(value: int) = Interop.mkAttr "defaultValue" value
  /// The default element value. Use when the component is not controlled.
  static member inline defaultValue(value: float) = Interop.mkAttr "defaultValue" value
  /// The default element value. Use when the component is not controlled.
  static member inline defaultValue(min: int, max: int) = Interop.mkAttr "defaultValue" (min, max)
  /// The default element value. Use when the component is not controlled.
  static member inline defaultValue(min: float, max: float) = Interop.mkAttr "defaultValue" (min, max)
  /// If `true`, the slider will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// Accepts a function which returns a string value that provides a user-friendly name for the current value of the slider.
  ///
  /// **Signature:**
  ///
  /// `function(value: number, index: number) => void`
  ///
  /// *value:* The thumb label's value to format
  ///
  /// *index:* The thumb label's index to format
  static member inline getAriaValueText(getText: int -> int -> string) = Interop.mkAttr "getAriaValueText" getText
  /// Accepts a function which returns a string value that provides a user-friendly name for the current value of the slider.
  ///
  /// **Signature:**
  ///
  /// `function(value: number, index: number) => void`
  ///
  /// *value:* The thumb label's value to format
  ///
  /// *index:* The thumb label's index to format
  static member inline getAriaValueText(getText: float -> int -> string) = Interop.mkAttr "getAriaValueText" getText
  /// Marks indicate predetermined values to which the user can move the slider. If `true` the marks will be spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks(value: bool) = Interop.mkAttr "marks" value
  /// Marks indicate predetermined values to which the user can move the slider. If `true` the marks will be spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks([<ParamArray>] values: {| value: int |} []) = Interop.mkAttr "marks" values
  /// Marks indicate predetermined values to which the user can move the slider. If `true` the marks will be spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks([<ParamArray>] values: {| value: int; label: string option |} []) = Interop.mkAttr "marks" values
  /// Marks indicate predetermined values to which the user can move the slider. If `true` the marks will be spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks([<ParamArray>] values: {| value: float |} []) = Interop.mkAttr "marks" values
  /// Marks indicate predetermined values to which the user can move the slider. If `true` the marks will be spaced according the value of the `step` prop. If an array, it should contain objects with `value` and an optional `label` keys.
  static member inline marks([<ParamArray>] values: {| value: float; label: string option |} []) = Interop.mkAttr "marks" values
  /// The maximum allowed value of the slider. Should not be equal to min.
  static member inline max(value: int) = Interop.mkAttr "max" value
  /// The minimum allowed value of the slider. Should not be equal to max.
  static member inline min(value: int) = Interop.mkAttr "min" value
  /// Name attribute of the hidden `input` element.
  static member inline name(value: string) = Interop.mkAttr "name" value
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChange(handler: Event -> int -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> handler)
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChange(handler: Event -> float -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> handler)
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChange(handler: int -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the slider's value changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChange(handler: float -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChangeCommitted(handler: Event -> int -> unit) = Interop.mkAttr "onChangeCommitted" (System.Func<_,_,_> handler)
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChangeCommitted(handler: Event -> float -> unit) = Interop.mkAttr "onChangeCommitted" (System.Func<_,_,_> handler)
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChangeCommitted(handler: int -> unit) = Interop.mkAttr "onChangeCommitted" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback function that is fired when the `mouseup` is triggered.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* The new value
  static member inline onChangeCommitted(handler: float -> unit) = Interop.mkAttr "onChangeCommitted" (System.Func<_,_,_> (fun _ v -> handler v))
  /// The granularity with which the slider can step through values. (A "discrete" slider.) When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
  static member inline step(value: int) = Interop.mkAttr "step" value
  /// The granularity with which the slider can step through values. (A "discrete" slider.) When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
  static member inline step(value: float) = Interop.mkAttr "step" value
  /// The granularity with which the slider can step through values. (A "discrete" slider.) When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
  static member inline step(value: int option) = Interop.mkAttr "step" value
  /// The component used to display the value label.
  static member inline ThumbComponent(value: ReactElementType) = Interop.mkAttr "ThumbComponent" value
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value(value: int) = Interop.mkAttr "value" value
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value(value: float) = Interop.mkAttr "value" value
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value(min: int, max: int) = Interop.mkAttr "value" (min, max)
  /// The value of the slider. For ranged sliders, provide an array with two values.
  static member inline value(min: float, max: float) = Interop.mkAttr "value" (min, max)
  /// The value label component.
  static member inline ValueLabelComponent(value: ReactElementType) = Interop.mkAttr "ValueLabelComponent" value
  /// The format function the value label's value.
  ///
  /// When a function is provided, it should have the following signature:
  ///
  /// - {number} value The value label's value to format - {number} index The value label's index to format
  static member inline valueLabelFormat(value: string) = Interop.mkAttr "valueLabelFormat" value
  /// The format function the value label's value.
  ///
  /// When a function is provided, it should have the following signature:
  ///
  /// - {number} value The value label's value to format - {number} index The value label's index to format
  static member inline valueLabelFormat(format: int -> int -> string) = Interop.mkAttr "valueLabelFormat" format
  /// The format function the value label's value.
  ///
  /// When a function is provided, it should have the following signature:
  ///
  /// - {number} value The value label's value to format - {number} index The value label's index to format
  static member inline valueLabelFormat(format: float -> int -> string) = Interop.mkAttr "valueLabelFormat" format

[<AutoOpen>]
module sliderExtensions =

  type slider with
    /// The granularity with which the slider can step through values. (A "discrete" slider.) When step is `null`, the thumb can only be slid onto marks provided with the `marks` prop.
    static member inline step(value: float option) = Interop.mkAttr "step" value

module slider =

  /// The slider orientation.
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// Controls when the value label is displayed:
  ///
  /// - `auto` the value label will display when the thumb is hovered or focused. - `on` will display persistently. - `off` will never display.
  [<Erase>]
  type valueLabelDisplay =
    static member inline on = Interop.mkAttr "valueLabelDisplay" "on"
    static member inline auto = Interop.mkAttr "valueLabelDisplay" "auto"
    static member inline off = Interop.mkAttr "valueLabelDisplay" "off"


type snackbar =
  /// The action to display.
  static member inline action(value: ReactElement) = Interop.mkAttr "action" value
  /// The action to display.
  static member inline action(values: ReactElement seq) = Interop.mkAttr "action" values
  /// The action to display.
  static member inline action(value: string) = Interop.mkAttr "action" value
  /// The action to display.
  static member inline action(values: string seq) = Interop.mkAttr "action" values
  /// The action to display.
  static member inline action(value: int) = Interop.mkAttr "action" value
  /// The action to display.
  static member inline action(value: float) = Interop.mkAttr "action" value
  /// The number of milliseconds to wait before automatically calling the `onClose` function. `onClose` should then set the state of the `open` prop to hide the Snackbar. This behavior is disabled by default with the `null` value.
  static member inline autoHideDuration(value: int) = Interop.mkAttr "autoHideDuration" value
  /// The number of milliseconds to wait before automatically calling the `onClose` function. `onClose` should then set the state of the `open` prop to hide the Snackbar. This behavior is disabled by default with the `null` value.
  static member inline autoHideDuration(value: int option) = Interop.mkAttr "autoHideDuration" value
  /// Replace the `SnackbarContent` component.
  static member inline children(value: ReactElement) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.snackbar` to specify class names.
  static member inline classes(classNames: classes.ISnackbarClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Props applied to the `ClickAwayListener` element.
  static member inline ClickAwayListenerProps(props: IReactProperty list) = Interop.mkAttr "ClickAwayListenerProps" (createObj !!props)
  /// Props applied to the [`SnackbarContent`](https://material-ui.com/api/snackbar-content/) element.
  static member inline ContentProps(props: IReactProperty list) = Interop.mkAttr "ContentProps" (createObj !!props)
  /// If `true`, the `autoHideDuration` timer will expire even if the window is not focused.
  static member inline disableWindowBlurListener(value: bool) = Interop.mkAttr "disableWindowBlurListener" value
  /// When displaying multiple consecutive Snackbars from a parent rendering a single <Snackbar/>, add the key prop to ensure independent treatment of each message. e.g. <snackbar key="{message}"></snackbar>, otherwise, the message may update-in-place and features such as autoHideDuration may be canceled.
  static member inline key(value: 'a) = Interop.mkAttr "key" value
  /// The message to display.
  static member inline message(value: ReactElement) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message(values: ReactElement seq) = Interop.mkAttr "message" values
  /// The message to display.
  static member inline message(value: string) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message(values: string seq) = Interop.mkAttr "message" values
  /// The message to display.
  static member inline message(value: int) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message(value: float) = Interop.mkAttr "message" value
  /// Callback fired when the component requests to be closed. Typically `onClose` is used to set state in the parent component, which is used to control the `Snackbar` `open` prop. The `reason` parameter can optionally be used to control the response to `onClose`, for example ignoring `clickaway`.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *reason:* Can be:`"timeout"` (`autoHideDuration` expired) or: `"clickaway"`
  static member inline onClose(handler: Event -> SnackbarCloseReason -> unit) = Interop.mkAttr "onClose" (System.Func<_,_,_> handler)
  /// Callback fired when the component requests to be closed. Typically `onClose` is used to set state in the parent component, which is used to control the `Snackbar` `open` prop. The `reason` parameter can optionally be used to control the response to `onClose`, for example ignoring `clickaway`.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, reason: string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *reason:* Can be:`"timeout"` (`autoHideDuration` expired) or: `"clickaway"`
  static member inline onClose(handler: SnackbarCloseReason -> unit) = Interop.mkAttr "onClose" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired before the transition is entering.
  static member inline onEnter(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEnter" handler
  /// Callback fired when the transition has entered.
  static member inline onEntered(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntered" handler
  /// Callback fired when the transition is entering.
  static member inline onEntering(handler: ReactElement -> bool -> unit) = Interop.mkAttr "onEntering" handler
  /// Callback fired before the transition is exiting.
  static member inline onExit(handler: ReactElement -> unit) = Interop.mkAttr "onExit" handler
  /// Callback fired when the transition has exited.
  static member inline onExited(handler: ReactElement -> unit) = Interop.mkAttr "onExited" handler
  /// Callback fired when the transition is exiting.
  static member inline onExiting(handler: ReactElement -> unit) = Interop.mkAttr "onExiting" handler
  /// If true, `Snackbar` is open.
  static member inline open'(value: bool) = Interop.mkAttr "open" value
  /// The number of milliseconds to wait before dismissing after user interaction. If `autoHideDuration` prop isn't specified, it does nothing. If `autoHideDuration` prop is specified but `resumeHideDuration` isn't, we default to `autoHideDuration / 2` ms.
  static member inline resumeHideDuration(value: int) = Interop.mkAttr "resumeHideDuration" value
  /// The component used for the transition.
  static member inline TransitionComponent(value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration(value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member transitionDuration(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "transitionDuration"
  /// Props applied to the `Transition` element.
  static member inline TransitionProps(props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module snackbar =

  /// The anchor of the `Snackbar`.
  [<Erase>]
  type anchorOrigin =
    static member inline topLeft = Interop.mkAttr "anchorOrigin" {| vertical = "top"; horizontal = "left" |}
    static member inline topCenter = Interop.mkAttr "anchorOrigin" {| vertical = "top"; horizontal = "center" |}
    static member inline topRight = Interop.mkAttr "anchorOrigin" {| vertical = "top"; horizontal = "right" |}
    static member inline bottomLeft = Interop.mkAttr "anchorOrigin" {| vertical = "bottom"; horizontal = "left" |}
    static member inline bottomCenter = Interop.mkAttr "anchorOrigin" {| vertical = "bottom"; horizontal = "center" |}
    static member inline bottomRight = Interop.mkAttr "anchorOrigin" {| vertical = "bottom"; horizontal = "right" |}


[<Erase>]
type snackbarContent =
  /// The action to display.
  static member inline action(value: ReactElement) = Interop.mkAttr "action" value
  /// The action to display.
  static member inline action(values: ReactElement seq) = Interop.mkAttr "action" values
  /// The action to display.
  static member inline action(value: string) = Interop.mkAttr "action" value
  /// The action to display.
  static member inline action(values: string seq) = Interop.mkAttr "action" values
  /// The action to display.
  static member inline action(value: int) = Interop.mkAttr "action" value
  /// The action to display.
  static member inline action(value: float) = Interop.mkAttr "action" value
  /// Override or extend the styles applied to the component. Use `classes.snackbarContent` to specify class names.
  static member inline classes(classNames: classes.ISnackbarContentClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The message to display.
  static member inline message(value: ReactElement) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message(values: ReactElement seq) = Interop.mkAttr "message" values
  /// The message to display.
  static member inline message(value: string) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message(values: string seq) = Interop.mkAttr "message" values
  /// The message to display.
  static member inline message(value: int) = Interop.mkAttr "message" value
  /// The message to display.
  static member inline message(value: float) = Interop.mkAttr "message" value


type speedDial =
  /// The aria-label of the `Button` element. Also used to provide the `id` for the `SpeedDial` element and its children.
  static member inline ariaLabel(value: string) = Interop.mkAttr "ariaLabel" value
  /// Props applied to the [`Button`](https://material-ui.com/api/button/) element.
  static member inline ButtonProps(props: IReactProperty list) = Interop.mkAttr "ButtonProps" (createObj !!props)
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children(element: ReactElement) = prop.children element
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// SpeedDialActions to display when the SpeedDial is `open`.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.speedDial` to specify class names.
  static member inline classes(classNames: classes.ISpeedDialClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the SpeedDial will be hidden.
  static member inline hidden(value: bool) = Interop.mkAttr "hidden" value
  /// The icon to display in the SpeedDial Floating Action Button. The `SpeedDialIcon` component provides a default Icon with animation.
  static member inline icon(value: ReactElement) = Interop.mkAttr "icon" value
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, key: string) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *key:* The key pressed
  static member inline onClose(handler: Event -> string -> unit) = Interop.mkAttr "onClose" (System.Func<_,_,_> handler)
  /// If `true`, the SpeedDial is open.
  static member inline open'(value: bool) = Interop.mkAttr "open" value
  /// The icon to display in the SpeedDial Floating Action Button when the SpeedDial is open.
  static member inline openIcon(element: ReactElement) = Interop.mkAttr "openIcon" element
  /// The component used for the transition.
  static member inline TransitionComponent(value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration(value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member transitionDuration(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "transitionDuration"
  /// Props applied to the `Transition` element.
  static member inline TransitionProps(props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module speedDial =

  /// The direction the actions open relative to the floating action button.
  [<Erase>]
  type direction =
    static member inline up = Interop.mkAttr "direction" "up"
    static member inline down = Interop.mkAttr "direction" "down"
    static member inline left = Interop.mkAttr "direction" "left"
    static member inline right = Interop.mkAttr "direction" "right"


[<Erase>]
type speedDialAction =
  /// Props applied to the [`Button`](https://material-ui.com/api/button/) component.
  static member inline ButtonProps(props: IReactProperty list) = Interop.mkAttr "ButtonProps" (createObj !!props)
  /// Override or extend the styles applied to the component. Use `classes.speedDialAction` to specify class names.
  static member inline classes(classNames: classes.ISpeedDialActionClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Adds a transition delay, to allow a series of SpeedDialActions to be animated.
  static member inline delay(value: int) = Interop.mkAttr "delay" value
  /// The Icon to display in the SpeedDial Floating Action Button.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element
  /// Classes applied to the [`Tooltip`](https://material-ui.com/api/tooltip/) element.
  static member inline TooltipClasses(classNames: classes.ITooltipClasses list) = Interop.mkAttr "TooltipClasses" (createObj !!classNames)
  /// Make the tooltip always visible when the SpeedDial is open.
  static member inline tooltipOpen(value: bool) = Interop.mkAttr "tooltipOpen" value
  /// Label to display in the tooltip.
  static member inline tooltipTitle(value: ReactElement) = Interop.mkAttr "tooltipTitle" value
  /// Label to display in the tooltip.
  static member inline tooltipTitle(values: ReactElement seq) = Interop.mkAttr "tooltipTitle" values
  /// Label to display in the tooltip.
  static member inline tooltipTitle(value: string) = Interop.mkAttr "tooltipTitle" value
  /// Label to display in the tooltip.
  static member inline tooltipTitle(values: string seq) = Interop.mkAttr "tooltipTitle" values
  /// Label to display in the tooltip.
  static member inline tooltipTitle(value: int) = Interop.mkAttr "tooltipTitle" value
  /// Label to display in the tooltip.
  static member inline tooltipTitle(value: float) = Interop.mkAttr "tooltipTitle" value

module speedDialAction =

  /// Placement of the tooltip.
  [<Erase>]
  type tooltipPlacement =
    static member inline bottomEnd = Interop.mkAttr "tooltipPlacement" "bottom-end"
    static member inline bottomStart = Interop.mkAttr "tooltipPlacement" "bottom-start"
    static member inline bottom = Interop.mkAttr "tooltipPlacement" "bottom"
    static member inline leftEnd = Interop.mkAttr "tooltipPlacement" "left-end"
    static member inline leftStart = Interop.mkAttr "tooltipPlacement" "left-start"
    static member inline left = Interop.mkAttr "tooltipPlacement" "left"
    static member inline rightEnd = Interop.mkAttr "tooltipPlacement" "right-end"
    static member inline rightStart = Interop.mkAttr "tooltipPlacement" "right-start"
    static member inline right = Interop.mkAttr "tooltipPlacement" "right"
    static member inline topEnd = Interop.mkAttr "tooltipPlacement" "top-end"
    static member inline topStart = Interop.mkAttr "tooltipPlacement" "top-start"
    static member inline top = Interop.mkAttr "tooltipPlacement" "top"


[<Erase>]
type speedDialIcon =
  /// Override or extend the styles applied to the component. Use `classes.speedDialIcon` to specify class names.
  static member inline classes(classNames: classes.ISpeedDialIconClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The icon to display in the SpeedDial Floating Action Button.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element
  /// The icon to display in the SpeedDial Floating Action Button when the SpeedDial is open.
  static member inline openIcon(element: ReactElement) = Interop.mkAttr "openIcon" element


[<Erase>]
type step =
  /// Sets the step as active. Is passed to child components.
  static member inline active(value: bool) = Interop.mkAttr "active" value
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children(element: ReactElement) = prop.children element
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Should be `Step` sub-components such as `StepLabel`, `StepContent`.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.step` to specify class names.
  static member inline classes(classNames: classes.IStepClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Mark the step as completed. Is passed to child components.
  static member inline completed(value: bool) = Interop.mkAttr "completed" value
  /// Mark the step as disabled, will also disable the button if `StepButton` is a child of `Step`. Is passed to child components.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value


[<Erase>]
type stepButton =
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children(element: ReactElement) = prop.children element
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Can be a `StepLabel` or a node to place inside `StepLabel` as children.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.stepButton` to specify class names.
  static member inline classes(classNames: classes.IStepButtonClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The icon displayed by the step label.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element
  /// The optional node to display.
  static member inline optional(value: ReactElement) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional(values: ReactElement seq) = Interop.mkAttr "optional" values
  /// The optional node to display.
  static member inline optional(value: string) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional(values: string seq) = Interop.mkAttr "optional" values
  /// The optional node to display.
  static member inline optional(value: int) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional(value: float) = Interop.mkAttr "optional" value


[<Erase>]
type stepConnector =
  /// Override or extend the styles applied to the component. Use `classes.stepConnector` to specify class names.
  static member inline classes(classNames: classes.IStepConnectorClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)


type stepContent =
  /// Step content.
  static member inline children(element: ReactElement) = prop.children element
  /// Step content.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Step content.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Step content.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Step content.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Step content.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.stepContent` to specify class names.
  static member inline classes(classNames: classes.IStepContentClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the transition.
  static member inline TransitionComponent(value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Adjust the duration of the content expand transition. Passed as a prop to the transition component.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member inline transitionDuration(value: int) = Interop.mkAttr "transitionDuration" value
  /// Adjust the duration of the content expand transition. Passed as a prop to the transition component.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  static member transitionDuration(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "transitionDuration"
  /// Props applied to the `Transition` element.
  static member inline TransitionProps(props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module stepContent =

  /// Adjust the duration of the content expand transition. Passed as a prop to the transition component.
  ///
  /// Set to 'auto' to automatically calculate transition time based on height.
  [<Erase>]
  type transitionDuration =
    static member inline auto = Interop.mkAttr "transitionDuration" "auto"


[<Erase>]
type stepIcon =
  /// Whether this step is active.
  static member inline active(value: bool) = Interop.mkAttr "active" value
  /// Override or extend the styles applied to the component. Use `classes.stepIcon` to specify class names.
  static member inline classes(classNames: classes.IStepIconClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Mark the step as completed. Is passed to child components.
  static member inline completed(value: bool) = Interop.mkAttr "completed" value
  /// Mark the step as failed.
  static member inline error(value: bool) = Interop.mkAttr "error" value
  /// The label displayed in the step icon.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element


[<Erase>]
type stepLabel =
  /// In most cases will simply be a string containing a title for the label.
  static member inline children(element: ReactElement) = prop.children element
  /// In most cases will simply be a string containing a title for the label.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// In most cases will simply be a string containing a title for the label.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// In most cases will simply be a string containing a title for the label.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// In most cases will simply be a string containing a title for the label.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// In most cases will simply be a string containing a title for the label.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.stepLabel` to specify class names.
  static member inline classes(classNames: classes.IStepLabelClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Mark the step as disabled, will also disable the button if `StepLabelButton` is a child of `StepLabel`. Is passed to child components.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// Mark the step as failed.
  static member inline error(value: bool) = Interop.mkAttr "error" value
  /// Override the default label of the step icon.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element
  /// The optional node to display.
  static member inline optional(value: ReactElement) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional(values: ReactElement seq) = Interop.mkAttr "optional" values
  /// The optional node to display.
  static member inline optional(value: string) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional(values: string seq) = Interop.mkAttr "optional" values
  /// The optional node to display.
  static member inline optional(value: int) = Interop.mkAttr "optional" value
  /// The optional node to display.
  static member inline optional(value: float) = Interop.mkAttr "optional" value
  /// The component to render in place of the [`StepIcon`](https://material-ui.com/api/step-icon/).
  static member inline StepIconComponent(value: ReactElementType) = Interop.mkAttr "StepIconComponent" value
  /// Props applied to the [`StepIcon`](https://material-ui.com/api/step-icon/) element.
  static member inline StepIconProps(props: IReactProperty list) = Interop.mkAttr "StepIconProps" (createObj !!props)


[<Erase>]
type stepper =
  /// Set the active step (zero based index).
  static member inline activeStep(value: int) = Interop.mkAttr "activeStep" value
  /// If set to 'true' and orientation is horizontal, then the step label will be positioned under the icon.
  static member inline alternativeLabel(value: bool) = Interop.mkAttr "alternativeLabel" value
  /// Two or more `<Step />` components.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Override or extend the styles applied to the component. Use `classes.stepper` to specify class names.
  static member inline classes(classNames: classes.IStepperClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// An element to be placed between each step.
  static member inline connector(value: ReactElement) = Interop.mkAttr "connector" value
  /// If set the `Stepper` will not assist in controlling steps for linear flow.
  static member inline nonLinear(value: bool) = Interop.mkAttr "nonLinear" value

module stepper =

  /// The stepper orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"


[<Erase>]
type svgIcon =
  /// Node passed into the SVG element.
  static member inline children(element: ReactElement) = prop.children element
  /// Node passed into the SVG element.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Node passed into the SVG element.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Node passed into the SVG element.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Node passed into the SVG element.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Node passed into the SVG element.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.svgIcon` to specify class names.
  static member inline classes(classNames: classes.ISvgIconClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Applies a color attribute to the SVG element.
  static member inline htmlColor(value: string) = Interop.mkAttr "htmlColor" value
  /// The shape-rendering attribute. The behavior of the different options is described on the [MDN Web Docs](https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/shape-rendering). If you are having issues with blurry icons you should investigate this property.
  static member inline shapeRendering(value: string) = Interop.mkAttr "shapeRendering" value
  /// Provides a human-readable title for the element that contains it. https://www.w3.org/TR/SVG-access/#Equivalent
  static member inline titleAccess(value: string) = Interop.mkAttr "titleAccess" value
  /// Allows you to redefine what the coordinates without units mean inside an SVG element. For example, if the SVG element is 500 (width) by 200 (height), and you pass viewBox="0 0 50 20", this means that the coordinates inside the SVG will go from the top left corner (0,0) to bottom right (50,20) and each unit will be worth 10px.
  static member inline viewBox(value: string) = Interop.mkAttr "viewBox" value

module svgIcon =

  /// The color of the component. You can use the `htmlColor` prop to apply a color attribute to the SVG element.
  [<Erase>]
  type color =
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline action = Interop.mkAttr "color" "action"
    static member inline error = Interop.mkAttr "color" "error"
    static member inline disabled = Interop.mkAttr "color" "disabled"

  /// The fontSize applied to the icon. Defaults to 24px, but can be configure to inherit font size.
  [<Erase>]
  type fontSize =
    static member inline inherit' = Interop.mkAttr "fontSize" "inherit"
    static member inline default' = Interop.mkAttr "fontSize" "default"
    static member inline small = Interop.mkAttr "fontSize" "small"
    static member inline large = Interop.mkAttr "fontSize" "large"


type swipeableDrawer =
  /// Disable the backdrop transition. This can improve the FPS on low-end devices.
  static member inline disableBackdropTransition(value: bool) = Interop.mkAttr "disableBackdropTransition" value
  /// If `true`, touching the screen near the edge of the drawer will not slide in the drawer a bit to promote accidental discovery of the swipe gesture.
  static member inline disableDiscovery(value: bool) = Interop.mkAttr "disableDiscovery" value
  /// If `true`, swipe to open is disabled. This is useful in browsers where swiping triggers navigation actions. Swipe to open is disabled on iOS browsers by default.
  static member inline disableSwipeToOpen(value: bool) = Interop.mkAttr "disableSwipeToOpen" value
  /// Affects how far the drawer must be opened/closed to change his state. Specified as percent (0-1) of the width of the drawer
  static member inline hysteresis(value: float) = Interop.mkAttr "hysteresis" value
  /// Defines, from which (average) velocity on, the swipe is defined as complete although hysteresis isn't reached. Good threshold is between 250 - 1000 px/s
  static member inline minFlingVelocity(value: int) = Interop.mkAttr "minFlingVelocity" value
  /// Callback fired when the component requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback
  static member inline onClose(handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback fired when the component requests to be opened.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback
  static member inline onOpen(handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// If `true`, the drawer is open.
  static member inline open'(value: bool) = Interop.mkAttr "open" value
  /// Props applied to the swipe area element.
  static member inline SwipeAreaProps(props: IReactProperty list) = Interop.mkAttr "SwipeAreaProps" (createObj !!props)
  /// The width of the left most (or right most) area in pixels where the drawer can be swiped open from.
  static member inline swipeAreaWidth(value: int) = Interop.mkAttr "swipeAreaWidth" value
  /// The duration for the transition, in milliseconds.
  static member inline transitionDuration(value: int) = Interop.mkAttr "transitionDuration" value
  /// The duration for the transition, in milliseconds.
  static member transitionDuration(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "transitionDuration"


[<Erase>]
type switch =
  /// If `true`, the component is checked.
  static member inline checked'(value: bool) = Interop.mkAttr "checked" value
  /// The icon to display when the component is checked.
  static member inline checkedIcon(element: ReactElement) = Interop.mkAttr "checkedIcon" element
  /// Override or extend the styles applied to the component. Use `classes.switch` to specify class names.
  static member inline classes(classNames: classes.ISwitchClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the switch will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple(value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon to display when the component is unchecked.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element
  /// The id of the `input` element.
  static member inline id(value: string) = Interop.mkAttr "id" value
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps(props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(ref: IRefValue<HTMLInputElement option>) = Interop.mkAttr "inputRef" ref
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(handler: HTMLInputElement -> unit) = Interop.mkAttr "inputRef" handler
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, checked: boolean) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.target.checked`.
  ///
  /// *checked:* The `checked` value of the switch
  static member inline onChange(handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the state is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, checked: boolean) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.target.checked`.
  ///
  /// *checked:* The `checked` value of the switch
  static member inline onChange(handler: bool -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Checked)
  /// If `true`, the `input` element will be required.
  static member inline required(value: bool) = Interop.mkAttr "required" value
  /// The input component prop `type`.
  static member inline type'(value: string) = Interop.mkAttr "type" value
  /// The value of the component.
  static member inline value(value: 'a) = Interop.mkAttr "value" value

module switch =

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline default' = Interop.mkAttr "color" "default"

  /// If given, uses a negative margin to counteract the padding on one side (this is often helpful for aligning the left or right side of the icon with content above or below, without ruining the border size and shape).
  [<Erase>]
  type edge =
    static member inline start = Interop.mkAttr "edge" "start"
    static member inline end' = Interop.mkAttr "edge" "end"
    static member inline false' = Interop.mkAttr "edge" false

  /// The size of the switch. `small` is equivalent to the dense switch styling.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"


[<Erase>]
type tab =
  /// Override or extend the styles applied to the component. Use `classes.tab` to specify class names.
  static member inline classes(classNames: classes.ITabClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the tab will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the keyboard focus ripple will be disabled. `disableRipple` must also be true.
  static member inline disableFocusRipple(value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple(value: bool) = Interop.mkAttr "disableRipple" value
  /// The icon element.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element
  /// The label element.
  static member inline label(value: ReactElement) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label(values: ReactElement seq) = Interop.mkAttr "label" values
  /// The label element.
  static member inline label(value: string) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label(values: string seq) = Interop.mkAttr "label" values
  /// The label element.
  static member inline label(value: int) = Interop.mkAttr "label" value
  /// The label element.
  static member inline label(value: float) = Interop.mkAttr "label" value
  /// You can provide your own value. Otherwise, we fallback to the child position index.
  static member inline value(value: 'a) = Interop.mkAttr "value" value
  /// Tab labels appear in a single row. They can use a second line if needed.
  static member inline wrapped(value: bool) = Interop.mkAttr "wrapped" value


[<Erase>]
type table =
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the table, normally `TableHead` and `TableBody`.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.table` to specify class names.
  static member inline classes(classNames: classes.ITableClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value

module table =

  /// Allows TableCells to inherit padding of the Table.
  [<Erase>]
  type padding =
    static member inline default' = Interop.mkAttr "padding" "default"
    static member inline checkbox = Interop.mkAttr "padding" "checkbox"
    static member inline none = Interop.mkAttr "padding" "none"

  /// Allows TableCells to inherit size of the Table.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"


[<Erase>]
type tableBody =
  /// The content of the component, normally `TableRow`.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component, normally `TableRow`.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component, normally `TableRow`.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component, normally `TableRow`.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.tableBody` to specify class names.
  static member inline classes(classNames: classes.ITableBodyClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value


[<Erase>]
type tableCell =
  /// The table cell contents.
  static member inline children(element: ReactElement) = prop.children element
  /// The table cell contents.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The table cell contents.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The table cell contents.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The table cell contents.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The table cell contents.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.tableCell` to specify class names.
  static member inline classes(classNames: classes.ITableCellClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Set scope attribute.
  static member inline scope(value: string) = Interop.mkAttr "scope" value

module tableCell =

  /// Set the text-align on the table cell content.
  ///
  /// Monetary or generally number fields **should be right aligned** as that allows you to add them up quickly in your head without having to worry about decimals.
  [<Erase>]
  type align =
    static member inline inherit' = Interop.mkAttr "align" "inherit"
    static member inline left = Interop.mkAttr "align" "left"
    static member inline center = Interop.mkAttr "align" "center"
    static member inline right = Interop.mkAttr "align" "right"
    static member inline justify = Interop.mkAttr "align" "justify"

  /// Sets the padding applied to the cell. By default, the Table parent component set the value (`default`).
  [<Erase>]
  type padding =
    static member inline default' = Interop.mkAttr "padding" "default"
    static member inline checkbox = Interop.mkAttr "padding" "checkbox"
    static member inline none = Interop.mkAttr "padding" "none"

  /// Specify the size of the cell. By default, the Table parent component set the value (`medium`).
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"

  /// Set aria-sort direction.
  [<Erase>]
  type sortDirection =
    static member inline asc = Interop.mkAttr "sortDirection" "asc"
    static member inline desc = Interop.mkAttr "sortDirection" "desc"
    static member inline false' = Interop.mkAttr "sortDirection" false

  /// Specify the cell type. By default, the TableHead, TableBody or TableFooter parent component set the value.
  [<Erase>]
  type variant =
    static member inline head = Interop.mkAttr "variant" "head"
    static member inline body = Interop.mkAttr "variant" "body"
    static member inline footer = Interop.mkAttr "variant" "footer"


[<Erase>]
type tableFooter =
  /// The content of the component, normally `TableRow`.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component, normally `TableRow`.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component, normally `TableRow`.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component, normally `TableRow`.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.tableFooter` to specify class names.
  static member inline classes(classNames: classes.ITableFooterClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value


[<Erase>]
type tableHead =
  /// The content of the component, normally `TableRow`.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component, normally `TableRow`.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component, normally `TableRow`.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component, normally `TableRow`.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component, normally `TableRow`.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.tableHead` to specify class names.
  static member inline classes(classNames: classes.ITableHeadClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value


type tablePagination =
  /// The component used for displaying the actions. Either a string to use a DOM element or a component.
  static member inline ActionsComponent(value: ReactElementType) = Interop.mkAttr "ActionsComponent" value
  /// Props applied to the back arrow [`IconButton`](https://material-ui.com/api/icon-button/) component.
  static member inline backIconButtonProps(props: IReactProperty list) = Interop.mkAttr "backIconButtonProps" (createObj !!props)
  /// Override or extend the styles applied to the component. Use `classes.tablePagination` to specify class names.
  static member inline classes(classNames: classes.ITablePaginationClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// The total number of rows.
  static member inline count(value: int) = Interop.mkAttr "count" value
  /// Customize the displayed rows label.
  static member labelDisplayedRows(getLabel: {| from: int; to': int; count: int |} -> ReactElement) = Interop.mkAttr "labelDisplayedRows" getLabel
  /// Customize the rows per page label. Invoked with a `{ from, to, count, page }` object.
  static member inline labelRowsPerPage(value: ReactElement) = Interop.mkAttr "labelRowsPerPage" value
  /// Customize the rows per page label. Invoked with a `{ from, to, count, page }` object.
  static member inline labelRowsPerPage(values: ReactElement seq) = Interop.mkAttr "labelRowsPerPage" values
  /// Customize the rows per page label. Invoked with a `{ from, to, count, page }` object.
  static member inline labelRowsPerPage(value: string) = Interop.mkAttr "labelRowsPerPage" value
  /// Customize the rows per page label. Invoked with a `{ from, to, count, page }` object.
  static member inline labelRowsPerPage(values: string seq) = Interop.mkAttr "labelRowsPerPage" values
  /// Customize the rows per page label. Invoked with a `{ from, to, count, page }` object.
  static member inline labelRowsPerPage(value: int) = Interop.mkAttr "labelRowsPerPage" value
  /// Customize the rows per page label. Invoked with a `{ from, to, count, page }` object.
  static member inline labelRowsPerPage(value: float) = Interop.mkAttr "labelRowsPerPage" value
  /// Props applied to the next arrow [`IconButton`](https://material-ui.com/api/icon-button/) element.
  static member inline nextIconButtonProps(props: IReactProperty list) = Interop.mkAttr "nextIconButtonProps" (createObj !!props)
  /// Callback fired when the page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, page: number) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *page:* The page selected
  static member inline onChangePage(handler: Event -> int -> unit) = Interop.mkAttr "onChangePage" (System.Func<_,_,_> handler)
  /// Callback fired when the page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, page: number) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *page:* The page selected
  static member inline onChangePage(handler: int -> unit) = Interop.mkAttr "onChangePage" (System.Func<_,_,_> (fun _ v -> handler v))
  /// Callback fired when the number of rows per page is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback
  static member inline onChangeRowsPerPage(handler: Event -> unit) = Interop.mkAttr "onChangeRowsPerPage" handler
  /// The zero-based index of the current page.
  static member inline page(value: int) = Interop.mkAttr "page" value
  /// The number of rows per page.
  static member inline rowsPerPage(value: int) = Interop.mkAttr "rowsPerPage" value
  /// Customizes the options of the rows per page select field. If less than two options are available, no select field will be displayed.
  static member inline rowsPerPageOptions([<ParamArray>] values: int []) = Interop.mkAttr "rowsPerPageOptions" values
  /// Props applied to the rows per page [`Select`](https://material-ui.com/api/select/) element.
  static member inline SelectProps(props: IReactProperty list) = Interop.mkAttr "SelectProps" (createObj !!props)


[<Erase>]
type tableRow =
  /// Should be valid `<tr>` children such as `TableCell`.
  static member inline children(element: ReactElement) = prop.children element
  /// Should be valid `<tr>` children such as `TableCell`.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Override or extend the styles applied to the component. Use `classes.tableRow` to specify class names.
  static member inline classes(classNames: classes.ITableRowClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the table row will shade on hover.
  static member inline hover(value: bool) = Interop.mkAttr "hover" value
  /// If `true`, the table row will have the selected shading.
  static member inline selected(value: bool) = Interop.mkAttr "selected" value


[<Erase>]
type tableSortLabel =
  /// If `true`, the label will have the active styling (should be true for the sorted column).
  static member inline active(value: bool) = Interop.mkAttr "active" value
  /// Label contents, the arrow will be appended automatically.
  static member inline children(element: ReactElement) = prop.children element
  /// Label contents, the arrow will be appended automatically.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Label contents, the arrow will be appended automatically.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Label contents, the arrow will be appended automatically.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Label contents, the arrow will be appended automatically.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Label contents, the arrow will be appended automatically.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.tableSortLabel` to specify class names.
  static member inline classes(classNames: classes.ITableSortLabelClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Hide sort icon when active is false.
  static member inline hideSortIcon(value: bool) = Interop.mkAttr "hideSortIcon" value
  /// Sort icon to use.
  static member inline IconComponent(value: ReactElementType) = Interop.mkAttr "IconComponent" value

module tableSortLabel =

  /// The current sort direction.
  [<Erase>]
  type direction =
    static member inline asc = Interop.mkAttr "direction" "asc"
    static member inline desc = Interop.mkAttr "direction" "desc"


[<Erase>]
type tabs =
  /// Callback fired when the component mounts. This is useful when you want to trigger an action programmatically. It currently only supports `updateIndicator()` action.
  ///
  /// **Signature:**
  ///
  /// `function(actions: object) => void`
  ///
  /// *actions:* This object contains all possible actions that can be triggered programmatically.
  static member inline action(ref: IRefValue<TabsActions option>) = Interop.mkAttr "action" ref
  /// Callback fired when the component mounts. This is useful when you want to trigger an action programmatically. It currently only supports `updateIndicator()` action.
  ///
  /// **Signature:**
  ///
  /// `function(actions: object) => void`
  ///
  /// *actions:* This object contains all possible actions that can be triggered programmatically.
  static member inline action(handler: TabsActions -> unit) = Interop.mkAttr "action" handler
  /// If `true`, the tabs will be centered. This property is intended for large views.
  static member inline centered(value: bool) = Interop.mkAttr "centered" value
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.tabs` to specify class names.
  static member inline classes(classNames: classes.ITabsClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* We default to the index of the child (number)
  static member inline onChange(handler: Event -> 'a -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: any) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* We default to the index of the child (number)
  static member inline onChange(handler: 'a -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> (fun _ v -> handler v))
  /// The component used to render the scroll buttons.
  static member inline ScrollButtonComponent(value: ReactElementType) = Interop.mkAttr "ScrollButtonComponent" value
  /// Props applied to the tab indicator element.
  static member inline TabIndicatorProps(props: IReactProperty list) = Interop.mkAttr "TabIndicatorProps" (createObj !!props)
  /// The value of the currently selected `Tab`. If you don't want any selected `Tab`, you can set this property to `false`.
  static member inline value(value: 'a) = Interop.mkAttr "value" value

module tabs =

  /// Determines the color of the indicator.
  [<Erase>]
  type indicatorColor =
    static member inline secondary = Interop.mkAttr "indicatorColor" "secondary"
    static member inline primary = Interop.mkAttr "indicatorColor" "primary"

  /// The tabs orientation (layout flow direction).
  [<Erase>]
  type orientation =
    static member inline horizontal = Interop.mkAttr "orientation" "horizontal"
    static member inline vertical = Interop.mkAttr "orientation" "vertical"

  /// Determine behavior of scroll buttons when tabs are set to scroll:
  ///
  /// - `auto` will only present them when not all the items are visible. - `desktop` will only present them on medium and larger viewports. - `on` will always present them. - `off` will never present them.
  [<Erase>]
  type scrollButtons =
    static member inline auto = Interop.mkAttr "scrollButtons" "auto"
    static member inline desktop = Interop.mkAttr "scrollButtons" "desktop"
    static member inline on = Interop.mkAttr "scrollButtons" "on"
    static member inline off = Interop.mkAttr "scrollButtons" "off"

  /// Determines the color of the `Tab`.
  [<Erase>]
  type textColor =
    static member inline secondary = Interop.mkAttr "textColor" "secondary"
    static member inline primary = Interop.mkAttr "textColor" "primary"
    static member inline inherit' = Interop.mkAttr "textColor" "inherit"

  /// Determines additional display behavior of the tabs:
  ///
  ///  - `scrollable` will invoke scrolling properties and allow for horizontally scrolling (or swiping) of the tab bar. -`fullWidth` will make the tabs grow to use all the available space, which should be used for small views, like on mobile. - `standard` will render the default state.
  [<Erase>]
  type variant =
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline scrollable = Interop.mkAttr "variant" "scrollable"
    static member inline fullWidth = Interop.mkAttr "variant" "fullWidth"


[<Erase>]
type textareaAutosize =
  /// Minimum number of rows to display.
  static member inline rows(value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display.
  static member inline rowsMax(value: int) = Interop.mkAttr "rowsMax" value


[<Erase>]
type textField =
  /// This prop helps users to fill forms faster, especially on mobile devices. The name can be confusing, as it's more like an autofill. You can learn more about it [following the specification](https://html.spec.whatwg.org/multipage/form-control-infrastructure.html#autofill).
  static member inline autoComplete(value: string) = Interop.mkAttr "autoComplete" value
  /// If `true`, the `input` element will be focused during the first mount.
  static member inline autoFocus(value: bool) = Interop.mkAttr "autoFocus" value
  /// Override or extend the styles applied to the component. Use `classes.textField` to specify class names.
  static member inline classes(classNames: classes.ITextFieldClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The default value of the `input` element.
  static member inline defaultValue(value: 'a) = Interop.mkAttr "defaultValue" value
  /// If `true`, the `input` element will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the label will be displayed in an error state.
  static member inline error(value: bool) = Interop.mkAttr "error" value
  /// Props applied to the [`FormHelperText`](https://material-ui.com/api/form-helper-text/) element.
  static member inline FormHelperTextProps(props: IReactProperty list) = Interop.mkAttr "FormHelperTextProps" (createObj !!props)
  /// If `true`, the input will take up the full width of its container.
  static member inline fullWidth(value: bool) = Interop.mkAttr "fullWidth" value
  /// The helper text content.
  static member inline helperText(value: ReactElement) = Interop.mkAttr "helperText" value
  /// The helper text content.
  static member inline helperText(values: ReactElement seq) = Interop.mkAttr "helperText" values
  /// The helper text content.
  static member inline helperText(value: string) = Interop.mkAttr "helperText" value
  /// The helper text content.
  static member inline helperText(values: string seq) = Interop.mkAttr "helperText" values
  /// The helper text content.
  static member inline helperText(value: int) = Interop.mkAttr "helperText" value
  /// The helper text content.
  static member inline helperText(value: float) = Interop.mkAttr "helperText" value
  /// The id of the `input` element. Use this prop to make `label` and `helperText` accessible for screen readers.
  static member inline id(value: string) = Interop.mkAttr "id" value
  /// Props applied to the [`InputLabel`](https://material-ui.com/api/input-label/) element.
  static member inline InputLabelProps(props: IReactProperty list) = Interop.mkAttr "InputLabelProps" (createObj !!props)
  /// Props applied to the Input element. It will be a [`FilledInput`](https://material-ui.com/api/filled-input/), [`OutlinedInput`](https://material-ui.com/api/outlined-input/) or [`Input`](https://material-ui.com/api/input/) component depending on the `variant` prop value.
  static member inline InputProps(props: IReactProperty list) = Interop.mkAttr "InputProps" (createObj !!props)
  /// [Attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Attributes) applied to the `input` element.
  static member inline inputProps(props: IReactProperty list) = Interop.mkAttr "inputProps" (createObj !!props)
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(ref: IRefValue<HTMLInputElement option>) = Interop.mkAttr "inputRef" ref
  /// This prop can be used to pass a ref callback to the `input` element.
  static member inline inputRef(handler: HTMLInputElement -> unit) = Interop.mkAttr "inputRef" handler
  /// The label content.
  static member inline label(value: ReactElement) = Interop.mkAttr "label" value
  /// The label content.
  static member inline label(values: ReactElement seq) = Interop.mkAttr "label" values
  /// The label content.
  static member inline label(value: string) = Interop.mkAttr "label" value
  /// The label content.
  static member inline label(values: string seq) = Interop.mkAttr "label" values
  /// The label content.
  static member inline label(value: int) = Interop.mkAttr "label" value
  /// The label content.
  static member inline label(value: float) = Interop.mkAttr "label" value
  /// If `true`, a textarea element will be rendered instead of an input.
  static member inline multiline(value: bool) = Interop.mkAttr "multiline" value
  /// Name attribute of the `input` element.
  static member inline name(value: string) = Interop.mkAttr "name" value
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: Event -> unit) = Interop.mkAttr "onChange" handler
  /// Callback fired when the value is changed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback. You can pull out the new value by accessing `event.Value`.
  static member inline onChange(handler: string -> unit) = Interop.mkAttr "onChange" (fun (e: Event) -> handler e.Value)
  /// The short hint displayed in the input before the user enters a value.
  static member inline placeholder(value: string) = Interop.mkAttr "placeholder" value
  /// If `true`, the label is displayed as required and the `input` element` will be required.
  static member inline required(value: bool) = Interop.mkAttr "required" value
  /// Number of rows to display when multiline option is set to true.
  static member inline rows(value: int) = Interop.mkAttr "rows" value
  /// Maximum number of rows to display when multiline option is set to true.
  static member inline rowsMax(value: int) = Interop.mkAttr "rowsMax" value
  /// Render a [`Select`](https://material-ui.com/api/select/) element while passing the Input element to `Select` as `input` parameter. If this option is set you must pass the options of the select as children.
  static member inline select(value: bool) = Interop.mkAttr "select" value
  /// Props applied to the [`Select`](https://material-ui.com/api/select/) element.
  static member inline SelectProps(props: IReactProperty list) = Interop.mkAttr "SelectProps" (createObj !!props)
  /// Type of the `input` element. It should be [a valid HTML5 input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#Form_%3Cinput%3E_types).
  static member inline type'(value: string) = Interop.mkAttr "type" value
  /// The value of the `input` element, required for a controlled component.
  static member inline value(value: 'a) = Interop.mkAttr "value" value

module textField =

  /// If `dense` or `normal`, will adjust vertical spacing of this and contained components.
  [<Erase>]
  type margin =
    static member inline none = Interop.mkAttr "margin" "none"
    static member inline dense = Interop.mkAttr "margin" "dense"
    static member inline normal = Interop.mkAttr "margin" "normal"

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline standard = Interop.mkAttr "variant" "standard"
    static member inline outlined = Interop.mkAttr "variant" "outlined"
    static member inline filled = Interop.mkAttr "variant" "filled"


[<Erase>]
type toggleButton =
  /// The content of the button.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the button.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the button.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the button.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.toggleButton` to specify class names.
  static member inline classes(classNames: classes.IToggleButtonClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, the button will be disabled.
  static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
  /// If `true`, the keyboard focus ripple will be disabled. `disableRipple` must also be true.
  static member inline disableFocusRipple(value: bool) = Interop.mkAttr "disableFocusRipple" value
  /// If `true`, the ripple effect will be disabled.
  static member inline disableRipple(value: bool) = Interop.mkAttr "disableRipple" value
  /// If `true`, the button will be rendered in an active state.
  static member inline selected(value: bool) = Interop.mkAttr "selected" value
  /// The value to associate with the button when selected in a ToggleButtonGroup.
  static member inline value(value: 'a) = Interop.mkAttr "value" value


[<Erase>]
type toggleButtonGroup =
  /// The content of the button.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the button.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the button.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the button.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the button.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.toggleButtonGroup` to specify class names.
  static member inline classes(classNames: classes.IToggleButtonGroupClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// If `true`, only allow one of the child ToggleButton values to be selected.
  static member inline exclusive(value: bool) = Interop.mkAttr "exclusive" value
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: object) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* of the selected buttons. When `exclusive` is true this is a single value; when false an array of selected values. If no value is selected and `exclusive` is true the value is null; when false an empty array.
  static member inline onChange(handler: Event -> 'a -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> handler)
  /// Callback fired when the value changes.
  ///
  /// **Signature:**
  ///
  /// `function(event: object, value: object) => void`
  ///
  /// *event:* The event source of the callback
  ///
  /// *value:* of the selected buttons. When `exclusive` is true this is a single value; when false an array of selected values. If no value is selected and `exclusive` is true the value is null; when false an empty array.
  static member inline onChange(handler: 'a -> unit) = Interop.mkAttr "onChange" (System.Func<_,_,_> (fun _ v -> handler v))
  /// The currently selected value within the group or an array of selected values when `exclusive` is false.
  static member inline value(value: 'toggleButtonValue option) = Interop.mkAttr "value" value
  /// The currently selected value within the group or an array of selected values when `exclusive` is false.
  static member inline value(values: 'toggleButtonValue []) = Interop.mkAttr "value" values

module toggleButtonGroup =

  /// The size of the buttons.
  [<Erase>]
  type size =
    static member inline small = Interop.mkAttr "size" "small"
    static member inline medium = Interop.mkAttr "size" "medium"
    static member inline large = Interop.mkAttr "size" "large"


[<Erase>]
type toolbar =
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children(element: ReactElement) = prop.children element
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// Toolbar children, usually a mixture of `IconButton`, `Button` and `Typography`.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.toolbar` to specify class names.
  static member inline classes(classNames: classes.IToolbarClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, disables gutter padding.
  static member inline disableGutters(value: bool) = Interop.mkAttr "disableGutters" value

module toolbar =

  /// The variant to use.
  [<Erase>]
  type variant =
    static member inline regular = Interop.mkAttr "variant" "regular"
    static member inline dense = Interop.mkAttr "variant" "dense"


[<Erase>]
type tooltip =
  /// Tooltip reference element.
  ///
  /// ⚠️ [Needs to be able to hold a ref](https://material-ui.com/guides/composition/#caveat-with-refs).
  static member inline children(value: ReactElement) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.tooltip` to specify class names.
  static member inline classes(classNames: classes.ITooltipClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// Do not respond to focus events.
  static member inline disableFocusListener(value: bool) = Interop.mkAttr "disableFocusListener" value
  /// Do not respond to hover events.
  static member inline disableHoverListener(value: bool) = Interop.mkAttr "disableHoverListener" value
  /// Do not respond to long press touch events.
  static member inline disableTouchListener(value: bool) = Interop.mkAttr "disableTouchListener" value
  /// The number of milliseconds to wait before showing the tooltip. This prop won't impact the enter touch delay (`enterTouchDelay`).
  static member inline enterDelay(value: int) = Interop.mkAttr "enterDelay" value
  /// The number of milliseconds a user must touch the element before showing the tooltip.
  static member inline enterTouchDelay(value: int) = Interop.mkAttr "enterTouchDelay" value
  /// The relationship between the tooltip and the wrapper component is not clear from the DOM. This prop is used with aria-describedby to solve the accessibility issue. If you don't provide this prop. It falls back to a randomly generated id.
  static member inline id(value: string) = Interop.mkAttr "id" value
  /// Makes a tooltip interactive, i.e. will not close when the user hovers over the tooltip before the `leaveDelay` is expired.
  static member inline interactive(value: bool) = Interop.mkAttr "interactive" value
  /// The number of milliseconds to wait before hiding the tooltip. This prop won't impact the leave touch delay (`leaveTouchDelay`).
  static member inline leaveDelay(value: int) = Interop.mkAttr "leaveDelay" value
  /// The number of milliseconds after the user stops touching an element before hiding the tooltip.
  static member inline leaveTouchDelay(value: int) = Interop.mkAttr "leaveTouchDelay" value
  /// Callback fired when the tooltip requests to be closed.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback
  static member inline onClose(handler: Event -> unit) = Interop.mkAttr "onClose" handler
  /// Callback fired when the tooltip requests to be open.
  ///
  /// **Signature:**
  ///
  /// `function(event: object) => void`
  ///
  /// *event:* The event source of the callback
  static member inline onOpen(handler: Event -> unit) = Interop.mkAttr "onOpen" handler
  /// If `true`, the tooltip is shown.
  static member inline open'(value: bool) = Interop.mkAttr "open" value
  /// Props applied to the [`Popper`](https://material-ui.com/api/popper/) element.
  static member inline PopperProps(props: IReactProperty list) = Interop.mkAttr "PopperProps" (createObj !!props)
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title(value: ReactElement) = Interop.mkAttr "title" value
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title(values: ReactElement seq) = Interop.mkAttr "title" values
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title(value: string) = Interop.mkAttr "title" value
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title(values: string seq) = Interop.mkAttr "title" values
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title(value: int) = Interop.mkAttr "title" value
  /// Tooltip title. Zero-length titles string are never displayed.
  static member inline title(value: float) = Interop.mkAttr "title" value
  /// The component used for the transition.
  static member inline TransitionComponent(value: ReactElementType) = Interop.mkAttr "TransitionComponent" value
  /// Props applied to the `Transition` element.
  static member inline TransitionProps(props: IReactProperty list) = Interop.mkAttr "TransitionProps" (createObj !!props)

module tooltip =

  /// Tooltip placement.
  [<Erase>]
  type placement =
    static member inline bottomEnd = Interop.mkAttr "placement" "bottom-end"
    static member inline bottomStart = Interop.mkAttr "placement" "bottom-start"
    static member inline bottom = Interop.mkAttr "placement" "bottom"
    static member inline leftEnd = Interop.mkAttr "placement" "left-end"
    static member inline leftStart = Interop.mkAttr "placement" "left-start"
    static member inline left = Interop.mkAttr "placement" "left"
    static member inline rightEnd = Interop.mkAttr "placement" "right-end"
    static member inline rightStart = Interop.mkAttr "placement" "right-start"
    static member inline right = Interop.mkAttr "placement" "right"
    static member inline topEnd = Interop.mkAttr "placement" "top-end"
    static member inline topStart = Interop.mkAttr "placement" "top-start"
    static member inline top = Interop.mkAttr "placement" "top"


[<Erase>]
type touchRipple =
  /// If `true`, the ripple starts at the center of the component rather than at the point of interaction.
  static member inline center(value: bool) = Interop.mkAttr "center" value
  /// Override or extend the styles applied to the component. Use `classes.touchRipple` to specify class names.
  static member inline classes(classNames: classes.ITouchRippleClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)


[<Erase>]
type treeItem =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.treeItem` to specify class names.
  static member inline classes(classNames: classes.ITreeItemClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The icon used to collapse the node.
  static member inline collapseIcon(element: ReactElement) = Interop.mkAttr "collapseIcon" element
  /// The icon displayed next to a end node.
  static member inline endIcon(element: ReactElement) = Interop.mkAttr "endIcon" element
  /// The icon used to expand the node.
  static member inline expandIcon(element: ReactElement) = Interop.mkAttr "expandIcon" element
  /// The icon to display next to the tree node's label.
  static member inline icon(element: ReactElement) = Interop.mkAttr "icon" element
  /// The tree node label.
  static member inline label(value: ReactElement) = Interop.mkAttr "label" value
  /// The tree node label.
  static member inline label(values: ReactElement seq) = Interop.mkAttr "label" values
  /// The tree node label.
  static member inline label(value: string) = Interop.mkAttr "label" value
  /// The tree node label.
  static member inline label(values: string seq) = Interop.mkAttr "label" values
  /// The tree node label.
  static member inline label(value: int) = Interop.mkAttr "label" value
  /// The tree node label.
  static member inline label(value: float) = Interop.mkAttr "label" value
  /// The id of the node.
  static member inline nodeId(value: string) = Interop.mkAttr "nodeId" value
  /// The component used for the transition.
  static member inline TransitionComponent(value: ReactElementType) = Interop.mkAttr "TransitionComponent" value


[<Erase>]
type treeView =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.treeView` to specify class names.
  static member inline classes(classNames: classes.ITreeViewClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The default icon used to collapse the node.
  static member inline defaultCollapseIcon(element: ReactElement) = Interop.mkAttr "defaultCollapseIcon" element
  /// The default icon displayed next to a end node. This is applied to all tree nodes and can be overridden by the TreeItem `icon` prop.
  static member inline defaultEndIcon(element: ReactElement) = Interop.mkAttr "defaultEndIcon" element
  /// Expanded node ids.
  static member inline defaultExpanded([<ParamArray>] nodeIds: string []) = Interop.mkAttr "defaultExpanded" nodeIds
  /// The default icon used to expand the node.
  static member inline defaultExpandIcon(element: ReactElement) = Interop.mkAttr "defaultExpandIcon" element
  /// The default icon displayed next to a parent node. This is applied to all parent nodes and can be overridden by the TreeItem `icon` prop.
  static member inline defaultParentIcon(element: ReactElement) = Interop.mkAttr "defaultParentIcon" element
  /// Callback fired when a `TreeItem` is expanded/collapsed.
  ///
  /// **Signature:**
  ///
  /// `function(nodeId: string, expanded: boolean) => void`
  ///
  /// *nodeId:* The id of the toggled node.
  ///
  /// *expanded:* The node status - If `true` the node was expanded. If `false` the node was collapsed.
  static member inline onNodeToggle(handler: string -> bool -> unit) = Interop.mkAttr "onNodeToggle" handler


type typography =
  /// The content of the component.
  static member inline children(element: ReactElement) = prop.children element
  /// The content of the component.
  static member inline children(elements: ReactElement seq) = prop.children elements
  /// The content of the component.
  static member inline children(value: string) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(values: string seq) = Interop.mkAttr "children" values
  /// The content of the component.
  static member inline children(value: int) = Interop.mkAttr "children" value
  /// The content of the component.
  static member inline children(value: float) = Interop.mkAttr "children" value
  /// Override or extend the styles applied to the component. Use `classes.typography` to specify class names.
  static member inline classes(classNames: classes.ITypographyClasses list) : IReactProperty = Interop.mkAttr "classes" (createObj !!classNames)
  /// The component used for the root node. Either a string to use a DOM element or a component. By default, it maps the variant to a good default headline component.
  static member inline component'(value: string) = Interop.mkAttr "component" value
  /// The component used for the root node. Either a string to use a DOM element or a component. By default, it maps the variant to a good default headline component.
  static member inline component'(value: ReactElementType) = Interop.mkAttr "component" value
  /// If `true`, the text will have a bottom margin.
  static member inline gutterBottom(value: bool) = Interop.mkAttr "gutterBottom" value
  /// If `true`, the text will not wrap, but instead will truncate with an ellipsis.
  static member inline noWrap(value: bool) = Interop.mkAttr "noWrap" value
  /// If `true`, the text will have a bottom margin.
  static member inline paragraph(value: bool) = Interop.mkAttr "paragraph" value
  /// We are empirically mapping the variant prop to a range of different DOM element types. For instance, subtitle1 to ``. If you wish to change that mapping, you can provide your own. Alternatively, you can use the `component` prop.
  static member variantMapping(?h1: string, ?h2: string, ?h3: string, ?h4: string, ?h5: string, ?h6: string, ?subtitle1: string, ?subtitle2: string, ?body1: string, ?body2: string) = [if h1.IsSome then yield "h1" ==> h1.Value; if h2.IsSome then yield "h2" ==> h2.Value; if h3.IsSome then yield "h3" ==> h3.Value; if h4.IsSome then yield "h4" ==> h4.Value; if h5.IsSome then yield "h5" ==> h5.Value; if h6.IsSome then yield "h6" ==> h6.Value; if subtitle1.IsSome then yield "subtitle1" ==> subtitle1.Value; if subtitle2.IsSome then yield "subtitle2" ==> subtitle2.Value; if body1.IsSome then yield "body1" ==> body1.Value; if body2.IsSome then yield "body2" ==> body2.Value] |> createObj |> Interop.mkAttr "variantMapping"

module typography =

  /// Set the text-align on the component.
  [<Erase>]
  type align =
    static member inline inherit' = Interop.mkAttr "align" "inherit"
    static member inline left = Interop.mkAttr "align" "left"
    static member inline center = Interop.mkAttr "align" "center"
    static member inline right = Interop.mkAttr "align" "right"
    static member inline justify = Interop.mkAttr "align" "justify"

  /// The color of the component.
  [<Erase>]
  type color =
    static member inline initial = Interop.mkAttr "color" "initial"
    static member inline inherit' = Interop.mkAttr "color" "inherit"
    static member inline primary = Interop.mkAttr "color" "primary"
    static member inline secondary = Interop.mkAttr "color" "secondary"
    static member inline textPrimary = Interop.mkAttr "color" "textPrimary"
    static member inline textSecondary = Interop.mkAttr "color" "textSecondary"
    static member inline error = Interop.mkAttr "color" "error"

  /// Controls the display type
  [<Erase>]
  type display =
    static member inline initial = Interop.mkAttr "display" "initial"
    static member inline block = Interop.mkAttr "display" "block"
    static member inline inline' = Interop.mkAttr "display" "inline"

  /// Applies the theme typography styles.
  [<Erase>]
  type variant =
    static member inline h1 = Interop.mkAttr "variant" "h1"
    static member inline h2 = Interop.mkAttr "variant" "h2"
    static member inline h3 = Interop.mkAttr "variant" "h3"
    static member inline h4 = Interop.mkAttr "variant" "h4"
    static member inline h5 = Interop.mkAttr "variant" "h5"
    static member inline h6 = Interop.mkAttr "variant" "h6"
    static member inline subtitle1 = Interop.mkAttr "variant" "subtitle1"
    static member inline subtitle2 = Interop.mkAttr "variant" "subtitle2"
    static member inline body1 = Interop.mkAttr "variant" "body1"
    static member inline body2 = Interop.mkAttr "variant" "body2"
    static member inline caption = Interop.mkAttr "variant" "caption"
    static member inline button = Interop.mkAttr "variant" "button"
    static member inline overline = Interop.mkAttr "variant" "overline"
    static member inline srOnly = Interop.mkAttr "variant" "srOnly"
    static member inline inherit' = Interop.mkAttr "variant" "inherit"


type zoom =
  /// A single child content element.
  static member inline children(value: ReactElement) = Interop.mkAttr "children" value
  /// If `true`, the component will transition in.
  static member inline in'(value: bool) = Interop.mkAttr "in" value
  /// The duration for the transition, in milliseconds.
  static member inline timeout(value: int) = Interop.mkAttr "timeout" value
  /// The duration for the transition, in milliseconds.
  static member timeout(?enter: int, ?exit: int) = [if enter.IsSome then yield "enter" ==> enter.Value; if exit.IsSome then yield "exit" ==> exit.Value] |> createObj |> Interop.mkAttr "timeout"


