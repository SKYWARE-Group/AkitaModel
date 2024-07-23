using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.Robin;

namespace AkitaModelDemo.RunUnits;

public class Robin
{
    public static async Task Run(IAkitaApi akitaService, AkitaSettings settings)
    {
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

    }
}