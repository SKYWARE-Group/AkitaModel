namespace Skyware.Lis.AkitaModel;

public class Plugin
{

    /// <summary>
    /// Name of the plugin, e.g. "Core", "BgNhis", etc.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Description, may contain html tags, e.g. "&lt;b&gt;", "&lt;a&gt;" etc.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Semantic version, e.g. "1.0.5"
    /// </summary>
    public string Version { get; set; }

}
