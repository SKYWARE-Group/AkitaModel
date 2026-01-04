/**
 * Skyware.Lis.AkitaModel.Results
 */

import { VisitBase } from '../VisitBase';
import { VisitSale } from './VisitSale';

/**
 * Represents a Visit view with structure for bill reporting.
 */
export class VisitBalance extends VisitBase {
  /**
   * List of sales.
   */
  sales?: VisitSale[];

  /**
   * Balance of the visit.
   */
  get balance(): number {
    return this.sales?.reduce((sum, s) => sum + s.balance, 0) ?? 0;
  }
}
