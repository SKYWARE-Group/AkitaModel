/**
 * Skyware.Lis.AkitaModel.Results
 */

import { PaymentBase } from '../PaymentBase';
import { Product } from './Product';

export class VisitSale {
  /**
   * PK in LIS iLab.
   */
  id!: number;

  /**
   * Date/time the sale was created.
   */
  date!: Date;

  /**
   * List of billable products.
   */
  products?: Product[];

  /**
   * List of payments for this sale.
   */
  payments?: PaymentBase[];

  /**
   * Total price of the sale.
   */
  get total(): number {
    return this.products?.reduce((sum, p) => sum + p.price, 0) ?? 0;
  }

  /**
   * Balance of the sale.
   */
  get balance(): number {
    return this.total - (this.payments?.reduce((sum, p) => sum + p.amount, 0) ?? 0);
  }
}
