module Main

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Electron.Types
open Node.Api

// A global reference to the window object is required in order to prevent garbage collection
let mutable mainWindow: BrowserWindow option = Option.None

[<Emit("$0.webContents.focus()")>]
let webContentsFocus (win: BrowserWindow) : unit = jsNative

module WindowState =

  type State =
    abstract x: int with get
    abstract y: int with get
    abstract width: int with get
    abstract height: int with get
    abstract isMaximized: bool with get
    abstract isFullScreen: bool with get
    abstract manage : BrowserWindow -> unit
    abstract unmanage : unit -> unit
    abstract saveState : BrowserWindow -> unit

  [<AllowNullLiteral>]
  type Options =
    /// The height that should be returned if no file exists yet. Defaults to `600`.
    abstract defaultHeight: int option with get, set
    /// The width that should be returned if no file exists yet. Defaults to `800`.
    abstract defaultWidth: int option with get, set
    abstract fullScreen: bool option with get, set
    /// The path where the state file should be written to. Defaults to `app.getPath('userData')`.
    abstract path: string option with get, set
    /// The name of file. Defaults to `window-state.json`.
    abstract file: string option with get, set
    /// Should we automatically maximize the window, if it was last closed maximized. Defaults to `true`.
    abstract maximize: bool option with get, set

  let getState : Options -> State =
    importDefault "electron-window-state"


#if DEBUG
module DevTools =

  let private installDevTools (extensionRef: obj) (forceDownload: bool) : JS.Promise<string> =
    importDefault "electron-devtools-installer"

  let private REACT_DEVELOPER_TOOLS : obj =
    import "REACT_DEVELOPER_TOOLS" "electron-devtools-installer"

  let private REDUX_DEVTOOLS : obj =
    import "REDUX_DEVTOOLS" "electron-devtools-installer"

  let private installDevTool extensionRef =
    promise {
      try
        let! name = installDevTools extensionRef false
        JS.console.log("Added extension", name)
      with err -> JS.console.log("An error occurred adding extension:", err)
    } |> ignore

  let installAllDevTools (win: BrowserWindow) =
    installDevTool REACT_DEVELOPER_TOOLS
    installDevTool REDUX_DEVTOOLS
    win.webContents.executeJavaScript("require('devtron').install()")

  let uninstallAllDevTools (win: BrowserWindow) =
    electron.BrowserWindow.removeDevToolsExtension("React Developer Tools")
    electron.BrowserWindow.removeDevToolsExtension("Redux DevTools")
    win.webContents.executeJavaScript("require('devtron').uninstall()")

  let connectRemoteDevViaExtension: unit -> unit = import "connectViaExtension" "remotedev"
#endif


let createMainWindow () =
  let winStateOpts = jsOptions<WindowState.Options>(fun o ->
    o.defaultHeight <- Some 600
    o.defaultWidth <- Some 800)
  let mainWinState = WindowState.getState winStateOpts

  let options = jsOptions<BrowserWindowOptions>(fun o ->
    o.width <- Some (float mainWinState.width)
    o.height <- Some (float mainWinState.height)
    o.autoHideMenuBar <- Some true
    o.webPreferences <- Some <| jsOptions<WebPreferences>(fun w ->
      w.contextIsolation <- Some false
      w.nodeIntegration <- Some true
    )
    o.show <- Some true)
  let win = electron.BrowserWindow.Create(options)

  mainWinState.manage win

  #if DEBUG
  // Set up dev tools
  DevTools.installAllDevTools win
  DevTools.connectRemoteDevViaExtension ()
  // Open dev tools on startup
  win.webContents.openDevTools()
  #endif

  // Load correct URL
  #if DEBUG
  let port = ``process``.env?ELECTRON_WEBPACK_WDS_PORT
  win.loadURL(sprintf "http://localhost:%s" port)
  #else
  path.join(__dirname, "index.html")
  |> sprintf "file:///%s"
  |> win.loadURL
  #endif

  // Dereference the window object when closed. If your app supports
  // multiple windows, you can store them in an array and delete the
  // corresponding element here.
  win.on("closed", fun ev -> mainWindow <- Option.None) |> ignore

  win.webContents.on("devtools-opened", fun ev -> webContentsFocus win) |> ignore

  mainWindow <- Some win


// This method will be called when Electron has finished
// initialization and is ready to create browser windows.
electron.app.on("ready", fun ev -> createMainWindow ()) |> ignore

// Quit when all windows are closed.
electron.app.on("window-all-closed", fun ev ->
  // On OS X it's common for applications and their menu bar
  // to stay active until the user quits explicitly with Cmd + Q
  if ``process``.platform <> Node.Base.Platform.Darwin then
    electron.app.quit()
) |> ignore

electron.app.on("activate", fun ev ->
  // On OS X it's common to re-create a window in the app when the
  // dock icon is clicked and there are no other windows open.
  if mainWindow.IsNone then createMainWindow ()
) |> ignore
