namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Represents a single test (analyte, assay) result.
/// </summary>
public class Test : ExaminationBase
{

    /// <inheritdoc />
    public override bool IsPanel => false;

    /// <summary>
    /// The result of the test.
    /// </summary>
    public string TextResult { get; set; } = string.Empty;

    /// <summary>
    /// Measurement units.
    /// </summary>
    public string Units { get; set; }

    /// <summary>
    /// Applicable reference range.
    /// </summary>
    public string ReferenceRange { get; set; }

    /// <summary>
    /// Level of the abnormality flag.
    /// </summary>
    public FlagLevels? FlagLevel { get; set; }

    /// <summary>
    /// Text of the abnormality flag.
    /// </summary>
    public string FlagText { get; set; }

    /// <summary>
    /// FK to the footnote in LIS iLab.
    /// </summary>
    public int? FootnoteId { get; set; }


}
