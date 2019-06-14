// Type definitions for Electron v0.37.7
// https://github.com/fable-compiler/fable-electron

namespace rec Electron.Types

open System
open Fable.Core
open Browser.Types

type Function = Event -> unit

type EventEmitter =
    abstract addListener: ``event``: string * listener: Function -> EventEmitter
    abstract on: ``event``: string * listener: Function -> EventEmitter
    abstract once: ``event``: string * listener: Function -> EventEmitter
    abstract removeListener: ``event``: string * listener: Function -> EventEmitter
    abstract setMaxListeners: n: int -> EventEmitter
    abstract getMaxListeners: unit -> int
    abstract listeners: ``event``: string -> Function[]
    abstract emit: ``event``: string * [<ParamArray>] args: obj[] -> bool
    abstract eventNames: unit -> string[]
    abstract defaultMaxListeners: float with get, set
    abstract prependListener: ``event``: string * listener: Function -> EventEmitter
    abstract prependOnceListener: ``event``: string * listener: Function -> EventEmitter
    abstract removeAllListener: ``event``: string * listener: Function -> EventEmitter

type Event =
    abstract preventDefault: Function with get, set
    abstract sender: EventEmitter with get, set

type App =
    inherit EventEmitter
    abstract commandLine: CommandLine with get, set
    abstract dock: Dock with get, set
    [<Emit("$0.on('will-finish-launching',$1...)")>] abstract ``on_will-finish-launching``: listener: Function -> obj
    [<Emit("$0.on('ready',$1...)")>] abstract on_ready: listener: Function -> obj
    [<Emit("$0.on('window-all-closed',$1...)")>] abstract ``on_window-all-closed``: listener: Function -> obj
    [<Emit("$0.on('before-quit',$1...)")>] abstract ``on_before-quit``: listener: Function -> obj
    [<Emit("$0.on('will-quit',$1...)")>] abstract ``on_will-quit``: listener: Function -> obj
    [<Emit("$0.on('quit',$1...)")>] abstract on_quit: Function -> obj
    [<Emit("$0.on('open-file',$1...)")>] abstract ``on_open-file``: Function -> obj
    [<Emit("$0.on('open-url',$1...)")>] abstract ``on_open-url``: listener: Function -> obj
    [<Emit("$0.on('activate',$1...)")>] abstract on_activate: listener: Function -> obj
    [<Emit("$0.on('continue-activity',$1...)")>] abstract ``on_continue-activity``: listener: Function -> obj
    [<Emit("$0.on('browser-window-blur',$1...)")>] abstract ``on_browser-window-blur``: listener: Function -> obj
    [<Emit("$0.on('browser-window-focus',$1...)")>] abstract ``on_browser-window-focus``: listener: Function -> obj
    [<Emit("$0.on('browser-window-created',$1...)")>] abstract ``on_browser-window-created``: listener: Function -> obj
    [<Emit("$0.on('web-contents-created',$1...)")>] abstract ``on_web-contents-created``: listener: Function -> obj
    [<Emit("$0.on('certificate-error',$1...)")>] abstract ``on_certificate-error``: listener: Function -> obj
    [<Emit("$0.on('select-client-certificate',$1...)")>] abstract ``on_select-client-certificate``: listener: Function -> obj
    [<Emit("$0.on('login',$1...)")>] abstract on_login: listener: Function -> obj
    [<Emit("$0.on('gpu-process-crashed',$1...)")>] abstract ``on_gpu-process-crashed``: listener: Function -> obj
    [<Emit("$0.on('accessibility-support-changed',$1...)")>] abstract ``on_accessibility-support-changed``: listener: Function -> obj
    [<Emit("$0.on('platform-theme-changed',$1...)")>] abstract ``on_platform-theme-changed``: listener: Function -> obj
    abstract on: ``event``: string * listener: Function -> obj
    abstract quit: unit -> unit
    abstract exit: ?exitCode: float -> unit
    abstract relaunch: ?options: obj -> unit
    abstract isReady: unit -> bool
    abstract focus: unit -> unit
    abstract hide: unit -> unit
    abstract show: unit -> unit
    abstract getAppPath: unit -> string
    abstract getPath: name: AppPathName -> string
    abstract setPath: name: AppPathName * path: string -> unit
    abstract getVersion: unit -> string
    abstract getName: unit -> string
    abstract setName: name: string -> unit
    abstract getLocale: unit -> string
    abstract addRecentDocument: path: string -> unit
    abstract clearRecentDocuments: unit -> unit
    abstract setAsDefaultProtocolClient: protocol: string * ?path: string * ?args: string[] -> bool
    abstract removeAsDefaultProtocolClient: protocol: string * ?path: string * ?args: string[] -> bool
    abstract isDefaultProtocolClient: protocol: string * ?path: string * ?args: string[] -> bool
    abstract setUserTasks: tasks: Task[] -> bool
    abstract getJumpListSettings: unit -> JumpListSettings
    abstract setJumpList: categories: JumpListCategory[] -> SetJumpListResult
    abstract makeSingleInstance: callback: (string[]->string->unit) -> bool
    abstract releaseSingleInstance: unit -> unit
    abstract setUserActivity: ``type``: string * userInfo: obj * ?webpageURL: string -> unit
    abstract getCurrentActivityType: unit -> string
    abstract setAppUserModelId: id: string -> unit
    abstract importCertificate: options: ImportCertificateOptions * callback: (float->unit) -> unit
    abstract disableHardwareAcceleration: unit -> unit
    abstract setBadgeCount: count: float -> bool
    abstract getBadgeCount: unit -> float
    abstract isUnityRunning: unit -> bool
    abstract isAccessibilitySupportEnabled: unit -> bool
    abstract getLoginItemSettings: unit -> LoginItemSettings
    abstract setLoginItemSettings: settings: LoginItemSettings -> unit
    abstract setAboutPanelOptions: options: AboutPanelOptions -> unit

type [<StringEnum>] AppPathName =
    | Home | AppData | UserData | Temp | Exe | Module | Desktop | Documents | Downloads | Music | Pictures | Videos | PepperFlashSystemPlugin

type ImportCertificateOptions =
    abstract certificate: string with get, set
    abstract password: string with get, set

type CommandLine =
    abstract appendSwitch: _switch: string * ?value: string -> unit
    abstract appendArgument: value: string -> unit

type Dock =
    abstract bounce: ?``type``: DockBounceType -> float
    abstract cancelBounce: id: float -> unit
    abstract downloadFinished: filePath: string -> unit
    abstract setBadge: text: string -> unit
    abstract getBadge: unit -> string
    abstract hide: unit -> unit
    abstract show: unit -> unit
    abstract isVisible: unit -> bool
    abstract setMenu: menu: Menu -> unit
    abstract setIcon: icon: U2<NativeImage, string> -> unit

type [<StringEnum>] DockBounceType =
    | Critical | Informational

type Task =
    abstract program: string with get, set
    abstract arguments: string with get, set
    abstract title: string with get, set
    abstract description: string option with get, set
    abstract iconPath: string with get, set
    abstract iconIndex: float option with get, set

type [<StringEnum>] SetJumpListResult =
    | Ok | Exception | InvalidSeparatorError | FileTypeRegistrationError | CustomCategoryAccessDeniedError

type JumpListSettings =
    abstract minItems: float with get, set
    abstract removedItems: JumpListItem[] with get, set

type JumpListCategory =
    abstract ``type``: JumpListCategoryType option with get, set
    abstract name: string option with get, set
    abstract items: JumpListItem[] option with get, set

type [<StringEnum>] JumpListCategoryType =
    | Tasks | Frequent | Recent | Custom

type JumpListItem =
    abstract ``type``: JumpListItemType with get, set
    abstract path: string option with get, set
    abstract program: string option with get, set

type [<StringEnum>] JumpListItemType =
    | Task | Separator | File

type LoginItemSettings =
    abstract openAtLogin: bool with get, set
    abstract openAsHidden: bool with get, set
    abstract wasOpenedAtLogin: bool option with get, set
    abstract wasOpenedAsHidden: bool option with get, set
    abstract restoreState: bool option with get, set

type AboutPanelOptions =
    abstract applicationName: string option with get, set
    abstract applicationVersion: string option with get, set
    abstract copyright: string option with get, set
    abstract credits: string option with get, set
    abstract version: string option with get, set

