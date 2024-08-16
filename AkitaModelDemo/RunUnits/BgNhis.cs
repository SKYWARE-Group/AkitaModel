using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.BgNhis;
using Skyware.Rila.Model;

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

        // Contracts
        IEnumerable<NhifContract> contracts = await akitaService.GetContracts(settings.ApiKey);
        Console.WriteLine($"#BGNHIS NhifContracts count: {contracts.Count()}");
        Console.WriteLine($"#BGNHIS First NhifContract doctor uin: {contracts.FirstOrDefault()?.Doctor.Uin}");

        // 1. Сценарий 1
        // 1.1 Извличане на НМДД по НРД (очаква се 1)
        // 1.2 Търсене по ЕГН (очаква се 1)

        // Get referral
        RilaReferralResultsData referral = await akitaService.GetReferral(DataFactory.NRN, settings.ApiKey);
        Console.WriteLine($"#BGNHIS Referral number: {referral?.ReferralData.Nrn}");

        // Get referral not found
        var message = await akitaService.GetReferralNotFound("fsjefoheshjf", settings.ApiKey);
        Console.WriteLine($"#BGNHIS Fake referral with status code: {message.StatusCode}");

        // Search referrals
        IEnumerable<RilaReferralResultsData> referrals = await akitaService.SearchReferrals(DataFactory.PID, settings.ApiKey);
        Console.WriteLine($"#BGNHIS Referrals count: {referrals.Count()}");


        // 2. Сценарий 2
        // 2.1. Търсене по ЕГН (очакват се 3)
        // 2.2. Импорт на №1 и № 2 (очаква се 1 продажба)
        // 2.3. Добавяне на № 3 към продажбата от 2.2 (вече трябва да им 3)
        // 2.4. Премахва са № 1 (очаква се да останат само 2)
        // 2.5. В № 2 първия код се анулира (void)
        // 2.6. Кода по т 2.5. се възстановява
        // 2.7  Освобождаване на всички направления

        //2.1
        IEnumerable<RilaReferralResultsData> referrals2 = await akitaService.SearchReferrals(DataFactory.PID, settings.ApiKey);
        Console.WriteLine($"#BGNHIS Referrals count: {referrals2.Count()}");

        List<string> nrns = referrals2.Select(r => r.ReferralData.Nrn).ToList();

        //2.2
        var importRequest = DataFactory.GetImportRequest(nrns.Take(2), contracts.FirstOrDefault()!, null);
        Sale sale = await akitaService.Import(importRequest, settings.ApiKey);
        Console.WriteLine($"#BGNHIS Sale id with 2 referrals: {sale.Id}");

        if (sale is not null)
        {
            //2.3
            importRequest = DataFactory.GetImportRequest(nrns.Skip(2), contracts.FirstOrDefault()!, sale.Id);
            sale = await akitaService.Import(importRequest, settings.ApiKey);
            Console.WriteLine($"#BGNHIS Import third referral: {sale.Id}");

            //2.4
            sale = await akitaService.ReleaseReferral(nrns.FirstOrDefault()!, settings.ApiKey);
            Console.WriteLine($"#BGNHIS Remove third referral: {sale.Id}");

            string code = referrals2.ToList()[1].ReferralData.Procedures.FirstOrDefault()?.Code ?? string.Empty;

            //2.5
            var response = await akitaService.VoidReferralItem(nrns[1], code, settings.ApiKey);
            Console.WriteLine($"#BGNHIS Referral item voided result: {response.StatusCode}");
            //2.6
            response = await akitaService.RestoreReferralItem(nrns[1], code, settings.ApiKey);
            Console.WriteLine($"#BGNHIS Referral item restored result: {response.StatusCode}");

            //2.7
            importRequest = DataFactory.GetImportRequest(nrns, contracts.FirstOrDefault()!, null);
            sale = await akitaService.ReleaseAll(importRequest, settings.ApiKey);
            Console.WriteLine($"#BGNHIS Remove all referrals: {sale.Id}");
        }
    }
}
