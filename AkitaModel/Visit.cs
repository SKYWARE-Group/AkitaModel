using System;
using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel;

public class Visit
{

    public int? Id { get; set; }

    public string ExternalId { get; set; }

    public DateTime? Registered { get; set; }

    public Patient Patient { get; set; }

    public int? SchemaId { get; set; }

    public int? LocationId { get; set; }

    public string Field1 { get; set; }

    public string Field2 { get; set; }

    public string Field3 { get; set; }

    public Doctor Doctor { get; set; }

    public List<VisitItem> Items { get; set; }

    public List<Sample> Samples { get; set; }

    // public List<Note>? Notes { get; set; }

}
