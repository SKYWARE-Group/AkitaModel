using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Microsoft.Extensions.Configuration;
using Refit;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.Robin;
using Skyware.Lis.AkitaModel.Robin.Reports.Bg;
using System.Diagnostics;
using System.IO;

Console.WriteLine("AkitaModel demo application");

IConfiguration configuration = ConfigHelper.BuildConfig();
AkitaSettings settings = configuration.GetSection(nameof(AkitaSettings)).Get<AkitaSettings>() ?? throw new ApplicationException("No configuration is found!");

IAkitaApi akitaService = RestService.For<IAkitaApi>(settings.BaseUrl);

#region Core

//// Species
//IEnumerable<Species> species = await akitaService.GetAllSpecies();
//Console.WriteLine($"Species count: {species.Count()}");
//Console.WriteLine($"First species name: {species.FirstOrDefault()?.Name}");

//// Sample types
//IEnumerable<SampleType> sampleTypes = await akitaService.GetAllSampleTypes();
//Console.WriteLine($"Sample types count: {sampleTypes.Count()}");
//Console.WriteLine($"First sample type name: {sampleTypes.FirstOrDefault()?.Name}");

// Locations
IEnumerable<Location> locations = await akitaService.GetAllLocations();
Console.WriteLine($"Locations types count: {locations.Count()}");
Console.WriteLine($"First location name: {locations.FirstOrDefault()?.Name}");

//// Location Groups
//// TODO: Add LocationGroup in model

//// Departments
//IEnumerable<Department> departments = await akitaService.GetAllDepartments();
//Console.WriteLine($"Departments count: {departments.Count()}");
//Console.WriteLine($"First department name: {departments.FirstOrDefault()?.Name}");

//// Tests
//IEnumerable<Test> tests = await akitaService.GetAllTests();
//Console.WriteLine($"Tests count: {tests.Count()}");
//Console.WriteLine($"First test name: {tests.FirstOrDefault()?.Name}");

//// Profiles
//// TODO: Add Profile in model

//// PID Types
//// TODO: Add PidType in model

//// Footnotes
//// TODO: Add Footnote in model

//// CultureInfo
//// TODO: Add CultureInfo in model


#endregion

#region Robin

// Reports
IEnumerable<DirectReport> reports = await akitaService.GetAllReports();
Console.WriteLine($"Reports count: {reports.Count()}");
Console.WriteLine($"First report name: {reports.FirstOrDefault()?.Id}");

// Hello world
HttpResponseMessage responseHello = await akitaService.GetSimpleReport(Constants.ROBIN_REPORTS_HELLO_WORLD, string.Empty);
await BinaryHelper.SaveAsTempAndOpen(responseHello);

// Lab referral
ReportRequest requestRefrral = new(DataFactory.GetDemoReferral());
HttpResponseMessage responseReferral = await akitaService.GetFullReport(Constants.ROBIN_REPORTS_BG_LAB_REFERRAL, requestRefrral);
await BinaryHelper.SaveAsTempAndOpen(responseReferral);

#endregion