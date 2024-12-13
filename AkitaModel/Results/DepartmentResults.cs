using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Results;

public class DepartmentResults
{

    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string RangeLabel { get; set; }

    public Note Note { get; set; }

    public IList<ItemBase> Results { get; set; }

}
