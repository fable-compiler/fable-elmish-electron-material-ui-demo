module Props

open System
open System.IO
open FSharp.Data

(*
TODO: verify all generated props against API docs
  - Friendlier overloads for srcSet/sizes props? Wait for Feliz? https://github.com/Zaid-Ajaj/Feliz/issues/20
  - unsure if component
TODO: adjust doc strings

*)

let outFile = @"..\..\..\..\Feliz.MaterialUI\MuiProps.fs"

let paramListAndObjCreator paramData =
  let safeName = appendApostropheToReservedKeywords >> kebabCaseToCamelCase >> prefixUnderscoreToNumbers
  let paramList =
    paramData
    |> List.map (fun (name, fsType, isOptional) ->
        sprintf "%s%s: %s" (if isOptional then "?" else "") (safeName name) fsType
    )
    |> String.concat ", "
    |> sprintf "%s"
  let objCreator =
    paramData
    |> List.map (fun (name, _, isOptional) ->
        if isOptional then
          sprintf "if %s.IsSome then yield \"%s\" ==> %s.Value" (safeName name) name (safeName name)
        else
          sprintf "yield \"%s\" ==> %s" name (safeName name)
    )
    |> String.concat "; "
    |> sprintf "[%s] |> createObj"
  paramList, objCreator


let globalDocTransform (s: string) =
  s.Replace(" It supports those theme colors that make sense for this component.", "")
   .Replace(" You may specify a single timeout for all transitions, or individually with an object.", "")


