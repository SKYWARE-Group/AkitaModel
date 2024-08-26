namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Abstract class for people.
/// </summary>
public abstract class PersonBase
{

    /// <summary>
    /// PK.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Given (first) name.
    /// </summary>
    public string GivenName { get; set; } = string.Empty;

    /// <summary>
    /// Middle (second) name.
    /// </summary>
    public string MiddleName { get; set; }

    /// <summary>
    /// Family name (surname, last name).
    /// </summary>
    public string FamilyName { get; set; } = string.Empty;

}
