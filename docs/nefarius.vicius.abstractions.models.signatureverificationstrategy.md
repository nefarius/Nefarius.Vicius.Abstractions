# SignatureVerificationStrategy

Namespace: Nefarius.Vicius.Abstractions.Models

The strategy on how to verify if the setup signature is trusted.

```csharp
public enum SignatureVerificationStrategy
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [SignatureVerificationStrategy](./nefarius.vicius.abstractions.models.signatureverificationstrategy.md)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [ISpanFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.ispanformattable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| FromUpdaterBinary | 0 | Extract the signature information from the updater binary and use that info to validate the signed setup. |
| FromConfiguration | 1 | Use the information provided in the [SharedConfig](./nefarius.vicius.abstractions.models.sharedconfig.md) to validate the signed setup. |
