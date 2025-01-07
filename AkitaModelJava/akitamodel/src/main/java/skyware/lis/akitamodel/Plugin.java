package skyware.lis.akitamodel;

import lombok.Data;

/**
 * Uniform plugin information.
 * <p>
 * The standard path for this resource is {@code /api/service/info}.
 * </p>
 */
@Data
public class Plugin {

    /**
     * Name of the plugin, e.g., "Akita Core", "Robin", etc.
     */
    private String name;

    /**
     * Description, may contain HTML tags, e.g., {@code <b>}, {@code <a>}, etc.
     */
    private String description;

    /**
     * Semantic version, e.g., "1.0.5".
     * <p>
     * Please, use reflection or a similar approach to extract the version.
     * </p>
     */
    private String version;

    /**
     * Optional. URL of documentation.
     */
    private String helpLink;

}

