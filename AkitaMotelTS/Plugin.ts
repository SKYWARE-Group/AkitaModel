namespace Skyware.Lis.AkitaModel {

    /**
     * Uniform plugin information.
     * 
     * The standard path for this resource is `/api/service/info`.
     */
    export class Plugin {

        /**
         * Name of the plugin, e.g. "Akita Core", "Robin", etc.
         */
        public name: string;

        /**
         * Description, may contain HTML tags, e.g. `<b>`, `<a>` etc.
         */
        public description: string;

        /**
         * Semantic version, e.g. "1.0.5".
         * 
         * Please, use reflection or similar approach to extract the version.
         */
        public version: string;

        /**
         * Optional. URL of documentation.
         */
        public helpLink?: string;
    }

}
