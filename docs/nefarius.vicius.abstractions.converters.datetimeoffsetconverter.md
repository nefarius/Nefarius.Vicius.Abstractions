# DateTimeOffsetConverter

Namespace: Nefarius.Vicius.Abstractions.Converters

[DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/system.datetimeoffset) to ISO 8601 (or custom formats) string (UTC) converter.

```csharp
public sealed class DateTimeOffsetConverter : System.Text.Json.Serialization.JsonConverter`1[[System.DateTimeOffset, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → JsonConverter → JsonConverter&lt;DateTimeOffset&gt; → [DateTimeOffsetConverter](./nefarius.vicius.abstractions.converters.datetimeoffsetconverter.md)

## Properties

### <a id="properties-handlenull"/>**HandleNull**

```csharp
public bool HandleNull { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### <a id="properties-type"/>**Type**

```csharp
public Type Type { get; }
```

#### Property Value

[Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

## Constructors

### <a id="constructors-.ctor"/>**DateTimeOffsetConverter(String)**

```csharp
public DateTimeOffsetConverter(string format)
```

#### Parameters

`format` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Methods

### <a id="methods-read"/>**Read(ref Utf8JsonReader, Type, JsonSerializerOptions)**

```csharp
public DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
```

#### Parameters

`reader` Utf8JsonReader&<br>

`typeToConvert` [Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

`options` JsonSerializerOptions<br>

#### Returns

[DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/system.datetimeoffset)

### <a id="methods-write"/>**Write(Utf8JsonWriter, DateTimeOffset, JsonSerializerOptions)**

```csharp
public void Write(Utf8JsonWriter writer, DateTimeOffset date, JsonSerializerOptions options)
```

#### Parameters

`writer` Utf8JsonWriter<br>

`date` [DateTimeOffset](https://docs.microsoft.com/en-us/dotnet/api/system.datetimeoffset)<br>

`options` JsonSerializerOptions<br>
