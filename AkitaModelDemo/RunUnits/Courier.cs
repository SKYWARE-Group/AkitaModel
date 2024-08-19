using AkitaModelDemo.Helpers;
using AkitaModelDemo.Models;
using AkitaModelDemo.Services;
using Skyware.Lis.AkitaModel.Courier;
using Spectre.Console;

namespace AkitaModelDemo.RunUnits;

internal class Courier
{
    public static async Task Run(IAkitaApi akitaService, AkitaSettings settings)
    {
        AnsiConsole.MarkupLine("[dodgerblue1]Courier: GetChannels[/]");
        AnsiConsole.MarkupLine("[dodgerblue1]--------------------------------------------------------[/]");

        IEnumerable<Channel> channels = null;
        await ApiRunner.InvokeApiFunction(
            async () => { channels = await akitaService.GetChannels(settings.ApiKey); },
            $"{nameof(Courier)}->{nameof(akitaService.GetChannels)}",
            [
                () => ApiRunner.PrintInfo("Species count", channels?.Count()),
                () => ApiRunner.PrintInfo("First channels name", channels?.FirstOrDefault()?.Name),
            ]);

        AnsiConsole.MarkupLine("[dodgerblue1]Courier: GetDialects[/]");
        AnsiConsole.MarkupLine("[dodgerblue1]--------------------------------------------------------[/]");

        IEnumerable<Dialect> dialects = null;
        await ApiRunner.InvokeApiFunction(
            async () => { dialects = await akitaService.GetDialects(settings.ApiKey); },
            $"{nameof(Courier)}->{nameof(akitaService.GetDialects)}",
            [
                () => ApiRunner.PrintInfo("Dialects count", dialects?.Count()),
                () => ApiRunner.PrintInfo("First dialects name", dialects?.FirstOrDefault()?.Name),
            ]);

        AnsiConsole.MarkupLine("[dodgerblue1]Courier: GetSenders[/]");
        AnsiConsole.MarkupLine("[dodgerblue1]--------------------------------------------------------[/]");

        IEnumerable<Sender> senders = null;
        await ApiRunner.InvokeApiFunction(
            async () => { senders = await akitaService.GetSenders(settings.ApiKey); },
            $"{nameof(Courier)}->{nameof(akitaService.GetSenders)}",
            [
                () => ApiRunner.PrintInfo("Senders count", senders?.Count()),
                () => ApiRunner.PrintInfo("First senders name", senders?.FirstOrDefault()?.Name),
            ]);

        await RunSales(akitaService, settings);
    }

    private static async Task RunSales(IAkitaApi akitaService, AkitaSettings settings)
    {
        AnsiConsole.MarkupLine("[dodgerblue1]Courier: GetSaleMessage[/]");
        AnsiConsole.MarkupLine("[dodgerblue1]--------------------------------------------------------[/]");

        int saleId = Random.Shared.Next(4000) + 1000;
        string message = null;
        await ApiRunner.InvokeApiFunction(
            async () => { message = await akitaService.GetSaleMessage(saleId, settings.ApiKey); },
            $"{nameof(Courier)}->{nameof(akitaService.GetSaleMessage)}",
            [
                () => ApiRunner.PrintInfo("Sale Id", saleId),
                () => ApiRunner.PrintInfo("Message received", message),
                () => ApiRunner.PrintInfo("Message length", message?.Length),
            ]);
    }
}
