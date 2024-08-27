using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Robin.Reports;

public class LaboratoryResults
{

    public Patient Patient { get; set; }

    public IList<Doctor> ReferringDoctors { get; set; } = [];

    public IList<SaleItem> Results { get; set; } = [];

}
