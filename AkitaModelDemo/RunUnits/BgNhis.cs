using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Arda.Model;
using Skyware.Lis.AkitaModel.BgNhis;

// Ignore Spelling: bg uin

namespace AkitaModelDemo.RunUnits;

public class BgNhis
{
    public static async Task RunBasic(IAkitaApi akitaService, AkitaSettings settings)
    {

        // Contracts
        IEnumerable<NhifContract> contracts = await akitaService.GetContracts(settings.ApiKey);
        Console.WriteLine($"#BGNHIS NhifContracts count: {contracts.Count()}");
        Console.WriteLine($"#BGNHIS First NhifContract doctor uin: {contracts.FirstOrDefault()?.Doctor.Uin}");

    }

    public static async Task Run(IAkitaApi akitaService, AkitaSettings settings)
    {

        // 1. Сценарий 1
        // 1.1 Извличане на НМДД по НРД (очаква се 1)
        // 1.2 Търсене по ЕГН (очаква се 1)

        // Get referral
        Referral? referral = await akitaService.GetReferral(DataFactory.NRN, settings.ApiKey);
        Console.WriteLine($"#BGNHIS Referral number: {referral?.Nrn}");

        // Search referrals
        IEnumerable<Referral> referrals = await akitaService.SearchReferrals(DataFactory.PID, settings.ApiKey);
        Console.WriteLine($"#BGNHIS Referrals count: {referrals.Count()}");
        Console.WriteLine($"#BGNHIS First Referral number: {referrals.FirstOrDefault()?.Nrn}");


        // 2. Сценарий 2
        // 2.1. Търсене по ЕГН (очакват се 3)
        // 2.2. Импорт на №1 и № 2 (очаква се 1 продажба)
        // 2.3. Добавяне на № 3 към продажбата от 2.2 (вече трябва да им 3)
        // 2.4. Премахва са № 1 (очаква се да останат само 2)
        // 2.5. В № 2 първия код се анулира (void)
        // 2.5. Кода по т 2.5. се възстановява


    }


}
