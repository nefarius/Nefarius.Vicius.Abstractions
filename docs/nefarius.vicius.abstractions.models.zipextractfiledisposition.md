# ZipExtractFileDisposition

Namespace: Nefarius.Vicius.Abstractions.Models

How to treat files when installing a .zip file.

```csharp
public enum ZipExtractFileDisposition
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [ZipExtractFileDisposition](./nefarius.vicius.abstractions.models.zipextractfiledisposition.md)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [ISpanFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.ispanformattable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| CreateIfAbsent | 0 | Create the extracted file if it doesn't already exist locally. |
| CreateOrReplace | 1 | Create or replace a locally existing file with the extracted one of the same name. |
| DeleteIfPresent | 2 | Delete the local file, if found. |
