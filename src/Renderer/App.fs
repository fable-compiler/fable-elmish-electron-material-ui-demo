module App

(**
 TodoMVC app ported from Elm.
 You can find more info about Emish architecture and samples at https://elmish.github.io/
 NOTE: The API in Fable's REPL may differ from Fable.Elmish & Fable.React nuget libraries.
       The generated JS code won't be as optimized as when using dotnet-fable.
*)

open Fable.Import
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Elmish
open Elmish.React

let [<Literal>] ESC_KEY = 27.
let [<Literal>] ENTER_KEY = 13.
let [<Literal>] ALL_TODOS = "all"
let [<Literal>] ACTIVE_TODOS = "active"
let [<Literal>] COMPLETED_TODOS = "completed"

// MODEL
type Entry =
    { description : string
      completed : bool
      editing : bool
      id : int }

// The full application state of our todo app.
type Model =
    { entries : Entry list
      field : string
      uid : int
      visibility : string }

let emptyModel () =
    { entries = []
      visibility = ALL_TODOS
      field = ""
      uid = 0 }

let newEntry desc id =
  { description = desc
    completed = false
    editing = false
    id = id }

// UPDATE

(** Users of our app can trigger messages by clicking and typing. These
messages are fed into the `update` function as they occur, letting us react
to them.
*)
type Msg =
    | Failure of string
    | UpdateField of string
    | EditingEntry of int*bool
    | UpdateEntry of int*string
    | Add
    | Delete of int
    | DeleteComplete
    | Check of int*bool
    | CheckAll of bool
    | ChangeVisibility of string

// How we update our Model on a given Msg?
let update (msg:Msg) (model:Model) =
    match msg with
    | Failure err ->
        Fable.Import.Browser.console.error(err)
        model

    | Add ->
        let xs = if System.String.IsNullOrEmpty model.field then
                    model.entries
                 else
                    model.entries @ [newEntry model.field model.uid]
        { model with
            uid = model.uid + 1
            field = ""
            entries = xs }

    | UpdateField str ->
      { model with field = str }

    | EditingEntry (id,isEditing) ->
        let updateEntry t =
          if t.id = id then { t with editing = isEditing } else t
        { model with entries = List.map updateEntry model.entries }

    | UpdateEntry (id,task) ->
        let updateEntry t =
          if t.id = id then { t with description = task } else t
        { model with entries = List.map updateEntry model.entries }

    | Delete id ->
        { model with entries = List.filter (fun t -> t.id <> id) model.entries }

    | DeleteComplete ->
        { model with entries = List.filter (fun t -> not t.completed) model.entries }

    | Check (id,isCompleted) ->
        let updateEntry t =
          if t.id = id then { t with completed = isCompleted } else t
        { model with entries = List.map updateEntry model.entries }

    | CheckAll isCompleted ->
        let updateEntry t = { t with completed = isCompleted }
        { model with entries = List.map updateEntry model.entries }

    | ChangeVisibility visibility ->
        { model with visibility = visibility }

let onEnter msg dispatch =
    OnKeyDown (fun ev ->
        let ev = ev :?> Browser.KeyboardEvent
        if ev.keyCode = ENTER_KEY then
            dispatch msg)

let targetValue (ev: React.SyntheticEvent) =
    (ev.target :?> Browser.HTMLInputElement).value

let viewInput (model:string) dispatch =
    header [ Class "header" ] [
        h1 [] [
            img [
                Src "todo.png"
                Style [ Height "0.52em" ]
            ]
            str "todos"
        ]
        input [
            Class "new-todo"
            Placeholder "What needs to be done?"
            Value model
            onEnter Add dispatch
            OnChange (fun ev ->
                targetValue ev |> UpdateField |> dispatch)
            AutoFocus true
        ]
    ]

let classList classes =
    classes
    |> List.fold (fun complete -> function | (name,true) -> complete + " " + name | _ -> complete) ""
    |> Class

