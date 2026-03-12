using System;

namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Represents a single laboratory order.
/// </summary>
/// <remarks>
/// This claass is an abstraction over LIS iLab Sale.
/// </remarks>
public class VisitOrder
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Date/time the visit was created.
    /// </summary>
    public DateTime Date { get; set; }

}
