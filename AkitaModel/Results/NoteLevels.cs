namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// The level of importance of a note.
/// </summary>
public enum NoteLevels : byte
{
    /// <summary>
    /// Informational note.
    /// </summary>
    Info = 0,

    /// <summary>
    /// Warning note.
    /// </summary>
    Warning = 1,

    /// <summary>
    /// Error note.
    /// </summary>
    Error = 2,

}
