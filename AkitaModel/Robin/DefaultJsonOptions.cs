using System.Text.Json;
using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel.Robin;

public static class DefaultJsonOptions
{

    private static JsonSerializerOptions _Options;

    public static JsonSerializerOptions Options
    {
        get
        {
            if (_Options is null)
            {
                _Options = new()
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    PropertyNameCaseInsensitive = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
            };
            return _Options;
        }
    }

}
