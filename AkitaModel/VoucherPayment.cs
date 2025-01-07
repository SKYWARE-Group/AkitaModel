namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Represents a payment made with a voucher.
/// </summary>
public class VoucherPayment : PaymentBase
{

    /// <inheritdoc />
    public override PaymentMethod Method => PaymentMethod.Voucher;

    /// <summary>
    /// Voucher serial number used for the payment.
    /// </summary>
    public string VoucherNumber { get; set; }

}
