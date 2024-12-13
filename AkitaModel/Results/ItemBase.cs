namespace Skyware.Lis.AkitaModel.Results;

public abstract class ItemBase
{

    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string Name { get; set; } = string.Empty; 

}
