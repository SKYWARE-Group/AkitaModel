using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Examination record - test or panel and its results.
/// </summary>
public class SaleItem
{
 
    /// <summary>
    /// PK of the item in LIS iLab.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// FK to Visit
    /// </summary>
    public int? SaleId { get; set; }

    /// <summary>
    /// FK to Profile/Panel.
    /// </summary>
    public int? ProfileId { get; set; }

    /// <summary>
    /// FK to Test.
    /// </summary>
    public int? TestId { get; set; }

    /// <summary>
    /// FK to Department.
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Department name.
    /// </summary>
    public string DepartmentName { get; set; }

    /// <summary>
    /// Sort order of the department..
    /// </summary>
    public int? DepartmentRank { get; set; }

    /// <summary>
    /// LOINC code.
    /// </summary>
    /// <remarks>
    /// It's laboratory's responsibility to comply with LOINC.
    /// Some laboratories may use other coding systems or private codes as well.
    /// </remarks>
    public string LoincId { get; set; }

    /// <summary>
    /// Name of the test or panel.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Sort order among other items.
    /// </summary>
    public int? Rank { get; set; }

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
    /// Version of the record, updated one every change.
    /// </summary>
    public int? Version { get; set; }

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

    /// <summary>
    /// Child items, applicable only to panels/profiles.
    /// </summary>
    public List<SaleItem> Children { get; set; }

}
