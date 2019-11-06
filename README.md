# Fable-Elmish-Electron-Material-UI demo [![Build status](https://ci.appveyor.com/api/projects/status/hm2w65e3enahp55g/branch/master?svg=true)](https://ci.appveyor.com/project/cmeeren/fable-elmish-electron-material-ui-demo/branch/master)

This is an example of an F# Electron app centered around Fable 2 and Elmish. The actual app contents (which you can easily replace to build your own Electron app) are intended to show how to use Material-UI (including JSS/style-as-code) as well as serve as examples of how to implement some (not always trivial) UX patterns in Elmish.

To use the demo for scaffolding your own Fable/Elmish/Electron apps, simply clone the repo and start hackin' on the `Renderer` project to get started (details below).

Features/stack:
* Hot module reloading for both code and styles
* Time-travel debugging (using Redux DevTools, RemoteDev, and Fable.Elmish.Debugger)
* Single-command development and packaging with FAKE
* [electron-webpack](https://webpack.electron.build/) takes care of most of the webpack config
* [electron-builder](https://www.electron.build/) packages the app (see their documentation for how to customize)
* [electron-window-state](https://github.com/mawie81/electron-window-state/) for remembering window state between launches
* [Devtron](https://electronjs.org/devtron) for Electron-specific debugging/linting

Stuff demoed:

* Autocomplete
* Badges
* Dialogs
* Saving/loading files
* Selects (dropdowns)
* Snackbars
* Static assets (images etc.)
* Text fields / input validation

### Hot module reloading in action

![Animation showing hot module reloading](readme-hmr.gif)

### Time-travel debugging in action

![Animation showing time-travel debugging](readme-ttd.gif)


## Requirements

* .NET Core SDK 3.0
* Yarn (probably easy to change to npm if you prefer that)


## How to develop

This project uses .NET Core 3 local tools. Therefore, run `dotnet tool restore` to restore the necessary CLI tools before doing anything else.

Then, to run the app locally in "live mode":

`dotnet fake build -t Dev`

(`Dev` is the default target, so you can also just run `dotnet fake build`.)

After the app starts, edit the renderer project in `/src/Renderer` and see the changes appear in real-time thanks to hot module reloading.

Place static files in the root `/static` folder as required by electron-webpack. See the code for the “Static assets” page (and the helpers in `Utils.fs`) to see how to use them.


### Release build to unpacked directory

`dotnet fake build -t DistDir`


### Release build to packed installer

`dotnet fake build -t Dist`


### NuGet package management

Use `dotnet paket` (after running `dotnet tool restore`).

## Improvements welcome!

If you see anything here that looks wrong, suboptimal or just weird, you may very well be right. Don't be shy about opening an issue or PR.
