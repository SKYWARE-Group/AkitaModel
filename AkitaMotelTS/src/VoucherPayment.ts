/**
 * Skyware.Lis.AkitaModel
 */

import { PaymentBase } from './PaymentBase';
import { PaymentMethod } from './PaymentMethod';

/**
 * Represents a payment made with a voucher.
 */
export class VoucherPayment extends PaymentBase {
  /** @inheritdoc */
  get method(): PaymentMethod {
    return PaymentMethod.Voucher;
  }

  /**
   * Voucher serial number used for the payment.
   */
  voucherNumber?: string;
}
