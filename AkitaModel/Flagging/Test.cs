using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Flagging;

/// <summary>
/// Definition of a test (analyte).
/// </summary>
public partial class Test
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the test.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// LOINC code of the test.
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

    ///// <summary>
    ///// Applicable flags, such as "+", "↑", "3+", etc.
    ///// </summary>
    //public IEnumerable<FlagType> Flags { get; set; } = [];

    public int? FlagTypeId{ get; set; }

    /// <summary>
    /// Maximum allowed flag level.
    /// </summary>
    public FlagLevelLimits FlagLimit { get; set; } = FlagLevelLimits.UP_TO_ULTRA;

    /// <summary>
    /// Scale is the number of digits to the right of the decimal point in a number.<br/>
    /// Applicable only if result type is <see cref="ResultTypes.Quantitative"/> or <see cref="ResultTypes.SemiQuantitative"/>.
    /// </summary>
    public int Scale { get; set; } 

    /// <summary>
    /// When result type is semiquantitative, this flag show which range stands for negative results.<br/>
    /// Suppose test is defined as semiquantitative with gray zone 9-11.<br/>
    /// If this flag is true, then values under 9 will be considered as negative.
    /// </summary>
    public bool NegativeIsLow { get; set; } = true;

    /// <summary>
    /// Collection of <see cref="ReferenceRange"/> for given test.<br/>
    /// Note that in case of <see cref="ResultTypes.SemiQuantitative"/> tests, <see cref="FlagLevels.LOW"/> and <see cref="FlagLevels.HIGH"/>
    /// stand for gray zone and aren't reference range limits!
    /// </summary>
    public IEnumerable<ReferenceRange> Ranges { get; set; } = [];

    /// <summary>
    /// List of allowed values, applicable only if result type is <see cref="ResultTypes.List"/>.<br/>
    /// When result is found amongst values, it will be flagged as level, defined in <see cref="ResultEntry.FlagLevel"/>.
    /// </summary>
    public IEnumerable<ResultEntry> AllowedResults { get; set; } = [];

}

