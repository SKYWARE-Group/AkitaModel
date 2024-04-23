namespace Skyware.Lis.AkitaModel.BgNhis;

/// <summary>
/// NHIF/NHIS (НЗОК/НЗИС) speciality.
/// </summary>
public class NhifSpeciality
{

    /// <summary>
    /// Code, according no NHIF (НЗОК).
    /// </summary>
    public string NhifCode { get; set; }

    /// <summary>
    /// Code, according to NHIS (НЗИС) CL006.
    /// </summary>
    public string NhisCode { get; set; }

    /// <summary>
    /// Name of the speciality, according to NHIF (НЗОК).
    /// </summary>
    public string Name { get; set; }

}
