using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Refit;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.BgNhis;
using Skyware.Rila.Model;
using Spectre.Console;

// Ignore Spelling: bg uin grey

namespace AkitaModelDemo.RunUnits;

public class BgNhis
{
    public static async Task<IEnumerable<NhifContract>?> GetContracts(IAkitaApi akitaService, AkitaSettings settings)
    {

        // Contracts
        IEnumerable<NhifContract>? contracts = null;
        bool res = await ApiRunner.InvokeApiFunction(
            async () => contracts = await akitaService.GetContracts(settings.ApiKey),
            $"{nameof(BgNhis)}->{nameof(akitaService.GetContracts)}",
            [
                () => ApiRunner.PrintInfo("Contracts count", contracts?.Count()),
                () => ApiRunner.PrintInfo("Doctor's UIN of first contract", contracts?.FirstOrDefault()?.Doctor.Uin)
            ]);
        return contracts;
    }

    public static async Task Run(IAkitaApi akitaService, AkitaSettings settings)
    {
        int failures = 0;

        ApiRunner.PrintHeaderLines("Akita BgNhis: Public functions");

        // Contracts
        IEnumerable<NhifContract>? contracts = await GetContracts(akitaService, settings);
        if (!contracts?.Any() ?? false)
        {
            AnsiConsole.MarkupLine($"[red]Execution is cancelled as there are no NHIF contracts.[/]");
            return;
        }

        // Packages
        IEnumerable<NhifPack>? packages = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => packages = await akitaService.GetPackages(settings.ApiKey),
            $"{nameof(BgNhis)}->{nameof(akitaService.GetPackages)}",
            [
                () => ApiRunner.PrintInfo("Packages count", packages?.Count()),
                () => ApiRunner.PrintInfo("Name of first package", packages?.FirstOrDefault()?.Name)
            ])) failures++;

        // Examinations
        IEnumerable<Examination>? examinations = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => examinations = await akitaService.GetExaminations(settings.ApiKey),
            $"{nameof(BgNhis)}->{nameof(akitaService.GetExaminations)}",
            [
                () => ApiRunner.PrintInfo("Examinations count", examinations?.Count()),
                () => ApiRunner.PrintInfo("Name of first examination", examinations?.FirstOrDefault()?.Name)
            ])) failures++;


        // 1. Сценарий 1
        // 1.1 Извличане на НМДД по НРД (очаква се 1)
        // 1.2 Търсене по ЕГН (очаква се 1)

        // Get referral
        RilaReferralResultsData? referral = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => referral = await akitaService.GetReferral(DataFactory.NRN, settings.ApiKey),
            $"{nameof(BgNhis)}->{nameof(akitaService.GetReferral)}",
            [
                () => ApiRunner.PrintInfo("Referral number", referral?.ReferralData?.Nrn),
            ])) failures++;

        // Get referral not found
        HttpResponseMessage? message = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => message = await akitaService.GetReferralNotFound("fsjefoheshjf", settings.ApiKey),
            $"{nameof(BgNhis)}->{nameof(akitaService.GetReferralNotFound)}",
            [
                () => ApiRunner.PrintInfo("Fake referral with status code", message?.StatusCode),
            ])) failures++;

        // Search referrals
        IEnumerable<RilaReferralResultsData>? referrals = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => referrals = await akitaService.SearchReferrals(DataFactory.PID, settings.ApiKey),
            $"{nameof(BgNhis)}->{nameof(akitaService.SearchReferrals)}",
            [
                () => ApiRunner.PrintInfo("Referrals count", referrals?.Count()),
                () => ApiRunner.PrintInfo("Nrn of first referral", referrals?.FirstOrDefault()?.ReferralData.Nrn)
            ])) failures++;


        // 2. Сценарий 2
        // 2.1. Търсене по ЕГН (очакват се 3)
        // 2.2. Импорт на №1 и № 2 (очаква се 1 продажба)
        // 2.3. Добавяне на № 3 към продажбата от 2.2 (вече трябва да им 3)
        // 2.4. Премахва са № 1 (очаква се да останат само 2)
        // 2.5. В № 2 първия код се анулира (void)
        // 2.6. Кода по т 2.5. се възстановява
        // 2.7  Освобождаване на всички направления

        //2.1
        IEnumerable<RilaReferralResultsData>? referrals2 = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => referrals2 = await akitaService.SearchReferrals(DataFactory.PID, settings.ApiKey),
            $"{nameof(BgNhis)}->{nameof(akitaService.SearchReferrals)}",
            [
                () => ApiRunner.PrintInfo("Referrals count", referrals2?.Count()),
                () => ApiRunner.PrintInfo("Nrn of first referral", referrals2?.FirstOrDefault()?.ReferralData.Nrn)
            ])) failures++;

        if (referrals2 is null)
        {
            AnsiConsole.MarkupLine($"[red]Execution is cancelled as there are no referrals.[/]");
            return;
        }

        List<string> nrns = referrals2.Select(r => r.ReferralData.Nrn).ToList();

        //2.2
        ImportRequest? importRequest = DataFactory.GetImportRequest(nrns.Take(2), contracts?.FirstOrDefault()!, null);
        Sale? sale = null;
        if (!await ApiRunner.InvokeApiFunction(
            async () => sale = await akitaService.Import(importRequest, settings.ApiKey),
            $"{nameof(BgNhis)}->{nameof(akitaService.Import)}",
            [
                () => ApiRunner.PrintInfo("Sale id with 2 referrals", sale?.Id),
                () => { foreach (var nrn in nrns.Take(2))
                    {
                        ApiRunner.PrintInfo("Nrn -->", nrn);
                    }}
            ])) failures++;


        if (sale is not null)
        {
            //2.3
            importRequest = DataFactory.GetImportRequest(nrns.Skip(2), contracts?.FirstOrDefault()!, sale?.Id);
            if (!await ApiRunner.InvokeApiFunction(
                async () => sale = await akitaService.Import(importRequest, settings.ApiKey),
                $"{nameof(BgNhis)}->{nameof(akitaService.Import)}",
                [
                    () => ApiRunner.PrintInfo("Third referral imported", sale?.Id),
                    () => ApiRunner.PrintInfo("Third referral nrn", nrns.Skip(2).FirstOrDefault())
                ])) failures++;

            //2.4
            if (!await ApiRunner.InvokeApiFunction(
                async () => sale = await akitaService.ReleaseReferral(nrns.FirstOrDefault()!, settings.ApiKey),
                $"{nameof(BgNhis)}->{nameof(akitaService.ReleaseReferral)}",
                [
                    () => ApiRunner.PrintInfo("Remove third referral", sale?.Id)
                ])) failures++;

            string code = referrals2.ToList()[1].ReferralData.Procedures.FirstOrDefault()?.Code ?? string.Empty;

            //2.5
            ApiResponse<bool>? response = null;
            if (!await ApiRunner.InvokeApiFunction(
                 async () => response = await akitaService.VoidReferralItem(nrns[1], code, settings.ApiKey),
                 $"{nameof(BgNhis)}->{nameof(akitaService.VoidReferralItem)}",
                 [
                     () => ApiRunner.PrintInfo("Referral item voided result", response?.StatusCode)
                 ])) failures++;

            //2.6
            if (!await ApiRunner.InvokeApiFunction(
                 async () => response = await akitaService.RestoreReferralItem(nrns[1], code, settings.ApiKey),
                 $"{nameof(BgNhis)}->{nameof(akitaService.RestoreReferralItem)}",
                 [
                     () => ApiRunner.PrintInfo("Referral item restored result", response?.StatusCode)
                 ])) failures++;

            //2.7
            importRequest = DataFactory.GetImportRequest(nrns, contracts?.FirstOrDefault()!, null);
            if (!await ApiRunner.InvokeApiFunction(
                async () => sale = await akitaService.ReleaseAll(importRequest, settings.ApiKey),
                $"{nameof(BgNhis)}->{nameof(akitaService.ReleaseAll)}",
                [
                    () => ApiRunner.PrintInfo("Remove all referrals", sale?.Id),
                ])) failures++;

            ApiRunner.PrintFooterLines(failures);
        }
    }
}
