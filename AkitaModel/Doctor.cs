namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Doctor
/// </summary>
public class Doctor : PersonBase
{

    /// <summary>
    /// Uin
    /// </summary>
    public string Uin { get; set; } = string.Empty;

    /// <summary>
    /// Title, e.g. "Dr.", "Prof.", etc.
    /// </summary>
    public string? Title {  get; set; } = string.Empty;

    /// <summary>
    /// Speciality
    /// </summary>
    public Speciality Speciality { get; set; }

    /// <summary>
    /// Region
    /// </summary>
    public string? Region { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Postal code
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Post address
    /// </summary>
    public string? PostAddress { get; set; }
}
