Sample of a nuget package that includes multiple assemblies (PackageLibrary.dll + ReferencedLibrary.dll) but only exposes the main (PackageLibrary.dll) assembly.

Build instructions: `dotnet pack PackageLibrary`

Correctly handles:
- Symbol packages via `IncludeSymbols=true`
- Documentation file via `GenerateDocumentationFile=true`
- TFMs with Target Platform Monikers (i.e. `net8.0-windows7.0`)

Doesn't support:
- Flowing dependencies transitively from referenced projects to the main (PackageLibrary.csproj) due to the use of `PrivateAssets=all`.
- Target Frameworks with Target Platform Monikers without specifying a Target Platform Version (i.e. `net8.0-windows`)
