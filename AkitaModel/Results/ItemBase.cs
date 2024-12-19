using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Base class for items in the results or sale.
/// </summary>
[JsonDerivedType(typeof(ExaminationBase))]
[JsonDerivedType(typeof(Product))]
public abstract class ItemBase
{

    /// <summary>
    /// PK of the item in LIS iLab.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK of the product in LIS iLab (test or panel/profile).
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Name of the item.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Rank of the item, use it for sorting.
    /// </summary>
    public int Rank { get; set; }

}
