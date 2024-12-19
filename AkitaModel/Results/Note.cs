namespace Skyware.Lis.AkitaModel.Results;

// Ignore Spelling: Dismissible

/// <summary>
/// Represents a note that may appear at visit or department level.
/// </summary>
public class Note
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Level of importance of the note.
    /// </summary>
    public NoteLevels Level { get; set; } = NoteLevels.Info;

    /// <summary>
    /// Text of the note.
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// True if the note can be dismissed by the user.
    /// </summary>
    public bool IsDismissible { get; set; } = false;

}
