namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Sample to be examined.
/// </summary>
public class Sample : SampleBase
{

    /// <summary>
    /// FK to other sample, in case of aliquot or otherwise sample derivate.
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// FK to Sale/Visit.
    /// </summary>
    public int? SaleId { get; set; }

    /// <summary>
    /// FK to Location where sample is located currently.
    /// </summary>
    public int? CurrentLocationId { get; set; }

    /// <summary>
    /// List of codes printed on sample label, e.g. "BC->MIC->RET". 
    /// Should be printed on sample label.
    /// </summary>
    public string ProcessingPoints { get; set; }


}
