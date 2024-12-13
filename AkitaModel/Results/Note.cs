namespace Skyware.Lis.AkitaModel.Results;

public class Note
{

    public int? Id { get; set; }

    public NoteLevels Level { get; set; } = NoteLevels.Info;

    public string Text { get; set; } = string.Empty;

    public bool IsDismissable { get; set; } = false;

}
