namespace Skyware.Lis.AkitaModel.BgNhis;

/// <summary>
/// Sale schema.
/// </summary>
public class Schema
{

    /// <summary>
    /// PK in LIS.
    /// </summary>
    public int SchemaId { get; set; }

    /// <summary>
    /// Fund #1 Id.
    /// </summary>
    public int? FundId { get; set; }

    /// <summary>
    /// Fund #2 Id.
    /// </summary>
    public int? Fund2Id { get; set; }

}
