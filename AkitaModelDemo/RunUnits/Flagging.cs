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
        // Tests
        IEnumerable<Test> flaggingTests = await akitaService.GetAllTests(settings.ApiKey);
        Console.WriteLine($"#FLAGGING Tests count: {flaggingTests.Count()}");
        Console.WriteLine($"#FLAGGING First test name: {flaggingTests.FirstOrDefault()?.Name}");

        // Flag Results
        IEnumerable<ResultRequest> resultRequest = DataFactory.GetDemoFlaggingTestResultRequest();
        IEnumerable<ResultResponse> resultResponses = await akitaService.GetTestResult(resultRequest, settings.ApiKey);
        foreach (ResultResponse response in resultResponses)
            Console.WriteLine($"#FLAGGING Test result: RefId: '{response.RefId}' Result: '{response.CalculationResult?.FlagLevel}'");

        //// Single Test
        //Test flaggingTest = await akitaService.GetSingleTest(tests?.FirstOrDefault()?.Id ?? InternalConstants.CORE_SINGLE_TEST_ID, settings.ApiKey);
        //Console.WriteLine($"#FLAGGING Test Id: {flaggingTest?.Id}");
        //Console.WriteLine($"#FLAGGING Test name: {flaggingTest?.Name}");
    }
}
