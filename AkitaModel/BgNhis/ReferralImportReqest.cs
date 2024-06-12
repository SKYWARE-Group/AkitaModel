using System;

// Ignore Spelling: nrn

namespace Skyware.Lis.AkitaModel.BgNhis;

/// <summary>
/// Referral import request.
/// </summary>
public class ReferralImportRequest
{
    /// <summary>
    /// National Reference Number in NHIS (НРН в НЗИС).
    /// </summary>
    public string Nrn { get; set; }

    /// <summary>
    /// Visit date
    /// </summary>
    public DateTime VisitDate { get; set; } = DateTime.Today;

    /// <summary>
    /// Sample date
    /// </summary>
    public DateTime SampleDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Result date
    /// </summary>
    public DateTime ResultsDate { get; set; } = DateTime.Today;

    /// <summary>
    /// Nhif contract
    /// </summary>
    public NhifContract NhifContract { get; set; }

}
