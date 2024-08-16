namespace Skyware.Lis.AkitaModel.BgNhis;

// Ignore Spelling: lis

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
    /// Flag, indicating ordering rules of NHIF (високо-специализирано изследване, ВСД)
    /// </summary>
    public bool IsSpecialized { get; set; }

    /// <summary>
    /// Code according to NHIS (НЗИС) set CL022.
    /// </summary>
    public string NhisCode { get; set; }

    /// <summary>
    /// Name of product according to NHIF (НЗОК).
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Mapped LOINC code, according to this laboratory
    /// </summary>
    public string LoincCode { get; set; }

    /// <summary>
    /// Id of the corresponding LIS test
    /// </summary>
    public int? TestId { get; set; }

    /// <summary>
    /// Id of the corresponding LIS profile/panel
    /// </summary>
    public int? ProfileId { get; set; }

    /// <summary>
    /// Examination name, according to laboratory
    /// </summary>
    public string LisName { get; set; }

}
