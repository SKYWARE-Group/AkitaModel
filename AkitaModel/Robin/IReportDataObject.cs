namespace Skyware.Lis.AkitaModel.Robin;

/// <summary>
/// Data object that can be encoded as Base64.
/// </summary>
public interface IReportDataObject
{

    /// <summary>
    /// Serialize to JSON and converts it to Base64 string.
    /// </summary>
    /// <returns></returns>
    string GetBase64Data();

}
