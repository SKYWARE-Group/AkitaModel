using System;
using System.Collections.Generic;
using System.Linq;

namespace Skyware.Lis.AkitaModel.Results;

public class VisitSale
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Date/time the sale was created.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// List of billable products.
    /// </summary>
    public IList<Product> Products { get; set; }

    /// <summary>
    /// List of payments for this sale.
    /// </summary>
    public IList<PaymentBase> Payments { get; set; }

    /// <summary>
    /// Total price of the sale.
    /// </summary>
    public decimal Total => Products?.Sum(p => p.Price) ?? 0m;

    /// <summary>
    /// Balance of the sale.
    /// </summary>
    public decimal Balance => Total - (Payments?.Sum(p => p.Amount) ?? 0m);

}
