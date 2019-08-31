namespace Feliz.MaterialUI

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop
open Feliz
open Feliz.Styles


type PaletteIntention =
  abstract light: string with get, set
  abstract main: string with get, set
  abstract dark: string with get, set
  abstract contrastText: string with get, set

[<StringEnum; RequireQualifiedAccess>] 
type PaletteType =
  | Dark
  | Light

type CommonPalette =
  abstract black: string with get, set
  abstract white: string with get, set

type ActionPalette =
  abstract active: string with get, set
  abstract hover: string with get, set
  abstract hoverOpacity: float with get, set
  abstract selected: string with get, set
  abstract disabled: string with get, set
  abstract disabledBackground: string with get, set

type BackgroundPalette =
  abstract paper: string with get, set
  abstract ``default``: string with get, set

type TextPalette =
  abstract primary: string with get, set
  abstract secondary: string with get, set
  abstract disabled: string with get, set
  abstract hint: string with get, set

type Color =
  abstract ``50``: string with get, set
  abstract ``100``: string with get, set
  abstract ``200``: string with get, set
  abstract ``300``: string with get, set
  abstract ``400``: string with get, set
  abstract ``500``: string with get, set
  abstract ``600``: string with get, set
  abstract ``700``: string with get, set
  abstract ``800``: string with get, set
  abstract ``900``: string with get, set
  abstract A100: string with get, set
  abstract A200: string with get, set
  abstract A400: string with get, set
  abstract A700: string with get, set

type Palette =
  abstract common: CommonPalette with get, set
  abstract ``type``: PaletteType with get, set
  abstract primary: U2<PaletteIntention, Color> with get, set
  abstract secondary: U2<PaletteIntention, Color> with get, set
  abstract error: U2<PaletteIntention, Color> with get, set
  abstract grey: Color with get, set
  abstract contrastThreshold: int with get, set
  abstract getContrastText: background: string -> string
  abstract augmentColor: color: PaletteIntention * ?mainShade : U2<int, string> * ?lightShade : U2<int, string> * ?darkShade : U2<int, string> -> unit
  abstract tonalOffset: float with get, set
  abstract text: TextPalette with get, set
  abstract divider: string with get, set
  abstract background: BackgroundPalette with get, set
  abstract action: ActionPalette with get, set

[<StringEnum; RequireQualifiedAccess>]
type Direction =
  | Ltr
  | Rtl

type Shape =
  abstract borderRadius: int with get, set

type ZIndex =
  abstract mobileStepper: int with get, set
  abstract appBar: int with get, set
  abstract drawer: int with get, set
  abstract modal: int with get, set
  abstract snackbar: int with get, set
  abstract tooltip: int with get, set

type VariantTypography =
  abstract fontSize: string with get, set
  abstract fontWeight: int with get, set
  abstract fontFamily: string with get, set
  abstract letterSpacing: string with get, set
  abstract lineHeight: string with get, set
  abstract marginLeft: string with get, set
  abstract color: string with get, set
  abstract textTransform: string with get, set

type Typography =
  abstract round: px: float -> float
  abstract pxToRem: px: float -> string
  abstract fontFamily: string [] with get, set
  abstract fontSize: string with get, set
  abstract fontWeightLight: int with get, set
  abstract fontWeightRegular: int with get, set
  abstract fontWeightMedium: int with get, set
  abstract h1: VariantTypography with get, set
  abstract h2: VariantTypography with get, set
  abstract h3: VariantTypography with get, set
  abstract h4: VariantTypography with get, set
  abstract h5: VariantTypography with get, set
  abstract h6: VariantTypography with get, set
  abstract subtitle1: VariantTypography with get, set
  abstract subtitle2: VariantTypography with get, set
  abstract overline: VariantTypography with get, set
  abstract srOnly: VariantTypography with get, set
  abstract body2: VariantTypography with get, set
  abstract body1: VariantTypography with get, set
  abstract caption: VariantTypography with get, set
  abstract button: VariantTypography with get, set

