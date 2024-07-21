# SharedConfig

Namespace: Nefarius.Vicius.Abstractions.Models

Parameters that might be provided by both the server and the local configuration.

```csharp
public sealed class SharedConfig
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SharedConfig](./nefarius.vicius.abstractions.models.sharedconfig.md)

## Properties

### <a id="properties-detection"/>**Detection**

The details of the selected [SharedConfig.DetectionMethod](./nefarius.vicius.abstractions.models.sharedconfig.md#detectionmethod).

```csharp
public ProductVersionDetectionImplementation Detection { get; set; }
```

#### Property Value

[ProductVersionDetectionImplementation](./nefarius.vicius.abstractions.models.productversiondetectionimplementation.md)<br>

### <a id="properties-detectionmethod"/>**DetectionMethod**

The implementation to use to detect the locally installed product version to compare release versions against.

```csharp
public Nullable<ProductVersionDetectionMethod> DetectionMethod { get; private set; }
```

#### Property Value

[Nullable&lt;ProductVersionDetectionMethod&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-downloadlocation"/>**DownloadLocation**

The preferred setup download directory.

```csharp
public DownloadLocationConfig DownloadLocation { get; set; }
```

#### Property Value

[DownloadLocationConfig](./nefarius.vicius.abstractions.models.downloadlocationconfig.md)<br>

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
public Nullable<Boolean> RunAsTemporaryCopy { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-windowtitle"/>**WindowTitle**

The process window title visible in the taskbar.

```csharp
public string WindowTitle { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### <a id="constructors-.ctor"/>**SharedConfig()**

```csharp
public SharedConfig()
```
