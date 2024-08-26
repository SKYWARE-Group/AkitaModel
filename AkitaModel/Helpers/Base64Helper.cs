using System.Text.Json;
using System;

namespace Skyware.Lis.AkitaModel.Helpers;

/// <summary>
/// JSON and Base64 encoding helper.
/// </summary>
public static class Base64Helper
{

    /// <summary>
    /// Serializes object as JSON and then return Base64 encoded string.
    /// </summary>
    /// <param name="object">Object to serialize</param>
    /// <returns>Base64 encoded string</returns>
    public static string GetBase64Data(object @object) =>
        Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(JsonSerializer.Serialize(@object, AkitaJsonOptions.Options)));

}
