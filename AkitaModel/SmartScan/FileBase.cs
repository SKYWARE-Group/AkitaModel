namespace Skyware.Lis.AkitaModel.SmartScan;

/// <summary>
/// Base class for file description.
/// </summary>
public abstract class FileBase
{

    /// <summary>
    /// Id of the file as it is known in the BLOB storage, e.g. '123-456-789.pdf'.
    /// </summary>
    public string FileId { get; set; }

    /// <summary>
    /// File name as it is known in the file systems, e.g. 'my-doc.docx'.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Id of a slot to which the client is connected.
    /// </summary>
    public string SlotId { get; set; }

}

