using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel.Robin.Reports.Bg;

/// <inheritdoc/>
/// <inheritdoc/>
public class CustomDateTimeConverter(string format) : JsonConverter<DateTime>
{
    private readonly string Format = format;

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, DateTime date, JsonSerializerOptions options) => writer.WriteStringValue(date.ToString(Format));

    /// <inheritdoc/>
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => DateTime.ParseExact(reader.GetString(), Format, null);

}
