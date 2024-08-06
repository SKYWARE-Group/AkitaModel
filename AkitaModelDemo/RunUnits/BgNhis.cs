using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Arda.Model;
using Skyware.Lis.AkitaModel.BgNhis;

// Ignore Spelling: bg uin

namespace AkitaModelDemo.RunUnits;

public class BgNhis
{
    public static async Task Run(IAkitaApi akitaService, AkitaSettings settings)
    {

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

    }
}
