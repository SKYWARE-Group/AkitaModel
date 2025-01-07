using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Represents base class for notes.
/// </summary>
[JsonDerivedType(typeof(Results.Note))]
public abstract class NoteBase
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Text of the note.
    /// </summary>
    public string Text { get; set; } = string.Empty;

}
