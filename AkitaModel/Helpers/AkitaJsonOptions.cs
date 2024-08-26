using System.Text.Json;
using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel.Helpers;

public class AkitaJsonOptions
{

    private static JsonSerializerOptions _Options;

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
