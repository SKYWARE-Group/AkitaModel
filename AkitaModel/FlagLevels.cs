namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Possible flag levels.
/// </summary>
public enum FlagLevels : byte
{

    /// <summary>
    /// Ultra low results (below alarm 2).
    /// </summary>
    ULTRA_LOW = 1,

    /// <summary>
    /// Very low results (below alarm 1).
    /// </summary>
    VERY_LOW = 2,

    /// <summary>
    /// Low results (below reference range).
    /// </summary>
    LOW = 3,

    /// <summary>
    /// No flag.
    /// </summary>
    NONE = 4,

    /// <summary>
    /// High results (above reference range).
    /// </summary>
    HIGH = 5,

    /// <summary>
    /// Very high results (above alarm 1).
    /// </summary>
    VERY_HIGH = 6,

    /// <summary>
    /// Ultra high results (above alarm 2).
    /// </summary>
    ULTRA_HIGH = 7,

    /// <summary>
    /// Abnormal non-numeric result.
    /// </summary>
    WITH_STAR = 10,

    /// <summary>
    /// Semi-quantitative result within gray zone.
    /// </summary>
    SEMI_QUANT_QUESTION = 11,

}
