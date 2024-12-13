using System;

namespace Skyware.Lis.AkitaModel.Heartbeats;

/// <summary>
/// Represents a heartbeat message.
/// </summary>
public class Heartbeat
{

    /// <summary>
    /// UTC date/time of the Heartbeat message.
    /// </summary>
    public DateTime HeartbeatTime { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Local date/time of the Heartbeat message;
    /// </summary>
    public DateTime LocalHeartbeatTime => HeartbeatTime.ToLocalTime();

    /// <summary>
    /// Host where the heartbeat was generated.
    /// </summary>
    public Host Host { get; set; } = new Host();

    public string LocationId { get; set; }

    public string LocationName { get; set; }

    /// <summary>
    /// Application that generated the heartbeat.
    /// </summary>
    public ApplicationBase Application { get; set; }

}
