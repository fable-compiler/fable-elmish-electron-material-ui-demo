module DarkModeWorkaround

open Fable.Core
open Node
open Node.Base
open Electron

// Work-around for this Electron bug: https://github.com/electron/electron/issues/19468
// Based on https://gist.github.com/LuminescentMoon/f7a180a6960d4d1b9b7e72acb1c77275

let private setWindowsAppTheme(light: bool) =
  let flag = if light then 1 else 0
  JS.console.log(sprintf "Setting Windows app theme to %s" (if light then "Light" else "Dark"))
  try
    childProcess.execSync(
      sprintf "REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize /v AppsUseLightTheme /t REG_DWORD /d %i /f" flag,
      {| windowsHide = true |}
    )
    |> ignore
  with _ -> failwith "No permission to modify AppsUseLightTheme value. Electron will hang."


let init () =

  if ``process``.platform = Win32 && main.nativeTheme.shouldUseDarkColors then
    main.app.onWillFinishLaunching(fun _ -> setWindowsAppTheme true) |> ignore
    main.app.onReady(fun _ _ -> setWindowsAppTheme false) |> ignore
