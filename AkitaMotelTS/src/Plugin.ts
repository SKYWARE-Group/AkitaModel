/**
 * Skyware.Lis.AkitaModel
 */

/**
 * Uniform plugin information.
 * @remarks
 * The standard path for this resource is /api/service/info.
 */
export class Plugin {
  /**
   * Name of the plugin, e.g. "Akita Core", "Robin", etc.
   */
  name?: string;

  /**
   * Description, may contain html tags, e.g. "<b>", "<a>" etc.
   */
  description?: string;

  /**
   * Semantic version, e.g. "1.0.5".
   * @remarks
   * Please, use reflection or similar approach to extract the version.
   */
  version?: string;

  /**
   * Optional. URL of documentation.
   */
  helpLink?: string;
}
