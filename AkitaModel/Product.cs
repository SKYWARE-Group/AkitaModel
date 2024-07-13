namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Price list entry
/// </summary>
public class Product
{

    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public int? TestId { get; set; }

    public int? ProfileId { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public string PriceText { get; set; }

}
