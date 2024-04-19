using System;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Sample type, e.g. Serum, Whole blood, Stool, etc.
/// </summary>
public class SampleType
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Short code, used across the laboratory, e.g. "Serum", "WB", etc.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Red component of the sample color code.
    /// </summary>
    public int? ColorR { get; set; }

    /// <summary>
    /// Green component of the sample color code.
    /// </summary>
    public int? ColorG { get; set; }

    /// <summary>
    /// Blood component of the sample color code.
    /// </summary>
    public int? ColorB { get; set; }

    /// <summary>
    /// LOINC code. Obsolete.
    /// </summary>
    [Obsolete]
    public string LoincId { get; set; }

}
