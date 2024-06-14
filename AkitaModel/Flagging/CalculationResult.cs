namespace Skyware.Lis.AkitaModel.Flagging;

/// <summary>
/// Represents result received from the flagging API
/// </summary>
public class CalculationResult
{
    /// <summary>
    /// Text representation
    /// </summary>
    public string TextResult { get; set; } = string.Empty;

    /// <summary>
    /// Decimal representation if it is available
    /// </summary>
    public decimal? DecimalResult { get; set; } = null;

    /// <summary>
    /// Flag level of the result <see cref="FlagLevels"/>
    /// </summary>
    public FlagLevels FlagLevel { get; set; } = FlagLevels.NONE;

}
