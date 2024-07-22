using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.RunUnits;
using AkitaModelDemo.Services;
using Microsoft.Extensions.Configuration;
using Refit;

Console.WriteLine("AkitaModel demo application");

IConfiguration configuration = ConfigHelper.BuildConfig();
AkitaSettings settings = configuration.GetSection(nameof(AkitaSettings)).Get<AkitaSettings>() ?? throw new ApplicationException("No configuration is found!");

RefitSettings refitSettings = new()
{
    ContentSerializer = new SystemTextJsonContentSerializer(Skyware.Lis.AkitaModel.Helpers.JsonSettings.GetJsonOptions()),
};

IAkitaApi akitaService = RestService.For<IAkitaApi>(settings.BaseUrl, refitSettings);

// Core
await Core.Run(akitaService);
//await Core.RunSchemas(akitaService, settings);
await Core.RunSales(akitaService, settings);

// BgNhis
await BgNhis.Run(akitaService, settings);

// Robin
await Robin.Run(akitaService, settings);

// Flagging
await Flagging.Run(akitaService, settings);

