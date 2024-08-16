namespace Skyware.Lis.AkitaModel.BgNhis;

/// <summary>
/// Medical practice, registered in Bulgaria.
/// </summary>
public class Practice
{

    /// <summary>
    /// Practice number (РЦЗ/РЗИ код) of the laboratory, mandatory.
    /// </summary>
    public string PracticeNumber { get; set; } = string.Empty;

    /// <summary>
    /// NHIF number of the practice (НЗОК номер), optional.
    /// </summary>
    public string NhifNumber { get; set; }

    /// <summary>
    /// Laboratory name, optional.
    /// </summary>
    public string Name { get; set; }

}
