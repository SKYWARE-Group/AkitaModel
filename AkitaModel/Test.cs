using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Test (analyte).
/// </summary>
public class Test
{

    /// <summary>
    /// Primary key.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the test (analyte), e.g. "Glucose".
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Long name of the test (analyte), e.g. "Glucose in Serum".
    /// </summary>
    public string LongName { get; set; }

    /// <summary>
    /// Foreign key to department this test belongs to.
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Sorting value.
    /// </summary>
    public int? Rank { get; set; }

    /// <summary>
    /// <see href="https://loinc.org/">LOINC</see> code of the test.
    /// </summary>
    public string LoincCode { get; set; }

    /// <summary>
    /// Measurement units of the test.
    /// </summary>
    public string Units { get; set; }

    /// <summary>
    /// Type of the result (numeric, text, etc.), see <see cref="ResultTypes"/>.
    /// </summary>
    public ResultTypes ResultType { get; set; } = ResultTypes.Text;

    /// <summary>
    /// When result type is semiquantitative, this flag show which range stands for negative results.<br/>
    /// Suppose test is defined as semiquantitative with gray zone 9-11.<br/>
    /// If this flag is true, then values under 9 will be considered as negative.
    /// </summary>
    public bool NegativeIsLow { get; set; } = true;

    /// <summary>
    /// Scale is the number of digits to the right of the decimal point in a number.<br/>
    /// Applicable only if result type is <see cref="ResultTypes.Quantitative"/> or <see cref="ResultTypes.SemiQuantitative"/>.
    /// </summary>
    public int Scale { get; set; }

    /// <summary>
    /// Foreign key to <see cref="SampleType"/>.
    /// </summary>
    public int? SampleTypeID { get; set; }

    /// <summary>
    /// <see cref="SampleType"/> of the test.
    /// </summary>
    public SampleType SampleType { get; set; }

    /// <summary>
    /// Foreign key to Flag Types.
    /// </summary>
    public int? FlagTypeId { get; set; }

    /// <summary>
    /// Applicable flags, such as "+", "↑", "3+", etc.
    /// </summary>
    public FlagType FlagType { get; set; }

    /// <summary>
    /// If false, test should be considered as "internal use only" and shouldn't be reported to third parties. 
    /// </summary>
    public bool? ShowInResults { get; set; } = true;

    /// <summary>
    /// Maximum allowed flag level.
    /// </summary>
    public FlagLevelLimits FlagLimit { get; set; } = FlagLevelLimits.UP_TO_ULTRA;

    /// <summary>
    /// Collection of <see cref="ReferenceRange"/> for given test.<br/>
    /// Note that in case of <see cref="ResultTypes.SemiQuantitative"/> tests, <see cref="FlagLevels.LOW"/> and <see cref="FlagLevels.HIGH"/>
    /// stand for gray zone and aren't reference range limits!
    /// </summary>
    public IEnumerable<ReferenceRange> Ranges { get; set; } = [];

    // TODO: resultListId
    // TODO: resultList (rename here or in core)

    /// <summary>
    /// List of allowed values, applicable only if result type is <see cref="ResultTypes.List"/>.<br/>
    /// When result is found amongst values, it will be flagged as level, defined in <see cref="ResultEntry.FlagLevel"/>.
    /// </summary>
    public IEnumerable<ResultEntry> AllowedResults { get; set; } = [];

}
