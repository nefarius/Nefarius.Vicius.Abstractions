﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace Nefarius.Vicius.Abstractions.Converters;

/// <summary>
///     <see cref="DateTimeOffset" /> to ISO 8601 (or custom formats) string (UTC) converter.
/// </summary>
public sealed class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{
    private readonly string _format;

    /// <inheritdoc />
    public DateTimeOffsetConverter(string format = "yyyy-MM-ddThh:mm:ssZ")
    {
        _format = format;
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, DateTimeOffset date, JsonSerializerOptions options)
    {
        writer.WriteStringValue(date.ToString(_format));
    }

    /// <inheritdoc />
    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return DateTime.ParseExact(reader.GetString(), _format, null);
    }
}