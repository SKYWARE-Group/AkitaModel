using System;
using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Results;

public class VisitResults
{

    public int Id { get; set; }

    public DateTime Date { get; set; }

    public Patient Patient { get; set; }

    public IList<Note> Notes { get; set; } 

    public IList<DepartmentResults> DepartmentResults { get; set; }

    public IList<Sample> Samples { get; set; }

    /// <summary>
    /// Footnotes list.
    /// </summary>
    public IList<Footnote> Footnotes { get; set; } = [];

}
