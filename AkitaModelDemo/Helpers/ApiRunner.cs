using Refit;
using Skyware.Arda.Model;
using Spectre.Console;
using System;

namespace AkitaModelDemo.Helpers;


public class ApiRunner
{

    public static async Task<bool> InvokeApiFunction(Func<Task> action, string actionName, bool swallowExceptions = false)
    {
        bool res = false;

        await AnsiConsole
            .Status()
            .AutoRefresh(true)
            .Spinner(Spinner.Known.Dots)
            .SpinnerStyle(Style.Parse("white bold"))
            .StartAsync($"Invoking {actionName}...", async ctx =>
            {
                try
                {
                    await action();
                    AnsiConsole.MarkupLineInterpolated($"{actionName}: [green3]Success[/].");
                    res = true;
                }
                catch (HttpRequestException ex)
                {
                    AnsiConsole.MarkupLineInterpolated($"{actionName}: [red]Failure[/].");
                    if (!swallowExceptions) AnsiConsole.WriteException(ex, ExceptionFormats.ShortenEverything);
                }
                catch (Exception ex)
                {
                    AnsiConsole.MarkupLineInterpolated($"{actionName}: [red]Failure[/].");
                    if (!swallowExceptions) AnsiConsole.WriteException(ex, ExceptionFormats.ShortenEverything);
                }
            });

        return res;

    }

}