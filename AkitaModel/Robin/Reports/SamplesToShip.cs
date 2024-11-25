namespace Skyware.Lis.AkitaModel.Robin.Reports;

/// <summary>
/// Data of samples to ship
/// </summary>
public class SamplesToShip
{
#nullable enable

    /// <summary>
    /// Barcode
    /// </summary>
    public string? Barcode { get; set; }

    /// <summary>
    /// Kind of sample 
    /// </summary>
    public string? SampleTypeName { get; set; }

    /// <summary>
    /// Date taken
    /// </summary>
    public string? DateTaken { get; set; }

    /// <summary>
    /// Visit / Sale id
    /// </summary>
    public int? VisitID { get; set; }

    /// <summary>
    /// Patient information
    /// </summary>
    public string? PatInfo { get; set; }

    /// <summary>
    /// Patient is male
    /// </summary>
    public bool? PatientIsMale { get; set; }
}