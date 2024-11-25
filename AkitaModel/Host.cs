using System;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Represents the host (PC, computer).
/// </summary>
public class Host
{

    /// <summary>
    /// Name of the host.
    /// </summary>
    public string Name { get; set; } = Environment.MachineName.ToLower();

}
