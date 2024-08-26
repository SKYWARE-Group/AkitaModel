namespace Skyware.Lis.AkitaModel.SmartScan.Events;

/// <summary>
/// Represents invalidation of a slot.
/// This is an event payload object (SignalR).
/// </summary>
public class SlotInvalidatedEvent : ITypedEvent
{

    /// <summary>
    /// Id of the invalidated slot
    /// </summary>
    public string Id { get; set; }

    /// <inheritdoc/>
    public string MethodName => "slotinvalidated";

}
