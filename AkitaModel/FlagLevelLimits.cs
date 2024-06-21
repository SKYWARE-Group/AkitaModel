namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Defines limit of flagging, e.g. up to alarm 1.
/// </summary>
public enum FlagLevelLimits : byte
{

    /// <summary>
    /// Do not use flags at all.
    /// </summary>
    NO_FLAG = 0,

    /// <summary>
    /// Up to Alarm 1 - High/Low.
    /// </summary>
    UP_TO_LOW_HIGH = 1,

    /// <summary>
    /// Up to Alarm 2 - Very High/Low.
    /// </summary>
    UP_TO_VERY = 2,

    /// <summary>
    /// Up to Alarm 3 - Ultra High/Low.
    /// </summary>
    UP_TO_ULTRA = 3

}