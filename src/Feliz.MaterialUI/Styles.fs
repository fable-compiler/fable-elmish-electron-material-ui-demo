namespace Feliz.MaterialUI

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<AutoOpen>]
module Global =

  // TODO: Remove these and simply add 'a overload to className and classes?

  /// Use with `makeStyles` etc. when returning an (anonymous) record of style
  /// properties or functions. Simply unboxes the input to `string` (which it is
  /// at runtime when returned by the JSS styling solution), so that the
  /// properties can be used in `className` and `classes` props.
  let inline styleList (x: #seq<IStyleAttribute>) =
    unbox<string> x

  /// Use with `makeStyles` etc. when returning an (anonymous) record of style
  /// properties or functions. Simply unboxes the input to `string` (which it is
  /// at runtime when returned by the JSS styling solution), so that the
  /// properties can be used in `className` and `classes` props.
  let inline styleFun (x: 'props -> #seq<IStyleAttribute>) =
    unbox<string> x


[<AutoOpen>]
module private StyleHelpers =

  [<Emit("""
    let finalTarget = {}
    for (var className in $1) {
      if ($1.hasOwnProperty(className)) {
        finalTarget[className] = $0($1[className]);
      }
    }
    return finalTarget;
  """)>]
  /// Returns a new object where all properties of the original object have been
  /// transformed by the specified function.
  let objMap (f: 'a -> 'b) (o: 'c) : obj = jsNative


type Styles =

  /// This hook links a style sheet with a function component.
  ///
  /// The Material-UI documentation often calls this returned hook `useStyles`.
  /// It accepts one argument: the properties that will be used for
  /// "interpolation" in the style sheet. Use unit `()` if you don't need it.
  ///
  /// Note that the object returned by the hook has the same properties as the
  /// object returned by getStyles, but every prop is a string.
  static member makeStyles
      ( getStyles: Theme -> 'a
      ) : ('props -> 'a) =
    (getStyles >> objMap (unbox >> createObj))
    |> import "makeStyles" "@material-ui/core/styles"

  static member createMuiTheme (theme: Theme) : Theme =
    theme |> import "createMuiTheme" "@material-ui/core/styles"

  /// This hook links a style sheet with a function component.
  ///
  /// The Material-UI documentation often calls this returned hook `useStyles`.
  /// It accepts one argument: the properties that will be used for
  /// "interpolation" in the style sheet. Use unit `()` if you don't need it.
  ///
  /// Note that the object returned by the hook has the same properties as the
  /// object returned by getStyles, but every prop is a string.
  static member makeStyles
      ( getStyles: Theme -> 'a,
        options: MakeStylesOptions
      ) : ('props -> 'a) =
    (getStyles >> objMap (unbox >> createObj), options)
    |> import "makeStyles" "@material-ui/core/styles"

  /// This hook returns the theme object so it can be used inside a function
  /// component.
  static member useTheme() : Theme =
    import "useTheme" "@material-ui/core/styles" ()


[<Erase>]
type style =

  /// Allows nesting styles, for example for JSS selectors etc.
  // TODO: rename?
  static member inline inner (name: string) (styles: IStyleAttribute list) =
    Interop.mkStyle name (createObj !!styles)
