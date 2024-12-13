namespace Skyware.Lis.AkitaModel.Results;

public class Note
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int? Id { get; set; }

    public NoteLevels Level { get; set; } = NoteLevels.Info;

    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// True if the note can be dismissed by the user.
    /// </summary>
    public bool IsDismissable { get; set; } = false;

}
