using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.RunUnits;
using AkitaModelDemo.Services;
using Microsoft.Extensions.Configuration;
using Refit;

Console.WriteLine("AkitaModel demo application");
Console.WriteLine("");
Console.WriteLine("");

// Set up --------------------------
// Configuration
IConfiguration configuration = ConfigHelper.BuildConfig();
AkitaSettings settings = configuration.GetSection(nameof(AkitaSettings)).Get<AkitaSettings>() ?? throw new ApplicationException("No configuration is found!");

// REST Service
var httpClient = new HttpClient(new HttpLoggingHandler()) { BaseAddress = new(settings.BaseUrl) };
RefitSettings refitSettings = new()
{
    ContentSerializer = new SystemTextJsonContentSerializer(Skyware.Lis.AkitaModel.Helpers.AkitaJsonOptions.Options),
};
IAkitaApi akitaService = RestService.For<IAkitaApi>(httpClient, refitSettings);

// ---------------------------------
// Test invocations

// Core
//await Core.RunPublic(akitaService);
//await Core.RunSales(akitaService, settings);

// BgNhis
//await BgNhis.GetContracts(akitaService, settings);
//await BgNhis.Run(akitaService, settings);

// Robin
//await Robin.Run(akitaService, settings);

// Flagging
await Flagging.Run(akitaService, settings);

Console.WriteLine("Done.");