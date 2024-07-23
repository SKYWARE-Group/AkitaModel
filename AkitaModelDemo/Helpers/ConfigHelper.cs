using Microsoft.Extensions.Configuration;

namespace AkitaModelDemo.Helpers;

public class ConfigHelper
{

    public static IConfiguration BuildConfig()
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        builder.AddUserSecrets<Program>();
        return builder.Build();
    }

}
