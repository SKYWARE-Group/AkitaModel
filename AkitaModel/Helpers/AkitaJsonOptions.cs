using System.Text.Json;
using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel.Helpers;

/// <summary>
/// Standard JSON options for Akita.
/// </summary>
public class AkitaJsonOptions
{

    private static JsonSerializerOptions _Options;

    /// <summary>
    /// JSON options for Akita.
    /// </summary>
    public static JsonSerializerOptions Options => _Options ??= new()
    {
        WriteIndented = true, //TODO: Remove in production
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        ReferenceHandler = ReferenceHandler.IgnoreCycles,
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
    };

}
