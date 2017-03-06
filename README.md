# DotNetNewNSpec

[![NuGet Version and Downloads count](https://buildstats.info/nuget/dotnet-new-nspec)](https://www.nuget.org/packages/dotnet-new-nspec)

DotNetNewNSpec is a set of Visual Studio project templates to be used when creating projects from .NET Core `dotnet new` command line interface.

Currently, it contains a project template for a NSpec test library targeting both .NET Core and .NET Framework.

## Minimum requirements

Even if template currently creates a project supporting *.NET Core Tools Preview 2* (the one based on project.json),
in order to install custom CLI templates like this you need to have at least **.NET Core Tools RC4** on your development machine.

## Usage

To install the latest version of templates, from a command line run:

```
> dotnet new --install dotnet-new-nspec::*
```

To create a NSpec library project from template:

```
> dotnet new nspectest -n MyTestProject
```

For more instructions on creating projects from the command line, see https://docs.microsoft.com/en-us/dotnet/articles/core/preview3/tools/dotnet-new.

For more info on NSpec testing framework, please see [its project](https://github.com/nspec/NSpec) or [nspec.org](http://nspec.org/) website.

## Breaking changes

To check for potential breaking changes, see [BREAKING-CHANGES.md](./BREAKING-CHANGES.md).

## License

[MIT](./license.txt)

## Credits

DotNetNewNSpec is written by [BrainCrumbz](http://www.braincrumbz.com).
