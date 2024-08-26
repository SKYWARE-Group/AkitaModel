namespace Skyware.Lis.AkitaModel.SmartScan;

/// <summary>
/// Represents the type of the uploaded file.
/// </summary>
public class DocumentType
{

    /// <summary>
    /// Id of the document type (local database).
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the document type.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Amount of days the document will expire.
    /// </summary>
    public int? ExpirationDays { get; set; }

    /// <summary>
    /// Available file extensions for the document type,
    /// comma separated values e.g. 'png,jpeg,jpg,pdf'
    /// </summary>
    public string FileExtentions { get; set; }

    /// <summary>
    /// Method/Service of storage.
    /// </summary>
    public int? DefaultStorageType { get; set; }

}
