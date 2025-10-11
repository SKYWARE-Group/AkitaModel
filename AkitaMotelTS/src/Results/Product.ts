/**
 * Skyware.Lis.AkitaModel.Results
 */

import { ItemBase } from './ItemBase';

/**
 * Represents a orderable/payable product in Sale.
 */
export class Product extends ItemBase {
  /**
   * Price of the product, payable by the patient.
   */
  price!: number;
}
