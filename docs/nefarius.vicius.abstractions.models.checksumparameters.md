# ChecksumParameters

Namespace: Nefarius.Vicius.Abstractions.Models

Parameters for checksum/hash calculation.

```csharp
public sealed class ChecksumParameters
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ChecksumParameters](./nefarius.vicius.abstractions.models.checksumparameters.md)

## Properties

### <a id="properties-checksum"/>**Checksum**

The checksum/hash value to compare against.

```csharp
public string Checksum { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-checksumalg"/>**ChecksumAlg**

The algorithm to use to calculate the checksum/hash.

```csharp
public ChecksumAlgorithm ChecksumAlg { get; set; }
```

#### Property Value

[ChecksumAlgorithm](./nefarius.vicius.abstractions.models.checksumalgorithm.md)<br>

## Constructors

### <a id="constructors-.ctor"/>**ChecksumParameters()**

```csharp
public ChecksumParameters()
```