type BreakpointValues =
  abstract xs: int with get, set
  abstract sm: int with get, set
  abstract md: int with get, set
  abstract lg: int with get, set
  abstract xl: int with get, set

[<StringEnum; RequireQualifiedAccess>]
type BreakpointKey =
  | Xs
  | Sm
  | Md
  | Lg
  | Xl

[<AbstractClass; Erase>]
type Breakpoints =
  abstract keys: BreakpointKey list with get, set
  abstract values: BreakpointValues with get, set
  abstract up: key: BreakpointKey -> string
  abstract up: widthPx: int -> string
  abstract down: key: BreakpointKey -> string
  abstract down: widthPx: int -> string
  abstract only: key: BreakpointKey -> string
  abstract between: start: BreakpointKey * ``end``: BreakpointKey -> string
  member inline this.upXs = this.up(BreakpointKey.Xs)
  member inline this.upSm = this.up(BreakpointKey.Sm)
  member inline this.upMd = this.up(BreakpointKey.Md)
  member inline this.upLg = this.up(BreakpointKey.Lg)
  member inline this.upXl = this.up(BreakpointKey.Xl)
  member inline this.downXs = this.down(BreakpointKey.Xs)
  member inline this.downSm = this.down(BreakpointKey.Sm)
  member inline this.downMd = this.down(BreakpointKey.Md)
  member inline this.downLg = this.down(BreakpointKey.Lg)
  member inline this.downXl = this.down(BreakpointKey.Xl)
  member inline this.onlyXs = this.only(BreakpointKey.Xs)
  member inline this.onlySm = this.only(BreakpointKey.Sm)
  member inline this.onlyMd = this.only(BreakpointKey.Md)
  member inline this.onlyLg = this.only(BreakpointKey.Lg)
  member inline this.onlyXl = this.only(BreakpointKey.Xl)
  member inline this.betweenXsSm = this.between(BreakpointKey.Xs, BreakpointKey.Sm)
  member inline this.betweenXsMd = this.between(BreakpointKey.Xs, BreakpointKey.Md)
  member inline this.betweenXsLg = this.between(BreakpointKey.Xs, BreakpointKey.Lg)
  member inline this.betweenXsXl = this.between(BreakpointKey.Xs, BreakpointKey.Xl)
  member inline this.betweenSmMd = this.between(BreakpointKey.Sm, BreakpointKey.Md)
  member inline this.betweenSmLg = this.between(BreakpointKey.Sm, BreakpointKey.Lg)
  member inline this.betweenSmXl = this.between(BreakpointKey.Sm, BreakpointKey.Xl)
  member inline this.betweenMdLg = this.between(BreakpointKey.Md, BreakpointKey.Lg)
  member inline this.betweenMdXl = this.between(BreakpointKey.Md, BreakpointKey.Xl)
  member inline this.betweenLgXl = this.between(BreakpointKey.Lg, BreakpointKey.Xl)

[<AbstractClass; Erase>]
type Mixins =
  abstract toolbar: obj with get, set
  [<Emit("Object.entries($0.toolbar)")>]
  member inline __.toolbarStyles : IStyleAttribute [] = jsNative

type Easing =
  abstract easeInOut: string with get, set
  abstract easeOut: string with get, set
  abstract easeIn: string with get, set
  abstract sharp: string with get, set

type Duration =
  abstract shortest: int with get, set
  abstract shorter: int with get, set
  abstract short: int with get, set
  abstract standard: int with get, set
  abstract complex: int with get, set
  abstract enteringScreen: int with get, set
  abstract leavingScreen: int with get, set

type TransitionOptions =
  abstract duration: U2<int, string> with get, set
  abstract easing: string with get, set
  abstract delay: U2<int, string> with get, set

type Transitions =
  abstract easing: Easing with get, set
  abstract duration: Duration with get, set
  abstract create: props : U2<string, string[]> * ?options: TransitionOptions -> string
  abstract getAutoHeightDuration: height : int -> int

