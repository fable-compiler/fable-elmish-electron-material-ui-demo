[<AutoOpen>]
module Bindings

open Electron
open Fable.Core.JsInterop


module WindowState =

  type State =
    /// The saved x coordinate of the loaded state. None if the state has not
    /// been saved yet.
    abstract x: int option
    /// The saved y coordinate of the loaded state. None if the state has not
    /// been saved yet.
    abstract y: int
    /// The saved width of loaded state. `defaultWidth` if the state has not
    /// been saved yet.
    abstract width: int
    /// The saved heigth of loaded state. `defaultHeight` if the state has not
    /// been saved yet.
    abstract height: int
    /// `true` if the window state was saved while the window was maximized.
    /// None if the state has not been saved yet.
    abstract isMaximized: bool option
    /// `true` if the window state was saved while the window was in full screen
    /// mode. None if the state has not been saved yet.
    abstract isFullScreen: bool option
    /// Register listeners on the given `BrowserWindow` for events that are
    /// related to size or position changes (`resize`, `move`). It will also
    /// restore the window's maximized or full screen state. When the window is
    /// closed we automatically remove the listeners and save the state.
    abstract manage: window: BrowserWindow -> unit
    /// Removes all listeners of the managed `BrowserWindow` in case it does not
    /// need to be managed anymore.
    abstract unmanage: unit -> unit
    /// Saves the current state of the given `BrowserWindow`. This exists mostly
    /// for legacy purposes, and in most cases it's better to just use `manage`.
    abstract saveState: window: BrowserWindow -> unit

  [<AllowNullLiteral>]
  type Options =
    /// The width that should be returned if no file exists yet.
    /// Defaults to `800`.
    abstract defaultWidth: int with get, set
    /// The height that should be returned if no file exists yet.
    /// Defaults to `600`.
    abstract defaultHeight: int with get, set
    /// The path where the state file should be written to.
    /// Defaults to `app.getPath('userData')`.
    abstract path: string with get, set
    /// The name of file. Defaults to `window-state.json`.
    abstract file: string with get, set
    /// Should we automatically maximize the window, if it was last closed
    /// maximized. Defaults to `true`.
    abstract maximize: bool with get, set
    /// Should we automatically restore the window to full screen, if it was
    /// last closed full screen. Defaults to `true`.
    abstract fullScreen: bool with get, set

  let getState : Options -> State =
    importDefault "electron-window-state"
