module Props

open System
open System.IO
open FSharp.Data

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
   .Replace("event.target.value", "event.Value")


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
      | "nativeSelect", "children" ->
          s.Replace("Can be some `` elements.", "Can be some `<option>` elements.")
      | "stepper", "children" ->
          s.Replace("Two or more `` components.", "Two or more `<Step />` components.")
      | "tableRow", "children" ->
          s.Replace("Should be valid | children", "Should be valid `<tr>` children")
           .Replace("\r\n|  |", "")
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


    else

      let isEnumProp =
        // Probably an enum prop
        (componentNameCamelCase = "grid" && propName = "spacing")
         || (propType.Contains "'"  // There is a string value
             && (propType.Contains "|"  // There are multiple values (at least one string per above)
                 || (propType.StartsWith "'" && propType.EndsWith "'")))  // There is a single string value

      let mutable isNonEnumProp = not isEnumProp

      if isEnumProp then
        hasEnumProps <- true

        use wEnumThisProp = new StringWriter()

        let enumValues =
          if componentNameCamelCase = "hidden" && propName = "only" && propType = "'xs' | 'sm' | 'md' | 'lg' | 'xl' | Array<'xs' | 'sm' | 'md' | 'lg' | 'xl'>" then
            isNonEnumProp <- true
            [| "'xs'"; "'sm'"; "'md'"; "'lg'"; "'xl'" |]
          elif componentNameCamelCase = "snackbar" && propName = "anchorOrigin" && propType = "{ horizontal: 'left' | 'center' | 'right', vertical: 'top' | 'bottom' }" then
            [|"SNACKBAR_ANCHORORIGIN"|]
          elif componentNameCamelCase = "popover" && (propName = "anchorOrigin" || propName = "transformOrigin") && propType = "{ horizontal: number | 'left' | 'center' | 'right', vertical: number | 'top' | 'center' | 'bottom' }" then
            [|"POPOVER_ANCHORORIGIN_TRANSFORMORIGIN"|]
          else
            propType.Split("|")
            |> Array.map (fun s -> s.Trim())

        for value in enumValues do

          if value = "number" then
            isNonEnumProp <- true

          elif value = "{ enter?: number, exit?: number }" then
            isNonEnumProp <- true

          elif value = "SNACKBAR_ANCHORORIGIN" then
            wEnumThisProp.printfn "    static member inline topLeft = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"left\" |}" propName
            wEnumThisProp.printfn "    static member inline topCenter = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"center\" |}" propName
            wEnumThisProp.printfn "    static member inline topRight = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"right\" |}" propName
            wEnumThisProp.printfn "    static member inline bottomLeft = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"left\" |}" propName
            wEnumThisProp.printfn "    static member inline bottomCenter = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"center\" |}" propName
            wEnumThisProp.printfn "    static member inline bottomRight = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"right\" |}" propName

          elif value = "POPOVER_ANCHORORIGIN_TRANSFORMORIGIN" then
            wEnumThisProp.printfn "    static member inline topLeft = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"left\" |}" propName
            wEnumThisProp.printfn "    static member inline topCenter = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"center\" |}" propName
            wEnumThisProp.printfn "    static member inline topRight = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = \"right\" |}" propName
            wEnumThisProp.printfn "    static member inline centerLeft = Interop.mkAttr \"%s\" {| vertical = \"center\"; horizontal = \"left\" |}" propName
            wEnumThisProp.printfn "    static member inline centerCenter = Interop.mkAttr \"%s\" {| vertical = \"center\"; horizontal = \"center\" |}" propName
            wEnumThisProp.printfn "    static member inline centerRight = Interop.mkAttr \"%s\" {| vertical = \"center\"; horizontal = \"right\" |}" propName
            wEnumThisProp.printfn "    static member inline bottomLeft = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"left\" |}" propName
            wEnumThisProp.printfn "    static member inline bottomCenter = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"center\" |}" propName
            wEnumThisProp.printfn "    static member inline bottomRight = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = \"right\" |}" propName
            wEnumThisProp.printfn "    static member inline custom(horizontal: int, vertical: int) = Interop.mkAttr \"%s\" {| vertical = vertical; horizontal = horizontal |}" propName
            wEnumThisProp.printfn "    static member inline topCustom(horizontal: int) = Interop.mkAttr \"%s\" {| vertical = \"top\"; horizontal = horizontal |}" propName
            wEnumThisProp.printfn "    static member inline centerCustom(horizontal: int) = Interop.mkAttr \"%s\" {| vertical = \"center\"; horizontal = horizontal |}" propName
            wEnumThisProp.printfn "    static member inline bottomCustom(horizontal: int) = Interop.mkAttr \"%s\" {| vertical = \"bottom\"; horizontal = horizontal |}" propName
            wEnumThisProp.printfn "    static member inline customLeft(vertical: int) = Interop.mkAttr \"%s\" {| vertical = vertical; horizontal = \"left\" |}" propName
            wEnumThisProp.printfn "    static member inline customCenter(vertical: int) = Interop.mkAttr \"%s\" {| vertical = vertical; horizontal = \"center\" |}" propName
            wEnumThisProp.printfn "    static member inline customRight(vertical: int) = Interop.mkAttr \"%s\" {| vertical = vertical; horizontal = \"right\" |}" propName

          else
            let fSharpValue =
              if value.StartsWith "'" && value.EndsWith "'" then
                // String
                value.Replace("'", "\"")
              else
                // Probably literal, e.g. bool or int
                value
            let valueSafeName = value.Trim('\'') |> appendApostropheToReservedKeywords |> kebabCaseToCamelCase |> prefixUnderscoreToNumbers
            wEnumThisProp.printfn "    static member inline %s = Interop.mkAttr \"%s\" %s" valueSafeName propName fSharpValue

        wEnum.printfn ""
        let docString = getDocString 2 markdownDoc
        if docString <> "" then
          wEnum.WriteLine docString
        if wEnumThisProp.ToString() |> hasNonInlineMembers |> not then
          wEnum.printfn "  [<Erase>]"
        wEnum.printfn "  type %s =" propNameSafe
        wEnum.Write (wEnumThisProp.ToString())


      if isNonEnumProp then

        // TODO: for 'any'-typed props (e.g. many 'value' props), constrain to
        // string if docs contain "The DOM API casts this to a string"?
        // https://github.com/mui-org/material-ui/pull/17132

        hasGeneralProps <- true

        let methods =
          match componentNameCamelCase, propName, propType with

          | "buttonBase", "action", "func | object" ->
              [
                sprintf "  static member inline %s(ref: IRefValue<ButtonBaseActions option>) = Interop.mkAttr \"%s\" ref" propNameSafe propName
                sprintf "  static member inline %s(handler: ButtonBaseActions -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
              ]

          | "popover", "action", "func | object" ->
              [
                sprintf "  static member inline %s(ref: IRefValue<PopoverActions option>) = Interop.mkAttr \"%s\" ref" propNameSafe propName
                sprintf "  static member inline %s(handler: PopoverActions -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
              ]

          | "tabs", "action", "func" ->
              [
                sprintf "  static member inline %s(ref: IRefValue<TabsActions option>) = Interop.mkAttr \"%s\" ref" propNameSafe propName
                sprintf "  static member inline %s(handler: TabsActions -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
              ]

          | "tablePagination", "rowsPerPageOptions", "array" ->
              [sprintf "  static member inline %s([<ParamArray>] values: int []) = Interop.mkAttr \"%s\" values" propNameSafe propName]

          | "popover", "anchorPosition",  "{ left: number, top: number }" ->
              let paramList, objCreator =
                [ "left", "int", false
                  "top", "int", false ]
                |> paramListAndObjCreator
              [sprintf "  static member %s(%s) = %s |> Interop.mkAttr \"%s\"" propNameSafe paramList objCreator propName]

          | "treeView", "defaultExpanded", _ ->
              [sprintf "  static member inline %s([<ParamArray>] nodeIds: string []) = Interop.mkAttr \"%s\" nodeIds" propNameSafe propName]

          | ("input" | "filledInput" | "outlinedInput" | "inputBase" | "textareaAutosize" | "textField"), ("rows" | "rowsMax"), "string | number" ->
              [sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName]

          | ("input" | "filledInput" | "outlinedInput" | "inputBase" | "textField" | "nativeSelect" | "radioGroup"), "onChange", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
                sprintf "  static member inline %s(handler: string -> unit) = Interop.mkAttr \"%s\" (fun (e: Event) -> handler e.Value)" propNameSafe propName
              ]

          | "hidden", "only", "'xs' | 'sm' | 'md' | 'lg' | 'xl' | Array<'xs' | 'sm' | 'md' | 'lg' | 'xl'>" ->
              [sprintf "  static member inline %s([<ParamArray>] values: BreakpointKey []) = Interop.mkAttr \"%s\" values" propNameSafe propName]

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
                sprintf "  static member inline %s(format: int -> int -> string) = Interop.mkAttr \"%s\" format" propNameSafe propName
                sprintf "  static member inline %s(format: float -> int -> string) = Interop.mkAttr \"%s\" format" propNameSafe propName
              ]

          | "rating", "getLabelText", "func" ->
              [
                sprintf "  static member inline %s(getText: int -> string) = Interop.mkAttr \"%s\" getText" propNameSafe propName
                sprintf "  static member inline %s(getText: float -> string) = Interop.mkAttr \"%s\" getText" propNameSafe propName
              ]

          | "slider", "getAriaValueText", "func" ->
              [
                sprintf "  static member inline %s(getText: int -> int -> string) = Interop.mkAttr \"%s\" getText" propNameSafe propName
                sprintf "  static member inline %s(getText: float -> int -> string) = Interop.mkAttr \"%s\" getText" propNameSafe propName
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

          | ("bottomNavigation" | "tabs"), "onChange", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> 'a -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: 'a -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun _ v -> handler v))" propNameSafe propName
              ]

          | "toggleButtonGroup", "value", "any" ->
              [
                sprintf "  static member inline %s(value: 'toggleButtonValue option) = Interop.mkAttr \"%s\" value" propNameSafe propName
                sprintf "  static member inline %s(values: 'toggleButtonValue []) = Interop.mkAttr \"%s\" values" propNameSafe propName
              ]

          | "speedDial", "onClose", "func" ->
              [sprintf "  static member inline %s(handler: Event -> string -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName]

          | ("checkbox" | "formControlLabel" | "switch"), "onChange", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
                sprintf "  static member inline %s(handler: bool -> unit) = Interop.mkAttr \"%s\" (fun (e: Event) -> handler e.Checked)" propNameSafe propName
              ]

          | "expansionPanel", "onChange", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> bool -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: bool -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun _ v -> handler v))" propNameSafe propName
              ]

          | "tablePagination", "labelDisplayedRows", "func" ->
              [sprintf "  static member %s(getLabel: {| from: int; to': int; count: int |} -> ReactElement) = Interop.mkAttr \"%s\" getLabel" propNameSafe propName]

          | "rating", ("onChange" | "onChangeActive"), "func"
          | "slider", ("onChange" | "onChangeCommitted"), "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> int -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: Event -> float -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: int -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun _ v -> handler v))" propNameSafe propName
                sprintf "  static member inline %s(handler: float -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun _ v -> handler v))" propNameSafe propName
              ]

          | "select", "onChange", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> ReactElement -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: 'a -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun (e: Event) _ -> handler !!e.Value))" propNameSafe propName
              ]

          | "tablePagination", "onChangePage", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> int -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: int -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun _ v -> handler v))" propNameSafe propName
              ]

          | "toggleButtonGroup", "onChange", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> 'a -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: 'a -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun _ v -> handler v))" propNameSafe propName
              ]

          | "slider", "step", "number" ->
              [
                sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName
                sprintf "  static member inline %s(value: float) = Interop.mkAttr \"%s\" value" propNameSafe propName
                sprintf "  static member inline %s(value: int option) = Interop.mkAttr \"%s\" value" propNameSafe propName
              ]

          | "select", "renderValue", "func" ->
              [sprintf "  static member inline %s(render: 'a -> ReactElement) = Interop.mkAttr \"%s\" render" propNameSafe propName]

          | "checkbox", "value", "any" ->
              [sprintf "  static member inline %s(value: string) = Interop.mkAttr \"%s\" value" propNameSafe propName]

          | "circularProgress", "size", "number | string"
          | "skeleton", ("height" | "width"), "number | string" ->
              [
                sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName
                sprintf "  static member inline %s(value: Styles.ICssUnit) = Interop.mkAttr \"%s\" value" propNameSafe propName
              ]

          | "collapse", "collapsedHeight", "string" ->
              [sprintf "  static member inline %s(value: Styles.ICssUnit) = Interop.mkAttr \"%s\" value" propNameSafe propName]

          | "dialog", "onClose", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> DialogCloseReason -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: DialogCloseReason -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun _ v -> handler v))" propNameSafe propName
              ]

          | "menu", "onClose", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> MenuCloseReason -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: MenuCloseReason -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun _ v -> handler v))" propNameSafe propName
              ]

          | "modal", "onClose", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> ModalCloseReason -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: ModalCloseReason -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun _ v -> handler v))" propNameSafe propName
              ]

          | "popover", "onClose", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> PopoverCloseReason -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: PopoverCloseReason -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun _ v -> handler v))" propNameSafe propName
              ]

          | "snackbar", "onClose", "func" ->
              [
                sprintf "  static member inline %s(handler: Event -> SnackbarCloseReason -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> handler)" propNameSafe propName
                sprintf "  static member inline %s(handler: SnackbarCloseReason -> unit) = Interop.mkAttr \"%s\" (System.Func<_,_,_> (fun _ v -> handler v))" propNameSafe propName
              ]

          | ("modal" | "portal"), "onRendered", "func" ->
              []  // deprecated

          | ("dialog" | "menu" | "popover" | "snackbar"), ("onEnter" | "onEntered" | "onEntering"), "func" ->
              [sprintf "  static member inline %s(handler: ReactElement -> bool -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName]

          | ("dialog" | "menu" | "popover" | "snackbar"), ("onExit" | "onExited" | "onExiting"), "func" ->
              [sprintf "  static member inline %s(handler: ReactElement -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName]

          | "snackbar", "autoHideDuration", "number" ->
              [
                sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName
                sprintf "  static member inline %s(value: int option) = Interop.mkAttr \"%s\" value" propNameSafe propName
              ]

          | "treeView", "onNodeToggle", "func" ->
              [sprintf "  static member inline %s(handler: string -> bool -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName]

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

          | _, ("transitionDuration" | "timeout"), ("number | { enter?: number, exit?: number }" | "number | { enter?: number, exit?: number } | 'auto'") ->
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
                sprintf "  static member inline %s(handler: unit -> Element option) = Interop.mkAttr \"%s\" handler" propNameSafe propName
                sprintf "  static member inline %s(ref: IRefValue<Element option>) = Interop.mkAttr \"%s\" (fun () -> ref.current)" propNameSafe propName
              ]

          | "popover", "getContentAnchorEl", "func" ->
            [
              sprintf "  static member inline %s(handler: Element option -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
            ]

          | ("modal" | "popover" | "popper" | "portal"), "container", ("object | func" | "func | React.Component | Element") ->
              [
                sprintf "  static member inline %s(element: Element option) = Interop.mkAttr \"%s\" element" propNameSafe propName
                sprintf "  static member inline %s(element: ReactElement option) = Interop.mkAttr \"%s\" element" propNameSafe propName
                sprintf "  static member inline %s(getElement: unit -> Element option) = Interop.mkAttr \"%s\" getElement" propNameSafe propName
                sprintf "  static member inline %s(getElement: unit -> ReactElement option) = Interop.mkAttr \"%s\" getElement" propNameSafe propName
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
              [sprintf "  static member inline %s(value: ReactElementType) = Interop.mkAttr \"%s\" value" propNameSafe propName]

          | ("checkbox" | "filledInput" | "formControlLabel" | "input" | "inputBase" | "outlinedInput" | "radio" | "switch" | "textField"), "inputRef", "func | object" ->
              [
                sprintf "  static member inline %s(ref: IRefValue<HTMLInputElement option>) = Interop.mkAttr \"%s\" ref" propNameSafe propName
                sprintf "  static member inline %s(handler: HTMLInputElement -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
              ]

          | "buttonBase", "buttonRef", "func | object" ->
              [
                sprintf "  static member inline %s(ref: IRefValue<HTMLButtonElement option>) = Interop.mkAttr \"%s\" ref" propNameSafe propName
                sprintf "  static member inline %s(handler: HTMLButtonElement -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
              ]

          | "popper", "popperRef", "func | object"
          | "rootRef", "rootRef", "func | object" ->
              [
                sprintf "  static member inline %s(ref: IRefValue<Element option>) = Interop.mkAttr \"%s\" ref" propNameSafe propName
                sprintf "  static member inline %s(handler: Element -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName
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

          | "swipeableDrawer", "hysteresis", "number" ->
              [sprintf "  static member inline %s(value: float) = Interop.mkAttr \"%s\" value" propNameSafe propName]

          | "gridList", "cellHeight", "number | 'auto'"
          | _, _, "number" ->
              [sprintf "  static member inline %s(value: int) = Interop.mkAttr \"%s\" value" propNameSafe propName]

          | _, pn, "func" when pn.StartsWith "on" ->
              [sprintf "  static member inline %s(handler: Event -> unit) = Interop.mkAttr \"%s\" handler" propNameSafe propName]

          | _, pn, "node" when pn = "icon" || pn.EndsWith "Icon" ->
              [sprintf "  static member inline %s(element: ReactElement) = Interop.mkAttr \"%s\" element" propNameSafe propName]

          | ("filledInput" | "input" | "inputBase" | "outlinedInput"), ("startAdornment" | "endAdornment"), "node" ->
              [sprintf "  static member inline %s(element: ReactElement) = Interop.mkAttr \"%s\" element" propNameSafe propName]

          | ("formControl" | "tableRow"), "children", "node" ->
              [
                sprintf "  static member inline %s(element: ReactElement) = prop.children element" propNameSafe
                sprintf "  static member inline %s(elements: ReactElement seq) = prop.children elements" propNameSafe
              ]

          | "stepper", "children", "node" ->
              [
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

          | _ ->
              [sprintf "  static member inline %s(value: TODO) = Interop.mkAttr \"%s\" value" propNameSafe propName]


        for method in methods do
          let docString = getDocString 2 markdownDoc
          if docString <> "" then
            wGeneral.WriteLine docString
          wGeneral.WriteLine method

  use w = new StringWriter()

  if hasGeneralProps then
    if wGeneral.ToString() |> hasNonInlineMembers |> not then
      w.printfn "[<Erase>]"
    w.printfn "type %s =" componentNameCamelCase
    w.WriteLine(wGeneral.ToString())

  // Ugly hack
  if componentNameCamelCase = "slider" then
    w.printfn "[<AutoOpen>]"
    w.printfn "module sliderExtensions ="
    w.printfn ""
    w.printfn "  type slider with"
    System.Text.RegularExpressions.Regex.Match(wGeneral.ToString(), "\/\/\/.+\r\n\s*static member inline step\(value: int option.+\r\n").Groups.[0].Value
    |> sprintf "  %s"
    |> fun s ->
        s.Replace("value: int option", "value: float option")
         .Replace("  ", "    ")
    |> w.WriteLine

  if hasEnumProps then
    w.printfn "module %s =" componentNameCamelCase
    w.WriteLine(wEnum.ToString())

  w.ToString ()

let generateAll () =
  Console.WriteLine("\n\nGENERATING PROPS\n")
  use w = new StringWriter()
  w.printfn """namespace Feliz.MaterialUI

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

"""

  HtmlCache.getCachedPages () |> Array.map (fun path ->
    Console.WriteLine(sprintf "Processing %s" path)
    generatePage path
  )
  |> Array.iter w.WriteLine
  System.IO.File.WriteAllText(outFile, w.ToString())