type AutoUpdater =
    inherit EventEmitter
    [<Emit("$0.on('error',$1...)")>] abstract on_error: listener: Function -> obj
    [<Emit("$0.on('checking-for-update',$1...)")>] abstract ``on_checking-for-update``: listener: Function -> obj
    [<Emit("$0.on('update-available',$1...)")>] abstract ``on_update-available``: listener: Function -> obj
    [<Emit("$0.on('update-not-available',$1...)")>] abstract ``on_update-not-available``: listener: Function -> obj
    [<Emit("$0.on('update-downloaded',$1...)")>] abstract ``on_update-downloaded``: listener: Function -> obj
    abstract on: ``event``: string * listener: Function -> obj
    abstract setFeedURL: url: string -> unit
    abstract checkForUpdates: unit -> unit
    abstract quitAndInstall: unit -> unit

type BrowserWindowStatic =
    [<Emit("new $0($1...)")>] abstract Create: ?options: BrowserWindowOptions -> BrowserWindow
    abstract getAllWindows: unit -> BrowserWindow[]
    abstract getFocusedWindow: unit -> BrowserWindow
    abstract fromWebContents: webContents: WebContents -> BrowserWindow
    abstract fromId: id: float -> BrowserWindow
    abstract addDevToolsExtension: path: string -> string
    abstract removeDevToolsExtension: name: string -> unit

type BrowserWindow =
    inherit EventEmitter
    abstract webContents: WebContents with get, set
    abstract id: float with get, set
    [<Emit("$0.on('page-title-updated',$1...)")>] abstract ``on_page-title-updated``: listener: Function -> obj
    [<Emit("$0.on('close',$1...)")>] abstract on_close: listener: Function -> obj
    [<Emit("$0.on('closed',$1...)")>] abstract on_closed: listener: Function -> obj
    [<Emit("$0.on('unresponsive',$1...)")>] abstract on_unresponsive: listener: Function -> obj
    [<Emit("$0.on('responsive',$1...)")>] abstract on_responsive: listener: Function -> obj
    [<Emit("$0.on('blur',$1...)")>] abstract on_blur: listener: Function -> obj
    [<Emit("$0.on('focus',$1...)")>] abstract on_focus: listener: Function -> obj
    [<Emit("$0.on('show',$1...)")>] abstract on_show: listener: Function -> obj
    [<Emit("$0.on('hide',$1...)")>] abstract on_hide: listener: Function -> obj
    [<Emit("$0.on('maximize',$1...)")>] abstract on_maximize: listener: Function -> obj
    [<Emit("$0.on('unmaximize',$1...)")>] abstract on_unmaximize: listener: Function -> obj
    [<Emit("$0.on('minimize',$1...)")>] abstract on_minimize: listener: Function -> obj
    [<Emit("$0.on('restore',$1...)")>] abstract on_restore: listener: Function -> obj
    [<Emit("$0.on('resize',$1...)")>] abstract on_resize: listener: Function -> obj
    [<Emit("$0.on('move',$1...)")>] abstract on_move: listener: Function -> obj
    [<Emit("$0.on('enter-full-screen',$1...)")>] abstract ``on_enter-full-screen``: listener: Function -> obj
    [<Emit("$0.on('leave-full-screen',$1...)")>] abstract ``on_leave-full-screen``: listener: Function -> obj
    [<Emit("$0.on('enter-html-full-screen',$1...)")>] abstract ``on_enter-html-full-screen``: listener: Function -> obj
    [<Emit("$0.on('leave-html-full-screen',$1...)")>] abstract ``on_leave-html-full-screen``: listener: Function -> obj
    [<Emit("$0.on('app-command',$1...)")>] abstract ``on_app-command``: listener: Function -> obj
    [<Emit("$0.on('scroll-touch-begin',$1...)")>] abstract ``on_scroll-touch-begin``: listener: Function -> obj
    [<Emit("$0.on('scroll-touch-end',$1...)")>] abstract ``on_scroll-touch-end``: listener: Function -> obj
    [<Emit("$0.on('swipe',$1...)")>] abstract on_swipe: listener: Function -> obj
    abstract on: ``event``: string * listener: Function -> obj
    abstract destroy: unit -> unit
    abstract close: unit -> unit
    abstract focus: unit -> unit
    abstract blur: unit -> unit
    abstract isFocused: unit -> bool
    abstract show: unit -> unit
    abstract showInactive: unit -> unit
    abstract hide: unit -> unit
    abstract isVisible: unit -> bool
    abstract maximize: unit -> unit
    abstract unmaximize: unit -> unit
    abstract isMaximized: unit -> bool
    abstract minimize: unit -> unit
    abstract restore: unit -> unit
    abstract isMinimized: unit -> bool
    abstract setFullScreen: flag: bool -> unit
    abstract isFullScreen: unit -> bool
    abstract setAspectRatio: aspectRatio: float * ?extraSize: Dimension -> unit
    abstract setBounds: options: Rectangle * ?animate: bool -> unit
    abstract getBounds: unit -> Rectangle
    abstract setSize: width: float * height: float * ?animate: bool -> unit
    abstract getSize: unit -> float[]
    abstract setContentSize: width: float * height: float * ?animate: bool -> unit
    abstract getContentSize: unit -> float[]
    abstract setMinimumSize: width: float * height: float -> unit
    abstract getMinimumSize: unit -> float[]
    abstract setMaximumSize: width: float * height: float -> unit
    abstract getMaximumSize: unit -> float[]
    abstract setResizable: resizable: bool -> unit
    abstract isResizable: unit -> bool
    abstract setMovable: movable: bool -> unit
    abstract isMovable: unit -> bool
    abstract setMinimizable: minimizable: bool -> unit
    abstract isMinimizable: unit -> bool
    abstract setMaximizable: maximizable: bool -> unit
    abstract isMaximizable: unit -> bool
    abstract setFullScreenable: fullscreenable: bool -> unit
    abstract isFullScreenable: unit -> bool
    abstract setClosable: closable: bool -> unit
    abstract isClosable: unit -> bool
    abstract setAlwaysOnTop: flag: bool -> unit
    abstract isAlwaysOnTop: unit -> bool
    abstract center: unit -> unit
    abstract setPosition: x: float * y: float * ?animate: bool -> unit
    abstract getPosition: unit -> float[]
    abstract setTitle: title: string -> unit
    abstract getTitle: unit -> string
    abstract setSheetOffset: offset: float -> unit
    abstract flashFrame: flag: bool -> unit
    abstract setSkipTaskbar: skip: bool -> unit
    abstract setKiosk: flag: bool -> unit
    abstract isKiosk: unit -> bool
    abstract getNativeWindowHandle: unit -> Buffer
    abstract hookWindowMessage: message: float * callback: Function -> unit
    abstract isWindowMessageHooked: message: float -> bool
    abstract unhookWindowMessage: message: float -> unit
    abstract unhookAllWindowMessages: unit -> unit
    abstract setRepresentedFilename: filename: string -> unit
    abstract getRepresentedFilename: unit -> string
    abstract setDocumentEdited: edited: bool -> unit
    abstract isDocumentEdited: unit -> bool
    abstract focusOnWebView: unit -> unit
    abstract blurWebView: unit -> unit
    abstract capturePage: rect: Rectangle * callback: (NativeImage->unit) -> unit
    abstract capturePage: callback: (NativeImage->unit) -> unit
    abstract print: ?options: PrintOptions -> unit
    abstract printToPDF: options: PrintToPDFOptions * callback: (Exception->Buffer->unit) -> unit
    abstract loadURL: url: string * ?options: LoadURLOptions -> unit
    abstract reload: unit -> unit
    abstract setMenu: menu: Menu -> unit
    abstract setProgressBar: progress: float -> unit
    abstract setOverlayIcon: overlay: NativeImage * description: string -> unit
    abstract setHasShadow: hasShadow: bool -> unit
    abstract hasShadow: unit -> bool
    abstract setThumbarButtons: buttons: ThumbarButton[] -> bool
    abstract showDefinitionForSelection: unit -> unit
    abstract setAutoHideMenuBar: hide: bool -> unit
    abstract isMenuBarAutoHide: unit -> bool
    abstract setMenuBarVisibility: visibile: bool -> unit
    abstract isMenuBarVisible: unit -> bool
    abstract setVisibleOnAllWorkspaces: visible: bool -> unit
    abstract isVisibleOnAllWorkspaces: unit -> bool
    abstract setIgnoreMouseEvents: ignore: bool -> unit

type [<StringEnum>] SwipeDirection =
    | Up | Right | Down | Left

type [<StringEnum>] ThumbarButtonFlags =
    | Enabled | Disabled | Dismissonclick | Nobackground | Hidden | Noninteractive

type ThumbarButton =
    abstract icon: U2<NativeImage, string> with get, set
    abstract click: Function with get, set
    abstract tooltip: string option with get, set
    abstract flags: ThumbarButtonFlags[] option with get, set

