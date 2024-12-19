namespace Skyware.Lis.AkitaModel.Results {

    /**
     * Base class for items in the results or sale.
     */
    export abstract class ItemBase {

        /**
         * PK of the item in LIS iLab.
         */
        public id: number;

        /**
         * FK of the product in LIS iLab (test or panel/profile).
         */
        public productId?: number;

        /**
         * Name of the item.
         */
        public name: string = '';

        /**
         * Rank of the item, use it for sorting.
         */
        public rank: number;

    }

}
