namespace Skyware.Lis.AkitaModel;

public class CardPayment : PaymentBase
{

    /// <inheritdoc />
    public override PaymentMethod Method => PaymentMethod.Card;

    /// <summary>
    /// Card number (masked) used for the payment.
    /// </summary>
    public string CardNumber { get; set; }

}

