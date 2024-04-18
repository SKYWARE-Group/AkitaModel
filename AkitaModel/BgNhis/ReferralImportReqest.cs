using System;

namespace Skyware.Lis.AkitaModel.BgNhis;

public class ReferralImportReqest
{

    public string Nrn { get; set; }

    public DateTime VisitDate { get; set; } = DateTime.Today;

    public DateTime SampleDate { get; set; } = DateTime.Now;

    public DateTime ResultsDate { get; set; } = DateTime.Today;

    public NhifContract NhifContract { get; set; }

}