type WebPreferences =
    abstract devTools: bool option with get, set
    abstract nodeIntegration: bool option with get, set
    abstract nodeIntegrationWorker: bool option with get, set
    abstract preload: string option with get, set
    abstract session: Session option with get, set
    abstract partition: string option with get, set
    abstract zoomFactor: float option with get, set
    abstract javascript: bool option with get, set
    abstract webSecurity: bool option with get, set
    abstract allowRunningInsecureContent: bool option with get, set
    abstract images: bool option with get, set
    abstract textAreasAreResizable: bool option with get, set
    abstract webgl: bool option with get, set
    abstract webaudio: bool option with get, set
    abstract plugins: bool option with get, set
    abstract experimentalFeatures: bool option with get, set
    abstract experimentalCanvasFeatures: bool option with get, set
    abstract scrollBounce: bool option with get, set
    abstract blinkFeatures: string option with get, set
    abstract disableBlinkFeatures: string option with get, set
    abstract defaultFontFamily: obj option with get, set
    abstract defaultFontSize: float option with get, set
    abstract defaultMonospaceFontSize: float option with get, set
    abstract minimumFontSize: float option with get, set
    abstract defaultEncoding: string option with get, set
    abstract backgroundThrottling: bool option with get, set
    abstract offscreen: bool option with get, set
    abstract sandbox: bool option with get, set
    abstract contextIsolation: bool option with get, set

type BrowserWindowOptions =
    inherit Rectangle
    abstract width: float option with get, set
    abstract height: float option with get, set
    abstract x: float option with get, set
    abstract y: float option with get, set
    abstract useContentSize: bool option with get, set
    abstract center: bool option with get, set
    abstract minWidth: float option with get, set
    abstract minHeight: float option with get, set
    abstract maxWidth: float option with get, set
    abstract maxHeight: float option with get, set
    abstract resizable: bool option with get, set
    abstract movable: bool option with get, set
    abstract minimizable: bool option with get, set
    abstract maximizable: bool option with get, set
    abstract closable: bool option with get, set
    abstract focusable: bool option with get, set
    abstract alwaysOnTop: bool option with get, set
    abstract fullscreen: bool option with get, set
    abstract fullscreenable: bool option with get, set
    abstract skipTaskbar: bool option with get, set
    abstract kiosk: bool option with get, set
    abstract title: string option with get, set
    abstract icon: U2<NativeImage, string> option with get, set
    abstract show: bool option with get, set
    abstract frame: bool option with get, set
    abstract parent: BrowserWindow option with get, set
    abstract modal: bool option with get, set
    abstract acceptFirstMouse: bool option with get, set
    abstract disableAutoHideCursor: bool option with get, set
    abstract autoHideMenuBar: bool option with get, set
    abstract enableLargerThanScreen: bool option with get, set
    abstract backgroundColor: string option with get, set
    abstract hasShadow: bool option with get, set
    abstract darkTheme: bool option with get, set
    abstract transparent: bool option with get, set
    abstract ``type``: BrowserWindowType option with get, set
    abstract titleBarStyle: string option with get, set
    abstract thickFrame: bool option with get, set
    abstract vibrancy: string option with get, set
    abstract zoomToPageWidth: bool option with get, set
    abstract webPreferences: WebPreferences option with get, set

type BrowserWindowType =
    U2<BrowserWindowTypeLinux, BrowserWindowTypeMac>

type [<StringEnum>] BrowserWindowTypeLinux =
    | Desktop | Dock | Toolbar | Splash | Notification

type [<StringEnum>] BrowserWindowTypeMac =
    | Desktop | Textured

type Rectangle =
    abstract x: float option with get, set
    abstract y: float option with get, set
    abstract width: float option with get, set
    abstract height: float option with get, set

type Clipboard =
    abstract readText: ?``type``: ClipboardType -> string
    abstract writeText: text: string * ?``type``: ClipboardType -> unit
    abstract readHtml: ?``type``: ClipboardType -> string
    abstract writeHtml: markup: string * ?``type``: ClipboardType -> unit
    abstract readImage: ?``type``: ClipboardType -> NativeImage
    abstract writeImage: image: NativeImage * ?``type``: ClipboardType -> unit
    abstract readRtf: ?``type``: ClipboardType -> string
    abstract writeRtf: text: string * ?``type``: ClipboardType -> unit
    abstract clear: ?``type``: ClipboardType -> unit
    abstract availableFormats: ?``type``: ClipboardType -> string[]
    abstract has: format: string * ?``type``: ClipboardType -> bool
    abstract read: format: string * ?``type``: ClipboardType -> U2<string, NativeImage>
    abstract write: data: obj * ?``type``: ClipboardType -> unit

type [<StringEnum>] ClipboardType =
    | [<CompiledName("")>] None | Selection

type ContentTracing =
    abstract getCategories: callback: (string[]->unit) -> unit
    abstract startRecording: options: ContentTracingOptions * callback: Function -> unit
    abstract stopRecording: resultFilePath: string * callback: (string->unit) -> unit
    abstract startMonitoring: options: ContentTracingOptions * callback: Function -> unit
    abstract stopMonitoring: callback: Function -> unit
    abstract captureMonitoringSnapshot: resultFilePath: string * callback: (string->unit) -> unit
    abstract getTraceBufferUsage: callback: Function -> unit
    abstract setWatchEvent: categoryName: string * eventName: string * callback: Function -> unit
    abstract cancelWatchEvent: unit -> unit

type ContentTracingOptions =
    abstract categoryFilter: string with get, set
    abstract traceOptions: string with get, set

type CrashReporter =
    abstract start: options: CrashReporterStartOptions -> unit
    abstract getLastCrashReport: unit -> CrashReport
    abstract getUploadedReports: unit -> CrashReport[]

type CrashReporterStartOptions =
    abstract productName: string option with get, set
    abstract companyName: string with get, set
    abstract submitURL: string with get, set
    abstract autoSubmit: bool option with get, set
    abstract ignoreSystemCrashHandler: bool option with get, set
    abstract extra: obj option with get, set

type CrashReport =
    abstract id: string with get, set
    abstract date: DateTime with get, set

type DesktopCapturer =
    abstract getSources: options: DesktopCapturerOptions * callback: (Exception->DesktopCapturerSource[]->obj) -> unit

type DesktopCapturerOptions =
    abstract types: (* TODO: StringEnum *) string[] option with get, set
    abstract thumbnailSize: Dimension option with get, set

type DesktopCapturerSource =
    abstract id: string with get, set
    abstract name: string with get, set
    abstract thumbnail: NativeImage with get, set

type Dialog =
    abstract showOpenDialog: browserWindow: BrowserWindow * options: OpenDialogOptions * ?callback: Func<string[], unit> -> string[]
    abstract showOpenDialog: options: OpenDialogOptions * ?callback: Func<string[], unit> -> string[]
    abstract showSaveDialog: browserWindow: BrowserWindow * options: SaveDialogOptions * ?callback: Func<string, unit> -> string
    abstract showSaveDialog: options: SaveDialogOptions * ?callback: Func<string, unit> -> string
    abstract showMessageBox: browserWindow: BrowserWindow * options: ShowMessageBoxOptions * ?callback: Func<float, unit> -> float
    abstract showMessageBox: options: ShowMessageBoxOptions * ?callback: Func<float, unit> -> float
    abstract showErrorBox: title: string * content: string -> unit

type OpenDialogOptions =
    abstract title: string option with get, set
    abstract defaultPath: string option with get, set
    abstract filters: obj[] option with get, set
    abstract properties: (* TODO: StringEnum *) string[] option with get, set

type SaveDialogOptions =
    abstract title: string option with get, set
    abstract defaultPath: string option with get, set
    abstract filters: obj[] option with get, set

type ShowMessageBoxOptions =
    abstract ``type``: string option with get, set
    abstract buttons: string[] option with get, set
    abstract defaultId: float option with get, set
    abstract title: string option with get, set
    abstract message: string option with get, set
    abstract detail: string option with get, set
    abstract icon: NativeImage option with get, set
    abstract cancelId: float option with get, set
    abstract noLink: bool option with get, set

