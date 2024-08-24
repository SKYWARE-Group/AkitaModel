namespace Skyware.Lis.AkitaModel.SmartScan.Events;


/// <summary>
/// Represents a connection made from browser (mobile) to the server.
/// This is an event payload object (SignalR).
/// </summary>
public class Connection : ITypedEvent
{

    /// <summary>
    /// Public IP address of the connected device.
    /// </summary>
    public string IpAddress { get; set; }

    /// <summary>
    /// Browser identity of the connected device.
    /// </summary>
    public string Browser { get; set; }

    /// <summary>
    /// Id of a slot to which the client is connected.
    /// </summary>
    public string SlotId { get; set; }

    /// <inheritdoc/>
    public string MethodName => "connection";

}
