using Skyware.Lis.AkitaModel.Helpers;
using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Robin.Reports;

/// <summary>
/// Data model for report "Pending by test".
/// </summary>
public class WorklistByTest : IReportDataObject
{
    /// <summary>
    /// Report parameter key (RPK) for "Title"
    /// Test name
    /// </summary>
    public const string RPK_TITLE = "Title";

    /// <summary>
    /// 
    /// </summary>
    public List<WorklistByTestItem> Items { get; set; } = [];

    /// <inheritdoc/>
    public string GetBase64Data() => Base64Helper.GetBase64Data(this);

}
