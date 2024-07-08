using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Microsoft.Extensions.Configuration;
using Refit;
using Skyware.Arda.Model;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.BgNhis;
using Skyware.Lis.AkitaModel.Flagging;
using Skyware.Lis.AkitaModel.Robin;

Console.WriteLine("AkitaModel demo application");

IConfiguration configuration = ConfigHelper.BuildConfig();
AkitaSettings settings = configuration.GetSection(nameof(AkitaSettings)).Get<AkitaSettings>() ?? throw new ApplicationException("No configuration is found!");

IAkitaApi akitaService = RestService.For<IAkitaApi>(settings.BaseUrl);

#region Core

// Species
IEnumerable<Species> species = await akitaService.GetAllSpecies();
Console.WriteLine($"Species count: {species.Count()}");
Console.WriteLine($"First species name: {species.FirstOrDefault()?.Name}");

// Sample types
IEnumerable<SampleType> sampleTypes = await akitaService.GetAllSampleTypes();
Console.WriteLine($"Sample types count: {sampleTypes.Count()}");
Console.WriteLine($"First sample type name: {sampleTypes.FirstOrDefault()?.Name}");

// Locations
IEnumerable<Location> locations = await akitaService.GetAllLocations();
Console.WriteLine($"Locations types count: {locations.Count()}");
Console.WriteLine($"First location name: {locations.FirstOrDefault()?.Name}");

// Location Groups
IEnumerable<LocationGroup> locationGroups = await akitaService.GetAllLocationGroups();
Console.WriteLine($"LocationGroups types count: {locationGroups.Count()}");
Console.WriteLine($"First locationGroup name: {locationGroups.FirstOrDefault()?.Name}");

// Departments
IEnumerable<Department> departments = await akitaService.GetAllDepartments();
Console.WriteLine($"Departments count: {departments.Count()}");
Console.WriteLine($"First department name: {departments.FirstOrDefault()?.Name}");

// Tests
IEnumerable<Test> tests = await akitaService.GetAllTests();
Console.WriteLine($"Tests count: {tests.Count()}");
Console.WriteLine($"First test name: {tests.FirstOrDefault()?.Name}");

//// Single Test
//Test test = await akitaService.GetSingleTest(tests?.FirstOrDefault()?.Id ?? InternalConstants.CORE_SINGLE_TEST_ID);
//Console.WriteLine($"Test Id: {test?.Id}");
//Console.WriteLine($"Test name: {test?.Name}");

// Profiles
IEnumerable<Profile> profiles = await akitaService.GetAllProfiles();
Console.WriteLine($"Profiles count: {profiles.Count()}");
Console.WriteLine($"First profile name: {profiles.FirstOrDefault()?.Name}");

// Single Profile
Profile profile = await akitaService.GetSingleProfile(profiles?.FirstOrDefault()?.Id ?? InternalConstants.CORE_SINGLE_PROFILE_ID);
Console.WriteLine($"Profile Id: {profile?.Id}");
Console.WriteLine($"Profile name: {profile?.Name}");


// PID Types
IEnumerable<PIDType> pidTypes = await akitaService.GetAllPIDTypes();
Console.WriteLine($"PIDTypes count: {pidTypes.Count()}");
Console.WriteLine($"First PIDType name: {pidTypes.FirstOrDefault()?.Name}");

// Footnotes
// TODO: Add Footnote in model
// TODO: API Returns Only an object with int sequence number

// CultureInfo
CultureInfo culture = await akitaService.GetCultureInfo();
Console.WriteLine($"CultureInfo Id: {culture?.Id}");
Console.WriteLine($"CultureInfo currency: {culture?.CurrencySymbol}");

#endregion

#region BgNhis

// Get referral
Referral? referral = await akitaService.GetReferral(DataFactory.NRN, settings.ApiKey);
Console.WriteLine($"#BGNHIS Referral number: {referral?.Nrn}");

// Search referrals
IEnumerable<Referral> referrals = await akitaService.SearchReferrals(DataFactory.PID, settings.ApiKey);
Console.WriteLine($"#BGNHIS Referrals count: {referrals.Count()}");
Console.WriteLine($"#BGNHIS First Referral number: {referrals.FirstOrDefault()?.Nrn}");

// Contracts
IEnumerable<NhifContract> contracts = await akitaService.GetContracts(settings.ApiKey);
Console.WriteLine($"#BGNHIS NhifContracts count: {contracts.Count()}");
Console.WriteLine($"#BGNHIS First NhifContract doctor uin: {contracts.FirstOrDefault()?.Doctor.Uin}");

#endregion

#region Robin

// Reports
IEnumerable<DirectReport> reports = await akitaService.GetAllReports();
Console.WriteLine($"Reports count: {reports.Count()}");
Console.WriteLine($"First report Id: {reports.FirstOrDefault()?.Id}");

// Hello world
HttpResponseMessage responseHello = await akitaService.GetSimpleReport(Constants.ROBIN_REPORTS_HELLO_WORLD, string.Empty);
await BinaryHelper.SaveAsTempAndOpen(responseHello);

// Lab referral
ReportRequest requestRefrral = new(DataFactory.GetDemoReferral());
HttpResponseMessage responseReferral = await akitaService.GetFullReport(Constants.ROBIN_REPORTS_BG_LAB_REFERRAL, requestRefrral);
await BinaryHelper.SaveAsTempAndOpen(responseReferral);

#endregion

#region LIS Flagging

// Tests
IEnumerable<Test> flaggingTests = await akitaService.GetAllTests(settings.ApiKey);
Console.WriteLine($"#FLAGGING Tests count: {flaggingTests.Count()}");
Console.WriteLine($"#FLAGGING First test name: {flaggingTests.FirstOrDefault()?.Name}");

// Flag Results
IEnumerable<ResultRequest> resultRequest = DataFactory.GetDemoFlaggingTestResultRequest();
IEnumerable<ResultResponse> resultResponses = await akitaService.GetTestResult(resultRequest, settings.ApiKey);
foreach (ResultResponse response in resultResponses)
    Console.WriteLine($"#FLAGGING Test result: RefId: '{response.RefId}' Result: '{response.CalculationResult?.FlagLevel}'");

// Single Test
Test flaggingTest = await akitaService.GetSingleTest(tests?.FirstOrDefault()?.Id ?? InternalConstants.CORE_SINGLE_TEST_ID, settings.ApiKey);
Console.WriteLine($"#FLAGGING Test Id: {flaggingTest?.Id}");
Console.WriteLine($"#FLAGGING Test name: {flaggingTest?.Name}");


#endregion