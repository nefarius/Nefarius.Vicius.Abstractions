# SignatureConfig

Namespace: Nefarius.Vicius.Abstractions.Models

Authenticode signature details.

```csharp
public sealed class SignatureConfig
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SignatureConfig](./nefarius.vicius.abstractions.models.signatureconfig.md)

## Properties

### <a id="properties-issuername"/>**IssuerName**

The issuer name (CA display name).

```csharp
public string IssuerName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-serialnumber"/>**SerialNumber**

The signing certificate serial number as a hex-string. The format depends on the CA used.

```csharp
public string SerialNumber { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-subjectname"/>**SubjectName**

The subject name (e.g. friendly signer company name).

```csharp
public string SubjectName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**SignatureConfig()**

```csharp
public SignatureConfig()
```
