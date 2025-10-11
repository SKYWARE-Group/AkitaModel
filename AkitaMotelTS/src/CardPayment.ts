/**
 * Skyware.Lis.AkitaModel
 */

import { PaymentBase } from './PaymentBase';
import { PaymentMethod } from './PaymentMethod';

export class CardPayment extends PaymentBase {
  /** @inheritdoc */
  get method(): PaymentMethod {
    return PaymentMethod.Card;
  }

  /**
   * Card number (masked) used for the payment.
   */
  cardNumber?: string;
}
