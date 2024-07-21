# SignatureComparisonPolicy

Namespace: Nefarius.Vicius.Abstractions.Models

The policy to abide by when comparing signatures.

```csharp
public enum SignatureComparisonPolicy
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [SignatureComparisonPolicy](./nefarius.vicius.abstractions.models.signaturecomparisonpolicy.md)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [ISpanFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.ispanformattable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Relaxed | 0 | Allows the user to make the decision to continue when the remote setup signature doesn't match the expected value. This is the default. |
| Strict | 1 | Fails with an error when the remote setup signature doesn't match the expected value. |
