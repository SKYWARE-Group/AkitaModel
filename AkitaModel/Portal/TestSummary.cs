using System;

namespace Skyware.Lis.AkitaModel.Portal;

/// <summary>
/// Entry of the patient's file.
/// </summary>
public class TestSummary
{

    /// <summary>
    /// The Test this summary is for.
    /// </summary>
    public Test Test { get; set; }

    /// <summary>
    /// Total number of test results over time.
    /// </summary>
    public int NumberOfResults { get; set; }

    /// <summary>
    /// Date/time of the last result.
    /// </summary>
    public DateTime ResultTime { get; set; }

    /// <summary>
    /// The last result of the test.
    /// </summary>
    public string TextResult { get; set; } = string.Empty;

    /// <summary>
    /// Level of the abnormality flag of the last result.
    /// </summary>
    public FlagLevels? FlagLevel { get; set; }

    /// <summary>
    /// Text of the abnormality flag of the last result.
    /// </summary>
    public string FlagText { get; set; }

}
