# UpdateConfig

Namespace: Nefarius.Vicius.Abstractions.Models

Update instance configuration. Parameters applying to the entire product/tenant.

```csharp
public sealed class UpdateConfig
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [UpdateConfig](./nefarius.vicius.abstractions.models.updateconfig.md)

## Properties

### <a id="properties-emergencyurl"/>**EmergencyUrl**

The emergency URL. See https://docs.nefarius.at/projects/Vicius/Emergency-Feature/

```csharp
public string EmergencyUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-errorfallbackurl"/>**ErrorFallbackUrl**

URL pointing to a help article opening when the user was presented with an error dialog.

```csharp
public string ErrorFallbackUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-exitcode"/>**ExitCode**

Setup exit code parameters.

```csharp
public ExitCodeCheck ExitCode { get; set; }
```

#### Property Value

[ExitCodeCheck](./nefarius.vicius.abstractions.models.exitcodecheck.md)<br>

### <a id="properties-helpurl"/>**HelpUrl**

URL pointing to a help article opening when the user clicks the help button.

```csharp
public string HelpUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-latesturl"/>**LatestUrl**

The URL to the latest updater binary. Redirects are supported.

```csharp
public string LatestUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-latestversion"/>**LatestVersion**

The latest version of the updater binary.

```csharp
public Version LatestVersion { get; set; }
```

#### Property Value

[Version](https://docs.microsoft.com/en-us/dotnet/api/system.version)<br>

### <a id="properties-updatesdisabled"/>**UpdatesDisabled**

Updates are currently disabled, do not do anything, even if new versions are found.

```csharp
public Nullable<Boolean> UpdatesDisabled { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### <a id="constructors-.ctor"/>**UpdateConfig()**

```csharp
public UpdateConfig()
```
