using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel;

public class VisitItem
{
    public int? Id { get; set; }

    public int? SaleId { get; set; }

    public int? ProfileId { get; set; }

    public int? TestId { get; set; }

    public int? DepartmentId { get; set; }

    public string DepartmentName { get; set; }

    public int? DepartmentRank { get; set; }

    public string LoincId { get; set; }

    public string Name { get; set; }

    public int? Rank { get; set; }

    public string Result { get; set; }

    public decimal? NumericResult { get; set; }

    public byte? Flag { get; set; }

    public string FlagSymbol { get; set; }

    public int? Version { get; set; }

    public string Units { get; set; }

    public string Range { get; set; }

    public bool? IsReady { get; set; }

    public List<VisitItem> Children { get; set; }

}
