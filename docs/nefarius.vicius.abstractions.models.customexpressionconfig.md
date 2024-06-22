# CustomExpressionConfig

Namespace: Nefarius.Vicius.Abstractions.Models

A custom expression to evaluate.

```csharp
public sealed class CustomExpressionConfig : ProductVersionDetectionImplementation
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ProductVersionDetectionImplementation](./nefarius.vicius.abstractions.models.productversiondetectionimplementation.md) → [CustomExpressionConfig](./nefarius.vicius.abstractions.models.customexpressionconfig.md)

## Properties

### <a id="properties-data"/>**Data**

Optional inja template data.

```csharp
public Dictionary<String, String> Data { get; set; }
```

#### Property Value

[Dictionary&lt;String, String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2)<br>

### <a id="properties-input"/>**Input**

The inja template.

```csharp
public string Input { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**CustomExpressionConfig()**

#### Caution

Constructors of types with required members are not supported in this version of your compiler.

---

```csharp
public CustomExpressionConfig()
```
