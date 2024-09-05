using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.Robin;
using Spectre.Console;

namespace AkitaModelDemo.RunUnits;

public class Robin
{
    public static async Task Run(IAkitaApi akitaService, AkitaSettings settings)
    {

        int failures = 0;

        ApiRunner.PrintHeaderLines("Robin");

        // All reports
        IEnumerable<DirectReport>? reports = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => reports = await akitaService.GetAllReports(),
            $"{nameof(Robin)}->{nameof(akitaService.GetAllReports)}",
            [
                () => ApiRunner.PrintInfo("Reports count", reports?.Count()),
                () => ApiRunner.PrintInfo("First report Id", reports?.FirstOrDefault()?.Id)
            ])) failures++;

        // Hello world report
        HttpResponseMessage? responseHello = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => responseHello = await akitaService.GetSimpleReport(Constants.ROBIN_REPORTS_HELLO_WORLD, string.Empty),
            $"{nameof(Robin)}->{nameof(akitaService.GetSimpleReport)} ({Constants.ROBIN_REPORTS_HELLO_WORLD})",
            [
                () => ApiRunner.PrintInfo("Report generation", "OK"),
                async () => await BinaryHelper.SaveAsTempAndOpen(responseHello!)
            ])) failures++;

        // Lab referral
        ReportRequest requestRefrral = new(DataFactory.GetDemoReferral());
        HttpResponseMessage? responseReferral = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => responseReferral = await akitaService.GetFullReport(Constants.ROBIN_REPORTS_BG_LAB_REFERRAL, requestRefrral),
            $"{nameof(Robin)}->{nameof(akitaService.GetFullReport)} ({Constants.ROBIN_REPORTS_BG_LAB_REFERRAL})",
            [
                () => ApiRunner.PrintInfo("Referral generation", "OK"),
                async () => await BinaryHelper.SaveAsTempAndOpen(responseReferral!)
            ])) failures++;

        ApiRunner.PrintFooterLines(failures);

    }
}