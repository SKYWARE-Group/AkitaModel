namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Species, e.g. Human, Dog, Cat, etc.
/// </summary>
public class Species
{

    /// <summary>
    /// Primary key. Value 1 is reserved for "Human".
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the species, e.g. "Human".
    /// </summary>
    public string Name { get; set; }

}
