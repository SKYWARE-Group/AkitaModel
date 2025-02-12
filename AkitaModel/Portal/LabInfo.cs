namespace Skyware.Lis.AkitaModel.Portal;

// Ignore Spelling: LabInfo precisio

public class LabInfo
{

    /// <summary>
    /// Brand of the laboratory, e.g. "Precisio".
    /// </summary>
    public string Brand { get; set; } = string.Empty;

    /// <summary>
    /// Short name of the laboratory, e.g. "Precisio Laboratory".
    /// </summary>
    public string ShortName { get; set; } = string.Empty;

    /// <summary>
    /// Full name of the laboratory, e.g. "Precisio Laboratory, Inc.".
    /// </summary>
    public string FullName { get; set; } = string.Empty;

    /// <summary>
    /// License number of the laboratory.
    /// </summary>
    public string LicenseNumber { get; set; } = string.Empty;

}
