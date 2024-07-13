using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.RunUnits;
using AkitaModelDemo.Services;
using Microsoft.Extensions.Configuration;
using Refit;

Console.WriteLine("AkitaModel demo application");

IConfiguration configuration = ConfigHelper.BuildConfig();
AkitaSettings settings = configuration.GetSection(nameof(AkitaSettings)).Get<AkitaSettings>() ?? throw new ApplicationException("No configuration is found!");

IAkitaApi akitaService = RestService.For<IAkitaApi>(settings.BaseUrl);

await Core.Run(akitaService);
await BgNhis.Run(akitaService, settings);
await Robin.Run(akitaService, settings);
await Flagging.Run(akitaService, settings);

