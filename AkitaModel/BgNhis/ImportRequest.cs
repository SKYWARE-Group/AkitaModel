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
    /// Location Id.
    /// </summary>
    public string LocationId { get; set; }

    /// <summary>
    /// Application user.
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// Collection of referrals to be imported.
    /// </summary>
    public ReferralImportReqest[] Referrals { get; set; } = [];

}
