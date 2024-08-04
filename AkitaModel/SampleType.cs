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
    /// Short code, used across the laboratory, e.g. "Serum", "WB", etc.<br/>
    /// This is the code that usually is printed on sample tubes.
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
    /// Material code, e.g. "WB" (Whole Blood in HL7 table 0487).<br/>
    /// See <see href="http://terminology.hl7.org/CodeSystem/v2-0487"/>.
    /// </summary>
    public string TypeCode { get; set; }

    /// <summary>
    /// Sample additive/preservative code, e.g. "EDTK" (Potassium/K EDTA in HL7 table 0371).<br/>
    /// See <see href="http://terminology.hl7.org/CodeSystem/v2-0371"/>.
    /// </summary>
    public string AdditiveCode { get; set; }

    /// <summary>
    /// Body part (specimen source) code, e.g. "BLDV" (Blood  venous in HL7 table 0070).<br/>
    /// See <see href="http://terminology.hl7.org/CodeSystem/v2-0550"/>.
    /// </summary>
    public string BodyPartCode { get; set; }


}
