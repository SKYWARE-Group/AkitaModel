// Ignore Spelling: uin

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Doctor.
/// </summary>
public class Doctor : PersonBase
{

    /// <summary>
    /// Unique Identification Number. Provided by healthcare authorities, jurisdiction dependent.
    /// </summary>
    public string Uin { get; set; }

    /// <summary>
    /// Title, e.g. "Dr.", "Prof.", etc.
    /// </summary>
    public string Title {  get; set; }

    /// <summary>
    /// Speciality
    /// </summary>
    public Speciality Speciality { get; set; }

    /// <summary>
    /// Region
    /// </summary>
    public string Region { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Postal code
    /// </summary>
    public string PostalCode { get; set; }

    /// <summary>
    /// Business address, usually same as practice address.
    /// </summary>
    public string PostAddress { get; set; }

    /// <summary>
    /// Doctor's information (last name, title, first name, speciality name and job place)
    /// </summary>
    public string DisplayName {  get; set; }

}
