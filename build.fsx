#r "./packages/fake/tools/fakelib.dll"

open Fake
open Fake.Testing

let sourceDir = "./src/"

let buildDir = "./build/"

let testsSourceDir = "./tests/"

let testsBuildDir = buildDir + "tests/"

let deployDir = buildDir + "/setup/"

MSBuildDefaults <- {MSBuildDefaults with ToolsVersion = Some("12.0")}

Target "Clean" (fun _ ->
    CleanDirs [buildDir]
)

Target "Build" (fun _ ->
    !!(sourceDir + "**/*.csproj")
    |> MSBuildDebug  buildDir "Build" 
    |> Log "Build-Output: "
)

Target "TestBUild" (fun _ ->
    !!(testsSourceDir + "**/*.csproj")
    |> MSBuildDebug  testsBuildDir "Build" 
    |> Log "BuildTest-Output: "
)

Target "Test" (fun _ -> 
    !! (testsBuildDir + "*Tests.dll")
    |> xUnit2 (fun p -> {p with HtmlOutputPath = Some(testsBuildDir + "test.html"); ToolPath = "packages/xunit.runner.console/tools/xunit.console.exe"})
)

Target "Deploy" (fun _ ->
    !!(sourceDir + "**/*.wixproj")
    |> MSBuildDebug  deployDir "Build" 
    |> Log "BuildSetup-Output: "
)


"Clean" ==> "Build" ==> "TestBuild" ==> "Test" ==> "Deploy"

RunTargetOrDefault "Deploy"