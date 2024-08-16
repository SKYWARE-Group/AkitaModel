namespace Skyware.Lis.AkitaModel;

/// <summary>
/// API error. Usually sent as content in case of non-success HTTP codes, such as 500, 404, etc.
/// </summary>
public class ApiError
{

    /// <summary>
    /// Correlation Identifier.
    /// </summary>
    public string CorrelationId { get; set; }

    /// <summary>
    /// Reason of the error.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Detailed information, e.g. exception stack.
    /// </summary>
    public string Details { get; set; }

}
