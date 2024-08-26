namespace Skyware.Lis.AkitaModel.SmartScan.Events;


/// <summary>
/// Represents a file uploaded to BLOB storage.
/// This is an event payload object (SignalR).
/// </summary>
public class FileEvent : FileBase, ITypedEvent
{

    /// <summary>
    /// Id of the attachment type
    /// </summary>
    public int DocumentTypeId { get; set; }

    /// <inheritdoc/>
    public string MethodName => "file";

}
