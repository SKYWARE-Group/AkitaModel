using System.Diagnostics;

namespace AkitaModelDemo.Helpers;

public class BinaryHelper
{

    public static async Task SaveAsTempAndOpen(HttpResponseMessage response)
    {
        string targetPath = Path.Combine(AppContext.BaseDirectory, "temp", $"{Guid.NewGuid()}.pdf");
        await SaveData(targetPath, response);
        OpenFile(targetPath);
    }

    public static async Task SaveData(string targetPath, HttpResponseMessage response)
    {
        byte[] data = await response.Content.ReadAsByteArrayAsync();
        await SaveData(targetPath, data);
    }

    public static async Task SaveData(string targetPath, byte[] data)
    {
        FileInfo file = new(targetPath);
        file.Directory?.Create(); // If the directory already exists, this method does nothing.
        await File.WriteAllBytesAsync(targetPath, data);
    }

    public static void OpenFile(string targetPath)
    {
        using Process fileopener = new();
        fileopener.StartInfo.FileName = "explorer";
        fileopener.StartInfo.Arguments = "\"" + targetPath + "\"";
        fileopener.Start();
    }

}
