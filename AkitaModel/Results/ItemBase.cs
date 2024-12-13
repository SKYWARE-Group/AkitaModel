using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel.Results;

[JsonDerivedType(typeof(ExaminatioinBase))]
[JsonDerivedType(typeof(Product))]
public abstract class ItemBase
{

    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string Name { get; set; } = string.Empty; 

}
