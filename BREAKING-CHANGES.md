# Breaking Changes

## 1.0.0

### NSpec 2.0.1, dotnet-test-nspec 0.1.1

Removed support for NSpec 2.0.1. Imported version is now NSpec 3.0.0.  
Removed support for dotnet-test-nspec 0.1.1. Imported version is now dotnet-test-nspec 0.2.0.

#### Reason

In order to enable integration with Visual Studio 2015 IDE, so to list and run tests from
Test Explorer Window.

#### Workaround

None. Remain on template version 0.1.0 if you need to support NSpec 2.0.1 or dotnet-test-nspec
0.1.1, or if you don't care about running tests from VS IDE.

### Microsoft transitive dependencies

When targeting .NET Core, added dependency on
Microsoft.Extensions.Testing.Abstractions 1.0.0-preview2-003121.  
When targeting .NET Framework, added dependencies on Microsoft.DiaSymReader.Native 1.4.2,
and on Microsoft.NETCore.Platforms 1.1.0.

#### Reason

Still because of VS IDE integration, those dependencies have been added in NSpec or in
dotnet-test-nspec. But due to an issue between .NET Core CLI Tools Preview 2 and NuGet
v3 that will not get solved (as *project.json* is being deprecated in favour of MSBuild),
those (transitive) dependencies must be applied to client test project as well.

#### Workaround

Same as above. Remain on template version 0.1.0 if you need to support NSpec 2.0.1 or
dotnet-test-nspec 0.1.1, or if you don't care about running tests from VS IDE.
