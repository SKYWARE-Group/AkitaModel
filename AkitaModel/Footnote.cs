namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Footnote.
/// </summary>
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
