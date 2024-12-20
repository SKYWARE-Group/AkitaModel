namespace Skyware.Lis.AkitaModel.Results {
  /**
   * Base class for items in the results or sale.
   */
  export abstract class ItemBase {
    /**
     * PK of the item in LIS iLab.
     */
    public Id: number;

    /**
     * FK of the product in LIS iLab (test or panel/profile).
     */
    public ProductId?: number;

    /**
     * Name of the item.
     */
    public Name: string = "";

    /**
     * Rank of the item, use it for sorting.
     */
    public Rank: number;
  }
}

export { Skyware.Lis.AkitaModel.Results.ItemBase };
