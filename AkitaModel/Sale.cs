using System;
using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Visit, laboratory order.
/// </summary>
public class Sale
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Reference to an external system.
    /// </summary>
    public string ExternalId { get; set; } = string.Empty;

    /// <summary>
    /// Date and time the visit was registered.
    /// </summary>
    public DateTime? Registered { get; set; }

    /// <summary>
    /// Patient.
    /// </summary>
    public Patient Patient { get; set; }

    /// <summary>
    /// FK to sale schema.
    /// </summary>
    public int? SchemaId { get; set; }

    /// <summary>
    ///  Sale schema name.
    /// </summary>
    public string SchemaName { get; set; } = string.Empty;

    /// <summary>
    /// FK to location where registration was made.
    /// </summary>
    public int? LocationId { get; set; }

    /// <summary>
    /// Custom field #1.
    /// </summary>
    public string Field1 { get; set; } = string.Empty;

    /// <summary>
    /// Custom field #2.
    /// </summary>
    public string Field2 { get; set; } = string.Empty;

    /// <summary>
    /// Custom field #3.
    /// </summary>
    public string Field3 { get; set; } = string.Empty;

    /// <summary>
    /// Priority
    /// </summary>
    public bool? IsStat { get; set; }

    /// <summary>
    /// Referring doctor.
    /// </summary>
    public Doctor Doctor { get; set; }

    /// <summary>
    /// Visit's examinations.
    /// </summary>
    public IList<SaleItem> Items { get; set; }

    /// <summary>
    /// Samples to the visit.
    /// </summary>
    public IList<Sample> Samples { get; set; }

    /// <summary>
    /// Name of first fund
    /// </summary>
    public string Fund1Name { get; set; }

    /// <summary>
    /// Name of second fund
    /// </summary>
    public string Fund2Name { get; set; }

    // public List<Note>? Notes { get; set; }

}
