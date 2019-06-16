module rec Electron

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types
open Node.Base
open Node.Buffer


[<ImportAll("electron")>]
let electron : IExports = jsNative

[<ImportAll("electron")>]
let main : MainInterface = jsNative

[<ImportAll("electron")>]
let renderer : RendererInterface = jsNative


type IExports =
  inherit AllElectron
  abstract TouchBarButton: TouchBarButtonStatic
  abstract TouchBarColorPicker: TouchBarColorPickerStatic
  abstract TouchBarGroup: TouchBarGroupStatic
  abstract TouchBarLabel: TouchBarLabelStatic
  abstract TouchBarPopover: TouchBarPopoverStatic
  abstract TouchBarScrubber: TouchBarScrubberStatic
  abstract TouchBarSegmentedControl: TouchBarSegmentedControlStatic
  abstract TouchBarSlider: TouchBarSliderStatic
  abstract TouchBarSpacer: TouchBarSpacerStatic

type EventEmitter<'self> =
  abstract addListener: event: string * listener: (Event -> unit) -> 'self
  abstract on: event: string * listener: (Event -> unit) -> 'self
  abstract once: event: string * listener: (Event -> unit) -> 'self
  abstract removeListener: event: string * listener: (Event -> unit) -> 'self
  abstract removeAllListeners: ?event: string -> 'self
  abstract setMaxListeners: n: int -> 'self
  abstract getMaxListeners: unit -> int
  abstract listeners: event: string -> (Event -> unit) []
  abstract emit: event: string * [<ParamArray>] args: obj [] -> bool
  abstract listenerCount: event: string -> int
  abstract prependListener: event: string * listener: (Event -> unit) -> 'self
  abstract prependOnceListener: event: string * listener: (Event -> unit) -> 'self
  abstract eventNames: unit -> string []

type ReturnValueEvent =
  inherit Browser.Types.Event
  abstract returnValue: obj option with get, set

type IpcMainEvent =
  inherit ReturnValueEvent
  abstract frameId: int with get, set
  abstract sender: WebContents with get, set
  abstract reply: channel: string * [<ParamArray>] args: obj [] -> unit

type TrayInputEvent =
  inherit Browser.Types.Event
  abstract altKey: bool with get, set
  abstract shiftKey: bool with get, set
  abstract ctrlKey: bool with get, set
  abstract metaKey: bool with get, set

type CommonInterface =
  abstract clipboard: Clipboard with get, set
  abstract crashReporter: CrashReporter with get, set
  abstract NativeImage: NativeImageStatic with get, set
  abstract screen: Screen with get, set
  abstract shell: Shell with get, set

type MainInterface =
  inherit CommonInterface
  abstract app: App with get, set
  abstract autoUpdater: AutoUpdater with get, set
  abstract BrowserView: BrowserViewStatic with get, set
  abstract BrowserWindow: BrowserWindowStatic with get, set
  abstract ClientRequest: ClientRequestStatic with get, set
  abstract contentTracing: ContentTracing with get, set
  abstract dialog: Dialog with get, set
  abstract globalShortcut: GlobalShortcut with get, set
  abstract inAppPurchase: InAppPurchase with get, set
  abstract ipcMain: IpcMain with get, set
  abstract Menu: MenuStatic with get, set
  abstract MenuItem: MenuItemStatic with get, set
  abstract net: Net with get, set
  abstract netLog: NetLog with get, set
  abstract Notification: NotificationStatic with get, set
  abstract powerMonitor: PowerMonitor with get, set
  abstract powerSaveBlocker: PowerSaveBlocker with get, set
  abstract protocol: Protocol with get, set
  abstract Session: SessionStatic with get, set
  abstract systemPreferences: SystemPreferences with get, set
  abstract TouchBar: TouchBarStatic with get, set
  abstract Tray: TrayStatic with get, set
  abstract WebContents: WebContentsStatic with get, set

type RendererInterface =
  inherit CommonInterface
  abstract desktopCapturer: DesktopCapturer with get, set
  abstract ipcRenderer: IpcRenderer with get, set
  abstract remote: Remote with get, set
  abstract webFrame: WebFrame with get, set

type AllElectron =
  inherit MainInterface
  inherit RendererInterface

[<StringEnum; RequireQualifiedAccess>]
type GpuInfoType =
  | Basic
  | Complete

[<StringEnum; RequireQualifiedAccess>]
type AppPathName =
  | Home
  | AppData
  | UserData
  | Temp
  | Exe
  | Module
  | Desktop
  | Documents
  | Downloads
  | Music
  | Pictures
  | Videos
  | PepperFlashSystemPlugin

type App =
  inherit EventEmitter<App>
  /// Emitted when Chrome's accessibility support changes. This event fires when
  /// assistive technologies, such as screen readers, are enabled or disabled. See
  /// https://www.chromium.org/developers/design-documents/accessibility for more
  /// details.
  [<Emit "$0.on('accessibility-support-changed',$1)">] abstract onAccessibilitySupportChanged: listener: (Event -> bool -> unit) -> App
  [<Emit "$0.once('accessibility-support-changed',$1)">] abstract onceAccessibilitySupportChanged: listener: (Event -> bool -> unit) -> App
  [<Emit "$0.addListener('accessibility-support-changed',$1)">] abstract addListenerAccessibilitySupportChanged: listener: (Event -> bool -> unit) -> App
  [<Emit "$0.removeListener('accessibility-support-changed',$1)">] abstract removeListenerAccessibilitySupportChanged: listener: (Event -> bool -> unit) -> App
  /// Emitted when the application is activated. Various actions can trigger this
  /// event, such as launching the application for the first time, attempting to
  /// re-launch the application when it's already running, or clicking on the
  /// application's dock or taskbar icon.
  [<Emit "$0.on('activate',$1)">] abstract onActivate: listener: (Event -> bool -> unit) -> App
  [<Emit "$0.once('activate',$1)">] abstract onceActivate: listener: (Event -> bool -> unit) -> App
  [<Emit "$0.addListener('activate',$1)">] abstract addListenerActivate: listener: (Event -> bool -> unit) -> App
  [<Emit "$0.removeListener('activate',$1)">] abstract removeListenerActivate: listener: (Event -> bool -> unit) -> App
  /// Emitted during Handoff after an activity from this device was successfully
  /// resumed on another one.
  [<Emit "$0.on('activity-was-continued',$1)">] abstract onActivityWasContinued: listener: (Event -> string -> obj option -> unit) -> App
  [<Emit "$0.once('activity-was-continued',$1)">] abstract onceActivityWasContinued: listener: (Event -> string -> obj option -> unit) -> App
  [<Emit "$0.addListener('activity-was-continued',$1)">] abstract addListenerActivityWasContinued: listener: (Event -> string -> obj option -> unit) -> App
  [<Emit "$0.removeListener('activity-was-continued',$1)">] abstract removeListenerActivityWasContinued: listener: (Event -> string -> obj option -> unit) -> App
  /// Emitted before the application starts closing its windows. Calling
  /// event.preventDefault() will prevent the default behavior, which is terminating
  /// the application. Note: If application quit was initiated by
  /// autoUpdater.quitAndInstall(), then before-quit is emitted after emitting close
  /// event on all windows and closing them. Note: On Windows, this event will not be
  /// emitted if the app is closed due to a shutdown/restart of the system or a user
  /// logout.
  [<Emit "$0.on('before-quit',$1)">] abstract onBeforeQuit: listener: (Event -> unit) -> App
  [<Emit "$0.once('before-quit',$1)">] abstract onceBeforeQuit: listener: (Event -> unit) -> App
  [<Emit "$0.addListener('before-quit',$1)">] abstract addListenerBeforeQuit: listener: (Event -> unit) -> App
  [<Emit "$0.removeListener('before-quit',$1)">] abstract removeListenerBeforeQuit: listener: (Event -> unit) -> App
  /// Emitted when a browserWindow gets blurred.
  [<Emit "$0.on('browser-window-blur',$1)">] abstract onBrowserWindowBlur: listener: (Event -> BrowserWindow -> unit) -> App
  [<Emit "$0.once('browser-window-blur',$1)">] abstract onceBrowserWindowBlur: listener: (Event -> BrowserWindow -> unit) -> App
  [<Emit "$0.addListener('browser-window-blur',$1)">] abstract addListenerBrowserWindowBlur: listener: (Event -> BrowserWindow -> unit) -> App
  [<Emit "$0.removeListener('browser-window-blur',$1)">] abstract removeListenerBrowserWindowBlur: listener: (Event -> BrowserWindow -> unit) -> App
  /// Emitted when a new browserWindow is created.
  [<Emit "$0.on('browser-window-created',$1)">] abstract onBrowserWindowCreated: listener: (Event -> BrowserWindow -> unit) -> App
  [<Emit "$0.once('browser-window-created',$1)">] abstract onceBrowserWindowCreated: listener: (Event -> BrowserWindow -> unit) -> App
  [<Emit "$0.addListener('browser-window-created',$1)">] abstract addListenerBrowserWindowCreated: listener: (Event -> BrowserWindow -> unit) -> App
  [<Emit "$0.removeListener('browser-window-created',$1)">] abstract removeListenerBrowserWindowCreated: listener: (Event -> BrowserWindow -> unit) -> App
  /// Emitted when a browserWindow gets focused.
  [<Emit "$0.on('browser-window-focus',$1)">] abstract onBrowserWindowFocus: listener: (Event -> BrowserWindow -> unit) -> App
  [<Emit "$0.once('browser-window-focus',$1)">] abstract onceBrowserWindowFocus: listener: (Event -> BrowserWindow -> unit) -> App
  [<Emit "$0.addListener('browser-window-focus',$1)">] abstract addListenerBrowserWindowFocus: listener: (Event -> BrowserWindow -> unit) -> App
  [<Emit "$0.removeListener('browser-window-focus',$1)">] abstract removeListenerBrowserWindowFocus: listener: (Event -> BrowserWindow -> unit) -> App
  /// Emitted when failed to verify the certificate for url, to trust the certificate
  /// you should prevent the default behavior with event.preventDefault() and call
  /// callback(true).
  [<Emit "$0.on('certificate-error',$1)">] abstract onCertificateError: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
  [<Emit "$0.once('certificate-error',$1)">] abstract onceCertificateError: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
  [<Emit "$0.addListener('certificate-error',$1)">] abstract addListenerCertificateError: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
  [<Emit "$0.removeListener('certificate-error',$1)">] abstract removeListenerCertificateError: listener: (Event -> WebContents -> string -> string -> Certificate -> (bool -> unit) -> unit) -> App
  /// Emitted during Handoff when an activity from a different device wants to be
  /// resumed. You should call event.preventDefault() if you want to handle this
  /// event. A user activity can be continued only in an app that has the same
  /// developer Team ID as the activity's source app and that supports the activity's
  /// type. Supported activity types are specified in the app's Info.plist under the
  /// NSUserActivityTypes key.
  [<Emit "$0.on('continue-activity',$1)">] abstract onContinueActivity: listener: (Event -> string -> obj option -> unit) -> App
  [<Emit "$0.once('continue-activity',$1)">] abstract onceContinueActivity: listener: (Event -> string -> obj option -> unit) -> App
  [<Emit "$0.addListener('continue-activity',$1)">] abstract addListenerContinueActivity: listener: (Event -> string -> obj option -> unit) -> App
  [<Emit "$0.removeListener('continue-activity',$1)">] abstract removeListenerContinueActivity: listener: (Event -> string -> obj option -> unit) -> App
  /// Emitted during Handoff when an activity from a different device fails to be
  /// resumed.
  [<Emit "$0.on('continue-activity-error',$1)">] abstract onContinueActivityError: listener: (Event -> string -> string -> unit) -> App
  [<Emit "$0.once('continue-activity-error',$1)">] abstract onceContinueActivityError: listener: (Event -> string -> string -> unit) -> App
  [<Emit "$0.addListener('continue-activity-error',$1)">] abstract addListenerContinueActivityError: listener: (Event -> string -> string -> unit) -> App
  [<Emit "$0.removeListener('continue-activity-error',$1)">] abstract removeListenerContinueActivityError: listener: (Event -> string -> string -> unit) -> App
  /// Emitted when desktopCapturer.getSources() is called in the renderer process of
  /// webContents. Calling event.preventDefault() will make it return empty sources.
  [<Emit "$0.on('desktop-capturer-get-sources',$1)">] abstract onDesktopCapturerGetSources: listener: (Event -> WebContents -> unit) -> App
  [<Emit "$0.once('desktop-capturer-get-sources',$1)">] abstract onceDesktopCapturerGetSources: listener: (Event -> WebContents -> unit) -> App
  [<Emit "$0.addListener('desktop-capturer-get-sources',$1)">] abstract addListenerDesktopCapturerGetSources: listener: (Event -> WebContents -> unit) -> App
  [<Emit "$0.removeListener('desktop-capturer-get-sources',$1)">] abstract removeListenerDesktopCapturerGetSources: listener: (Event -> WebContents -> unit) -> App
  /// Emitted when the gpu process crashes or is killed.
  [<Emit "$0.on('gpu-process-crashed',$1)">] abstract onGpuProcessCrashed: listener: (Event -> bool -> unit) -> App
  [<Emit "$0.once('gpu-process-crashed',$1)">] abstract onceGpuProcessCrashed: listener: (Event -> bool -> unit) -> App
  [<Emit "$0.addListener('gpu-process-crashed',$1)">] abstract addListenerGpuProcessCrashed: listener: (Event -> bool -> unit) -> App
  [<Emit "$0.removeListener('gpu-process-crashed',$1)">] abstract removeListenerGpuProcessCrashed: listener: (Event -> bool -> unit) -> App
  /// Emitted when webContents wants to do basic auth. The default behavior is to
  /// cancel all authentications. To override this you should prevent the default
  /// behavior with event.preventDefault() and call callback(username, password) with
  /// the credentials.
  [<Emit "$0.on('login',$1)">] abstract onLogin: listener: (Event -> WebContents -> LoginRequest -> AuthInfo -> (string -> string -> unit) -> unit) -> App
  [<Emit "$0.once('login',$1)">] abstract onceLogin: listener: (Event -> WebContents -> LoginRequest -> AuthInfo -> (string -> string -> unit) -> unit) -> App
  [<Emit "$0.addListener('login',$1)">] abstract addListenerLogin: listener: (Event -> WebContents -> LoginRequest -> AuthInfo -> (string -> string -> unit) -> unit) -> App
  [<Emit "$0.removeListener('login',$1)">] abstract removeListenerLogin: listener: (Event -> WebContents -> LoginRequest -> AuthInfo -> (string -> string -> unit) -> unit) -> App
  /// Emitted when the user clicks the native macOS new tab button. The new tab button
  /// is only visible if the current BrowserWindow has a tabbingIdentifier
  [<Emit "$0.on('new-window-for-tab',$1)">] abstract onNewWindowForTab: listener: (Event -> unit) -> App
  [<Emit "$0.once('new-window-for-tab',$1)">] abstract onceNewWindowForTab: listener: (Event -> unit) -> App
  [<Emit "$0.addListener('new-window-for-tab',$1)">] abstract addListenerNewWindowForTab: listener: (Event -> unit) -> App
  [<Emit "$0.removeListener('new-window-for-tab',$1)">] abstract removeListenerNewWindowForTab: listener: (Event -> unit) -> App
  /// Emitted when the user wants to open a file with the application. The open-file
  /// event is usually emitted when the application is already open and the OS wants
  /// to reuse the application to open the file. open-file is also emitted when a file
  /// is dropped onto the dock and the application is not yet running. Make sure to
  /// listen for the open-file event very early in your application startup to handle
  /// this case (even before the ready event is emitted). You should call
  /// event.preventDefault() if you want to handle this event. On Windows, you have to
  /// parse process.argv (in the main process) to get the filepath.
  [<Emit "$0.on('open-file',$1)">] abstract onOpenFile: listener: (Event -> string -> unit) -> App
  [<Emit "$0.once('open-file',$1)">] abstract onceOpenFile: listener: (Event -> string -> unit) -> App
  [<Emit "$0.addListener('open-file',$1)">] abstract addListenerOpenFile: listener: (Event -> string -> unit) -> App
  [<Emit "$0.removeListener('open-file',$1)">] abstract removeListenerOpenFile: listener: (Event -> string -> unit) -> App
  /// Emitted when the user wants to open a URL with the application. Your
  /// application's Info.plist file must define the url scheme within the
  /// CFBundleURLTypes key, and set NSPrincipalClass to AtomApplication. You should
  /// call event.preventDefault() if you want to handle this event.
  [<Emit "$0.on('open-url',$1)">] abstract onOpenUrl: listener: (Event -> string -> unit) -> App
  [<Emit "$0.once('open-url',$1)">] abstract onceOpenUrl: listener: (Event -> string -> unit) -> App
  [<Emit "$0.addListener('open-url',$1)">] abstract addListenerOpenUrl: listener: (Event -> string -> unit) -> App
  [<Emit "$0.removeListener('open-url',$1)">] abstract removeListenerOpenUrl: listener: (Event -> string -> unit) -> App
  /// Emitted when the application is quitting. Note: On Windows, this event will not
  /// be emitted if the app is closed due to a shutdown/restart of the system or a
  /// user logout.
  [<Emit "$0.on('quit',$1)">] abstract onQuit: listener: (Event -> int -> unit) -> App
  [<Emit "$0.once('quit',$1)">] abstract onceQuit: listener: (Event -> int -> unit) -> App
  [<Emit "$0.addListener('quit',$1)">] abstract addListenerQuit: listener: (Event -> int -> unit) -> App
  [<Emit "$0.removeListener('quit',$1)">] abstract removeListenerQuit: listener: (Event -> int -> unit) -> App
  /// Emitted when Electron has finished initializing. On macOS, launchInfo holds the
  /// userInfo of the NSUserNotification that was used to open the application, if it
  /// was launched from Notification Center. You can call app.isReady() to check if
  /// this event has already fired.
  [<Emit "$0.on('ready',$1)">] abstract onReady: listener: (obj option -> unit) -> App
  [<Emit "$0.once('ready',$1)">] abstract onceReady: listener: (obj option -> unit) -> App
  [<Emit "$0.addListener('ready',$1)">] abstract addListenerReady: listener: (obj option -> unit) -> App
  [<Emit "$0.removeListener('ready',$1)">] abstract removeListenerReady: listener: (obj option -> unit) -> App
  /// Emitted when remote.getBuiltin() is called in the renderer process of
  /// webContents. Calling event.preventDefault() will prevent the module from being
  /// returned. Custom value can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-get-builtin',$1)">] abstract onRemoteGetBuiltin: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  [<Emit "$0.once('remote-get-builtin',$1)">] abstract onceRemoteGetBuiltin: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  [<Emit "$0.addListener('remote-get-builtin',$1)">] abstract addListenerRemoteGetBuiltin: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  [<Emit "$0.removeListener('remote-get-builtin',$1)">] abstract removeListenerRemoteGetBuiltin: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  /// Emitted when remote.getCurrentWebContents() is called in the renderer process of
  /// webContents. Calling event.preventDefault() will prevent the object from being
  /// returned. Custom value can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-get-current-web-contents',$1)">] abstract onRemoteGetCurrentWebContents: listener: (ReturnValueEvent -> WebContents -> unit) -> App
  [<Emit "$0.once('remote-get-current-web-contents',$1)">] abstract onceRemoteGetCurrentWebContents: listener: (ReturnValueEvent -> WebContents -> unit) -> App
  [<Emit "$0.addListener('remote-get-current-web-contents',$1)">] abstract addListenerRemoteGetCurrentWebContents: listener: (ReturnValueEvent -> WebContents -> unit) -> App
  [<Emit "$0.removeListener('remote-get-current-web-contents',$1)">] abstract removeListenerRemoteGetCurrentWebContents: listener: (ReturnValueEvent -> WebContents -> unit) -> App
  /// Emitted when remote.getCurrentWindow() is called in the renderer process of
  /// webContents. Calling event.preventDefault() will prevent the object from being
  /// returned. Custom value can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-get-current-window',$1)">] abstract onRemoteGetCurrentWindow: listener: (ReturnValueEvent -> WebContents -> unit) -> App
  [<Emit "$0.once('remote-get-current-window',$1)">] abstract onceRemoteGetCurrentWindow: listener: (ReturnValueEvent -> WebContents -> unit) -> App
  [<Emit "$0.addListener('remote-get-current-window',$1)">] abstract addListenerRemoteGetCurrentWindow: listener: (ReturnValueEvent -> WebContents -> unit) -> App
  [<Emit "$0.removeListener('remote-get-current-window',$1)">] abstract removeListenerRemoteGetCurrentWindow: listener: (ReturnValueEvent -> WebContents -> unit) -> App
  /// Emitted when remote.getGlobal() is called in the renderer process of
  /// webContents. Calling event.preventDefault() will prevent the global from being
  /// returned. Custom value can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-get-global',$1)">] abstract onRemoteGetGlobal: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  [<Emit "$0.once('remote-get-global',$1)">] abstract onceRemoteGetGlobal: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  [<Emit "$0.addListener('remote-get-global',$1)">] abstract addListenerRemoteGetGlobal: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  [<Emit "$0.removeListener('remote-get-global',$1)">] abstract removeListenerRemoteGetGlobal: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  /// Emitted when <webview>.getWebContents() is called in the renderer process of
  /// webContents. Calling event.preventDefault() will prevent the object from being
  /// returned. Custom value can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-get-guest-web-contents',$1)">] abstract onRemoteGetGuestWebContents: listener: (ReturnValueEvent -> WebContents -> WebContents -> unit) -> App
  [<Emit "$0.once('remote-get-guest-web-contents',$1)">] abstract onceRemoteGetGuestWebContents: listener: (ReturnValueEvent -> WebContents -> WebContents -> unit) -> App
  [<Emit "$0.addListener('remote-get-guest-web-contents',$1)">] abstract addListenerRemoteGetGuestWebContents: listener: (ReturnValueEvent -> WebContents -> WebContents -> unit) -> App
  [<Emit "$0.removeListener('remote-get-guest-web-contents',$1)">] abstract removeListenerRemoteGetGuestWebContents: listener: (ReturnValueEvent -> WebContents -> WebContents -> unit) -> App
  /// Emitted when remote.require() is called in the renderer process of webContents.
  /// Calling event.preventDefault() will prevent the module from being returned.
  /// Custom value can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-require',$1)">] abstract onRemoteRequire: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  [<Emit "$0.once('remote-require',$1)">] abstract onceRemoteRequire: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  [<Emit "$0.addListener('remote-require',$1)">] abstract addListenerRemoteRequire: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  [<Emit "$0.removeListener('remote-require',$1)">] abstract removeListenerRemoteRequire: listener: (ReturnValueEvent -> WebContents -> string -> unit) -> App
  /// This event will be emitted inside the primary instance of your application when
  /// a second instance has been executed and calls app.requestSingleInstanceLock().
  /// argv is an Array of the second instance's command line arguments, and
  /// workingDirectory is its current working directory. Usually applications respond
  /// to this by making their primary window focused and non-minimized. This event is
  /// guaranteed to be emitted after the ready event of app gets emitted. Note: Extra
  /// command line arguments might be added by Chromium, such as
  /// --original-process-start-time.
  [<Emit "$0.on('second-instance',$1)">] abstract onSecondInstance: listener: (Event -> string [] -> string -> unit) -> App
  [<Emit "$0.once('second-instance',$1)">] abstract onceSecondInstance: listener: (Event -> string [] -> string -> unit) -> App
  [<Emit "$0.addListener('second-instance',$1)">] abstract addListenerSecondInstance: listener: (Event -> string [] -> string -> unit) -> App
  [<Emit "$0.removeListener('second-instance',$1)">] abstract removeListenerSecondInstance: listener: (Event -> string [] -> string -> unit) -> App
  /// Emitted when a client certificate is requested. The url corresponds to the
  /// navigation entry requesting the client certificate and callback can be called
  /// with an entry filtered from the list. Using event.preventDefault() prevents the
  /// application from using the first certificate from the store.
  [<Emit "$0.on('select-client-certificate',$1)">] abstract onSelectClientCertificate: listener: (Event -> WebContents -> string -> Certificate [] -> (Certificate -> unit) -> unit) -> App
  [<Emit "$0.once('select-client-certificate',$1)">] abstract onceSelectClientCertificate: listener: (Event -> WebContents -> string -> Certificate [] -> (Certificate -> unit) -> unit) -> App
  [<Emit "$0.addListener('select-client-certificate',$1)">] abstract addListenerSelectClientCertificate: listener: (Event -> WebContents -> string -> Certificate [] -> (Certificate -> unit) -> unit) -> App
  [<Emit "$0.removeListener('select-client-certificate',$1)">] abstract removeListenerSelectClientCertificate: listener: (Event -> WebContents -> string -> Certificate [] -> (Certificate -> unit) -> unit) -> App
  /// Emitted when Electron has created a new session.
  [<Emit "$0.on('session-created',$1)">] abstract onSessionCreated: listener: (Session -> unit) -> App
  [<Emit "$0.once('session-created',$1)">] abstract onceSessionCreated: listener: (Session -> unit) -> App
  [<Emit "$0.addListener('session-created',$1)">] abstract addListenerSessionCreated: listener: (Session -> unit) -> App
  [<Emit "$0.removeListener('session-created',$1)">] abstract removeListenerSessionCreated: listener: (Session -> unit) -> App
  /// Emitted when Handoff is about to be resumed on another device. If you need to
  /// update the state to be transferred, you should call event.preventDefault()
  /// immediately, construct a new userInfo dictionary and call
  /// app.updateCurrentActiviy() in a timely manner. Otherwise, the operation will
  /// fail and continue-activity-error will be called.
  [<Emit "$0.on('update-activity-state',$1)">] abstract onUpdateActivityState: listener: (Event -> string -> obj option -> unit) -> App
  [<Emit "$0.once('update-activity-state',$1)">] abstract onceUpdateActivityState: listener: (Event -> string -> obj option -> unit) -> App
  [<Emit "$0.addListener('update-activity-state',$1)">] abstract addListenerUpdateActivityState: listener: (Event -> string -> obj option -> unit) -> App
  [<Emit "$0.removeListener('update-activity-state',$1)">] abstract removeListenerUpdateActivityState: listener: (Event -> string -> obj option -> unit) -> App
  /// Emitted when a new webContents is created.
  [<Emit "$0.on('web-contents-created',$1)">] abstract onWebContentsCreated: listener: (Event -> WebContents -> unit) -> App
  [<Emit "$0.once('web-contents-created',$1)">] abstract onceWebContentsCreated: listener: (Event -> WebContents -> unit) -> App
  [<Emit "$0.addListener('web-contents-created',$1)">] abstract addListenerWebContentsCreated: listener: (Event -> WebContents -> unit) -> App
  [<Emit "$0.removeListener('web-contents-created',$1)">] abstract removeListenerWebContentsCreated: listener: (Event -> WebContents -> unit) -> App
  /// Emitted during Handoff before an activity from a different device wants to be
  /// resumed. You should call event.preventDefault() if you want to handle this
  /// event.
  [<Emit "$0.on('will-continue-activity',$1)">] abstract onWillContinueActivity: listener: (Event -> string -> unit) -> App
  [<Emit "$0.once('will-continue-activity',$1)">] abstract onceWillContinueActivity: listener: (Event -> string -> unit) -> App
  [<Emit "$0.addListener('will-continue-activity',$1)">] abstract addListenerWillContinueActivity: listener: (Event -> string -> unit) -> App
  [<Emit "$0.removeListener('will-continue-activity',$1)">] abstract removeListenerWillContinueActivity: listener: (Event -> string -> unit) -> App
  /// Emitted when the application has finished basic startup. On Windows and Linux,
  /// the will-finish-launching event is the same as the ready event; on macOS, this
  /// event represents the applicationWillFinishLaunching notification of
  /// NSApplication. You would usually set up listeners for the open-file and open-url
  /// events here, and start the crash reporter and auto updater. In most cases, you
  /// should do everything in the ready event handler.
  [<Emit "$0.on('will-finish-launching',$1)">] abstract onWillFinishLaunching: listener: (Event -> unit) -> App
  [<Emit "$0.once('will-finish-launching',$1)">] abstract onceWillFinishLaunching: listener: (Event -> unit) -> App
  [<Emit "$0.addListener('will-finish-launching',$1)">] abstract addListenerWillFinishLaunching: listener: (Event -> unit) -> App
  [<Emit "$0.removeListener('will-finish-launching',$1)">] abstract removeListenerWillFinishLaunching: listener: (Event -> unit) -> App
  /// Emitted when all windows have been closed and the application will quit. Calling
  /// event.preventDefault() will prevent the default behaviour, which is terminating
  /// the application. See the description of the window-all-closed event for the
  /// differences between the will-quit and window-all-closed events. Note: On
  /// Windows, this event will not be emitted if the app is closed due to a
  /// shutdown/restart of the system or a user logout.
  [<Emit "$0.on('will-quit',$1)">] abstract onWillQuit: listener: (Event -> unit) -> App
  [<Emit "$0.once('will-quit',$1)">] abstract onceWillQuit: listener: (Event -> unit) -> App
  [<Emit "$0.addListener('will-quit',$1)">] abstract addListenerWillQuit: listener: (Event -> unit) -> App
  [<Emit "$0.removeListener('will-quit',$1)">] abstract removeListenerWillQuit: listener: (Event -> unit) -> App
  /// Emitted when all windows have been closed. If you do not subscribe to this event
  /// and all windows are closed, the default behavior is to quit the app; however, if
  /// you subscribe, you control whether the app quits or not. If the user pressed Cmd
  /// + Q, or the developer called app.quit(), Electron will first try to close all
  /// the windows and then emit the will-quit event, and in this case the
  /// window-all-closed event would not be emitted.
  [<Emit "$0.on('window-all-closed',$1)">] abstract onWindowAllClosed: listener: (Event -> unit) -> App
  [<Emit "$0.once('window-all-closed',$1)">] abstract onceWindowAllClosed: listener: (Event -> unit) -> App
  [<Emit "$0.addListener('window-all-closed',$1)">] abstract addListenerWindowAllClosed: listener: (Event -> unit) -> App
  [<Emit "$0.removeListener('window-all-closed',$1)">] abstract removeListenerWindowAllClosed: listener: (Event -> unit) -> App
  /// Adds path to the recent documents list. This list is managed by the OS. On
  /// Windows, you can visit the list from the task bar, and on macOS, you can visit
  /// it from dock menu.
  abstract addRecentDocument: path: string -> unit
  /// Clears the recent documents list.
  abstract clearRecentDocuments: unit -> unit
  /// By default, Chromium disables 3D APIs (e.g. WebGL) until restart on a per domain
  /// basis if the GPU processes crashes too frequently. This (Event -> unit) disables that
  /// behaviour. This method can only be called before app is ready.
  abstract disableDomainBlockingFor3DAPIs: unit -> unit
  /// Disables hardware acceleration for current app. This method can only be called
  /// before app is ready.
  abstract disableHardwareAcceleration: unit -> unit
  /// Enables full sandbox mode on the app. This method can only be called before app
  /// is ready.
  abstract enableSandbox: unit -> unit
  /// Exits immediately with exitCode. exitCode defaults to 0. All windows will be
  /// closed immediately without asking the user, and the before-quit and will-quit
  /// events will not be emitted.
  abstract exit: ?exitCode: int -> unit
  /// On Linux, focuses on the first visible window. On macOS, makes the application
  /// the active app. On Windows, focuses on the application's first window.
  abstract focus: unit -> unit
  abstract getAppMetrics: unit -> ProcessMetric []
  abstract getAppPath: unit -> string
  abstract getBadgeCount: unit -> int
  abstract getCurrentActivityType: unit -> string
  /// Fetches a path's associated icon. On Windows, there a 2 kinds of icons: On Linux
  /// and macOS, icons depend on the application associated with file mime type.
  /// Deprecated Soon
  abstract getFileIcon: path: string * callback: (Error -> NativeImage -> unit) -> unit
  /// Fetches a path's associated icon. On Windows, there a 2 kinds of icons: On Linux
  /// and macOS, icons depend on the application associated with file mime type.
  /// Deprecated Soon
  abstract getFileIcon: path: string * options: FileIconOptions * callback: (Error -> NativeImage -> unit) -> unit
  /// Fetches a path's associated icon. On Windows, there a 2 kinds of icons: On Linux
  /// and macOS, icons depend on the application associated with file mime type.
  abstract getFileIcon: path: string * ?options: FileIconOptions -> Promise<NativeImage>
  abstract getGPUFeatureStatus: unit -> GPUFeatureStatus
  /// For infoType equal to complete: Promise is fulfilled with Object containing all
  /// the GPU Information as in chromium's GPUInfo object. This includes the version
  /// and driver information that's shown on chrome://gpu page. For infoType equal to
  /// basic: Promise is fulfilled with Object containing fewer attributes than when
  /// requested with complete. Here's an example of basic response: Using basic should
  /// be preferred if only basic information like vendorId or driverId is needed.
  abstract getGPUInfo: infoType: GpuInfoType -> Promise<obj>
  abstract getJumpListSettings: unit -> JumpListSettings
  /// To set the locale, you'll want to use a command line switch at app startup,
  /// which may be found here. Note: When distributing your packaged app, you have to
  /// also ship the locales folder. Note: On Windows, you have to call it after the
  /// ready events gets emitted.
  abstract getLocale: unit -> string
  /// Note: When unable to detect locale country code, it returns empty string.
  abstract getLocaleCountryCode: unit -> string
  /// If you provided path and args options to app.setLoginItemSettings, then you need
  /// to pass the same arguments here for openAtLogin to be set correctly.
  abstract getLoginItemSettings: ?options: GetLoginItemSettingsOptions -> LoginItemSettings
  /// Usually the name field of package.json is a short lowercased name, according to
  /// the npm modules spec. You should usually also specify a productName field, which
  /// is your application's full capitalized name, and which will be preferred over
  /// name by Electron.
  abstract getName: unit -> string
  /// You can request the following paths by the name:
  abstract getPath: name: AppPathName -> string
  abstract getVersion: unit -> string
  /// This method returns whether or not this instance of your app is currently
  /// holding the single instance lock.  You can request the lock with
  /// app.requestSingleInstanceLock() and release with app.releaseSingleInstanceLock()
  abstract hasSingleInstanceLock: unit -> bool
  /// Hides all application windows without minimizing them.
  abstract hide: unit -> unit
  /// Imports the certificate in pkcs12 format into the platform certificate store.
  /// callback is called with the result of import operation, a value of 0 indicates
  /// success while any other value indicates failure according to Chromium
  /// net_error_list.
  abstract importCertificate: options: ImportCertificateOptions * callback: (int -> unit) -> unit
  /// Invalidates the current Handoff user activity.
  abstract invalidateCurrentActivity: ``type``: string -> unit
  abstract isAccessibilitySupportEnabled: unit -> bool
  /// This method checks if the current executable is the default handler for a
  /// protocol (aka URI scheme). If so, it will return true. Otherwise, it will return
  /// false. Note: On macOS, you can use this method to check if the app has been
  /// registered as the default protocol handler for a protocol. You can also verify
  /// this by checking ~/Library/Preferences/com.apple.LaunchServices.plist on the
  /// macOS machine. Please refer to Apple's documentation for details. The API uses
  /// the Windows Registry and LSCopyDefaultHandlerForURLScheme internally.
  abstract isDefaultProtocolClient: protocol: string * ?path: string * ?args: string [] -> bool
  abstract isInApplicationsFolder: unit -> bool
  abstract isReady: unit -> bool
  abstract isUnityRunning: unit -> bool
  /// No confirmation dialog will be presented by default. If you wish to allow the
  /// user to confirm the operation, you may do so using the dialog API. NOTE: This
  /// method throws errors if anything other than the user causes the move to fail.
  /// For instance if the user cancels the authorization dialog, this method returns
  /// false. If we fail to perform the copy, then this method will throw an error. The
  /// message in the error should be informative and tell you exactly what went wrong
  abstract moveToApplicationsFolder: unit -> bool
  /// Try to close all windows. The before-quit event will be emitted first. If all
  /// windows are successfully closed, the will-quit event will be emitted and by
  /// default the application will terminate. This method guarantees that all
  /// beforeunload and unload event handlers are correctly executed. It is possible
  /// that a window cancels the quitting by returning false in the beforeunload event
  /// handler.
  abstract quit: unit -> unit
  /// Relaunches the app when current instance exits. By default, the new instance
  /// will use the same working directory and command line arguments with current
  /// instance. When args is specified, the args will be passed as command line
  /// arguments instead. When execPath is specified, the execPath will be executed for
  /// relaunch instead of current app. Note that this method does not quit the app
  /// when executed, you have to call app.quit or app.exit after calling app.relaunch
  /// to make the app restart. When app.relaunch is called for multiple times,
  /// multiple instances will be started after current instance exited. An example of
  /// restarting current instance immediately and adding a new command line argument
  /// to the new instance:
  abstract relaunch: ?options: RelaunchOptions -> unit
  /// Releases all locks that were created by requestSingleInstanceLock. This will
  /// allow multiple instances of the application to once again run side by side.
  abstract releaseSingleInstanceLock: unit -> unit
  /// This method checks if the current executable as the default handler for a
  /// protocol (aka URI scheme). If so, it will remove the app as the default handler.
  abstract removeAsDefaultProtocolClient: protocol: string * ?path: string * ?args: string [] -> bool
  /// This method makes your application a Single Instance Application - instead of
  /// allowing multiple instances of your app to run, this will ensure that only a
  /// single instance of your app is running, and other instances signal this instance
  /// and exit. The return value of this method indicates whether or not this instance
  /// of your application successfully obtained the lock.  If it failed to obtain the
  /// lock, you can assume that another instance of your application is already
  /// running with the lock and exit immediately. I.e. This method returns true if
  /// your process is the primary instance of your application and your app should
  /// continue loading.  It returns false if your process should immediately quit as
  /// it has sent its parameters to another instance that has already acquired the
  /// lock. On macOS, the system enforces single instance automatically when users try
  /// to open a second instance of your app in Finder, and the open-file and open-url
  /// events will be emitted for that. However when users start your app in command
  /// line, the system's single instance mechanism will be bypassed, and you have to
  /// use this method to ensure single instance. An example of activating the window
  /// of primary instance when a second instance starts:
  abstract requestSingleInstanceLock: unit -> bool
  /// Set the about panel options. This will override the values defined in the app's
  /// .plist file on MacOS. See the Apple docs for more details. On Linux, values must
  /// be set in order to be shown; there are no defaults.
  abstract setAboutPanelOptions: options: AboutPanelOptions -> unit
  /// Manually enables Chrome's accessibility support, allowing to expose
  /// accessibility switch to users in application settings. See Chromium's
  /// accessibility docs for more details. Disabled by default. This API must be
  /// called after the ready event is emitted. Note: Rendering accessibility tree can
  /// significantly affect the performance of your app. It should not be enabled by
  /// default.
  abstract setAccessibilitySupportEnabled: enabled: bool -> unit
  /// Changes the Application User Model ID to id.
  abstract setAppUserModelId: id: string -> unit
  /// This method sets the current executable as the default handler for a protocol
  /// (aka URI scheme). It allows you to integrate your app deeper into the operating
  ///  Once registered, all links with your-protocol:// will be opened with the
  /// current executable. The whole link, including protocol, will be passed to your
  /// application as a parameter. On Windows, you can provide optional parameters
  /// path, the path to your executable, and args, an array of arguments to be passed
  /// to your executable when it launches. Note: On macOS, you can only register
  /// protocols that have been added to your app's info.plist, which can not be
  /// modified at runtime. You can however change the file with a simple text editor
  /// or script during build time. Please refer to Apple's documentation for details.
  /// The API uses the Windows Registry and LSSetDefaultHandlerForURLScheme
  /// internally.
  abstract setAsDefaultProtocolClient: protocol: string * ?path: string * ?args: string [] -> bool
  /// Sets the counter badge for current app. Setting the count to 0 will hide the
  /// badge. On macOS, it shows on the dock icon. On Linux, it only works for Unity
  /// launcher. Note: Unity launcher requires the existence of a .desktop file to
  /// work, for more information please read Desktop Environment Integration.
  abstract setBadgeCount: count: int -> bool
  /// Sets or removes a custom Jump List for the application, and returns one of the
  /// following strings: If categories is null the previously set custom Jump List (if
  /// any) will be replaced by the standard Jump List for the app (managed by
  /// Windows). Note: If a JumpListCategory object has neither the type nor the name
  /// property set then its type is assumed to be tasks. If the name property is set
  /// but the type property is omitted then the type is assumed to be custom. Note:
  /// Users can remove items from custom categories, and Windows will not allow a
  /// removed item to be added back into a custom category until after the next
  /// successful call to app.setJumpList(categories). Any attempt to re-add a removed
  /// item to a custom category earlier than that will result in the entire custom
  /// category being omitted from the Jump List. The list of removed items can be
  /// obtained using app.getJumpListSettings(). Here's a very simple example of
  /// creating a custom Jump List:
  abstract setJumpList: categories: JumpListCategory [] -> unit
  /// Set the app's login item settings. To work with Electron's autoUpdater on
  /// Windows, which uses Squirrel, you'll want to set the launch path to Update.exe,
  /// and pass arguments that specify your application name. For example:
  abstract setLoginItemSettings: settings: SetLoginItemSettings -> unit
  /// Overrides the current application's name.
  abstract setName: name: string -> unit
  /// Overrides the path to a special directory or file associated with name. If the
  /// path specifies a directory that does not exist, the directory will be created by
  /// this method. On failure an Error is thrown. You can only override paths of a
  /// name defined in app.getPath. By default, web pages' cookies and caches will be
  /// stored under the userData directory. If you want to change this location, you
  /// have to override the userData path before the ready event of the app module is
  /// emitted.
  abstract setPath: name: AppPathName * path: string -> unit
  /// Creates an NSUserActivity and sets it as the current activity. The activity is
  /// eligible for Handoff to another device afterward.
  abstract setUserActivity: ``type``: string * userInfo: obj option * ?webpageURL: string -> unit
  /// Adds tasks to the Tasks category of the JumpList on Windows. tasks is an array
  /// of Task objects. Note: If you'd like to customize the Jump List even more use
  /// app.setJumpList(categories) instead.
  abstract setUserTasks: tasks: Task [] -> bool
  /// Shows application windows after they were hidden. Does not automatically focus
  /// them.
  abstract show: unit -> unit
  /// Show the app's about panel options. These options can be overridden with
  /// app.setAboutPanelOptions(options).
  abstract showAboutPanel: unit -> unit
  /// Start accessing a security scoped resource. With this method Electron
  /// applications that are packaged for the Mac App Store may reach outside their
  /// sandbox to access files chosen by the user. See Apple's documentation for a
  /// description of how this system works.
  abstract startAccessingSecurityScopedResource: bookmarkData: string -> (Event -> unit)
  /// Updates the current activity if its type matches type, merging the entries from
  /// userInfo into its current userInfo dictionary.
  abstract updateCurrentActivity: ``type``: string * userInfo: obj option -> unit
  abstract whenReady: unit -> Promise<unit>
  abstract commandLine: CommandLine with get, set
  abstract dock: Dock with get, set
  /// A Boolean property that returns  true if the app is packaged, false otherwise.
  /// For many apps, this property can be used to distinguish development and
  /// production environments.
  abstract isPackaged: bool with get, set

type AutoUpdater =
  inherit EventEmitter<AutoUpdater>
  /// This event is emitted after a user calls quitAndInstall(). When this API is
  /// called, the before-quit event is not emitted before all windows are closed. As a
  /// result you should listen to this event if you wish to perform actions before the
  /// windows are closed while a process is quitting, as well as listening to
  /// before-quit.
  [<Emit "$0.on('before-quit-for-update',$1)">] abstract onBeforeQuitForUpdate: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.once('before-quit-for-update',$1)">] abstract onceBeforeQuitForUpdate: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.addListener('before-quit-for-update',$1)">] abstract addListenerBeforeQuitForUpdate: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.removeListener('before-quit-for-update',$1)">] abstract removeListenerBeforeQuitForUpdate: listener: (Event -> unit) -> AutoUpdater
  /// Emitted when checking if an update has started.
  [<Emit "$0.on('checking-for-update',$1)">] abstract onCheckingForUpdate: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.once('checking-for-update',$1)">] abstract onceCheckingForUpdate: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.addListener('checking-for-update',$1)">] abstract addListenerCheckingForUpdate: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.removeListener('checking-for-update',$1)">] abstract removeListenerCheckingForUpdate: listener: (Event -> unit) -> AutoUpdater
  /// Emitted when there is an error while updating.
  [<Emit "$0.on('error',$1)">] abstract onError: listener: (Error -> unit) -> AutoUpdater
  [<Emit "$0.once('error',$1)">] abstract onceError: listener: (Error -> unit) -> AutoUpdater
  [<Emit "$0.addListener('error',$1)">] abstract addListenerError: listener: (Error -> unit) -> AutoUpdater
  [<Emit "$0.removeListener('error',$1)">] abstract removeListenerError: listener: (Error -> unit) -> AutoUpdater
  /// Emitted when there is an available update. The update is downloaded
  /// automatically.
  [<Emit "$0.on('update-available',$1)">] abstract onUpdateAvailable: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.once('update-available',$1)">] abstract onceUpdateAvailable: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.addListener('update-available',$1)">] abstract addListenerUpdateAvailable: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.removeListener('update-available',$1)">] abstract removeListenerUpdateAvailable: listener: (Event -> unit) -> AutoUpdater
  /// Emitted when an update has been downloaded. On Windows only releaseName is
  /// available. Note: It is not strictly necessary to handle this event. A
  /// successfully downloaded update will still be applied the next time the
  /// application starts.
  [<Emit "$0.on('update-downloaded',$1)">] abstract onUpdateDownloaded: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
  [<Emit "$0.once('update-downloaded',$1)">] abstract onceUpdateDownloaded: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
  [<Emit "$0.addListener('update-downloaded',$1)">] abstract addListenerUpdateDownloaded: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
  [<Emit "$0.removeListener('update-downloaded',$1)">] abstract removeListenerUpdateDownloaded: listener: (Event -> string -> string -> DateTime -> string -> unit) -> AutoUpdater
  /// Emitted when there is no available update.
  [<Emit "$0.on('update-not-available',$1)">] abstract onUpdateNotAvailable: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.once('update-not-available',$1)">] abstract onceUpdateNotAvailable: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.addListener('update-not-available',$1)">] abstract addListenerUpdateNotAvailable: listener: (Event -> unit) -> AutoUpdater
  [<Emit "$0.removeListener('update-not-available',$1)">] abstract removeListenerUpdateNotAvailable: listener: (Event -> unit) -> AutoUpdater
  /// Asks the server whether there is an update. You must call setFeedURL before
  /// using this API.
  abstract checkForUpdates: unit -> unit
  abstract getFeedURL: unit -> string
  /// Restarts the app and installs the update after it has been downloaded. It should
  /// only be called after update-downloaded has been emitted. Under the hood calling
  /// autoUpdater.quitAndInstall() will close all application windows first, and
  /// automatically call app.quit() after all windows have been closed. Note: It is
  /// not strictly necessary to call this (Event -> unit) to apply an update, as a
  /// successfully downloaded update will always be applied the next time the
  /// application starts.
  abstract quitAndInstall: unit -> unit
  /// Sets the url and initialize the auto updater.
  abstract setFeedURL: options: AutoOpdateFeedOptions -> unit

type BluetoothDevice =
  abstract deviceId: string with get, set
  abstract deviceName: string with get, set

type BrowserView =
  inherit EventEmitter<BrowserView>
  /// Force closing the view, the unload and beforeunload events won't be emitted for
  /// the web page. After you're done with a view, call this (Event -> unit) in order to free
  /// memory and other resources as soon as possible.
  abstract destroy: unit -> unit
  abstract isDestroyed: unit -> bool
  abstract setAutoResize: options: AutoResizeOptions -> unit
  abstract setBackgroundColor: color: string -> unit
  /// Resizes and moves the view to the supplied bounds relative to the window.
  abstract setBounds: bounds: Rectangle -> unit
  abstract id: int with get, set
  abstract webContents: WebContents with get, set

type BrowserViewStatic =
  [<EmitConstructor>] abstract Create: ?options: BrowserViewOptions -> BrowserView
  abstract fromId: id: int -> BrowserView
  abstract fromWebContents: webContents: WebContents -> BrowserView option
  abstract getAllViews: unit -> BrowserView []

[<StringEnum; RequireQualifiedAccess>]
type AlwaysOnTopLevel =
  | Normal
  | Floating
  | [<CompiledName "torn-off-menu">] TornOffMenu
  | [<CompiledName "modal-panel">] ModalPanel
  | [<CompiledName "main-menu">] MainMenu
  | Status
  | [<CompiledName "pop-up-menu">] PopUpMenu
  | [<CompiledName "screen-saver">] ScreenSaver

[<StringEnum; RequireQualifiedAccess>]
type VibrancyType =
  | [<CompiledName("appearance-based")>] AppearanceBased
  | Light
  | Dark
  | [<CompiledName("titlebar")>] TitleBar
  | Selection
  | Menu
  | Popover
  | Sidebar
  | [<CompiledName("medium-light")>] MediumLight
  | [<CompiledName("ultra-dark")>] UltraDark

type BrowserWindow =
  inherit EventEmitter<BrowserWindow>
  /// Emitted when the window is set or unset to show always on top of other windows.
  [<Emit "$0.on('always-on-top-changed',$1)">] abstract onAlwaysOnTopChanged: listener: (Event -> bool -> unit) -> BrowserWindow
  [<Emit "$0.once('always-on-top-changed',$1)">] abstract onceAlwaysOnTopChanged: listener: (Event -> bool -> unit) -> BrowserWindow
  [<Emit "$0.addListener('always-on-top-changed',$1)">] abstract addListenerAlwaysOnTopChanged: listener: (Event -> bool -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('always-on-top-changed',$1)">] abstract removeListenerAlwaysOnTopChanged: listener: (Event -> bool -> unit) -> BrowserWindow
  /// Emitted when an App Command is invoked. These are typically related to keyboard
  /// media keys or browser commands, as well as the "Back" button built into some
  /// mice on Windows. Commands are lowercased, underscores are replaced with hyphens,
  /// and the APPCOMMAND_ prefix is stripped off. e.g. APPCOMMAND_BROWSER_BACKWARD is
  /// emitted as browser-backward. The following app commands are explictly supported
  /// on Linux:
  [<Emit "$0.on('app-command',$1)">] abstract onAppCommand: listener: (Event -> string -> unit) -> BrowserWindow
  [<Emit "$0.once('app-command',$1)">] abstract onceAppCommand: listener: (Event -> string -> unit) -> BrowserWindow
  [<Emit "$0.addListener('app-command',$1)">] abstract addListenerAppCommand: listener: (Event -> string -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('app-command',$1)">] abstract removeListenerAppCommand: listener: (Event -> string -> unit) -> BrowserWindow
  /// Emitted when the window loses focus.
  [<Emit "$0.on('blur',$1)">] abstract onBlur: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('blur',$1)">] abstract onceBlur: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('blur',$1)">] abstract addListenerBlur: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('blur',$1)">] abstract removeListenerBlur: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window is going to be closed. It's emitted before the
  /// beforeunload and unload event of the DOM. Calling event.preventDefault() will
  /// cancel the close. Usually you would want to use the beforeunload handler to
  /// decide whether the window should be closed, which will also be called when the
  /// window is reloaded. In Electron, returning any value other than undefined would
  /// cancel the close. For example: Note: There is a subtle difference between the
  /// behaviors of window.onbeforeunload = handler and
  /// window.addEventListener('beforeunload', handler). It is recommended to always
  /// set the event.returnValue explicitly, instead of only returning a value, as the
  /// former works more consistently within Electron.
  [<Emit "$0.on('close',$1)">] abstract onClose: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('close',$1)">] abstract onceClose: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('close',$1)">] abstract addListenerClose: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('close',$1)">] abstract removeListenerClose: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window is closed. After you have received this event you should
  /// remove the reference to the window and avoid using it any more.
  [<Emit "$0.on('closed',$1)">] abstract onClosed: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('closed',$1)">] abstract onceClosed: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('closed',$1)">] abstract addListenerClosed: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('closed',$1)">] abstract removeListenerClosed: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window enters a full-screen state.
  [<Emit "$0.on('enter-full-screen',$1)">] abstract onEnterFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('enter-full-screen',$1)">] abstract onceEnterFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('enter-full-screen',$1)">] abstract addListenerEnterFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('enter-full-screen',$1)">] abstract removeListenerEnterFullScreen: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window enters a full-screen state triggered by HTML API.
  [<Emit "$0.on('enter-html-full-screen',$1)">] abstract onEnterHtmlFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('enter-html-full-screen',$1)">] abstract onceEnterHtmlFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('enter-html-full-screen',$1)">] abstract addListenerEnterHtmlFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('enter-html-full-screen',$1)">] abstract removeListenerEnterHtmlFullScreen: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window gains focus.
  [<Emit "$0.on('focus',$1)">] abstract onFocus: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('focus',$1)">] abstract onceFocus: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('focus',$1)">] abstract addListenerFocus: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('focus',$1)">] abstract removeListenerFocus: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window is hidden.
  [<Emit "$0.on('hide',$1)">] abstract onHide: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('hide',$1)">] abstract onceHide: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('hide',$1)">] abstract addListenerHide: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('hide',$1)">] abstract removeListenerHide: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window leaves a full-screen state.
  [<Emit "$0.on('leave-full-screen',$1)">] abstract onLeaveFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('leave-full-screen',$1)">] abstract onceLeaveFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('leave-full-screen',$1)">] abstract addListenerLeaveFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('leave-full-screen',$1)">] abstract removeListenerLeaveFullScreen: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window leaves a full-screen state triggered by HTML API.
  [<Emit "$0.on('leave-html-full-screen',$1)">] abstract onLeaveHtmlFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('leave-html-full-screen',$1)">] abstract onceLeaveHtmlFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('leave-html-full-screen',$1)">] abstract addListenerLeaveHtmlFullScreen: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('leave-html-full-screen',$1)">] abstract removeListenerLeaveHtmlFullScreen: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when window is maximized.
  [<Emit "$0.on('maximize',$1)">] abstract onMaximize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('maximize',$1)">] abstract onceMaximize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('maximize',$1)">] abstract addListenerMaximize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('maximize',$1)">] abstract removeListenerMaximize: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window is minimized.
  [<Emit "$0.on('minimize',$1)">] abstract onMinimize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('minimize',$1)">] abstract onceMinimize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('minimize',$1)">] abstract addListenerMinimize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('minimize',$1)">] abstract removeListenerMinimize: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window is being moved to a new position. Note: On macOS this
  /// event is an alias of moved.
  [<Emit "$0.on('move',$1)">] abstract onMove: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('move',$1)">] abstract onceMove: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('move',$1)">] abstract addListenerMove: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('move',$1)">] abstract removeListenerMove: listener: (Event -> unit) -> BrowserWindow
  /// Emitted once when the window is moved to a new position.
  [<Emit "$0.on('moved',$1)">] abstract onMoved: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('moved',$1)">] abstract onceMoved: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('moved',$1)">] abstract addListenerMoved: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('moved',$1)">] abstract removeListenerMoved: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the native new tab button is clicked.
  [<Emit "$0.on('new-window-for-tab',$1)">] abstract onNewWindowForTab: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('new-window-for-tab',$1)">] abstract onceNewWindowForTab: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('new-window-for-tab',$1)">] abstract addListenerNewWindowForTab: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('new-window-for-tab',$1)">] abstract removeListenerNewWindowForTab: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the document changed its title, calling event.preventDefault() will
  /// prevent the native window's title from changing. explicitSet is false when title
  /// is synthesized from file url.
  [<Emit "$0.on('page-title-updated',$1)">] abstract onPageTitleUpdated: listener: (Event -> string -> bool -> unit) -> BrowserWindow
  [<Emit "$0.once('page-title-updated',$1)">] abstract oncePageTitleUpdated: listener: (Event -> string -> bool -> unit) -> BrowserWindow
  [<Emit "$0.addListener('page-title-updated',$1)">] abstract addListenerPageTitleUpdated: listener: (Event -> string -> bool -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('page-title-updated',$1)">] abstract removeListenerPageTitleUpdated: listener: (Event -> string -> bool -> unit) -> BrowserWindow
  /// Emitted when the web page has been rendered (while not being shown) and window
  /// can be displayed without a visual flash.
  [<Emit "$0.on('ready-to-show',$1)">] abstract onReadyToShow: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('ready-to-show',$1)">] abstract onceReadyToShow: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('ready-to-show',$1)">] abstract addListenerReadyToShow: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('ready-to-show',$1)">] abstract removeListenerReadyToShow: listener: (Event -> unit) -> BrowserWindow
  /// Emitted after the window has been resized.
  [<Emit "$0.on('resize',$1)">] abstract onResize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('resize',$1)">] abstract onceResize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('resize',$1)">] abstract addListenerResize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('resize',$1)">] abstract removeListenerResize: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the unresponsive web page becomes responsive again.
  [<Emit "$0.on('responsive',$1)">] abstract onResponsive: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('responsive',$1)">] abstract onceResponsive: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('responsive',$1)">] abstract addListenerResponsive: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('responsive',$1)">] abstract removeListenerResponsive: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window is restored from a minimized state.
  [<Emit "$0.on('restore',$1)">] abstract onRestore: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('restore',$1)">] abstract onceRestore: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('restore',$1)">] abstract addListenerRestore: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('restore',$1)">] abstract removeListenerRestore: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when scroll wheel event phase has begun.
  [<Emit "$0.on('scroll-touch-begin',$1)">] abstract onScrollTouchBegin: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('scroll-touch-begin',$1)">] abstract onceScrollTouchBegin: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('scroll-touch-begin',$1)">] abstract addListenerScrollTouchBegin: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('scroll-touch-begin',$1)">] abstract removeListenerScrollTouchBegin: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when scroll wheel event phase filed upon reaching the edge of element.
  [<Emit "$0.on('scroll-touch-edge',$1)">] abstract onScrollTouchEdge: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('scroll-touch-edge',$1)">] abstract onceScrollTouchEdge: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('scroll-touch-edge',$1)">] abstract addListenerScrollTouchEdge: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('scroll-touch-edge',$1)">] abstract removeListenerScrollTouchEdge: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when scroll wheel event phase has ended.
  [<Emit "$0.on('scroll-touch-end',$1)">] abstract onScrollTouchEnd: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('scroll-touch-end',$1)">] abstract onceScrollTouchEnd: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('scroll-touch-end',$1)">] abstract addListenerScrollTouchEnd: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('scroll-touch-end',$1)">] abstract removeListenerScrollTouchEnd: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when window session is going to end due to force shutdown or machine
  /// restart or session log off.
  [<Emit "$0.on('session-end',$1)">] abstract onSessionEnd: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('session-end',$1)">] abstract onceSessionEnd: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('session-end',$1)">] abstract addListenerSessionEnd: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('session-end',$1)">] abstract removeListenerSessionEnd: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window opens a sheet.
  [<Emit "$0.on('sheet-begin',$1)">] abstract onSheetBegin: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('sheet-begin',$1)">] abstract onceSheetBegin: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('sheet-begin',$1)">] abstract addListenerSheetBegin: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('sheet-begin',$1)">] abstract removeListenerSheetBegin: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window has closed a sheet.
  [<Emit "$0.on('sheet-end',$1)">] abstract onSheetEnd: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('sheet-end',$1)">] abstract onceSheetEnd: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('sheet-end',$1)">] abstract addListenerSheetEnd: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('sheet-end',$1)">] abstract removeListenerSheetEnd: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the window is shown.
  [<Emit "$0.on('show',$1)">] abstract onShow: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('show',$1)">] abstract onceShow: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('show',$1)">] abstract addListenerShow: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('show',$1)">] abstract removeListenerShow: listener: (Event -> unit) -> BrowserWindow
  /// Emitted on 3-finger swipe. Possible directions are up, right, down, left.
  [<Emit "$0.on('swipe',$1)">] abstract onSwipe: listener: (Event -> string -> unit) -> BrowserWindow
  [<Emit "$0.once('swipe',$1)">] abstract onceSwipe: listener: (Event -> string -> unit) -> BrowserWindow
  [<Emit "$0.addListener('swipe',$1)">] abstract addListenerSwipe: listener: (Event -> string -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('swipe',$1)">] abstract removeListenerSwipe: listener: (Event -> string -> unit) -> BrowserWindow
  /// Emitted when the window exits from a maximized state.
  [<Emit "$0.on('unmaximize',$1)">] abstract onUnmaximize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('unmaximize',$1)">] abstract onceUnmaximize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('unmaximize',$1)">] abstract addListenerUnmaximize: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('unmaximize',$1)">] abstract removeListenerUnmaximize: listener: (Event -> unit) -> BrowserWindow
  /// Emitted when the web page becomes unresponsive.
  [<Emit "$0.on('unresponsive',$1)">] abstract onUnresponsive: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.once('unresponsive',$1)">] abstract onceUnresponsive: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.addListener('unresponsive',$1)">] abstract addListenerUnresponsive: listener: (Event -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('unresponsive',$1)">] abstract removeListenerUnresponsive: listener: (Event -> unit) -> BrowserWindow
  /// Emitted before the window is moved. Calling event.preventDefault() will prevent
  /// the window from being moved. Note that this is only emitted when the window is
  /// being resized manually. Resizing the window with setBounds/setSize will not emit
  /// this event.
  [<Emit "$0.on('will-move',$1)">] abstract onWillMove: listener: (Event -> Rectangle -> unit) -> BrowserWindow
  [<Emit "$0.once('will-move',$1)">] abstract onceWillMove: listener: (Event -> Rectangle -> unit) -> BrowserWindow
  [<Emit "$0.addListener('will-move',$1)">] abstract addListenerWillMove: listener: (Event -> Rectangle -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('will-move',$1)">] abstract removeListenerWillMove: listener: (Event -> Rectangle -> unit) -> BrowserWindow
  /// Emitted before the window is resized. Calling event.preventDefault() will
  /// prevent the window from being resized. Note that this is only emitted when the
  /// window is being resized manually. Resizing the window with setBounds/setSize
  /// will not emit this event.
  [<Emit "$0.on('will-resize',$1)">] abstract onWillResize: listener: (Event -> Rectangle -> unit) -> BrowserWindow
  [<Emit "$0.once('will-resize',$1)">] abstract onceWillResize: listener: (Event -> Rectangle -> unit) -> BrowserWindow
  [<Emit "$0.addListener('will-resize',$1)">] abstract addListenerWillResize: listener: (Event -> Rectangle -> unit) -> BrowserWindow
  [<Emit "$0.removeListener('will-resize',$1)">] abstract removeListenerWillResize: listener: (Event -> Rectangle -> unit) -> BrowserWindow
  /// Replacement API for setBrowserView supporting work with multi browser views.
  abstract addBrowserView: browserView: BrowserView -> unit
  /// Adds a window as a tab on this window, after the tab for the window instance.
  abstract addTabbedWindow: browserWindow: BrowserWindow -> unit
  /// Removes focus from the window.
  abstract blur: unit -> unit
  abstract blurWebView: unit -> unit
  /// Captures a snapshot of the page within rect. Upon completion callback will be
  /// called with callback(image). The image is an instance of NativeImage that stores
  /// data of the snapshot. Omitting rect will capture the whole visible page.
  /// Deprecated Soon
  abstract capturePage: callback: (NativeImage -> unit) -> unit
  /// Captures a snapshot of the page within rect. Omitting rect will capture the
  /// whole visible page.
  abstract capturePage: ?rect: Rectangle -> unit
  /// Captures a snapshot of the page within rect. Upon completion callback will be
  /// called with callback(image). The image is an instance of NativeImage that stores
  /// data of the snapshot. Omitting rect will capture the whole visible page.
  /// Deprecated Soon
  abstract capturePage: rect: Rectangle * callback: (NativeImage -> unit) -> unit
  /// Moves window to the center of the screen.
  abstract center: unit -> unit
  /// Try to close the window. This has the same effect as a user manually clicking
  /// the close button of the window. The web page may cancel the close though. See
  /// the close event.
  abstract close: unit -> unit
  /// Closes the currently open Quick Look panel.
  abstract closeFilePreview: unit -> unit
  /// Force closing the window, the unload and beforeunload event won't be emitted for
  /// the web page, and close event will also not be emitted for this window, but it
  /// guarantees the closed event will be emitted.
  abstract destroy: unit -> unit
  /// Starts or stops flashing the window to attract user's attention.
  abstract flashFrame: flag: bool -> unit
  /// Focuses on the window.
  abstract focus: unit -> unit
  abstract focusOnWebView: unit -> unit
  abstract getBounds: unit -> Rectangle
  abstract getBrowserView: unit -> BrowserView option
  /// Returns array of BrowserView what was an attached with addBrowserView or
  /// setBrowserView. Note: The BrowserView API is currently experimental and may
  /// change or be removed in future Electron releases.
  abstract getBrowserViews: unit -> BrowserView []
  abstract getChildWindows: unit -> BrowserWindow []
  abstract getContentBounds: unit -> Rectangle
  abstract getContentSize: unit -> int * int
  abstract getMaximumSize: unit -> int * int
  abstract getMinimumSize: unit -> int * int
  /// The native type of the handle is HWND on Windows, NSView* on macOS, and Window
  /// (unsigned long) on Linux.
  abstract getNativeWindowHandle: unit -> Buffer
  /// Note: whatever the current state of the window : maximized, minimized or in
  /// fullscreen, this (Event -> unit) always returns the position and size of the window in
  /// normal state. In normal state, getBounds and getNormalBounds returns the same
  /// Rectangle.
  abstract getNormalBounds: unit -> Rectangle
  abstract getOpacity: unit -> float
  abstract getParentWindow: unit -> BrowserWindow
  abstract getPosition: unit -> int * int
  abstract getRepresentedFilename: unit -> string
  abstract getSize: unit -> int * int
  /// Note: The title of the web page can be different from the title of the native
  /// window.
  abstract getTitle: unit -> string
  /// On Windows and Linux always returns true.
  abstract hasShadow: unit -> bool
  /// Hides the window.
  abstract hide: unit -> unit
  /// Hooks a windows message. The callback is called when the message is received in
  /// the WndProc.
  abstract hookWindowMessage: message: int * callback: (Event -> unit) -> unit
  abstract isAlwaysOnTop: unit -> bool
  /// On Linux always returns true.
  abstract isClosable: unit -> bool
  abstract isDestroyed: unit -> bool
  abstract isDocumentEdited: unit -> bool
  abstract isFocused: unit -> bool
  abstract isFullScreen: unit -> bool
  abstract isFullScreenable: unit -> bool
  abstract isKiosk: unit -> bool
  /// On Linux always returns true.
  abstract isMaximizable: unit -> bool
  abstract isMaximized: unit -> bool
  abstract isMenuBarAutoHide: unit -> bool
  abstract isMenuBarVisible: unit -> bool
  /// On Linux always returns true.
  abstract isMinimizable: unit -> bool
  abstract isMinimized: unit -> bool
  abstract isModal: unit -> bool
  /// On Linux always returns true.
  abstract isMovable: unit -> bool
  abstract isNormal: unit -> bool
  abstract isResizable: unit -> bool
  abstract isSimpleFullScreen: unit -> bool
  abstract isVisible: unit -> bool
  /// Note: This API always returns false on Windows.
  abstract isVisibleOnAllWorkspaces: unit -> bool
  abstract isWindowMessageHooked: message: int -> bool
  /// Same as webContents.loadFile, filePath should be a path to an HTML file relative
  /// to the root of your application.  See the webContents docs for more information.
  abstract loadFile: filePath: string * ?options: LoadFileOptions -> Promise<unit>
  /// Same as webContents.loadURL(url[, options]). The url can be a remote address
  /// (e.g. http://) or a path to a local HTML file using the file:// protocol. To
  /// ensure that file URLs are properly formatted, it is recommended to use Node's
  /// url.format method: You can load a URL using a POST request with URL-encoded data
  /// by doing the following:
  abstract loadURL: url: string * ?options: LoadURLOptions -> Promise<unit>
  /// Maximizes the window. This will also show (but not focus) the window if it isn't
  /// being displayed already.
  abstract maximize: unit -> unit
  /// Merges all windows into one window with multiple tabs when native tabs are
  /// enabled and there is more than one open window.
  abstract mergeAllWindows: unit -> unit
  /// Minimizes the window. On some platforms the minimized window will be shown in
  /// the Dock.
  abstract minimize: unit -> unit
  /// Moves the current tab into a new window if native tabs are enabled and there is
  /// more than one tab in the current window.
  abstract moveTabToNewWindow: unit -> unit
  /// Moves window to top(z-order) regardless of focus
  abstract moveTop: unit -> unit
  /// Uses Quick Look to preview a file at a given path.
  abstract previewFile: path: string * ?displayName: string -> unit
  /// Same as webContents.reload.
  abstract reload: unit -> unit
  abstract removeBrowserView: browserView: BrowserView -> unit
  /// Remove the window's menu bar.
  abstract removeMenu: unit -> unit
  /// Restores the window from minimized state to its previous state.
  abstract restore: unit -> unit
  /// Selects the next tab when native tabs are enabled and there are other tabs in
  /// the window.
  abstract selectNextTab: unit -> unit
  /// Selects the previous tab when native tabs are enabled and there are other tabs
  /// in the window.
  abstract selectPreviousTab: unit -> unit
  /// Sets whether the window should show always on top of other windows. After
  /// setting this, the window is still a normal window, not a toolbox window which
  /// can not be focused on.
  abstract setAlwaysOnTop: flag: bool * ?level: AlwaysOnTopLevel * ?relativeLevel: int -> unit
  /// Sets the properties for the window's taskbar button. Note: relaunchCommand and
  /// relaunchDisplayName must always be set together. If one of those properties is
  /// not set, then neither will be used.
  abstract setAppDetails: options: AppDetailsOptions -> unit
  /// This will make a window maintain an aspect ratio. The extra size allows a
  /// developer to have space, specified in pixels, not included within the aspect
  /// ratio calculations. This API already takes into account the difference between a
  /// window's size and its content size. Consider a normal window with an HD video
  /// player and associated controls. Perhaps there are 15 pixels of controls on the
  /// left edge, 25 pixels of controls on the right edge and 50 pixels of controls
  /// below the player. In order to maintain a 16:9 aspect ratio (standard aspect
  /// ratio for HD @1920x1080) within the player itself we would call this (Event -> unit)
  /// with arguments of 16/9 and [ 40, 50 ]. The second argument doesn't care where
  /// the extra width and height are within the content view--only that they exist.
  /// Sum any extra width and height areas you have within the overall content view.
  /// Calling this (Event -> unit) with a value of 0 will remove any previously set aspect
  /// ratios.
  abstract setAspectRatio: aspectRatio: float * extraSize: Size -> unit
  /// Controls whether to hide cursor when typing.
  abstract setAutoHideCursor: autoHide: bool -> unit
  /// Sets whether the window menu bar should hide itself automatically. Once set the
  /// menu bar will only show when users press the single Alt key. If the menu bar is
  /// already visible, calling setAutoHideMenuBar(true) won't hide it immediately.
  abstract setAutoHideMenuBar: hide: bool -> unit
  /// Sets the background color of the window. See Setting backgroundColor.
  abstract setBackgroundColor: backgroundColor: string -> unit
  /// Resizes and moves the window to the supplied bounds. Any properties that are not
  /// supplied will default to their current values.
  abstract setBounds: bounds: Rectangle * ?animate: bool -> unit
  abstract setBrowserView: browserView: BrowserView -> unit
  /// Sets whether the window can be manually closed by user. On Linux does nothing.
  abstract setClosable: closable: bool -> unit
  /// Resizes and moves the window's client area (e.g. the web page) to the supplied
  /// bounds.
  abstract setContentBounds: bounds: Rectangle * ?animate: bool -> unit
  /// Prevents the window contents from being captured by other apps. On macOS it sets
  /// the NSWindow's sharingType to NSWindowSharingNone. On Windows it calls
  /// SetWindowDisplayAffinity with WDA_MONITOR.
  abstract setContentProtection: enable: bool -> unit
  /// Resizes the window's client area (e.g. the web page) to width and height.
  abstract setContentSize: width: int * height: int * ?animate: bool -> unit
  /// Specifies whether the window’s document has been edited, and the icon in title
  /// bar will become gray when set to true.
  abstract setDocumentEdited: edited: bool -> unit
  /// Disable or enable the window.
  abstract setEnabled: enable: bool -> unit
  /// Changes whether the window can be focused.
  abstract setFocusable: focusable: bool -> unit
  /// Sets whether the window should be in fullscreen mode.
  abstract setFullScreen: flag: bool -> unit
  /// Sets whether the maximize/zoom window button toggles fullscreen mode or
  /// maximizes the window.
  abstract setFullScreenable: fullscreenable: bool -> unit
  /// Sets whether the window should have a shadow. On Windows and Linux does nothing.
  abstract setHasShadow: hasShadow: bool -> unit
  /// Changes window icon.
  abstract setIcon: icon: NativeImage -> unit
  /// Makes the window ignore all mouse events. All mouse events happened in this
  /// window will be passed to the window below this window, but if this window has
  /// focus, it will still receive keyboard events.
  abstract setIgnoreMouseEvents: ignore: bool * ?options: IgnoreMouseEventsOptions -> unit
  /// Enters or leaves the kiosk mode.
  abstract setKiosk: flag: bool -> unit
  /// Sets whether the window can be manually maximized by user. On Linux does
  /// nothing.
  abstract setMaximizable: maximizable: bool -> unit
  /// Sets the maximum size of window to width and height.
  abstract setMaximumSize: width: int * height: int -> unit
  /// Sets the menu as the window's menu bar.
  abstract setMenu: menu: Menu option -> unit
  /// Sets whether the menu bar should be visible. If the menu bar is auto-hide, users
  /// can still bring up the menu bar by pressing the single Alt key.
  abstract setMenuBarVisibility: visible: bool -> unit
  /// Sets whether the window can be manually minimized by user. On Linux does
  /// nothing.
  abstract setMinimizable: minimizable: bool -> unit
  /// Sets the minimum size of window to width and height.
  abstract setMinimumSize: width: int * height: int -> unit
  /// Sets whether the window can be moved by user. On Linux does nothing.
  abstract setMovable: movable: bool -> unit
  /// Sets the opacity of the window. On Linux does nothing.
  abstract setOpacity: opacity: float -> unit
  /// Sets a 16 x 16 pixel overlay onto the current taskbar icon, usually used to
  /// convey some sort of application status or to passively notify the user.
  abstract setOverlayIcon: overlay: NativeImage option * description: string -> unit
  /// Sets parent as current window's parent window, passing null will turn current
  /// window into a top-level window.
  abstract setParentWindow: parent: BrowserWindow -> unit
  /// Moves window to x and y.
  abstract setPosition: x: int * y: int * ?animate: bool -> unit
  /// Sets progress value in progress bar. Valid range is [0, 1.0]. Remove progress
  /// bar when progress < 0; Change to indeterminate mode when progress > 1. On Linux
  /// platform, only supports Unity desktop environment, you need to specify the
  /// *.desktop file name to desktopName field in package.json. By default, it will
  /// assume app.getName().desktop. On Windows, a mode can be passed. Accepted values
  /// are none, normal, indeterminate, error, and paused. If you call setProgressBar
  /// without a mode set (but with a value within the valid range), normal will be
  /// assumed.
  abstract setProgressBar: progress: float * ?options: ProgressBarOptions -> unit
  /// Sets the pathname of the file the window represents, and the icon of the file
  /// will show in window's title bar.
  abstract setRepresentedFilename: filename: string -> unit
  /// Sets whether the window can be manually resized by user.
  abstract setResizable: resizable: bool -> unit
  /// Setting a window shape determines the area within the window where the system
  /// permits drawing and user interaction. Outside of the given region, no pixels
  /// will be drawn and no mouse events will be registered. Mouse events outside of
  /// the region will not be received by that window, but will fall through to
  /// whatever is behind the window.
  abstract setShape: rects: Rectangle [] -> unit
  /// Changes the attachment point for sheets on macOS. By default, sheets are
  /// attached just below the window frame, but you may want to display them beneath a
  /// HTML-rendered toolbar. For example:
  abstract setSheetOffset: offsetY: float * ?offsetX: float -> unit
  /// Enters or leaves simple fullscreen mode. Simple fullscreen mode emulates the
  /// native fullscreen behavior found in versions of Mac OS X prior to Lion (10.7).
  abstract setSimpleFullScreen: flag: bool -> unit
  /// Resizes the window to width and height. If width or height are below any set
  /// minimum size constraints the window will snap to its minimum size.
  abstract setSize: width: int * height: int * ?animate: bool -> unit
  /// Makes the window not show in the taskbar.
  abstract setSkipTaskbar: skip: bool -> unit
  /// Add a thumbnail toolbar with a specified set of buttons to the thumbnail image
  /// of a window in a taskbar button layout. Returns a Boolean object indicates
  /// whether the thumbnail has been added successfully. The number of buttons in
  /// thumbnail toolbar should be no greater than 7 due to the limited room. Once you
  /// setup the thumbnail toolbar, the toolbar cannot be removed due to the platform's
  /// limitation. But you can call the API with an empty array to clean the buttons.
  /// The buttons is an array of Button objects: The flags is an array that can
  /// include following Strings:
  abstract setThumbarButtons: buttons: ThumbarButton [] -> bool
  /// Sets the region of the window to show as the thumbnail image displayed when
  /// hovering over the window in the taskbar. You can reset the thumbnail to be the
  /// entire window by specifying an empty region: { x: 0, y: 0, width: 0, height: 0
  /// }.
  abstract setThumbnailClip: region: Rectangle -> unit
  /// Sets the toolTip that is displayed when hovering over the window thumbnail in
  /// the taskbar.
  abstract setThumbnailToolTip: toolTip: string -> unit
  /// Changes the title of native window to title.
  abstract setTitle: title: string -> unit
  /// Sets the touchBar layout for the current window. Specifying null or undefined
  /// clears the touch bar. This method only has an effect if the machine has a touch
  /// bar and is running on macOS 10.12.1+. Note: The TouchBar API is currently
  /// experimental and may change or be removed in future Electron releases.
  abstract setTouchBar: touchBar: TouchBar -> unit
  /// Adds a vibrancy effect to the browser window. Passing null or an empty string
  /// will remove the vibrancy effect on the window.
  abstract setVibrancy: ``type``: VibrancyType -> unit
  /// Sets whether the window should be visible on all workspaces. Note: This API does
  /// nothing on Windows.
  abstract setVisibleOnAllWorkspaces: visible: bool * ?options: VisibleOnAllWorkspacesOptions -> unit
  /// Sets whether the window traffic light buttons should be visible. This cannot be
  /// called when titleBarStyle is set to customButtonsOnHover.
  abstract setWindowButtonVisibility: visible: bool -> unit
  /// Shows and gives focus to the window.
  abstract show: unit -> unit
  /// Same as webContents.showDefinitionForSelection().
  abstract showDefinitionForSelection: unit -> unit
  /// Shows the window but doesn't focus on it.
  abstract showInactive: unit -> unit
  /// Toggles the visibility of the tab bar if native tabs are enabled and there is
  /// only one tab in the current window.
  abstract toggleTabBar: unit -> unit
  /// Unhooks all of the window messages.
  abstract unhookAllWindowMessages: unit -> unit
  /// Unhook the window message.
  abstract unhookWindowMessage: message: int -> unit
  /// Unmaximizes the window.
  abstract unmaximize: unit -> unit
  abstract id: int with get, set
  abstract webContents: WebContents with get, set

type BrowserWindowStatic =
  [<EmitConstructor>] abstract Create: ?options: BrowserWindowOptions -> BrowserWindow
  /// Adds DevTools extension located at path, and returns extension's name. The
  /// extension will be remembered so you only need to call this API once, this API is
  /// not for programming use. If you try to add an extension that has already been
  /// loaded, this method will not return and instead log a warning to the console.
  /// The method will also not return if the extension's manifest is missing or
  /// incomplete. Note: This API cannot be called before the ready event of the app
  /// module is emitted.
  abstract addDevToolsExtension: path: string -> unit
  /// Adds Chrome extension located at path, and returns extension's name. The method
  /// will also not return if the extension's manifest is missing or incomplete. Note:
  /// This API cannot be called before the ready event of the app module is emitted.
  abstract addExtension: path: string -> unit
  abstract fromBrowserView: browserView: BrowserView -> BrowserWindow option
  abstract fromId: id: int -> BrowserWindow
  abstract fromWebContents: webContents: WebContents -> BrowserWindow
  abstract getAllWindows: unit -> BrowserWindow []
  /// To check if a DevTools extension is installed you can run the following: Note:
  /// This API cannot be called before the ready event of the app module is emitted.
  abstract getDevToolsExtensions: unit -> obj
  /// Note: This API cannot be called before the ready event of the app module is
  /// emitted.
  abstract getExtensions: unit -> obj
  abstract getFocusedWindow: unit -> BrowserWindow option
  /// Remove a DevTools extension by name. Note: This API cannot be called before the
  /// ready event of the app module is emitted.
  abstract removeDevToolsExtension: name: string -> unit
  /// Remove a Chrome extension by name. Note: This API cannot be called before the
  /// ready event of the app module is emitted.
  abstract removeExtension: name: string -> unit

type BrowserWindowProxy =
  inherit EventEmitter<BrowserWindowProxy>
  /// Removes focus from the child window.
  abstract blur: unit -> unit
  /// Forcefully closes the child window without calling its unload event.
  abstract close: unit -> unit
  /// Evaluates the code in the child window.
  abstract eval: code: string -> unit
  /// Focuses the child window (brings the window to front).
  abstract focus: unit -> unit
  /// Sends a message to the child window with the specified origin or * for no origin
  /// preference. In addition to these methods, the child window implements
  /// window.opener object with no properties and a single method.
  abstract postMessage: message: string * targetOrigin: string -> unit
  /// Invokes the print dialog on the child window.
  abstract print: unit -> unit
  abstract closed: bool with get, set

type Certificate =
  /// PEM encoded data
  abstract data: string with get, set
  /// Fingerprint of the certificate
  abstract fingerprint: string with get, set
  /// Issuer principal
  abstract issuer: CertificatePrincipal with get, set
  /// Issuer certificate (if not self-signed)
  abstract issuerCert: Certificate with get, set
  /// Issuer's Common Name
  abstract issuerName: string with get, set
  /// Hex value represented string
  abstract serialNumber: string with get, set
  /// Subject principal
  abstract subject: CertificatePrincipal with get, set
  /// Subject's Common Name
  abstract subjectName: string with get, set
  /// End date of the certificate being valid in seconds
  abstract validExpiry: float with get, set
  /// Start date of the certificate being valid in seconds
  abstract validStart: float with get, set

type CertificatePrincipal =
  /// Common Name.
  abstract commonName: string with get, set
  /// Country or region.
  abstract country: string with get, set
  /// Locality.
  abstract locality: string with get, set
  /// Organization names.
  abstract organizations: string [] with get, set
  /// Organization Unit names.
  abstract organizationUnits: string [] with get, set
  /// State or province.
  abstract state: string with get, set

type ClientRequest =
  inherit Node.Stream.Writable<obj>
  inherit EventEmitter<ClientRequest>
  /// Emitted when the request is aborted. The abort event will not be fired if the
  /// request is already closed.
  [<Emit "$0.on('abort',$1)">] abstract onAbort: listener: (Event -> unit) -> ClientRequest
  [<Emit "$0.once('abort',$1)">] abstract onceAbort: listener: (Event -> unit) -> ClientRequest
  [<Emit "$0.addListener('abort',$1)">] abstract addListenerAbort: listener: (Event -> unit) -> ClientRequest
  [<Emit "$0.removeListener('abort',$1)">] abstract removeListenerAbort: listener: (Event -> unit) -> ClientRequest
  /// Emitted as the last event in the HTTP request-response transaction. The close
  /// event indicates that no more events will be emitted on either the request or
  /// response objects.
  [<Emit "$0.on('close',$1)">] abstract onClose: listener: (Event -> unit) -> ClientRequest
  [<Emit "$0.once('close',$1)">] abstract onceClose: listener: (Event -> unit) -> ClientRequest
  [<Emit "$0.addListener('close',$1)">] abstract addListenerClose: listener: (Event -> unit) -> ClientRequest
  [<Emit "$0.removeListener('close',$1)">] abstract removeListenerClose: listener: (Event -> unit) -> ClientRequest
  /// Emitted when the net module fails to issue a network request. Typically when the
  /// request object emits an error event, a close event will subsequently follow and
  /// no response object will be provided.
  [<Emit "$0.on('error',$1)">] abstract onError: listener: (Error -> unit) -> ClientRequest
  [<Emit "$0.once('error',$1)">] abstract onceError: listener: (Error -> unit) -> ClientRequest
  [<Emit "$0.addListener('error',$1)">] abstract addListenerError: listener: (Error -> unit) -> ClientRequest
  [<Emit "$0.removeListener('error',$1)">] abstract removeListenerError: listener: (Error -> unit) -> ClientRequest
  /// Emitted just after the last chunk of the request's data has been written into
  /// the request object.
  [<Emit "$0.on('finish',$1)">] abstract onFinish: listener: (Event -> unit) -> ClientRequest
  [<Emit "$0.once('finish',$1)">] abstract onceFinish: listener: (Event -> unit) -> ClientRequest
  [<Emit "$0.addListener('finish',$1)">] abstract addListenerFinish: listener: (Event -> unit) -> ClientRequest
  [<Emit "$0.removeListener('finish',$1)">] abstract removeListenerFinish: listener: (Event -> unit) -> ClientRequest
  /// Emitted when an authenticating proxy is asking for user credentials. The
  /// callback (Event -> unit) is expected to be called back with user credentials: Providing
  /// empty credentials will cancel the request and report an authentication error on
  /// the response object:
  [<Emit "$0.on('login',$1)">] abstract onLogin: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
  [<Emit "$0.once('login',$1)">] abstract onceLogin: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
  [<Emit "$0.addListener('login',$1)">] abstract addListenerLogin: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
  [<Emit "$0.removeListener('login',$1)">] abstract removeListenerLogin: listener: (AuthInfo -> (string -> string -> unit) -> unit) -> ClientRequest
  /// Emitted when there is redirection and the mode is manual. Calling
  /// request.followRedirect will continue with the redirection.
  [<Emit "$0.on('redirect',$1)">] abstract onRedirect: listener: (int -> string -> string -> obj option -> unit) -> ClientRequest
  [<Emit "$0.once('redirect',$1)">] abstract onceRedirect: listener: (int -> string -> string -> obj option -> unit) -> ClientRequest
  [<Emit "$0.addListener('redirect',$1)">] abstract addListenerRedirect: listener: (int -> string -> string -> obj option -> unit) -> ClientRequest
  [<Emit "$0.removeListener('redirect',$1)">] abstract removeListenerRedirect: listener: (int -> string -> string -> obj option -> unit) -> ClientRequest
  [<Emit "$0.on('response',$1)">] abstract onResponse: listener: (IncomingMessage -> unit) -> ClientRequest
  [<Emit "$0.once('response',$1)">] abstract onceResponse: listener: (IncomingMessage -> unit) -> ClientRequest
  [<Emit "$0.addListener('response',$1)">] abstract addListenerResponse: listener: (IncomingMessage -> unit) -> ClientRequest
  [<Emit "$0.removeListener('response',$1)">] abstract removeListenerResponse: listener: (IncomingMessage -> unit) -> ClientRequest
  /// Cancels an ongoing HTTP transaction. If the request has already emitted the
  /// close event, the abort operation will have no effect. Otherwise an ongoing event
  /// will emit abort and close events. Additionally, if there is an ongoing response
  /// object,it will emit the aborted event.
  abstract abort: unit -> unit
  /// Sends the last chunk of the request data. Subsequent write or end operations
  /// will not be allowed. The finish event is emitted just after the end operation.
  abstract ``end``: ?chunk: U2<string, Buffer> * ?encoding: string * ?callback: (Event -> unit) -> unit
  /// Continues any deferred redirection request when the redirection mode is manual.
  abstract followRedirect: unit -> unit
  abstract getHeader: name: string -> ExtraHeaderValue
  /// You can use this method in conjunction with POST requests to get the progress of
  /// a file upload or other data transfer.
  abstract getUploadProgress: unit -> UploadProgress
  /// Removes a previously set extra header name. This method can be called only
  /// before first write. Trying to call it after the first write will throw an error.
  abstract removeHeader: name: string -> unit
  /// Adds an extra HTTP header. The header name will issued as it is without
  /// lowercasing. It can be called only before first write. Calling this method after
  /// the first write will throw an error. If the passed value is not a String, its
  /// toString() method will be called to obtain the final value.
  abstract setHeader: name: string * value: obj -> unit
  /// callback is essentially a dummy (Event -> unit) introduced in the purpose of keeping
  /// similarity with the Node.js API. It is called asynchronously in the next tick
  /// after chunk content have been delivered to the Chromium networking layer.
  /// Contrary to the Node.js implementation, it is not guaranteed that chunk content
  /// have been flushed on the wire before callback is called. Adds a chunk of data to
  /// the request body. The first write operation may cause the request headers to be
  /// issued on the wire. After the first write operation, it is not allowed to add or
  /// remove a custom header.
  abstract write: chunk: U2<string, Buffer> * ?encoding: string * ?callback: (Event -> unit) -> unit
  abstract chunkedEncoding: bool with get, set

type ClientRequestOptions =
  /// The HTTP request method. Defaults to the GET method.
  abstract method: string
  /// The request URL. Must be provided in the absolute form with the protocol scheme specified as http or https.
  abstract url: string
  /// The Session instance with which the request is associated.
  abstract session: Session
  /// The name of the partition with which the request is associated. Defaults to the empty string. The session option prevails on partition. Thus if a session is explicitly specified, partition is ignored.
  abstract partition: string
  /// The protocol scheme in the form 'scheme:'. Currently supported values are 'http:' or 'https:'. Defaults to 'http:'.
  abstract protocol: string
  /// The server host provided as a concatenation of the hostname and the port number 'hostname:port'.
  abstract host: string
  /// The server host name.
  abstract hostname: string
  /// The server's listening port number.
  abstract port: int
  /// The path part of the request URL.
  abstract path: string
  /// The redirect mode for this request. Should be one of follow, error or manual. Defaults to follow. When mode is error, any redirection will be aborted. When mode is manual the redirection will be deferred until request.followRedirect is invoked. Listen for the redirect event in this mode to get more details about the redirect request.
  abstract redirect: string


type ClientRequestStatic =
  [<EmitConstructor>] abstract Create: options: U2<string, ClientRequestOptions> -> ClientRequest

[<StringEnum; RequireQualifiedAccess>]
type ClipboardType =
  | Clipboard
  // Only available on Linux
  | Selection

type Clipboard =
  inherit EventEmitter<Clipboard>
  abstract availableFormats: ?``type``: ClipboardType -> string []
  /// Clears the clipboard content.
  abstract clear: ?``type``: ClipboardType -> unit
  abstract has: format: string * ?``type``: ClipboardType -> bool
  abstract read: format: string -> string
  /// Returns an Object containing title and url keys representing the bookmark in the
  /// clipboard. The title and url values will be empty strings when the bookmark is
  /// unavailable.
  abstract readBookmark: unit -> ReadBookmark
  abstract readBuffer: format: string -> Buffer
  abstract readFindText: unit -> string
  abstract readHTML: ?``type``: ClipboardType -> string
  abstract readImage: ?``type``: ClipboardType -> NativeImage
  abstract readRTF: ?``type``: ClipboardType -> string
  abstract readText: ?``type``: ClipboardType -> string
  /// Writes data to the clipboard.
  abstract write: data: ClipboardData * ?``type``: ClipboardType -> unit
  /// Writes the title and url into the clipboard as a bookmark. Note: Most apps on
  /// Windows don't support pasting bookmarks into them so you can use clipboard.write
  /// to write both a bookmark and fallback text to the clipboard.
  abstract writeBookmark: title: string * url: string * ?``type``: ClipboardType -> unit
  /// Writes the buffer into the clipboard as format.
  abstract writeBuffer: format: string * buffer: Buffer * ?``type``: ClipboardType -> unit
  /// Writes the text into the find pasteboard as plain text. This method uses
  /// synchronous IPC when called from the renderer process.
  abstract writeFindText: text: string -> unit
  /// Writes markup to the clipboard.
  abstract writeHTML: markup: string * ?``type``: ClipboardType -> unit
  /// Writes image to the clipboard.
  abstract writeImage: image: NativeImage * ?``type``: ClipboardType -> unit
  /// Writes the text into the clipboard in RTF.
  abstract writeRTF: text: string * ?``type``: ClipboardType -> unit
  /// Writes the text into the clipboard as plain text.
  abstract writeText: text: string * ?``type``: ClipboardType -> unit

type ContentTracing =
  inherit EventEmitter<ContentTracing>
  /// Get a set of category groups. The category groups can change as new code paths
  /// are reached. Once all child processes have acknowledged the getCategories
  /// request the callback is invoked with an array of category groups. Deprecated
  /// Soon
  abstract getCategories: callback: (string [] -> unit) -> unit
  /// Get a set of category groups. The category groups can change as new code paths
  /// are reached.
  abstract getCategories: unit -> Promise<string>
  /// Get the maximum usage across processes of trace buffer as a percentage of the
  /// full state. When the TraceBufferUsage value is determined the callback is
  /// called.
  abstract getTraceBufferUsage: callback: (float -> float -> unit) -> unit
  /// Start recording on all processes. Recording begins immediately locally and
  /// asynchronously on child processes as soon as they receive the EnableRecording
  /// request. The callback will be called once all child processes have acknowledged
  /// the startRecording request. Deprecated Soon
  abstract startRecording: options: U2<TraceCategoriesAndOptions, TraceConfig> * callback: (Event -> unit) -> unit
  /// Start recording on all processes. Recording begins immediately locally and
  /// asynchronously on child processes as soon as they receive the EnableRecording
  /// request.
  abstract startRecording: options: U2<TraceCategoriesAndOptions, TraceConfig> -> Promise<unit>
  /// Stop recording on all processes. Child processes typically cache trace data and
  /// only rarely flush and send trace data back to the main process. This helps to
  /// minimize the runtime overhead of tracing since sending trace data over IPC can
  /// be an expensive operation. So, to end tracing, we must asynchronously ask all
  /// child processes to flush any pending trace data. Once all child processes have
  /// acknowledged the stopRecording request, callback will be called with a file that
  /// contains the traced data. Trace data will be written into resultFilePath if it
  /// is not empty or into a temporary file. The actual file path will be passed to
  /// callback if it's not null. Deprecated Soon
  abstract stopRecording: resultFilePath: string * callback: (string -> unit) -> unit
  /// Stop recording on all processes. Child processes typically cache trace data and
  /// only rarely flush and send trace data back to the main process. This helps to
  /// minimize the runtime overhead of tracing since sending trace data over IPC can
  /// be an expensive operation. So, to end tracing, we must asynchronously ask all
  /// child processes to flush any pending trace data. Trace data will be written into
  /// resultFilePath if it is not empty or into a temporary file.
  abstract stopRecording: resultFilePath: string -> Promise<string>

type Cookie =
  /// The domain of the cookie; this will be normalized with a preceding dot so that
  /// it's also valid for subdomains.
  abstract domain: string option with get, set
  /// The expiration date of the cookie as the number of seconds since the UNIX epoch.
  /// Not provided for session cookies.
  abstract expirationDate: float option with get, set
  /// Whether the cookie is a host-only cookie; this will only be true if no domain
  /// was passed.
  abstract hostOnly: bool option with get, set
  /// Whether the cookie is marked as HTTP only.
  abstract httpOnly: bool option with get, set
  /// The name of the cookie.
  abstract name: string with get, set
  /// The path of the cookie.
  abstract path: string option with get, set
  /// Whether the cookie is marked as secure.
  abstract secure: bool option with get, set
  /// Whether the cookie is a session cookie or a persistent cookie with an expiration
  /// date.
  abstract session: bool option with get, set
  /// The value of the cookie.
  abstract value: string with get, set

[<StringEnum; RequireQualifiedAccess>]
type CookieChangedCause =
  | Explicit
  | Overwrite
  | Expired
  | Evicted
  | [<CompiledName("expired-overwrite")>] ExpiredOverwrite

type Cookies =
  inherit EventEmitter<Cookies>
  /// Emitted when a cookie is changed because it was added, edited, removed, or
  /// expired.
  [<Emit "$0.on('changed',$1)">] abstract onChanged: listener: (Event -> Cookie -> CookieChangedCause -> bool -> unit) -> Cookies
  [<Emit "$0.once('changed',$1)">] abstract onceChanged: listener: (Event -> Cookie -> CookieChangedCause -> bool -> unit) -> Cookies
  [<Emit "$0.addListener('changed',$1)">] abstract addListenerChanged: listener: (Event -> Cookie -> CookieChangedCause -> bool -> unit) -> Cookies
  [<Emit "$0.removeListener('changed',$1)">] abstract removeListenerChanged: listener: (Event -> Cookie -> CookieChangedCause -> bool -> unit) -> Cookies
  /// Writes any unwritten cookies data to disk.
  abstract flushStore: unit -> Promise<unit>
  /// Writes any unwritten cookies data to disk. Deprecated Soon
  abstract flushStore: callback: (Event -> unit) -> unit
  /// Sends a request to get all cookies matching filter, and resolves a promise with
  /// the response.
  abstract get: filter: CookieFilter -> Promise<Cookie>
  /// Sends a request to get all cookies matching filter, callback will be called with
  /// callback(error, cookies) on complete. Deprecated Soon
  abstract get: filter: CookieFilter * callback: (Error -> Cookie [] -> unit) -> unit
  /// Removes the cookies matching url and name
  abstract remove: url: string * name: string -> Promise<unit>
  /// Removes the cookies matching url and name, callback will called with callback()
  /// on complete. Deprecated Soon
  abstract remove: url: string * name: string * callback: (Event -> unit) -> unit
  /// Sets a cookie with details.
  abstract set: details: CookieDetails -> Promise<unit>
  /// Sets a cookie with details, callback will be called with callback(error) on
  /// complete. Deprecated Soon
  abstract set: details: CookieDetails * callback: (Error -> unit) -> unit

type CPUUsage =
  /// The number of average idle cpu wakeups per second since the last call to
  /// getCPUUsage. First call returns 0. Will always return 0 on Windows.
  abstract idleWakeupsPerSecond: float with get, set
  /// Percentage of CPU used since the last call to getCPUUsage. First call returns 0.
  abstract percentCPUUsage: float with get, set

type CrashReport =
  abstract date: DateTime with get, set
  abstract id: string with get, set

type CrashReporter =
  inherit EventEmitter<CrashReporter>
  /// Set an extra parameter to be sent with the crash report. The values specified
  /// here will be sent in addition to any values set via the extra option when start
  /// was called. This API is only available on macOS, if you need to add/update extra
  /// parameters on Linux and Windows after your first call to start you can call
  /// start again with the updated extra options.
  abstract addExtraParameter: key: string * value: string -> unit
  /// Returns the date and ID of the last crash report. Only crash reports that have
  /// been uploaded will be returned; even if a crash report is present on disk it
  /// will not be returned until it is uploaded. In the case that there are no
  /// uploaded reports, null is returned.
  abstract getLastCrashReport: unit -> CrashReport
  /// See all of the current parameters being passed to the crash reporter.
  abstract getParameters: unit -> unit
  /// Returns all uploaded crash reports. Each report contains the date and uploaded
  /// ID.
  abstract getUploadedReports: unit -> CrashReport []
  /// Note: This API can only be called from the main process.
  abstract getUploadToServer: unit -> bool
  /// Remove a extra parameter from the current set of parameters so that it will not
  /// be sent with the crash report.
  abstract removeExtraParameter: key: string -> unit
  /// This would normally be controlled by user preferences. This has no effect if
  /// called before start is called. Note: This API can only be called from the main
  /// process.
  abstract setUploadToServer: uploadToServer: bool -> unit
  /// You are required to call this method before using any other crashReporter APIs
  /// and in each process (main/renderer) from which you want to collect crash
  /// reports. You can pass different options to crashReporter.start when calling from
  /// different processes. Note Child processes created via the child_process module
  /// will not have access to the Electron modules. Therefore, to collect crash
  /// reports from them, use process.crashReporter.start instead. Pass the same
  /// options as above along with an additional one called crashesDirectory that
  /// should point to a directory to store the crash reports temporarily. You can test
  /// this out by calling process.crash() to crash the child process. Note: To collect
  /// crash reports from child process in Windows, you need to add this extra code as
  /// well. This will start the process that will monitor and send the crash reports.
  /// Replace submitURL, productName and crashesDirectory with appropriate values.
  /// Note: If you need send additional/updated extra parameters after your first call
  /// start you can call addExtraParameter on macOS or call start again with the
  /// new/updated extra parameters on Linux and Windows. Note: On macOS, Electron uses
  /// a new crashpad client for crash collection and reporting. If you want to enable
  /// crash reporting, initializing crashpad from the main process using
  /// crashReporter.start is required regardless of which process you want to collect
  /// crashes from. Once initialized this way, the crashpad handler collects crashes
  /// from all processes. You still have to call crashReporter.start from the renderer
  /// or child process, otherwise crashes from them will get reported without
  /// companyName, productName or any of the extra information.
  abstract start: options: CrashReporterStartOptions -> unit

type CustomScheme =
  abstract privileges: CustomSchemePrivileges with get, set
  /// Custom schemes to be registered with options.
  abstract scheme: string with get, set

type Debugger =
  inherit EventEmitter<Debugger>
  /// Emitted when debugging session is terminated. This happens either when
  /// webContents is closed or devtools is invoked for the attached webContents.
  [<Emit "$0.on('detach',$1)">] abstract onDetach: listener: (Event -> string -> unit) -> Debugger
  [<Emit "$0.once('detach',$1)">] abstract onceDetach: listener: (Event -> string -> unit) -> Debugger
  [<Emit "$0.addListener('detach',$1)">] abstract addListenerDetach: listener: (Event -> string -> unit) -> Debugger
  [<Emit "$0.removeListener('detach',$1)">] abstract removeListenerDetach: listener: (Event -> string -> unit) -> Debugger
  /// Emitted whenever debugging target issues instrumentation event.
  [<Emit "$0.on('message',$1)">] abstract onMessage: listener: (Event -> string -> obj option -> unit) -> Debugger
  [<Emit "$0.once('message',$1)">] abstract onceMessage: listener: (Event -> string -> obj option -> unit) -> Debugger
  [<Emit "$0.addListener('message',$1)">] abstract addListenerMessage: listener: (Event -> string -> obj option -> unit) -> Debugger
  [<Emit "$0.removeListener('message',$1)">] abstract removeListenerMessage: listener: (Event -> string -> obj option -> unit) -> Debugger
  /// Attaches the debugger to the webContents.
  abstract attach: ?protocolVersion: string -> unit
  /// Detaches the debugger from the webContents.
  abstract detach: unit -> unit
  abstract isAttached: unit -> bool
  /// Send given command to the debugging target. Deprecated Soon
  abstract sendCommand: method: string * ?commandParams: obj * ?callback: (obj option -> obj option -> unit) -> unit
  /// Send given command to the debugging target.
  abstract sendCommand: method: string * ?commandParams: obj -> Promise<obj option>

type DesktopCapturer =
  inherit EventEmitter<DesktopCapturer>
  /// Starts gathering information about all available desktop media sources, and
  /// calls callback(error, sources) when finished. sources is an array of
  /// DesktopCapturerSource objects, each DesktopCapturerSource represents a screen or
  /// an individual window that can be captured. Deprecated Soon
  abstract getSources: options: GetDesktopCapturerSourcesOptions * callback: (Error -> DesktopCapturerSource [] -> unit) -> unit
  abstract getSources: options: GetDesktopCapturerSourcesOptions -> Promise<DesktopCapturerSource>

type DesktopCapturerSource =
  /// An icon image of the application that owns the window or null if the source has
  /// a type screen. The size of the icon is not known in advance and depends on what
  /// the the application provides.
  abstract appIcon: NativeImage with get, set
  /// A unique identifier that will correspond to the id of the matching returned by
  /// the . On some platforms, this is equivalent to the XX portion of the id field
  /// above and on others it will differ. It will be an empty string if not available.
  abstract display_id: string with get, set
  /// The identifier of a window or screen that can be used as a chromeMediaSourceId
  /// constraint when calling [navigator.webkitGetUserMedia]. The format of the
  /// identifier will be window:XX or screen:XX, where XX is a random generated
  /// number.
  abstract id: string with get, set
  /// A screen source will be named either Entire Screen or Screen , while the name of
  /// a window source will match the window title.
  abstract name: string with get, set
  /// A thumbnail image. There is no guarantee that the size of the thumbnail is the
  /// same as the thumbnailSize specified in the options passed to
  /// desktopCapturer.getSources. The actual size depends on the scale of the screen
  /// or window.
  abstract thumbnail: NativeImage with get, set

type Dialog =
  inherit EventEmitter<Dialog>
  /// On macOS, this displays a modal dialog that shows a message and certificate
  /// information, and gives the user the option of trusting/importing the
  /// certificate. If you provide a browserWindow argument the dialog will be attached
  /// to the parent window, making it modal. On Windows the options are more limited,
  /// due to the Win32 APIs used:
  abstract showCertificateTrustDialog: browserWindow: BrowserWindow * options: CertificateTrustDialogOptions * callback: (Event -> unit) -> unit
  /// On macOS, this displays a modal dialog that shows a message and certificate
  /// information, and gives the user the option of trusting/importing the
  /// certificate. If you provide a browserWindow argument the dialog will be attached
  /// to the parent window, making it modal. On Windows the options are more limited,
  /// due to the Win32 APIs used:
  abstract showCertificateTrustDialog: options: CertificateTrustDialogOptions * callback: (Event -> unit) -> unit
  /// Displays a modal dialog that shows an error message. This API can be called
  /// safely before the ready event the app module emits, it is usually used to report
  /// errors in early stage of startup. If called before the app readyevent on Linux,
  /// the message will be emitted to stderr, and no GUI dialog will appear.
  abstract showErrorBox: title: string * content: string -> unit
  /// Shows a message box, it will block the process until the message box is closed.
  /// It returns the index of the clicked button. The browserWindow argument allows
  /// the dialog to attach itself to a parent window, making it modal. If the callback
  /// and browserWindow arguments are passed, the dialog will not block the process.
  /// The API call will be asynchronous and the result will be passed via
  /// callback(response).
  abstract showMessageBox: browserWindow: BrowserWindow * options: MessageBoxOptions * callback: (int -> bool -> unit) -> unit
  /// Shows a message box, it will block the process until the message box is closed.
  /// It returns the index of the clicked button. The browserWindow argument allows
  /// the dialog to attach itself to a parent window, making it modal. If the callback
  /// and browserWindow arguments are passed, the dialog will not block the process.
  /// The API call will be asynchronous and the result will be passed via
  /// callback(response).
  abstract showMessageBox: browserWindow: BrowserWindow * options: MessageBoxOptions -> int
  /// Shows a message box, it will block the process until the message box is closed.
  /// It returns the index of the clicked button. The browserWindow argument allows
  /// the dialog to attach itself to a parent window, making it modal. If the callback
  /// and browserWindow arguments are passed, the dialog will not block the process.
  /// The API call will be asynchronous and the result will be passed via
  /// callback(response).
  abstract showMessageBox: options: MessageBoxOptions * callback: (int -> bool -> unit) -> unit
  /// Shows a message box, it will block the process until the message box is closed.
  /// It returns the index of the clicked button. The browserWindow argument allows
  /// the dialog to attach itself to a parent window, making it modal. If the callback
  /// and browserWindow arguments are passed, the dialog will not block the process.
  /// The API call will be asynchronous and the result will be passed via
  /// callback(response).
  abstract showMessageBox: options: MessageBoxOptions -> int
  /// The browserWindow argument allows the dialog to attach itself to a parent
  /// window, making it modal. The filters specifies an array of file types that can
  /// be displayed or selected when you want to limit the user to a specific type. For
  /// example: The extensions array should contain extensions without wildcards or
  /// dots (e.g. 'png' is good but '.png' and '*.png' are bad). To show all files, use
  /// the '*' wildcard (no other wildcard is supported). If a callback is passed, the
  /// API call will be asynchronous and the result will be passed via
  /// callback(filenames). Note: On Windows and Linux an open dialog can not be both a
  /// file selector and a directory selector, so if you set properties to ['openFile',
  /// 'openDirectory'] on these platforms, a directory selector will be shown.
  abstract showOpenDialog: browserWindow: BrowserWindow * options: OpenDialogOptions * callback: (string [] -> string [] -> unit) -> unit
  /// The browserWindow argument allows the dialog to attach itself to a parent
  /// window, making it modal. The filters specifies an array of file types that can
  /// be displayed or selected when you want to limit the user to a specific type. For
  /// example: The extensions array should contain extensions without wildcards or
  /// dots (e.g. 'png' is good but '.png' and '*.png' are bad). To show all files, use
  /// the '*' wildcard (no other wildcard is supported). If a callback is passed, the
  /// API call will be asynchronous and the result will be passed via
  /// callback(filenames). Note: On Windows and Linux an open dialog can not be both a
  /// file selector and a directory selector, so if you set properties to ['openFile',
  /// 'openDirectory'] on these platforms, a directory selector will be shown.
  abstract showOpenDialog: options: OpenDialogOptions * callback: (string [] option -> string [] -> unit) -> unit
  /// The browserWindow argument allows the dialog to attach itself to a parent
  /// window, making it modal. The filters specifies an array of file types that can
  /// be displayed or selected when you want to limit the user to a specific type. For
  /// example: The extensions array should contain extensions without wildcards or
  /// dots (e.g. 'png' is good but '.png' and '*.png' are bad). To show all files, use
  /// the '*' wildcard (no other wildcard is supported). If a callback is passed, the
  /// API call will be asynchronous and the result will be passed via
  /// callback(filenames). Note: On Windows and Linux an open dialog can not be both a
  /// file selector and a directory selector, so if you set properties to ['openFile',
  /// 'openDirectory'] on these platforms, a directory selector will be shown.
  abstract showOpenDialog: browserWindow: BrowserWindow * options: OpenDialogOptions -> string []
  /// The browserWindow argument allows the dialog to attach itself to a parent
  /// window, making it modal. The filters specifies an array of file types that can
  /// be displayed or selected when you want to limit the user to a specific type. For
  /// example: The extensions array should contain extensions without wildcards or
  /// dots (e.g. 'png' is good but '.png' and '*.png' are bad). To show all files, use
  /// the '*' wildcard (no other wildcard is supported). If a callback is passed, the
  /// API call will be asynchronous and the result will be passed via
  /// callback(filenames). Note: On Windows and Linux an open dialog can not be both a
  /// file selector and a directory selector, so if you set properties to ['openFile',
  /// 'openDirectory'] on these platforms, a directory selector will be shown.
  abstract showOpenDialog: options: OpenDialogOptions -> string []
  /// The browserWindow argument allows the dialog to attach itself to a parent
  /// window, making it modal. The filters specifies an array of file types that can
  /// be displayed, see dialog.showOpenDialog for an example. If a callback is passed,
  /// the API call will be asynchronous and the result will be passed via
  /// callback(filename).
  abstract showSaveDialog: browserWindow: BrowserWindow * options: SaveDialogOptions * callback: (string option -> string option -> unit) -> unit
  /// The browserWindow argument allows the dialog to attach itself to a parent
  /// window, making it modal. The filters specifies an array of file types that can
  /// be displayed, see dialog.showOpenDialog for an example. If a callback is passed,
  /// the API call will be asynchronous and the result will be passed via
  /// callback(filename).
  abstract showSaveDialog: options: SaveDialogOptions * callback: (string option -> string option -> unit) -> unit
  /// The browserWindow argument allows the dialog to attach itself to a parent
  /// window, making it modal. The filters specifies an array of file types that can
  /// be displayed, see dialog.showOpenDialog for an example. If a callback is passed,
  /// the API call will be asynchronous and the result will be passed via
  /// callback(filename).
  abstract showSaveDialog: browserWindow: BrowserWindow * options: SaveDialogOptions -> string option
  /// The browserWindow argument allows the dialog to attach itself to a parent
  /// window, making it modal. The filters specifies an array of file types that can
  /// be displayed, see dialog.showOpenDialog for an example. If a callback is passed,
  /// the API call will be asynchronous and the result will be passed via
  /// callback(filename).
  abstract showSaveDialog: options: SaveDialogOptions -> string option


[<StringEnum; RequireQualifiedAccess>]
type DisplayTouchSupport =
  | Available
  | Unavailable
  | Unknown

type Display =
  abstract bounds: Rectangle with get, set
  /// Unique identifier associated with the display.
  abstract id: int with get, set
  /// Can be 0, 90, 180, 270, represents screen rotation in clock-wise degrees.
  abstract rotation: int with get, set
  /// Output device's pixel scale factor.
  abstract scaleFactor: float with get, set
  abstract size: Size with get, set
  abstract touchSupport: DisplayTouchSupport with get, set
  abstract workArea: Rectangle with get, set
  abstract workAreaSize: Size with get, set

[<StringEnum; RequireQualifiedAccess>]
type DownloadItemState =
  | Progressing
  | Completed
  | Cancelled
  | Interrupted

[<StringEnum; RequireQualifiedAccess>]
type DownloadItemDoneState =
  | Completed
  | Cancelled
  | Interrupted

[<StringEnum; RequireQualifiedAccess>]
type DownloadItemUpdatedState =
  | Progressing
  | Interrupted

type DownloadItem =
  inherit EventEmitter<DownloadItem>
  /// Emitted when the download is in a terminal state. This includes a completed
  /// download, a cancelled download (via downloadItem.cancel()), and interrupted
  /// download that can't be resumed. The state can be one of following:
  [<Emit "$0.on('done',$1)">] abstract onDone: listener: (Event -> DownloadItemDoneState -> unit) -> DownloadItem
  [<Emit "$0.once('done',$1)">] abstract onceDone: listener: (Event -> DownloadItemDoneState -> unit) -> DownloadItem
  [<Emit "$0.addListener('done',$1)">] abstract addListenerDone: listener: (Event -> DownloadItemDoneState -> unit) -> DownloadItem
  [<Emit "$0.removeListener('done',$1)">] abstract removeListenerDone: listener: (Event -> DownloadItemDoneState -> unit) -> DownloadItem
  /// Emitted when the download has been updated and is not done. The state can be one
  /// of following:
  [<Emit "$0.on('updated',$1)">] abstract onUpdated: listener: (Event -> DownloadItemUpdatedState -> unit) -> DownloadItem
  [<Emit "$0.once('updated',$1)">] abstract onceUpdated: listener: (Event -> DownloadItemUpdatedState -> unit) -> DownloadItem
  [<Emit "$0.addListener('updated',$1)">] abstract addListenerUpdated: listener: (Event -> DownloadItemUpdatedState -> unit) -> DownloadItem
  [<Emit "$0.removeListener('updated',$1)">] abstract removeListenerUpdated: listener: (Event -> DownloadItemUpdatedState -> unit) -> DownloadItem
  /// Cancels the download operation.
  abstract cancel: unit -> unit
  abstract canResume: unit -> bool
  abstract getContentDisposition: unit -> string
  abstract getETag: unit -> string
  /// Note: The file name is not always the same as the actual one saved in local
  /// disk. If user changes the file name in a prompted download saving dialog, the
  /// actual name of saved file will be different.
  abstract getFilename: unit -> string
  abstract getLastModifiedTime: unit -> string
  abstract getMimeType: unit -> string
  abstract getReceivedBytes: unit -> int
  abstract getSaveDialogOptions: unit -> SaveDialogOptions
  abstract getSavePath: unit -> string
  abstract getStartTime: unit -> float
  /// Note: The following methods are useful specifically to resume a cancelled item
  /// when session is restarted.
  abstract getState: unit -> DownloadItemState
  /// If the size is unknown, it returns 0.
  abstract getTotalBytes: unit -> int
  abstract getURL: unit -> string
  abstract getURLChain: unit -> string []
  abstract hasUserGesture: unit -> bool
  abstract isPaused: unit -> bool
  /// Pauses the download.
  abstract pause: unit -> unit
  /// Resumes the download that has been paused. Note: To enable resumable downloads
  /// the server you are downloading from must support range requests and provide both
  /// Last-Modified and ETag header values. Otherwise resume() will dismiss previously
  /// received bytes and restart the download from the beginning.
  abstract resume: unit -> unit
  /// This API allows the user to set custom options for the save dialog that opens
  /// for the download item by default. The API is only available in session's
  /// will-download callback (Event -> unit).
  abstract setSaveDialogOptions: options: SaveDialogOptions -> unit
  /// The API is only available in session's will-download callback (Event -> unit). If user
  /// doesn't set the save path via the API, Electron will use the original routine to
  /// determine the save path(Usually prompts a save dialog).
  abstract setSavePath: path: string -> unit

type FileDialogFilter =
  abstract extensions: string [] with get, set
  abstract name: string with get, set

type GlobalShortcut =
  inherit EventEmitter<GlobalShortcut>
  /// When the accelerator is already taken by other applications, this call will
  /// still return false. This behavior is intended by operating systems, since they
  /// don't want applications to fight for global shortcuts.
  abstract isRegistered: accelerator: string -> bool
  /// Registers a global shortcut of accelerator. The callback is called when the
  /// registered shortcut is pressed by the user. When the accelerator is already
  /// taken by other applications, this call will silently fail. This behavior is
  /// intended by operating systems, since they don't want applications to fight for
  /// global shortcuts. The following accelerators will not be registered successfully
  /// on macOS 10.14 Mojave unless the app has been authorized as a trusted
  /// accessibility client:
  abstract register: accelerator: string * callback: (Event -> unit) -> bool
  /// Registers a global shortcut of all accelerator items in accelerators. The
  /// callback is called when any of the registered shortcuts are pressed by the user.
  /// When a given accelerator is already taken by other applications, this call will
  /// silently fail. This behavior is intended by operating systems, since they don't
  /// want applications to fight for global shortcuts. The following accelerators will
  /// not be registered successfully on macOS 10.14 Mojave unless the app has been
  /// authorized as a trusted accessibility client:
  abstract registerAll: accelerators: string [] * callback: (Event -> unit) -> unit
  /// Unregisters the global shortcut of accelerator.
  abstract unregister: accelerator: string -> unit
  /// Unregisters all of the global shortcuts.
  abstract unregisterAll: unit -> unit

type GPUFeatureStatus =
  /// Canvas.
  abstract ``2d_canvas``: string with get, set
  /// Flash.
  abstract flash_3d: string with get, set
  /// Flash Stage3D.
  abstract flash_stage3d: string with get, set
  /// Flash Stage3D Baseline profile.
  abstract flash_stage3d_baseline: string with get, set
  /// Compositing.
  abstract gpu_compositing: string with get, set
  /// Multiple Raster Threads.
  abstract multiple_raster_threads: string with get, set
  /// Native GpuMemoryBuffers.
  abstract native_gpu_memory_buffers: string with get, set
  /// Rasterization.
  abstract rasterization: string with get, set
  /// Video Decode.
  abstract video_decode: string with get, set
  /// Video Encode.
  abstract video_encode: string with get, set
  /// VPx Video Decode.
  abstract vpx_decode: string with get, set
  /// WebGL.
  abstract webgl: string with get, set
  /// WebGL2.
  abstract webgl2: string with get, set

type InAppPurchase =
  inherit EventEmitter<InAppPurchase>
  /// Emitted when one or more transactions have been updated.
  [<Emit "$0.on('transactions-updated',$1)">] abstract onTransactionsUpdated: listener: (Event -> Transaction [] -> unit) -> InAppPurchase
  [<Emit "$0.once('transactions-updated',$1)">] abstract onceTransactionsUpdated: listener: (Event -> Transaction [] -> unit) -> InAppPurchase
  [<Emit "$0.addListener('transactions-updated',$1)">] abstract addListenerTransactionsUpdated: listener: (Event -> Transaction [] -> unit) -> InAppPurchase
  [<Emit "$0.removeListener('transactions-updated',$1)">] abstract removeListenerTransactionsUpdated: listener: (Event -> Transaction [] -> unit) -> InAppPurchase
  abstract canMakePayments: unit -> bool
  /// Completes all pending transactions.
  abstract finishAllTransactions: unit -> unit
  /// Completes the pending transactions corresponding to the date.
  abstract finishTransactionByDate: date: string -> unit
  /// Retrieves the product descriptions.
  abstract getProducts: productIDs: string [] * callback: (Product [] -> unit) -> unit
  abstract getReceiptURL: unit -> string
  /// You should listen for the transactions-updated event as soon as possible and
  /// certainly before you call purchaseProduct.
  abstract purchaseProduct: productID: string * ?quantity: int * ?callback: (bool -> unit) -> unit

type IncomingMessage =
  inherit Node.Stream.Readable<obj>
  inherit EventEmitter<IncomingMessage>
  /// Emitted when a request has been canceled during an ongoing HTTP transaction.
  [<Emit "$0.on('aborted',$1)">] abstract onAborted: listener: (Event -> unit) -> IncomingMessage
  [<Emit "$0.once('aborted',$1)">] abstract onceAborted: listener: (Event -> unit) -> IncomingMessage
  [<Emit "$0.addListener('aborted',$1)">] abstract addListenerAborted: listener: (Event -> unit) -> IncomingMessage
  [<Emit "$0.removeListener('aborted',$1)">] abstract removeListenerAborted: listener: (Event -> unit) -> IncomingMessage
  /// The data event is the usual method of transferring response data into
  /// applicative code.
  [<Emit "$0.on('data',$1)">] abstract onData: listener: (Buffer -> unit) -> IncomingMessage
  [<Emit "$0.once('data',$1)">] abstract onceData: listener: (Buffer -> unit) -> IncomingMessage
  [<Emit "$0.addListener('data',$1)">] abstract addListenerData: listener: (Buffer -> unit) -> IncomingMessage
  [<Emit "$0.removeListener('data',$1)">] abstract removeListenerData: listener: (Buffer -> unit) -> IncomingMessage
  /// Indicates that response body has ended.
  [<Emit "$0.on('end',$1)">] abstract onEnd: listener: (Event -> unit) -> IncomingMessage
  [<Emit "$0.once('end',$1)">] abstract onceEnd: listener: (Event -> unit) -> IncomingMessage
  [<Emit "$0.addListener('end',$1)">] abstract addListenerEnd: listener: (Event -> unit) -> IncomingMessage
  [<Emit "$0.removeListener('end',$1)">] abstract removeListenerEnd: listener: (Event -> unit) -> IncomingMessage
  /// error Error - Typically holds an error string identifying failure root cause.
  /// Emitted when an error was encountered while streaming response data events. For
  /// instance, if the server closes the underlying while the response is still
  /// streaming, an error event will be emitted on the response object and a close
  /// event will subsequently follow on the request object.
  [<Emit "$0.on('error',$1)">] abstract onError: listener: (Event -> unit) -> IncomingMessage
  [<Emit "$0.once('error',$1)">] abstract onceError: listener: (Event -> unit) -> IncomingMessage
  [<Emit "$0.addListener('error',$1)">] abstract addListenerError: listener: (Event -> unit) -> IncomingMessage
  [<Emit "$0.removeListener('error',$1)">] abstract removeListenerError: listener: (Event -> unit) -> IncomingMessage
  abstract headers: obj option with get, set
  abstract httpVersion: string with get, set
  abstract httpVersionMajor: int with get, set
  abstract httpVersionMinor: int with get, set
  abstract statusCode: int with get, set
  abstract statusMessage: string with get, set

type IOCounters =
  /// Then number of I/O other operations.
  abstract otherOperationCount: float with get, set
  /// Then number of I/O other transfers.
  abstract otherTransferCount: float with get, set
  /// The number of I/O read operations.
  abstract readOperationCount: float with get, set
  /// The number of I/O read transfers.
  abstract readTransferCount: float with get, set
  /// The number of I/O write operations.
  abstract writeOperationCount: float with get, set
  /// The number of I/O write transfers.
  abstract writeTransferCount: float with get, set

type IpcMain =
  inherit EventEmitter<IpcMain>
  /// Listens to channel, when a new message arrives listener would be called with
  /// listener(event, args...).
  abstract on: channel: string * listener: (IpcMainEvent -> obj [] -> unit) -> IpcMain
  /// Adds a one time listener (Event -> unit) for the event. This listener is invoked only
  /// the next time a message is sent to channel, after which it is removed.
  abstract once: channel: string * listener: (IpcMainEvent -> obj [] -> unit) -> IpcMain
  /// Removes listeners of the specified channel.
  abstract removeAllListeners: channel: string -> IpcMain
  /// Removes the specified listener from the listener array for the specified
  /// channel.
  abstract removeListener: channel: string * listener: (IpcMainEvent -> obj [] -> unit) -> IpcMain

type IpcRenderer =
  inherit EventEmitter<IpcRenderer>
  /// Listens to channel, when a new message arrives listener would be called with
  /// listener(event, args...).
  abstract on: channel: string * listener: (Event -> unit) -> IpcRenderer
  /// Adds a one time listener (Event -> unit) for the event. This listener is invoked only
  /// the next time a message is sent to channel, after which it is removed.
  abstract once: channel: string * listener: (Event -> unit) -> IpcRenderer
  /// Removes all listeners, or those of the specified channel.
  abstract removeAllListeners: channel: string -> IpcRenderer
  /// Removes the specified listener from the listener array for the specified
  /// channel.
  abstract removeListener: channel: string * listener: (Event -> unit) -> IpcRenderer
  /// Send a message to the main process asynchronously via channel, you can also send
  /// arbitrary arguments. Arguments will be serialized in JSON internally and hence
  /// no (Event -> unit)s or prototype chain will be included. The main process handles it by
  /// listening for channel with ipcMain module.
  abstract send: channel: string * [<ParamArray>] args: obj [] -> unit
  /// Send a message to the main process synchronously via channel, you can also send
  /// arbitrary arguments. Arguments will be serialized in JSON internally and hence
  /// no (Event -> unit)s or prototype chain will be included. The main process handles it by
  /// listening for channel with ipcMain module, and replies by setting
  /// event.returnValue. Note: Sending a synchronous message will block the whole
  /// renderer process, unless you know what you are doing you should never use it.
  abstract sendSync: channel: string * [<ParamArray>] args: obj [] -> obj option
  /// Sends a message to a window with webContentsId via channel.
  abstract sendTo: webContentsId: int * channel: string * [<ParamArray>] args: obj [] -> unit
  /// Like ipcRenderer.send but the event will be sent to the <webview> element in the
  /// host page instead of the main process.
  abstract sendToHost: channel: string * [<ParamArray>] args: obj [] -> unit

[<StringEnum; RequireQualifiedAccess>]
type JumpListCategoryType =
  | Tasks
  | Frequent
  | Recent
  | Custom

type JumpListCategory =
  /// Array of objects if type is tasks or custom, otherwise it should be omitted.
  abstract items: JumpListItem [] with get, set
  /// Must be set if type is custom, otherwise it should be omitted.
  abstract name: string with get, set
  /// One of the following:
  abstract ``type``: JumpListCategoryType with get, set

[<StringEnum; RequireQualifiedAccess>]
type JumpListItemType =
  | Task
  | Separator
  | File

type JumpListItem =
  /// The command line arguments when program is executed. Should only be set if type
  /// is task.
  abstract args: string option with get, set
  /// Description of the task (displayed in a tooltip). Should only be set if type is
  /// task.
  abstract description: string option with get, set
  /// The index of the icon in the resource file. If a resource file contains multiple
  /// icons this value can be used to specify the zero-based index of the icon that
  /// should be displayed for this task. If a resource file contains only one icon,
  /// this property should be set to zero.
  abstract iconIndex: int option with get, set
  /// The absolute path to an icon to be displayed in a Jump List, which can be an
  /// arbitrary resource file that contains an icon (e.g. .ico, .exe, .dll). You can
  /// usually specify process.execPath to show the program icon.
  abstract iconPath: string option with get, set
  /// Path of the file to open, should only be set if type is file.
  abstract path: string option with get, set
  /// Path of the program to execute, usually you should specify process.execPath
  /// which opens the current program. Should only be set if type is task.
  abstract program: string option with get, set
  /// The text to be displayed for the item in the Jump List. Should only be set if
  /// type is task.
  abstract title: string option with get, set
  /// One of the following:
  abstract ``type``: JumpListItemType option with get, set

type MemoryUsageDetails =
  abstract count: int with get, set
  abstract liveSize: float with get, set
  abstract size: float with get, set

type Menu =
  /// Emitted when a popup is closed either manually or with menu.closePopup().
  [<Emit "$0.on('menu-will-close',$1)">] abstract onMenuWillClose: listener: (Event -> unit) -> Menu
  [<Emit "$0.once('menu-will-close',$1)">] abstract onceMenuWillClose: listener: (Event -> unit) -> Menu
  [<Emit "$0.addListener('menu-will-close',$1)">] abstract addListenerMenuWillClose: listener: (Event -> unit) -> Menu
  [<Emit "$0.removeListener('menu-will-close',$1)">] abstract removeListenerMenuWillClose: listener: (Event -> unit) -> Menu
  /// Emitted when menu.popup() is called.
  [<Emit "$0.on('menu-will-show',$1)">] abstract onMenuWillShow: listener: (Event -> unit) -> Menu
  [<Emit "$0.once('menu-will-show',$1)">] abstract onceMenuWillShow: listener: (Event -> unit) -> Menu
  [<Emit "$0.addListener('menu-will-show',$1)">] abstract addListenerMenuWillShow: listener: (Event -> unit) -> Menu
  [<Emit "$0.removeListener('menu-will-show',$1)">] abstract removeListenerMenuWillShow: listener: (Event -> unit) -> Menu
  /// Appends the menuItem to the menu.
  abstract append: menuItem: MenuItem -> unit
  /// Closes the context menu in the browserWindow.
  abstract closePopup: ?browserWindow: BrowserWindow -> unit
  abstract getMenuItemById: id: string -> MenuItem
  /// Inserts the menuItem to the pos position of the menu.
  abstract insert: pos: int * menuItem: MenuItem -> unit
  /// Pops up this menu as a context menu in the BrowserWindow.
  abstract popup: ?options: PopupOptions -> unit
  abstract items: MenuItem [] with get, set

type MenuStatic =
  [<EmitConstructor>] abstract Create: unit -> Menu
  /// Generally, the template is an array of options for constructing a MenuItem. The
  /// usage can be referenced above. You can also attach other fields to the element
  /// of the template and they will become properties of the constructed menu items.
  abstract buildFromTemplate: template: U2<MenuItemOptions, MenuItem> [] -> Menu
  /// Note: The returned Menu instance doesn't support dynamic addition or removal of
  /// menu items. Instance properties can still be dynamically modified.
  abstract getApplicationMenu: unit -> Menu option
  /// Sends the action to the first responder of application. This is used for
  /// emulating default macOS menu behaviors. Usually you would use the role property
  /// of a MenuItem. See the macOS Cocoa Event Handling Guide for more information on
  /// macOS' native actions.
  abstract sendActionToFirstResponder: action: string -> unit
  /// Sets menu as the application menu on macOS. On Windows and Linux, the menu will
  /// be set as each window's top menu. Also on Windows and Linux, you can use a & in
  /// the top-level item name to indicate which letter should get a generated
  /// accelerator. For example, using &File for the file menu would result in a
  /// generated Alt-F accelerator that opens the associated menu. The indicated
  /// character in the button label gets an underline. The & character is not
  /// displayed on the button label. Passing null will suppress the default menu. On
  /// Windows and Linux, this has the additional effect of removing the menu bar from
  /// the window. Note: The default menu will be created automatically if the app does
  /// not set one. It contains standard items such as File, Edit, View, Window and
  /// Help.
  abstract setApplicationMenu: menu: Menu option -> unit

type MenuItem =
  abstract ``checked``: bool with get, set
  abstract click: (Event -> unit) with get, set
  abstract enabled: bool with get, set
  abstract label: string with get, set
  abstract visible: bool with get, set

type MenuItemStatic =
  [<EmitConstructor>] abstract Create: options: MenuItemOptions -> MenuItem

type MimeTypedBuffer =
  /// The actual Buffer content.
  abstract data: Buffer with get, set
  /// The mimeType of the Buffer that you are sending.
  abstract mimeType: string with get, set

type NativeImage =
  /// Add an image representation for a specific scale factor. This can be used to
  /// explicitly add different scale factor representations to an image. This can be
  /// called on empty images.
  abstract addRepresentation: options: NativeImageRepresentationOptions -> unit
  abstract crop: rect: Rectangle -> NativeImage
  abstract getAspectRatio: unit -> float
  /// The difference between getBitmap() and toBitmap() is, getBitmap() does not copy
  /// the bitmap data, so you have to use the returned Buffer immediately in current
  /// event loop tick, otherwise the data might be changed or destroyed.
  abstract getBitmap: ?options: BitmapOptions -> Buffer
  /// Notice that the returned pointer is a weak pointer to the underlying native
  /// image instead of a copy, so you must ensure that the associated nativeImage
  /// instance is kept around.
  abstract getNativeHandle: unit -> Buffer
  abstract getSize: unit -> Size
  abstract isEmpty: unit -> bool
  abstract isTemplateImage: unit -> bool
  /// If only the height or the width are specified then the current aspect ratio will
  /// be preserved in the resized image.
  abstract resize: options: ResizeOptions -> NativeImage
  /// Marks the image as a template image.
  abstract setTemplateImage: option: bool -> unit
  abstract toBitmap: ?options: ToBitmapOptions -> Buffer
  abstract toDataURL: ?options: ToDataURLOptions -> string
  abstract toJPEG: quality: int -> Buffer
  abstract toPNG: ?options: ToPNGOptions -> Buffer

type NativeImageStatic =
  /// Creates an empty NativeImage instance.
  abstract createEmpty: unit -> NativeImage
  /// Creates a new NativeImage instance from buffer.
  abstract createFromBuffer: buffer: Buffer * ?options: NativeImageFromBufferOptions -> NativeImage
  /// Creates a new NativeImage instance from dataURL.
  abstract createFromDataURL: dataURL: string -> NativeImage
  /// Creates a new NativeImage instance from the NSImage that maps to the given image
  /// name. See NSImageName for a list of possible values. The hslShift is applied to
  /// the image with the following rules This means that [-1, 0, 1] will make the
  /// image completely white and [-1, 1, 0] will make the image completely black. In
  /// some cases, the NSImageName doesn't match its string representation; one example
  /// of this is NSFolderImageName, whose string representation would actually be
  /// NSFolder. Therefore, you'll need to determine the correct string representation
  /// for your image before passing it in. This can be done with the following: echo
  /// -e '#import <Cocoa/Cocoa.h>\nint main() { NSLog(@"%@", SYSTEM_IMAGE_NAME); }' |
  /// clang -otest -x objective-c -framework Cocoa - && ./test where SYSTEM_IMAGE_NAME
  /// should be replaced with any value from this list.
  abstract createFromNamedImage: imageName: string * hslShift: float * float * float -> NativeImage
  /// Creates a new NativeImage instance from a file located at path. This method
  /// returns an empty image if the path does not exist, cannot be read, or is not a
  /// valid image.
  abstract createFromPath: path: string -> NativeImage

type Net =
  inherit EventEmitter<Net>
  /// Creates a ClientRequest instance using the provided options which are directly
  /// forwarded to the ClientRequest constructor. The net.request method would be used
  /// to issue both secure and insecure HTTP requests according to the specified
  /// protocol scheme in the options object.
  abstract request: options: U2<ClientRequestOptions, string> -> ClientRequest

type NetLog =
  inherit EventEmitter<NetLog>
  /// Starts recording network events to path.
  abstract startLogging: path: string -> unit
  /// Stops recording network events. If not called, net logging will automatically
  /// end when app quits.
  abstract stopLogging: ?callback: (string -> unit) -> unit
  /// A Boolean property that indicates whether network logs are recorded.
  abstract currentlyLogging: bool with get, set
  /// A String property that returns the path to the current log file.
  abstract currentlyLoggingPath: string option with get, set

type Notification =
  inherit EventEmitter<Notification>
  [<Emit "$0.on('action',$1)">] abstract onAction: listener: (Event -> int -> unit) -> Notification
  [<Emit "$0.once('action',$1)">] abstract onceAction: listener: (Event -> int -> unit) -> Notification
  [<Emit "$0.addListener('action',$1)">] abstract addListenerAction: listener: (Event -> int -> unit) -> Notification
  [<Emit "$0.removeListener('action',$1)">] abstract removeListenerAction: listener: (Event -> int -> unit) -> Notification
  /// Emitted when the notification is clicked by the user.
  [<Emit "$0.on('click',$1)">] abstract onClick: listener: (Event -> unit) -> Notification
  [<Emit "$0.once('click',$1)">] abstract onceClick: listener: (Event -> unit) -> Notification
  [<Emit "$0.addListener('click',$1)">] abstract addListenerClick: listener: (Event -> unit) -> Notification
  [<Emit "$0.removeListener('click',$1)">] abstract removeListenerClick: listener: (Event -> unit) -> Notification
  /// Emitted when the notification is closed by manual intervention from the user.
  /// This event is not guaranteed to be emitted in all cases where the notification
  /// is closed.
  [<Emit "$0.on('close',$1)">] abstract onClose: listener: (Event -> unit) -> Notification
  [<Emit "$0.once('close',$1)">] abstract onceClose: listener: (Event -> unit) -> Notification
  [<Emit "$0.addListener('close',$1)">] abstract addListenerClose: listener: (Event -> unit) -> Notification
  [<Emit "$0.removeListener('close',$1)">] abstract removeListenerClose: listener: (Event -> unit) -> Notification
  /// Emitted when the user clicks the "Reply" button on a notification with hasReply:
  /// true.
  [<Emit "$0.on('reply',$1)">] abstract onReply: listener: (Event -> string -> unit) -> Notification
  [<Emit "$0.once('reply',$1)">] abstract onceReply: listener: (Event -> string -> unit) -> Notification
  [<Emit "$0.addListener('reply',$1)">] abstract addListenerReply: listener: (Event -> string -> unit) -> Notification
  [<Emit "$0.removeListener('reply',$1)">] abstract removeListenerReply: listener: (Event -> string -> unit) -> Notification
  /// Emitted when the notification is shown to the user, note this could be fired
  /// multiple times as a notification can be shown multiple times through the show()
  /// method.
  [<Emit "$0.on('show',$1)">] abstract onShow: listener: (Event -> unit) -> Notification
  [<Emit "$0.once('show',$1)">] abstract onceShow: listener: (Event -> unit) -> Notification
  [<Emit "$0.addListener('show',$1)">] abstract addListenerShow: listener: (Event -> unit) -> Notification
  [<Emit "$0.removeListener('show',$1)">] abstract removeListenerShow: listener: (Event -> unit) -> Notification
  /// Dismisses the notification.
  abstract close: unit -> unit
  /// Immediately shows the notification to the user, please note this means unlike
  /// the HTML5 Notification implementation, instantiating a new Notification does not
  /// immediately show it to the user, you need to call this method before the OS will
  /// display it. If the notification has been shown before, this method will dismiss
  /// the previously shown notification and create a new one with identical
  /// properties.
  abstract show: unit -> unit

type NotificationStatic =
  [<EmitConstructor>] abstract Create: options: NotificationOptions -> Notification
  abstract isSupported: unit -> bool

type NotificationAction =
  /// The label for the given action.
  abstract text: string with get, set
  /// The type of action, can be button.
  abstract ``type``: string with get, set

type Point =
  abstract x: int with get, set
  abstract y: int with get, set

type PowerMonitor =
  inherit EventEmitter<PowerMonitor>
  /// Emitted when the system is about to lock the screen.
  [<Emit "$0.on('lock-screen',$1)">] abstract onLockScreen: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.once('lock-screen',$1)">] abstract onceLockScreen: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.addListener('lock-screen',$1)">] abstract addListenerLockScreen: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.removeListener('lock-screen',$1)">] abstract removeListenerLockScreen: listener: (Event -> unit) -> PowerMonitor
  /// Emitted when the system changes to AC power.
  [<Emit "$0.on('on-ac',$1)">] abstract onOnAc: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.once('on-ac',$1)">] abstract onceOnAc: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.addListener('on-ac',$1)">] abstract addListenerOnAc: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.removeListener('on-ac',$1)">] abstract removeListenerOnAc: listener: (Event -> unit) -> PowerMonitor
  /// Emitted when system changes to battery power.
  [<Emit "$0.on('on-battery',$1)">] abstract onOnBattery: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.once('on-battery',$1)">] abstract onceOnBattery: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.addListener('on-battery',$1)">] abstract addListenerOnBattery: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.removeListener('on-battery',$1)">] abstract removeListenerOnBattery: listener: (Event -> unit) -> PowerMonitor
  /// Emitted when system is resuming.
  [<Emit "$0.on('resume',$1)">] abstract onResume: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.once('resume',$1)">] abstract onceResume: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.addListener('resume',$1)">] abstract addListenerResume: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.removeListener('resume',$1)">] abstract removeListenerResume: listener: (Event -> unit) -> PowerMonitor
  /// Emitted when the system is about to reboot or shut down. If the event handler
  /// invokes e.preventDefault(), Electron will attempt to delay system shutdown in
  /// order for the app to exit cleanly. If e.preventDefault() is called, the app
  /// should exit as soon as possible by calling something like app.quit().
  [<Emit "$0.on('shutdown',$1)">] abstract onShutdown: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.once('shutdown',$1)">] abstract onceShutdown: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.addListener('shutdown',$1)">] abstract addListenerShutdown: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.removeListener('shutdown',$1)">] abstract removeListenerShutdown: listener: (Event -> unit) -> PowerMonitor
  /// Emitted when the system is suspending.
  [<Emit "$0.on('suspend',$1)">] abstract onSuspend: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.once('suspend',$1)">] abstract onceSuspend: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.addListener('suspend',$1)">] abstract addListenerSuspend: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.removeListener('suspend',$1)">] abstract removeListenerSuspend: listener: (Event -> unit) -> PowerMonitor
  /// Emitted as soon as the systems screen is unlocked.
  [<Emit "$0.on('unlock-screen',$1)">] abstract onUnlockScreen: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.once('unlock-screen',$1)">] abstract onceUnlockScreen: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.addListener('unlock-screen',$1)">] abstract addListenerUnlockScreen: listener: (Event -> unit) -> PowerMonitor
  [<Emit "$0.removeListener('unlock-screen',$1)">] abstract removeListenerUnlockScreen: listener: (Event -> unit) -> PowerMonitor

[<StringEnum; RequireQualifiedAccess>]
type PowerSaveBlockerType =
  | [<CompiledName("prevent-app-suspension")>] PreventAppSuspension
  | [<CompiledName("prevent-display-sleep")>] PreventDisplaySleep

type PowerSaveBlocker =
  inherit EventEmitter<PowerSaveBlocker>
  abstract isStarted: id: int -> bool
  /// Starts preventing the system from entering lower-power mode. Returns an integer
  /// identifying the power save blocker. Note: prevent-display-sleep has higher
  /// precedence over prevent-app-suspension. Only the highest precedence type takes
  /// effect. In other words, prevent-display-sleep always takes precedence over
  /// prevent-app-suspension. For example, an API calling A requests for
  /// prevent-app-suspension, and another calling B requests for
  /// prevent-display-sleep. prevent-display-sleep will be used until B stops its
  /// request. After that, prevent-app-suspension is used.
  abstract start: ``type``: PowerSaveBlockerType -> int
  /// Stops the specified power save blocker.
  abstract stop: id: int -> unit

type PrinterInfo =
  abstract description: string with get, set
  abstract isDefault: bool with get, set
  abstract name: string with get, set
  abstract status: int with get, set

type ProcessMetric =
  /// CPU usage of the process.
  abstract cpu: CPUUsage with get, set
  /// Process id of the process.
  abstract pid: int with get, set
  /// Process type (Browser or Tab or GPU etc).
  abstract ``type``: string with get, set

type Product =
  /// The total size of the content, in bytes.
  abstract contentLengths: int [] with get, set
  /// A string that identifies the version of the content.
  abstract contentVersion: string with get, set
  /// A Boolean value that indicates whether the App Store has downloadable content
  /// for this product.
  abstract downloadable: bool with get, set
  /// The locale formatted price of the product.
  abstract formattedPrice: string with get, set
  /// A description of the product.
  abstract localizedDescription: string with get, set
  /// The name of the product.
  abstract localizedTitle: string with get, set
  /// The cost of the product in the local currency.
  abstract price: float with get, set
  /// The string that identifies the product to the Apple App Store.
  abstract productIdentifier: string with get, set

type Protocol =
  inherit EventEmitter<Protocol>
  /// Intercepts scheme protocol and uses handler as the protocol's new handler which
  /// sends a Buffer as a response.
  abstract interceptBufferProtocol: scheme: string * handler: (InterceptBufferProtocolRequest -> (Buffer -> unit) -> unit) * ?completion: (Error -> unit) -> unit
  /// Intercepts scheme protocol and uses handler as the protocol's new handler which
  /// sends a file as a response.
  abstract interceptFileProtocol: scheme: string * handler: (InterceptFileProtocolRequest -> (string -> unit) -> unit) * ?completion: (Error -> unit) -> unit
  /// Intercepts scheme protocol and uses handler as the protocol's new handler which
  /// sends a new HTTP request as a response.
  abstract interceptHttpProtocol: scheme: string * handler: (InterceptHttpProtocolRequest -> (RedirectRequest -> unit) -> unit) * ?completion: (Error -> unit) -> unit
  /// Same as protocol.registerStreamProtocol, except that it replaces an existing
  /// protocol handler.
  abstract interceptStreamProtocol: scheme: string * handler: (InterceptStreamProtocolRequest -> (U2<Node.Stream.Readable<'a>, StreamProtocolResponse<'a>> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
  /// Intercepts scheme protocol and uses handler as the protocol's new handler which
  /// sends a String as a response.
  abstract interceptStringProtocol: scheme: string * handler: (InterceptStringProtocolRequest -> (string -> unit) -> unit) * ?completion: (Error -> unit) -> unit
  /// The callback will be called with a boolean that indicates whether there is
  /// already a handler for scheme. Deprecated Soon
  abstract isProtocolHandled: scheme: string * callback: (bool -> unit) -> unit
  abstract isProtocolHandled: scheme: string -> Promise<bool>
  /// Registers a protocol of scheme that will send a Buffer as a response. The usage
  /// is the same with registerFileProtocol, except that the callback should be called
  /// with either a Buffer object or an object that has the data, mimeType, and
  /// charset properties. Example:
  abstract registerBufferProtocol: scheme: string * handler: (RegisterBufferProtocolRequest -> (U2<Buffer, MimeTypedBuffer> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
  /// Registers a protocol of scheme that will send the file as a response. The
  /// handler will be called with handler(request, callback) when a request is going
  /// to be created with scheme. completion will be called with completion(null) when
  /// scheme is successfully registered or completion(error) when failed. To handle
  /// the request, the callback should be called with either the file's path or an
  /// object that has a path property, e.g. callback(filePath) or callback({ path:
  /// filePath }). The object may also have a headers property which gives a map of
  /// headers to values for the response headers, e.g. callback({ path: filePath,
  /// headers: {"Content-Security-Policy": "default-src 'none'"]}). When callback is
  /// called with nothing, a number, or an object that has an error property, the
  /// request will fail with the error number you specified. For the available error
  /// numbers you can use, please see the net error list. By default the scheme is
  /// treated like http:, which is parsed differently than protocols that follow the
  /// "generic URI syntax" like file:, so you probably want to call
  /// protocol.registerStandardSchemes to have your scheme treated as a standard
  /// scheme.
  abstract registerFileProtocol: scheme: string * handler: (RegisterFileProtocolRequest -> (string -> unit) -> unit) * ?completion: (Error -> unit) -> unit
  /// Registers a protocol of scheme that will send an HTTP request as a response. The
  /// usage is the same with registerFileProtocol, except that the callback should be
  /// called with a redirectRequest object that has the url, method, referrer,
  /// uploadData and session properties. By default the HTTP request will reuse the
  /// current session. If you want the request to have a different session you should
  /// set session to null. For POST requests the uploadData object must be provided.
  abstract registerHttpProtocol: scheme: string * handler: (RegisterHttpProtocolRequest -> (RedirectRequest -> unit) -> unit) * ?completion: (Error -> unit) -> unit
  /// Note: This method can only be used before the ready event of the app module gets
  /// emitted and can be called only once. Registers the scheme as standard, secure,
  /// bypasses content security policy for resources, allows registering ServiceWorker
  /// and supports fetch API. Specify a privilege with the value of true to enable the
  /// capability. An example of registering a privileged scheme, with bypassing
  /// Content Security Policy: A standard scheme adheres to what RFC 3986 calls
  /// generic URI syntax. For example http and https are standard schemes, while file
  /// is not. Registering a scheme as standard, will allow relative and absolute
  /// resources to be resolved correctly when served. Otherwise the scheme will behave
  /// like the file protocol, but without the ability to resolve relative URLs. For
  /// example when you load following page with custom protocol without registering it
  /// as standard scheme, the image will not be loaded because non-standard schemes
  /// can not recognize relative URLs: Registering a scheme as standard will allow
  /// access to files through the FileSystem API. Otherwise the renderer will throw a
  /// security error for the scheme. By default web storage apis (localStorage,
  /// sessionStorage, webSQL, indexedDB, cookies) are disabled for non standard
  /// schemes. So in general if you want to register a custom protocol to replace the
  /// http protocol, you have to register it as a standard scheme.
  abstract registerSchemesAsPrivileged: customSchemes: CustomScheme [] -> unit
  /// Registers a protocol of scheme that will send a Readable as a response. The
  /// usage is similar to the other register{Any}Protocol, except that the callback
  /// should be called with either a Readable object or an object that has the data,
  /// statusCode, and headers properties. Example: It is possible to pass any object
  /// that implements the readable stream API (emits data/end/error events). For
  /// example, here's how a file could be returned:
  abstract registerStreamProtocol: scheme: string * handler: (RegisterStreamProtocolRequest -> (U2<Node.Stream.Readable<'a>, StreamProtocolResponse<'a>> -> unit) -> unit) * ?completion: (Error -> unit) -> unit
  /// Registers a protocol of scheme that will send a String as a response. The usage
  /// is the same with registerFileProtocol, except that the callback should be called
  /// with either a String or an object that has the data, mimeType, and charset
  /// properties.
  abstract registerStringProtocol: scheme: string * handler: (RegisterStringProtocolRequest -> (string -> unit) -> unit) * ?completion: (Error -> unit) -> unit
  /// Remove the interceptor installed for scheme and restore its original handler.
  abstract uninterceptProtocol: scheme: string * ?completion: (Error -> unit) -> unit
  /// Unregisters the custom protocol of scheme.
  abstract unregisterProtocol: scheme: string * ?completion: (Error -> unit) -> unit

type Rectangle =
  /// The height of the rectangle.
  abstract height: int with get, set
  /// The width of the rectangle.
  abstract width: int with get, set
  /// The x coordinate of the origin of the rectangle.
  abstract x: int with get, set
  /// The y coordinate of the origin of the rectangle.
  abstract y: int with get, set

[<StringEnum; RequireQualifiedAccess>]
type ReferrerPolicy =
  | Default
  | [<CompiledName("unsafe-url")>] UnsafeUrl
  | [<CompiledName("no-referrer-when-downgrade")>] NoReferrerWhenDowngrade
  | [<CompiledName("no-referrer")>] NoReferrer
  | Origin
  | [<CompiledName("strict-origin-when-cross-origin")>] StrictOriginWhenCrossOrigin
  | [<CompiledName("same-origin")>] SameOrigin
  | [<CompiledName("strict-origin")>] StrictOrigin

type Referrer =
  /// Can be default, unsafe-url, no-referrer-when-downgrade, no-referrer, origin,
  /// strict-origin-when-cross-origin, same-origin or strict-origin. See the for more
  /// details on the meaning of these values.
  abstract policy: ReferrerPolicy with get, set
  /// HTTP Referrer URL.
  abstract url: string with get, set

type Remote =
  inherit MainInterface
  abstract getCurrentWebContents: unit -> WebContents
  /// Note: Do not use removeAllListeners on BrowserWindow. Use of this can remove all
  /// blur listeners, disable click events on touch bar buttons, and other unintended
  /// consequences.
  abstract getCurrentWindow: unit -> BrowserWindow
  abstract getGlobal: name: string -> obj option
  /// e.g.
  abstract require: ``module``: string -> obj option
  /// The process object in the main process. This is the same as
  /// remote.getGlobal('process') but is cached.
  abstract ``process``: NodeExtensions.Process with get, set

type RemoveClientCertificate =
  /// Origin of the server whose associated client certificate must be removed from
  /// the cache.
  abstract origin: string with get, set
  /// clientCertificate.
  abstract ``type``: string with get, set

[<StringEnum; RequireQualifiedAccess>]
type RemovePasswordScheme =
  | Basic
  | Digest
  | Ntlm
  | Negotiate

type RemovePassword =
  /// When provided, the authentication info related to the origin will only be
  /// removed otherwise the entire cache will be cleared.
  abstract origin: string with get, set
  /// Credentials of the authentication. Must be provided if removing by origin.
  abstract password: string with get, set
  /// Realm of the authentication. Must be provided if removing by origin.
  abstract realm: string with get, set
  /// Scheme of the authentication. Can be basic, digest, ntlm, negotiate. Must be
  /// provided if removing by origin.
  abstract scheme: RemovePasswordScheme with get, set
  /// password.
  abstract ``type``: string with get, set
  /// Credentials of the authentication. Must be provided if removing by origin.
  abstract username: string with get, set

type Screen =
  inherit EventEmitter<Screen>
  /// Emitted when newDisplay has been added.
  [<Emit "$0.on('display-added',$1)">] abstract onDisplayAdded: listener: (Event -> Display -> unit) -> Screen
  [<Emit "$0.once('display-added',$1)">] abstract onceDisplayAdded: listener: (Event -> Display -> unit) -> Screen
  [<Emit "$0.addListener('display-added',$1)">] abstract addListenerDisplayAdded: listener: (Event -> Display -> unit) -> Screen
  [<Emit "$0.removeListener('display-added',$1)">] abstract removeListenerDisplayAdded: listener: (Event -> Display -> unit) -> Screen
  /// Emitted when one or more metrics change in a display. The changedMetrics is an
  /// array of strings that describe the changes. Possible changes are bounds,
  /// workArea, scaleFactor and rotation.
  [<Emit "$0.on('display-metrics-changed',$1)">] abstract onDisplayMetricsChanged: listener: (Event -> Display -> string [] -> unit) -> Screen
  [<Emit "$0.once('display-metrics-changed',$1)">] abstract onceDisplayMetricsChanged: listener: (Event -> Display -> string [] -> unit) -> Screen
  [<Emit "$0.addListener('display-metrics-changed',$1)">] abstract addListenerDisplayMetricsChanged: listener: (Event -> Display -> string [] -> unit) -> Screen
  [<Emit "$0.removeListener('display-metrics-changed',$1)">] abstract removeListenerDisplayMetricsChanged: listener: (Event -> Display -> string [] -> unit) -> Screen
  /// Emitted when oldDisplay has been removed.
  [<Emit "$0.on('display-removed',$1)">] abstract onDisplayRemoved: listener: (Event -> Display -> unit) -> Screen
  [<Emit "$0.once('display-removed',$1)">] abstract onceDisplayRemoved: listener: (Event -> Display -> unit) -> Screen
  [<Emit "$0.addListener('display-removed',$1)">] abstract addListenerDisplayRemoved: listener: (Event -> Display -> unit) -> Screen
  [<Emit "$0.removeListener('display-removed',$1)">] abstract removeListenerDisplayRemoved: listener: (Event -> Display -> unit) -> Screen
  /// Converts a screen DIP point to a screen physical point. The DPI scale is
  /// performed relative to the display containing the DIP point.
  abstract dipToScreenPoint: point: Point -> Point
  /// Converts a screen DIP rect to a screen physical rect. The DPI scale is performed
  /// relative to the display nearest to window. If window is null, scaling will be
  /// performed to the display nearest to rect.
  abstract dipToScreenRect: window: BrowserWindow option * rect: Rectangle -> Rectangle
  abstract getAllDisplays: unit -> Display []
  /// The current absolute position of the mouse pointer.
  abstract getCursorScreenPoint: unit -> Point
  abstract getDisplayMatching: rect: Rectangle -> Display
  abstract getDisplayNearestPoint: point: Point -> Display
  abstract getPrimaryDisplay: unit -> Display
  /// Converts a screen physical point to a screen DIP point. The DPI scale is
  /// performed relative to the display containing the physical point.
  abstract screenToDipPoint: point: Point -> Point
  /// Converts a screen physical rect to a screen DIP rect. The DPI scale is performed
  /// relative to the display nearest to window. If window is null, scaling will be
  /// performed to the display nearest to rect.
  abstract screenToDipRect: window: BrowserWindow option * rect: Rectangle -> Rectangle

type ScrubberItem =
  /// The image to appear in this item.
  abstract icon: NativeImage option with get, set
  /// The text to appear in this item.
  abstract label: string option with get, set

type SegmentedControlSegment =
  /// Whether this segment is selectable. Default: true.
  abstract enabled: bool option with get, set
  /// The image to appear in this segment.
  abstract icon: NativeImage option with get, set
  /// The text to appear in this segment.
  abstract label: string option with get, set

type Session =
  inherit EventEmitter<Session>
  /// Emitted when Electron is about to download item in webContents. Calling
  /// event.preventDefault() will cancel the download and item will not be available
  /// from next tick of the process.
  [<Emit "$0.on('will-download',$1)">] abstract onWillDownload: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
  [<Emit "$0.once('will-download',$1)">] abstract onceWillDownload: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
  [<Emit "$0.addListener('will-download',$1)">] abstract addListenerWillDownload: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
  [<Emit "$0.removeListener('will-download',$1)">] abstract removeListenerWillDownload: listener: (Event -> DownloadItem -> WebContents -> unit) -> Session
  /// Dynamically sets whether to always send credentials for HTTP NTLM or Negotiate
  /// authentication.
  abstract allowNTLMCredentialsForDomains: domains: string -> unit
  /// Clears the session’s HTTP authentication cache.
  abstract clearAuthCache: options: U2<RemovePassword, RemoveClientCertificate> * ?callback: (Event -> unit) -> unit
  /// Clears the session’s HTTP cache.
  abstract clearCache: callback: (Event -> unit) -> unit
  /// Clears the host resolver cache.
  abstract clearHostResolverCache: ?callback: (Event -> unit) -> unit
  /// Clears the data of web storages.
  abstract clearStorageData: ?options: ClearStorageDataOptions * ?callback: (Event -> unit) -> unit
  /// Allows resuming cancelled or interrupted downloads from previous Session. The
  /// API will generate a DownloadItem that can be accessed with the will-download
  /// event. The DownloadItem will not have any WebContents associated with it and the
  /// initial state will be interrupted. The download will start only when the resume
  /// API is called on the DownloadItem.
  abstract createInterruptedDownload: options: CreateInterruptedDownloadOptions -> unit
  /// Disables any network emulation already active for the session. Resets to the
  /// original network configuration.
  abstract disableNetworkEmulation: unit -> unit
  /// Emulates network with the given configuration for the session.
  abstract enableNetworkEmulation: options: EnableNetworkEmulationOptions -> unit
  /// Writes any unwritten DOMStorage data to disk.
  abstract flushStorageData: unit -> unit
  abstract getBlobData: identifier: string * callback: (Buffer -> unit) -> unit
  /// Callback is invoked with the session's current cache size.
  abstract getCacheSize: callback: (int -> unit) -> unit
  abstract getPreloads: unit -> string []
  abstract getUserAgent: unit -> string
  /// Resolves the proxy information for url. The callback will be called with
  /// callback(proxy) when the request is performed.
  abstract resolveProxy: url: string * callback: (string -> unit) -> unit
  /// Sets the certificate verify proc for session, the proc will be called with
  /// proc(request, callback) whenever a server certificate verification is requested.
  /// Calling callback(0) accepts the certificate, calling callback(-2) rejects it.
  /// Calling setCertificateVerifyProc(null) will revert back to default certificate
  /// verify proc.
  abstract setCertificateVerifyProc: proc: (CertificateVerifyProcRequest -> (int -> unit) -> unit) -> unit
  /// Sets download saving directory. By default, the download directory will be the
  /// Downloads under the respective app folder.
  abstract setDownloadPath: path: string -> unit
  /// Sets the handler which can be used to respond to permission checks for the
  /// session. Returning true will allow the permission and false will reject it. To
  /// clear the handler, call setPermissionCheckHandler(null).
  abstract setPermissionCheckHandler: handler: (WebContents -> string -> string -> PermissionCheckHandlerDetails -> bool) option -> unit
  /// Sets the handler which can be used to respond to permission requests for the
  /// session. Calling callback(true) will allow the permission and callback(false)
  /// will reject it. To clear the handler, call setPermissionRequestHandler(null).
  abstract setPermissionRequestHandler: handler: (WebContents -> string -> (bool -> unit) -> PermissionRequestHandlerDetails -> unit) option -> unit
  /// Adds scripts that will be executed on ALL web contents that are associated with
  /// this session just before normal preload scripts run.
  abstract setPreloads: preloads: string [] -> unit
  /// Sets the proxy settings. When pacScript and proxyRules are provided together,
  /// the proxyRules option is ignored and pacScript configuration is applied. The
  /// proxyRules has to follow the rules below: For example: The proxyBypassRules is a
  /// comma separated list of rules described below:
  abstract setProxy: config: ProxyConfig * callback: (Event -> unit) -> unit
  /// Overrides the userAgent and acceptLanguages for this session. The
  /// acceptLanguages must a comma separated ordered list of language codes, for
  /// example "en-US,fr,de,ko,zh-CN,ja". This doesn't affect existing WebContents, and
  /// each WebContents can use webContents.setUserAgent to override the session-wide
  /// user agent.
  abstract setUserAgent: userAgent: string * ?acceptLanguages: string -> unit
  abstract cookies: Cookies with get, set
  abstract netLog: NetLog with get, set
  abstract protocol: Protocol with get, set
  abstract webRequest: WebRequest with get, set

type SessionStatic =
  /// If partition starts with persist:, the page will use a persistent session
  /// available to all pages in the app with the same partition. if there is no
  /// persist: prefix, the page will use an in-memory session. If the partition is
  /// empty then default session of the app will be returned. To create a Session with
  /// options, you have to ensure the Session with the partition has never been used
  /// before. There is no way to change the options of an existing Session object.
  abstract fromPartition: partition: string * ?options: FromPartitionOptions -> Session
  /// A Session object, the default session object of the app.
  abstract defaultSession: Session with get, set

[<StringEnum; RequireQualifiedAccess>]
type WriteShortcutLinkOperation =
  | Create
  | Update
  | Replace

type Shell =
  /// Play the beep sound.
  abstract beep: unit -> unit
  /// Move the given file to trash and returns a boolean status for the operation.
  abstract moveItemToTrash: fullPath: string -> bool
  /// Open the given external protocol URL in the desktop's default manner. (For
  /// example, mailto: URLs in the user's default mail agent).
  abstract openExternal: url: string * ?options: OpenExternalOptions -> Promise<unit>
  /// Open the given external protocol URL in the desktop's default manner. (For
  /// example, mailto: URLs in the user's default mail agent).
  abstract openExternalSync: url: string * ?options: OpenExternalOptions -> bool
  /// Open the given file in the desktop's default manner.
  abstract openItem: fullPath: string -> bool
  /// Resolves the shortcut link at shortcutPath. An exception will be thrown when any
  /// error happens.
  abstract readShortcutLink: shortcutPath: string -> ShortcutDetails
  /// Show the given file in a file manager. If possible, select the file.
  abstract showItemInFolder: fullPath: string -> bool
  /// Creates or updates a shortcut link at shortcutPath.
  abstract writeShortcutLink: shortcutPath: string * operation: WriteShortcutLinkOperation * options: ShortcutDetails -> bool
  /// Creates or updates a shortcut link at shortcutPath.
  abstract writeShortcutLink: shortcutPath: string * options: ShortcutDetails -> bool

type ShortcutDetails =
  /// The Application User Model ID. Default is empty.
  abstract appUserModelId: string option with get, set
  /// The arguments to be applied to target when launching from this shortcut. Default
  /// is empty.
  abstract args: string option with get, set
  /// The working directory. Default is empty.
  abstract cwd: string option with get, set
  /// The description of the shortcut. Default is empty.
  abstract description: string option with get, set
  /// The path to the icon, can be a DLL or EXE. icon and iconIndex have to be set
  /// together. Default is empty, which uses the target's icon.
  abstract icon: string option with get, set
  /// The resource ID of icon when icon is a DLL or EXE. Default is 0.
  abstract iconIndex: int option with get, set
  /// The target to launch from this shortcut.
  abstract target: string with get, set

type Size =
  abstract height: int with get, set
  abstract width: int with get, set

type StreamProtocolResponse<'a> =
  /// A Node.js readable stream representing the response body.
  abstract data: Node.Stream.Readable<'a> with get, set
  /// An object containing the response headers.
  abstract headers: obj with get, set
  /// The HTTP response code.
  abstract statusCode: int with get, set

[<StringEnum; RequireQualifiedAccess>]
type SetAppearance =
  | Dark
  | Light

[<StringEnum; RequireQualifiedAccess>]
type GetAppearance =
  | Dark
  | Light
  | Unknown

[<StringEnum; RequireQualifiedAccess>]
type MediaAccessType =
  | Microphone
  | Camera

[<StringEnum; RequireQualifiedAccess>]
type MediaAccessStatus =
  | [<CompiledName("not-determined")>] NotDetermined
  | Granted
  | Denied
  | Restricted
  | Unknown

[<StringEnum; RequireQualifiedAccess>]
type UserDefaultValueType =
  | String
  | Boolean
  | Integer
  | Float
  | Double
  | Url
  | Array
  | Dictionary

[<StringEnum; RequireQualifiedAccess>]
type SystemPrefsColor =
  | [<CompiledName("3d-dark-shadow")>] DarkShadow3D
  | [<CompiledName("3d-face")>] Face3D
  | [<CompiledName("3d-highlight")>] Highlight3D
  | [<CompiledName("3d-light")>] Light3D
  | [<CompiledName("3d-shadow")>] Shadow3D
  | [<CompiledName("active-border")>] ActiveBorder
  | [<CompiledName("active-caption")>] ActiveCaption
  | [<CompiledName("active-caption-gradient")>] ActiveCaptionGradient
  | [<CompiledName("app-workspace")>] AppWorkspace
  | [<CompiledName("button-text")>] ButtonText
  | [<CompiledName("caption-text")>] CaptionText
  | [<CompiledName("desktop")>] Desktop
  | [<CompiledName("disabled-text")>] DisabledText
  | [<CompiledName("highlight-text")>] HighlightText
  | [<CompiledName("hotlight")>] Hotlight
  | [<CompiledName("inactive-border")>] InactiveBorder
  | [<CompiledName("inactive-caption")>] InactiveCaption
  | [<CompiledName("inactive-caption-gradient")>] InactiveCaptionGradient
  | [<CompiledName("inactive-caption-text")>] InactiveCaptionText
  | [<CompiledName("info-background")>] InfoBackground
  | [<CompiledName("info-text")>] InfoText
  | [<CompiledName("menu")>] Menu
  | [<CompiledName("menu-highlight")>] MenuHighlight
  | [<CompiledName("menubar")>] MenuBar
  | [<CompiledName("menu-text")>] MenuText
  | [<CompiledName("scrollbar")>] Scrollbar
  | [<CompiledName("window")>] Window
  | [<CompiledName("window-frame")>] WindowFrame
  | [<CompiledName("window-text")>] WindowText
  | [<CompiledName("alternate-selected-control-text")>] AlternateSelectedControlText
  | [<CompiledName("control-background")>] ControlBackground
  | [<CompiledName("control")>] Control
  | [<CompiledName("control-text")>] ControlText
  | [<CompiledName("disabled-control-text")>] DisabledControlText
  | [<CompiledName("find-highlight")>] FindHighlight
  | [<CompiledName("grid")>] Grid
  | [<CompiledName("header-text")>] HeaderText
  | [<CompiledName("highlight")>] Highlight
  | [<CompiledName("keyboard-focus-indicator")>] KeyboardFocusIndicator
  | [<CompiledName("label")>] Label
  | [<CompiledName("link")>] Link
  | [<CompiledName("placeholder-text")>] PlaceholderText
  | [<CompiledName("quaternary-label")>] QuaternaryLabel
  | [<CompiledName("scrubber-textured-background")>] ScrubberTexturedBackground
  | [<CompiledName("secondary-label")>] SecondaryLabel
  | [<CompiledName("selected-content-background")>] SelectedContentBackground
  | [<CompiledName("selected-control")>] SelectedControl
  | [<CompiledName("selected-control-text")>] SelectedControlText
  | [<CompiledName("selected-menu-item")>] SelectedMenuItem
  | [<CompiledName("selected-text-background")>] SelectedTextBackground
  | [<CompiledName("selected-text")>] SelectedText
  | [<CompiledName("separator")>] Separator
  | [<CompiledName("shadow")>] Shadow
  | [<CompiledName("tertiary-label")>] TertiaryLabel
  | [<CompiledName("text-background")>] TextBackground
  | [<CompiledName("text")>] Text
  | [<CompiledName("under-page-background")>] UnderPageBackground
  | [<CompiledName("unemphasized-selected-content-background")>] UnemphasizedSelectedContentBackground
  | [<CompiledName("unemphasized-selected-text-background")>] UnemphasizedSelectedTextBackground
  | [<CompiledName("unemphasized-selected-text")>] UnemphasizedSelectedText
  | [<CompiledName("window-background")>] WindowBackground
  | [<CompiledName("window-frame-text")>] WindowFrameText

[<StringEnum; RequireQualifiedAccess>]
type SystemPrefsSystemColor =
  | Blue
  | Brown
  | Gray
  | Green
  | Orange
  | Pink
  | Purple
  | Red
  | Yellow

type SystemPreferences =
  inherit EventEmitter<SystemPreferences>
  [<Emit "$0.on('accent-color-changed',$1)">] abstract onAccentColorChanged: listener: (Event -> string -> unit) -> SystemPreferences
  [<Emit "$0.once('accent-color-changed',$1)">] abstract onceAccentColorChanged: listener: (Event -> string -> unit) -> SystemPreferences
  [<Emit "$0.addListener('accent-color-changed',$1)">] abstract addListenerAccentColorChanged: listener: (Event -> string -> unit) -> SystemPreferences
  [<Emit "$0.removeListener('accent-color-changed',$1)">] abstract removeListenerAccentColorChanged: listener: (Event -> string -> unit) -> SystemPreferences
  /// NOTE: This event is only emitted after you have called
  /// startAppLevelAppearanceTrackingOS
  [<Emit "$0.on('appearance-changed',$1)">] abstract onAppearanceChanged: listener: (SetAppearance -> unit) -> SystemPreferences
  [<Emit "$0.once('appearance-changed',$1)">] abstract onceAppearanceChanged: listener: (SetAppearance -> unit) -> SystemPreferences
  [<Emit "$0.addListener('appearance-changed',$1)">] abstract addListenerAppearanceChanged: listener: (SetAppearance -> unit) -> SystemPreferences
  [<Emit "$0.removeListener('appearance-changed',$1)">] abstract removeListenerAppearanceChanged: listener: (SetAppearance -> unit) -> SystemPreferences
  [<Emit "$0.on('color-changed',$1)">] abstract onColorChanged: listener: (Event -> unit) -> SystemPreferences
  [<Emit "$0.once('color-changed',$1)">] abstract onceColorChanged: listener: (Event -> unit) -> SystemPreferences
  [<Emit "$0.addListener('color-changed',$1)">] abstract addListenerColorChanged: listener: (Event -> unit) -> SystemPreferences
  [<Emit "$0.removeListener('color-changed',$1)">] abstract removeListenerColorChanged: listener: (Event -> unit) -> SystemPreferences
  [<Emit "$0.on('high-contrast-color-scheme-changed',$1)">] abstract onHighContrastColorSchemeChanged: listener: (Event -> bool -> unit) -> SystemPreferences
  [<Emit "$0.once('high-contrast-color-scheme-changed',$1)">] abstract onceHighContrastColorSchemeChanged: listener: (Event -> bool -> unit) -> SystemPreferences
  [<Emit "$0.addListener('high-contrast-color-scheme-changed',$1)">] abstract addListenerHighContrastColorSchemeChanged: listener: (Event -> bool -> unit) -> SystemPreferences
  [<Emit "$0.removeListener('high-contrast-color-scheme-changed',$1)">] abstract removeListenerHighContrastColorSchemeChanged: listener: (Event -> bool -> unit) -> SystemPreferences
  [<Emit "$0.on('inverted-color-scheme-changed',$1)">] abstract onInvertedColorSchemeChanged: listener: (Event -> bool -> unit) -> SystemPreferences
  [<Emit "$0.once('inverted-color-scheme-changed',$1)">] abstract onceInvertedColorSchemeChanged: listener: (Event -> bool -> unit) -> SystemPreferences
  [<Emit "$0.addListener('inverted-color-scheme-changed',$1)">] abstract addListenerInvertedColorSchemeChanged: listener: (Event -> bool -> unit) -> SystemPreferences
  [<Emit "$0.removeListener('inverted-color-scheme-changed',$1)">] abstract removeListenerInvertedColorSchemeChanged: listener: (Event -> bool -> unit) -> SystemPreferences
  /// Important: In order to properly leverage this API, you must set the
  /// NSMicrophoneUsageDescription and NSCameraUsageDescription strings in your app's
  /// Info.plist file. The values for these keys will be used to populate the
  /// permission dialogs so that the user will be properly informed as to the purpose
  /// of the permission request. See Electron Application Distribution for more
  /// information about how to set these in the context of Electron. This user consent
  /// was not required until macOS 10.14 Mojave, so this method will always return
  /// true if your system is running 10.13 High Sierra or lower.
  abstract askForMediaAccess: mediaType: MediaAccessType -> Promise<bool>
  /// This API is only available on macOS 10.14 Mojave or newer.
  abstract getAccentColor: unit -> string
  /// Gets the macOS appearance setting that you have declared you want for your
  /// application, maps to NSApplication.appearance. You can use the
  /// setAppLevelAppearance API to set this value.
  abstract getAppLevelAppearance: unit -> GetAppearance
  abstract getColor: color: SystemPrefsColor -> string
  /// Gets the macOS appearance setting that is currently applied to your application,
  /// maps to NSApplication.effectiveAppearance Please note that until Electron is
  /// built targeting the 10.14 SDK, your application's effectiveAppearance will
  /// default to 'light' and won't inherit the OS preference. In the interim in order
  /// for your application to inherit the OS preference you must set the
  /// NSRequiresAquaSystemAppearance key in your apps Info.plist to false.  If you are
  /// using electron-packager or electron-forge just set the enableDarwinDarkMode
  /// packager option to true.  See the Electron Packager API for more details.
  abstract getEffectiveAppearance: unit -> GetAppearance
  /// This user consent was not required until macOS 10.14 Mojave, so this method will
  /// always return granted if your system is running 10.13 High Sierra or lower.
  abstract getMediaAccessStatus: mediaType: string -> MediaAccessStatus
  /// Returns one of several standard system colors that automatically adapt to
  /// vibrancy and changes in accessibility settings like 'Increase contrast' and
  /// 'Reduce transparency'. See Apple Documentation for  more details.
  abstract getSystemColor: color: SystemPrefsSystemColor -> string
  abstract getUserDefault: key: string * ``type``: UserDefaultValueType -> obj option
  /// An example of using it to determine if you should create a transparent window or
  /// not (transparent windows won't work correctly when DWM composition is disabled):
  abstract isAeroGlassEnabled: unit -> bool
  abstract isDarkMode: unit -> bool
  abstract isHighContrastColorScheme: unit -> bool
  abstract isInvertedColorScheme: unit -> bool
  abstract isSwipeTrackingFromScrollEventsEnabled: unit -> bool
  abstract isTrustedAccessibilityClient: prompt: bool -> bool
  /// Posts event as native notifications of macOS. The userInfo is an Object that
  /// contains the user information dictionary sent along with the notification.
  abstract postLocalNotification: event: string * userInfo: obj option -> unit
  /// Posts event as native notifications of macOS. The userInfo is an Object that
  /// contains the user information dictionary sent along with the notification.
  abstract postNotification: event: string * userInfo: obj option * ?deliverImmediately: bool -> unit
  /// Posts event as native notifications of macOS. The userInfo is an Object that
  /// contains the user information dictionary sent along with the notification.
  abstract postWorkspaceNotification: event: string * userInfo: obj option -> unit
  /// Add the specified defaults to your application's NSUserDefaults.
  abstract registerDefaults: defaults: obj option -> unit
  /// Removes the key in NSUserDefaults. This can be used to restore the default or
  /// global value of a key previously set with setUserDefault.
  abstract removeUserDefault: key: string -> unit
  /// Sets the appearance setting for your application, this should override the
  /// system default and override the value of getEffectiveAppearance.
  abstract setAppLevelAppearance: appearance: SetAppearance -> unit
  /// Set the value of key in NSUserDefaults. Note that type should match actual type
  /// of value. An exception is thrown if they don't. Some popular key and types are:
  abstract setUserDefault: key: string * ``type``: UserDefaultValueType * value: string -> unit
  /// Same as subscribeNotification, but uses NSNotificationCenter for local defaults.
  /// This is necessary for events such as NSUserDefaultsDidChangeNotification.
  abstract subscribeLocalNotification: event: string * callback: (string -> obj option -> unit) -> int
  /// Subscribes to native notifications of macOS, callback will be called with
  /// callback(event, userInfo) when the corresponding event happens. The userInfo is
  /// an Object that contains the user information dictionary sent along with the
  /// notification. The id of the subscriber is returned, which can be used to
  /// unsubscribe the event. Under the hood this API subscribes to
  /// NSDistributedNotificationCenter, example values of event are:
  abstract subscribeNotification: event: string * callback: (string -> obj option -> unit) -> int
  /// Same as subscribeNotification, but uses
  /// NSWorkspace.sharedWorkspace.notificationCenter. This is necessary for events
  /// such as NSWorkspaceDidActivateApplicationNotification.
  abstract subscribeWorkspaceNotification: event: string * callback: (string -> obj option -> unit) -> int
  /// Same as unsubscribeNotification, but removes the subscriber from
  /// NSNotificationCenter.
  abstract unsubscribeLocalNotification: id: int -> unit
  /// Removes the subscriber with id.
  abstract unsubscribeNotification: id: int -> unit
  /// Same as unsubscribeNotification, but removes the subscriber from
  /// NSWorkspace.sharedWorkspace.notificationCenter.
  abstract unsubscribeWorkspaceNotification: id: int -> unit

type Task =
  /// The command line arguments when program is executed.
  abstract arguments: string with get, set
  /// Description of this task.
  abstract description: string with get, set
  /// The icon index in the icon file. If an icon file consists of two or more icons,
  /// set this value to identify the icon. If an icon file consists of one icon, this
  /// value is 0.
  abstract iconIndex: int with get, set
  /// The absolute path to an icon to be displayed in a JumpList, which can be an
  /// arbitrary resource file that contains an icon. You can usually specify
  /// process.execPath to show the icon of the program.
  abstract iconPath: string with get, set
  /// Path of the program to execute, usually you should specify process.execPath
  /// which opens the current program.
  abstract program: string with get, set
  /// The string to be displayed in a JumpList.
  abstract title: string with get, set

[<StringEnum; RequireQualifiedAccess>]
type ThumbarButtonFlag =
  | Enabled
  | Disabled
  | [<CompiledName("dismissonclick")>] DismissOnClick
  | [<CompiledName("nobackground")>] NoBackground
  | Hidden
  | [<CompiledName("noninteractive")>] NonInteractive

type ThumbarButton =
  /// The icon showing in thumbnail toolbar.
  abstract icon: NativeImage with get, set
  abstract click: (Event -> unit) with get, set
  /// The text of the button's tooltip.
  abstract tooltip: string option with get, set
  /// Control specific states and behaviors of the button. By default, it is
  /// ['enabled'].
  abstract flags: ThumbarButtonFlag [] with get, set

type ITouchBarItem =
  interface end

type TouchBarButton =
  inherit EventEmitter<TouchBarButton>
  inherit ITouchBarItem
  abstract backgroundColor: string with get, set
  abstract icon: NativeImage with get, set
  abstract label: string with get, set

type TouchBarButtonStatic =
  [<EmitConstructor>] abstract Create: options: TouchBarButtonOptions -> TouchBarButton

type TouchBarColorPicker =
  inherit EventEmitter<TouchBarColorPicker>
  inherit ITouchBarItem
  abstract availableColors: string [] with get, set
  abstract selectedColor: string with get, set

type TouchBarColorPickerStatic =
  [<EmitConstructor>] abstract Create: options: TouchBarColorPickerOptions -> TouchBarColorPicker

type TouchBarGroup =
  inherit EventEmitter<TouchBarGroup>
  inherit ITouchBarItem

type TouchBarGroupStatic =
  [<EmitConstructor>] abstract Create: options: TouchBarGroupOptions -> TouchBarGroup

type TouchBarLabel =
  inherit EventEmitter<TouchBarLabel>
  inherit ITouchBarItem
  abstract label: string with get, set
  abstract textColor: string with get, set

type TouchBarLabelStatic =
  [<EmitConstructor>] abstract Create: options: TouchBarLabelOptions -> TouchBarLabel

type TouchBarPopover =
  inherit EventEmitter<TouchBarPopover>
  inherit ITouchBarItem
  abstract icon: NativeImage with get, set
  abstract label: string with get, set

type TouchBarPopoverStatic =
  [<EmitConstructor>] abstract Create: options: TouchBarPopoverOptions -> TouchBarPopover

type TouchBarScrubber =
  inherit EventEmitter<TouchBarScrubber>
  inherit ITouchBarItem
  abstract continuous: bool with get, set
  abstract items: ScrubberItem [] with get, set
  abstract mode: string with get, set
  abstract overlayStyle: string with get, set
  abstract selectedStyle: string with get, set
  abstract showArrowButtons: bool with get, set

type TouchBarScrubberStatic =
  [<EmitConstructor>] abstract Create: options: TouchBarScrubberOptions -> TouchBarScrubber

type TouchBarSegmentedControl =
  inherit EventEmitter<TouchBarSegmentedControl>
  inherit ITouchBarItem
  abstract segments: SegmentedControlSegment [] with get, set
  abstract segmentStyle: string with get, set
  abstract selectedIndex: int with get, set

type TouchBarSegmentedControlStatic =
  [<EmitConstructor>] abstract Create: options: TouchBarSegmentedControlOptions -> TouchBarSegmentedControl

type TouchBarSlider =
  inherit EventEmitter<TouchBarSlider>
  inherit ITouchBarItem
  abstract label: string with get, set
  abstract maxValue: float with get, set
  abstract minValue: float with get, set
  abstract value: float with get, set

type TouchBarSliderStatic =
  [<EmitConstructor>] abstract Create: options: TouchBarSliderOptions -> TouchBarSlider

type TouchBarSpacer =
  inherit EventEmitter<TouchBarSpacer>
  inherit ITouchBarItem

type TouchBarSpacerStatic =
  [<EmitConstructor>] abstract Create: options: TouchBarSpacerOptions -> TouchBarSpacer

type TouchBar =
  inherit EventEmitter<TouchBar>
  abstract escapeItem: ITouchBarItem with get, set

type TouchBarStatic =
  [<EmitConstructor>] abstract Create: options: TouchBarOptions -> TouchBar
  abstract TouchBarButton: TouchBarButtonStatic with get, set
  abstract TouchBarColorPicker: TouchBarColorPickerStatic with get, set
  abstract TouchBarGroup: TouchBarGroupStatic with get, set
  abstract TouchBarLabel: TouchBarLabelStatic with get, set
  abstract TouchBarPopover: TouchBarPopoverStatic with get, set
  abstract TouchBarScrubber: TouchBarScrubberStatic with get, set
  abstract TouchBarSegmentedControl: TouchBarSegmentedControlStatic with get, set
  abstract TouchBarSlider: TouchBarSliderStatic with get, set
  abstract TouchBarSpacer: TouchBarSpacerStatic with get, set

type TraceCategoriesAndOptions =
  /// – is a filter to control what category groups should be traced. A filter can
  /// have an optional prefix to exclude category groups that contain a matching
  /// category. Having both included and excluded category patterns in the same list
  /// is not supported. Examples: test_MyTest*, test_MyTest*,test_OtherStuff,
  /// -excluded_category1,-excluded_category2.
  abstract categoryFilter: string with get, set
  /// Controls what kind of tracing is enabled, it is a comma-delimited sequence of
  /// the following strings: record-until-full, record-continuously, trace-to-console,
  /// enable-sampling, enable-systrace, e.g. 'record-until-full,enable-sampling'. The
  /// first 3 options are trace recording modes and hence mutually exclusive. If more
  /// than one trace recording modes appear in the traceOptions string, the last one
  /// takes precedence. If none of the trace recording modes are specified, recording
  /// mode is record-until-full. The trace option will first be reset to the default
  /// option (record_mode set to record-until-full, enable_sampling and
  /// enable_systrace set to false) before options parsed from traceOptions are
  /// applied on it.
  abstract traceOptions: string with get, set

type TraceConfig =
  abstract excluded_categories: string [] with get, set
  abstract included_categories: string [] with get, set
  abstract memory_dump_config: obj option with get, set

[<StringEnum; RequireQualifiedAccess>]
type TransactionState =
  | Purchasing
  | Purchased
  | Failed
  | Restored
  | Deferred

type Transaction =
  /// The error code if an error occurred while processing the transaction.
  abstract errorCode: int with get, set
  /// The error message if an error occurred while processing the transaction.
  abstract errorMessage: string with get, set
  /// The identifier of the restored transaction by the App Store.
  abstract originalTransactionIdentifier: string with get, set
  abstract payment: Payment with get, set
  /// The date the transaction was added to the App Store’s payment queue.
  abstract transactionDate: string with get, set
  /// A string that uniquely identifies a successful payment transaction.
  abstract transactionIdentifier: string with get, set
  /// The transaction state, can be purchasing, purchased, failed, restored or
  /// deferred.
  abstract transactionState: TransactionState with get, set

[<StringEnum; RequireQualifiedAccess>]
type HighlightMode =
  | Selection
  | Always
  | Never

type Tray =
  inherit EventEmitter<Tray>
  /// Emitted when the tray balloon is clicked.
  [<Emit "$0.on('balloon-click',$1)">] abstract onBalloonClick: listener: (Event -> unit) -> Tray
  [<Emit "$0.once('balloon-click',$1)">] abstract onceBalloonClick: listener: (Event -> unit) -> Tray
  [<Emit "$0.addListener('balloon-click',$1)">] abstract addListenerBalloonClick: listener: (Event -> unit) -> Tray
  [<Emit "$0.removeListener('balloon-click',$1)">] abstract removeListenerBalloonClick: listener: (Event -> unit) -> Tray
  /// Emitted when the tray balloon is closed because of timeout or user manually
  /// closes it.
  [<Emit "$0.on('balloon-closed',$1)">] abstract onBalloonClosed: listener: (Event -> unit) -> Tray
  [<Emit "$0.once('balloon-closed',$1)">] abstract onceBalloonClosed: listener: (Event -> unit) -> Tray
  [<Emit "$0.addListener('balloon-closed',$1)">] abstract addListenerBalloonClosed: listener: (Event -> unit) -> Tray
  [<Emit "$0.removeListener('balloon-closed',$1)">] abstract removeListenerBalloonClosed: listener: (Event -> unit) -> Tray
  /// Emitted when the tray balloon shows.
  [<Emit "$0.on('balloon-show',$1)">] abstract onBalloonShow: listener: (Event -> unit) -> Tray
  [<Emit "$0.once('balloon-show',$1)">] abstract onceBalloonShow: listener: (Event -> unit) -> Tray
  [<Emit "$0.addListener('balloon-show',$1)">] abstract addListenerBalloonShow: listener: (Event -> unit) -> Tray
  [<Emit "$0.removeListener('balloon-show',$1)">] abstract removeListenerBalloonShow: listener: (Event -> unit) -> Tray
  /// Emitted when the tray icon is clicked.
  [<Emit "$0.on('click',$1)">] abstract onClick: listener: (TrayInputEvent -> Rectangle -> Point -> unit) -> Tray
  [<Emit "$0.once('click',$1)">] abstract onceClick: listener: (TrayInputEvent -> Rectangle -> Point -> unit) -> Tray
  [<Emit "$0.addListener('click',$1)">] abstract addListenerClick: listener: (TrayInputEvent -> Rectangle -> Point -> unit) -> Tray
  [<Emit "$0.removeListener('click',$1)">] abstract removeListenerClick: listener: (TrayInputEvent -> Rectangle -> Point -> unit) -> Tray
  /// Emitted when the tray icon is double clicked.
  [<Emit "$0.on('double-click',$1)">] abstract onDoubleClick: listener: (TrayInputEvent -> Rectangle -> unit) -> Tray
  [<Emit "$0.once('double-click',$1)">] abstract onceDoubleClick: listener: (TrayInputEvent -> Rectangle -> unit) -> Tray
  [<Emit "$0.addListener('double-click',$1)">] abstract addListenerDoubleClick: listener: (TrayInputEvent -> Rectangle -> unit) -> Tray
  [<Emit "$0.removeListener('double-click',$1)">] abstract removeListenerDoubleClick: listener: (TrayInputEvent -> Rectangle -> unit) -> Tray
  /// Emitted when a drag operation ends on the tray or ends at another location.
  [<Emit "$0.on('drag-end',$1)">] abstract onDragEnd: listener: (Event -> unit) -> Tray
  [<Emit "$0.once('drag-end',$1)">] abstract onceDragEnd: listener: (Event -> unit) -> Tray
  [<Emit "$0.addListener('drag-end',$1)">] abstract addListenerDragEnd: listener: (Event -> unit) -> Tray
  [<Emit "$0.removeListener('drag-end',$1)">] abstract removeListenerDragEnd: listener: (Event -> unit) -> Tray
  /// Emitted when a drag operation enters the tray icon.
  [<Emit "$0.on('drag-enter',$1)">] abstract onDragEnter: listener: (Event -> unit) -> Tray
  [<Emit "$0.once('drag-enter',$1)">] abstract onceDragEnter: listener: (Event -> unit) -> Tray
  [<Emit "$0.addListener('drag-enter',$1)">] abstract addListenerDragEnter: listener: (Event -> unit) -> Tray
  [<Emit "$0.removeListener('drag-enter',$1)">] abstract removeListenerDragEnter: listener: (Event -> unit) -> Tray
  /// Emitted when a drag operation exits the tray icon.
  [<Emit "$0.on('drag-leave',$1)">] abstract onDragLeave: listener: (Event -> unit) -> Tray
  [<Emit "$0.once('drag-leave',$1)">] abstract onceDragLeave: listener: (Event -> unit) -> Tray
  [<Emit "$0.addListener('drag-leave',$1)">] abstract addListenerDragLeave: listener: (Event -> unit) -> Tray
  [<Emit "$0.removeListener('drag-leave',$1)">] abstract removeListenerDragLeave: listener: (Event -> unit) -> Tray
  /// Emitted when any dragged items are dropped on the tray icon.
  [<Emit "$0.on('drop',$1)">] abstract onDrop: listener: (Event -> unit) -> Tray
  [<Emit "$0.once('drop',$1)">] abstract onceDrop: listener: (Event -> unit) -> Tray
  [<Emit "$0.addListener('drop',$1)">] abstract addListenerDrop: listener: (Event -> unit) -> Tray
  [<Emit "$0.removeListener('drop',$1)">] abstract removeListenerDrop: listener: (Event -> unit) -> Tray
  /// Emitted when dragged files are dropped in the tray icon.
  [<Emit "$0.on('drop-files',$1)">] abstract onDropFiles: listener: (Event -> string [] -> unit) -> Tray
  [<Emit "$0.once('drop-files',$1)">] abstract onceDropFiles: listener: (Event -> string [] -> unit) -> Tray
  [<Emit "$0.addListener('drop-files',$1)">] abstract addListenerDropFiles: listener: (Event -> string [] -> unit) -> Tray
  [<Emit "$0.removeListener('drop-files',$1)">] abstract removeListenerDropFiles: listener: (Event -> string [] -> unit) -> Tray
  /// Emitted when dragged text is dropped in the tray icon.
  [<Emit "$0.on('drop-text',$1)">] abstract onDropText: listener: (Event -> string -> unit) -> Tray
  [<Emit "$0.once('drop-text',$1)">] abstract onceDropText: listener: (Event -> string -> unit) -> Tray
  [<Emit "$0.addListener('drop-text',$1)">] abstract addListenerDropText: listener: (Event -> string -> unit) -> Tray
  [<Emit "$0.removeListener('drop-text',$1)">] abstract removeListenerDropText: listener: (Event -> string -> unit) -> Tray
  /// Emitted when the mouse enters the tray icon.
  [<Emit "$0.on('mouse-enter',$1)">] abstract onMouseEnter: listener: (TrayInputEvent -> Point -> unit) -> Tray
  [<Emit "$0.once('mouse-enter',$1)">] abstract onceMouseEnter: listener: (TrayInputEvent -> Point -> unit) -> Tray
  [<Emit "$0.addListener('mouse-enter',$1)">] abstract addListenerMouseEnter: listener: (TrayInputEvent -> Point -> unit) -> Tray
  [<Emit "$0.removeListener('mouse-enter',$1)">] abstract removeListenerMouseEnter: listener: (TrayInputEvent -> Point -> unit) -> Tray
  /// Emitted when the mouse exits the tray icon.
  [<Emit "$0.on('mouse-leave',$1)">] abstract onMouseLeave: listener: (TrayInputEvent -> Point -> unit) -> Tray
  [<Emit "$0.once('mouse-leave',$1)">] abstract onceMouseLeave: listener: (TrayInputEvent -> Point -> unit) -> Tray
  [<Emit "$0.addListener('mouse-leave',$1)">] abstract addListenerMouseLeave: listener: (TrayInputEvent -> Point -> unit) -> Tray
  [<Emit "$0.removeListener('mouse-leave',$1)">] abstract removeListenerMouseLeave: listener: (TrayInputEvent -> Point -> unit) -> Tray
  /// Emitted when the mouse moves in the tray icon.
  [<Emit "$0.on('mouse-move',$1)">] abstract onMouseMove: listener: (TrayInputEvent -> Point -> unit) -> Tray
  [<Emit "$0.once('mouse-move',$1)">] abstract onceMouseMove: listener: (TrayInputEvent -> Point -> unit) -> Tray
  [<Emit "$0.addListener('mouse-move',$1)">] abstract addListenerMouseMove: listener: (TrayInputEvent -> Point -> unit) -> Tray
  [<Emit "$0.removeListener('mouse-move',$1)">] abstract removeListenerMouseMove: listener: (TrayInputEvent -> Point -> unit) -> Tray
  /// Emitted when the tray icon is right clicked.
  [<Emit "$0.on('right-click',$1)">] abstract onRightClick: listener: (TrayInputEvent -> Rectangle -> unit) -> Tray
  [<Emit "$0.once('right-click',$1)">] abstract onceRightClick: listener: (TrayInputEvent -> Rectangle -> unit) -> Tray
  [<Emit "$0.addListener('right-click',$1)">] abstract addListenerRightClick: listener: (TrayInputEvent -> Rectangle -> unit) -> Tray
  [<Emit "$0.removeListener('right-click',$1)">] abstract removeListenerRightClick: listener: (TrayInputEvent -> Rectangle -> unit) -> Tray
  /// Destroys the tray icon immediately.
  abstract destroy: unit -> unit
  /// Displays a tray balloon.
  abstract displayBalloon: options: DisplayBalloonOptions -> unit
  /// The bounds of this tray icon as Object.
  abstract getBounds: unit -> Rectangle
  abstract getIgnoreDoubleClickEvents: unit -> bool
  abstract isDestroyed: unit -> bool
  /// Pops up the context menu of the tray icon. When menu is passed, the menu will be
  /// shown instead of the tray icon's context menu. The position is only available on
  /// Windows, and it is (0, 0) by default.
  abstract popUpContextMenu: ?menu: Menu * ?position: Point -> unit
  /// Sets the context menu for this icon.
  abstract setContextMenu: menu: Menu option -> unit
  /// Sets when the tray's icon background becomes highlighted (in blue). Note: You
  /// can use highlightMode with a BrowserWindow by toggling between 'never' and
  /// 'always' modes when the window visibility changes.
  abstract setHighlightMode: mode: HighlightMode -> unit
  /// Sets the option to ignore double click events. Ignoring these events allows you
  /// to detect every individual click of the tray icon. This value is set to false by
  /// default.
  abstract setIgnoreDoubleClickEvents: ignore: bool -> unit
  /// Sets the image associated with this tray icon.
  abstract setImage: image: U2<NativeImage, string> -> unit
  /// Sets the image associated with this tray icon when pressed on macOS.
  abstract setPressedImage: image: U2<NativeImage, string> -> unit
  /// Sets the title displayed aside of the tray icon in the status bar (Support ANSI
  /// colors).
  abstract setTitle: title: string -> unit
  /// Sets the hover text for this tray icon.
  abstract setToolTip: toolTip: string -> unit

type TrayStatic =
  [<EmitConstructor>] abstract Create: image: U2<NativeImage, string> -> Tray

type UploadBlob =
  /// UUID of blob data to upload.
  abstract blobUUID: string with get, set
  /// blob.
  abstract ``type``: string with get, set

type UploadData =
  /// UUID of blob data. Use method to retrieve the data.
  abstract blobUUID: string with get, set
  /// Content being sent.
  abstract bytes: Buffer with get, set
  /// Path of file being uploaded.
  abstract file: string with get, set

type UploadFile =
  /// Path of file to be uploaded.
  abstract filePath: string with get, set
  /// Number of bytes to read from offset. Defaults to 0.
  abstract length: int with get, set
  /// Last Modification time in number of seconds since the UNIX epoch.
  abstract modificationTime: float with get, set
  /// Defaults to 0.
  abstract offset: int with get, set
  /// file.
  abstract ``type``: string with get, set

type UploadRawData =
  /// Data to be uploaded.
  abstract bytes: Buffer with get, set
  /// rawData.
  abstract ``type``: string with get, set

[<StringEnum; RequireQualifiedAccess>]
type WindowDisposition =
  | Default
  | [<CompiledName("foreground-tab")>] ForegroundTab
  | [<CompiledName("background-tab")>] BackgroundTab
  | [<CompiledName("new-window")>] NewWindow
  | [<CompiledName("save-to-disk")>] SaveToDisk
  | Other

[<StringEnum; RequireQualifiedAccess>]
type WebContentType =
  | BackgroundPage
  | Window
  | BrowserView
  | Remote
  | Webview
  | Offscreen

[<StringEnum; RequireQualifiedAccess>]
type WebContentSaveType =
  | [<CompiledName("HTMLOnly")>] HtmlOnly
  | [<CompiledName("HTMLComplete")>] HtmlComplete
  | [<CompiledName("MHTML")>] Mhtml

[<StringEnum; RequireQualifiedAccess>]
type WebRtcIpHandlingPolicy =
  | Default
  | [<CompiledName("default_public_interface_only")>] DefaultPublicInterfaceOnly
  | [<CompiledName("default_public_and_private_interfaces")>] DefaultPublicAndPrivateInterfaces
  | [<CompiledName("disable_non_proxied_udp")>] DisableNonProxiedUdp

[<StringEnum; RequireQualifiedAccess>]
type StopFindInPageAction =
  | ClearSelection
  | KeepSelection
  | ActivateSelection

type WebContents =
  inherit EventEmitter<WebContents>
  /// Emitted before dispatching the keydown and keyup events in the page. Calling
  /// event.preventDefault will prevent the page keydown/keyup events and the menu
  /// shortcuts. To only prevent the menu shortcuts, use setIgnoreMenuShortcuts:
  [<Emit "$0.on('before-input-event',$1)">] abstract onBeforeInputEvent: listener: (Event -> BeforeInputEventData -> unit) -> WebContents
  [<Emit "$0.once('before-input-event',$1)">] abstract onceBeforeInputEvent: listener: (Event -> BeforeInputEventData -> unit) -> WebContents
  [<Emit "$0.addListener('before-input-event',$1)">] abstract addListenerBeforeInputEvent: listener: (Event -> BeforeInputEventData -> unit) -> WebContents
  [<Emit "$0.removeListener('before-input-event',$1)">] abstract removeListenerBeforeInputEvent: listener: (Event -> BeforeInputEventData -> unit) -> WebContents
  /// Emitted when failed to verify the certificate for url. The usage is the same
  /// with the certificate-error event of app.
  [<Emit "$0.on('certificate-error',$1)">] abstract onCertificateError: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
  [<Emit "$0.once('certificate-error',$1)">] abstract onceCertificateError: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
  [<Emit "$0.addListener('certificate-error',$1)">] abstract addListenerCertificateError: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
  [<Emit "$0.removeListener('certificate-error',$1)">] abstract removeListenerCertificateError: listener: (Event -> string -> string -> Certificate -> (bool -> unit) -> unit) -> WebContents
  /// Emitted when the associated window logs a console message. Will not be emitted
  /// for windows with offscreen rendering enabled.
  [<Emit "$0.on('console-message',$1)">] abstract onConsoleMessage: listener: (Event -> int -> string -> int -> string -> unit) -> WebContents
  [<Emit "$0.once('console-message',$1)">] abstract onceConsoleMessage: listener: (Event -> int -> string -> int -> string -> unit) -> WebContents
  [<Emit "$0.addListener('console-message',$1)">] abstract addListenerConsoleMessage: listener: (Event -> int -> string -> int -> string -> unit) -> WebContents
  [<Emit "$0.removeListener('console-message',$1)">] abstract removeListenerConsoleMessage: listener: (Event -> int -> string -> int -> string -> unit) -> WebContents
  /// Emitted when there is a new context menu that needs to be handled.
  [<Emit "$0.on('context-menu',$1)">] abstract onContextMenu: listener: (Event -> ContextMenuParams -> unit) -> WebContents
  [<Emit "$0.once('context-menu',$1)">] abstract onceContextMenu: listener: (Event -> ContextMenuParams -> unit) -> WebContents
  [<Emit "$0.addListener('context-menu',$1)">] abstract addListenerContextMenu: listener: (Event -> ContextMenuParams -> unit) -> WebContents
  [<Emit "$0.removeListener('context-menu',$1)">] abstract removeListenerContextMenu: listener: (Event -> ContextMenuParams -> unit) -> WebContents
  /// Emitted when the renderer process crashes or is killed.
  [<Emit "$0.on('crashed',$1)">] abstract onCrashed: listener: (Event -> bool -> unit) -> WebContents
  [<Emit "$0.once('crashed',$1)">] abstract onceCrashed: listener: (Event -> bool -> unit) -> WebContents
  [<Emit "$0.addListener('crashed',$1)">] abstract addListenerCrashed: listener: (Event -> bool -> unit) -> WebContents
  [<Emit "$0.removeListener('crashed',$1)">] abstract removeListenerCrashed: listener: (Event -> bool -> unit) -> WebContents
  /// Emitted when the cursor's type changes. The type parameter can be default,
  /// crosshair, pointer, text, wait, help, e-resize, n-resize, ne-resize, nw-resize,
  /// s-resize, se-resize, sw-resize, w-resize, ns-resize, ew-resize, nesw-resize,
  /// nwse-resize, col-resize, row-resize, m-panning, e-panning, n-panning,
  /// ne-panning, nw-panning, s-panning, se-panning, sw-panning, w-panning, move,
  /// vertical-text, cell, context-menu, alias, progress, nodrop, copy, none,
  /// not-allowed, zoom-in, zoom-out, grab, grabbing or custom. If the type parameter
  /// is custom, the image parameter will hold the custom cursor image in a
  /// NativeImage, and scale, size and hotspot will hold additional information about
  /// the custom cursor.
  [<Emit "$0.on('cursor-changed',$1)">] abstract onCursorChanged: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
  [<Emit "$0.once('cursor-changed',$1)">] abstract onceCursorChanged: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
  [<Emit "$0.addListener('cursor-changed',$1)">] abstract addListenerCursorChanged: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
  [<Emit "$0.removeListener('cursor-changed',$1)">] abstract removeListenerCursorChanged: listener: (Event -> string -> NativeImage -> float -> Size -> Point -> unit) -> WebContents
  /// Emitted when desktopCapturer.getSources() is called in the renderer process.
  /// Calling event.preventDefault() will make it return empty sources.
  [<Emit "$0.on('desktop-capturer-get-sources',$1)">] abstract onDesktopCapturerGetSources: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('desktop-capturer-get-sources',$1)">] abstract onceDesktopCapturerGetSources: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('desktop-capturer-get-sources',$1)">] abstract addListenerDesktopCapturerGetSources: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('desktop-capturer-get-sources',$1)">] abstract removeListenerDesktopCapturerGetSources: listener: (Event -> unit) -> WebContents
  /// Emitted when webContents is destroyed.
  [<Emit "$0.on('destroyed',$1)">] abstract onDestroyed: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('destroyed',$1)">] abstract onceDestroyed: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('destroyed',$1)">] abstract addListenerDestroyed: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('destroyed',$1)">] abstract removeListenerDestroyed: listener: (Event -> unit) -> WebContents
  /// Emitted when DevTools is closed.
  [<Emit "$0.on('devtools-closed',$1)">] abstract onDevtoolsClosed: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('devtools-closed',$1)">] abstract onceDevtoolsClosed: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('devtools-closed',$1)">] abstract addListenerDevtoolsClosed: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('devtools-closed',$1)">] abstract removeListenerDevtoolsClosed: listener: (Event -> unit) -> WebContents
  /// Emitted when DevTools is focused / opened.
  [<Emit "$0.on('devtools-focused',$1)">] abstract onDevtoolsFocused: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('devtools-focused',$1)">] abstract onceDevtoolsFocused: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('devtools-focused',$1)">] abstract addListenerDevtoolsFocused: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('devtools-focused',$1)">] abstract removeListenerDevtoolsFocused: listener: (Event -> unit) -> WebContents
  /// Emitted when DevTools is opened.
  [<Emit "$0.on('devtools-opened',$1)">] abstract onDevtoolsOpened: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('devtools-opened',$1)">] abstract onceDevtoolsOpened: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('devtools-opened',$1)">] abstract addListenerDevtoolsOpened: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('devtools-opened',$1)">] abstract removeListenerDevtoolsOpened: listener: (Event -> unit) -> WebContents
  /// Emitted when the devtools window instructs the webContents to reload
  [<Emit "$0.on('devtools-reload-page',$1)">] abstract onDevtoolsReloadPage: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('devtools-reload-page',$1)">] abstract onceDevtoolsReloadPage: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('devtools-reload-page',$1)">] abstract addListenerDevtoolsReloadPage: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('devtools-reload-page',$1)">] abstract removeListenerDevtoolsReloadPage: listener: (Event -> unit) -> WebContents
  /// Emitted when a <webview> has been attached to this web contents.
  [<Emit "$0.on('did-attach-webview',$1)">] abstract onDidAttachWebview: listener: (Event -> WebContents -> unit) -> WebContents
  [<Emit "$0.once('did-attach-webview',$1)">] abstract onceDidAttachWebview: listener: (Event -> WebContents -> unit) -> WebContents
  [<Emit "$0.addListener('did-attach-webview',$1)">] abstract addListenerDidAttachWebview: listener: (Event -> WebContents -> unit) -> WebContents
  [<Emit "$0.removeListener('did-attach-webview',$1)">] abstract removeListenerDidAttachWebview: listener: (Event -> WebContents -> unit) -> WebContents
  /// Emitted when a page's theme color changes. This is usually due to encountering a
  /// meta tag:
  [<Emit "$0.on('did-change-theme-color',$1)">] abstract onDidChangeThemeColor: listener: (Event -> string option -> unit) -> WebContents
  [<Emit "$0.once('did-change-theme-color',$1)">] abstract onceDidChangeThemeColor: listener: (Event -> string option -> unit) -> WebContents
  [<Emit "$0.addListener('did-change-theme-color',$1)">] abstract addListenerDidChangeThemeColor: listener: (Event -> string option -> unit) -> WebContents
  [<Emit "$0.removeListener('did-change-theme-color',$1)">] abstract removeListenerDidChangeThemeColor: listener: (Event -> string option -> unit) -> WebContents
  /// This event is like did-finish-load but emitted when the load failed or was
  /// cancelled, e.g. window.stop() is invoked. The full list of error codes and their
  /// meaning is available here.
  [<Emit "$0.on('did-fail-load',$1)">] abstract onDidFailLoad: listener: (Event -> int -> string -> string -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.once('did-fail-load',$1)">] abstract onceDidFailLoad: listener: (Event -> int -> string -> string -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.addListener('did-fail-load',$1)">] abstract addListenerDidFailLoad: listener: (Event -> int -> string -> string -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.removeListener('did-fail-load',$1)">] abstract removeListenerDidFailLoad: listener: (Event -> int -> string -> string -> bool -> int -> int -> unit) -> WebContents
  /// Emitted when the navigation is done, i.e. the spinner of the tab has stopped
  /// spinning, and the onload event was dispatched.
  [<Emit "$0.on('did-finish-load',$1)">] abstract onDidFinishLoad: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('did-finish-load',$1)">] abstract onceDidFinishLoad: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('did-finish-load',$1)">] abstract addListenerDidFinishLoad: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('did-finish-load',$1)">] abstract removeListenerDidFinishLoad: listener: (Event -> unit) -> WebContents
  /// Emitted when a frame has done navigation.
  [<Emit "$0.on('did-frame-finish-load',$1)">] abstract onDidFrameFinishLoad: listener: (Event -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.once('did-frame-finish-load',$1)">] abstract onceDidFrameFinishLoad: listener: (Event -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.addListener('did-frame-finish-load',$1)">] abstract addListenerDidFrameFinishLoad: listener: (Event -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.removeListener('did-frame-finish-load',$1)">] abstract removeListenerDidFrameFinishLoad: listener: (Event -> bool -> int -> int -> unit) -> WebContents
  /// Emitted when any frame navigation is done. This event is not emitted for in-page
  /// navigations, such as clicking anchor links or updating the window.location.hash.
  /// Use did-navigate-in-page event for this purpose.
  [<Emit "$0.on('did-frame-navigate',$1)">] abstract onDidFrameNavigate: listener: (Event -> string -> int -> string -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.once('did-frame-navigate',$1)">] abstract onceDidFrameNavigate: listener: (Event -> string -> int -> string -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.addListener('did-frame-navigate',$1)">] abstract addListenerDidFrameNavigate: listener: (Event -> string -> int -> string -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.removeListener('did-frame-navigate',$1)">] abstract removeListenerDidFrameNavigate: listener: (Event -> string -> int -> string -> bool -> int -> int -> unit) -> WebContents
  /// Emitted when a main frame navigation is done. This event is not emitted for
  /// in-page navigations, such as clicking anchor links or updating the
  /// window.location.hash. Use did-navigate-in-page event for this purpose.
  [<Emit "$0.on('did-navigate',$1)">] abstract onDidNavigate: listener: (Event -> string -> int -> string -> unit) -> WebContents
  [<Emit "$0.once('did-navigate',$1)">] abstract onceDidNavigate: listener: (Event -> string -> int -> string -> unit) -> WebContents
  [<Emit "$0.addListener('did-navigate',$1)">] abstract addListenerDidNavigate: listener: (Event -> string -> int -> string -> unit) -> WebContents
  [<Emit "$0.removeListener('did-navigate',$1)">] abstract removeListenerDidNavigate: listener: (Event -> string -> int -> string -> unit) -> WebContents
  /// Emitted when an in-page navigation happened in any frame. When in-page
  /// navigation happens, the page URL changes but does not cause navigation outside
  /// of the page. Examples of this occurring are when anchor links are clicked or
  /// when the DOM hashchange event is triggered.
  [<Emit "$0.on('did-navigate-in-page',$1)">] abstract onDidNavigateInPage: listener: (Event -> string -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.once('did-navigate-in-page',$1)">] abstract onceDidNavigateInPage: listener: (Event -> string -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.addListener('did-navigate-in-page',$1)">] abstract addListenerDidNavigateInPage: listener: (Event -> string -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.removeListener('did-navigate-in-page',$1)">] abstract removeListenerDidNavigateInPage: listener: (Event -> string -> bool -> int -> int -> unit) -> WebContents
  /// Emitted after a server side redirect occurs during navigation.  For example a
  /// 302 redirect. This event can not be prevented, if you want to prevent redirects
  /// you should checkout out the will-redirect event above.
  [<Emit "$0.on('did-redirect-navigation',$1)">] abstract onDidRedirectNavigation: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.once('did-redirect-navigation',$1)">] abstract onceDidRedirectNavigation: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.addListener('did-redirect-navigation',$1)">] abstract addListenerDidRedirectNavigation: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.removeListener('did-redirect-navigation',$1)">] abstract removeListenerDidRedirectNavigation: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  /// Corresponds to the points in time when the spinner of the tab started spinning.
  [<Emit "$0.on('did-start-loading',$1)">] abstract onDidStartLoading: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('did-start-loading',$1)">] abstract onceDidStartLoading: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('did-start-loading',$1)">] abstract addListenerDidStartLoading: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('did-start-loading',$1)">] abstract removeListenerDidStartLoading: listener: (Event -> unit) -> WebContents
  /// Emitted when any frame (including main) starts navigating. isInplace will be
  /// true for in-page navigations.
  [<Emit "$0.on('did-start-navigation',$1)">] abstract onDidStartNavigation: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.once('did-start-navigation',$1)">] abstract onceDidStartNavigation: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.addListener('did-start-navigation',$1)">] abstract addListenerDidStartNavigation: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.removeListener('did-start-navigation',$1)">] abstract removeListenerDidStartNavigation: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  /// Corresponds to the points in time when the spinner of the tab stopped spinning.
  [<Emit "$0.on('did-stop-loading',$1)">] abstract onDidStopLoading: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('did-stop-loading',$1)">] abstract onceDidStopLoading: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('did-stop-loading',$1)">] abstract addListenerDidStopLoading: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('did-stop-loading',$1)">] abstract removeListenerDidStopLoading: listener: (Event -> unit) -> WebContents
  /// Emitted when the document in the given frame is loaded.
  [<Emit "$0.on('dom-ready',$1)">] abstract onDomReady: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('dom-ready',$1)">] abstract onceDomReady: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('dom-ready',$1)">] abstract addListenerDomReady: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('dom-ready',$1)">] abstract removeListenerDomReady: listener: (Event -> unit) -> WebContents
  /// Emitted when a result is available for [webContents.findInPage] request.
  [<Emit "$0.on('found-in-page',$1)">] abstract onFoundInPage: listener: (Event -> FoundInPageResult -> unit) -> WebContents
  [<Emit "$0.once('found-in-page',$1)">] abstract onceFoundInPage: listener: (Event -> FoundInPageResult -> unit) -> WebContents
  [<Emit "$0.addListener('found-in-page',$1)">] abstract addListenerFoundInPage: listener: (Event -> FoundInPageResult -> unit) -> WebContents
  [<Emit "$0.removeListener('found-in-page',$1)">] abstract removeListenerFoundInPage: listener: (Event -> FoundInPageResult -> unit) -> WebContents
  /// Emitted when the renderer process sends an asynchronous message via
  /// ipcRenderer.send().
  [<Emit "$0.on('ipc-message',$1)">] abstract onIpcMessage: listener: (Event -> string -> obj [] -> unit) -> WebContents
  [<Emit "$0.once('ipc-message',$1)">] abstract onceIpcMessage: listener: (Event -> string -> obj [] -> unit) -> WebContents
  [<Emit "$0.addListener('ipc-message',$1)">] abstract addListenerIpcMessage: listener: (Event -> string -> obj [] -> unit) -> WebContents
  [<Emit "$0.removeListener('ipc-message',$1)">] abstract removeListenerIpcMessage: listener: (Event -> string -> obj [] -> unit) -> WebContents
  /// Emitted when the renderer process sends a synchronous message via
  /// ipcRenderer.sendSync().
  [<Emit "$0.on('ipc-message-sync',$1)">] abstract onIpcMessageSync: listener: (Event -> string -> obj [] -> unit) -> WebContents
  [<Emit "$0.once('ipc-message-sync',$1)">] abstract onceIpcMessageSync: listener: (Event -> string -> obj [] -> unit) -> WebContents
  [<Emit "$0.addListener('ipc-message-sync',$1)">] abstract addListenerIpcMessageSync: listener: (Event -> string -> obj [] -> unit) -> WebContents
  [<Emit "$0.removeListener('ipc-message-sync',$1)">] abstract removeListenerIpcMessageSync: listener: (Event -> string -> obj [] -> unit) -> WebContents
  /// Emitted when webContents wants to do basic auth. The usage is the same with the
  /// login event of app.
  [<Emit "$0.on('login',$1)">] abstract onLogin: listener: (Event -> LoginRequest -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
  [<Emit "$0.once('login',$1)">] abstract onceLogin: listener: (Event -> LoginRequest -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
  [<Emit "$0.addListener('login',$1)">] abstract addListenerLogin: listener: (Event -> LoginRequest -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
  [<Emit "$0.removeListener('login',$1)">] abstract removeListenerLogin: listener: (Event -> LoginRequest -> AuthInfo -> (string -> string -> unit) -> unit) -> WebContents
  /// Emitted when media is paused or done playing.
  [<Emit "$0.on('media-paused',$1)">] abstract onMediaPaused: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('media-paused',$1)">] abstract onceMediaPaused: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('media-paused',$1)">] abstract addListenerMediaPaused: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('media-paused',$1)">] abstract removeListenerMediaPaused: listener: (Event -> unit) -> WebContents
  /// Emitted when media starts playing.
  [<Emit "$0.on('media-started-playing',$1)">] abstract onMediaStartedPlaying: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('media-started-playing',$1)">] abstract onceMediaStartedPlaying: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('media-started-playing',$1)">] abstract addListenerMediaStartedPlaying: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('media-started-playing',$1)">] abstract removeListenerMediaStartedPlaying: listener: (Event -> unit) -> WebContents
  /// Emitted when the page requests to open a new window for a url. It could be
  /// requested by window.open or an external link like <a target='_blank'>. By
  /// default a new BrowserWindow will be created for the url. Calling
  /// event.preventDefault() will prevent Electron from automatically creating a new
  /// BrowserWindow. If you call event.preventDefault() and manually create a new
  /// BrowserWindow then you must set event.newGuest to reference the new
  /// BrowserWindow instance, failing to do so may result in unexpected behavior. For
  /// example:
  [<Emit "$0.on('new-window',$1)">] abstract onNewWindow: listener: (Event -> string -> string -> WindowDisposition -> BrowserWindowOptions -> string [] -> Referrer -> unit) -> WebContents
  [<Emit "$0.once('new-window',$1)">] abstract onceNewWindow: listener: (Event -> string -> string -> WindowDisposition -> BrowserWindowOptions -> string [] -> Referrer -> unit) -> WebContents
  [<Emit "$0.addListener('new-window',$1)">] abstract addListenerNewWindow: listener: (Event -> string -> string -> WindowDisposition -> BrowserWindowOptions -> string [] -> Referrer -> unit) -> WebContents
  [<Emit "$0.removeListener('new-window',$1)">] abstract removeListenerNewWindow: listener: (Event -> string -> string -> WindowDisposition -> BrowserWindowOptions -> string [] -> Referrer -> unit) -> WebContents
  /// Emitted when page receives favicon urls.
  [<Emit "$0.on('page-favicon-updated',$1)">] abstract onPageFaviconUpdated: listener: (Event -> string [] -> unit) -> WebContents
  [<Emit "$0.once('page-favicon-updated',$1)">] abstract oncePageFaviconUpdated: listener: (Event -> string [] -> unit) -> WebContents
  [<Emit "$0.addListener('page-favicon-updated',$1)">] abstract addListenerPageFaviconUpdated: listener: (Event -> string [] -> unit) -> WebContents
  [<Emit "$0.removeListener('page-favicon-updated',$1)">] abstract removeListenerPageFaviconUpdated: listener: (Event -> string [] -> unit) -> WebContents
  /// Fired when page title is set during navigation. explicitSet is false when title
  /// is synthesized from file url.
  [<Emit "$0.on('page-title-updated',$1)">] abstract onPageTitleUpdated: listener: (Event -> string -> bool -> unit) -> WebContents
  [<Emit "$0.once('page-title-updated',$1)">] abstract oncePageTitleUpdated: listener: (Event -> string -> bool -> unit) -> WebContents
  [<Emit "$0.addListener('page-title-updated',$1)">] abstract addListenerPageTitleUpdated: listener: (Event -> string -> bool -> unit) -> WebContents
  [<Emit "$0.removeListener('page-title-updated',$1)">] abstract removeListenerPageTitleUpdated: listener: (Event -> string -> bool -> unit) -> WebContents
  /// Emitted when a new frame is generated. Only the dirty area is passed in the
  /// buffer.
  [<Emit "$0.on('paint',$1)">] abstract onPaint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
  [<Emit "$0.once('paint',$1)">] abstract oncePaint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
  [<Emit "$0.addListener('paint',$1)">] abstract addListenerPaint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
  [<Emit "$0.removeListener('paint',$1)">] abstract removeListenerPaint: listener: (Event -> Rectangle -> NativeImage -> unit) -> WebContents
  /// Emitted when a plugin process has crashed.
  [<Emit "$0.on('plugin-crashed',$1)">] abstract onPluginCrashed: listener: (Event -> string -> string -> unit) -> WebContents
  [<Emit "$0.once('plugin-crashed',$1)">] abstract oncePluginCrashed: listener: (Event -> string -> string -> unit) -> WebContents
  [<Emit "$0.addListener('plugin-crashed',$1)">] abstract addListenerPluginCrashed: listener: (Event -> string -> string -> unit) -> WebContents
  [<Emit "$0.removeListener('plugin-crashed',$1)">] abstract removeListenerPluginCrashed: listener: (Event -> string -> string -> unit) -> WebContents
  /// Emitted when the preload script preloadPath throws an unhandled exception error.
  [<Emit "$0.on('preload-error',$1)">] abstract onPreloadError: listener: (Event -> string -> Error -> unit) -> WebContents
  [<Emit "$0.once('preload-error',$1)">] abstract oncePreloadError: listener: (Event -> string -> Error -> unit) -> WebContents
  [<Emit "$0.addListener('preload-error',$1)">] abstract addListenerPreloadError: listener: (Event -> string -> Error -> unit) -> WebContents
  [<Emit "$0.removeListener('preload-error',$1)">] abstract removeListenerPreloadError: listener: (Event -> string -> Error -> unit) -> WebContents
  /// Emitted when remote.getBuiltin() is called in the renderer process. Calling
  /// event.preventDefault() will prevent the module from being returned. Custom value
  /// can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-get-builtin',$1)">] abstract onRemoteGetBuiltin: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  [<Emit "$0.once('remote-get-builtin',$1)">] abstract onceRemoteGetBuiltin: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  [<Emit "$0.addListener('remote-get-builtin',$1)">] abstract addListenerRemoteGetBuiltin: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  [<Emit "$0.removeListener('remote-get-builtin',$1)">] abstract removeListenerRemoteGetBuiltin: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  /// Emitted when remote.getCurrentWebContents() is called in the renderer process.
  /// Calling event.preventDefault() will prevent the object from being returned.
  /// Custom value can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-get-current-web-contents',$1)">] abstract onRemoteGetCurrentWebContents: listener: (ReturnValueEvent -> unit) -> WebContents
  [<Emit "$0.once('remote-get-current-web-contents',$1)">] abstract onceRemoteGetCurrentWebContents: listener: (ReturnValueEvent -> unit) -> WebContents
  [<Emit "$0.addListener('remote-get-current-web-contents',$1)">] abstract addListenerRemoteGetCurrentWebContents: listener: (ReturnValueEvent -> unit) -> WebContents
  [<Emit "$0.removeListener('remote-get-current-web-contents',$1)">] abstract removeListenerRemoteGetCurrentWebContents: listener: (ReturnValueEvent -> unit) -> WebContents
  /// Emitted when remote.getCurrentWindow() is called in the renderer process.
  /// Calling event.preventDefault() will prevent the object from being returned.
  /// Custom value can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-get-current-window',$1)">] abstract onRemoteGetCurrentWindow: listener: (ReturnValueEvent -> unit) -> WebContents
  [<Emit "$0.once('remote-get-current-window',$1)">] abstract onceRemoteGetCurrentWindow: listener: (ReturnValueEvent -> unit) -> WebContents
  [<Emit "$0.addListener('remote-get-current-window',$1)">] abstract addListenerRemoteGetCurrentWindow: listener: (ReturnValueEvent -> unit) -> WebContents
  [<Emit "$0.removeListener('remote-get-current-window',$1)">] abstract removeListenerRemoteGetCurrentWindow: listener: (ReturnValueEvent -> unit) -> WebContents
  /// Emitted when remote.getGlobal() is called in the renderer process. Calling
  /// event.preventDefault() will prevent the global from being returned. Custom value
  /// can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-get-global',$1)">] abstract onRemoteGetGlobal: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  [<Emit "$0.once('remote-get-global',$1)">] abstract onceRemoteGetGlobal: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  [<Emit "$0.addListener('remote-get-global',$1)">] abstract addListenerRemoteGetGlobal: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  [<Emit "$0.removeListener('remote-get-global',$1)">] abstract removeListenerRemoteGetGlobal: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  /// Emitted when <webview>.getWebContents() is called in the renderer process.
  /// Calling event.preventDefault() will prevent the object from being returned.
  /// Custom value can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-get-guest-web-contents',$1)">] abstract onRemoteGetGuestWebContents: listener: (ReturnValueEvent -> WebContents -> unit) -> WebContents
  [<Emit "$0.once('remote-get-guest-web-contents',$1)">] abstract onceRemoteGetGuestWebContents: listener: (ReturnValueEvent -> WebContents -> unit) -> WebContents
  [<Emit "$0.addListener('remote-get-guest-web-contents',$1)">] abstract addListenerRemoteGetGuestWebContents: listener: (ReturnValueEvent -> WebContents -> unit) -> WebContents
  [<Emit "$0.removeListener('remote-get-guest-web-contents',$1)">] abstract removeListenerRemoteGetGuestWebContents: listener: (ReturnValueEvent -> WebContents -> unit) -> WebContents
  /// Emitted when remote.require() is called in the renderer process. Calling
  /// event.preventDefault() will prevent the module from being returned. Custom value
  /// can be returned by setting event.returnValue.
  [<Emit "$0.on('remote-require',$1)">] abstract onRemoteRequire: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  [<Emit "$0.once('remote-require',$1)">] abstract onceRemoteRequire: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  [<Emit "$0.addListener('remote-require',$1)">] abstract addListenerRemoteRequire: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  [<Emit "$0.removeListener('remote-require',$1)">] abstract removeListenerRemoteRequire: listener: (ReturnValueEvent -> string -> unit) -> WebContents
  /// Emitted when the unresponsive web page becomes responsive again.
  [<Emit "$0.on('responsive',$1)">] abstract onResponsive: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('responsive',$1)">] abstract onceResponsive: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('responsive',$1)">] abstract addListenerResponsive: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('responsive',$1)">] abstract removeListenerResponsive: listener: (Event -> unit) -> WebContents
  /// Emitted when bluetooth device needs to be selected on call to
  /// navigator.bluetooth.requestDevice. To use navigator.bluetooth api webBluetooth
  /// should be enabled. If event.preventDefault is not called, first available device
  /// will be selected. callback should be called with deviceId to be selected,
  /// passing empty string to callback will cancel the request.
  [<Emit "$0.on('select-bluetooth-device',$1)">] abstract onSelectBluetoothDevice: listener: (Event -> BluetoothDevice [] -> (string -> unit) -> unit) -> WebContents
  [<Emit "$0.once('select-bluetooth-device',$1)">] abstract onceSelectBluetoothDevice: listener: (Event -> BluetoothDevice [] -> (string -> unit) -> unit) -> WebContents
  [<Emit "$0.addListener('select-bluetooth-device',$1)">] abstract addListenerSelectBluetoothDevice: listener: (Event -> BluetoothDevice [] -> (string -> unit) -> unit) -> WebContents
  [<Emit "$0.removeListener('select-bluetooth-device',$1)">] abstract removeListenerSelectBluetoothDevice: listener: (Event -> BluetoothDevice [] -> (string -> unit) -> unit) -> WebContents
  /// Emitted when a client certificate is requested. The usage is the same with the
  /// select-client-certificate event of app.
  [<Emit "$0.on('select-client-certificate',$1)">] abstract onSelectClientCertificate: listener: (Event -> string -> Certificate [] -> (Certificate -> unit) -> unit) -> WebContents
  [<Emit "$0.once('select-client-certificate',$1)">] abstract onceSelectClientCertificate: listener: (Event -> string -> Certificate [] -> (Certificate -> unit) -> unit) -> WebContents
  [<Emit "$0.addListener('select-client-certificate',$1)">] abstract addListenerSelectClientCertificate: listener: (Event -> string -> Certificate [] -> (Certificate -> unit) -> unit) -> WebContents
  [<Emit "$0.removeListener('select-client-certificate',$1)">] abstract removeListenerSelectClientCertificate: listener: (Event -> string -> Certificate [] -> (Certificate -> unit) -> unit) -> WebContents
  /// Emitted when the web page becomes unresponsive.
  [<Emit "$0.on('unresponsive',$1)">] abstract onUnresponsive: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('unresponsive',$1)">] abstract onceUnresponsive: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('unresponsive',$1)">] abstract addListenerUnresponsive: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('unresponsive',$1)">] abstract removeListenerUnresponsive: listener: (Event -> unit) -> WebContents
  /// Emitted when mouse moves over a link or the keyboard moves the focus to a link.
  [<Emit "$0.on('update-target-url',$1)">] abstract onUpdateTargetUrl: listener: (Event -> string -> unit) -> WebContents
  [<Emit "$0.once('update-target-url',$1)">] abstract onceUpdateTargetUrl: listener: (Event -> string -> unit) -> WebContents
  [<Emit "$0.addListener('update-target-url',$1)">] abstract addListenerUpdateTargetUrl: listener: (Event -> string -> unit) -> WebContents
  [<Emit "$0.removeListener('update-target-url',$1)">] abstract removeListenerUpdateTargetUrl: listener: (Event -> string -> unit) -> WebContents
  /// Emitted when a <webview>'s web contents is being attached to this web contents.
  /// Calling event.preventDefault() will destroy the guest page. This event can be
  /// used to configure webPreferences for the webContents of a <webview> before it's
  /// loaded, and provides the ability to set settings that can't be set via <webview>
  /// attributes. Note: The specified preload script option will be appear as
  /// preloadURL (not preload) in the webPreferences object emitted with this event.
  [<Emit "$0.on('will-attach-webview',$1)">] abstract onWillAttachWebview: listener: (Event -> WebPreferences -> obj -> unit) -> WebContents
  [<Emit "$0.once('will-attach-webview',$1)">] abstract onceWillAttachWebview: listener: (Event -> WebPreferences -> obj -> unit) -> WebContents
  [<Emit "$0.addListener('will-attach-webview',$1)">] abstract addListenerWillAttachWebview: listener: (Event -> WebPreferences -> obj -> unit) -> WebContents
  [<Emit "$0.removeListener('will-attach-webview',$1)">] abstract removeListenerWillAttachWebview: listener: (Event -> WebPreferences -> obj -> unit) -> WebContents
  /// Emitted when a user or the page wants to start navigation. It can happen when
  /// the window.location object is changed or a user clicks a link in the page. This
  /// event will not emit when the navigation is started programmatically with APIs
  /// like webContents.loadURL and webContents.back. It is also not emitted for
  /// in-page navigations, such as clicking anchor links or updating the
  /// window.location.hash. Use did-navigate-in-page event for this purpose. Calling
  /// event.preventDefault() will prevent the navigation.
  [<Emit "$0.on('will-navigate',$1)">] abstract onWillNavigate: listener: (Event -> string -> unit) -> WebContents
  [<Emit "$0.once('will-navigate',$1)">] abstract onceWillNavigate: listener: (Event -> string -> unit) -> WebContents
  [<Emit "$0.addListener('will-navigate',$1)">] abstract addListenerWillNavigate: listener: (Event -> string -> unit) -> WebContents
  [<Emit "$0.removeListener('will-navigate',$1)">] abstract removeListenerWillNavigate: listener: (Event -> string -> unit) -> WebContents
  /// Emitted when a beforeunload event handler is attempting to cancel a page unload.
  /// Calling event.preventDefault() will ignore the beforeunload event handler and
  /// allow the page to be unloaded.
  [<Emit "$0.on('will-prevent-unload',$1)">] abstract onWillPreventUnload: listener: (Event -> unit) -> WebContents
  [<Emit "$0.once('will-prevent-unload',$1)">] abstract onceWillPreventUnload: listener: (Event -> unit) -> WebContents
  [<Emit "$0.addListener('will-prevent-unload',$1)">] abstract addListenerWillPreventUnload: listener: (Event -> unit) -> WebContents
  [<Emit "$0.removeListener('will-prevent-unload',$1)">] abstract removeListenerWillPreventUnload: listener: (Event -> unit) -> WebContents
  /// Emitted as a server side redirect occurs during navigation.  For example a 302
  /// redirect. This event will be emitted after did-start-navigation and always
  /// before the did-redirect-navigation event for the same navigation. Calling
  /// event.preventDefault() will prevent the navigation (not just the redirect).
  [<Emit "$0.on('will-redirect',$1)">] abstract onWillRedirect: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.once('will-redirect',$1)">] abstract onceWillRedirect: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.addListener('will-redirect',$1)">] abstract addListenerWillRedirect: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  [<Emit "$0.removeListener('will-redirect',$1)">] abstract removeListenerWillRedirect: listener: (Event -> string -> bool -> bool -> int -> int -> unit) -> WebContents
  /// Adds the specified path to DevTools workspace. Must be used after DevTools
  /// creation:
  abstract addWorkSpace: path: string -> unit
  /// Begin subscribing for presentation events and captured frames, the callback will
  /// be called with callback(image, dirtyRect) when there is a presentation event.
  /// The image is an instance of NativeImage that stores the captured frame. The
  /// dirtyRect is an object with x, y, width, height properties that describes which
  /// part of the page was repainted. If onlyDirty is set to true, image will only
  /// contain the repainted area. onlyDirty defaults to false.
  abstract beginFrameSubscription: callback: (NativeImage -> Rectangle -> unit) -> unit
  /// Begin subscribing for presentation events and captured frames, the callback will
  /// be called with callback(image, dirtyRect) when there is a presentation event.
  /// The image is an instance of NativeImage that stores the captured frame. The
  /// dirtyRect is an object with x, y, width, height properties that describes which
  /// part of the page was repainted. If onlyDirty is set to true, image will only
  /// contain the repainted area. onlyDirty defaults to false.
  abstract beginFrameSubscription: onlyDirty: bool * callback: (NativeImage -> Rectangle -> unit) -> unit
  abstract canGoBack: unit -> bool
  abstract canGoForward: unit -> bool
  abstract canGoToOffset: offset: int -> bool
  /// Captures a snapshot of the page within rect. Omitting rect will capture the
  /// whole visible page.
  abstract capturePage: ?rect: Rectangle -> unit
  /// Captures a snapshot of the page within rect. Upon completion callback will be
  /// called with callback(image). The image is an instance of NativeImage that stores
  /// data of the snapshot. Omitting rect will capture the whole visible page.
  /// Deprecated Soon
  abstract capturePage: rect: Rectangle * callback: (NativeImage -> unit) -> unit
  /// Captures a snapshot of the page within rect. Upon completion callback will be
  /// called with callback(image). The image is an instance of NativeImage that stores
  /// data of the snapshot. Omitting rect will capture the whole visible page.
  /// Deprecated Soon
  abstract capturePage: callback: (NativeImage -> unit) -> unit
  /// Clears the navigation history.
  abstract clearHistory: unit -> unit
  /// Closes the devtools.
  abstract closeDevTools: unit -> unit
  /// Executes the editing command copy in web page.
  abstract copy: unit -> unit
  /// Copy the image at the given position to the clipboard.
  abstract copyImageAt: x: int * y: int -> unit
  /// Executes the editing command cut in web page.
  abstract cut: unit -> unit
  /// Executes the editing command delete in web page.
  abstract delete: unit -> unit
  /// Disable device emulation enabled by webContents.enableDeviceEmulation.
  abstract disableDeviceEmulation: unit -> unit
  /// Initiates a download of the resource at url without navigating. The
  /// will-download event of session will be triggered.
  abstract downloadURL: url: string -> unit
  /// Enable device emulation with the given parameters.
  abstract enableDeviceEmulation: parameters: DeviceEmulationParameters -> unit
  /// End subscribing for frame presentation events.
  abstract endFrameSubscription: unit -> unit
  /// Evaluates code in page. In the browser window some HTML APIs like
  /// requestFullScreen can only be invoked by a gesture from the user. Setting
  /// userGesture to true will remove this limitation. If the result of the executed
  /// code is a promise the callback result will be the resolved value of the promise.
  /// We recommend that you use the returned Promise to handle code that results in a
  /// Promise.
  abstract executeJavaScript: code: string * ?userGesture: bool * ?callback: (obj option -> unit) -> Promise<obj option>
  /// Starts a request to find all matches for the text in the web page. The result of
  /// the request can be obtained by subscribing to found-in-page event.
  abstract findInPage: text: string * ?options: FindInPageOptions -> int
  /// Focuses the web page.
  abstract focus: unit -> unit
  abstract getFrameRate: unit -> int
  abstract getOSProcessId: unit -> int
  /// Get the system printer list.
  abstract getPrinters: unit -> PrinterInfo []
  abstract getProcessId: unit -> int
  abstract getTitle: unit -> string
  abstract getType: unit -> WebContentType
  abstract getURL: unit -> string
  abstract getUserAgent: unit -> string
  abstract getWebRTCIPHandlingPolicy: unit -> string
  abstract getZoomFactor: unit -> float
  abstract getZoomLevel: unit -> float
  /// Makes the browser go back a web page.
  abstract goBack: unit -> unit
  /// Makes the browser go forward a web page.
  abstract goForward: unit -> unit
  /// Navigates browser to the specified absolute web page index.
  abstract goToIndex: index: int -> unit
  /// Navigates to the specified offset from the "current entry".
  abstract goToOffset: offset: int -> unit
  /// Checks if any ServiceWorker is registered and returns a boolean as response to
  /// callback.
  abstract hasServiceWorker: callback: (bool -> unit) -> unit
  /// Injects CSS into the current web page.
  abstract insertCSS: css: string -> unit
  /// Inserts text to the focused element.
  abstract insertText: text: string -> unit
  /// Starts inspecting element at position (x, y).
  abstract inspectElement: x: int * y: int -> unit
  /// Opens the developer tools for the service worker context.
  abstract inspectServiceWorker: unit -> unit
  /// Schedules a full repaint of the window this web contents is in. If offscreen
  /// rendering is enabled invalidates the frame and generates a new one through the
  /// 'paint' event.
  abstract invalidate: unit -> unit
  abstract isAudioMuted: unit -> bool
  abstract isCrashed: unit -> bool
  abstract isCurrentlyAudible: unit -> bool
  abstract isDestroyed: unit -> bool
  abstract isDevToolsFocused: unit -> bool
  abstract isDevToolsOpened: unit -> bool
  abstract isFocused: unit -> bool
  abstract isLoading: unit -> bool
  abstract isLoadingMainFrame: unit -> bool
  abstract isOffscreen: unit -> bool
  abstract isPainting: unit -> bool
  abstract isWaitingForResponse: unit -> bool
  /// Loads the given file in the window, filePath should be a path to an HTML file
  /// relative to the root of your application.  For instance an app structure like
  /// this: Would require code like this
  abstract loadFile: filePath: string * ?options: LoadFileOptions -> Promise<unit>
  /// Loads the url in the window. The url must contain the protocol prefix, e.g. the
  /// http:// or file://. If the load should bypass http cache then use the pragma
  /// header to achieve it.
  abstract loadURL: url: string * ?options: LoadURLOptions -> Promise<unit>
  /// Opens the devtools. When contents is a <webview> tag, the mode would be detach
  /// by default, explicitly passing an empty mode can force using last used dock
  /// state.
  abstract openDevTools: ?options: OpenDevToolsOptions -> unit
  /// Executes the editing command paste in web page.
  abstract paste: unit -> unit
  /// Executes the editing command pasteAndMatchStyle in web page.
  abstract pasteAndMatchStyle: unit -> unit
  /// Prints window's web page. When silent is set to true, Electron will pick the
  /// system's default printer if deviceName is empty and the default settings for
  /// printing. Calling window.print() in web page is equivalent to calling
  /// webContents.print({ silent: false, printBackground: false, deviceName: '' }).
  /// Use page-break-before: always; CSS style to force to print to a new page.
  abstract print: ?options: PrintOptions * ?callback: (bool -> unit) -> unit
  /// Prints window's web page as PDF with Chromium's preview printing custom
  /// settings. The callback will be called with callback(error, data) on completion.
  /// The data is a Buffer that contains the generated PDF data. The landscape will be
  /// ignored if @page CSS at-rule is used in the web page. By default, an empty
  /// options will be regarded as: Use page-break-before: always; CSS style to force
  /// to print to a new page. An example of webContents.printToPDF:
  abstract printToPDF: options: PrintToPDFOptions * callback: (Error -> Buffer -> unit) -> unit
  /// Executes the editing command redo in web page.
  abstract redo: unit -> unit
  /// Reloads the current web page.
  abstract reload: unit -> unit
  /// Reloads current page and ignores cache.
  abstract reloadIgnoringCache: unit -> unit
  /// Removes the specified path from DevTools workspace.
  abstract removeWorkSpace: path: string -> unit
  /// Executes the editing command replace in web page.
  abstract replace: text: string -> unit
  /// Executes the editing command replaceMisspelling in web page.
  abstract replaceMisspelling: text: string -> unit
  abstract savePage: fullPath: string * saveType: WebContentSaveType * callback: (Error -> unit) -> bool
  /// Executes the editing command selectAll in web page.
  abstract selectAll: unit -> unit
  /// Send an asynchronous message to renderer process via channel, you can also send
  /// arbitrary arguments. Arguments will be serialized in JSON internally and hence
  /// no (Event -> unit)s or prototype chain will be included. The renderer process can
  /// handle the message by listening to channel with the ipcRenderer module. An
  /// example of sending messages from the main process to the renderer process:
  abstract send: channel: string * [<ParamArray>] args: obj [] -> unit
  /// Sends an input event to the page. Note: The BrowserWindow containing the
  /// contents needs to be focused for sendInputEvent() to work. For keyboard events,
  /// the event object also have following properties: For mouse events, the event
  /// object also have following properties: For the mouseWheel event, the event
  /// object also have following properties:
  abstract sendInputEvent: event: Event -> unit
  /// Send an asynchronous message to a specific frame in a renderer process via
  /// channel. Arguments will be serialized as JSON internally and as such no
  /// (Event -> unit)s or prototype chains will be included. The renderer process can handle
  /// the message by listening to channel with the ipcRenderer module. If you want to
  /// get the frameId of a given renderer context you should use the
  /// webFrame.routingId value.  E.g. You can also read frameId from all incoming IPC
  /// messages in the main process.
  abstract sendToFrame: frameId: int * channel: string * [<ParamArray>] args: obj [] -> unit
  /// Mute the audio on the current web page.
  abstract setAudioMuted: muted: bool -> unit
  /// Controls whether or not this WebContents will throttle animations and timers
  /// when the page becomes backgrounded. This also affects the Page Visibility API.
  abstract setBackgroundThrottling: allowed: bool -> unit
  /// Uses the devToolsWebContents as the target WebContents to show devtools. The
  /// devToolsWebContents must not have done any navigation, and it should not be used
  /// for other purposes after the call. By default Electron manages the devtools by
  /// creating an internal WebContents with native view, which developers have very
  /// limited control of. With the setDevToolsWebContents method, developers can use
  /// any WebContents to show the devtools in it, including BrowserWindow, BrowserView
  /// and <webview> tag. Note that closing the devtools does not destroy the
  /// devToolsWebContents, it is caller's responsibility to destroy
  /// devToolsWebContents. An example of showing devtools in a <webview> tag: An
  /// example of showing devtools in a BrowserWindow:
  abstract setDevToolsWebContents: devToolsWebContents: WebContents -> unit
  /// If offscreen rendering is enabled sets the frame rate to the specified number.
  /// Only values between 1 and 60 are accepted.
  abstract setFrameRate: fps: int -> unit
  /// Ignore application menu shortcuts while this web contents is focused.
  abstract setIgnoreMenuShortcuts: ignore: bool -> unit
  /// Sets the maximum and minimum layout-based (i.e. non-visual) zoom level.
  abstract setLayoutZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
  /// Overrides the user agent for this web page.
  abstract setUserAgent: userAgent: string -> unit
  /// Sets the maximum and minimum pinch-to-zoom level.
  abstract setVisualZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
  /// Setting the WebRTC IP handling policy allows you to control which IPs are
  /// exposed via WebRTC. See BrowserLeaks for more details.
  abstract setWebRTCIPHandlingPolicy: policy: WebRtcIpHandlingPolicy -> unit
  /// Changes the zoom factor to the specified factor. Zoom factor is zoom percent
  /// divided by 100, so 300% = 3.0.
  abstract setZoomFactor: factor: float -> unit
  /// Changes the zoom level to the specified level. The original size is 0 and each
  /// increment above or below represents zooming 20% larger or smaller to default
  /// limits of 300% and 50% of original size, respectively. The formula for this is
  /// scale := 1.2 ^ level.
  abstract setZoomLevel: level: float -> unit
  /// Shows pop-up dictionary that searches the selected word on the page.
  abstract showDefinitionForSelection: unit -> unit
  /// Sets the item as dragging item for current drag-drop operation, file is the
  /// absolute path of the file to be dragged, and icon is the image showing under the
  /// cursor when dragging.
  abstract startDrag: item: DraggedItem -> unit
  /// If offscreen rendering is enabled and not painting, start painting.
  abstract startPainting: unit -> unit
  /// Stops any pending navigation.
  abstract stop: unit -> unit
  /// Stops any findInPage request for the webContents with the provided action.
  abstract stopFindInPage: action: StopFindInPageAction -> unit
  /// If offscreen rendering is enabled and painting, stop painting.
  abstract stopPainting: unit -> unit
  /// Takes a V8 heap snapshot and saves it to filePath.
  abstract takeHeapSnapshot: filePath: string -> Promise<unit>
  /// Toggles the developer tools.
  abstract toggleDevTools: unit -> unit
  /// Executes the editing command undo in web page.
  abstract undo: unit -> unit
  /// Unregisters any ServiceWorker if present and returns a boolean as response to
  /// callback when the JS promise is fulfilled or false when the JS promise is
  /// rejected.
  abstract unregisterServiceWorker: callback: (bool -> unit) -> unit
  /// Executes the editing command unselect in web page.
  abstract unselect: unit -> unit
  abstract debugger: Debugger with get, set
  abstract devToolsWebContents: WebContents with get, set
  abstract hostWebContents: WebContents with get, set
  abstract id: int with get, set
  abstract session: Session with get, set

type WebContentsStatic =
  abstract fromId: id: int -> WebContents
  abstract getAllWebContents: unit -> WebContents []
  abstract getFocusedWebContents: unit -> WebContents

type WebFrame =
  inherit EventEmitter<WebFrame>
  /// Attempts to free memory that is no longer being used (like images from a
  /// previous navigation). Note that blindly calling this method probably makes
  /// Electron slower since it will have to refill these emptied caches, you should
  /// only call it if an event in your app has occurred that makes you think your page
  /// is actually using less memory (i.e. you have navigated from a super heavy page
  /// to a mostly empty one, and intend to stay there).
  abstract clearCache: unit -> unit
  /// Evaluates code in page. In the browser window some HTML APIs like
  /// requestFullScreen can only be invoked by a gesture from the user. Setting
  /// userGesture to true will remove this limitation.
  abstract executeJavaScript: code: string * ?userGesture: bool * ?callback: (obj option -> unit) -> Promise<obj option>
  /// Work like executeJavaScript but evaluates scripts in an isolated context.
  abstract executeJavaScriptInIsolatedWorld: worldId: int * scripts: WebSource [] * ?userGesture: bool * ?callback: (obj option -> unit) -> unit
  abstract findFrameByName: name: string -> WebFrame
  abstract findFrameByRoutingId: routingId: int -> WebFrame
  abstract getFrameForSelector: selector: string -> WebFrame
  /// Returns an object describing usage information of Blink's internal memory
  /// caches. This will generate:
  abstract getResourceUsage: unit -> ResourceUsage
  abstract getZoomFactor: unit -> float
  abstract getZoomLevel: unit -> float
  /// Inserts text to the focused element.
  abstract insertText: text: string -> unit
  /// Set the content security policy of the isolated world.
  abstract setIsolatedWorldContentSecurityPolicy: worldId: int * csp: string -> unit
  /// Set the name of the isolated world. Useful in devtools.
  abstract setIsolatedWorldHumanReadableName: worldId: int * name: string -> unit
  /// Set the security origin, content security policy and name of the isolated world.
  /// Note: If the csp is specified, then the securityOrigin also has to be specified.
  abstract setIsolatedWorldInfo: worldId: int * info: IsolatedWorldInfo -> unit
  /// Set the security origin of the isolated world.
  abstract setIsolatedWorldSecurityOrigin: worldId: int * securityOrigin: string -> unit
  /// Sets the maximum and minimum layout-based (i.e. non-visual) zoom level.
  abstract setLayoutZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
  /// Sets a provider for spell checking in input fields and text areas. The provider
  /// must be an object that has a spellCheck method that accepts an array of
  /// individual words for spellchecking. The spellCheck (Event -> unit) runs asynchronously
  /// and calls the callback (Event -> unit) with an array of misspelt words when complete.
  /// An example of using node-spellchecker as provider:
  abstract setSpellCheckProvider: language: string * provider: SpellCheckProvider -> unit
  /// Sets the maximum and minimum pinch-to-zoom level.
  abstract setVisualZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
  /// Changes the zoom factor to the specified factor. Zoom factor is zoom percent
  /// divided by 100, so 300% = 3.0.
  abstract setZoomFactor: factor: float -> unit
  /// Changes the zoom level to the specified level. The original size is 0 and each
  /// increment above or below represents zooming 20% larger or smaller to default
  /// limits of 300% and 50% of original size, respectively.
  abstract setZoomLevel: level: float -> unit
  /// A WebFrame representing the first child frame of webFrame, the property would be
  /// null if webFrame has no children or if first child is not in the current
  /// renderer process.
  abstract firstChild: WebFrame option with get, set
  /// A WebFrame representing next sibling frame, the property would be null if
  /// webFrame is the last frame in its parent or if the next sibling is not in the
  /// current renderer process.
  abstract nextSibling: WebFrame option with get, set
  /// A WebFrame representing the frame which opened webFrame, the property would be
  /// null if there's no opener or opener is not in the current renderer process.
  abstract opener: WebFrame option with get, set
  /// A WebFrame representing parent frame of webFrame, the property would be null if
  /// webFrame is top or parent is not in the current renderer process.
  abstract parent: WebFrame option with get, set
  /// An Integer representing the unique frame id in the current renderer process.
  /// Distinct WebFrame instances that refer to the same underlying frame will have
  /// the same routingId.
  abstract routingId: int with get, set
  /// A WebFrame representing top frame in frame hierarchy to which webFrame belongs,
  /// the property would be null if top frame is not in the current renderer process.
  abstract top: WebFrame option with get, set

type WebRequest =
  inherit EventEmitter<WebRequest>
  /// The listener will be called with listener(details) when a server initiated
  /// redirect is about to occur.
  abstract onBeforeRedirect: listener: (OnBeforeRedirectDetails -> unit) option -> unit
  /// The listener will be called with listener(details) when a server initiated
  /// redirect is about to occur.
  abstract onBeforeRedirect: filter: OnBeforeRedirectFilter * listener: (OnBeforeRedirectDetails -> unit) option -> unit
  /// The listener will be called with listener(details, callback) when a request is
  /// about to occur. The uploadData is an array of UploadData objects. The callback
  /// has to be called with an response object.
  abstract onBeforeRequest: listener: (OnBeforeRequestDetails -> (OnBeforeRequestResponse -> unit) -> unit) option -> unit
  /// The listener will be called with listener(details, callback) when a request is
  /// about to occur. The uploadData is an array of UploadData objects. The callback
  /// has to be called with an response object.
  abstract onBeforeRequest: filter: OnBeforeRequestFilter * listener: (OnBeforeRequestDetails -> (OnBeforeRequestResponse -> unit) -> unit) option -> unit
  /// The listener will be called with listener(details, callback) before sending an
  /// HTTP request, once the request headers are available. This may occur after a TCP
  /// connection is made to the server, but before any http data is sent. The callback
  /// has to be called with an response object.
  abstract onBeforeSendHeaders: filter: OnBeforeSendHeadersFilter * listener: (OnBeforeSendHeadersDetails -> (OnBeforeSendHeadersResponse -> unit) -> unit) option -> unit
  /// The listener will be called with listener(details, callback) before sending an
  /// HTTP request, once the request headers are available. This may occur after a TCP
  /// connection is made to the server, but before any http data is sent. The callback
  /// has to be called with an response object.
  abstract onBeforeSendHeaders: listener: (OnBeforeSendHeadersDetails -> (OnBeforeSendHeadersResponse -> unit) -> unit) option -> unit
  /// The listener will be called with listener(details) when a request is completed.
  abstract onCompleted: filter: OnCompletedFilter * listener: (OnCompletedDetails -> unit) option -> unit
  /// The listener will be called with listener(details) when a request is completed.
  abstract onCompleted: listener: (OnCompletedDetails -> unit) option -> unit
  /// The listener will be called with listener(details) when an error occurs.
  abstract onErrorOccurred: listener: (OnErrorOccurredDetails -> unit) option -> unit
  /// The listener will be called with listener(details) when an error occurs.
  abstract onErrorOccurred: filter: OnErrorOccurredFilter * listener: (OnErrorOccurredDetails -> unit) option -> unit
  /// The listener will be called with listener(details, callback) when HTTP response
  /// headers of a request have been received. The callback has to be called with an
  /// response object.
  abstract onHeadersReceived: filter: OnHeadersReceivedFilter * listener: (OnHeadersReceivedDetails -> (OnHeadersReceivedResponse -> unit) -> unit) option -> unit
  /// The listener will be called with listener(details, callback) when HTTP response
  /// headers of a request have been received. The callback has to be called with an
  /// response object.
  abstract onHeadersReceived: listener: (OnHeadersReceivedDetails -> (OnHeadersReceivedResponse -> unit) -> unit) option -> unit
  /// The listener will be called with listener(details) when first byte of the
  /// response body is received. For HTTP requests, this means that the status line
  /// and response headers are available.
  abstract onResponseStarted: listener: (OnResponseStartedDetails -> unit) option -> unit
  /// The listener will be called with listener(details) when first byte of the
  /// response body is received. For HTTP requests, this means that the status line
  /// and response headers are available.
  abstract onResponseStarted: filter: OnResponseStartedFilter * listener: (OnResponseStartedDetails -> unit) option -> unit
  /// The listener will be called with listener(details) just before a request is
  /// going to be sent to the server, modifications of previous onBeforeSendHeaders
  /// response are visible by the time this listener is fired.
  abstract onSendHeaders: filter: OnSendHeadersFilter * listener: (OnSendHeadersDetails -> unit) option -> unit
  /// The listener will be called with listener(details) just before a request is
  /// going to be sent to the server, modifications of previous onBeforeSendHeaders
  /// response are visible by the time this listener is fired.
  abstract onSendHeaders: listener: (OnSendHeadersDetails -> unit) option -> unit

type WebSource =
  abstract code: string with get, set
  /// Default is 1.
  abstract startLine: int with get, set
  abstract url: string with get, set

type AboutPanelOptions =
  /// The app's name.
  abstract applicationName: string with get, set
  /// The app's version.
  abstract applicationVersion: string with get, set
  /// Copyright information.
  abstract copyright: string with get, set
  /// The app's build version number.
  abstract version: string with get, set
  /// Credit information.
  abstract credits: string with get, set
  /// The app's website.
  abstract website: string with get, set
  /// Path to the app's icon.
  abstract iconPath: string with get, set

type NativeImageRepresentationOptions =
  /// The scale factor to add the image representation for.
  abstract scaleFactor: float with get, set
  /// Defaults to 0. Required if a bitmap buffer is specified as buffer.
  abstract width: int with get, set
  /// Defaults to 0. Required if a bitmap buffer is specified as buffer.
  abstract height: int with get, set
  /// The buffer containing the raw image data.
  abstract buffer: Buffer with get, set
  /// The data URL containing either a base 64 encoded PNG or JPEG image.
  abstract dataURL: string with get, set

type AppDetailsOptions =
  /// Window's . It has to be set, otherwise the other options will have no effect.
  abstract appId: string with get, set
  /// Window's .
  abstract appIconPath: string with get, set
  /// Index of the icon in appIconPath. Ignored when appIconPath is not set. Default
  /// is 0.
  abstract appIconIndex: int with get, set
  /// Window's .
  abstract relaunchCommand: string with get, set
  /// Window's .
  abstract relaunchDisplayName: string with get, set

type AuthInfo =
  abstract isProxy: bool with get, set
  abstract scheme: string with get, set
  abstract host: string with get, set
  abstract port: int with get, set
  abstract realm: string with get, set

type AutoResizeOptions =
  /// If true, the view's width will grow and shrink together with the window. false
  /// by default.
  abstract width: bool with get, set
  /// If true, the view's height will grow and shrink together with the window. false
  /// by default.
  abstract height: bool with get, set

type BitmapOptions =
  /// Defaults to 1.0.
  abstract scaleFactor: float with get, set

type BrowserViewOptions =
  /// See BrowserWindow.
  abstract webPreferences: WebPreferences with get, set

[<StringEnum; RequireQualifiedAccess>]
type TitleBarStyle =
  | Default
  | Hidden
  | HiddenInset
  | CustomButtonsOnHover

type BrowserWindowOptions =
  /// Window's width in pixels. Default is 800.
  abstract width: int with get, set
  /// Window's height in pixels. Default is 600.
  abstract height: int with get, set
  /// ( if y is used) Window's left offset from screen. Default is to center the
  /// window.
  abstract x: int with get, set
  /// ( if x is used) Window's top offset from screen. Default is to center the
  /// window.
  abstract y: int with get, set
  /// The width and height would be used as web page's size, which means the actual
  /// window's size will include window frame's size and be slightly larger. Default
  /// is false.
  abstract useContentSize: bool with get, set
  /// Show window in the center of the screen.
  abstract center: bool with get, set
  /// Window's minimum width. Default is 0.
  abstract minWidth: int with get, set
  /// Window's minimum height. Default is 0.
  abstract minHeight: int with get, set
  /// Window's maximum width. Default is no limit.
  abstract maxWidth: int with get, set
  /// Window's maximum height. Default is no limit.
  abstract maxHeight: int with get, set
  /// Whether window is resizable. Default is true.
  abstract resizable: bool with get, set
  /// Whether window is movable. This is not implemented on Linux. Default is true.
  abstract movable: bool with get, set
  /// Whether window is minimizable. This is not implemented on Linux. Default is
  /// true.
  abstract minimizable: bool with get, set
  /// Whether window is maximizable. This is not implemented on Linux. Default is
  /// true.
  abstract maximizable: bool with get, set
  /// Whether window is closable. This is not implemented on Linux. Default is true.
  abstract closable: bool with get, set
  /// Whether the window can be focused. Default is true. On Windows setting
  /// focusable: false also implies setting skipTaskbar: true. On Linux setting
  /// focusable: false makes the window stop interacting with wm, so the window will
  /// always stay on top in all workspaces.
  abstract focusable: bool with get, set
  /// Whether the window should always stay on top of other windows. Default is false.
  abstract alwaysOnTop: bool with get, set
  /// Whether the window should show in fullscreen. When explicitly set to false the
  /// fullscreen button will be hidden or disabled on macOS. Default is false.
  abstract fullscreen: bool with get, set
  /// Whether the window can be put into fullscreen mode. On macOS, also whether the
  /// maximize/zoom button should toggle full screen mode or maximize window. Default
  /// is true.
  abstract fullscreenable: bool with get, set
  /// Use pre-Lion fullscreen on macOS. Default is false.
  abstract simpleFullscreen: bool with get, set
  /// Whether to show the window in taskbar. Default is false.
  abstract skipTaskbar: bool with get, set
  /// The kiosk mode. Default is false.
  abstract kiosk: bool with get, set
  /// Default window title. Default is "Electron". If the HTML tag is defined in the
  /// HTML file loaded by loadURL(), this property will be ignored.
  abstract title: string with get, set
  /// The window icon. On Windows it is recommended to use ICO icons to get best
  /// visual effects, you can also leave it undefined so the executable's icon will be
  /// used.
  abstract icon: U2<NativeImage, string> with get, set
  /// Whether window should be shown when created. Default is true.
  abstract show: bool with get, set
  /// Specify false to create a . Default is true.
  abstract frame: bool with get, set
  /// Specify parent window. Default is null.
  abstract parent: BrowserWindow option with get, set
  /// Whether this is a modal window. This only works when the window is a child
  /// window. Default is false.
  abstract modal: bool with get, set
  /// Whether the web view accepts a single mouse-down event that simultaneously
  /// activates the window. Default is false.
  abstract acceptFirstMouse: bool with get, set
  /// Whether to hide cursor when typing. Default is false.
  abstract disableAutoHideCursor: bool with get, set
  /// Auto hide the menu bar unless the Alt key is pressed. Default is false.
  abstract autoHideMenuBar: bool with get, set
  /// Enable the window to be resized larger than screen. Default is false.
  abstract enableLargerThanScreen: bool with get, set
  /// Window's background color as a hexadecimal value, like #66CD00 or #FFF or
  /// #80FFFFFF (alpha in #AARRGGBB format is supported if transparent is set to
  /// true). Default is #FFF (white).
  abstract backgroundColor: string with get, set
  /// Whether window should have a shadow. This is only implemented on macOS. Default
  /// is true.
  abstract hasShadow: bool with get, set
  /// Set the initial opacity of the window, between 0.0 (fully transparent) and 1.0
  /// (fully opaque). This is only implemented on Windows and macOS.
  abstract opacity: float with get, set
  /// Forces using dark theme for the window, only works on some GTK+3 desktop
  /// environments. Default is false.
  abstract darkTheme: bool with get, set
  /// Makes the window . Default is false.
  abstract transparent: bool with get, set
  /// The type of window, default is normal window. See more about this below.
  abstract ``type``: string with get, set
  /// The style of window title bar. Default is default. Possible values are:
  abstract titleBarStyle: TitleBarStyle with get, set
  /// Shows the title in the title bar in full screen mode on macOS for all
  /// titleBarStyle options. Default is false.
  abstract fullscreenWindowTitle: bool with get, set
  /// Use WS_THICKFRAME style for frameless windows on Windows, which adds standard
  /// window frame. Setting it to false will remove window shadow and window
  /// animations. Default is true.
  abstract thickFrame: bool with get, set
  /// Add a type of vibrancy effect to the window, only on macOS. Can be
  /// appearance-based, light, dark, titlebar, selection, menu, popover, sidebar,
  /// medium-light or ultra-dark. Please note that using frame: false in combination
  /// with a vibrancy value requires that you use a non-default titleBarStyle as well.
  abstract vibrancy: VibrancyType with get, set
  /// Controls the behavior on macOS when option-clicking the green stoplight button
  /// on the toolbar or by clicking the Window > Zoom menu item. If true, the window
  /// will grow to the preferred width of the web page when zoomed, false will cause
  /// it to zoom to the width of the screen. This will also affect the behavior when
  /// calling maximize() directly. Default is false.
  abstract zoomToPageWidth: bool with get, set
  /// Tab group name, allows opening the window as a native tab on macOS 10.12+.
  /// Windows with the same tabbing identifier will be grouped together. This also
  /// adds a native new tab button to your window's tab bar and allows your app and
  /// window to receive the new-window-for-tab event.
  abstract tabbingIdentifier: string with get, set
  /// Settings of web page's features.
  abstract webPreferences: WebPreferences with get, set

type CertificateTrustDialogOptions =
  /// The certificate to trust/import.
  abstract certificate: Certificate with get, set
  /// The message to display to the user.
  abstract message: string with get, set

type CertificateVerifyProcRequest =
  abstract hostname: string with get, set
  abstract certificate: Certificate with get, set
  /// Verification result from chromium.
  abstract verificationResult: string with get, set
  /// Error code.
  abstract errorCode: int with get, set

[<StringEnum; RequireQualifiedAccess>]
type StorageType =
  | [<CompiledName("appcache")>] AppCache
  | Cookies
  | [<CompiledName("filesystem")>] FileSystem
  | [<CompiledName("indexdb")>] IndexDb
  | [<CompiledName("localstorage")>] LocalStorage
  | [<CompiledName("shadercache")>] ShaderCache
  | [<CompiledName("websql")>] WebSql
  | [<CompiledName("serviceworkers")>] ServiceWorkers
  | [<CompiledName("cachestorage")>] CacheStorage

[<StringEnum; RequireQualifiedAccess>]
type StorageQuota =
  | Temporary
  | Persistent
  | Syncable

type ClearStorageDataOptions =
  /// Should follow window.location.origin’s representation scheme://host:port.
  abstract origin: string with get, set
  /// The types of storages to clear, can contain: appcache, cookies, filesystem,
  /// indexdb, localstorage, shadercache, websql, serviceworkers, cachestorage.
  abstract storages: StorageType [] with get, set
  /// The types of quotas to clear, can contain: temporary, persistent, syncable.
  abstract quotas: StorageQuota [] with get, set

type CommandLine =
  /// Append a switch (with optional value) to Chromium's command line. Note: This
  /// will not affect process.argv, and is mainly used by developers to control some
  /// low-level Chromium behaviors.
  abstract appendSwitch: (string -> string -> unit) with get, set
  /// Append an argument to Chromium's command line. The argument will be quoted
  /// correctly. Note: This will not affect process.argv.
  abstract appendArgument: (string -> unit) with get, set
  abstract hasSwitch: (string -> bool) with get, set
  /// Note: When the switch is not present, it returns empty string.
  abstract getSwitchValue: (string -> string) with get, set

type ProxyConfig =
  /// The URL associated with the PAC file.
  abstract pacScript: string with get, set
  /// Rules indicating which proxies to use.
  abstract proxyRules: string with get, set
  /// Rules indicating which URLs should bypass the proxy settings.
  abstract proxyBypassRules: string with get, set

[<StringEnum; RequireQualifiedAccess>]
type ContextMenuMediaType =
  | None
  | Image
  | Audio
  | Video
  | Canvas
  | File
  | Plugin

[<StringEnum; RequireQualifiedAccess>]
type ContextMenuSourceType =
  | None
  | Mouse
  | Keyboard
  | Touch
  | TouchMenu

type ContextMenuParams =
  /// x coordinate.
  abstract x: int with get, set
  /// y coordinate.
  abstract y: int with get, set
  /// URL of the link that encloses the node the context menu was invoked on.
  abstract linkURL: string with get, set
  /// Text associated with the link. May be an empty string if the contents of the
  /// link are an image.
  abstract linkText: string with get, set
  /// URL of the top level page that the context menu was invoked on.
  abstract pageURL: string with get, set
  /// URL of the subframe that the context menu was invoked on.
  abstract frameURL: string with get, set
  /// Source URL for the element that the context menu was invoked on. Elements with
  /// source URLs are images, audio and video.
  abstract srcURL: string with get, set
  /// Type of the node the context menu was invoked on. Can be none, image, audio,
  /// video, canvas, file or plugin.
  abstract mediaType: ContextMenuMediaType with get, set
  /// Whether the context menu was invoked on an image which has non-empty contents.
  abstract hasImageContents: bool with get, set
  /// Whether the context is editable.
  abstract isEditable: bool with get, set
  /// Text of the selection that the context menu was invoked on.
  abstract selectionText: string with get, set
  /// Title or alt text of the selection that the context was invoked on.
  abstract titleText: string with get, set
  /// The misspelled word under the cursor, if any.
  abstract misspelledWord: string with get, set
  /// The character encoding of the frame on which the menu was invoked.
  abstract frameCharset: string with get, set
  /// If the context menu was invoked on an input field, the type of that field.
  /// Possible values are none, plainText, password, other.
  abstract inputFieldType: string with get, set
  /// Input source that invoked the context menu. Can be none, mouse, keyboard, touch
  /// or touchMenu.
  abstract menuSourceType: ContextMenuSourceType with get, set
  /// The flags for the media element the context menu was invoked on.
  abstract mediaFlags: ContextMenuMediaFlags with get, set
  /// These flags indicate whether the renderer believes it is able to perform the
  /// corresponding action.
  abstract editFlags: ContextMenuEditFlags with get, set

type CrashReporterStartOptions =
  abstract companyName: string with get, set
  /// URL that crash reports will be sent to as POST.
  abstract submitURL: string with get, set
  /// Defaults to app.getName().
  abstract productName: string with get, set
  /// Whether crash reports should be sent to the server Default is true.
  abstract uploadToServer: bool with get, set
  /// Default is false.
  abstract ignoreSystemCrashHandler: bool with get, set
  /// An object you can define that will be sent along with the report. Only string
  /// properties are sent correctly. Nested objects are not supported and the property
  /// names and values must be less than 64 characters long.
  abstract extra: obj with get, set
  /// Directory to store the crashreports temporarily (only used when the crash
  /// reporter is started via process.crashReporter.start).
  abstract crashesDirectory: string with get, set

type NativeImageFromBufferOptions =
  /// Required for bitmap buffers.
  abstract width: int with get, set
  /// Required for bitmap buffers.
  abstract height: int with get, set
  /// Defaults to 1.0.
  abstract scaleFactor: float with get, set

type CreateInterruptedDownloadOptions =
  /// Absolute path of the download.
  abstract path: string with get, set
  /// Complete URL chain for the download.
  abstract urlChain: string [] with get, set
  abstract mimeType: string with get, set
  /// Start range for the download.
  abstract offset: int with get, set
  /// Total length of the download.
  abstract length: int with get, set
  /// Last-Modified header value.
  abstract lastModified: string with get, set
  /// ETag header value.
  abstract eTag: string with get, set
  /// Time when download was started in number of seconds since UNIX epoch.
  abstract startTime: float with get, set

type ClipboardData =
  abstract text: string with get, set
  abstract html: string with get, set
  abstract image: NativeImage with get, set
  abstract rtf: string with get, set
  /// The title of the url at text.
  abstract bookmark: string with get, set

type CookieDetails =
  /// The url to associate the cookie with.
  abstract url: string with get, set
  /// The name of the cookie. Empty by default if omitted.
  abstract name: string with get, set
  /// The value of the cookie. Empty by default if omitted.
  abstract value: string with get, set
  /// The domain of the cookie. Empty by default if omitted.
  abstract domain: string with get, set
  /// The path of the cookie. Empty by default if omitted.
  abstract path: string with get, set
  /// Whether the cookie should be marked as Secure. Defaults to false.
  abstract secure: bool with get, set
  /// Whether the cookie should be marked as HTTP only. Defaults to false.
  abstract httpOnly: bool with get, set
  /// The expiration date of the cookie as the number of seconds since the UNIX epoch.
  /// If omitted then the cookie becomes a session cookie and will not be retained
  /// between sessions.
  abstract expirationDate: float with get, set

type DisplayBalloonOptions =
  abstract icon: U2<NativeImage, string> with get, set
  abstract title: string with get, set
  abstract content: string with get, set

[<StringEnum; RequireQualifiedAccess>]
type DockBounceType =
  | Critical
  | Informational

type Dock =
  /// When critical is passed, the dock icon will bounce until either the application
  /// becomes active or the request is canceled. When informational is passed, the
  /// dock icon will bounce for one second. However, the request remains active until
  /// either the application becomes active or the request is canceled.
  abstract bounce: (DockBounceType -> int) with get, set
  /// Cancel the bounce of id.
  abstract cancelBounce: (int -> unit) with get, set
  /// Bounces the Downloads stack if the filePath is inside the Downloads folder.
  abstract downloadFinished: (string -> unit) with get, set
  /// Sets the string to be displayed in the dock’s badging area.
  abstract setBadge: (string -> unit) with get, set
  abstract getBadge: (unit -> string) with get, set
  /// Hides the dock icon.
  abstract hide: (unit -> unit) with get, set
  /// Shows the dock icon.
  abstract show: (unit -> unit) with get, set
  abstract isVisible: (unit -> bool) with get, set
  /// Sets the application's dock menu.
  abstract setMenu: (Menu -> unit) with get, set
  /// Sets the image associated with this dock icon.
  abstract setIcon: (U2<NativeImage, string> -> unit) with get, set

type EnableNetworkEmulationOptions =
  /// Whether to emulate network outage. Defaults to false.
  abstract offline: bool with get, set
  /// RTT in ms. Defaults to 0 which will disable latency throttling.
  abstract latency: float with get, set
  /// Download rate in Bps. Defaults to 0 which will disable download throttling.
  abstract downloadThroughput: float with get, set
  /// Upload rate in Bps. Defaults to 0 which will disable upload throttling.
  abstract uploadThroughput: float with get, set

[<StringEnum; RequireQualifiedAccess>]
type AutoOpdateFeedServerType =
  | Json
  | Default

type AutoOpdateFeedOptions =
  abstract url: string with get, set
  /// HTTP request headers.
  abstract headers: obj with get, set
  /// Either json or default, see the README for more information.
  abstract serverType: AutoOpdateFeedServerType with get, set

[<StringEnum; RequireQualifiedAccess>]
type FileIconSize =
  | Small
  | Normal
  | Large

type FileIconOptions =
  abstract size: FileIconSize with get, set

type CookieFilter =
  /// Retrieves cookies which are associated with url. Empty implies retrieving
  /// cookies of all urls.
  abstract url: string with get, set
  /// Filters cookies by name.
  abstract name: string with get, set
  /// Retrieves cookies whose domains match or are subdomains of domains.
  abstract domain: string with get, set
  /// Retrieves cookies whose path matches path.
  abstract path: string with get, set
  /// Filters cookies by their Secure property.
  abstract secure: bool with get, set
  /// Filters out session or persistent cookies.
  abstract session: bool with get, set

type FindInPageOptions =
  /// Whether to search forward or backward, defaults to true.
  abstract forward: bool with get, set
  /// Whether the operation is first request or a follow up, defaults to false.
  abstract findNext: bool with get, set
  /// Whether search should be case-sensitive, defaults to false.
  abstract matchCase: bool with get, set
  /// Whether to look only at the start of words. defaults to false.
  abstract wordStart: bool with get, set
  /// When combined with wordStart, accepts a match in the middle of a word if the
  /// match begins with an uppercase letter followed by a lowercase or non-letter.
  /// Accepts several other intra-word matches, defaults to false.
  abstract medialCapitalAsWordStart: bool with get, set

type FromPartitionOptions =
  /// Whether to enable cache.
  abstract cache: bool with get, set

type ExtraHeaderValue =
  /// Specify an extra header name.
  abstract name: string with get, set

type HeapStatistics =
  abstract totalHeapSize: int with get, set
  abstract totalHeapSizeExecutable: int with get, set
  abstract totalPhysicalSize: int with get, set
  abstract totalAvailableSize: int with get, set
  abstract usedHeapSize: int with get, set
  abstract heapSizeLimit: int with get, set
  abstract mallocedMemory: int with get, set
  abstract peakMallocedMemory: int with get, set
  abstract doesZapGarbage: bool with get, set

type IgnoreMouseEventsOptions =
  /// If true, forwards mouse move messages to Chromium, enabling mouse related events
  /// such as mouseleave. Only used when ignore is true. If ignore is false,
  /// forwarding is always disabled regardless of this value.
  abstract forward: bool with get, set

type ImportCertificateOptions =
  /// Path for the pkcs12 file.
  abstract certificate: string with get, set
  /// Passphrase for the certificate.
  abstract password: string with get, set

type IsolatedWorldInfo =
  /// Security origin for the isolated world.
  abstract securityOrigin: string with get, set
  /// Content Security Policy for the isolated world.
  abstract csp: string with get, set
  /// Name for isolated world. Useful in devtools.
  abstract name: string with get, set

type BeforeInputEventData =
  /// Either keyUp or keyDown.
  abstract ``type``: string with get, set
  /// Equivalent to .
  abstract key: string with get, set
  /// Equivalent to .
  abstract code: string with get, set
  /// Equivalent to .
  abstract isAutoRepeat: bool with get, set
  /// Equivalent to .
  abstract shift: bool with get, set
  /// Equivalent to .
  abstract control: bool with get, set
  /// Equivalent to .
  abstract alt: bool with get, set
  /// Equivalent to .
  abstract meta: bool with get, set

type InterceptBufferProtocolRequest =
  abstract url: string with get, set
  abstract referrer: string with get, set
  abstract method: string with get, set
  abstract uploadData: UploadData [] with get, set

type InterceptFileProtocolRequest =
  abstract url: string with get, set
  abstract referrer: string with get, set
  abstract method: string with get, set
  abstract uploadData: UploadData [] with get, set

type InterceptHttpProtocolRequest =
  abstract url: string with get, set
  abstract headers: obj with get, set
  abstract referrer: string with get, set
  abstract method: string with get, set
  abstract uploadData: UploadData [] with get, set

type InterceptStreamProtocolRequest =
  abstract url: string with get, set
  abstract headers: obj with get, set
  abstract referrer: string with get, set
  abstract method: string with get, set
  abstract uploadData: UploadData [] with get, set

type InterceptStringProtocolRequest =
  abstract url: string with get, set
  abstract referrer: string with get, set
  abstract method: string with get, set
  abstract uploadData: UploadData [] with get, set

type DraggedItem =
  /// or files Array The path(s) to the file(s) being dragged.
  abstract file: string with get, set
  /// The image must be non-empty on macOS.
  abstract icon: NativeImage with get, set

type JumpListSettings =
  /// The minimum number of items that will be shown in the Jump List (for a more
  /// detailed description of this value see the ).
  abstract minItems: int with get, set
  /// Array of JumpListItem objects that correspond to items that the user has
  /// explicitly removed from custom categories in the Jump List. These items must not
  /// be re-added to the Jump List in the call to app.setJumpList(), Windows will not
  /// display any custom category that contains any of the removed items.
  abstract removedItems: JumpListItem [] with get, set

type LoadFileOptions =
  /// Passed to url.format().
  abstract query: obj with get, set
  /// Passed to url.format().
  abstract search: string with get, set
  /// Passed to url.format().
  abstract hash: string with get, set

type LoadURLOptions =
  /// An HTTP Referrer url.
  abstract httpReferrer: U2<string, Referrer> with get, set
  /// A user agent originating the request.
  abstract userAgent: string with get, set
  /// Extra headers separated by "\n"
  abstract extraHeaders: string with get, set
  abstract postData: U3<UploadRawData [], UploadFile [], UploadBlob []> with get, set
  /// Base url (with trailing path separator) for files to be loaded by the data url.
  /// This is needed only if the specified url is a data url and needs to load other
  /// files.
  abstract baseURLForDataURL: string with get, set

type LoginItemSettings =
  abstract openAtLogin: bool with get, set
  /// true if the app is set to open as hidden at login. This setting is not available
  /// on .
  abstract openAsHidden: bool with get, set
  /// true if the app was opened at login automatically. This setting is not available
  /// on .
  abstract wasOpenedAtLogin: bool with get, set
  /// true if the app was opened as a hidden login item. This indicates that the app
  /// should not open any windows at startup. This setting is not available on .
  abstract wasOpenedAsHidden: bool with get, set
  /// true if the app was opened as a login item that should restore the state from
  /// the previous session. This indicates that the app should restore the windows
  /// that were open the last time the app was closed. This setting is not available
  /// on .
  abstract restoreState: bool with get, set

type GetLoginItemSettingsOptions =
  /// The executable path to compare against. Defaults to process.execPath.
  abstract path: string with get, set
  /// The command-line arguments to compare against. Defaults to an empty array.
  abstract args: string [] with get, set

[<StringEnum; RequireQualifiedAccess>]
type MenuItemRole =
  | Undo
  | Redo
  | Cut
  | Copy
  | Paste
  | [<CompiledName("pasteandmatchstyle")>] PasteAndMatchStyle
  | Delete
  | [<CompiledName("selectall")>] SelectAll
  | Reload
  | [<CompiledName("forcereload")>] Forcereload
  | [<CompiledName("toggledevtools")>] ToggleDevTools
  | [<CompiledName("resetzoom")>] ResetZoom
  | [<CompiledName("zoomin")>] ZoomIn
  | [<CompiledName("zoomout")>] ZoomOut
  | [<CompiledName("togglefullscreen")>] ToggleFullScreen
  | Window
  | Minimize
  | Close
  | Help
  | About
  | Services
  | Hide
  | [<CompiledName("hideothers")>] HideOthers
  | Unhide
  | Quit
  | [<CompiledName("startspeaking")>] StartSpeaking
  | [<CompiledName("stopspeaking")>] StopSpeaking
  | Zoom
  | Front

[<StringEnum; RequireQualifiedAccess>]
type MenuItemType =
  | Normal
  | Separator
  | [<CompiledName("Submenu")>] SubMenu
  | Checkbox
  | Radio

type MenuItemOptions =
  /// Will be called with click(menuItem, browserWindow, event) when the menu item is
  /// clicked.
  abstract click: (MenuItem -> BrowserWindow -> Event -> unit) with get, set
  /// Can be undo, redo, cut, copy, paste, pasteandmatchstyle, delete, selectall,
  /// reload, forcereload, toggledevtools, resetzoom, zoomin, zoomout,
  /// togglefullscreen, window, minimize, close, help, about, services, hide,
  /// hideothers, unhide, quit, startspeaking, stopspeaking, close, minimize, zoom or
  /// front Define the action of the menu item, when specified the click property will
  /// be ignored. See .
  abstract role: MenuItemRole with get, set
  /// Can be normal, separator, submenu, checkbox or radio.
  abstract ``type``: MenuItemType with get, set
  abstract label: string with get, set
  abstract sublabel: string with get, set
  abstract accelerator: string with get, set
  abstract icon: U2<NativeImage, string> with get, set
  /// If false, the menu item will be greyed out and unclickable.
  abstract enabled: bool with get, set
  /// If false, the menu item will be entirely hidden.
  abstract visible: bool with get, set
  /// Should only be specified for checkbox or radio type menu items.
  abstract ``checked``: bool with get, set
  /// If false, the accelerator won't be registered with the system, but it will still
  /// be displayed. Defaults to true.
  abstract registerAccelerator: bool with get, set
  /// Should be specified for submenu type menu items. If submenu is specified, the
  /// type: 'submenu' can be omitted. If the value is not a then it will be
  /// automatically converted to one using Menu.buildFromTemplate.
  abstract submenu: U2<MenuItemOptions [], Menu> with get, set
  /// Unique within a single menu. If defined then it can be used as a reference to
  /// this item by the position attribute.
  abstract id: string with get, set
  /// Inserts this item before the item with the specified label. If the referenced
  /// item doesn't exist the item will be inserted at the end of the menu. Also
  /// implies that the menu item in question should be placed in the same “group” as
  /// the item.
  abstract before: string [] with get, set
  /// Inserts this item after the item with the specified label. If the referenced
  /// item doesn't exist the item will be inserted at the end of the menu.
  abstract after: string [] with get, set
  /// Provides a means for a single context menu to declare the placement of their
  /// containing group before the containing group of the item with the specified
  /// label.
  abstract beforeGroupContaining: string [] with get, set
  /// Provides a means for a single context menu to declare the placement of their
  /// containing group after the containing group of the item with the specified
  /// label.
  abstract afterGroupContaining: string [] with get, set

type MessageBoxOptions =
  /// Can be "none", "info", "error", "question" or "warning". On Windows, "question"
  /// displays the same icon as "info", unless you set an icon using the "icon"
  /// option. On macOS, both "warning" and "error" display the same warning icon.
  abstract ``type``: string with get, set
  /// Array of texts for buttons. On Windows, an empty array will result in one button
  /// labeled "OK".
  abstract buttons: string [] with get, set
  /// Index of the button in the buttons array which will be selected by default when
  /// the message box opens.
  abstract defaultId: int with get, set
  /// Title of the message box, some platforms will not show it.
  abstract title: string with get, set
  /// Content of the message box.
  abstract message: string with get, set
  /// Extra information of the message.
  abstract detail: string with get, set
  /// If provided, the message box will include a checkbox with the given label. The
  /// checkbox state can be inspected only when using callback.
  abstract checkboxLabel: string with get, set
  /// Initial checked state of the checkbox. false by default.
  abstract checkboxChecked: bool with get, set
  abstract icon: NativeImage with get, set
  /// The index of the button to be used to cancel the dialog, via the Esc key. By
  /// default this is assigned to the first button with "cancel" or "no" as the label.
  /// If no such labeled buttons exist and this option is not set, 0 will be used as
  /// the return value or callback response.
  abstract cancelId: int with get, set
  /// On Windows Electron will try to figure out which one of the buttons are common
  /// buttons (like "Cancel" or "Yes"), and show the others as command links in the
  /// dialog. This can make the dialog appear in the style of modern Windows apps. If
  /// you don't like this behavior, you can set noLink to true.
  abstract noLink: bool with get, set
  /// Normalize the keyboard access keys across platforms. Default is false. Enabling
  /// this assumes & is used in the button labels for the placement of the keyboard
  /// shortcut access key and labels will be converted so they work correctly on each
  /// platform, & characters are removed on macOS, converted to _ on Linux, and left
  /// untouched on Windows. For example, a button label of Vie&w will be converted to
  /// Vie_w on Linux and View on macOS and can be selected via Alt-W on Windows and
  /// Linux.
  abstract normalizeAccessKeys: bool with get, set

type NotificationOptions =
  /// A title for the notification, which will be shown at the top of the notification
  /// window when it is shown.
  abstract title: string with get, set
  /// A subtitle for the notification, which will be displayed below the title.
  abstract subtitle: string with get, set
  /// The body text of the notification, which will be displayed below the title or
  /// subtitle.
  abstract body: string with get, set
  /// Whether or not to emit an OS notification noise when showing the notification.
  abstract silent: bool with get, set
  /// An icon to use in the notification.
  abstract icon: U2<string, NativeImage> with get, set
  /// Whether or not to add an inline reply option to the notification.
  abstract hasReply: bool with get, set
  /// The placeholder to write in the inline reply input field.
  abstract replyPlaceholder: string with get, set
  /// The name of the sound file to play when the notification is shown.
  abstract sound: string with get, set
  /// Actions to add to the notification. Please read the available actions and
  /// limitations in the NotificationAction documentation.
  abstract actions: NotificationAction [] with get, set
  /// A custom title for the close button of an alert. An empty string will cause the
  /// default localized text to be used.
  abstract closeButtonText: string with get, set

type OnBeforeRedirectDetails =
  abstract id: int with get, set
  abstract url: string with get, set
  abstract method: string with get, set
  abstract webContentsId: int option with get, set
  abstract resourceType: string with get, set
  abstract referrer: string with get, set
  abstract timestamp: float with get, set
  abstract redirectURL: string with get, set
  abstract statusCode: int with get, set
  /// The server IP address that the request was actually sent to.
  abstract ip: string option with get, set
  abstract fromCache: bool with get, set
  abstract responseHeaders: obj with get, set

type OnBeforeRedirectFilter =
  /// Array of URL patterns that will be used to filter out the requests that do not
  /// match the URL patterns.
  abstract urls: string [] with get, set

type OnBeforeRequestDetails =
  abstract id: int with get, set
  abstract url: string with get, set
  abstract method: string with get, set
  abstract webContentsId: int option with get, set
  abstract resourceType: string with get, set
  abstract referrer: string with get, set
  abstract timestamp: float with get, set
  abstract uploadData: UploadData [] with get, set

type OnBeforeRequestFilter =
  /// Array of URL patterns that will be used to filter out the requests that do not
  /// match the URL patterns.
  abstract urls: string [] with get, set

type OnBeforeSendHeadersDetails =
  abstract id: int with get, set
  abstract url: string with get, set
  abstract method: string with get, set
  abstract webContentsId: int option with get, set
  abstract resourceType: string with get, set
  abstract referrer: string with get, set
  abstract timestamp: float with get, set
  abstract requestHeaders: obj with get, set

type OnBeforeSendHeadersFilter =
  /// Array of URL patterns that will be used to filter out the requests that do not
  /// match the URL patterns.
  abstract urls: string [] with get, set

type OnBeforeSendHeadersResponse =
  abstract cancel: bool with get, set
  /// When provided, request will be made with these headers.
  abstract requestHeaders: obj with get, set

type OnCompletedDetails =
  abstract id: int with get, set
  abstract url: string with get, set
  abstract method: string with get, set
  abstract webContentsId: int option with get, set
  abstract resourceType: string with get, set
  abstract referrer: string with get, set
  abstract timestamp: float with get, set
  abstract responseHeaders: obj with get, set
  abstract fromCache: bool with get, set
  abstract statusCode: int with get, set
  abstract statusLine: string with get, set

type OnCompletedFilter =
  /// Array of URL patterns that will be used to filter out the requests that do not
  /// match the URL patterns.
  abstract urls: string [] with get, set

type OnErrorOccurredDetails =
  abstract id: int with get, set
  abstract url: string with get, set
  abstract method: string with get, set
  abstract webContentsId: int option with get, set
  abstract resourceType: string with get, set
  abstract referrer: string with get, set
  abstract timestamp: float with get, set
  abstract fromCache: bool with get, set
  /// The error description.
  abstract error: string with get, set

type OnErrorOccurredFilter =
  /// Array of URL patterns that will be used to filter out the requests that do not
  /// match the URL patterns.
  abstract urls: string [] with get, set

type OnHeadersReceivedDetails =
  abstract id: int with get, set
  abstract url: string with get, set
  abstract method: string with get, set
  abstract webContentsId: int option with get, set
  abstract resourceType: string with get, set
  abstract referrer: string with get, set
  abstract timestamp: float with get, set
  abstract statusLine: string with get, set
  abstract statusCode: int with get, set
  abstract responseHeaders: obj with get, set

type OnHeadersReceivedFilter =
  /// Array of URL patterns that will be used to filter out the requests that do not
  /// match the URL patterns.
  abstract urls: string [] with get, set

type OnHeadersReceivedResponse =
  abstract cancel: bool with get, set
  /// When provided, the server is assumed to have responded with these headers.
  abstract responseHeaders: obj with get, set
  /// Should be provided when overriding responseHeaders to change header status
  /// otherwise original response header's status will be used.
  abstract statusLine: string with get, set

type OnResponseStartedDetails =
  abstract id: int with get, set
  abstract url: string with get, set
  abstract method: string with get, set
  abstract webContentsId: int option with get, set
  abstract resourceType: string with get, set
  abstract referrer: string with get, set
  abstract timestamp: float with get, set
  abstract responseHeaders: obj with get, set
  /// Indicates whether the response was fetched from disk cache.
  abstract fromCache: bool with get, set
  abstract statusCode: int with get, set
  abstract statusLine: string with get, set

type OnResponseStartedFilter =
  /// Array of URL patterns that will be used to filter out the requests that do not
  /// match the URL patterns.
  abstract urls: string [] with get, set

type OnSendHeadersDetails =
  abstract id: int with get, set
  abstract url: string with get, set
  abstract method: string with get, set
  abstract webContentsId: int option with get, set
  abstract resourceType: string with get, set
  abstract referrer: string with get, set
  abstract timestamp: float with get, set
  abstract requestHeaders: obj with get, set

type OnSendHeadersFilter =
  /// Array of URL patterns that will be used to filter out the requests that do not
  /// match the URL patterns.
  abstract urls: string [] with get, set

[<StringEnum; RequireQualifiedAccess>]
type DevToolsOpenMode =
  | Right
  | Bottom
  | Undocked
  | Detach

type OpenDevToolsOptions =
  /// Opens the devtools with specified dock state, can be right, bottom, undocked,
  /// detach. Defaults to last used dock state. In undocked mode it's possible to dock
  /// back. In detach mode it's not.
  abstract mode: DevToolsOpenMode with get, set
  /// Whether to bring the opened devtools window to the foreground. The default is
  /// true.
  abstract activate: bool with get, set

[<StringEnum; RequireQualifiedAccess>]
type DialogFeatures =
  | OpenFile
  | OpenDirectory
  | MultiSelections
  | ShowHiddenFiles
  | CreateDirectory
  | PromptToCreate
  | NoResolveAliases
  | TreatPackageAsDirectory

type OpenDialogOptions =
  abstract title: string with get, set
  abstract defaultPath: string with get, set
  /// Custom label for the confirmation button, when left empty the default label will
  /// be used.
  abstract buttonLabel: string with get, set
  abstract filters: FileDialogFilter [] with get, set
  /// Contains which features the dialog should use. The following values are
  /// supported:
  abstract properties: DialogFeatures [] with get, set
  /// Message to display above input boxes.
  abstract message: string with get, set
  /// Create when packaged for the Mac App Store.
  abstract securityScopedBookmarks: bool with get, set

type OpenExternalOptions =
  /// true to bring the opened application to the foreground. The default is true.
  abstract activate: bool with get, set
  /// The working directory.
  abstract workingDirectory: string with get, set

[<StringEnum; RequireQualifiedAccess>]
type DeviceEmulationScreenPosition =
  | Desktop
  | Mobile

type DeviceEmulationParameters =
  /// Specify the screen type to emulate (default: desktop):
  abstract screenPosition: DeviceEmulationScreenPosition with get, set
  /// Set the emulated screen size (screenPosition == mobile).
  abstract screenSize: Size with get, set
  /// Position the view on the screen (screenPosition == mobile) (default: { x: 0, y:
  /// 0 }).
  abstract viewPosition: Point with get, set
  /// Set the device scale factor (if zero defaults to original device scale factor)
  /// (default: 0).
  abstract deviceScaleFactor: int with get, set
  /// Set the emulated view size (empty means no override)
  abstract viewSize: Size with get, set
  /// Scale of emulated view inside available space (not in fit to view mode)
  /// (default: 1).
  abstract scale: float with get, set

type Payment =
  /// The identifier of the purchased product.
  abstract productIdentifier: string with get, set
  /// The quantity purchased.
  abstract quantity: int with get, set

[<StringEnum; RequireQualifiedAccess>]
type PermissionCheckMediaType =
  | Video
  | Audio
  | Unknown

[<StringEnum; RequireQualifiedAccess>]
type PermissionRequestMediaType =
  | Video
  | Audio

type PermissionCheckHandlerDetails =
  /// The security orign of the media check.
  abstract securityOrigin: string with get, set
  /// The type of media access being requested, can be video, audio or unknown
  abstract mediaType: PermissionCheckMediaType with get, set

type PermissionRequestHandlerDetails =
  /// The url of the openExternal request.
  abstract externalURL: string with get, set
  /// The types of media access being requested, elements can be video or audio
  abstract mediaTypes: PermissionRequestMediaType [] with get, set

type PopupOptions =
  /// Default is the focused window.
  abstract window: BrowserWindow with get, set
  /// Default is the current mouse cursor position. Must be declared if y is declared.
  abstract x: int with get, set
  /// Default is the current mouse cursor position. Must be declared if x is declared.
  abstract y: int with get, set
  /// The index of the menu item to be positioned under the mouse cursor at the
  /// specified coordinates. Default is -1.
  abstract positioningItem: int with get, set
  /// Called when menu is closed.
  abstract callback: (unit -> unit) with get, set

type PrintOptions =
  /// Don't ask user for print settings. Default is false.
  abstract silent: bool with get, set
  /// Also prints the background color and image of the web page. Default is false.
  abstract printBackground: bool with get, set
  /// Set the printer device name to use. Default is ''.
  abstract deviceName: string with get, set

type PrintToPDFOptions =
  /// Specifies the type of margins to use. Uses 0 for default margin, 1 for no
  /// margin, and 2 for minimum margin.
  abstract marginsType: int with get, set
  /// Specify page size of the generated PDF. Can be A3, A4, A5, Legal, Letter,
  /// Tabloid or an Object containing height and width in microns.
  abstract pageSize: U2<string, Size> with get, set
  /// Whether to print CSS backgrounds.
  abstract printBackground: bool with get, set
  /// Whether to print selection only.
  abstract printSelectionOnly: bool with get, set
  /// true for landscape, false for portrait.
  abstract landscape: bool with get, set

type CustomSchemePrivileges =
  /// Default false.
  abstract standard: bool with get, set
  /// Default false.
  abstract secure: bool with get, set
  /// Default false.
  abstract bypassCSP: bool with get, set
  /// Default false.
  abstract allowServiceWorkers: bool with get, set
  /// Default false.
  abstract supportFetchAPI: bool with get, set
  /// Default false.
  abstract corsEnabled: bool with get, set

type ProcessMemoryInfo =
  /// and The amount of memory currently pinned to actual physical RAM in Kilobytes.
  abstract residentSet: int with get, set
  /// The amount of memory not shared by other processes, such as JS heap or HTML
  /// content in Kilobytes.
  abstract ``private``: int with get, set
  /// The amount of memory shared between processes, typically memory consumed by the
  /// Electron code itself in Kilobytes.
  abstract shared: int with get, set

[<StringEnum; RequireQualifiedAccess>]
type ProgressBarMode =
  | None
  | Normal
  | Indeterminate
  | Error
  | Paused

type ProgressBarOptions =
  /// Mode for the progress bar. Can be none, normal, indeterminate, error or paused.
  abstract mode: ProgressBarMode with get, set

type SpellCheckProvider =
  /// .
  abstract spellCheck: (string [] -> (string [] -> unit) -> unit) with get, set

type ReadBookmark =
  abstract title: string with get, set
  abstract url: string with get, set

type RedirectRequest =
  abstract url: string with get, set
  abstract method: string with get, set
  abstract session: Session option with get, set
  abstract uploadData: UploadData with get, set

type RegisterBufferProtocolRequest =
  abstract url: string with get, set
  abstract referrer: string with get, set
  abstract method: string with get, set
  abstract uploadData: UploadData [] with get, set

type RegisterFileProtocolRequest =
  abstract url: string with get, set
  abstract referrer: string with get, set
  abstract method: string with get, set
  abstract uploadData: UploadData [] with get, set

type RegisterHttpProtocolRequest =
  abstract url: string with get, set
  abstract headers: obj with get, set
  abstract referrer: string with get, set
  abstract method: string with get, set
  abstract uploadData: UploadData [] with get, set

type RegisterStreamProtocolRequest =
  abstract url: string with get, set
  abstract headers: obj with get, set
  abstract referrer: string with get, set
  abstract method: string with get, set
  abstract uploadData: UploadData [] with get, set

type RegisterStringProtocolRequest =
  abstract url: string with get, set
  abstract referrer: string with get, set
  abstract method: string with get, set
  abstract uploadData: UploadData [] with get, set

type RelaunchOptions =
  abstract args: string [] with get, set
  abstract execPath: string with get, set

type LoginRequest =
  abstract method: string with get, set
  abstract url: string with get, set
  abstract referrer: string with get, set

[<StringEnum; RequireQualifiedAccess>]
type ResizeQuality =
  | Good
  | Better
  | Best

type ResizeOptions =
  /// Defaults to the image's width.
  abstract width: int with get, set
  /// Defaults to the image's height.
  abstract height: int with get, set
  /// The desired quality of the resize image. Possible values are good, better or
  /// best. The default is best. These values express a desired quality/speed
  /// tradeoff. They are translated into an algorithm-specific method that depends on
  /// the capabilities (CPU, GPU) of the underlying platform. It is possible for all
  /// three methods to be mapped to the same algorithm on a given platform.
  abstract quality: ResizeQuality with get, set

type ResourceUsage =
  abstract images: MemoryUsageDetails with get, set
  abstract scripts: MemoryUsageDetails with get, set
  abstract cssStyleSheets: MemoryUsageDetails with get, set
  abstract xslStyleSheets: MemoryUsageDetails with get, set
  abstract fonts: MemoryUsageDetails with get, set
  abstract other: MemoryUsageDetails with get, set

type OnBeforeRequestResponse =
  abstract cancel: bool with get, set
  /// The original request is prevented from being sent or completed and is instead
  /// redirected to the given URL.
  abstract redirectURL: string with get, set

type SaveDialogOptions =
  abstract title: string with get, set
  /// Absolute directory path, absolute file path, or file name to use by default.
  abstract defaultPath: string with get, set
  /// Custom label for the confirmation button, when left empty the default label will
  /// be used.
  abstract buttonLabel: string with get, set
  abstract filters: FileDialogFilter [] with get, set
  /// Message to display above text fields.
  abstract message: string with get, set
  /// Custom label for the text displayed in front of the filename text field.
  abstract nameFieldLabel: string with get, set
  /// Show the tags input box, defaults to true.
  abstract showsTagField: bool with get, set
  /// Create a when packaged for the Mac App Store. If this option is enabled and the
  /// file doesn't already exist a blank file will be created at the chosen path.
  abstract securityScopedBookmarks: bool with get, set

type SetLoginItemSettings =
  /// true to open the app at login, false to remove the app as a login item. Defaults
  /// to false.
  abstract openAtLogin: bool with get, set
  /// true to open the app as hidden. Defaults to false. The user can edit this
  /// setting from the System Preferences so
  /// app.getLoginItemSettings().wasOpenedAsHidden should be checked when the app is
  /// opened to know the current value. This setting is not available on .
  abstract openAsHidden: bool with get, set
  /// The executable to launch at login. Defaults to process.execPath.
  abstract path: string with get, set
  /// The command-line arguments to pass to the executable. Defaults to an empty
  /// array. Take care to wrap paths in quotes.
  abstract args: string [] with get, set

type GetDesktopCapturerSourcesOptions =
  /// An array of Strings that lists the types of desktop sources to be captured,
  /// available types are screen and window.
  abstract types: string [] with get, set
  /// The size that the media source thumbnail should be scaled to. Default is 150 x
  /// 150.
  abstract thumbnailSize: Size with get, set
  /// Set to true to enable fetching window icons. The default value is false. When
  /// false the appIcon property of the sources return null. Same if a source has the
  /// type screen.
  abstract fetchWindowIcons: bool with get, set

type SystemMemoryInfo =
  /// The total amount of physical memory in Kilobytes available to the 
  abstract total: int with get, set
  /// The total amount of memory not being used by applications or disk cache.
  abstract free: int with get, set
  /// The total amount of swap memory in Kilobytes available to the 
  abstract swapTotal: int with get, set
  /// The free amount of swap memory in Kilobytes available to the 
  abstract swapFree: int with get, set

type ToBitmapOptions =
  /// Defaults to 1.0.
  abstract scaleFactor: float with get, set

type ToDataURLOptions =
  /// Defaults to 1.0.
  abstract scaleFactor: float with get, set

type ToPNGOptions =
  /// Defaults to 1.0.
  abstract scaleFactor: float with get, set

[<StringEnum; RequireQualifiedAccess>]
type TouchBarButtonIconPosition =
  | Left
  | Right
  | Overlay

type TouchBarButtonOptions =
  /// Button text.
  abstract label: string with get, set
  /// Button background color in hex format, i.e #ABCDEF.
  abstract backgroundColor: string with get, set
  /// Button icon.
  abstract icon: NativeImage with get, set
  /// Can be left, right or overlay.
  abstract iconPosition: TouchBarButtonIconPosition with get, set
  /// (Event -> unit) to call when the button is clicked.
  abstract click: (unit -> unit) with get, set

type TouchBarColorPickerOptions =
  /// Array of hex color strings to appear as possible colors to select.
  abstract availableColors: string [] with get, set
  /// The selected hex color in the picker, i.e #ABCDEF.
  abstract selectedColor: string with get, set
  /// (Event -> unit) to call when a color is selected.
  abstract change: (string -> unit) with get, set

type TouchBarOptions =
  abstract items: ITouchBarItem [] with get, set
  abstract escapeItem: ITouchBarItem option with get, set

type TouchBarGroupOptions =
  /// Items to display as a group.
  abstract items: TouchBar with get, set

type TouchBarLabelOptions =
  /// Text to display.
  abstract label: string with get, set
  /// Hex color of text, i.e #ABCDEF.
  abstract textColor: string with get, set

type TouchBarPopoverOptions =
  /// Popover button text.
  abstract label: string with get, set
  /// Popover button icon.
  abstract icon: NativeImage with get, set
  /// Items to display in the popover.
  abstract items: TouchBar with get, set
  /// true to display a close button on the left of the popover, false to not show it.
  /// Default is true.
  abstract showCloseButton: bool with get, set

type TouchBarScrubberOptions =
  /// An array of items to place in this scrubber.
  abstract items: ScrubberItem [] with get, set
  /// Called when the user taps an item that was not the last tapped item.
  abstract select: (int -> unit) with get, set
  /// Called when the user taps any item.
  abstract highlight: (int -> unit) with get, set
  /// Selected item style. Defaults to null.
  abstract selectedStyle: string with get, set
  /// Selected overlay item style. Defaults to null.
  abstract overlayStyle: string with get, set
  /// Defaults to false.
  abstract showArrowButtons: bool with get, set
  /// Defaults to free.
  abstract mode: string with get, set
  /// Defaults to true.
  abstract continuous: bool with get, set

[<StringEnum; RequireQualifiedAccess>]
type TouchBarSegmentedControlSegmentStyle =
  | Automatic
  | Rounded
  | [<CompiledName("textured-rounded")>] TexturedRounded
  | [<CompiledName("round-rect")>] RoundRect
  | [<CompiledName("textured-square")>] TexturedSquare
  | Capsule
  | [<CompiledName("small-square")>] SmallSquare
  | Separated

[<StringEnum; RequireQualifiedAccess>]
type TouchBarSegmentedControlMode =
  | Single
  | Multiple
  | Buttons

type TouchBarSegmentedControlOptions =
  /// Style of the segments:
  abstract segmentStyle: TouchBarSegmentedControlSegmentStyle with get, set
  /// The selection mode of the control:
  abstract mode: TouchBarSegmentedControlMode with get, set
  /// An array of segments to place in this control.
  abstract segments: SegmentedControlSegment [] with get, set
  /// The index of the currently selected segment, will update automatically with user
  /// interaction. When the mode is multiple it will be the last selected item.
  abstract selectedIndex: int option with get, set
  /// Called when the user selects a new segment.
  abstract change: (int -> bool -> unit) with get, set

type TouchBarSliderOptions =
  /// Label text.
  abstract label: string with get, set
  /// Selected value.
  abstract value: int with get, set
  /// Minimum value.
  abstract minValue: int with get, set
  /// Maximum value.
  abstract maxValue: int with get, set
  /// Function to call when the slider is changed.
  abstract change: (int -> unit) with get, set

[<StringEnum; RequireQualifiedAccess>]
type TouchBarSpacerSize =
  | Small
  | Large
  | Flexible

type TouchBarSpacerOptions =
  /// Size of spacer, possible values are:
  abstract size: TouchBarSpacerSize with get, set

type UploadProgress =
  /// Whether the request is currently active. If this is false no other properties
  /// will be set
  abstract active: bool with get, set
  /// Whether the upload has started. If this is false both current and total will be
  /// set to 0.
  abstract started: bool with get, set
  /// The number of bytes that have been uploaded so far
  abstract current: int with get, set
  /// The number of bytes that will be uploaded this request
  abstract total: int with get, set

type VisibleOnAllWorkspacesOptions =
  /// Sets whether the window should be visible above fullscreen windows
  abstract visibleOnFullScreen: bool with get, set

type ContextMenuEditFlags =
  /// Whether the renderer believes it can undo.
  abstract canUndo: bool with get, set
  /// Whether the renderer believes it can redo.
  abstract canRedo: bool with get, set
  /// Whether the renderer believes it can cut.
  abstract canCut: bool with get, set
  /// Whether the renderer believes it can copy
  abstract canCopy: bool with get, set
  /// Whether the renderer believes it can paste.
  abstract canPaste: bool with get, set
  /// Whether the renderer believes it can delete.
  abstract canDelete: bool with get, set
  /// Whether the renderer believes it can select all.
  abstract canSelectAll: bool with get, set

type FoundInPageResult =
  abstract requestId: int with get, set
  /// Position of the active match.
  abstract activeMatchOrdinal: int with get, set
  /// Number of Matches.
  abstract matches: int with get, set
  /// Coordinates of first match region.
  abstract selectionArea: obj with get, set
  abstract finalUpdate: bool with get, set

type ContextMenuMediaFlags =
  /// Whether the media element has crashed.
  abstract inError: bool with get, set
  /// Whether the media element is paused.
  abstract isPaused: bool with get, set
  /// Whether the media element is muted.
  abstract isMuted: bool with get, set
  /// Whether the media element has audio.
  abstract hasAudio: bool with get, set
  /// Whether the media element is looping.
  abstract isLooping: bool with get, set
  /// Whether the media element's controls are visible.
  abstract isControlsVisible: bool with get, set
  /// Whether the media element's controls are toggleable.
  abstract canToggleControls: bool with get, set
  /// Whether the media element can be rotated.
  abstract canRotate: bool with get, set

[<StringEnum; RequireQualifiedAccess>]
type AutoplayPolicy =
  | [<CompiledName("no-user-gesture-required")>] NoUserGestureRequired
  | [<CompiledName("user-gesture-required")>] UserGestureRequired
  | [<CompiledName("document-user-activation-required")>] DocumentUserActivationRequired

type WebPreferences =
  /// Whether to enable DevTools. If it is set to false, can not use
  /// BrowserWindow.webContents.openDevTools() to open DevTools. Default is true.
  abstract devTools: bool with get, set
  /// Whether node integration is enabled. Default is false.
  abstract nodeIntegration: bool with get, set
  /// Whether node integration is enabled in web workers. Default is false. More about
  /// this can be found in .
  abstract nodeIntegrationInWorker: bool with get, set
  /// Experimental option for enabling NodeJS support in sub-frames such as iframes.
  /// All your preloads will load for every iframe, you can use process.isMainFrame to
  /// determine if you are in the main frame or not.
  abstract nodeIntegrationInSubFrames: bool with get, set
  /// Specifies a script that will be loaded before other scripts run in the page.
  /// This script will always have access to node APIs no matter whether node
  /// integration is turned on or off. The value should be the absolute file path to
  /// the script. When node integration is turned off, the preload script can
  /// reintroduce Node global symbols back to the global scope. See example .
  abstract preload: string with get, set
  /// If set, this will sandbox the renderer associated with the window, making it
  /// compatible with the Chromium OS-level sandbox and disabling the Node.js engine.
  /// This is not the same as the nodeIntegration option and the APIs available to the
  /// preload script are more limited. Read more about the option . This option is
  /// currently experimental and may change or be removed in future Electron releases.
  abstract sandbox: bool with get, set
  /// Whether to enable the module. Default is true.
  abstract enableRemoteModule: bool with get, set
  /// Sets the session used by the page. Instead of passing the Session object
  /// directly, you can also choose to use the partition option instead, which accepts
  /// a partition string. When both session and partition are provided, session will
  /// be preferred. Default is the default session.
  abstract session: Session with get, set
  /// Sets the session used by the page according to the session's partition string.
  /// If partition starts with persist:, the page will use a persistent session
  /// available to all pages in the app with the same partition. If there is no
  /// persist: prefix, the page will use an in-memory session. By assigning the same
  /// partition, multiple pages can share the same session. Default is the default
  /// session.
  abstract partition: string with get, set
  /// When specified, web pages with the same affinity will run in the same renderer
  /// process. Note that due to reusing the renderer process, certain webPreferences
  /// options will also be shared between the web pages even when you specified
  /// different values for them, including but not limited to preload, sandbox and
  /// nodeIntegration. So it is suggested to use exact same webPreferences for web
  /// pages with the same affinity.
  abstract affinity: string with get, set
  /// The default zoom factor of the page, 3.0 represents 300%. Default is 1.0.
  abstract zoomFactor: float with get, set
  /// Enables JavaScript support. Default is true.
  abstract javascript: bool with get, set
  /// When false, it will disable the same-origin policy (usually using testing
  /// websites by people), and set allowRunningInsecureContent to true if this options
  /// has not been set by user. Default is true.
  abstract webSecurity: bool with get, set
  /// Allow an https page to run JavaScript, CSS or plugins from http URLs. Default is
  /// false.
  abstract allowRunningInsecureContent: bool with get, set
  /// Enables image support. Default is true.
  abstract images: bool with get, set
  /// Make TextArea elements resizable. Default is true.
  abstract textAreasAreResizable: bool with get, set
  /// Enables WebGL support. Default is true.
  abstract webgl: bool with get, set
  /// Enables WebAudio support. Default is true.
  abstract webaudio: bool with get, set
  /// Whether plugins should be enabled. Default is false.
  abstract plugins: bool with get, set
  /// Enables Chromium's experimental features. Default is false.
  abstract experimentalFeatures: bool with get, set
  /// Enables scroll bounce (rubber banding) effect on macOS. Default is false.
  abstract scrollBounce: bool with get, set
  /// A list of feature strings separated by ,, like CSSVariables,KeyboardEventKey to
  /// enable. The full list of supported feature strings can be found in the file.
  abstract enableBlinkFeatures: string with get, set
  /// A list of feature strings separated by ,, like CSSVariables,KeyboardEventKey to
  /// disable. The full list of supported feature strings can be found in the file.
  abstract disableBlinkFeatures: string with get, set
  /// Sets the default font for the font-family.
  abstract defaultFontFamily: DefaultFontFamily with get, set
  /// Defaults to 16.
  abstract defaultFontSize: int with get, set
  /// Defaults to 13.
  abstract defaultMonospaceFontSize: int with get, set
  /// Defaults to 0.
  abstract minimumFontSize: int with get, set
  /// Defaults to ISO-8859-1.
  abstract defaultEncoding: string with get, set
  /// Whether to throttle animations and timers when the page becomes background. This
  /// also affects the . Defaults to true.
  abstract backgroundThrottling: bool with get, set
  /// Whether to enable offscreen rendering for the browser window. Defaults to false.
  /// See the for more details.
  abstract offscreen: bool with get, set
  /// Whether to run Electron APIs and the specified preload script in a separate
  /// JavaScript context. Defaults to false. The context that the preload script runs
  /// in will still have full access to the document and window globals but it will
  /// use its own set of JavaScript builtins (Array, Object, JSON, etc.) and will be
  /// isolated from any changes made to the global environment by the loaded page. The
  /// Electron API will only be available in the preload script and not the loaded
  /// page. This option should be used when loading potentially untrusted remote
  /// content to ensure the loaded content cannot tamper with the preload script and
  /// any Electron APIs being used. This option uses the same technique used by . You
  /// can access this context in the dev tools by selecting the 'Electron Isolated
  /// Context' entry in the combo box at the top of the Console tab.
  abstract contextIsolation: bool with get, set
  /// Whether to use native window.open(). Defaults to false. Child windows will
  /// always have node integration disabled. This option is currently experimental.
  abstract nativeWindowOpen: bool with get, set
  /// A list of strings that will be appended to process.argv in the renderer process
  /// of this app. Useful for passing small bits of data down to renderer process
  /// preload scripts.
  abstract additionalArguments: string [] with get, set
  /// Whether to enable browser style consecutive dialog protection. Default is false.
  abstract safeDialogs: bool with get, set
  /// The message to display when consecutive dialog protection is triggered. If not
  /// defined the default message would be used, note that currently the default
  /// message is in English and not localized.
  abstract safeDialogsMessage: string with get, set
  /// Whether dragging and dropping a file or link onto the page causes a navigation.
  /// Default is false.
  abstract navigateOnDragDrop: bool with get, set
  /// Autoplay policy to apply to content in the window, can be
  /// no-user-gesture-required, user-gesture-required,
  /// document-user-activation-required. Defaults to no-user-gesture-required.
  abstract autoplayPolicy: AutoplayPolicy with get, set

type DefaultFontFamily =
  /// Defaults to Times New Roman.
  abstract standard: string with get, set
  /// Defaults to Times New Roman.
  abstract serif: string with get, set
  /// Defaults to Arial.
  abstract sansSerif: string with get, set
  /// Defaults to Courier New.
  abstract monospace: string with get, set
  /// Defaults to Script.
  abstract cursive: string with get, set
  /// Defaults to Impact.
  abstract fantasy: string with get, set


module NodeExtensions =

  [<StringEnum; RequireQualifiedAccess>]
  type ProcessType =
    | Browser
    | Renderer
    | Worker

  type ProcessVersions =
    inherit Node.Base.ProcessVersions
    /// A String representing Chrome's version string.
    abstract chrome: string with get
    /// A String representing Electron's version string.
    abstract electron: string with get

  type Process =
    inherit Node.Process.Process
    inherit EventEmitter<Process>
    /// Emitted when Electron has loaded its internal initialization script and is
    /// beginning to load the web page or the main script. It can be used by the preload
    /// script to add removed Node global symbols back to the global scope when node
    /// integration is turned off:
    [<Emit "$0.on('loaded',$1)">] abstract onLoaded: listener: (Event -> unit) -> Process
    [<Emit "$0.once('loaded',$1)">] abstract onceLoaded: listener: (Event -> unit) -> Process
    [<Emit "$0.addListener('loaded',$1)">] abstract addListenerLoaded: listener: (Event -> unit) -> Process
    [<Emit "$0.removeListener('loaded',$1)">] abstract removeListenerLoaded: listener: (Event -> unit) -> Process
    /// Causes the main thread of the current process crash.
    abstract crash: unit -> unit
    abstract getCPUUsage: unit -> CPUUsage
    /// Indicates the creation time of the application. The time is represented as
    /// number of milliseconds since epoch. It returns null if it is unable to get the
    /// process creation time.
    abstract getCreationTime: unit -> float option
    /// Returns an object with V8 heap statistics. Note that all statistics are reported
    /// in Kilobytes.
    abstract getHeapStatistics: unit -> HeapStatistics
    abstract getIOCounters: unit -> IOCounters
    /// Returns an object giving memory usage statistics about the current process. Note
    /// that all statistics are reported in Kilobytes. This api should be called after
    /// app ready. Chromium does not provide residentSet value for macOS. This is
    /// because macOS performs in-memory compression of pages that haven't been recently
    /// used. As a result the resident set size value is not what one would expect.
    /// private memory is more representative of the actual pre-compression memory usage
    /// of the process on macOS.
    abstract getProcessMemoryInfo: unit -> ProcessMemoryInfo
    /// Returns an object giving memory usage statistics about the entire  Note
    /// that all statistics are reported in Kilobytes.
    abstract getSystemMemoryInfo: unit -> SystemMemoryInfo
    /// Causes the main thread of the current process hang.
    abstract hang: unit -> unit
    /// Sets the file descriptor soft limit to maxDescriptors or the OS hard limit,
    /// whichever is lower for the current process.
    abstract setFdLimit: maxDescriptors: int -> unit
    /// Takes a V8 heap snapshot and saves it to filePath.
    abstract takeHeapSnapshot: filePath: string -> bool
    /// A Boolean. When app is started by being passed as parameter to the default app,
    /// this property is true in the main process, otherwise it is undefined.
    abstract defaultApp: bool option with get, set
    /// A Boolean that controls whether or not deprecation warnings are printed to
    /// stderr when formerly callback-based APIs converted to Promises are invoked using
    /// callbacks. Setting this to true will enable deprecation warnings.
    abstract enablePromiseAPIs: bool with get, set
    /// A Boolean, true when the current renderer context is the "main" renderer frame.
    /// If you want the ID of the current frame you should use webFrame.routingId.
    abstract isMainFrame: bool with get, set
    /// A Boolean. For Mac App Store build, this property is true, for other builds it
    /// is undefined.
    abstract mas: bool option with get, set
    /// A Boolean that controls ASAR support inside your application. Setting this to
    /// true will disable the support for asar archives in Node's built-in modules.
    abstract noAsar: bool with get, set
    /// A Boolean that controls whether or not deprecation warnings are printed to
    /// stderr. Setting this to true will silence deprecation warnings. This property is
    /// used instead of the --no-deprecation command line flag.
    abstract noDeprecation: bool with get, set
    /// A String representing the path to the resources directory.
    abstract resourcesPath: string with get, set
    /// A Boolean. When the renderer process is sandboxed, this property is true,
    /// otherwise it is undefined.
    abstract sandboxed: bool option with get, set
    /// A Boolean that controls whether or not deprecation warnings will be thrown as
    /// exceptions. Setting this to true will throw errors for deprecations. This
    /// property is used instead of the --throw-deprecation command line flag.
    abstract throwDeprecation: bool with get, set
    /// A Boolean that controls whether or not deprecations printed to stderr include
    /// their stack trace. Setting this to true will print stack traces for
    /// deprecations. This property is instead of the --trace-deprecation command line
    /// flag.
    abstract traceDeprecation: bool with get, set
    /// A Boolean that controls whether or not process warnings printed to stderr
    /// include their stack trace. Setting this to true will print stack traces for
    /// process warnings (including deprecations). This property is instead of the
    /// --trace-warnings command line flag.
    abstract traceProcessWarnings: bool with get, set
    /// A String representing the current process's type, can be "browser" (i.e. main
    /// process), "renderer", or "worker" (i.e. web worker).
    abstract ``type``: ProcessType with get, set
    /// A Boolean. If the app is running as a Windows Store app (appx), this property is
    /// true, for otherwise it is undefined.
    abstract windowsStore: bool option with get, set
    abstract versions: ProcessVersions with get, set
