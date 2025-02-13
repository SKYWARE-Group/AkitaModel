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
    /// Latest test result.
    /// </summary>
    public TestResult LastResult { get; set; }

}
