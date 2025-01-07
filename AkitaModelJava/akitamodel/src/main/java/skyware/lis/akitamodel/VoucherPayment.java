package skyware.lis.akitamodel;

import lombok.Data;
import lombok.EqualsAndHashCode;

/**
 * Represents a payment made with a voucher.
 */
@Data
@EqualsAndHashCode(callSuper = true)
public class VoucherPayment extends PaymentBase {

    /**
     * Returns the payment method as VOUCHER.
     *
     * @return the payment method.
     */
    @Override
    public PaymentMethod getMethod() {
        return PaymentMethod.VOUCHER;
    }

    /**
     * Voucher serial number used for the payment.
     */
    private String voucherNumber;
    
}
