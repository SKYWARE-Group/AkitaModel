package skyware.lis.akitamodel;

/**
 * Represents a cash payment.
 */
public class CashPayment extends PaymentBase {

    /**
     * Returns the payment method as CASH.
     *
     * @return the payment method.
     */
    @Override
    public PaymentMethod getMethod() {
        return PaymentMethod.CASH;
    }
    
}
