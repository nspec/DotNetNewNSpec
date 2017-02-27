# DotNetNewNSpec

DotNetNewNSpec is a set of Visual Studio project templates to be used when creating projects from .NET Core *dotnet new* command line interface.

Currently, it contains a project template for a NSpec test library targeting both .NET Core and .NET Frameowrk.

For instructions on creating projects from the command line, see:

Even if template currently creates a project based on .NET Core Tools Preview 2 (the one based on project.json),
in order to install custom project templates such this from the command line you need to have at least .NET Core Tools RC4
installed on your machine.

To install the latest version of templates, from a command line run:

```
> dotnet new --install dotnet-new-nspec::*
```

To create a NSpec library project from those templates:

```
> dotnet new nspectest -n MyTestProject
```

For more instructions on creating projects from the command line, see https://docs.microsoft.com/en-us/dotnet/articles/core/preview3/tools/dotnet-new.

For more info on NSpec testing framework, please see [its project](https://github.com/nspec/NSpec) or [nspec.org](http://nspec.org/) website.

DotNetNewNSpec is written by [BrainCrumbz](http://www.braincrumbz.com).

## Breaking changes

To check for potential breaking changes, see [BREAKING-CHANGES.md](./BREAKING-CHANGES.md).

## License

[MIT](./license.txt)