let generatePage (url: String) =
  use wEnum = new StringWriter()
  use wGeneral = new StringWriter()
  let page = ComponentApiPage.Load(url)
  let table = page.Tables.Props
  let componentNamePascalCase = page.Html.CssSelect("h1").[0].InnerText().Split(" ").[0]
  let componentNameCamelCase = componentNamePascalCase.Substring(0, 1).ToLower() + componentNamePascalCase.Substring(1)

  let mutable hasGeneralProps = false
  let mutable hasEnumProps = false

  for i, row in Seq.indexed table.Rows do
    let propName = row.Name.Trim(' ', '*')
    let propNameSafe = propName |> appendApostropheToReservedKeywords |> kebabCaseToCamelCase
    let propType = row.Type.Trim()

    let propSpecificTransform (s: string) =
      match componentNameCamelCase, propName with
      | _ -> s

    let markdownDoc =
      table.Html.CssSelect("tbody > tr").[i].CssSelect("td").[3].Elements()
      |> docElementsToMarkdown
      |> globalDocTransform
      |> propSpecificTransform

    if propType = "unsupportedProp" then
      ()


    elif propName = "classes" then
      hasGeneralProps <- true
      wGeneral.printfn "  /// Override or extend the styles applied to the component. Use `classes.%s` to specify class names." componentNameCamelCase
      wGeneral.printfn "  static member inline classes(classNames: classes.I%sClasses list) : IReactProperty = Interop.mkAttr \"classes\" (createObj !!classNames)" componentNamePascalCase


    elif (componentNameCamelCase = "grid" && propName = "spacing")
         || (propType.Contains "'"  // There is a string value
             && (propType.Contains "|"  // There are multiple values (at least one string per above)
                 || (propType.StartsWith "'" && propType.EndsWith "'")))  // There is a single string value
    then
      // Probably an enum prop
      hasEnumProps <- true

      wEnum.printfn ""
      let docString = getDocString 2 markdownDoc
      if docString <> "" then
        wEnum.WriteLine docString
      wEnum.printfn "  type %s =" propNameSafe

      let enumValues =
        if componentNameCamelCase = "hidden" && propName = "only" && propType = "'xs' | 'sm' | 'md' | 'lg' | 'xl' | Array<'xs' | 'sm' | 'md' | 'lg' | 'xl'>" then
          [| "'xs'"; "'sm'"; "'md'"; "'lg'"; "'xl'"; "HIDDEN_ONLY_ARRAY" |]
        elif componentNameCamelCase = "snackbar" && propName = "anchorOrigin" && propType = "{ horizontal: 'left' | 'center' | 'right', vertical: 'top' | 'bottom' }" then
          [|"SNACKBAR_ANCHORORIGIN"|]
        elif componentNameCamelCase = "popover" && (propName = "anchorOrigin" || propName = "transformOrigin") && propType = "{ horizontal: number | 'left' | 'center' | 'right', vertical: number | 'top' | 'center' | 'bottom' }" then
          [|"POPOVER_ANCHORORIGIN_TRANSFORMORIGIN"|]
        else
          propType.Split("|")
          |> Array.map (fun s -> s.Trim())

      for value in enumValues do

        if value = "number" then
          wEnum.printfn "    static member inline value(value: int) = Interop.mkAttr \"%s\" value" propName

        elif value = "{ enter?: number, exit?: number }" then
          let paramList, objCreator =
            [ "enter", "int", true;
              "exit", "int", true ]
            |> paramListAndObjCreator
          wEnum.printfn "    static member inline value(%s) = %s |> Interop.mkAttr \"%s\"" paramList objCreator propName

        elif value = "HIDDEN_ONLY_ARRAY" then
          wEnum.printfn "    static member inline values([<ParamArray>] sizes: string []) = Interop.mkAttr \"%s\" sizes" propName

        elif value = "SNACKBAR_ANCHORORIGIN" then
          wEnum.printfn "    static member inline topLeft = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"left\" |}" propName
          wEnum.printfn "    static member inline topCenter = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"center\" |}" propName
          wEnum.printfn "    static member inline topRight = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"right\" |}" propName
          wEnum.printfn "    static member inline bottomLeft = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"left\" |}" propName
          wEnum.printfn "    static member inline bottomCenter = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"center\" |}" propName
          wEnum.printfn "    static member inline bottomRight = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"right\" |}" propName

        elif value = "POPOVER_ANCHORORIGIN_TRANSFORMORIGIN" then
          wEnum.printfn "    static member inline topLeft = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"left\" |}" propName
          wEnum.printfn "    static member inline topCenter = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"center\" |}" propName
          wEnum.printfn "    static member inline topRight = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"right\" |}" propName
          wEnum.printfn "    static member inline centerLeft = Interop.mkAttr \"%s\" {| vertical = \"center\"; horizontal = \"left\" |}" propName
          wEnum.printfn "    static member inline centerCenter = Interop.mkAttr \"%s\" {| vertical = \"center\"; horizontal = \"center\" |}" propName
          wEnum.printfn "    static member inline centerRight = Interop.mkAttr \"%s\" {| vertical = \"center\"; horizontal = \"right\" |}" propName
          wEnum.printfn "    static member inline bottomLeft = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"left\" |}" propName
          wEnum.printfn "    static member inline bottomCenter = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"center\" |}" propName
          wEnum.printfn "    static member inline bottomRight = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"right\" |}" propName
          wEnum.printfn "    static member inline custom(horizontal: int, vertical: int) = Interop.mkAttr \"%s\" {| vertical = vertical; horizontal = horizontal |}" propName
          wEnum.printfn "    static member inline topCustom(horizontal: int) = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = horizontal |}" propName
          wEnum.printfn "    static member inline centerCustom(horizontal: int) = Interop.mkAttr \"%s\" {| vertical = \"center\"; horizontal = horizontal |}" propName
          wEnum.printfn "    static member inline bottomCustom(horizontal: int) = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = horizontal |}" propName
          wEnum.printfn "    static member inline customLeft(vertical: int) = Interop.mkAttr \"%s\" {| vertical = vertical; horizontal = \"left\" |}" propName
          wEnum.printfn "    static member inline customCenter(vertical: int) = Interop.mkAttr \"%s\" {| vertical = vertical; horizontal = \"center\" |}" propName
          wEnum.printfn "    static member inline customRight(vertical: int) = Interop.mkAttr \"%s\" {| vertical = vertical; horizontal = \"right\" |}" propName

        else
          let fSharpValue =
            if value.StartsWith "'" && value.EndsWith "'" then
              // String
              value.Replace("'", "\"")
            else
              // Probably literal, e.g. bool or int
              value
          let valueSafeName = value.Trim('\'') |> appendApostropheToReservedKeywords |> kebabCaseToCamelCase |> prefixUnderscoreToNumbers
          wEnum.printfn "    static member inline %s = Interop.mkAttr \"%s\" %s" valueSafeName propName fSharpValue


    else
      // Probably not an enum prop

      hasGeneralProps <- true

      let methods =
        match componentNameCamelCase, propName, propType with

        | "buttonBase", "action", "func | object" ->
            [
              sprintf "  static member inline %s(ref: IRefValue<IButtonBaseActions option>) = Interop.mkAttr \"%s\" ref" propNameSafe propName
              sprintf "  static member inline %s(ref: IButtonBaseActions -> unit) = Interop.mkAttr \"%s\" ref" propNameSafe propName
            ]

        | "tablePagination", "rowsPerPageOptions", "array" ->
            [sprintf "  static member inline %s([<ParamArray>] values: int []) = Interop.mkAttr \"%s\" values" propNameSafe propName]

        | "popover", "anchorPosition",  "{ left: number, top: number }" ->
            let paramList, objCreator =
              [ "left", "int", false;
                "top", "int", false ]
              |> paramListAndObjCreator
            [sprintf "  static member %s(%s) = %s |> Interop.mkAttr \"%s\"" propNameSafe paramList objCreator propName]

        | "treeView", "defaultExpanded", _ ->
            [sprintf "  static member inline %s([<ParamArray>] nodeIds: string []) = Interop.mkAttr \"%s\" nodeIds"propNameSafe propName]

        | ("input" | "filledInput" | "outlinedInput" | "inputBase" | "textareaAutosize" | "textField"), ("rows" | "rowsMax"), _ ->
            [sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName]

        | "slider", ("value" | "defaultValue"), _ ->
            [
              sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(value: float) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(min: int, max: int) = Interop.mkAttr \"%s\" (min, max)" propNameSafe propName
              sprintf "  static member inline %s(min: float, max: float) = Interop.mkAttr \"%s\" (min, max)" propNameSafe propName
            ]

        | "slider", "marks", "bool | array" ->
            [
              sprintf "  static member inline %s(value: bool) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s([<ParamArray>] values: {| value: int |} []) = Interop.mkAttr \"%s\" values" propNameSafe propName
              sprintf "  static member inline %s([<ParamArray>] values: {| value: int; label: string option |} []) = Interop.mkAttr \"%s\" values" propNameSafe propName
              sprintf "  static member inline %s([<ParamArray>] values: {| value: float |} []) = Interop.mkAttr \"%s\" values" propNameSafe propName
              sprintf "  static member inline %s([<ParamArray>] values: {| value: float; label: string option |} []) = Interop.mkAttr \"%s\" values" propNameSafe propName
            ]

        | "slider", "valueLabelFormat", _ ->
            [
              sprintf "  static member inline %s(value: string) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(format: int -> string) = Interop.mkAttr \"%s\" format" propNameSafe propName
              sprintf "  static member inline %s(format: int -> int -> string) = Interop.mkAttr \"%s\" format" propNameSafe propName
              sprintf "  static member inline %s(format: float -> string) = Interop.mkAttr \"%s\" format" propNameSafe propName
              sprintf "  static member inline %s(format: float -> int -> string) = Interop.mkAttr \"%s\" format" propNameSafe propName
            ]

        | "typography", "variantMapping", "object" ->
            let paramList, objCreator =
              [ "h1", "string", true
                "h2", "string", true
                "h3", "string", true
                "h4", "string", true
                "h5", "string", true
                "h6", "string", true
                "subtitle1", "string", true
                "subtitle2", "string", true
                "body1", "string", true
                "body2", "string", true ]
              |> paramListAndObjCreator
            [sprintf "  static member %s(%s) = %s |> Interop.mkAttr \"%s\"" propNameSafe paramList objCreator propName]

        | "bottomNavigation", "onChange", "func" ->
            [sprintf "  static member inline %s(handler: Event -> 'bottomNavigationActionValue -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName]

        | "bottomNavigation", "value", "any" ->
            [sprintf "  static member inline %s(value: 'bottomNavigationActionValue) = Interop.mkAttr \"%s\" value" propNameSafe propName]

        | "bottomNavigationAction", "value", "any" ->
            [sprintf "  static member inline %s(value: 'a) = Interop.mkAttr \"%s\" value" propNameSafe propName]

        | "checkbox", "onChange", "func" ->
            [sprintf "  static member inline %s(handler: Event -> bool -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName]

        | "checkbox", "value", "any" ->
            [sprintf "  static member inline %s(value: string) = Interop.mkAttr \"%s\" value" propNameSafe propName]

        | "circularProgress", "size", "number | string" ->
            [
              sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(value: Styles.ICssUnit) = Interop.mkAttr \"%s\" value" propNameSafe propName
            ]

        | "collapse", "collapsedHeight", "string" ->
            [
              sprintf "  static member inline %s(value: Styles.ICssUnit) = Interop.mkAttr \"%s\" value" propNameSafe propName
            ]

        | "dialog", "onClose", "func" ->
            [
              sprintf "  static member inline %s(handler: Event -> DialogCloseReason -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
            ]

        | "dialog", ("onEnter" | "onEntered" | "onEntering"), "func" ->
            [
              sprintf "  static member inline %s(handler: ReactElement -> bool -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
            ]

        | "dialog", ("onExit" | "onExited" | "onExiting"), "func" ->
            [
              sprintf "  static member inline %s(handler: ReactElement -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
            ]

        | ("expansionPanel" | "formControlLabel"), "onChange", "func" ->
            [
              sprintf "  static member inline %s(handler: Event -> bool -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
            ]

        | _, "transitionDuration", "number | { appear?: number, enter?: number, exit?: number }" ->
            let paramList, objCreator =
              [ "appear", "int", true
                "enter", "int", true;
                "exit", "int", true ]
              |> paramListAndObjCreator
            [
              sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member %s(%s) = %s |> Interop.mkAttr \"%s\"" propNameSafe paramList objCreator propName
            ]

        | _, ("transitionDuration" | "timeout"), "number | { enter?: number, exit?: number }" ->
            let paramList, objCreator =
              [ "enter", "int", true;
                "exit", "int", true ]
              |> paramListAndObjCreator
            [
              sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member %s(%s) = %s |> Interop.mkAttr \"%s\"" propNameSafe paramList objCreator propName
            ]

        | _, "anchorEl", "object | func" ->
            [
              sprintf "  static member inline %s(value: Element option) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(value: unit -> Element option) = Interop.mkAttr \"%s\" value" propNameSafe propName
            ]

        | ("modal" | "popover" | "popper" | "portal"), "container", ("object | func" | "func | React.Component | Element") ->
            [
              sprintf "  static member inline %s(value: Element option) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(value: ReactElement option) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(value: unit -> Element option) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(value: unit -> ReactElement option) = Interop.mkAttr \"%s\" value" propNameSafe propName
            ]

        | "popper", ("modifiers" | "popperOptions"), "object" ->
            [sprintf "  static member inline %s(value: 'a) = Interop.mkAttr \"%s\" value" propNameSafe propName]

        | _, "component", ("elementType" | "element type")
        | ("filledInput" | "input" | "inputBase"), "inputComponent", "elementType" ->
            [
              sprintf "  static member inline %s(value: string) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(value: ReactElementType) = Interop.mkAttr \"%s\" value" propNameSafe propName
            ]

        | _, pn, ("elementType" | "element type") when pn.EndsWith "Component" ->
            [
              sprintf "  static member inline %s(value: ReactElementType) = Interop.mkAttr \"%s\" value" propNameSafe propName
            ]

        | _, pn, "func | object" when pn.EndsWith "Ref" ->
            [
              sprintf "  static member inline %s(ref: IRefValue<Element option>) = Interop.mkAttr \"%s\" ref" propNameSafe propName
              sprintf "  static member inline %s(ref: Element -> unit) = Interop.mkAttr \"%s\" ref" propNameSafe propName
            ]

        | _, pn, ("object" | "{ component?: element type }") when pn.EndsWith "Props" ->
            [sprintf "  static member inline %s(props: IReactProperty list) = Interop.mkAttr \"%s\" (createObj !!props)" propNameSafe propName]

        | _, pn, "object" when pn.EndsWith "Classes" ->
            let otherComponentNamePascalCase = pn.Substring(0, pn.Length - 7)
            [sprintf "  static member inline %s(classNames: classes.I%sClasses list) = Interop.mkAttr \"%s\" (createObj !!classNames)" propNameSafe otherComponentNamePascalCase propName]

        | _, _, "bool" ->
            [sprintf "  static member inline %s(value: bool) = Interop.mkAttr \"%s\" value" propNameSafe propName]

        | _, _, "string" ->
            [sprintf "  static member inline %s(value: string) = Interop.mkAttr \"%s\" value" propNameSafe propName]

        | _, _, "number" ->
            [sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName]

        | _, pn, "func" when pn.StartsWith "on" ->
            [sprintf "  static member inline %s(handler: Event -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName]

        | _, _, "func" ->
            [sprintf "  static member inline %s(value: unit -> unit) = Interop.mkAttr \"%s\" value" propNameSafe propName]

        | _, pn, "node" when pn.EndsWith "Icon" ->
            [sprintf "  static member inline %s(element: ReactElement) = Interop.mkAttr \"%s\" element" propNameSafe propName]

        | ("filledInput" | "input"), ("startAdornment" | "endAdornment"), "node" ->
            [sprintf "  static member inline %s(element: ReactElement) = Interop.mkAttr \"%s\" element" propNameSafe propName]

        | "formControl", "children", "node" ->
            [
              sprintf "  static member inline %s(element: ReactElement) = prop.children element" propNameSafe
              sprintf "  static member inline %s(elements: ReactElement seq) = prop.children elements" propNameSafe
            ]

        | _, "children", "node"
        | "popper", "children", "node | func" ->  // TODO: popper.children can also be a func, but can't find signature docs
            [
              sprintf "  static member inline %s(element: ReactElement) = prop.children element" propNameSafe
              sprintf "  static member inline %s(elements: ReactElement seq) = prop.children elements" propNameSafe
              sprintf "  static member inline %s(value: string) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(values: string seq) = Interop.mkAttr \"%s\" values" propNameSafe propName
              sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(value: float) = Interop.mkAttr \"%s\" value" propNameSafe propName
            ]

        | _, _, "node" ->
            [
              sprintf "  static member inline %s(value: ReactElement) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(values: ReactElement seq) = Interop.mkAttr \"%s\" values" propNameSafe propName
              sprintf "  static member inline %s(value: string) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(values: string seq) = Interop.mkAttr \"%s\" values" propNameSafe propName
              sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(value: float) = Interop.mkAttr \"%s\" value" propNameSafe propName
            ]

        | _, _, "element" ->
            [sprintf "  static member inline %s(value: ReactElement) = Interop.mkAttr \"%s\" value" propNameSafe propName]

        | _, _, "any" ->
            [sprintf "  static member inline %s(value: 'a) = Interop.mkAttr \"%s\" value" propNameSafe propName]

        | _, _, "number | string" ->
            [
              sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName
              sprintf "  static member inline %s(value: string) = Interop.mkAttr \"%s\" value" propNameSafe propName
            ]

        | _ ->
            [sprintf "  static member inline %s(value: TODO) = Interop.mkAttr \"%s\" value" propNameSafe propName]


      for method in methods do
        let docString = getDocString 2 markdownDoc
        if docString <> "" then
          wGeneral.WriteLine docString
        wGeneral.WriteLine method

  use w = new StringWriter()

  if hasGeneralProps then
    w.printfn "type %s =" componentNameCamelCase
    w.WriteLine(wGeneral.ToString())
  if hasEnumProps then
    w.printfn "module %s =" componentNameCamelCase
    w.WriteLine(wEnum.ToString())

  w.ToString ()

let generateAll () =
  Console.WriteLine("\n\nGENERATING PROPS\n")
  use w = new StringWriter()
  w.printfn """namespace Feliz.MaterialUI

//////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
//////////////////////////////////

open System
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.MaterialUI
open Fable.React
open Feliz

[<StringEnum>]
type DialogCloseReason =
  | EscapeKeyDown
  | BackdropClick

"""

  HtmlCache.getCachedPages () |> Array.mapi (fun i path ->
    Console.WriteLine(sprintf "Processing #%i: %s" i path)
    generatePage path
  )
  |> Array.iter w.WriteLine
  System.IO.File.WriteAllText(outFile, w.ToString())
