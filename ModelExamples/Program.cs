// See https://aka.ms/new-console-template for more information
using Skyware.Lis.AkitaModel.Results;
using Spectre.Console;
using Spectre.Console.Json;

AnsiConsole.MarkupLine("[green]Akita Model Demo[/]");

//string basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location ) ?? throw new Exception("Can't determine base path.");
//string resFileName = Path.Combine(basePath, "Results", "LaboratoryResults.json");
//await ResultExample.SaveLaboratoryResults(resFileName);
//Console.WriteLine($"{nameof(LaboratoryResults)}: {resFileName}");


VisitResults res = ModelExamples.Results.ResultsExample.GetDemoVisitResults();
string jsonString = System.Text.Json.JsonSerializer.Serialize(res, Skyware.Lis.AkitaModel.Helpers.AkitaJsonOptions.Options);
JsonText jsonResults = new(jsonString);

AnsiConsole.Write(
    new Spectre.Console.Panel(jsonResults)
        .Header(nameof(VisitResults))
        .Collapse()
        .RoundedBorder()
        .BorderColor(Color.Yellow));

VisitBalance balance = ModelExamples.Results.ResultsExample.GetDemoVisitBalance();
jsonString = System.Text.Json.JsonSerializer.Serialize(balance, Skyware.Lis.AkitaModel.Helpers.AkitaJsonOptions.Options);
JsonText jsonBalance = new(jsonString);

AnsiConsole.Write(
    new Spectre.Console.Panel(jsonBalance)
        .Header(nameof(VisitBalance))
        .Collapse()
        .RoundedBorder()
        .BorderColor(Color.Yellow));
