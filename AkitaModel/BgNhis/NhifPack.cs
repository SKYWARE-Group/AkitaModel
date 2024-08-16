using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.BgNhis;

/// <summary>
/// NHIF (НЗОК) пакет дейности
/// </summary>
public class NhifPack
{

    /// <summary>
    /// NHIF (НЗОК) code.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// Name, according to NHIF (НЗОК).
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Examinations (Изследвания)
    /// </summary>
    public IList<Examination> Examinations { get; set; }

}
