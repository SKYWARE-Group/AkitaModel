using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Portal;

/// <summary>
/// Represents a patient and distinct test entries.
/// </summary>
public class PatientTests
{

    /// <summary>
    /// Patient.
    /// </summary>
    public Patient Patient { get; set; }

    /// <summary>
    /// The test summaries the patient.
    /// </summary>
    public IList<TestSummary> TestSummaries { get; set; }

}
