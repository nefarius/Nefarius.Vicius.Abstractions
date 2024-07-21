# MergedConfig

Namespace: Nefarius.Vicius.Abstractions.Models

The shared configuration that has been merged with local and remote parameters.

```csharp
public sealed class MergedConfig
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MergedConfig](./nefarius.vicius.abstractions.models.mergedconfig.md)

**Remarks:**

Keep in sync with [SharedConfig](./nefarius.vicius.abstractions.models.sharedconfig.md).

## Properties

### <a id="properties-detection"/>**Detection**

The details of the selected [MergedConfig.DetectionMethod](./nefarius.vicius.abstractions.models.mergedconfig.md#detectionmethod).

```csharp
public ProductVersionDetectionImplementation Detection { get; set; }
```

#### Property Value

[ProductVersionDetectionImplementation](./nefarius.vicius.abstractions.models.productversiondetectionimplementation.md)<br>

### <a id="properties-detectionmethod"/>**DetectionMethod**

The implementation to use to detect the locally installed product version to compare release versions against.

```csharp
public ProductVersionDetectionMethod DetectionMethod { get; set; }
```

#### Property Value

[ProductVersionDetectionMethod](./nefarius.vicius.abstractions.models.productversiondetectionmethod.md)<br>

### <a id="properties-downloadlocation"/>**DownloadLocation**

The preferred setup download directory.

```csharp
public DownloadLocationConfig DownloadLocation { get; set; }
```

#### Property Value

[DownloadLocationConfig](./nefarius.vicius.abstractions.models.downloadlocationconfig.md)<br>

**Remarks:**

By default, a temporary directory of the current user is used.

### <a id="properties-installationerrorurl"/>**InstallationErrorUrl**

URL pointing to a help article opening when an update error occurred.

```csharp
public string InstallationErrorUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-productname"/>**ProductName**

The product name displayed in the UI and dialogs.

```csharp
public string ProductName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-runastemporarycopy"/>**RunAsTemporaryCopy**

Gets or sets whether the updater should run as a temporary copy instead from the origin directory.

```csharp
public bool RunAsTemporaryCopy { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-windowtitle"/>**WindowTitle**

The process window title visible in the taskbar.

```csharp
public string WindowTitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**MergedConfig()**

#### Caution

Constructors of types with required members are not supported in this version of your compiler.

---

```csharp
public MergedConfig()
```
