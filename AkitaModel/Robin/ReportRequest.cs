// Ignore Spelling: bg

namespace Skyware.Lis.AkitaModel.Robin;

/// <summary>
/// Payload class for report generation.
/// </summary>
public class ReportRequest
{

    /// <summary>
    /// Culture (Locale) of the report, e.g. "en-US", "bg-BG", etc.
    /// </summary>
    /// <remarks>
    /// This field is optional and if it isn't provided, server's default will be applied.
    /// </remarks>
    public string Culture { get; set; }

    /// <summary>
    /// <b>Base64 encoded JSON</b> collection of parameters.
    /// </summary>
    /// <remarks>
    /// JSON before Base64 encoding is a key-value pair dictionary and looks like this:
    /// <code>
    /// {
    ///   "key1": "value1",
    ///   "key2": 2,
    ///   "key3": 3.14
    /// }
    /// </code>
    /// This field is optional.
    /// </remarks>
    public string Parameters { get; set; }

    /// <summary>
    /// <b>Base64 encoded JSON</b> with data source.
    /// </summary>
    /// <remarks>
    /// Consult the report's source for the model.
    /// This field is optional.
    /// </remarks>
    public string Data { get; set; }

}
