using System.Text.Json;
using System.Text.Json.Serialization;

using Nefarius.Vicius.Abstractions.Models;

namespace Nefarius.Vicius.Abstractions.Converters;

/// <summary>
///     Converts a <see cref="FixedVersionConfig" /> instance to and from JSON.
/// </summary>
public sealed class FixedProductVersionConverter : JsonConverter<FixedVersionConfig>
{
    /// <inheritdoc />
    public override FixedVersionConfig? Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
    {
        string? version = reader.GetString();

        return version is null ? null : new FixedVersionConfig { Version = version };
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, FixedVersionConfig? value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value?.Version);
    }
}