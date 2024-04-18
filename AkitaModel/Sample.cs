namespace Skyware.Lis.AkitaModel;

public class Sample
{

    public int? Id { get; set; }

    public int? ParentId { get; set; }

    public int? SaleId { get; set; }

    // public int? SampleTypeId { get; set; }

    public SampleType SampleType { get; set; }

    public string Barcode { get; set; }

    public System.DateTime? Taken { get; set; }

    public int? CurrentLocationId { get; set; }

    public string ProcessingPoints { get; set; }

    //public object Created { get; set; }


}
