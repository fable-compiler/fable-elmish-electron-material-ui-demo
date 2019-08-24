module SaveLoad

open System
open Elmish
open Fable.Core.JsInterop
open Electron
open Fable.React
open Fable.React.Props
open Node.Api
open Node.Base
open Fable.MaterialUI
open Fable.MaterialUI.Core
open FSharp.Core  // To prevent shadowing Result.Error


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


let private styles (theme: ITheme) : IStyles list =
  []


let private view' (classes: IClasses) model dispatch =
  form [ OnSubmit preventDefault; Class classes?form ] [
    textField [
      Multiline true
      Rows 4
      HTMLAttr.Label "Your story"
      HTMLAttr.Value model.Text
      DOMAttr.OnChange (fun ev -> ev.Value |> SetText |> dispatch)
    ] []
    button [
      OnClick (fun _ -> dispatch RequestSave)
      MaterialProp.Color ComponentColor.Primary
    ] [ str "Save" ]
    button [
      OnClick (fun _ -> dispatch RequestLoad)
      MaterialProp.Color ComponentColor.Primary
    ] [ str "Load" ]
  ]


// Workaround for using JSS with Elmish
// https://github.com/mvsmal/fable-material-ui/issues/4#issuecomment-422781471
type private IProps =
  abstract member model: Model with get, set
  abstract member dispatch: (Msg -> unit) with get, set
  inherit IClassesProps

type private Component(p) =
  inherit PureStatelessComponent<IProps>(p)
  let viewFun (p: IProps) = view' p.classes p.model p.dispatch
  let viewWithStyles = withStyles (StyleType.Func styles) [] viewFun
  override this.render() = ReactElementType.create viewWithStyles this.props []


let view (model: Model) (dispatch: Msg -> unit) : ReactElement =
  let props = jsOptions<IProps>(fun p ->
    p.model <- model
    p.dispatch <- dispatch)
  ofType<Component,_,_> props []
