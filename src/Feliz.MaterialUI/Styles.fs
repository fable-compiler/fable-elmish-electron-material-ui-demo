namespace Feliz.MaterialUI

open Fable.Core
open Fable.Core.JsInterop
open Feliz


// TODO: how to hide?
module StyleImports =

  let makeStyles_get (getStyles: Theme -> obj) : ('props -> 'a) =
    import "makeStyles" "@material-ui/core/styles"

  let makeStyles_getWithOpts (getStyles: Theme -> obj) (opts: MakeStylesOptions) : ('props -> 'a) =
    import "makeStyles" "@material-ui/core/styles"

  let makeStyles_obj (styles: obj) : ('props -> 'a) =
    import "makeStyles" "@material-ui/core/styles"

  let makeStyles_objWithOpts (styles: obj) (opts: MakeStylesOptions) : ('props -> 'a) =
    import "makeStyles" "@material-ui/core/styles"

  let responsiveFontSizes (theme: Theme) : Theme =
    import "responsiveFontSizes" "@material-ui/core/styles"

  let responsiveFontSizes_opts (theme: Theme) (opts: ResponsiveFontSizesOptions) : Theme =
    import "responsiveFontSizes" "@material-ui/core/styles"

  let createMuiTheme (theme: Theme) : Theme =
    import "createMuiTheme" "@material-ui/core/styles"

  let createMuiTheme_unit () : Theme =
    import "createMuiTheme" "@material-ui/core/styles"

  let useTheme () : Theme =
    import "useTheme" "@material-ui/core/styles"


[<Erase>]
type Styles =

  /// Use with `makeStyles` etc. when returning an (anonymous) record of style
  /// properties or functions. Simply unboxes the input to `string` (which it is
  /// at runtime when returned by the JSS styling solution), so that the
  /// properties can be used in `className` and `classes` props.
  static member inline create (styles: #seq<IStyleAttribute>) =
    styles |> unbox |> createObj |> unbox<string>

  /// Use with `makeStyles` etc. when returning an (anonymous) record of style
  /// properties or functions. Simply unboxes the input to `string` (which it is
  /// at runtime when returned by the JSS styling solution), so that the
  /// properties can be used in `className` and `classes` props.
  static member inline create (getStyles: 'props -> #seq<IStyleAttribute>) =
    (getStyles >> unbox >> createObj) |> unbox<string>

  /// This hook links a style sheet with a function component.
  ///
  /// The Material-UI documentation often calls the returned hook `useStyles`.
  /// It accepts one argument: the properties that will be used for
  /// "interpolation" in the style sheet. Use unit `()` if you don't need it.
  ///
  /// Note that the object returned by the hook has the same properties as the
  /// object returned by getStyles, but every prop is a string.
  static member inline makeStyles
      ( getStyles: Theme -> 'a
      ) : ('props -> 'a) =
    StyleImports.makeStyles_get (getStyles >> toPlainJsObj)

  /// This hook links a style sheet with a function component.
  ///
  /// The Material-UI documentation often calls the returned hook `useStyles`.
  /// It accepts one argument: the properties that will be used for
  /// "interpolation" in the style sheet. Use unit `()` if you don't need it.
  ///
  /// Note that the object returned by the hook has the same properties as the
  /// object returned by getStyles, but every prop is a string.
  static member inline makeStyles
      ( getStyles: Theme -> 'a,
        options: MakeStylesOptions
      ) : ('props -> 'a) =
    StyleImports.makeStyles_getWithOpts (getStyles >> toPlainJsObj) options

  /// This hook returns the theme object so it can be used inside a function
  /// component.
  static member inline useTheme() : Theme =
    StyleImports.useTheme ()

  /// Generate a theme base on the configured incomplete theme object.
  static member inline createMuiTheme (theme: Theme) : Theme =
    StyleImports.createMuiTheme theme

  /// Returns a default theme object.
  static member inline createMuiTheme () : Theme =
    StyleImports.createMuiTheme_unit ()

  /// Generate responsive typography settings based on the options received.
  static member inline responsiveFontSizes (theme: Theme) : Theme =
    StyleImports.responsiveFontSizes theme

  /// Generate responsive typography settings based on the options received.
  static member inline responsiveFontSizes (theme: Theme, options: ResponsiveFontSizesOptions) : Theme =
    StyleImports.responsiveFontSizes_opts theme options


[<AutoOpen>]
module Extensions =

  type Styles with

    /// This hook links a style sheet with a function component.
    ///
    /// The Material-UI documentation often calls the returned hook `useStyles`.
    /// It accepts one argument: the properties that will be used for
    /// "interpolation" in the style sheet. Use unit `()` if you don't need it.
    ///
    /// Note that the object returned by the hook has the same properties as the
    /// styles object, but every prop is a string.
    static member inline makeStyles
        ( styles: 'a
        ) : ('props -> 'a) =
      StyleImports.makeStyles_obj (styles |> toPlainJsObj)

    /// This hook links a style sheet with a function component.
    ///
    /// The Material-UI documentation often calls the returned hook `useStyles`.
    /// It accepts one argument: the properties that will be used for
    /// "interpolation" in the style sheet. Use unit `()` if you don't need it.
    ///
    /// Note that the object returned by the hook has the same properties as the
    /// styles object, but every prop is a string.
    static member inline makeStyles
        ( styles: 'a,
          options: MakeStylesOptions
        ) : ('props -> 'a) =
      StyleImports.makeStyles_objWithOpts (styles |> toPlainJsObj) options


[<Erase>]
type style =

  /// Allows nesting styles, for example for JSS selectors etc.
  // TODO: rename?
  static member inline inner (name: string) (styles: IStyleAttribute list) =
    Interop.mkStyle name (createObj !!styles)
