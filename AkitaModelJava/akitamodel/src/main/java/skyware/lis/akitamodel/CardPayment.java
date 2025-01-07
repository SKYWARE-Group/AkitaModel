package skyware.lis.akitamodel;

import lombok.Data;
import lombok.EqualsAndHashCode;

/**
 * Represents a card payment.
 */
@Data
@EqualsAndHashCode(callSuper = true)
public class CardPayment extends PaymentBase {

    /**
     * Returns the payment method as CARD.
     *
     * @return the payment method.
     */
    @Override
    public PaymentMethod getMethod() {
        return PaymentMethod.CARD;
    }

    /**
     * Card number (masked) used for the payment.
     */
    private String cardNumber;
    
}
