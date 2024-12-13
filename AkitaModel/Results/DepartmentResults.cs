using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Department as wrapper of examination results.
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

    public string RangeLabel { get; set; }

    public Note Note { get; set; }

    /// <summary>
    /// List of examination results.
    /// </summary>
    public IList<ExaminatioinBase> Results { get; set; }

}
