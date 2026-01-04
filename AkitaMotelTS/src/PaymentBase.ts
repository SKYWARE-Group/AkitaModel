/**
 * Skyware.Lis.AkitaModel
 */

import { PaymentMethod } from './PaymentMethod';

/**
 * Base (abstract) class for payments.
 */
export abstract class PaymentBase {
  /**
   * PK of the item in LIS iLab.
   */
  id!: number;

  /**
   * Date/time the payment was made.
   */
  date!: Date;

  /**
   * Payment method.
   */
  abstract get method(): PaymentMethod;

  /**
   * Amount of the payment.
   */
  amount!: number;
}
