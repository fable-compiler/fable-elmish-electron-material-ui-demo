module DevTools

open Fable.Core
open Fable.Core.JsInterop
open Electron

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
  main.BrowserWindow.removeDevToolsExtension("React Developer Tools")
  main.BrowserWindow.removeDevToolsExtension("Redux DevTools")
  win.webContents.executeJavaScript("require('devtron').uninstall()")
