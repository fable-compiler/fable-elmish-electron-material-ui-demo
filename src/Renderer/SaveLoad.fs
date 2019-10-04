module SaveLoad

open System
open Elmish
open Fable.Core.JsInterop
open Electron
open Fable.React
open Node.Api
open Node.Base
open Feliz
open Feliz.MaterialUI


let writeUtf8Async text pathAndFilename =
  Promise.create (fun resolve reject ->
    fs.writeFile(
      pathAndFilename,
      text,
      function
        | None -> resolve <| Ok ()
        | Some err -> resolve <| Error err
    )
  )


let readUtf8Async pathAndFilename =
  Promise.create (fun resolve reject ->
    fs.readFile(
      pathAndFilename,
      "utf8",
      fun optErr contents ->
        match optErr with
        | None -> resolve <| Ok contents
        | Some err -> resolve <| Error err
    )
  )


[<RequireQualifiedAccess>]
type SaveResult =
  | Saved
  | Canceled

[<RequireQualifiedAccess>]
type LoadResult =
  | Loaded of string
  | Canceled


type Model =
  { Text: string
    LastSaved: (string * DateTimeOffset) option
    ErrMsg: string option }

type Msg =
  | SetText of string
  | RequestSave
  | RequestLoad
  | SaveSuccess of string
  | LoadSuccess of string
  | SaveCanceled
  | LoadCanceled
  | SaveFailed of ErrnoException
  | LoadFailed of ErrnoException

let init () =
  { Text = ""
    LastSaved = None
    ErrMsg = None }


let save text =
  promise {
    let opts = jsOptions<SaveDialogOptions>(fun o ->
      // See https://github.com/electron/electron/blob/master/docs/api/dialog.md
      o.title <- "Title of save dialog"
      o.defaultPath <- renderer.remote.app.getPath AppPathName.Desktop
      o.filters <-
        [|
          jsOptions<FileFilter>(fun f ->
            f.name <- "Text files"
            f.extensions <- [|"txt"|]
          )
        |]
    )
    let! res = renderer.remote.dialog.showSaveDialog opts
    if res.canceled then return Ok SaveResult.Canceled
    else
      let! result =
        res.filePath
        |> String.ensureEndsWith ".txt"
        |> writeUtf8Async text
      return result |> Result.map (fun () -> SaveResult.Saved)
  }


let load () =
  promise {
    let opts = jsOptions<OpenDialogOptions>(fun o ->
      // See https://github.com/electron/electron/blob/master/docs/api/dialog.md
      o.title <- "Title of load dialog"
      o.defaultPath <- renderer.remote.app.getPath AppPathName.Desktop
      o.filters <-
        [|
          jsOptions<FileFilter>(fun f ->
            f.name <- "Text files"
            f.extensions <- [|"txt"|]
          )
        |]
    )
    let! res = renderer.remote.dialog.showOpenDialog opts
    if res.canceled then return Ok LoadResult.Canceled
    else
      let! result = readUtf8Async (Seq.head res.filePaths)
      return result |> Result.map LoadResult.Loaded
  }


let update msg m =
  match msg with
  | SetText s -> { m with Text = s }, Cmd.none

  | RequestSave ->
      let handleSaved = function
        | Ok SaveResult.Saved -> SaveSuccess m.Text
        | Ok SaveResult.Canceled -> SaveCanceled
        | Error err -> SaveFailed err
      m, Cmd.OfPromise.perform save m.Text handleSaved

  | RequestLoad ->
      let handleLoaded = function
        | Ok (LoadResult.Loaded contents) -> LoadSuccess contents
        | Ok LoadResult.Canceled -> LoadCanceled
        | Error err -> LoadFailed err
      m, Cmd.OfPromise.perform load () handleLoaded

  | SaveSuccess s ->
      { m with LastSaved = Some (s, DateTimeOffset.Now); ErrMsg = None },
      Cmd.none

  | LoadSuccess s ->
      { m with Text = s; LastSaved = Some (s, DateTimeOffset.Now); ErrMsg = None },
      Cmd.none

  | SaveCanceled -> m, Cmd.none  // no-op

  | LoadCanceled -> m, Cmd.none  // no-op

  | SaveFailed err ->
      { m with ErrMsg = Some <| sprintf "Error when saving: %s" err.message },
      Cmd.none

  | LoadFailed err ->
      { m with ErrMsg = Some <| sprintf "Error when loading: %s" err.message },
      Cmd.none


// Domain/Elmish above, view below

let SaveLoadPage = FunctionComponent.Of((fun (model, dispatch) ->
  Html.form [
    prop.onSubmit preventDefault
    prop.children [
      Mui.textField [
        textField.multiline true
        textField.rows 4
        textField.label "Your story"
        textField.value model.Text
        textField.onChange (SetText >> dispatch)
      ]
      Mui.button [
        prop.onClick (fun _ -> dispatch RequestSave)
        button.color.primary
        button.children "Save"
      ]
      Mui.button [
        prop.onClick (fun _ -> dispatch RequestLoad)
        button.color.primary
        button.children "Load"
      ]
    ]
  ]
), "SaveLoadPage", memoEqualsButFunctions)
