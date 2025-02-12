using System;

namespace Skyware.Lis.AkitaModel.Portal;

/// <summary>
/// Patient visit.
/// </summary>
/// <remarks>
/// This class is intended to be used in the portal or similar scenarios.
/// It contains minimum properties and is intended to be used in lists and tables.
/// </remarks>
public class Visit : VisitBase
{

    /// <summary>
    /// Total number of ordered tests.
    /// </summary>
    public int TotalTests { get; set; }

    /// <summary>
    /// Number of completed tests.
    /// </summary>
    public int ReadyTests { get; set; }

    /// <summary>
    /// Number of flagged tests.
    /// </summary>
    /// <remarks>
    /// The value here counts only already flagged tests. 
    /// It does not include tests that could be flagged on the fly.
    /// </remarks>
    public int FlaggedTests { get; set; }

    /// <summary>
    /// Percent of completed tests.
    /// </summary>
    public int PercentReady => TotalTests == 0 ? 100 : (int)Math.Floor(((double)ReadyTests / TotalTests * 100));

    /// <summary>
    /// Degree of readiness from 0 (none) to 5 (complete).
    /// </summary>
    public int DegreeOfReadiness5 => TotalTests == 0 ? 5 : Math.Min(5, (int)Math.Floor((double)ReadyTests / TotalTests * 5));

    /// <summary>
    /// Degree of readiness from 0 (none) to 8 (complete).
    /// </summary>
    public int DegreeOfReadiness8 => TotalTests == 0 ? 8 : Math.Min(8, (int)Math.Floor((double)ReadyTests / TotalTests * 8));

}
