namespace Skyware.Lis.AkitaModel.BgNhis;

/// <summary>
/// Request for NHIS referrals import.
/// </summary>
public class ImportRequest
{
    /// <summary>
    /// Name of requesting application.
    /// </summary>
    public string ApplicationName { get; set; }

    /// <summary>
    /// Proc points location id
    /// </summary>
    public string? ProcPointLocationId { get; set; }

    /// <summary>
    /// Schema
    /// </summary>
    public Schema? Schema { get; set; }

    /// <summary>
    /// Reg location id
    /// </summary>
    public string? RegLocationId { get; set; }

    /// <summary>
    /// Location Id.
    /// </summary>
    public string? LocationId { get; set; }

    /// <summary>
    /// Application user.
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// Collection of referrals to be imported.
    /// </summary>
    public ReferralImportRequest[] Referrals { get; set; } = [];

}
