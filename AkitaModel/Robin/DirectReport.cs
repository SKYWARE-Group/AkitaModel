namespace Skyware.Lis.AkitaModel.Robin;

/// <summary>
/// Report definition.
/// </summary>
public class DirectReport
{

    /// <summary>
    /// Identifier of the report (JRXML file name).
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Description of the report.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// True is report is embedded.
    /// </summary>
    public bool? IsExternal { get; set; }

}
