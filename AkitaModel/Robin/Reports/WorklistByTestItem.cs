namespace Skyware.Lis.AkitaModel.Robin.Reports;

/// <summary>
/// Data item for report "Pending by test".
/// </summary>
public class WorklistByTestItem
{
    /// <summary>
    /// Sample barkod or Visit Id.
    /// </summary>
    public string SampleVisitId { get; set; } = string.Empty;

    /// <summary>
    /// Patient data.
    /// </summary>
    public string PatientInfo { get; set; } = string.Empty;

    /// <summary>
    /// Gender indicator.
    /// </summary>
    public bool? IsMale { get; set; } = null;
}
