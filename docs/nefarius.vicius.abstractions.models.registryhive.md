# RegistryHive

Namespace: Nefarius.Vicius.Abstractions.Models

The registry hive to search for keys/values under.

```csharp
public enum RegistryHive
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [RegistryHive](./nefarius.vicius.abstractions.models.registryhive.md)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| HKCU | 0 | HKEY_CURRENT_USER hive. |
| HKLM | 1 | HKEY_LOCAL_MACHINE hive. |
| HKCR | 2 | HKEY_CLASSES_ROOT hive. |
