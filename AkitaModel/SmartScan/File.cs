namespace Skyware.Lis.AkitaModel.SmartScan;

/// <summary>
/// Binary file with metadata.
/// </summary>
public class File : FileBase
{

    /// <summary>
    /// Base64 encoded binary data of a file.
    /// </summary>
    public string Data { get; set; }

}

