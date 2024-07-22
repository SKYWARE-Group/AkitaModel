using System.Text.Json;
using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel.Helpers;

/// <summary>
/// JSON settings
/// </summary>
public class JsonSettings
{

    /// <summary>
    /// Set JSON options
    /// </summary>
    /// <param name="opts"></param>
    public static JsonSerializerOptions GetJsonOptions()
    {
        return new()
        {
            WriteIndented = true, //TODO: Remove in production
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
        };
    }

}
