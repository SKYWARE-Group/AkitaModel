using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Robin.Reports;

/// <summary>
/// Data model for report "Laboratory results". 
/// </summary>
public class LaboratoryResults
{
    /// <summary>
    /// Sale/Visit data.
    /// </summary>
    public Sale Visit { get; set; }

    /// <summary>
    /// Patient data
    /// </summary>
    public Patient Patient { get; set; }

    /// <summary>
    /// Doctors data
    /// </summary>
    public IList<Doctor> ReferringDoctors { get; set; } = [];

    /// <summary>
    /// List of results
    /// </summary>
    public IList<SaleItem> Results { get; set; } = [];

    /// <summary>
    /// Footnotes list.
    /// </summary>
    public IList<Footnote> Footnotes { get; set; } = [];

}