type DownloadItem =
    inherit EventEmitter
    [<Emit("$0.on('updated',$1...)")>] abstract on_updated: listener: Function -> obj
    [<Emit("$0.on('done',$1...)")>] abstract on_done: listener: Function -> obj
    abstract on: ``event``: string * listener: Function -> obj
    abstract setSavePath: path: string -> unit
    abstract pause: unit -> unit
    abstract resume: unit -> unit
    abstract cancel: unit -> unit
    abstract getURL: unit -> string
    abstract getMimeType: unit -> string
    abstract hasUserGesture: unit -> bool
    abstract getFilename: unit -> string
    abstract getTotalBytes: unit -> float
    abstract getReceivedBytes: unit -> float
    abstract getContentDisposition: unit -> string

type GlobalShortcut =
    abstract register: accelerator: string * callback: Function -> unit
    abstract isRegistered: accelerator: string -> bool
    abstract unregister: accelerator: string -> unit
    abstract unregisterAll: unit -> unit

type IpcMain =
    inherit EventEmitter
    abstract addListener: channel: string * listener: IpcMainEventListener -> obj
    abstract on: channel: string * listener: IpcMainEventListener -> obj
    abstract once: channel: string * listener: IpcMainEventListener -> obj
    abstract removeListener: channel: string * listener: IpcMainEventListener -> obj
    abstract removeAllListeners: ?channel: string -> obj

type IpcMainEventListener =
    (IpcMainEvent->obj->unit)

type IpcMainEvent =
    abstract returnValue: obj option with get, set
    abstract sender: WebContents with get, set

type IpcRenderer =
    inherit EventEmitter
    abstract addListener: channel: string * listener: IpcRendererEventListener -> obj
    abstract on: channel: string * listener: IpcRendererEventListener -> obj
    abstract once: channel: string * listener: IpcRendererEventListener -> obj
    abstract removeListener: channel: string * listener: IpcRendererEventListener -> obj
    abstract removeAllListeners: ?channel: string -> obj
    abstract send: channel: string * [<ParamArray>] args: obj[] -> unit
    abstract sendSync: channel: string * [<ParamArray>] args: obj[] -> obj
    abstract sendToHost: channel: string * [<ParamArray>] args: obj[] -> unit

type IpcRendererEventListener =
    (IpcRendererEvent->obj->unit)

type IpcRendererEvent =
    abstract sender: IpcRenderer with get, set

type MenuItemStatic =
    [<Emit("new $0($1...)")>] abstract Create: options: MenuItemOptions -> MenuItem

type MenuItem =
    abstract click: (MenuItem->BrowserWindow->unit) with get, set
    abstract ``type``: MenuItemType with get, set
    abstract role: U2<MenuItemRole, MenuItemRoleMac> with get, set
    abstract accelerator: string with get, set
    abstract icon: U2<NativeImage, string> with get, set
    abstract submenu: U2<Menu, MenuItemOptions[]> with get, set
    abstract label: string with get, set
    abstract sublabel: string with get, set
    abstract enabled: bool with get, set
    abstract visible: bool with get, set
    abstract ``checked``: bool with get, set

type [<StringEnum>] MenuItemType =
    | Normal | Separator | Submenu | Checkbox | Radio

type [<StringEnum>] MenuItemRole =
    | Undo | Redo | Cut | Copy | Paste | Pasteandmatchstyle | Selectall | Delete | Minimize | Close | Quit | Reload | Forcereload | Toggledevtools | Togglefullscreen | Resetzoom | Zoomin | Zoomout | EditMenu | WindowMenu

type [<StringEnum>] MenuItemRoleMac =
    | About | Hide | Hideothers | Unhide | Startspeaking | Stopspeaking | Front | Zoom | Window | Help | Services

type MenuItemOptions =
    abstract click: (MenuItem->BrowserWindow->unit) option with get, set
    abstract ``type``: MenuItemType option with get, set
    abstract label: string option with get, set
    abstract sublabel: string option with get, set
    abstract accelerator: string option with get, set
    abstract icon: U2<NativeImage, string> option with get, set
    abstract enabled: bool option with get, set
    abstract visible: bool option with get, set
    abstract ``checked``: bool option with get, set
    abstract submenu: U2<Menu, MenuItemOptions[]> option with get, set
    abstract id: string option with get, set
    abstract position: string option with get, set
    abstract role: U2<MenuItemRole, MenuItemRoleMac> option with get, set

type MenuStatic =
    [<Emit("new $0($1...)")>] abstract Create: unit -> Menu
    abstract setApplicationMenu: menu: Menu -> unit
    abstract sendActionToFirstResponder: action: string -> unit
    abstract buildFromTemplate: template: MenuItemOptions[] -> Menu

type Menu =
    inherit EventEmitter
    abstract items: MenuItem[] with get, set
    abstract popup: ?browserWindow: BrowserWindow * ?x: float * ?y: float -> unit
    abstract append: menuItem: MenuItem -> unit
    abstract insert: position: float * menuItem: MenuItem -> unit

type NativeImageStatic =
    abstract createEmpty: unit -> NativeImage
    abstract createFromPath: path: string -> NativeImage
    abstract createFromBuffer: buffer: Buffer * ?scaleFactor: float -> NativeImage
    abstract createFromDataURL: dataURL: string -> NativeImage

type NativeImage =
    abstract toPng: unit -> Buffer
    abstract toJpeg: quality: float -> Buffer
    abstract toDataURL: unit -> string
    abstract getNativeHandle: unit -> Buffer
    abstract isEmpty: unit -> bool
    abstract getSize: unit -> Dimension
    abstract setTemplateImage: option: bool -> unit
    abstract isTemplateImage: unit -> bool

type PowerMonitor =
    inherit EventEmitter
    [<Emit("$0.on('suspend',$1...)")>] abstract on_suspend: listener: Function -> obj
    [<Emit("$0.on('resume',$1...)")>] abstract on_resume: listener: Function -> obj
    [<Emit("$0.on('on-ac',$1...)")>] abstract ``on_on-ac``: listener: Function -> obj
    [<Emit("$0.on('on-battery',$1...)")>] abstract ``on_on-battery``: listener: Function -> obj
    abstract on: ``event``: string * listener: Function -> obj

type PowerSaveBlocker =
    abstract start: ``type``: (* TODO: StringEnum *) string -> float
    abstract stop: id: float -> unit
    abstract isStarted: id: float -> bool

type Protocol =
    abstract registerStandardSchemes: schemes: string[] -> unit
    abstract registerServiceWorkerSchemes: schemes: string[] -> unit
    abstract registerFileProtocol: scheme: string * handler: (ProtocolRequest->FileProtocolCallback->unit) * ?completion: (Exception->unit) -> unit
    abstract registerBufferProtocol: scheme: string * handler: (ProtocolRequest->BufferProtocolCallback->unit) * ?completion: (Exception->unit) -> unit
    abstract registerStringProtocol: scheme: string * handler: (ProtocolRequest->StringProtocolCallback->unit) * ?completion: (Exception->unit) -> unit
    abstract registerHttpProtocol: scheme: string * handler: (ProtocolRequest->HttpProtocolCallback->unit) * ?completion: (Exception->unit) -> unit
    abstract unregisterProtocol: scheme: string * ?completion: (Exception->unit) -> unit
    abstract isProtocolHandled: scheme: string * callback: (bool->unit) -> unit
    abstract interceptFileProtocol: scheme: string * handler: (ProtocolRequest->FileProtocolCallback->unit) * ?completion: (Exception->unit) -> unit
    abstract interceptStringProtocol: scheme: string * handler: (ProtocolRequest->BufferProtocolCallback->unit) * ?completion: (Exception->unit) -> unit
    abstract interceptBufferProtocol: scheme: string * handler: (ProtocolRequest->StringProtocolCallback->unit) * ?completion: (Exception->unit) -> unit
    abstract interceptHttpProtocol: scheme: string * handler: (ProtocolRequest->HttpProtocolCallback->unit) * ?completion: (Exception->unit) -> unit
    abstract uninterceptProtocol: scheme: string * ?completion: (Exception->unit) -> unit

type ProtocolRequest =
    abstract url: string with get, set
    abstract referrer: string with get, set
    abstract ``method``: string with get, set
    abstract uploadData: obj[] option with get, set

type ProtocolCallback =
    [<Emit("$0($1...)")>] abstract Invoke: error: float -> unit
    [<Emit("$0($1...)")>] abstract Invoke: obj: obj -> unit
    [<Emit("$0($1...)")>] abstract Invoke: unit -> unit

type FileProtocolCallback =
    inherit ProtocolCallback
    [<Emit("$0($1...)")>] abstract Invoke: filePath: string -> unit
    [<Emit("$0($1...)")>] abstract Invoke: obj: obj -> unit

type BufferProtocolCallback =
    inherit ProtocolCallback
    [<Emit("$0($1...)")>] abstract Invoke: buffer: Buffer -> unit
    [<Emit("$0($1...)")>] abstract Invoke: obj: obj -> unit

