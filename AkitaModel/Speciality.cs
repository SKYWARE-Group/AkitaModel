namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Medical speciality of a doctor, e.g. General practitioner, Surgeon, etc.
/// </summary>
public class Speciality
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Name of the speciality.
    /// </summary>
    public string Name { get; set; }

}
