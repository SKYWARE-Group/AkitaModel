using Skyware.Lis.AkitaModel.Helpers;

namespace Skyware.Lis.AkitaModel.Robin.Reports;

/// <summary>
/// Data model for report "Pending by test".
/// </summary>
public class WorklistByTest : IReportDataObject
{

    /// <summary>
    /// Sample barkod or Visit Id.
    /// </summary>
    public string SampleVisitId { get; private set; } = string.Empty;

    /// <summary>
    /// Patient data.
    /// </summary>
    public string PatientInfo { get; private set; } = string.Empty;

    /// <summary>
    /// Gender indicator.
    /// </summary>
    public bool? IsMale { get; set; } = null;

    /// <inheritdoc/>
    public string GetBase64Data() => Base64Helper.GetBase64Data(this);

}
