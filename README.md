# Class Library Projects

- [Create a .NET class library using Visual Studio for Mac](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-mac)


## Add a console app to the solution

- In the Solution pad, ctrl-click the ClassLibraryProjects solution, select Add > New Project. Add a new Console Application project by selecting the template from the Web and Console > App templates, and select Next.


## Where is the solution explorer in Visual Studio Code for Mac?

Simply quit the application, and restart again

## Why am I getting error CS0246: The type or namespace name could not be found?

You have to make a project reference.

## Add a project reference

Initially, the new console app project doesn't have access to the class library. To allow it to call methods in the class library, create a project reference to the class library project.

In Solution Explorer, right-click the ShowCase project's Dependencies node, and select Add Project Reference.

## Run the application with library extensions

- In Solution Explorer, right-click the ShowCase project and select Set as StartUp Project in the context menu.
- Press Ctrl+F5 to compile and run the program without debugging.
- Try out the program by entering strings and pressing Enter
- press Enter with empty input to exit.