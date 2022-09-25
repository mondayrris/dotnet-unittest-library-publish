# Class Library Projects UnitTest 

> [Reference Link Here](https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-mac)

## Create a unit test project

- Open the ClassLibraryProjects solution you created in Create a .NET class library using Visual Studio for Mac.
- In the Solution pad, ctrl-click the ClassLibraryProjects solution and select Add > New Project.
- In the New Project dialog, select Tests from the Web and Console node. Select the MSTest Project followed by Next.
- Name the new project "StringLibraryTest" and select Create.

## Add a project reference

For the test project to work with the StringLibrary class, add a reference to the StringLibrary project.
- In the Solution pad, ctrl-click Dependencies under StringLibraryTest. Select Add Reference from the context menu.
- In the References dialog, select the StringLibrary project. Select OK.

## Run UnitTest

- Open the Unit Tests panel on the right side of the screen. Select View > Tests from the menu.
- Click the Pin icon to keep the panel open.
- Click the Run All button.

## Handle test failures

If you're doing `test-driven development (TDD)`, you write tests first and they fail the first time you run them. Then you add code to the app that makes the test succeed. 

For this tutorial, you created the test after writing the app code that it validates, so you haven't seen the test fail. To validate that a test fails when you expect it to fail, add an invalid value to the test input.

## Test the Release version of the library

Now that the tests have all passed when running the Debug build of the library, 
run the tests an additional time against the Release build of the library. 
A number of factors, including compiler optimizations, can sometimes produce different behavior between Debug and Release builds.

To test the Release build:

- In the Visual Studio toolbar, change the build configuration from Debug to Release.
- In the Solution pad, ctrl-click the StringLibrary project and select Build from the context menu to recompile the library.
- Run the unit tests again.

## Debug tests

If you're using Visual Studio for Mac as your IDE, you can use the same process shown in Tutorial: [Debug a .NET console application using Visual Studio for Mac](https://learn.microsoft.com/en-us/dotnet/core/tutorials/debugging-with-visual-studio-mac) to debug code using your unit test project. 

Instead of starting the ShowCase app project, ctrl-click the StringLibraryTests project, and select Start Debugging Project from the context menu.
Visual Studio starts the test project with the debugger attached. Execution will stop at any breakpoint you've added to the test project or the underlying library code.

## Additional resources

- [Unit testing in .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/)

