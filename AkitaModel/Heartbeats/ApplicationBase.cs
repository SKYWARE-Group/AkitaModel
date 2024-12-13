using System;
using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Heartbeats;

/// <summary>
/// Represents an application that generates a heartbeat.
/// </summary>
public abstract class ApplicationBase
{

    /// <summary>
    /// Name of the application.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Version of the application.
    /// </summary>
    public string Version { get; set; }

    /// <summary>
    /// Username of the user that is currently logged in the application.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Uptime of the application.
    /// </summary>
    public TimeSpan Uptime { get; set; }

    /// <summary>
    /// List of devices that are available to the application.
    /// </summary>
    public IList<DeviceBase> AvailableDevices { get; set; } = [];

}
