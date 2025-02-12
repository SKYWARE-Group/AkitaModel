using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Portal;

/// <summary>
/// Represents test results over time for given Patient.
/// </summary>
public class TestHistory
{

    /// <summary>
    /// Patient.
    /// </summary>
    public Patient Patient { get; set; }

    /// <summary>
    /// The Test this summary is for.
    /// </summary>
    public Test Test { get; set; }

    /// <summary>
    /// The results of the test.
    /// </summary>
    public IList<TestResult> Results { get; set; }

}
