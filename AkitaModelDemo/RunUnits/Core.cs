using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Lis.AkitaModel;
using static System.Net.Mime.MediaTypeNames;

namespace AkitaModelDemo.RunUnits;

public class Core
{

    public static async Task Run(IAkitaApi akitaService)
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

    public static async Task RunSchemas(IAkitaApi akitaService, AkitaSettings settings)
    {

        // All schemas
        IEnumerable<Schema> schemas = await akitaService.GetAllSchemas(settings.ApiKey);
        Console.WriteLine($"Schemas count: {schemas.Count()}");
        Console.WriteLine($"First schema name: {schemas.FirstOrDefault()?.Name}");

        // Single schema
        Schema schema = await akitaService.GetSingleSchema(schemas?.FirstOrDefault()?.Id ?? 1, settings.ApiKey);
        Console.WriteLine($"Schema Id: {schema?.Id}");
        Console.WriteLine($"Schema name: {schema?.Name}");
        Console.WriteLine($"Schema products: {schema?.Items?.Count() ?? 0}");

    }

}
