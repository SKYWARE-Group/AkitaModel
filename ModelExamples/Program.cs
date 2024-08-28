// See https://aka.ms/new-console-template for more information
using ModelExamples.Reports;
using Skyware.Lis.AkitaModel.Robin.Reports;
using System.Reflection;

Console.WriteLine("Examples generation");

string basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location ) ?? throw new Exception("Can't determine bae path.");

string resFileName = Path.Combine(basePath, "Results", "LaboratoryResults.json");
await ResultExample.SaveLaboratoryResults(resFileName);
Console.WriteLine($"{nameof(LaboratoryResults)}: {resFileName}");
