namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Uniform plugin information.
/// </summary>
/// <remarks>
/// The standard path for this resource should be /api/service/info
/// </remarks>
public class Plugin
{

    /// <summary>
    /// Name of the plugin, e.g. "Akita Core", "Robin", etc.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Description, may contain html tags, e.g. "&lt;b&gt;", "&lt;a&gt;" etc.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Semantic version, e.g. "1.0.5".
    /// </summary>
    /// <remarks>
    /// Please, use reflection or similar approach to extract the version.
    /// </remarks>
    public string Version { get; set; }

    /// <summary>
    /// Optional. URL of documentation.
    /// </summary>
    public string HelpLink { get; set; }

}