let viewEntry todo dispatch =
  li
    [ classList [ ("completed", todo.completed); ("editing", todo.editing) ]]
    [ div
        [ Class "view" ]
        [ input
            [ Class "toggle"
              Type "checkbox"
              Checked todo.completed
              OnChange (fun _ -> Check (todo.id,(not todo.completed)) |> dispatch) ]
          label
            [ OnDoubleClick (fun _ -> EditingEntry (todo.id,true) |> dispatch) ]
            [ str todo.description ]
          button
            [ Class "destroy"
              OnClick (fun _-> Delete todo.id |> dispatch) ]
            []
        ]
      input
        [ Class "edit"
          Value todo.description
          Name "title"
          Id ("todo-" + (string todo.id))
          OnInput (fun ev -> UpdateEntry (todo.id, targetValue ev) |> dispatch)
          OnBlur (fun _ -> EditingEntry (todo.id,false) |> dispatch)
          onEnter (EditingEntry (todo.id,false)) dispatch ]
    ]

let viewEntries visibility entries dispatch =
    let isVisible todo =
        match visibility with
        | COMPLETED_TODOS -> todo.completed
        | ACTIVE_TODOS -> not todo.completed
        | _ -> true

    let allCompleted =
        List.forall (fun t -> t.completed) entries

    let cssVisibility =
        if List.isEmpty entries then "hidden" else "visible"

    section
      [ Class "main"
        Style [ Visibility cssVisibility ]]
      [ input
          [ Class "toggle-all"
            Type "checkbox"
            Name "toggle"
            Checked allCompleted
            OnChange (fun _ -> CheckAll (not allCompleted) |> dispatch)]
        label
          [ HtmlFor "toggle-all" ]
          [ str "Mark all as complete" ]
        ul
          [ Class "todo-list" ]
          (entries
           |> List.filter isVisible
           |> List.map (fun i -> viewEntry i dispatch)) ]

// VIEW CONTROLS AND FOOTER
let visibilitySwap uri visibility actualVisibility dispatch =
  li
    [ OnClick (fun _ -> ChangeVisibility visibility |> dispatch) ]
    [ a [ Href uri
          classList ["selected", visibility = actualVisibility] ]
          [ str visibility ] ]

let viewControlsFilters visibility dispatch =
  ul
    [ Class "filters" ]
    [ visibilitySwap "#/" ALL_TODOS visibility dispatch
      str " "
      visibilitySwap "#/active" ACTIVE_TODOS visibility dispatch
      str " "
      visibilitySwap "#/completed" COMPLETED_TODOS visibility dispatch ]

let viewControlsCount entriesLeft =
  let item =
      if entriesLeft = 1 then " item" else " items"

  span
      [ Class "todo-count" ]
      [ strong [] [ str (string entriesLeft) ]
        str (item + " left") ]

let viewControlsClear entriesCompleted dispatch =
  button
    [ Class "clear-completed"
      Hidden (entriesCompleted = 0)
      OnClick (fun _ -> DeleteComplete |> dispatch)]
    [ str ("Clear completed (" + (string entriesCompleted) + ")") ]

let viewControls visibility entries dispatch =
  let entriesCompleted =
      entries
      |> List.filter (fun t -> t.completed)
      |> List.length

  let entriesLeft =
      List.length entries - entriesCompleted

  footer
      [ Class "footer"
        Hidden (List.isEmpty entries) ]
      [ viewControlsCount entriesLeft
        viewControlsFilters visibility dispatch
        viewControlsClear entriesCompleted dispatch ]

let infoFooter =
  footer [ Class "info" ]
    [ p []
        [ str "Double-click to edit a todo" ]
      p []
        [ str "Ported from Elm by "
          a [ Href "https://github.com/et1975" ] [ str "Eugene Tolmachev" ]]
      p []
        [ str "Part of "
          a [ Href "http://todomvc.com" ] [ str "TodoMVC" ]]
    ]

let view model dispatch =
  div
    [ Class "todomvc-wrapper"]
    [ section
        [ Class "todoapp" ]
        [ viewInput model.field dispatch
          viewEntries model.visibility model.entries dispatch
          viewControls model.visibility model.entries dispatch ]
      infoFooter ]
