using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Represents a Visit view with structure for results reporting.
/// </summary>
public class VisitResults : VisitBase
{

    /// <summary>
    /// List of notes and announcements.
    /// </summary>
    public IList<Note> Notes { get; set; }

    /// <summary>
    /// List of departments with results.
    /// </summary>
    public IList<DepartmentResults> DepartmentResults { get; set; }

    /// <summary>
    /// List of samples used in examinations.
    /// </summary>
    public IList<Sample> Samples { get; set; }

    /// <summary>
    /// Footnotes list.
    /// </summary>
    public IList<Footnote> Footnotes { get; set; }

}
