using System;

namespace Skyware.Lis.AkitaModel.Courier;


/// <summary>
/// Communication channel.
/// </summary>
public class Channel
{

    /// <summary>
    /// PK.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Human-friendly name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Filtering parameter. If null - any schema.
    /// </summary>
    public int? SchemaId { get; set; }

    /// <summary>
    /// Filtering parameter. If null - any fund.
    /// </summary>
    public int? FundId { get; set; }

    public string FilterScript { get; set; }

    public string Dialect { get; set; }

    public object DialectParams { get; set; }

    public string Transport { get; set; }

    public object TransportParams { get; set; }

    public string Target { get; set; }

    public object TargetParams { get; set; }

    public bool IsActive { get; set; } = true;

    /// <summary>
    /// API key for HTTP GET transport.
    /// </summary>
    public string ApiKeyGet { get; set; }

    public DateTime Created { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Creation time as local date/time.
    /// </summary>
    public DateTime CreatedLocalTime => Created.ToLocalTime();

    public DateTime? Modified { get; set; }

    /// <summary>
    /// Modification time as local date/time.
    /// </summary>
    public DateTime? ModifiedLocalTime => Modified?.ToLocalTime();

}
