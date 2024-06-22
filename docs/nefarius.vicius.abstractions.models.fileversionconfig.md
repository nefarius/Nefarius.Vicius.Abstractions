# FileVersionConfig

Namespace: Nefarius.Vicius.Abstractions.Models

Reads the version resource of the specified local file and matches it against the selected
 [UpdateRelease](./nefarius.vicius.abstractions.models.updaterelease.md) version.

```csharp
public sealed class FileVersionConfig : ProductVersionDetectionImplementation
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ProductVersionDetectionImplementation](./nefarius.vicius.abstractions.models.productversiondetectionimplementation.md) → [FileVersionConfig](./nefarius.vicius.abstractions.models.fileversionconfig.md)

## Properties

### <a id="properties-data"/>**Data**

Optional inja template data.

```csharp
public Dictionary<String, String> Data { get; set; }
```

#### Property Value

[Dictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2)<br>

### <a id="properties-input"/>**Input**

The absolute local path to the file to read or an inja template.

```csharp
public string Input { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-statement"/>**Statement**

The [VersionResource](./nefarius.vicius.abstractions.models.versionresource.md) to read.

```csharp
public VersionResource Statement { get; set; }
```

#### Property Value

[VersionResource](./nefarius.vicius.abstractions.models.versionresource.md)<br>

## Constructors

### <a id="constructors-.ctor"/>**FileVersionConfig()**

#### Caution

Constructors of types with required members are not supported in this version of your compiler.

---

```csharp
public FileVersionConfig()
```
