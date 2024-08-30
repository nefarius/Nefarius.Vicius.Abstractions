using Nefarius.Vicius.Abstractions.Models;

using Newtonsoft.Json;

namespace Nefarius.Vicius.Abstractions.Converters;

/// <summary>
///     Converts a <see cref="FixedVersionConfig"/> instance to and from JSON.
/// </summary>
public sealed class FixedProductVersionConverter : JsonConverter<FixedVersionConfig>
{
    /// <inheritdoc />
    public override void WriteJson(JsonWriter writer, FixedVersionConfig? value, JsonSerializer serializer)
    {
        writer.WriteValue(value?.ToString());
    }

    /// <inheritdoc />
    public override FixedVersionConfig? ReadJson(JsonReader reader, Type objectType, FixedVersionConfig? existingValue,
        bool hasExistingValue, JsonSerializer serializer)
    {
        string? version = reader.ReadAsString();

        return version is null ? null : new FixedVersionConfig { Version = version };
    }
}