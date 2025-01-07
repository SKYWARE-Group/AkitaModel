namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Represents a orderable/payable product in Sale.
/// </summary>
public class Product : ItemBase
{

    /// <summary>
    /// Price of the product, payable by the patient.
    /// </summary>
    public decimal Price { get; set; }

}
