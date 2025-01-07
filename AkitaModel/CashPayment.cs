namespace Skyware.Lis.AkitaModel;

public class CashPayment : PaymentBase
{

    /// <inheritdoc />
    public override PaymentMethod Method => PaymentMethod.Cash;

}
