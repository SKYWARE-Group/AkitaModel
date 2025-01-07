using System.Collections.Generic;
using System.Linq;

namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Represents a Visit view with structure for bill reporting.
/// </summary>
public class VisitBalance : VisitBase
{

    /// <summary>
    /// List of sales.
    /// </summary>
    public IList<VisitSale> Sales { get; set; }

    /// <summary>
    /// Balance of the visit.
    /// </summary>
    public decimal Balance => Sales?.Sum(s => s.Balance) ?? 0m;

}
