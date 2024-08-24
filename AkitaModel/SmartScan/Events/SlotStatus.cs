namespace Skyware.Lis.AkitaModel.SmartScan.Events;


/// <summary>
/// Represents slot for ad hoc client for taking pictures.
/// This is an event payload object (SignalR).
/// </summary>
public class SlotStatus : ITypedEvent
{

    /// <summary>
    /// Id of a slot (encoded in endpoint URL).
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// True if slot is available.
    /// </summary>
    public bool IsValid { get; set; } = false;

    /// <inheritdoc/>
    public string MethodName => "slot";

}
