using System;

namespace Skyware.Lis.AkitaModel.Portal;

/// <summary>
/// Represents a single test result.
/// </summary>
public class TestResult
{

    /// <summary>
    /// Unique identifier of the result (PK).
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Test this result belongs to.
    /// </summary>
    public int SaleId { get; set; }

    /// <summary>
    /// Date/time of the result.
    /// </summary>
    public DateTime ResultTime { get; set; }

    /// <summary>
    /// Result as text.
    /// </summary>
    public string Result { get; set; }

    /// <summary>
    /// Optional, decimal result.
    /// </summary>
    public decimal? NumericResult { get; set; }

    /// <summary>
    /// Flag, according to reference range (1-7, 10, 11).
    /// </summary>
    /// <remarks>
    /// 1=ultra low, 2=very low, 3=low, 5=high, 6=very high, 7=ultra high, 10=star.
    /// 4=no flag. Null means the flag is not calculated.
    /// </remarks>
    public byte? Flag { get; set; }

    /// <summary>
    /// Flag string, e.g. "↑", "↓↓", etc.
    /// </summary>
    public string FlagSymbol { get; set; }

    /// <summary>
    /// Measurement units.
    /// </summary>
    public string Units { get; set; }

    /// <summary>
    /// Reference range (label) for this patient.
    /// </summary>
    public string Range { get; set; }

    /// <summary>
    /// Ready/Pending flag.
    /// </summary>
    public bool? IsReady { get; set; }

}
