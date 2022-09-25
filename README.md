# Class Library Projects UnitTest Publish

This quickstart shows you how to quickly create a NuGet package from a .NET class LIBRARY and publish it to nuget.org by using the .NET command-line interface, or dotnet CLI.

> [Reference Link Here](https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli)

## Add package metadata to the project file

Every NuGet package has a manifest that describes the package's contents and dependencies. In the final package, the manifest is a .nuspec file, which uses the NuGet metadata properties you include in the project file.

Open the .csproj, .fproj, or .vbproj project file, and add the following properties inside the existing <PropertyGroup> tag. Use your own values for name and company, and replace the package identifier with a unique value.

```
<PackageId>Contoso.08.28.22.001.Test</PackageId>
<Version>1.0.0</Version>
<Authors>your_name</Authors>
<Company>your_company</Company>
```

> The package identifier must be unique across nuget.org and other package sources. Publishing makes the package publicly visible, so if you use the example AppLogger library or other test library, use a unique name that includes Sample or Test. For packages you build for public consumption, pay special attention to the PackageTags property. Tags help others find your package and understand what it does.

You can add any optional properties described in [NuGet metadata properties](https://learn.microsoft.com/en-us/dotnet/core/project-sdk/msbuild-props#nuget-metadata-properties).

## Run the pack command

To build a NuGet package or .nupkg file from the project, run the `dotnet pack` command, which also builds the project automatically.

## Automatically generate package on build

To automatically run dotnet pack whenever you run dotnet build, add the following line to your project file within <PropertyGroup>:

```
<GeneratePackageOnBuild>true</GeneratePackageOnBuild>
```

## Publish the package

Publish your .nupkg file to nuget.org by using the dotnet nuget push command with an API key you get from nuget.org.

Make sure to copy your new API key now using the Copy button below. You will not be able to do so.

- Get your API key
    - [Sign into your nuget.org account](https://www.nuget.org/users/account/LogOn?returnUrl=%2F) or [create an account]() if you don't have one already.
    - Select your user name at upper right, and then select API Keys.
    - Select Create, and provide a name for your key.
    - Under Select Scopes, select Push.
    - Under Select Packages > Glob Pattern, enter *.
    - Select Create.
    - Select Copy to copy the new key.
- Copy the content to new created file `nuget-apikey`
- Add this filename to gitignore

## Publish with dotnet nuget push

From the folder that contains the .nupkg file, run the following command. Specify your .nupkg filename, and replace the key value with your API key.

```bash
cd StringLibrary/bin/Release
dotnet nuget push Mondayrris.09.25.22.001.StringLibrary.1.0.0.nupkg --api-key content_from_nuget_apikey --source https://api.nuget.org/v3/index.json
```

Verify the success result, which contains the text `Your package was pushed`. Check [here](https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli#publish-errors) for publish errors.

## Manage the published package

When your package successfully publishes, you receive a confirmation email. To see the package you just published, on nuget.org, select your user name at upper right, and then select Manage Packages.

## Make your uploaded package not searchable

if you decide you don't want the package to be visible, you can unlist the package to hide it from search results:

- After the package appears under Published Packages on the Manage Packages page, select the pencil icon next to the package listing.

- On the next page, select Listing, deselect the List in search results checkbox, and then select Save.