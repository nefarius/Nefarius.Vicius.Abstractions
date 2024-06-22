# RegistryValueConfig

Namespace: Nefarius.Vicius.Abstractions.Models

Queries a specific registry value and matches it against the selected [UpdateRelease](./nefarius.vicius.abstractions.models.updaterelease.md) version.

```csharp
public sealed class RegistryValueConfig : ProductVersionDetectionImplementation
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ProductVersionDetectionImplementation](./nefarius.vicius.abstractions.models.productversiondetectionimplementation.md) → [RegistryValueConfig](./nefarius.vicius.abstractions.models.registryvalueconfig.md)

## Properties

### <a id="properties-hive"/>**Hive**

The hive.

```csharp
public RegistryHive Hive { get; set; }
```

#### Property Value

[RegistryHive](./nefarius.vicius.abstractions.models.registryhive.md)<br>

### <a id="properties-key"/>**Key**

The (sub-)key.

```csharp
public string Key { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-value"/>**Value**

The value name.

```csharp
public string Value { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-view"/>**View**

The alternate view.

```csharp
public RegistryView View { get; set; }
```

#### Property Value

[RegistryView](./nefarius.vicius.abstractions.models.registryview.md)<br>

## Constructors

### <a id="constructors-.ctor"/>**RegistryValueConfig()**

#### Caution

Constructors of types with required members are not supported in this version of your compiler.

---

```csharp
public RegistryValueConfig()
```
