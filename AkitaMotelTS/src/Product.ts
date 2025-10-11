/**
 * Skyware.Lis.AkitaModel
 */

/**
 * Price list entry.
 */
export class Product {
  id!: number;
  departmentId!: number;
  rank?: number;
  testId?: number;
  profileId?: number;
  loincCode?: string;
  name?: string;
  price!: number;
  priceText?: string;
}
