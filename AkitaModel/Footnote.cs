namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Footnote.
/// </summary>
/// <remarks>
/// Footnote is a canned text that will be shown or printed on patient results and contains
/// additional information about the test(s).<br/>
/// The report generator:<br/>
/// 1. Order reportable results (<see cref="SaleItem"/>) by <see cref="Department.Rank"/>
///    (both Test and Profile items have such property), then by <see cref="Test.Rank"/> or 
///    <see cref="Profile.Rank"/> and finnaly, in case the item is a child of a panel, by 
///    <see cref="Test.Rank"/> within the panel.<br/>
/// 2. Collect all distinct footnotes attached to the tests in the ordered list of results.<br/>
/// 3. Generate a numbered list of involved footnotes in the current visit.<br/>
/// 4. Place superscript reference numbers to the footnotes at the right of the test name.<br/>
/// 5. Print or show the numbered list of footnotes at the bottom of the report.
/// </remarks>
public class Footnote
{

    /// <summary>
    /// Unique Identification Number.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Label.
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Footnote text.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Sequence number.
    /// </summary>
    public byte SequenceNumber { get; set; }

}
