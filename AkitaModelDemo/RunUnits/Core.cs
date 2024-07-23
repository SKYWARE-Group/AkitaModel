using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Lis.AkitaModel;

namespace AkitaModelDemo.RunUnits;

public class Core
{

    public static async Task RunPublic(IAkitaApi akitaService)
    {

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

        // Single Test
        Test test = await akitaService.GetSingleTest(tests?.FirstOrDefault()?.Id ?? InternalConstants.CORE_SINGLE_TEST_ID);
        Console.WriteLine($"Test Id: {test?.Id}");
        Console.WriteLine($"Test name: {test?.Name}");

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

        // Pricelist
        IEnumerable<Product> products = await akitaService.GetDefaultPricelist();
        Console.WriteLine($"Products count: {products.Count()}");
        Console.WriteLine($"First product name: {products.FirstOrDefault()?.Name}");

    }

    public static async Task RunSales(IAkitaApi akitaService, AkitaSettings settings)
    {

        // Get all schemas
        IEnumerable<Schema> schemas = await akitaService.GetAllSchemas(settings.ApiKey);
        Console.WriteLine($"Schemas count: {schemas.Count()}");
        Console.WriteLine($"First schema name: {schemas.FirstOrDefault()?.Name}");

        // Get single schema
        Schema schema = await akitaService.GetSingleSchema(schemas?.FirstOrDefault()?.Id ?? 1, settings.ApiKey);
        Console.WriteLine($"Schema Id: {schema?.Id}");
        Console.WriteLine($"Schema name: {schema?.Name}");
        Console.WriteLine($"Schema products: {schema?.Items?.Count() ?? 0}");

        // Register Sale (Native Bulgarian)
        Sale visitBulgarian = DataFactory.GetBulgarianCitizenVisit(schemas?.FirstOrDefault()?.Id ?? 1, schema?.Items?.Where(x => !string.IsNullOrWhiteSpace(x.LoincCode)).Take(3).Select(x => x.LoincCode) ?? []);
        visitBulgarian = await akitaService.CreateSale(visitBulgarian, settings.ApiKey);
        if (visitBulgarian is null) throw new Exception();
        Console.WriteLine($"Visit Id (Native Bulgarian): {visitBulgarian?.Id}");

        // Get samples (Native Bulgarian)
        IEnumerable<Sample> bulgarianCitizenSamples = await akitaService.GetSamples(visitBulgarian?.Id ?? 0, settings.ApiKey);
        Console.WriteLine($"Native Bulgarian sample count: {bulgarianCitizenSamples.Count()}");
        Console.WriteLine($"Native Bulgarian first sample: {bulgarianCitizenSamples.FirstOrDefault()?.Barcode}");

        // Register Sale (John Doe)
        Sale visitJohnDoe = DataFactory.GetJohnDoeVisit(schemas?.FirstOrDefault()?.Id ?? 1, schema?.Items?.Where(x => !string.IsNullOrWhiteSpace(x.LoincCode)).Take(5).Select(x => x.LoincCode) ?? []);
        visitJohnDoe = await akitaService.CreateSale(visitJohnDoe, settings.ApiKey);
        Console.WriteLine($"Visit Id (John Doe): {visitJohnDoe?.Id}");

        // Update Sale (John Doe -> Jane Doe)
        if (visitJohnDoe is null) throw new Exception();
        visitJohnDoe.Items.RemoveAt(3);
        visitJohnDoe.Items.RemoveAt(2);
        visitJohnDoe.Patient = DataFactory.GetJaneDoe();
        visitJohnDoe.IsStat = false;
        Sale visitJaneDoe = await akitaService.UpadteSale(visitJohnDoe.Id ?? -1, visitJohnDoe, settings.ApiKey);
        Console.WriteLine($"Visit Id (Jane Doe): {visitJohnDoe?.Id}");

        // Register Sale (John Doe #2, no samples)
        Sale visitJohnDoe2 = DataFactory.GetJohnDoeVisit(schemas?.FirstOrDefault()?.Id ?? 1, schema?.Items?.Where(x => !string.IsNullOrWhiteSpace(x.LoincCode)).Take(5).Select(x => x.LoincCode) ?? []);
        visitJohnDoe2 = await akitaService.CreateSale(visitJohnDoe2, settings.ApiKey, false);
        Console.WriteLine($"Visit Id (John Doe): {visitJohnDoe2?.Id}");
        if (visitJohnDoe2 is null) throw new Exception();
        Console.WriteLine($"Visit Id (John Doe #2): {visitJohnDoe2.Id}");

        // Set result (John Doe #2 first item)
        SaleItem item = (visitJohnDoe2?.Items.FirstOrDefault(x => x.TestId.HasValue)) ?? throw new Exception();
        item.Result = "82.3";
        item.NumericResult = 82.3m;
        SaleItem resultItem = await akitaService.SetResult(visitJohnDoe2.Id ?? 0, item, settings.ApiKey);
        Console.WriteLine($"John Doe #2 first item's result: {resultItem.Result}");

        // Unset result (John Doe #2 first item)
        SaleItem unsetItem = await akitaService.UnsetResult(visitJohnDoe2.Id ?? 0, item.LoincId, settings.ApiKey);
        Console.WriteLine($"John Doe #2 first item's result (unset): {unsetItem.Result}");

        // Set result (John Doe #2 first item, second time)
        item.Result = "85.1";
        item.NumericResult = 85.1m;
        item = await akitaService.SetResult(visitJohnDoe2.Id ?? 0, item, settings.ApiKey);
        Console.WriteLine($"John Doe #2 first item's result (second set): {item.Result}");

    }

}
