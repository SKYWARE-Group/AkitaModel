/**
 * Skyware.Lis.AkitaModel
 */

import { PaymentBase } from './PaymentBase';
import { PaymentMethod } from './PaymentMethod';

export class CashPayment extends PaymentBase {
  /** @inheritdoc */
  get method(): PaymentMethod {
    return PaymentMethod.Cash;
  }
}
