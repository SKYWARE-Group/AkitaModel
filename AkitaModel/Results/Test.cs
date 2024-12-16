namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Represents a single test (analyte, assay) result.
/// </summary>
public class Test : ExaminatioinBase
{

    /// <inheritdoc />
    public override bool IsPanel => false;

    public string TextResult { get; set; } = string.Empty;

    public string Units { get; set; }

    public string ReferenceRange { get; set; }

    public FlagLevels? FlagLevel { get; set; } 

    public string FlagText { get; set; }

    public int? FootnoteId { get; set; }


}
