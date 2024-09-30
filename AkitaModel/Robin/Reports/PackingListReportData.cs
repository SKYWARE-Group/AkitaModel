using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Robin.Reports;

/// <summary>
/// "PackingList" report data
/// </summary>
public class PackingListReportData
{
#nullable enable

    /// <summary>
    /// Sender and receiver info
    /// </summary>
    public PackingList? SenderAndReceiver { get; set; }

    /// <summary>
    /// Samples to ship
    /// </summary>
    public List<SamplesToShip>? SamplesToShip { get; set; }

    /// <summary>
    /// Summary
    /// </summary>
    public List<SamplesSummary>? SamplesSummary { get; set; }
}