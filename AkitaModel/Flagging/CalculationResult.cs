namespace Skyware.Lis.AkitaModel.Flagging;

/// <summary>
/// Represents result received from the flagging API
/// </summary>
public class CalculationResult
{

    /// <summary>
    /// Text representation of the results as it would be printed, shown on screen, etc.
    /// </summary>
    public string TextResult { get; set; } = string.Empty;

    /// <summary>
    /// Number prefix, e.g. "&lt;", "&gt;&gt;", "&gt;=", etc.
    /// </summary>
    public string Prefix { get; set; }

    /// <summary>
    /// Decimal representation (if available).
    /// </summary>
    public decimal? DecimalResult { get; set; } = null;

    /// <summary>
    /// Flag level of the result <see cref="FlagLevels"/>
    /// </summary>
    public FlagLevels FlagLevel { get; set; } = FlagLevels.NONE;

    /// <summary>
    /// Flag, e.g. "↑", "↓↓", "3+", etc.
    /// </summary>
    public string Flag { get; set; }

}