type StringProtocolCallback =
    inherit ProtocolCallback
    [<Emit("$0($1...)")>] abstract Invoke: str: string -> unit
    [<Emit("$0($1...)")>] abstract Invoke: obj: obj -> unit

type HttpProtocolCallback =
    inherit ProtocolCallback
    [<Emit("$0($1...)")>] abstract Invoke: redirectRequest: obj -> unit

type Remote =
    inherit CommonElectron
    // abstract ``process``: Node.Process.Process with get, set
    abstract require: ``module``: string -> obj
    abstract getCurrentWindow: unit -> BrowserWindow
    abstract getCurrentWebContents: unit -> WebContents
    abstract getGlobal: name: string -> obj

type Display =
    abstract id: float with get, set
    abstract bounds: Bounds with get, set
    abstract workArea: Bounds with get, set
    abstract size: Dimension with get, set
    abstract workAreaSize: Dimension with get, set
    abstract scaleFactor: float with get, set
    abstract rotation: float with get, set
    abstract touchSupport: (* TODO: StringEnum *) string with get, set

type Bounds =
    abstract x: float with get, set
    abstract y: float with get, set
    abstract width: float with get, set
    abstract height: float with get, set

type Dimension =
    abstract width: float with get, set
    abstract height: float with get, set

type Point =
    abstract x: float with get, set
    abstract y: float with get, set

type [<StringEnum>] DisplayMetrics =
    | Bounds | WorkArea | ScaleFactor | Rotation

type Screen =
    inherit EventEmitter
    [<Emit("$0.on('display-added',$1...)")>] abstract ``on_display-added``: listener: Function -> obj
    [<Emit("$0.on('display-removed',$1...)")>] abstract ``on_display-removed``: listener: Function -> obj
    [<Emit("$0.on('display-metrics-changed',$1...)")>] abstract ``on_display-metrics-changed``: listener: Function -> obj
    abstract on: ``event``: string * listener: Function -> obj
    abstract getCursorScreenPoint: unit -> Point
    abstract getPrimaryDisplay: unit -> Display
    abstract getAllDisplays: unit -> Display[]
    abstract getDisplayNearestPoint: point: Point -> Display
    abstract getDisplayMatching: rect: Bounds -> Display

type SessionStatic =
    abstract defaultSession: Session with get, set
    abstract fromPartition: partition: string -> Session

type Session =
    inherit EventEmitter
    abstract cookies: SessionCookies with get, set
    /// TODO: Cast this to electron.WebRequest
    abstract webRequest: obj with get, set
    [<Emit("$0.on('will-download',$1...)")>] abstract ``on_will-download``: listener: Function -> obj
    abstract on: ``event``: string * listener: Function -> obj
    abstract getCacheSize: callback: (float->unit) -> unit
    abstract clearCache: callback: Function -> unit
    abstract clearStorageData: callback: Function -> unit
    abstract clearStorageData: options: ClearStorageDataOptions * callback: Function -> unit
    abstract flushStorageData: unit -> unit
    abstract setProxy: config: string * callback: Function -> unit
    abstract resolveProxy: url: obj (*URL*) * callback: (string->unit) -> unit
    abstract setDownloadPath: path: string -> unit
    abstract enableNetworkEmulation: options: NetworkEmulationOptions -> unit
    abstract disableNetworkEmulation: unit -> unit
    abstract setCertificateVerifyProc: proc: (string->Certificate->(bool->unit)->unit) -> unit
    abstract setPermissionRequestHandler: handler: (WebContents->Permission->(bool->unit)->unit) -> unit
    abstract clearHostResolverCache: callback: Function -> unit

type [<StringEnum>] Permission =
    | Media | Geolocation | Notifications | MidiSysex | PointerLock | Fullscreen | OpenExternal

type ClearStorageDataOptions =
    abstract origin: string option with get, set
    abstract storages: string[] option with get, set
    abstract quotas: string[] option with get, set

type NetworkEmulationOptions =
    abstract offline: bool option with get, set
    abstract latency: float option with get, set
    abstract downloadThroughput: float option with get, set
    abstract uploadThroughput: float option with get, set

type CookieFilter =
    abstract url: string option with get, set
    abstract name: string option with get, set
    abstract domain: string option with get, set
    abstract path: string option with get, set
    abstract secure: bool option with get, set
    abstract session: bool option with get, set

type Cookie =
    abstract name: string with get, set
    abstract value: string with get, set
    abstract domain: string with get, set
    abstract hostOnly: string with get, set
    abstract path: string with get, set
    abstract secure: bool with get, set
    abstract httpOnly: bool with get, set
    abstract session: bool with get, set
    abstract expirationDate: float option with get, set

type CookieDetails =
    abstract url: string with get, set
    abstract name: string option with get, set
    abstract value: string option with get, set
    abstract domain: string option with get, set
    abstract path: string option with get, set
    abstract secure: bool option with get, set
    abstract httpOnly: bool option with get, set
    abstract expirationDate: float option with get, set

type SessionCookies =
    abstract get: filter: CookieFilter * callback: (Exception->Cookie[]->unit) -> unit
    abstract set: details: CookieDetails * callback: (Exception->unit) -> unit
    abstract remove: url: string * name: string * callback: (Exception->unit) -> unit

type Shell =
    abstract showItemInFolder: fullPath: string -> unit
    abstract openItem: fullPath: string -> unit
    abstract openExternal: url: string * ?options: obj -> bool
    abstract moveItemToTrash: fullPath: string -> bool
    abstract beep: unit -> unit

type Tray =
    inherit EventEmitter
    [<Emit("$0.on('click',$1...)")>] abstract on_click: listener: Function -> obj
    [<Emit("$0.on('right-click',$1...)")>] abstract ``on_right-click``: listener: Function -> obj
    [<Emit("$0.on('double-click',$1...)")>] abstract ``on_double-click``: listener: Function -> obj
    [<Emit("$0.on('balloon-show',$1...)")>] abstract ``on_balloon-show``: listener: Function -> obj
    [<Emit("$0.on('balloon-click',$1...)")>] abstract ``on_balloon-click``: listener: Function -> obj
    [<Emit("$0.on('balloon-closed',$1...)")>] abstract ``on_balloon-closed``: listener: Function -> obj
    [<Emit("$0.on('drop',$1...)")>] abstract on_drop: listener: Function -> obj
    [<Emit("$0.on('drop-files',$1...)")>] abstract ``on_drop-files``: listener: Function -> obj
    [<Emit("$0.on('drag-enter',$1...)")>] abstract ``on_drag-enter``: listener: Function -> obj
    [<Emit("$0.on('drag-leave',$1...)")>] abstract ``on_drag-leave``: listener: Function -> obj
    [<Emit("$0.on('drag-end',$1...)")>] abstract ``on_drag-end``: listener: Function -> obj
    abstract on: ``event``: string * listener: Function -> obj
    [<Emit("new $0($1...)")>] abstract Create: image: U2<NativeImage, string> -> Tray
    abstract destroy: unit -> unit
    abstract setImage: image: U2<NativeImage, string> -> unit
    abstract setPressedImage: image: NativeImage -> unit
    abstract setToolTip: toolTip: string -> unit
    abstract setTitle: title: string -> unit
    abstract setHighlightMode: highlight: bool -> unit
    abstract displayBalloon: ?options: obj -> unit
    abstract popUpContextMenu: ?menu: Menu * ?position: Point -> unit
    abstract setContextMenu: menu: Menu -> unit

type Modifiers =
    abstract altKey: bool with get, set
    abstract shiftKey: bool with get, set
    abstract ctrlKey: bool with get, set
    abstract metaKey: bool with get, set

