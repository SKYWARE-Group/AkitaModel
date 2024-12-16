// See https://aka.ms/new-console-template for more information
using Skyware.Lis.AkitaModel.Results;
using Spectre.Console;
using Spectre.Console.Json;

AnsiConsole.MarkupLine("[green]Akita Model Demo[/]");

//string basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location ) ?? throw new Exception("Can't determine base path.");
//string resFileName = Path.Combine(basePath, "Results", "LaboratoryResults.json");
//await ResultExample.SaveLaboratoryResults(resFileName);
//Console.WriteLine($"{nameof(LaboratoryResults)}: {resFileName}");


VisitResults obj = ModelExamples.Results.ResultsExample.GetDemoVisit();

string jsonString = System.Text.Json.JsonSerializer.Serialize(obj, Skyware.Lis.AkitaModel.Helpers.AkitaJsonOptions.Options);
JsonText json = new(jsonString);

AnsiConsole.Write(
    new Spectre.Console.Panel(json)
        .Header(nameof(VisitResults))
        .Collapse()
        .RoundedBorder()
        .BorderColor(Color.Yellow));
