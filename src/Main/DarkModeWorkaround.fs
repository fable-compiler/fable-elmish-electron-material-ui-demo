module DarkModeWorkaround

open Fable.Core
open Node
open Node.Base
open Electron

// Work-around for this Electron bug: https://github.com/electron/electron/issues/19468
// Based on https://gist.github.com/LuminescentMoon/f7a180a6960d4d1b9b7e72acb1c77275

let private setWindowsAppTheme(light: bool) =
  let flag = if light then 1 else 0
  try
    childProcess.execSync(
      sprintf "REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize /v AppsUseLightTheme /t REG_DWORD /d %i /f" flag,
      {| windowsHide = true |}
    )
    |> ignore
  with _ -> failwith "No permission to modify AppsUseLightTheme value. Electron will hang. Change Windows app theme to Light manually before starting Electron."


let init () =

  if ``process``.platform = Win32 && main.nativeTheme.shouldUseDarkColors then
    main.app
      .onWillFinishLaunching(fun _ ->
        JS.console.log("Setting Windows app theme to Light to avoid DevTools startup issue")
        setWindowsAppTheme true)
      .onReady(fun _ _ ->
        JS.console.log("Reverting Windows app theme to Dark")
        setWindowsAppTheme false)
    |> ignore
