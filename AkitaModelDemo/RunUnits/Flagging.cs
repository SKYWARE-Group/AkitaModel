using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.Flagging;
using Spectre.Console;
using System.Diagnostics;

// Ignore Spelling: grey

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
            $"{nameof(Flagging)}->{nameof(akitaService.GetTestResult)} (single numeric test)",
            [
                () => ApiRunner.PrintInfo("Flagging test", flaggingTests?.FirstOrDefault(t => t.Id == resultRequest?.TestId)?.Name),
                () => ApiRunner.PrintInfo("Original decimal result", resultRequest.NumericResult),
                () => ApiRunner.PrintInfo("Calculated decimal result", numericResultResponse?.FirstOrDefault()?.CalculationResult?.DecimalResult),
                () => ApiRunner.PrintInfo("Calculated flag level", numericResultResponse?.FirstOrDefault()?.CalculationResult?.FlagLevel)
            ])) failures++;

        // Multiple numeric tests, gender ranged
        IEnumerable<ResultResponse>? numericResultResponse2 = null;
        ResultRequest[] resultRequest2 = GetMultipleNumericTestsRequest(flaggingTests!);
        long processingMs = 0;
        if (!await ApiRunner.InvokeApiFunction(
            async () =>
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                numericResultResponse2 = await akitaService.GetTestResult(resultRequest2, settings.ApiKey);
                stopwatch.Stop();
                processingMs = stopwatch.ElapsedMilliseconds;
            },
            $"{nameof(Flagging)}->{nameof(akitaService.GetTestResult)} (multiple numeric tests)",
            [
                () =>
                {
                    if (resultRequest2.Length != (numericResultResponse2?.Count() ?? 0)) throw new Exception("Answer's size has unexpected length.");
                    AnsiConsole.MarkupLineInterpolated($"  [grey]Invocation time: {processingMs}ms.[/]");
                    for (int ix = 0; ix < resultRequest2!.Length; ix++) {
                        AnsiConsole.MarkupLineInterpolated($"  [grey]--- Case {ix}[/]");
                        ApiRunner.PrintInfo($"Flagging test #{ix}", flaggingTests?.FirstOrDefault(t => t.Id == resultRequest2?[ix]?.TestId)?.Name);
                        ApiRunner.PrintInfo($"Original decimal result #{ix}", resultRequest2?[ix]?.NumericResult);
                        ApiRunner.PrintInfo($"Calculated decimal result #{ix}", numericResultResponse2?.ToArray()[ix]?.CalculationResult?.DecimalResult);
                        ApiRunner.PrintInfo($"Calculated flag level #{ix}", numericResultResponse2?.ToArray()[ix]?.CalculationResult?.FlagLevel);
                    };
                },
            ])) failures++;

        // Multiple numeric tests with multiple alarms
        IEnumerable<ResultResponse>? numericResultResponse3 = null;
        ResultRequest[] resultRequest3 = GetMultipleNumericTestRequestsWithMultipleAlarms(flaggingTests!);
        processingMs = 0;
        if (!await ApiRunner.InvokeApiFunction(
            async () =>
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                numericResultResponse3 = await akitaService.GetTestResult(resultRequest3, settings.ApiKey);
                stopwatch.Stop();
                processingMs = stopwatch.ElapsedMilliseconds;
            },
            $"{nameof(Flagging)}->{nameof(akitaService.GetTestResult)} (multiple numeric tests with multiple alarms)",
            [
                () =>
                {
                    if (resultRequest3.Length != (numericResultResponse3?.Count() ?? 0)) throw new Exception("Answer's size has unexpected length.");
                    AnsiConsole.MarkupLineInterpolated($"  [grey]Invocation time: {processingMs}ms.[/]");
                    for (int ix = 0; ix < resultRequest3!.Length; ix++) {
                        AnsiConsole.MarkupLineInterpolated($"  [grey]--- Case {ix}[/]");
                        ApiRunner.PrintInfo($"Flagging test #{ix}", flaggingTests?.FirstOrDefault(t => t.Id == resultRequest3?[ix]?.TestId)?.Name);
                        ApiRunner.PrintInfo($"Original decimal result #{ix}", resultRequest3?[ix]?.NumericResult);
                        ApiRunner.PrintInfo($"Calculated decimal result #{ix}", numericResultResponse3?.ToArray()[ix]?.CalculationResult?.DecimalResult);
                        ApiRunner.PrintInfo($"Calculated flag level #{ix}", numericResultResponse3?.ToArray()[ix]?.CalculationResult?.FlagLevel);
                        ApiRunner.PrintInfo($"Calculated flag symbol", GetFlagSymbol(numericResultResponse3?.ToArray()[ix]?.CalculationResult?.FlagLevel,
                                                                                     flaggingTests?.FirstOrDefault(t => t.Id == resultRequest3?[ix]?.TestId)));
                    };
                },
            ])) failures++;

        // Multiple semiquantitative tests
        IEnumerable<ResultResponse>? semiQuantitativeResultResponse = null;
        ResultRequest[] resultsemiQuantitativeRequest = GetMultipleSemiQuantitativeTestRequests(flaggingTests!);
        processingMs = 0;
        if (!await ApiRunner.InvokeApiFunction(
            async () =>
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                semiQuantitativeResultResponse = await akitaService.GetTestResult(resultsemiQuantitativeRequest, settings.ApiKey);
                stopwatch.Stop();
                processingMs = stopwatch.ElapsedMilliseconds;
            },
            $"{nameof(Flagging)}->{nameof(akitaService.GetTestResult)} (multiple semi quantitative tests)",
            [
                () =>
                {
                    if (resultsemiQuantitativeRequest.Length != (semiQuantitativeResultResponse?.Count() ?? 0)) throw new Exception("Answer's size has unexpected length.");
                    AnsiConsole.MarkupLineInterpolated($"  [grey]Invocation time: {processingMs}ms.[/]");
                    for (int ix = 0; ix < resultsemiQuantitativeRequest!.Length; ix++) {
                        AnsiConsole.MarkupLineInterpolated($"  [grey]--- Case {ix}[/]");
                        ApiRunner.PrintInfo($"Flagging test #{ix}", flaggingTests?.FirstOrDefault(t => t.Id == resultsemiQuantitativeRequest?[ix]?.TestId)?.Name);
                        ApiRunner.PrintInfo($"Original decimal result #{ix}", resultsemiQuantitativeRequest?[ix]?.NumericResult);
                        ApiRunner.PrintInfo($"Calculated decimal result #{ix}", semiQuantitativeResultResponse?.ToArray()[ix]?.CalculationResult?.DecimalResult);
                        ApiRunner.PrintInfo($"Calculated flag level #{ix}", semiQuantitativeResultResponse?.ToArray()[ix]?.CalculationResult?.FlagLevel);
                        ApiRunner.PrintInfo($"Calculated flag level #{ix}", semiQuantitativeResultResponse?.ToArray()[ix]?.CalculationResult?.TextResult);
                        ApiRunner.PrintInfo($"Calculated flag symbol", GetFlagSymbol(semiQuantitativeResultResponse?.ToArray()[ix]?.CalculationResult?.FlagLevel,
                                                                                     flaggingTests?.FirstOrDefault(t => t.Id == resultsemiQuantitativeRequest?[ix]?.TestId)));
                    };
                },
            ])) failures++;

        // Multiple list tests
        IEnumerable<ResultResponse>? listTestResponse = null;
        ResultRequest[] resultListTestRequest = GetMultipleListTestRequests(flaggingTests!);
        processingMs = 0;
        if (!await ApiRunner.InvokeApiFunction(
            async () =>
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                listTestResponse = await akitaService.GetTestResult(resultListTestRequest, settings.ApiKey);
                stopwatch.Stop();
                processingMs = stopwatch.ElapsedMilliseconds;
            },
            $"{nameof(Flagging)}->{nameof(akitaService.GetTestResult)} (multiple list tests)",
            [
                () =>
                {
                    if (resultListTestRequest.Length != (listTestResponse?.Count() ?? 0)) throw new Exception("Answer's size has unexpected length.");
                    AnsiConsole.MarkupLineInterpolated($"  [grey]Invocation time: {processingMs}ms.[/]");
                    for (int ix = 0; ix < resultListTestRequest!.Length; ix++) {
                        AnsiConsole.MarkupLineInterpolated($"  [grey]--- Case {ix}[/]");
                        ApiRunner.PrintInfo($"Flagging test #{ix}", flaggingTests?.FirstOrDefault(t => t.Id == resultListTestRequest?[ix]?.TestId)?.Name);
                        ApiRunner.PrintInfo($"Calculated flag level #{ix}", listTestResponse?.ToArray()[ix]?.CalculationResult?.FlagLevel);
                        ApiRunner.PrintInfo($"Calculated flag level #{ix}", listTestResponse?.ToArray()[ix]?.CalculationResult?.TextResult);
                        ApiRunner.PrintInfo($"Calculated flag symbol", GetFlagSymbol(listTestResponse?.ToArray()[ix]?.CalculationResult?.FlagLevel,
                                                                                     flaggingTests?.FirstOrDefault(t => t.Id == resultListTestRequest?[ix]?.TestId)));
                    };
                },
            ])) failures++;


        ApiRunner.PrintFooterLines(failures);
    }

    private static string GetFlagSymbol(FlagLevels? flagLevel, Test? test)
    {
        return flagLevel switch
        {
            FlagLevels.ULTRA_LOW => test?.FlagType?.UltraLow ?? string.Empty,
            FlagLevels.VERY_LOW => test?.FlagType?.VeryLow ?? string.Empty,
            FlagLevels.LOW => test?.FlagType?.Low ?? string.Empty,
            FlagLevels.HIGH => test?.FlagType?.High ?? string.Empty,
            FlagLevels.VERY_HIGH => test?.FlagType?.VeryHigh ?? string.Empty,
            FlagLevels.ULTRA_HIGH => test?.FlagType?.UltraHigh ?? string.Empty,
            FlagLevels.NONE => string.Empty,
            FlagLevels.SEMI_QUANT_QUESTION => string.Empty,
            _ => throw new ArgumentOutOfRangeException(nameof(flagLevel), "The level is not supported.")
        };
    }

    private static ResultRequest[] GetMultipleListTestRequests(IEnumerable<Test> tests)
    {
        ///list test request
        Test test = GetTest(tests, (t) => t.ResultType == ResultTypes.List && t.FlagLimit >= FlagLevelLimits.UP_TO_ULTRA && t.AllowedResults.Any(ar => ar.FlagLevel == FlagLevels.HIGH || ar.FlagLevel == FlagLevels.VERY_HIGH));
        Test test1 = GetTest(tests, (t) => t.ResultType == ResultTypes.List && t.FlagLimit == FlagLevelLimits.NO_FLAG && t.AllowedResults.Any(ar => ar.FlagLevel == FlagLevels.NONE));


        return [
            GetListRequest(test.Id, $"S{Utilities.GetRandomString()}", null, test.AllowedResults?.FirstOrDefault(ar => ar.FlagLevel == FlagLevels.HIGH)),
            GetListRequest(test.Id, $"S{Utilities.GetRandomString()}", null, test.AllowedResults?.FirstOrDefault(ar => ar.FlagLevel == FlagLevels.VERY_HIGH)),
            GetListRequest(test1.Id, $"S{Utilities.GetRandomString()}", null, test1.AllowedResults?.FirstOrDefault(ar => ar.FlagLevel == FlagLevels.NONE))
            ];
    }

    private static ResultRequest[] GetMultipleNumericTestRequestsWithMultipleAlarms(IEnumerable<Test> tests)
    {
        ///test with multiple alarms
        (Test targetTest, ReferenceRange targetRange) = GetRange(
            tests,
            (t) => t.ResultType == ResultTypes.Quantitative && t.FlagLimit >= FlagLevelLimits.UP_TO_ULTRA,
            (r) => r.SpeciesId == 1 && !r.IsRangedByGender && r.HighAlarm2 is not null && r.HighAlarm1 is not null && r.LowAlarm1 is not null && r.LowAlarm2 is not null);

        return [
           GetNumericTestRequest(targetTest.Id, $"S{Utilities.GetRandomString()}", targetRange, null, FlagLevels.VERY_HIGH, 1.1m),
           GetNumericTestRequest(targetTest.Id, $"S{Utilities.GetRandomString()}", targetRange, null, FlagLevels.ULTRA_HIGH, 1.1m),
           GetNumericTestRequest(targetTest.Id, $"S{Utilities.GetRandomString()}", targetRange, null, FlagLevels.VERY_LOW, 0.95m),
           GetNumericTestRequest(targetTest.Id, $"S{Utilities.GetRandomString()}", targetRange, null, FlagLevels.ULTRA_LOW, 0.95m)
        ];
    }

    private static ResultRequest[] GetMultipleSemiQuantitativeTestRequests(IEnumerable<Test> tests)
    {
        ///test request for no flag, high, semiquantitative question between low and high
        (Test targetTest, ReferenceRange targetRange) = GetRange(
            tests,
            (t) => t.ResultType == ResultTypes.SemiQuantitative && t.FlagLimit >= FlagLevelLimits.UP_TO_ULTRA,
            (r) => r.SpeciesId == 1 && r.HighValue is not null && r.LowValue is not null);

        return [
            GetSemiQuantitativeRequest(targetTest.Id, $"S{Utilities.GetRandomString()}", targetRange, null, FlagLevels.HIGH, 1.1m),
            GetSemiQuantitativeRequest(targetTest.Id, $"S{Utilities.GetRandomString()}", targetRange, null, FlagLevels.LOW, 1.1m),
            GetSemiQuantitativeRequest(targetTest.Id, $"S{Utilities.GetRandomString()}", targetRange, null, FlagLevels.LOW, 0.95m)
            ];
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
        // Female, scale >=1, high alarm #1 limit
        (Test targetTestF, ReferenceRange targetRangeF) = GetRange(
            tests,
            (t) => t.ResultType == ResultTypes.Quantitative && t.Scale >= 1 && t.FlagLimit >= FlagLevelLimits.UP_TO_VERY,
            (r) => r.SpeciesId == 1 && r.IsRangedByGender && r.FHighAlarm1 is not null);
        // Unknown gender, scale >=1, low limit
        (Test targetTestU, ReferenceRange targetRangeU) = GetRange(
            tests,
            (t) => t.ResultType == ResultTypes.Quantitative && t.Scale >= 1 && t.FlagLimit >= FlagLevelLimits.UP_TO_VERY,
            (r) => r.SpeciesId == 1 && r.LowValue is not null);
        return [
            GetNumericTestRequest(targetTestM.Id, $"S{Utilities.GetRandomString()}", targetRangeM, true, FlagLevels.HIGH, 1.1m),
            GetNumericTestRequest(targetTestF.Id, $"S{Utilities.GetRandomString()}", targetRangeF, false, FlagLevels.VERY_HIGH, 1.1m),
            GetNumericTestRequest(targetTestU.Id, $"S{Utilities.GetRandomString()}", targetRangeU, null, FlagLevels.LOW, 0.95m),
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

    private static ResultRequest GetListRequest(int testId, string reference, bool? isMale, ResultEntry? entry) => new()
    {
        TestId = testId,
        RefId = reference,
        IsMale = isMale,
        TextResult = entry?.Value
    };

    private static ResultRequest GetSemiQuantitativeRequest(int testId, string reference, ReferenceRange range, bool? isMale, FlagLevels level, decimal coeficient) => new()
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

    private static Test GetTest(IEnumerable<Test> tests, Func<Test, bool> testFilter)
    {
        return tests.FirstOrDefault(testFilter) ?? throw new Exception("Can't find suitable test.");
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
                _ => throw new ArgumentOutOfRangeException(nameof(level), "The level is not supported.")
            },
            false => level switch
            {
                FlagLevels.ULTRA_LOW => range.FLowAlarm2,
                FlagLevels.VERY_LOW => range.FLowAlarm1,
                FlagLevels.LOW => range.FLowValue,
                FlagLevels.HIGH => range.FHighValue,
                FlagLevels.VERY_HIGH => range.FHighAlarm1,
                FlagLevels.ULTRA_HIGH => range.FHighAlarm2,
                _ => throw new ArgumentOutOfRangeException(nameof(level), "The level is not supported.")
            },
            _ => level switch
            {
                FlagLevels.ULTRA_LOW => range.LowAlarm2,
                FlagLevels.VERY_LOW => range.LowAlarm1,
                FlagLevels.LOW => range.LowValue,
                FlagLevels.HIGH => range.HighValue,
                FlagLevels.VERY_HIGH => range.HighAlarm1,
                FlagLevels.ULTRA_HIGH => range.HighAlarm2,
                _ => throw new ArgumentOutOfRangeException(nameof(level), "The level is not supported.")
            },
        };

}
