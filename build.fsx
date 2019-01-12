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
    ++ "fable"
    |> Shell.cleanDirs
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
    ==> "Build"

"YarnInstall"
    ==> "Dev"

"YarnInstall"
    ==> "Dist"

"YarnInstall"
    ==> "DistDir"

// start build
Target.runOrDefault "Dev"
