using System.Text.Json;
using System;

namespace Skyware.Lis.AkitaModel.Robin;

public static class Base64Helper
{

    public static string GetBase64Data(object @object) => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(JsonSerializer.Serialize(@object, DefaultJsonOptions.Options)));

}
