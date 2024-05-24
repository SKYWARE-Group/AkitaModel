namespace Skyware.Lis.AkitaModel.BgNhis;

/// <summary>
/// Examination
/// </summary>
public class Examination
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
    /// Name of product
    /// </summary>
    public string Name { get; set; }
}
