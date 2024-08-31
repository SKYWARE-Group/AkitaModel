using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Lis.AkitaModel;
using Spectre.Console;

namespace AkitaModelDemo.RunUnits;

public class Core
{

    public static async Task RunPublic(IAkitaApi akitaService)
    {

        int failures = 0;

        ApiRunner.PrintHeaderLines("Akita Core: Public functions");

        // Species
        IEnumerable<Species>? species = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => species = await akitaService.GetAllSpecies(),
            $"{nameof(Core)}->{nameof(akitaService.GetAllSpecies)}",
            [
                () => ApiRunner.PrintInfo("Species count", species?.Count()),
                () => ApiRunner.PrintInfo("Name of first species", species?.FirstOrDefault()?.Name)
            ])) failures++;

        // Sample types
        IEnumerable<SampleType>? sampleTypes = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => sampleTypes = await akitaService.GetAllSampleTypes(),
            $"{nameof(Core)}->{nameof(akitaService.GetAllSampleTypes)}",
            [
                () => ApiRunner.PrintInfo("Sample types count", sampleTypes?.Count()),
                () => ApiRunner.PrintInfo("Name of first sample type", sampleTypes?.FirstOrDefault()?.Name)
            ])) failures++;

        // Location Groups
        IEnumerable<LocationGroup>? locationGroups = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => locationGroups = await akitaService.GetAllLocationGroups(),
            $"{nameof(Core)}->{nameof(akitaService.GetAllLocationGroups)}",
            [
                () => ApiRunner.PrintInfo("Locations groups count", locationGroups?.Count()),
                () => ApiRunner.PrintInfo("Name of first location group", locationGroups?.FirstOrDefault()?.Name)
            ])) failures++;

        // Locations
        IEnumerable<Location>? locations = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => locations = await akitaService.GetAllLocations(),
            $"{nameof(Core)}->{nameof(akitaService.GetAllLocations)}",
            [
                () => ApiRunner.PrintInfo("Locations count", locations?.Count()),
                () => ApiRunner.PrintInfo("Name of first location", locations?.FirstOrDefault()?.Name)
            ])) failures++;

        // Departments
        IEnumerable<Department>? departments = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => departments = await akitaService.GetAllDepartments(),
            $"{nameof(Core)}->{nameof(akitaService.GetAllDepartments)}",
            [
                () => ApiRunner.PrintInfo("Departments count", departments?.Count()),
                () => ApiRunner.PrintInfo("Name of first department", departments?.FirstOrDefault()?.Name)
            ])) failures++;

        // Tests
        IEnumerable<Test>? tests = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => tests = await akitaService.GetAllTests(),
            $"{nameof(Core)}->{nameof(akitaService.GetAllTests)}",
            [
                () => ApiRunner.PrintInfo("Tests count", tests?.Count()),
                () => ApiRunner.PrintInfo("Name of first test", tests?.FirstOrDefault()?.Name)
            ])) failures++;

        // Single Test
        Test? test = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => test = await akitaService.GetSingleTest(tests?.FirstOrDefault()?.Id ?? InternalConstants.CORE_SINGLE_TEST_ID),
            $"{nameof(Core)}->{nameof(akitaService.GetSingleTest)}",
            [
                () => ApiRunner.PrintInfo("Test Id", test?.Id),
                () => ApiRunner.PrintInfo("Test name", test?.Name)
            ])) failures++;

        // Profiles
        IEnumerable<Skyware.Lis.AkitaModel.Profile>? profiles = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => profiles = await akitaService.GetAllProfiles(),
            $"{nameof(Core)}->{nameof(akitaService.GetAllProfiles)}",
            [
                () => ApiRunner.PrintInfo("Profiles count", profiles?.Count()),
                () => ApiRunner.PrintInfo("Name of first profile", profiles?.FirstOrDefault()?.Name)
            ])) failures++;

        // Single Profile
        Skyware.Lis.AkitaModel.Profile? profile = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => profile = await akitaService.GetSingleProfile(profiles?.FirstOrDefault()?.Id ?? InternalConstants.CORE_SINGLE_PROFILE_ID),
            $"{nameof(Core)}->{nameof(akitaService.GetSingleProfile)}",
            [
                () => ApiRunner.PrintInfo("Profile Id", profile?.Id),
                () => ApiRunner.PrintInfo("Profile name", profile?.Name)
            ])) failures++;


        // PID Types
        IEnumerable<PIDType>? pidTypes = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => pidTypes = await akitaService.GetAllPIDTypes(),
            $"{nameof(Core)}->{nameof(akitaService.GetAllPIDTypes)}",
            [
                () => ApiRunner.PrintInfo("PID types count", pidTypes?.Count()),
                () => ApiRunner.PrintInfo("Name of first PID type", pidTypes?.FirstOrDefault()?.Name)
            ])) failures++;

        // Footnotes
        // TODO: Add Footnote in model
        // TODO: API Returns Only an object with int sequence number

        // CultureInfo
        CultureInfo? culture = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => culture = await akitaService.GetCultureInfo(),
            $"{nameof(Core)}->{nameof(akitaService.GetCultureInfo)}",
            [
                () => ApiRunner.PrintInfo("CultureInfo Id", culture?.Id),
                () => ApiRunner.PrintInfo("CultureInfo currency symbol", culture?.CurrencySymbol)
            ])) failures++;

        // Pricelist
        IEnumerable<Product>? products = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => products = await akitaService.GetDefaultPricelist(),
            $"{nameof(Core)}->{nameof(akitaService.GetDefaultPricelist)}",
            [
                () => ApiRunner.PrintInfo("Products count", products?.Count()),
                () => ApiRunner.PrintInfo("Name of first product", products?.FirstOrDefault()?.Name)
            ])) failures++;

        ApiRunner.PrintFooterLines(failures);

    }

    public static async Task RunSales(IAkitaApi akitaService, AkitaSettings settings)
    {
        int failures = 0;

        ApiRunner.PrintHeaderLines("Akita Core: Sales functions");

        // Get all schemas
        IEnumerable<Schema>? schemas = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => schemas = await akitaService.GetAllSchemas(settings.ApiKey),
            $"{nameof(Core)}->{nameof(akitaService.GetAllSchemas)}",
            [
                () => ApiRunner.PrintInfo("Schemas count", schemas?.Count()),
                () => ApiRunner.PrintInfo("Name of first schema", schemas?.FirstOrDefault()?.Name)
            ])) failures++;

        // Get single schema
        Schema? schema = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => schema = await akitaService.GetSingleSchema(schemas?.FirstOrDefault()?.Id ?? 1, settings.ApiKey),
            $"{nameof(Core)}->{nameof(akitaService.GetSingleSchema)}",
            [
                () => ApiRunner.PrintInfo("Schema id", schema?.Id),
                () => ApiRunner.PrintInfo("Schema name", schema?.Name),
                () => ApiRunner.PrintInfo("Schema products", schema?.Items?.Count() ?? 0)
            ])) failures++;

        // Register Sale (Native Bulgarian)
        Sale? visitBulgarian = DataFactory.GetBulgarianCitizenVisit(schemas?.FirstOrDefault()?.Id ?? 1, schema?.Items?.Where(x => !string.IsNullOrWhiteSpace(x.LoincCode)).Take(3).Select(x => x.LoincCode) ?? []);
        if (!await ApiRunner.InvokeApiFunction(
            async () => visitBulgarian = await akitaService.CreateSale(visitBulgarian, settings.ApiKey),
            $"{nameof(Core)}->{nameof(akitaService.CreateSale)}",
            [
                () => ApiRunner.PrintInfo("Visit Id (Native Bulgarian)", visitBulgarian?.Id)
            ])) failures++;

        // Get samples (Native Bulgarian)
        IEnumerable<Sample>? bulgarianCitizenSamples = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => bulgarianCitizenSamples = await akitaService.GetSamples(visitBulgarian?.Id ?? 0, settings.ApiKey),
            $"{nameof(Core)}->{nameof(akitaService.GetSamples)}",
            [
                () => ApiRunner.PrintInfo("Native Bulgarian sample count", bulgarianCitizenSamples?.Count()),
                () => ApiRunner.PrintInfo("Native Bulgarian first sample", bulgarianCitizenSamples?.FirstOrDefault()?.Barcode)
            ])) failures++;

        // Register Sale (John Doe)
        Sale? visitJohnDoe = DataFactory.GetJohnDoeVisit(schemas?.FirstOrDefault()?.Id ?? 1, schema?.Items?.Where(x => !string.IsNullOrWhiteSpace(x.LoincCode)).Take(5).Select(x => x.LoincCode) ?? []);
        if (!await ApiRunner.InvokeApiFunction(
            async () => visitJohnDoe = await akitaService.CreateSale(visitJohnDoe, settings.ApiKey),
            $"{nameof(Core)}->{nameof(akitaService.CreateSale)}",
            [
                () => ApiRunner.PrintInfo("Visit Id (John Doe)", visitJohnDoe?.Id)
            ])) failures++;

        // Update Sale (John Doe -> Jane Doe)
        if (visitJohnDoe is null) throw new Exception();
        visitJohnDoe.Items.RemoveAt(3);
        visitJohnDoe.Items.RemoveAt(2);
        visitJohnDoe.Patient = DataFactory.GetJaneDoe();
        visitJohnDoe.IsStat = false;
        Sale? visitJaneDoe = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => visitJaneDoe = await akitaService.UpadteSale(visitJohnDoe.Id ?? -1, visitJohnDoe, settings.ApiKey),
            $"{nameof(Core)}->{nameof(akitaService.UpadteSale)}",
            [
                () => ApiRunner.PrintInfo("Visit Id (Jane Doe)", visitJaneDoe?.Id)
            ])) failures++;


        // Register Sale (John Doe #2, no samples)
        Sale? visitJohnDoe2 = DataFactory.GetJohnDoeVisit(schemas?.FirstOrDefault()?.Id ?? 1, schema?.Items?.Where(x => !string.IsNullOrWhiteSpace(x.LoincCode)).Take(5).Select(x => x.LoincCode) ?? []);
        if (!await ApiRunner.InvokeApiFunction(
            async () => visitJohnDoe2 = await akitaService.CreateSale(visitJohnDoe2, settings.ApiKey, false),
            $"{nameof(Core)}->{nameof(akitaService.CreateSale)}",
            [
                () => { if (visitJohnDoe2 is null) throw new Exception(); },
                () => ApiRunner.PrintInfo("Visit Id (John Doe #2)", visitJohnDoe2?.Id)
            ])) failures++;


        // Set result (John Doe #2 first item)
        SaleItem? item = (visitJohnDoe2?.Items.FirstOrDefault(x => x.TestId.HasValue)) ?? throw new Exception();
        item.Result = "82.3";
        item.NumericResult = 82.3m;
        SaleItem? resultItem = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => resultItem = await akitaService.SetResult(visitJohnDoe2.Id ?? 0, item, settings.ApiKey),
            $"{nameof(Core)}->{nameof(akitaService.SetResult)}",
            [
                () => ApiRunner.PrintInfo("John Doe #2 first item's result", resultItem?.Result)
            ])) failures++;

        // Unset result (John Doe #2 first item)
        SaleItem? unsetItem = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => unsetItem = await akitaService.UnsetResult(visitJohnDoe2.Id ?? 0, item.LoincId, settings.ApiKey),
            $"{nameof(Core)}->{nameof(akitaService.UnsetResult)}",
            [
                () => ApiRunner.PrintInfo("John Doe #2 first item's result (unset)", unsetItem?.Result)
            ])) failures++;

        // Set result (John Doe #2 first item, second time)
        item.Result = "85.1";
        item.NumericResult = 85.1m;
        if (!await ApiRunner.InvokeApiFunction(
            async () => item = await akitaService.SetResult(visitJohnDoe2.Id ?? 0, item, settings.ApiKey),
            $"{nameof(Core)}->{nameof(akitaService.SetResult)}",
            [
                () => ApiRunner.PrintInfo("John Doe #2 first item's result (second set)", item?.Result)
            ])) failures++;
    }
}
