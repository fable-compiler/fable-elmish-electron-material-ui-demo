#r "paket: groupref FakeBuild //"
#load ".fake/build.fsx/intellisense.fsx"

open System
open Fake.Core
open Fake.Core.TargetOperators
open Fake.DotNet
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.IO.FileSystemOperators
open Fake.JavaScript

Target.create "Clean" (fun _ ->
    !! "src/**/bin"
    ++ "src/**/obj"
    ++ "dist"
    |> Shell.cleanDirs
)

// Simple workaround for https://github.com/electron-userland/electron-webpack/issues/225
Target.create "PatchElectronWebpack" (fun _ ->
    let replace oldValue newValue (str: string) =
        if str.Contains newValue then str
        elif str.Contains oldValue then str.Replace (oldValue, newValue)
        else failwithf "Could not find search text to replace in electron-webpack file. Manual patching may be required.\nOld value: %s\nNew value: %s" oldValue newValue
    let addFSharpEntries (fileContents: string) =
        fileContents
        |> replace """["ts", "js", "tsx"]""" """["ts", "js", "tsx", "fs", "fsproj"]"""
        |> replace """["index", "main", "app"]""" """["index", "main", "app", "Main", "Renderer"]"""
    File.applyReplace addFSharpEntries "node_modules/electron-webpack/out/main.js"
)

Target.create "DotnetRestore" (fun _ ->
    DotNet.restore
        (DotNet.Options.withWorkingDirectory __SOURCE_DIRECTORY__)
        "fable-elmish-electron-demo.sln"
)

Target.create "YarnInstall" (fun _ ->
    Yarn.install id
)

Target.create "Build" (fun _ ->
    Yarn.exec "compile" id
)

Target.create "Dev" (fun _ ->
    Yarn.exec "dev" id
)

Target.create "Dist" (fun _ ->
    Yarn.exec "dist" id
)

Target.create "DistDir" (fun _ ->
    Yarn.exec "dist:dir" id
)

// Build order
"Clean"
    ==> "DotnetRestore"
    ==> "YarnInstall"
    ==> "PatchElectronWebpack"
    ==> "Build"

"PatchElectronWebpack"
    ==> "Dev"

"PatchElectronWebpack"
    ==> "Dist"

"PatchElectronWebpack"
    ==> "DistDir"

// start build
Target.runOrDefault "Dev"
