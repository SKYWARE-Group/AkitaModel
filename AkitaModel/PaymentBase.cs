using System;
using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Base (abstract) class for payments.
/// </summary>
[JsonDerivedType(typeof(CashPayment))]
[JsonDerivedType(typeof(CardPayment))]
[JsonDerivedType(typeof(VoucherPayment))]
public abstract class PaymentBase
{

    /// <summary>
    /// PK of the item in LIS iLab.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Date/time the payment was made.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Payment method.
    /// </summary>
    public abstract PaymentMethod Method { get; }

    /// <summary>
    /// Amount of the payment.
    /// </summary>
    public decimal Amount { get; set; }

}
