namespace Skyware.Lis.AkitaModel.Flagging;

/// <summary>
/// Result types.
/// </summary>
public enum ResultTypes : byte
{
    /// <summary>
    /// Textual result.
    /// </summary>
    Text = 4,
    
    /// <summary>
    /// Numeric result, usually represents concentration.
    /// </summary>
    Quantitative = 1,

    /// <summary>
    /// Semi-quantitative, cut-off result.
    /// </summary>
    SemiQuantitative = 5,

    /// <summary>
    /// Ratio, such as 1:2, 2:16, 3:5, etc.
    /// </summary>
    Ratio = 2,

    /// <summary>
    /// Value amongst list of allowed values.
    /// </summary>
    List = 3,

}
