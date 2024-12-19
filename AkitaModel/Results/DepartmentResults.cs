using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Wrapper class of examination results that follows structure of the printout.
/// </summary>
public class DepartmentResults
{

    /// <summary>
    /// PK of the Department in LIS iLab.
    /// </summary>
    public int DepartmentId { get; set; }

    /// <summary>
    /// Name of the department.
    /// </summary>
    public string DepartmentName { get; set; } = string.Empty;

    /// <summary>
    /// Rank of the department, use it for sorting.
    /// </summary>
    public int Rank { get; set; }

    /// <summary>
    /// Label for the reference range column for this department.
    /// </summary>
    public string RangeLabel { get; set; }

    /// <summary>
    /// Department-level note.
    /// </summary>
    public Note Note { get; set; }

    /// <summary>
    /// List of examination results.
    /// </summary>
    public IList<ExaminationBase> Results { get; set; }

}
