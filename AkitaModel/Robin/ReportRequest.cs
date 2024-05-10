// Ignore Spelling: bg

namespace Skyware.Lis.AkitaModel.Robin;

/// <summary>
/// Payload class for report generation.
/// </summary>
public class ReportRequest
{

    /// <summary>
    /// Culture of the report, e.g. "en-US", "bg-BG", etc.
    /// </summary>
    public string Culture { get; set; }

    /// <summary>
    /// Base64 encoded JSON collection of parameters.
    /// </summary>
    /// <remarks>
    /// JSON before Base64 encoding must be like this:
    /// <code>
    /// {
    ///   "key1": "value1",
    ///   "key2": 2,
    ///   "key3": 3.14
    /// }
    /// </code>
    /// </remarks>
    public string Parameters { get; set; }

    /// <summary>
    /// Base64 encoded JSON with data source.
    /// </summary>
    /// <remarks>
    /// Consult the report's source for JSON before Base64 encoding.
    /// </remarks>
    public string Data { get; set; }

}
