namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Allowed result entry.
/// </summary>
public class ResultEntry
{

    /// <summary>
    /// Allowed value of the result.
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Corresponding flag for this value.
    /// </summary>
    public FlagLevels FlagLevel { get; set; } = FlagLevels.NONE;

}
