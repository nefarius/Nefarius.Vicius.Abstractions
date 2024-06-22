# ProductVersionDetectionMethod

Namespace: Nefarius.Vicius.Abstractions.Models

The detection method of the installed software to use on the client.

```csharp
public enum ProductVersionDetectionMethod
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [ProductVersionDetectionMethod](./nefarius.vicius.abstractions.models.productversiondetectionmethod.md)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| RegistryValue | 0 | Performs checking a specified registry hive, key and value. |
| FileVersion | 1 | Performs checking a specified file version resource. |
| FileSize | 2 | Performs checking a specified file size for matching. |
| FileChecksum | 3 | Calculates and compares the hash of a given file. |
| CustomExpression | 4 | Custom inja expression. |