type WebContents =
    inherit EventEmitter
    abstract session: Session with get, set
    abstract hostWebContents: WebContents with get, set
    abstract devToolsWebContents: WebContents with get, set
    abstract debugger: Debugger with get, set
    [<Emit("$0.on('did-finish-load',$1...)")>] abstract ``on_did-finish-load``: listener: Function -> obj
    [<Emit("$0.on('did-fail-load',$1...)")>] abstract ``on_did-fail-load``: listener: Function -> obj
    [<Emit("$0.on('did-frame-finish-load',$1...)")>] abstract ``on_did-frame-finish-load``: listener: Function -> obj
    [<Emit("$0.on('did-start-loading',$1...)")>] abstract ``on_did-start-loading``: listener: Function -> obj
    [<Emit("$0.on('did-stop-loading',$1...)")>] abstract ``on_did-stop-loading``: listener: Function -> obj
    [<Emit("$0.on('did-get-response-details',$1...)")>] abstract ``on_did-get-response-details``: listener: Function -> obj
    [<Emit("$0.on('did-get-redirect-request',$1...)")>] abstract ``on_did-get-redirect-request``: listener: Function -> obj
    [<Emit("$0.on('dom-ready',$1...)")>] abstract ``on_dom-ready``: listener: Function -> obj
    [<Emit("$0.on('page-favicon-updated',$1...)")>] abstract ``on_page-favicon-updated``: listener: Function -> obj
    [<Emit("$0.on('new-window',$1...)")>] abstract ``on_new-window``: listener: Function -> obj
    [<Emit("$0.on('will-navigate',$1...)")>] abstract ``on_will-navigate``: listener: Function -> obj
    [<Emit("$0.on('did-navigate',$1...)")>] abstract ``on_did-navigate``: listener: Function -> obj
    [<Emit("$0.on('did-navigate-in-page',$1...)")>] abstract ``on_did-navigate-in-page``: listener: Function -> obj
    [<Emit("$0.on('crashed',$1...)")>] abstract on_crashed: listener: Function -> obj
    [<Emit("$0.on('plugin-crashed',$1...)")>] abstract ``on_plugin-crashed``: listener: Function -> obj
    [<Emit("$0.on('destroyed',$1...)")>] abstract on_destroyed: listener: Function -> obj
    [<Emit("$0.on('devtools-opened',$1...)")>] abstract ``on_devtools-opened``: listener: Function -> obj
    [<Emit("$0.on('devtools-closed',$1...)")>] abstract ``on_devtools-closed``: listener: Function -> obj
    [<Emit("$0.on('devtools-focused',$1...)")>] abstract ``on_devtools-focused``: listener: Function -> obj
    [<Emit("$0.on('certificate-error',$1...)")>] abstract ``on_certificate-error``: listener: Function -> obj
    [<Emit("$0.on('select-client-certificate',$1...)")>] abstract ``on_select-client-certificate``: listener: Function -> obj
    [<Emit("$0.on('login',$1...)")>] abstract on_login: listener: Function -> obj
    [<Emit("$0.on('found-in-page',$1...)")>] abstract ``on_found-in-page``: listener: Function -> obj
    [<Emit("$0.on('media-started-playing',$1...)")>] abstract ``on_media-started-playing``: listener: Function -> obj
    [<Emit("$0.on('media-paused',$1...)")>] abstract ``on_media-paused``: listener: Function -> obj
    [<Emit("$0.on('did-change-theme-color',$1...)")>] abstract ``on_did-change-theme-color``: listener: Function -> obj
    [<Emit("$0.on('cursor-changed',$1...)")>] abstract ``on_cursor-changed``: listener: Function -> obj
    abstract on: ``event``: string * listener: Function -> obj
    abstract loadURL: url: string * ?options: LoadURLOptions -> unit
    abstract downloadURL: url: string -> unit
    abstract getURL: unit -> string
    abstract getTitle: unit -> string
    abstract getFavicon: unit -> NativeImage
    abstract isLoading: unit -> bool
    abstract isLoadingMainFrame: unit -> bool
    abstract isWaitingForResponse: unit -> bool
    abstract stop: unit -> unit
    abstract reload: unit -> unit
    abstract reloadIgnoringCache: unit -> unit
    abstract canGoBack: unit -> bool
    abstract canGoForward: unit -> bool
    abstract canGoToOffset: offset: float -> bool
    abstract clearHistory: unit -> unit
    abstract goBack: unit -> unit
    abstract goForward: unit -> unit
    abstract goToIndex: index: float -> unit
    abstract goToOffset: offset: float -> unit
    abstract isCrashed: unit -> bool
    abstract setUserAgent: userAgent: string -> unit
    abstract getUserAgent: unit -> string
    abstract insertCSS: css: string -> unit
    abstract executeJavaScript: code: string * ?userGesture: bool * ?callback: (obj->unit) -> unit
    abstract setAudioMuted: muted: bool -> unit
    abstract isAudioMuted: unit -> bool
    abstract undo: unit -> unit
    abstract redo: unit -> unit
    abstract cut: unit -> unit
    abstract copy: unit -> unit
    abstract paste: unit -> unit
    abstract pasteAndMatchStyle: unit -> unit
    abstract delete: unit -> unit
    abstract selectAll: unit -> unit
    abstract unselect: unit -> unit
    abstract replace: text: string -> unit
    abstract replaceMisspelling: text: string -> unit
    abstract insertText: text: string -> unit
    abstract findInPage: text: string * ?options: FindInPageOptions -> float
    abstract stopFindInPage: action: StopFindInPageAtion -> unit
    abstract hasServiceWorker: callback: (bool->unit) -> unit
    abstract unregisterServiceWorker: callback: (bool->unit) -> unit
    abstract print: ?options: PrintOptions -> unit
    abstract printToPDF: options: PrintToPDFOptions * callback: (Exception->Buffer->unit) -> unit
    abstract addWorkSpace: path: string -> unit
    abstract removeWorkSpace: path: string -> unit
    abstract openDevTools: ?options: obj -> unit
    abstract closeDevTools: unit -> unit
    abstract isDevToolsOpened: unit -> bool
    abstract isDevToolsFocused: unit -> bool
    abstract toggleDevTools: unit -> unit
    abstract inspectElement: x: float * y: float -> unit
    abstract inspectServiceWorker: unit -> unit
    abstract send: channel: string * [<ParamArray>] args: obj[] -> unit
    abstract enableDeviceEmulation: parameters: DeviceEmulationParameters -> unit
    abstract disableDeviceEmulation: unit -> unit
    abstract sendInputEvent: ``event``: SendInputEvent -> unit
    abstract beginFrameSubscription: callback: (Buffer->unit) -> unit
    abstract endFrameSubscription: unit -> unit
    abstract savePage: fullPath: string * saveType: (* TODO: StringEnum *) string * ?callback: (Exception->unit) -> bool

type Headers =
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: key: string -> string with get, set

type [<StringEnum>] NewWindowDisposition =
    | Default | ``Foreground-tab`` | ``Background-tab`` | ``New-window`` | Other

type [<StringEnum>] StopFindInPageAtion =
    | ClearSelection | KeepSelection | ActivateSelection

type [<StringEnum>] CursorType =
    | Default | Crosshair | Pointer | Text | Wait | Help | ``E-resize`` | ``N-resize`` | ``Ne-resize`` | ``Nw-resize`` | ``S-resize`` | ``Se-resize`` | ``Sw-resize`` | ``W-resize`` | ``Ns-resize`` | ``Ew-resize`` | ``Nesw-resize`` | ``Nwse-resize`` | ``Col-resize`` | ``Row-resize`` | ``M-panning`` | ``E-panning`` | ``N-panning`` | ``Ne-panning`` | ``Nw-panning`` | ``S-panning`` | ``Se-panning`` | ``Sw-panning`` | ``W-panning`` | Move | ``Vertical-text`` | Cell | ``Context-menu`` | Alias | Progress | Nodrop | Copy | None | ``Not-allowed`` | ``Zoom-in`` | ``Zoom-out`` | Grab | Grabbing | Custom

type LoadURLOptions =
    abstract httpReferrer: string option with get, set
    abstract userAgent: string option with get, set
    abstract extraHeaders: string option with get, set

type PrintOptions =
    abstract silent: bool option with get, set
    abstract printBackground: bool option with get, set

type PrintToPDFOptions =
    abstract marginsType: float option with get, set
    abstract pageSize: string option with get, set
    abstract printBackground: bool option with get, set
    abstract printSelectionOnly: bool option with get, set
    abstract landscape: bool option with get, set

type Certificate =
    abstract data: Buffer with get, set
    abstract issuerName: string with get, set

type LoginRequest =
    abstract ``method``: string with get, set
    abstract url: string with get, set
    abstract referrer: string with get, set

type LoginAuthInfo =
    abstract isProxy: bool with get, set
    abstract scheme: string with get, set
    abstract host: string with get, set
    abstract port: float with get, set
    abstract realm: string with get, set

type FindInPageOptions =
    abstract forward: bool option with get, set
    abstract findNext: bool option with get, set
    abstract matchCase: bool option with get, set
    abstract wordStart: bool option with get, set
    abstract medialCapitalAsWordStart: bool option with get, set

type FoundInPageResult =
    abstract requestId: float with get, set
    abstract finalUpdate: bool with get, set
    abstract activeMatchOrdinal: float option with get, set
    abstract matches: float option with get, set
    abstract selectionArea: Bounds option with get, set

