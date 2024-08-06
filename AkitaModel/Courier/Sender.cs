namespace Skyware.Lis.AkitaModel.Courier;

// Ignore Spelling: tcp

/// <summary>
/// Message sender, e.g. TCP, HTTP POST, etc.
/// </summary>
public class Sender
{

    /// <summary>
    /// Identifier of the sender, e.g. "tcp".
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Name of the sender, e.g. "TCP Client".
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Sender version, e.g. "1.0.0".
    /// </summary>
    public string Version { get; set; }

}
