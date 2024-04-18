using System;

namespace Skyware.Lis.AkitaModel;

public class SampleType
{
    public int? Id { get; set; }

    public string Name { get; set; }

    public string Code { get; set; }

    public int? ColorR { get; set; }

    public int? ColorG { get; set; }

    public int? ColorB { get; set; }

    [Obsolete]
    public string LoincId { get; set; }

}