type DeviceEmulationParameters =
    abstract screenPosition: (* TODO: StringEnum *) string option with get, set
    abstract screenSize: Dimension option with get, set
    abstract viewPosition: Point option with get, set
    abstract deviceScaleFactor: float with get, set
    abstract viewSize: Dimension option with get, set
    abstract fitToView: bool option with get, set
    abstract offset: Point option with get, set
    abstract scale: float with get, set

type SendInputEvent =
    abstract ``type``: string with get, set
    abstract modifiers: string[] with get, set

type SendInputKeyboardEvent =
    inherit SendInputEvent
    abstract keyCode: string with get, set

type SendInputMouseEvent =
    inherit SendInputEvent
    abstract x: float with get, set
    abstract y: float with get, set
    abstract button: (* TODO: StringEnum *) string option with get, set
    abstract globalX: float option with get, set
    abstract globalY: float option with get, set
    abstract movementX: float option with get, set
    abstract movementY: float option with get, set
    abstract clickCount: float option with get, set

type SendInputMouseWheelEvent =
    inherit SendInputEvent
    abstract deltaX: float option with get, set
    abstract deltaY: float option with get, set
    abstract wheelTicksX: float option with get, set
    abstract wheelTicksY: float option with get, set
    abstract accelerationRatioX: float option with get, set
    abstract accelerationRatioY: float option with get, set
    abstract hasPreciseScrollingDeltas: float option with get, set
    abstract canScroll: bool option with get, set

type Debugger =
    inherit EventEmitter
    abstract attach: ?protocolVersion: string -> unit
    abstract isAttached: unit -> bool
    abstract detach: unit -> unit
    abstract sendCommand: ``method``: string * ?commandParams: obj * ?callback: (Exception->obj->unit) -> unit
    [<Emit("$0.on('detach',$1...)")>] abstract on_detach: listener: Function -> obj
    [<Emit("$0.on('message',$1...)")>] abstract on_message: listener: Function -> obj
    abstract on: ``event``: string * listener: Function -> obj

type WebFrame =
    abstract setZoomFactor: factor: float -> unit
    abstract getZoomFactor: unit -> float
    abstract setZoomLevel: level: float -> unit
    abstract getZoomLevel: unit -> float
    abstract setZoomLevelLimits: minimumLevel: float * maximumLevel: float -> unit
    abstract setSpellCheckProvider: language: string * autoCorrectWord: bool * provider: obj -> unit
    abstract registerURLSchemeAsSecure: scheme: string -> unit
    abstract registerURLSchemeAsBypassingCSP: scheme: string -> unit
    abstract registerURLSchemeAsPrivileged: scheme: string -> unit
    abstract insertText: text: string -> unit
    abstract executeJavaScript: code: string * ?userGesture: bool * ?callback: (obj->unit) -> unit

type BrowserWindowProxy =
    abstract closed: bool with get, set
    abstract blur: unit -> unit
    abstract close: unit -> unit
    abstract eval: code: string -> unit
    abstract focus: unit -> unit
    abstract postMessage: message: string * targetOrigin: string -> unit

type CommonElectron =
    abstract clipboard: Clipboard with get, set
    abstract crashReporter: CrashReporter with get, set
    abstract nativeImage: NativeImageStatic with get, set
    abstract shell: Shell with get, set
    abstract app: App with get, set
    abstract autoUpdater: AutoUpdater with get, set
    abstract BrowserWindow: BrowserWindowStatic with get, set
    abstract contentTracing: ContentTracing with get, set
    abstract dialog: Dialog with get, set
    abstract ipcMain: IpcMain with get, set
    abstract globalShortcut: GlobalShortcut with get, set
    abstract Menu: MenuStatic with get, set
    abstract MenuItem: MenuItemStatic with get, set
    abstract powerMonitor: PowerMonitor with get, set
    abstract powerSaveBlocker: PowerSaveBlocker with get, set
    abstract protocol: Protocol with get, set
    abstract screen: Screen with get, set
    abstract session: SessionStatic with get, set
    abstract Tray: Tray with get, set
    abstract hideInternalModules: unit -> unit

type ElectronMainAndRenderer =
    inherit CommonElectron
    abstract desktopCapturer: DesktopCapturer with get, set
    abstract ipcRenderer: IpcRenderer with get, set
    abstract remote: Remote with get, set
    abstract webFrame: WebFrame with get, set

module WebRequest =
    type Filter =
        abstract urls: string[] with get, set

    type Details =
        abstract id: float with get, set
        abstract url: string with get, set
        abstract ``method``: string with get, set
        abstract resourceType: string with get, set
        abstract timestamp: float with get, set

    type UploadData =
        abstract bytes: Buffer with get, set
        abstract file: string with get, set

    type BeforeRequestDetails =
        inherit Details
        abstract uploadData: UploadData[] option with get, set

    type BeforeRequestCallback =
        (obj->unit)

    type BeforeSendHeadersDetails =
        inherit Details
        abstract requestHeaders: Headers with get, set

    type BeforeSendHeadersCallback =
        (obj->unit)

    type SendHeadersDetails =
        inherit Details
        abstract requestHeaders: Headers with get, set

    type HeadersReceivedDetails =
        inherit Details
        abstract statusLine: string with get, set
        abstract statusCode: float with get, set
        abstract responseHeaders: Headers with get, set

    type HeadersReceivedCallback =
        (obj->unit)

    type ResponseStartedDetails =
        inherit Details
        abstract responseHeaders: Headers with get, set
        abstract fromCache: bool with get, set
        abstract statusCode: float with get, set
        abstract statusLine: string with get, set

    type BeforeRedirectDetails =
        inherit Details
        abstract redirectURL: string with get, set
        abstract statusCode: float with get, set
        abstract ip: string option with get, set
        abstract fromCache: bool with get, set
        abstract responseHeaders: Headers with get, set

    type CompletedDetails =
        inherit Details
        abstract responseHeaders: Headers with get, set
        abstract fromCache: bool with get, set
        abstract statusCode: float with get, set
        abstract statusLine: string with get, set

    type ErrorOccurredDetails =
        inherit Details
        abstract fromCache: bool with get, set
        abstract error: string with get, set

type IWebRequest =
    abstract onBeforeRequest: listener: Function -> unit
    abstract onBeforeRequest: filter: WebRequest.Filter * listener: Function -> unit
    abstract onBeforeSendHeaders: listener: Function -> unit
    abstract onBeforeSendHeaders: filter: WebRequest.Filter * listener: Function -> unit
    abstract onSendHeaders: listener: Function -> unit
    abstract onSendHeaders: filter: WebRequest.Filter * listener: Function -> unit
    abstract onHeadersReceived: listener: Function -> unit
    abstract onHeadersReceived: filter: WebRequest.Filter * listener: Function -> unit
    abstract onResponseStarted: listener: Function -> unit
    abstract onResponseStarted: filter: WebRequest.Filter * listener: Function -> unit
    abstract onBeforeRedirect: listener: Function -> unit
    abstract onBeforeRedirect: filter: WebRequest.Filter * listener: Function -> unit
    abstract onCompleted: listener: Function -> unit
    abstract onCompleted: filter: WebRequest.Filter * listener: Function -> unit
    abstract onErrorOccurred: listener: Function -> unit
    abstract onErrorOccurred: filter: WebRequest.Filter * listener: Function -> unit


// module WebViewElement =
//     type Event =
//         ElectronPrivate.GlobalEvent

//     type LoadCommitEvent =
//         inherit Event
//         abstract url: string with get, set
//         abstract isMainFrame: bool with get, set

//     type DidFailLoadEvent =
//         inherit Event
//         abstract errorCode: float with get, set
//         abstract errorDescription: string with get, set
//         abstract validatedURL: string with get, set
//         abstract isMainFrame: bool with get, set

//     type DidFrameFinishLoadEvent =
//         inherit Event
//         abstract isMainFrame: bool with get, set

//     type DidGetResponseDetails =
//         inherit Event
//         abstract status: bool with get, set
//         abstract newURL: string with get, set
//         abstract originalURL: string with get, set
//         abstract httpResponseCode: float with get, set
//         abstract requestMethod: string with get, set
//         abstract referrer: string with get, set
//         abstract headers: Headers with get, set
//         abstract resourceType: string with get, set

//     type DidGetRedirectRequestEvent =
//         inherit Event
//         abstract oldURL: string with get, set
//         abstract newURL: string with get, set
//         abstract isMainFrame: bool with get, set
//         abstract httpResponseCode: float with get, set
//         abstract requestMethod: string with get, set
//         abstract referrer: string with get, set
//         abstract headers: Headers with get, set

