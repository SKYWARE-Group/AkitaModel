using Skyware.Lis.AkitaModel.Robin.Reports;

namespace ModelExamples.Reports;

public class ResultExample
{

    public static LaboratoryResults GetLaboratoryResults() => new()
    {
        Patient = new()
        {
            GivenName = "John",
            FamilyName = "Doe",
            DateOfBirth = DateTime.Now.AddYears(-30).AddMonths(-8).AddDays(6),
            IsDobAprox = false,
            IsMale = false,
        }
    };

    public static async Task SaveLaboratoryResults(string fileName, bool deleteIfExists = true)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(fileName) ?? throw new ArgumentOutOfRangeException(nameof(fileName), "Wrong path")); // ensure folder exists
        if (deleteIfExists && File.Exists(fileName)) File.Delete(fileName); // delete if needed
        LaboratoryResults obj = GetLaboratoryResults();
        string data = System.Text.Json.JsonSerializer.Serialize(obj, Skyware.Lis.AkitaModel.Helpers.AkitaJsonOptions.Options);
        await File.WriteAllTextAsync(fileName, data);
    }


}

