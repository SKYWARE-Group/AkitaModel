namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Represents a single test (analyte, assay) result.
/// </summary>
public class Test : ExaminationBase
{

    /// <inheritdoc />
    public override bool IsPanel => false;

    /// <summary>
    /// The result of the test as text, e.g. "5.2", "Negative", "&gt;&gt;100", etc.
    /// </summary>
    public string TextResult { get; set; } = string.Empty;

    /// <summary>
    /// The numeric result of the test.
    /// </summary>
    public decimal? NumericResult { get; set; }

    /// <summary>
    /// Prefix (leading value modifier), e.g. '&lt;&lt;&lt;', '&gt;=', etc.
    /// </summary>
    public string NumericPrefix { get; set; }

    /// <summary>
    /// Measurement units.
    /// </summary>
    public string Units { get; set; }

    /// <summary>
    /// Applicable reference range, e.g. "4.5-11.0", " &lt;200", "Negative", etc.
    /// </summary>
    public string ReferenceRange { get; set; }

    /// <summary>
    /// Level of the abnormality flag.
    /// </summary>
    /// <remarks>
    /// Use shades of blue for low flags and shades of red for high flags as <b>background
    /// of the result</b> when media supports color rendering. For 
    /// <see cref="FlagLevels.WITH_STAR"/> and <see cref="FlagLevels.SEMI_QUANT_QUESTION"/> 
    /// use shades of gray.<br/>
    /// When media does not support color rendering, use <b>bold text</b> for all flags.<br/>
    /// DO NOT use coloring or bold text for <see cref="FlagLevels.NONE"/>.
    /// </remarks>
    public FlagLevels? FlagLevel { get; set; }

    /// <summary>
    /// Text representation of the abnormality flag, e.g. "H"', "↓↓", "↑", "&gt;&gt;"
    /// </summary>
    /// <remarks>
    /// This text should be rendered next to the test result in the report.
    /// </remarks>
    public string FlagText { get; set; }

    /// <summary>
    /// Number of the footnote associated with this test result (optional).
    /// </summary>
    /// <remarks>
    /// In the report, the footnote text should be rendered as superscript next to the 
    /// name of the test. If media supports it, the footnote number should be a clickable link
    /// to the footnote text at the bottom of the report.<br/>
    /// See <see cref="AkitaModel.Footnote"/> for more information about footnotes.
    /// </remarks>
    public int? Footnote { get; set; }

}
