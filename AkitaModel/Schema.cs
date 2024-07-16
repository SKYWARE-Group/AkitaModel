using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel;

public class Schema
{

    public int Id { get; set; }

    public string Name { get; set; }

    public bool HasDoctor { get; set; }

    public bool HasFund1 { get; set; }

    public int? Fund1Id { get; set; }

    //public Fund fund1 { get; set; }

    public bool HasFund2 { get; set; }

    public int? Fund2Id { get; set; }

    //public Fund fund2 { get; set; }

    public string Field1 { get; set; }

    public string Field2 { get; set; }

    public string Field3 { get; set; }

    public bool IsActive { get; set; }

    public int? SaleTypeId { get; set; }

    public IEnumerable<Product> Items { get; set; }

    //public IEnumerable<Fund> enabledFunds;

    //public IEnumerable<PatientIdType> enabledPidTypes;

}
