package skyware.lis.akitamodel;

import com.fasterxml.jackson.annotation.JsonSubTypes;
import com.fasterxml.jackson.annotation.JsonTypeInfo;
import lombok.Data;

import java.math.BigDecimal;
import java.time.LocalDateTime;

/**
 * Base (abstract) class for payments.
 */
@Data
@JsonTypeInfo(use = JsonTypeInfo.Id.NAME, property = "type")
@JsonSubTypes({
        @JsonSubTypes.Type(value = CashPayment.class, name = "CashPayment"),
        @JsonSubTypes.Type(value = CardPayment.class, name = "CardPayment"),
        @JsonSubTypes.Type(value = VoucherPayment.class, name = "VoucherPayment")
})
public abstract class PaymentBase {

    /**
     * PK of the item in LIS iLab.
     */
    private int id;

    /**
     * Date/time the payment was made.
     */
    private LocalDateTime date;

    /**
     * Payment method.
     */
    public abstract PaymentMethod getMethod();

    /**
     * Amount of the payment.
     */
    private BigDecimal amount;
    
}
