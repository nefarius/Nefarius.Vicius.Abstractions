# <img src="assets/NSS-128x128.png" align="left" />Nefarius.Vicius.Abstractions

[![.NET](https://github.com/nefarius/Nefarius.Vicius.Abstractions/actions/workflows/build.yml/badge.svg)](https://github.com/nefarius/Nefarius.Vicius.Abstractions/actions/workflows/build.yml) 
![Requirements](https://img.shields.io/badge/Requires-.NET%20Standard%202.0-blue.svg) 
[![Nuget](https://img.shields.io/nuget/v/Nefarius.Vicius.Abstractions)](https://www.nuget.org/packages/Nefarius.Vicius.Abstractions/) 
[![Nuget](https://img.shields.io/nuget/dt/Nefarius.Vicius.Abstractions)](https://www.nuget.org/packages/Nefarius.Vicius.Abstractions/)

## Documentation

[Link to API docs](docs/index.md).

### Generating documentation

```PowerShell
dotnet build -c:Release
dotnet tool install --global Nefarius.Tools.XMLDoc2Markdown
xmldoc2md .\bin\netstandard2.0\Nefarius.Vicius.Abstractions.dll .\docs\
```
