namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Represents symbols to be shown or printed for abnormal results.
/// </summary>
public class FlagType
{

    /// <summary>
    /// The value when the result is below the scale, e.g. &quot;&lt;&lt;&quot;.
    /// </summary>
    public string BelowScale { get; set; }

    /// <summary>
    /// The value when the result is below alarm 2, e.g. &quot;↓↓↓&quot;.
    /// </summary>
    /// <remarks>
    /// This value corresponds to <see cref="FlagLevels.ULTRA_LOW"/>.
    /// </remarks>
    public string UltraLow { get; set; }

    /// <summary>
    /// The value when the result is below alarm 1, e.g. &quot;↓↓&quot;.
    /// </summary>
    /// <remarks>
    /// This value corresponds to <see cref="FlagLevels.VERY_LOW"/>.
    /// </remarks>
    public string VeryLow { get; set; }

    /// <summary>
    /// The value when the result is below the reference range, e.g. &quot;↓&quot;.
    /// </summary>
    /// <remarks>
    /// This value corresponds to <see cref="FlagLevels.LOW"/>.
    /// </remarks>
    public string Low { get; set; }

    /// <summary>
    /// The value when the result is above the reference range, e.g. &quot;↑&quot;.
    /// </summary>
    /// <remarks>
    /// This value corresponds to <see cref="FlagLevels.HIGH"/>.
    /// </remarks>
    public string High { get; set; }

    /// <summary>
    /// The value when the result is above alarm 1, e.g. &quot;↑↑&quot;.
    /// </summary>
    /// <remarks>
    /// This value corresponds to <see cref="FlagLevels.VERY_HIGH"/>.
    /// </remarks>
    public string VeryHigh { get; set; }

    /// <summary>
    /// The value when the result is above alarm 2, e.g. &quot;↑↑↑&quot;.
    /// </summary>
    /// <remarks>
    /// This value corresponds to <see cref="FlagLevels.ULTRA_HIGH"/>.
    /// </remarks>
    public string UltraHigh { get; set; }

    /// <summary>
    /// The value when the result is above the scale, e.g. &quot;&gt;&gt;&quot;.
    /// </summary>
    public string AboveScale { get; set; }

    /// <summary>
    /// Convenience method to get the flag for the given level.
    /// </summary>
    /// <param name="flagLevel">Result flag level</param>
    /// <returns>Flag to be shown/printed</returns>
    public string GetFlag(FlagLevels flagLevel) =>  flagLevel switch
    {
        FlagLevels.ULTRA_LOW => UltraLow,
        FlagLevels.VERY_LOW => VeryLow,
        FlagLevels.LOW => Low,
        FlagLevels.HIGH => High,
        FlagLevels.VERY_HIGH => VeryHigh,
        FlagLevels.ULTRA_HIGH => UltraHigh,
        _ => string.Empty
    };

}