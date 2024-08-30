using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.Flagging;

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

        // Single numeric test for male patient, gender ranged numeric test with result 10% higher than upper limit of the reference range
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

        // Multiple numeric tests, gender ranged
        IEnumerable<ResultResponse>? numericResultResponse2 = null;
        ResultRequest[] resultRequest2 = GetMultipleNumericTestsRequest(flaggingTests!);
        if (!await ApiRunner.InvokeApiFunction(
            async () => numericResultResponse2 = await akitaService.GetTestResult(resultRequest2, settings.ApiKey),
            $"{nameof(Flagging)}->{nameof(akitaService.GetTestResult)}",
            [
                () => ApiRunner.PrintInfo("Flagging test #1", flaggingTests?.FirstOrDefault(t => t.Id == resultRequest2?.FirstOrDefault()?.TestId)?.Name),
                () => ApiRunner.PrintInfo("Original decimal result #1", resultRequest2[0].NumericResult),
                () => ApiRunner.PrintInfo("Calculated decimal result #1", numericResultResponse2?.FirstOrDefault()?.CalculationResult?.DecimalResult),
                () => ApiRunner.PrintInfo("Calculated flag level #1", numericResultResponse2?.FirstOrDefault()?.CalculationResult?.FlagLevel),
                () => ApiRunner.PrintInfo("Flagging test #2", flaggingTests?.LastOrDefault(t => t.Id == resultRequest2?.LastOrDefault()?.TestId)?.Name),
                () => ApiRunner.PrintInfo("Original decimal result #2", resultRequest2[1].NumericResult),
                () => ApiRunner.PrintInfo("Calculated decimal result #2", numericResultResponse2?.LastOrDefault()?.CalculationResult?.DecimalResult),
                () => ApiRunner.PrintInfo("Calculated flag level #2", numericResultResponse2?.LastOrDefault()?.CalculationResult?.FlagLevel)
            ])) failures++;

        ApiRunner.PrintFooterLines(failures);
    }

    private static ResultRequest GetSingleNumericTestRequest(IEnumerable<Test> tests)
    {
        (Test targetTest, ReferenceRange targetRange) = GetRange(
            tests,
            (t) => t.ResultType == ResultTypes.Quantitative,
            (r) => r.SpeciesId == 1 && r.IsRangedByGender && r.MHighValue is not null);
        return GetNumericTestRequest(targetTest.Id, $"S{Utilities.GetRandomString()}", targetRange, true, FlagLevels.HIGH, 1.1m);
    }

    private static ResultRequest[] GetMultipleNumericTestsRequest(IEnumerable<Test> tests)
    {
        // Male, scale >=1, age > 16y, high limit
        (Test targetTestM, ReferenceRange targetRangeM) = GetRange(
            tests,
            (t) => t.ResultType == ResultTypes.Quantitative && t.Scale >= 1,
            (r) => r.SpeciesId == 1 && r.IsRangedByGender && r.MHighValue is not null && r.AgeFrom > 16 * 365);
        // Female, alarm 1 limit
        (Test targetTestF, ReferenceRange targetRangeF) = GetRange(
            tests,
            (t) => t.ResultType == ResultTypes.Quantitative && t.Scale >= 1 && t.FlagLimit >= FlagLevelLimits.UP_TO_VERY,
            (r) => r.SpeciesId == 1 && r.IsRangedByGender && r.FHighAlarm1 is not null);
        return [
            GetNumericTestRequest(targetTestM.Id, $"S{Utilities.GetRandomString()}", targetRangeM, true, FlagLevels.HIGH, 1.1m),
            GetNumericTestRequest(targetTestF.Id, $"S{Utilities.GetRandomString()}", targetRangeF, false, FlagLevels.VERY_HIGH, 1.1m),
        ];
    }

    private static ResultRequest GetNumericTestRequest(int testId, string reference, ReferenceRange range, bool? isMale, FlagLevels level, decimal coeficient) => new()
    {
        TestId = testId,
        SpeciesId = range.SpeciesId,
        RefId = reference,
        DateOfBirth = DateTime.Now.AddDays(range.AgeFrom * -1).AddDays(-2),
        IsMale = isMale,
        NumericResult = SelectLimit(range, isMale, level) * coeficient ?? throw new Exception("Cant' select proper range limit."),
    };

    private static (Test targetTest, ReferenceRange targetRange) GetRange(IEnumerable<Test> tests, Func<Test, bool> testFilter, Func<ReferenceRange, bool> rangeFilter)
    {
        ReferenceRange referenceRange = tests
            .OrderBy(t => t.Rank)
            .Where(t => testFilter(t))
            .SelectMany(t => t.Ranges.OrderBy(r => r.AgeFrom))?
            .FirstOrDefault(r => rangeFilter(r)) ?? throw new Exception("Can't find suitable test.");

        Test test = tests.FirstOrDefault(x => x.Ranges?.Any(r => object.ReferenceEquals(r, referenceRange)) ?? false) ?? throw new Exception("Can't find suitable test.");
        return (test, referenceRange);
    }

    private static decimal? SelectLimit(ReferenceRange range, bool? isMale, FlagLevels level) =>
        isMale switch
        {
            true => level switch
            {
                FlagLevels.ULTRA_LOW => range.MLowAlarm2,
                FlagLevels.VERY_LOW => range.MLowAlarm1,
                FlagLevels.LOW => range.MLowValue,
                FlagLevels.HIGH => range.MHighValue,
                FlagLevels.VERY_HIGH => range.MHighAlarm1,
                FlagLevels.ULTRA_HIGH => range.MHighAlarm2,
                _ => null
            },
            false => level switch
            {
                FlagLevels.ULTRA_LOW => range.FLowAlarm2,
                FlagLevels.VERY_LOW => range.FLowAlarm1,
                FlagLevels.LOW => range.FLowValue,
                FlagLevels.HIGH => range.FHighValue,
                FlagLevels.VERY_HIGH => range.FHighAlarm1,
                FlagLevels.ULTRA_HIGH => range.FHighAlarm2,
                _ => null
            },
            _ => level switch
            {
                FlagLevels.ULTRA_LOW => range.LowAlarm2,
                FlagLevels.VERY_LOW => range.LowAlarm1,
                FlagLevels.LOW => range.LowValue,
                FlagLevels.HIGH => range.HighValue,
                FlagLevels.VERY_HIGH => range.HighAlarm1,
                FlagLevels.ULTRA_HIGH => range.HighAlarm2,
                _ => null
            },
        };

}
