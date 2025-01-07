package skyware.lis.akitamodel;

/**
 * Payment method enumeration.
 */
public enum PaymentMethod {
    CASH(1),
    CARD(2),
    VOUCHER(3),
    OTHER(5);

    private final int value;

    PaymentMethod(int value) {
        this.value = value;
    }

    /**
     * Gets the integer value associated with the payment method.
     * 
     * @return the integer value of the payment method.
     */
    public int getValue() {
        return value;
    }
}
