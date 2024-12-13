using System;
using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel;

public class Visit
{

    public int Id { get; set; }

    public DateTime Date { get; set; }

    public Patient Patient { get; set; }

    public IList<Sale> Sales { get; set; }

    public IList<Sample> Samples { get; set; }


}
