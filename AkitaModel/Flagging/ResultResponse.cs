namespace Skyware.Lis.AkitaModel.Flagging;

/// <summary>
/// Represents answer from the flagging service when test frag is requested
/// </summary>
public class ResultResponse
{

    public ResultResponse() { }

    public ResultResponse(string referenceId) : this()
    {
        RefId = referenceId;
    }

    /// <summary>
    /// Calculation resul <see cref="CalculationResult"/>
    /// </summary>
    public CalculationResult? CalculationResult { get; set; }

    /// <summary>
    /// If any error occur when the result is flagged it will be written here
    /// </summary>
    public string? Error { get; set; }

    /// <summary>
    /// Reference like SaleItemId etc.
    /// </summary>
    public string RefId { get; set; }

}