//     type PageTitleUpdatedEvent =
//         inherit Event
//         abstract title: string with get, set
//         abstract explicitSet: string with get, set

//     type PageFaviconUpdatedEvent =
//         inherit Event
//         abstract favicons: string[] with get, set

//     type ConsoleMessageEvent =
//         inherit Event
//         abstract level: float with get, set
//         abstract message: string with get, set
//         abstract line: float with get, set
//         abstract sourceId: string with get, set

//     type FoundInPageEvent =
//         inherit Event
//         abstract result: FoundInPageResult with get, set

//     type NewWindowEvent =
//         inherit Event
//         abstract url: string with get, set
//         abstract frameName: string with get, set
//         abstract disposition: NewWindowDisposition with get, set
//         abstract options: BrowserWindowOptions with get, set

//     type NavigateEvent =
//         inherit Event
//         abstract url: string with get, set

//     type IpcMessageEvent =
//         inherit Event
//         abstract channel: string with get, set
//         abstract args: obj[] with get, set

//     type PluginCrashedEvent =
//         inherit Event
//         abstract name: string with get, set
//         abstract version: string with get, set

//     type DidChangeThemeColorEvent =
//         inherit Event
//         abstract themeColor: string with get, set

type IWebViewElement =
    inherit HTMLElement
    abstract src: string with get, set
    abstract autosize: string with get, set
    abstract nodeintegration: string with get, set
    abstract plugins: string with get, set
    abstract preload: string with get, set
    abstract httpreferrer: string with get, set
    abstract useragent: string with get, set
    abstract disablewebsecurity: string with get, set
    abstract partition: string with get, set
    abstract allowpopups: string with get, set
    abstract blinkfeatures: string with get, set
    abstract loadURL: url: string * ?options: LoadURLOptions -> unit
    abstract getURL: unit -> string
    abstract getTitle: unit -> string
    abstract isLoading: unit -> bool
    abstract isWaitingForResponse: unit -> bool
    abstract stop: unit -> unit
    abstract reload: unit -> unit
    abstract reloadIgnoringCache: unit -> unit
    abstract canGoBack: unit -> bool
    abstract canGoForward: unit -> bool
    abstract canGoToOffset: offset: float -> bool
    abstract clearHistory: unit -> unit
    abstract goBack: unit -> unit
    abstract goForward: unit -> unit
    abstract goToIndex: index: float -> unit
    abstract goToOffset: offset: bool -> unit
    abstract isCrashed: unit -> bool
    abstract setUserAgent: userAgent: string -> unit
    abstract getUserAgent: unit -> string
    abstract insertCSS: css: string -> unit
    abstract executeJavaScript: code: string * ?userGesture: bool * ?callback: (obj->unit) -> unit
    abstract openDevTools: unit -> unit
    abstract closeDevTools: unit -> unit
    abstract isDevToolsOpened: unit -> bool
    abstract isDevToolsFocused: unit -> bool
    abstract inspectElement: x: float * y: float -> unit
    abstract inspectServiceWorker: unit -> unit
    abstract setAudioMuted: muted: bool -> unit
    abstract isAudioMuted: unit -> bool
    abstract undo: unit -> unit
    abstract redo: unit -> unit
    abstract cut: unit -> unit
    abstract copy: unit -> unit
    abstract paste: unit -> unit
    abstract pasteAndMatchStyle: unit -> unit
    abstract delete: unit -> unit
    abstract selectAll: unit -> unit
    abstract unselect: unit -> unit
    abstract replace: text: string -> unit
    abstract replaceMisspelling: text: string -> unit
    abstract insertText: text: string -> unit
    abstract findInPage: text: string * ?options: FindInPageOptions -> float
    abstract stopFindInPage: action: StopFindInPageAtion -> unit
    abstract print: ?options: PrintOptions -> unit
    abstract printToPDF: options: PrintToPDFOptions * callback: (Exception->Buffer->unit) -> unit
    abstract send: channel: string * [<ParamArray>] args: obj[] -> unit
    abstract sendInputEvent: ``event``: SendInputEvent -> unit
    abstract getWebContents: unit -> WebContents
    // [<Emit("$0.addEventListener('load-commit',$1...)")>] abstract ``addEventListener_load-commit``: listener: Func<WebViewElement.LoadCommitEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('did-finish-load',$1...)")>] abstract ``addEventListener_did-finish-load``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('did-fail-load',$1...)")>] abstract ``addEventListener_did-fail-load``: listener: Func<WebViewElement.DidFailLoadEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('did-frame-finish-load',$1...)")>] abstract ``addEventListener_did-frame-finish-load``: listener: Func<WebViewElement.DidFrameFinishLoadEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('did-start-loading',$1...)")>] abstract ``addEventListener_did-start-loading``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('did-stop-loading',$1...)")>] abstract ``addEventListener_did-stop-loading``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('did-get-response-details',$1...)")>] abstract ``addEventListener_did-get-response-details``: listener: Func<WebViewElement.DidGetResponseDetails, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('did-get-redirect-request',$1...)")>] abstract ``addEventListener_did-get-redirect-request``: listener: Func<WebViewElement.DidGetRedirectRequestEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('dom-ready',$1...)")>] abstract ``addEventListener_dom-ready``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('page-title-updated',$1...)")>] abstract ``addEventListener_page-title-updated``: listener: Func<WebViewElement.PageTitleUpdatedEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('page-favicon-updated',$1...)")>] abstract ``addEventListener_page-favicon-updated``: listener: Func<WebViewElement.PageFaviconUpdatedEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('enter-html-full-screen',$1...)")>] abstract ``addEventListener_enter-html-full-screen``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('leave-html-full-screen',$1...)")>] abstract ``addEventListener_leave-html-full-screen``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('console-message',$1...)")>] abstract ``addEventListener_console-message``: listener: Func<WebViewElement.ConsoleMessageEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('found-in-page',$1...)")>] abstract ``addEventListener_found-in-page``: listener: Func<WebViewElement.FoundInPageEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('new-window',$1...)")>] abstract ``addEventListener_new-window``: listener: Func<WebViewElement.NewWindowEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('will-navigate',$1...)")>] abstract ``addEventListener_will-navigate``: listener: Func<WebViewElement.NavigateEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('did-navigate',$1...)")>] abstract ``addEventListener_did-navigate``: listener: Func<WebViewElement.NavigateEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('did-navigate-in-page',$1...)")>] abstract ``addEventListener_did-navigate-in-page``: listener: Func<WebViewElement.NavigateEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('close',$1...)")>] abstract addEventListener_close: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('ipc-message',$1...)")>] abstract ``addEventListener_ipc-message``: listener: Func<WebViewElement.IpcMessageEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('crashed',$1...)")>] abstract addEventListener_crashed: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('gpu-crashed',$1...)")>] abstract ``addEventListener_gpu-crashed``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('plugin-crashed',$1...)")>] abstract ``addEventListener_plugin-crashed``: listener: Func<WebViewElement.PluginCrashedEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('destroyed',$1...)")>] abstract addEventListener_destroyed: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('media-started-playing',$1...)")>] abstract ``addEventListener_media-started-playing``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('media-paused',$1...)")>] abstract ``addEventListener_media-paused``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('did-change-theme-color',$1...)")>] abstract ``addEventListener_did-change-theme-color``: listener: Func<WebViewElement.DidChangeThemeColorEvent, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('devtools-opened',$1...)")>] abstract ``addEventListener_devtools-opened``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('devtools-closed',$1...)")>] abstract ``addEventListener_devtools-closed``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    // [<Emit("$0.addEventListener('devtools-focused',$1...)")>] abstract ``addEventListener_devtools-focused``: listener: Func<WebViewElement.Event, unit> * ?useCapture: bool -> unit
    abstract addEventListener: ``type``: string * listener: Function * ?useCapture: bool -> unit

// module NodeJS =
//     type Process =
//         abstract ``type``: string with get, set
//         abstract resourcesPath: string with get, set
//         abstract mas: bool option with get, set
//         abstract windowsStore: bool option with get, set
//         abstract noAsar: bool option with get, set
//         [<Emit("$0.on('loaded',$1...)")>] abstract on_loaded: listener: Function -> obj
//         abstract on: ``event``: string * listener: Function -> obj
//         abstract crash: unit -> unit
//         abstract hang: unit -> unit
//         abstract setFdLimit: maxDescriptors: float -> unit

 [<AutoOpen>]
 module electron_Extensions =
     let [<Import("default","electron")>] electron: ElectronMainAndRenderer = failwith "JS only"
