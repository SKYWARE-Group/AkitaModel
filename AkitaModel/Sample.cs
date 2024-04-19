using System;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Sample to be examined.
/// </summary>
public class Sample
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// FK to other sample, in case of aliquot or otherwise sample derivate.
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// FK to Sale/Visit.
    /// </summary>
    public int? SaleId { get; set; }

    // public int? SampleTypeId { get; set; }

    /// <summary>
    /// Type of the sample.
    /// </summary>
    public SampleType SampleType { get; set; }

    /// <summary>
    /// Barcode on the label.
    /// </summary>
    public string Barcode { get; set; }

    /// <summary>
    /// Date and time the sample was taken.
    /// </summary>
    public DateTime? Taken { get; set; }

    /// <summary>
    /// FK to Location where sample is located currently.
    /// </summary>
    public int? CurrentLocationId { get; set; }

    /// <summary>
    /// List of codes printed on sample label, e.g. "BC->MIC->RET". 
    /// Should be printed on sample label.
    /// </summary>
    public string ProcessingPoints { get; set; }

    //public object Created { get; set; }


}
