using Refit;
using Skyware.Arda.Model;
using Spectre.Console;
using System;

namespace AkitaModelDemo.Helpers;


public class ApiRunner
{

    public static async Task<bool> InvokeApiFunction(
        Func<Task> action, string actionName,
        IEnumerable<Action>? successActions = null,
        bool printExceptions = true)
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
                    if (printExceptions) AnsiConsole.WriteException(ex, ExceptionFormats.ShortenEverything);
                }
                catch (Exception ex)
                {
                    AnsiConsole.MarkupLineInterpolated($"{actionName}: [red]Failure[/].");
                    if (printExceptions) AnsiConsole.WriteException(ex, ExceptionFormats.ShortenEverything);
                }
            });

        if (res) foreach (Action act in successActions ?? []) act.Invoke();

        return res;

    }

    public static void PrintInfo(string label, object? value) => AnsiConsole.MarkupLineInterpolated($"  [grey]{label}: {value}.[/]");

    public static void PrintFooterLines(int failures)
    {
        AnsiConsole.MarkupLine("[dodgerblue1]--------------------------------------------------------[/]");
        AnsiConsole.Markup("[dodgerblue1]Failures:[/] ");
        if (failures == 0)
            AnsiConsole.MarkupLineInterpolated($"[green3]0 (Success)[/]");
        else
            AnsiConsole.MarkupLineInterpolated($"[red]{failures} (Failure)[/]");
        AnsiConsole.MarkupLine("");
    }

    public static void PrintHeaderLines(string title)
    {
        AnsiConsole.MarkupLineInterpolated($"[dodgerblue1]{title}[/]");
        AnsiConsole.MarkupLine("[dodgerblue1]--------------------------------------------------------[/]");
    }


}