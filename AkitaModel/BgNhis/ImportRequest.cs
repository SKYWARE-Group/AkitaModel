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
    /// Processing points location Id.
    /// </summary>
    public string ProcPointLocationId { get; set; }

    /// <summary>
    /// Sale schema.
    /// </summary>
    public Schema Schema { get; set; }

    /// <summary>
    /// Reception location Id.
    /// </summary>
    public string RegLocationId { get; set; }

    /// <summary>
    /// Location Id.
    /// </summary>
    public string LocationId { get; set; }

    /// <summary>
    /// Application user.
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// Id of the existing Sale the referrals must be added.
    /// </summary>
    public int? SaleId { get; set; }

    /// <summary>
    /// Collection of referrals to be imported.
    /// </summary>
    public ReferralImportRequest[] Referrals { get; set; } = [];

}
