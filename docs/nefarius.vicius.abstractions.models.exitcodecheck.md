# ExitCodeCheck

Namespace: Nefarius.Vicius.Abstractions.Models

Setup exit code parameters.

```csharp
public sealed class ExitCodeCheck
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ExitCodeCheck](./nefarius.vicius.abstractions.models.exitcodecheck.md)

## Properties

### <a id="properties-skipcheck"/>**SkipCheck**

Ignore whatever exit code we got if true.

```csharp
public bool SkipCheck { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-successcodes"/>**SuccessCodes**

One or more exit codes that signify success.

```csharp
public List<Int32> SuccessCodes { get; }
```

#### Property Value

[List&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

## Constructors

### <a id="constructors-.ctor"/>**ExitCodeCheck()**

```csharp
public ExitCodeCheck()
```
