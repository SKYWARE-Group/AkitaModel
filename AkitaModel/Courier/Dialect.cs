namespace Skyware.Lis.AkitaModel.Courier;

// Ignore Spelling: hl

/// <summary>
/// HL7 syntax dialect.
/// </summary>
public class Dialect
{

    /// <summary>
    /// Identifier in the Courier system, e.g. "hl7.251.basic".
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Friendly name, e.g. "HL7 v2.5.1 Basic".
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Base HL7 version, e.g. "2.5.1".
    /// </summary>
    public string Hl7Version { get; set; }

    /// <summary>
    /// Description and further details.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// True if this dialect is default one for Courier system.
    /// </summary>
    public bool IsDefault { get; set; } = false;

}
