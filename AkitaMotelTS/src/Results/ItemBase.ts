/**
 * Skyware.Lis.AkitaModel.Results
 */

/**
 * Base class for items in the results or sale.
 */
export abstract class ItemBase {
  /**
   * PK of the item in LIS iLab.
   */
  id!: number;

  /**
   * FK of the product in LIS iLab (test or panel/profile).
   */
  productId?: number;

  /**
   * Name of the item.
   */
  name: string = '';

  /**
   * Rank of the item, use it for sorting.
   */
  rank!: number;
}
