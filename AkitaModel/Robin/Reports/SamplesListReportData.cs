using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Robin.Reports;

/// <summary>
/// "SamplesList" report data
/// </summary>
public class SamplesListReportData
{
#nullable enable

    /// <summary>
    /// Samples to ship
    /// </summary>
    public List<SamplesToShip>? Samples { get; set; }

    /// <summary>
    /// Summary
    /// </summary>
    public List<SamplesSummary>? SamplesSummary { get; set; }
}