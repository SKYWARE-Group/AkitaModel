namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Department is a group of tests (analytes) and profiles/panels.
/// </summary>
public class Department
{

    /// <summary>
    /// Primary key.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the department.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Label to be shown on results report for items in this department.
    /// </summary>
    public string RangeText { get; set; }

    /// <summary>
    /// Sorting value.
    /// </summary>
    public int Rank { get; set; }

}
