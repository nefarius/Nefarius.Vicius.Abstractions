# UpdateRelease

Namespace: Nefarius.Vicius.Abstractions.Models

Represents an update release.

```csharp
public sealed class UpdateRelease
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [UpdateRelease](./nefarius.vicius.abstractions.models.updaterelease.md)

## Properties

### <a id="properties-checksum"/>**Checksum**

Optional checksum/hashing settings to perform after download.

```csharp
public ChecksumParameters Checksum { get; set; }
```

#### Property Value

[ChecksumParameters](./nefarius.vicius.abstractions.models.checksumparameters.md)<br>

**Remarks:**

This simply hashes the file contents and compares them, there is no cryptographic signature validation
 performed. It can be used to ensure that the file hasn't been corrupted in transit but doesn't say anything about
 the authenticity or origin of the file.

### <a id="properties-detectionchecksum"/>**DetectionChecksum**

The file hash to use in product detection. This can differ from [UpdateRelease.Checksum](./nefarius.vicius.abstractions.models.updaterelease.md#checksum).

```csharp
public ChecksumParameters DetectionChecksum { get; set; }
```

#### Property Value

[ChecksumParameters](./nefarius.vicius.abstractions.models.checksumparameters.md)<br>

**Remarks:**

This simply hashes the file contents and compares them, there is no cryptographic signature validation
 performed. It can be used to ensure that the file hasn't been corrupted in transit but doesn't say anything about
 the authenticity or origin of the file.

### <a id="properties-detectionsize"/>**DetectionSize**

The size value (in bytes) used in product detection. This can differ from [UpdateRelease.DownloadSize](./nefarius.vicius.abstractions.models.updaterelease.md#downloadsize).

```csharp
public Nullable<Int64> DetectionSize { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-detectionversion"/>**DetectionVersion**

The version used in product detection. This can differ from [UpdateRelease.Version](./nefarius.vicius.abstractions.models.updaterelease.md#version).

```csharp
public Version DetectionVersion { get; set; }
```

#### Property Value

[Version](https://docs.microsoft.com/en-us/dotnet/api/system.version)<br>

### <a id="properties-disabled"/>**Disabled**

Skips/disables this release on the client if set.

```csharp
public Nullable<Boolean> Disabled { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-downloadsize"/>**DownloadSize**

Optional size (in bytes) of the download target. If this is not set, the UI will simply display "N/A" until the
 actual download starts.

```csharp
public Nullable<Int64> DownloadSize { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### <a id="properties-downloadurl"/>**DownloadUrl**

The URL to the new product setup. Redirects are supported.

```csharp
public string DownloadUrl { get; set; }
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

**Remarks:**

You can use [UpdateConfig.ExitCode](./nefarius.vicius.abstractions.models.updateconfig.md#exitcode) instead to apply to all releases.

### <a id="properties-launcharguments"/>**LaunchArguments**

Optional arguments to pass to the setup process.

```csharp
public string LaunchArguments { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-name"/>**Name**

Simple display name of the release.

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-publishedat"/>**PublishedAt**

The release publish timestamp.

```csharp
public DateTimeOffset PublishedAt { get; set; }
```

#### Property Value

[DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/system.datetimeoffset)<br>

**Remarks:**

Releases are sorted on the client by descending [UpdateRelease.Version](./nefarius.vicius.abstractions.models.updaterelease.md#version), even if the publish date doesn't match the
 order of the release.

### <a id="properties-summary"/>**Summary**

Summary/changelog/description of the release. Supports Markdown syntax.

```csharp
public string Summary { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### <a id="properties-version"/>**Version**

Semantic version of the release.

```csharp
public Version Version { get; set; }
```

#### Property Value

[Version](https://docs.microsoft.com/en-us/dotnet/api/system.version)<br>

## Constructors

### <a id="constructors-.ctor"/>**UpdateRelease()**

#### Caution

Constructors of types with required members are not supported in this version of your compiler.

---

```csharp
public UpdateRelease()
```
