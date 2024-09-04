namespace Skyware.Lis.AkitaModel.Flagging;

/// <summary>
/// Represents answer from the flagging service when result flag is requested.
/// </summary>
public class ResultResponse
{

    /// <summary>
    /// Default c-tor.
    /// </summary>
    public ResultResponse() { }

    /// <summary>
    /// Convenience c-tor.
    /// </summary>
    /// <param name="referenceId"></param>
    public ResultResponse(string referenceId) : this()
    {
        RefId = referenceId;
    }

    /// <summary>
    /// Calculation result <see cref="CalculationResult"/>.
    /// </summary>
    public CalculationResult CalculationResult { get; set; }

    /// <summary>
    /// If any error occurred when the result is flagged it will be written here.
    /// </summary>
    public string Error { get; set; }

    /// <summary>
    /// Reference like SaleItemId etc.
    /// </summary>
    public string RefId { get; set; }

}