[<AbstractClass; Erase>]
type Theme =
  abstract breakpoints: Breakpoints with get, set
  abstract direction: Direction with get, set
  abstract overrides: obj with get, set
  abstract palette: Palette with get, set
  abstract props: obj with get, set
  abstract shadows: string [] with get, set
  abstract typography: Typography with get, set
  abstract shape: Shape with get, set
  abstract spacing: a: int -> int
  abstract spacing: a: int * b: int -> int
  abstract spacing: a: int * b: int * c: int -> int
  abstract spacing: a: int * b: int * c: int * d: int -> int
  abstract zIndex: ZIndex with get, set
  abstract mixins: Mixins with get, set
  abstract transitions: Transitions with get, set
  /// Sets the theme's `spacing`.
  [<Emit("$0.spacing = $1")>]
  member __.setSpacing(px: int) : unit = jsNative
  /// Sets the theme's `spacing`.
  [<Emit("$0.spacing = $1")>]
  member __.setSpacing(f: int -> int) : unit = jsNative
  /// Sets the theme's `spacing`.
  [<Emit("$0.spacing = $1")>]
  member __.setSpacing(f: int -> ICssUnit) : unit = jsNative
  // Sets the theme's overrides, replacing any existing overrides. Use
  // `overrides.<x>` to specify components and overrides.
  member inline this.setOverrides (overrides: IOverrideStyleSheet list) =
    this.overrides <- overrides |> unbox |> createObj
  // Adds the specified overrides to the theme's existing overrides. Use
  // `overrides.<x>` to specify components and overrides. This is not a deep
  // merge; any component overrides specified here will completely replace any
  // existing overrides for that component, regardless of which override rules
  // or styles are used.
  member inline this.addOverrides (overrides: IOverrideStyleSheet list) =
    Object.assign(this.overrides, overrides |> unbox |> createObj) |> ignore
  // Sets the theme's props, replacing any existing props. Use `themeProps.<x>`
  // to specify components.
  member inline this.setProps (props: IThemeProps list) =
    this.props <- props |> unbox |> createObj
  // Adds the specified props to the theme's existing props. Use
  // `themeProps.<x>` to specify components. This is not a deep merge; any
  // component props specified here will completely replace any existing props
  // for that component.
  member inline this.addProps (props: IThemeProps list) =
    Object.assign(this.props, props |> unbox |> createObj) |> ignore

type MakeStylesOptions =
  /// The default theme to use if a theme isn't supplied through a Theme
  /// Provider.
  abstract defaultTheme: Theme with get, set
  /// The name of the style sheet. Useful for debugging. If the value isn't
  /// provided, it will try to fallback to the name of the component.
  abstract name: string with get, set
  /// When set to `false`, this sheet will opt-out the `rtl` transformation.
  /// When set to `true`, the styles are inversed. When set to `None`, it
  /// follows `theme.direction`.
  abstract flip: bool option with get, set

[<StringEnum; RequireQualifiedAccess>]
type TypographyVariant =
  | H1
  | H2
  | H3
  | H4
  | H5
  | H6
  | Subtitle1
  | Subtitle2
  | Overline
  | SrOnly
  | Body1
  | Body2
  | Caption
  | Button

type ResponsiveFontSizesOptions =
  /// Default to `['sm', 'md', 'lg']`.
  abstract breakpoints: BreakpointKey [] with get, set
  /// Whether font sizes change slightly so line heights are preserved and align
  /// to Material Design's 4px line height grid. This requires a unitless line
  /// height in the theme's styles. Default to `false`. 
  abstract disableAlign: bool with get, set
  /// This value determines the strength of font size resizing. The higher the
  /// value, the less difference there is between font sizes on small screens.
  /// The lower the value, the bigger font sizes for small screens. The value
  /// must be greater than 1. Default to 2.
  abstract factor: float with get, set
  /// The typography variants to handle. Default to all.
  abstract variants: TypographyVariant [] with get, set

type ButtonBaseActions =
  abstract focusVisible: unit -> bool

type PopoverActions =
  abstract updatePosition: unit -> unit

type TabsActions =
  abstract updateIndicator: unit -> unit
