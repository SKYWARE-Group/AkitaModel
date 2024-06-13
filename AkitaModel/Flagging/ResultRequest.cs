using System;

namespace Skyware.Lis.AkitaModel.Flagging;

/// <summary>
/// Represents DTO for Flagging api call
/// </summary>
public class ResultRequest
{
    /// <summary>
    /// Date of birth of the patient 
    /// Default value for is 33 years and 6 months old
    /// </summary>
    public DateTime? DateOfBirth { get; set; } = DateTime.Now.AddYears(-33).AddMonths(-6); // Default age is 33 y and 6 mo

    /// <summary>
    /// 
    /// </summary>
    public bool? IsMale { get; set; } // No default gender

    /// <summary>
    /// 
    /// </summary>
    public int? SpeciesId { get; set; } = 1; // Human in LIS iLab

    /// <summary>
    /// References the taken test identifier
    /// </summary>
    public int TestId { get; set; }

    /// <summary>
    /// Text representation of the test result
    /// </summary>
    public string? TextResult { get; set; }

    /// <summary>
    /// Numeric prefixes of the result
    /// </summary>
    public string? NumericPrefix { get; set; }

    /// <summary>
    /// Numeric result of the test
    /// </summary>
    public decimal? NumericResult { get; set; }

    /// <summary>
    /// Reference Id like SaleItemId etc.
    /// </summary>
    public string RefId { get; set; }

}
