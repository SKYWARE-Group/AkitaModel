namespace Skyware.Lis.AkitaModel.Heartbeats;

// Ignore Spelling: epson

/// <summary>
/// Represents a device which is available to the given application.
/// </summary>
public abstract class DeviceBase
{

    /// <summary>
    /// Brand of the device, e.g. "Epson", "Datecs", etc.
    /// </summary>
    public string Brand { get; set; }

    /// <summary>
    /// Model of the device, e.g. "TM-T88V", "MP55", etc.
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Serial number or ID of the device, e.g. fiscal memory number, POS terminal Id, etc.
    /// </summary>
    public string SerialNumberOrId { get; set; }

}
