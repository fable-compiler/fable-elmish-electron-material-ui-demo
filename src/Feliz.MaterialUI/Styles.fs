namespace Feliz.MaterialUI

open Fable.Core
open Fable.Core.JsInterop
open Feliz

// TODO: EraseAttribute on types?

[<AutoOpen>]
module Global =

  let inline asClassName (styles: IStyleAttribute list) : IClassName =
    unbox styles

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

  [<Emit("Object.entries($0)")>]
  /// Transforms a plain JS object to key-value pairs.
  let objectEntries (x: 'a) : (string * obj) [] = jsNative

type Styles =

  /// Link a style sheet with a function component using the hook pattern.
  ///
  /// Note that the object returned by the hook has the same properties as the
  /// object returned by getStyles, but every prop is a string.
  static member makeStyles(getStyles: Fable.MaterialUI.Themes.ITheme -> 'a) : (unit -> 'a) =
    (getStyles >> objMap (unbox >> createObj))
    |> import "makeStyles" "@material-ui/core/styles"

[<AutoOpen>]
module Extensions =
  // Implement as extension to give lower priority
  type Styles with

    /// Link a style sheet with a function component using the hook pattern.
    ///
    /// Note that the object returned by the hook has the same properties as the
    /// object returned by getStyles, but every prop is a string.
    static member makeStyles(styles: 'a) : (unit -> 'a) =
      styles |> objMap (unbox >> createObj)
      |> import "makeStyles" "@material-ui/core/styles"


type style =

  /// Converts the items in the object to a list of StyleAttribute so they can
  /// be used alongside other styles. Use yield! to combine these in a list of
  /// other styles.
  static member spread(value: obj) : IStyleAttribute [] =
    objectEntries value |> unbox

  /// Allows nesting styles, for example for JSS selectors etc.
  static member inner (name: string) (styles: IStyleAttribute list) =
    Interop.mkStyle name (createObj !!styles)
