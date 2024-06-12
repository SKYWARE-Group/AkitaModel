namespace Skyware.Lis.AkitaModel.BgNhis;

/// <summary>
/// NHIF covered examination (Изследване, платимо от НЗОК).
/// </summary>
public class Examination
{

    /// <summary>
    /// Code according to NHIF (НЗОК).
    /// </summary>
    public string NhifCode { get; set; }

    /// <summary>
    /// Code according to NHIS (НЗИС) set CL022.
    /// </summary>
    public string NhisCode { get; set; }

    /// <summary>
    /// Name of product according to NHIF (НЗОК).
    /// </summary>
    public string Name { get; set; }

}
