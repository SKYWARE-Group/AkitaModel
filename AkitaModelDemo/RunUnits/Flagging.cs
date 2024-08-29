using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.Flagging;
using Spectre.Console;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace AkitaModelDemo.RunUnits;

public class Flagging
{
    public static async Task Run(IAkitaApi akitaService, AkitaSettings settings)
    {

        int failures = 0;

        ApiRunner.PrintHeaderLines("Akita Flagging");

        // All tests
        IEnumerable<Test>? flaggingTests = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => flaggingTests = await akitaService.GetAllTests(settings.ApiKey),
            $"{nameof(Flagging)}->{nameof(akitaService.GetAllTests)}",
            [
                () => ApiRunner.PrintInfo("Tests count", flaggingTests?.Count()),
                () => ApiRunner.PrintInfo("Name of first test", flaggingTests?.FirstOrDefault()?.Name)
            ])) failures++;

        // Single test
        Test? test = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => test = await akitaService.GetSingleTest(flaggingTests?.FirstOrDefault()?.Id ?? 1, settings.ApiKey),
            $"{nameof(Flagging)}->{nameof(akitaService.GetSingleTest)}",
            [
                () => ApiRunner.PrintInfo("Test Id", test?.Id),
                () => ApiRunner.PrintInfo("Test name", test?.Name)
            ])) failures++;

        // Single numeric test for male patient, gander ranged numeric test with result 10% higher than upper limit of the reference range
        IEnumerable<ResultResponse>? numericResultResponse = null;
        ResultRequest resultRequest = GetSingleNumericTestRequest(flaggingTests!);
        if (!await ApiRunner.InvokeApiFunction(
            async () => numericResultResponse = await akitaService.GetTestResult([resultRequest], settings.ApiKey),
            $"{nameof(Flagging)}->{nameof(akitaService.GetTestResult)}",
            [
                () => ApiRunner.PrintInfo("Flagging test", flaggingTests?.FirstOrDefault(t => t.Id == resultRequest?.TestId)?.Name),
                () => ApiRunner.PrintInfo("Original decimal result", resultRequest.NumericResult),
                () => ApiRunner.PrintInfo("Calculated decimal result", numericResultResponse?.FirstOrDefault()?.CalculationResult?.DecimalResult),
                () => ApiRunner.PrintInfo("Calculated flag level", numericResultResponse?.FirstOrDefault()?.CalculationResult?.FlagLevel)
            ])) failures++;

        ApiRunner.PrintFooterLines(failures);
    }


    private static ResultRequest GetSingleNumericTestRequest(IEnumerable<Test> tests)
    {

        Test? targetTest = tests.FirstOrDefault(x => x.Ranges?.Any(r => r.MHighValue is not null && r.IsRangedByGender && r.SpeciesId == 1) ?? false);
        ReferenceRange? referenceRange = targetTest?.Ranges?.FirstOrDefault(r => r.MHighValue is not null && r.IsRangedByGender && r.SpeciesId == 1);

        if (targetTest is null || referenceRange is null) throw new Exception("Can't find suitable test for testing flagging.");

        return new ()
        {
            TestId = targetTest.Id,
            SpeciesId = referenceRange.SpeciesId,
            RefId = "S7ENF",
            DateOfBirth = DateTime.Now.AddDays(referenceRange.AgeFrom * -1).AddDays(1),
            IsMale = true,
            NumericResult = referenceRange.MHighValue!.Value + referenceRange.MHighValue!.Value * 0.1m, // 10% higher than upper male limit
        };
    }


}
