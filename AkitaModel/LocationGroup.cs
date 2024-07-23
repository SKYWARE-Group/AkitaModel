namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Represents group where <see cref="Location"/> belongs to
/// </summary>
public class LocationGroup
{
    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the group
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Rank of the group
    /// </summary>
    public int Rank { get; set; }
}
