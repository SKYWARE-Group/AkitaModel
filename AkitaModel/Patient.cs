using Skyware.Lis.AkitaModel.Helpers;
using System;
using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Patient.
/// </summary>
public class Patient : PersonBase
{

    /// <summary>
    /// Patient's identifier descriptor.
    /// </summary>
    public int? PidTypeId { get; set; }

    /// <summary>
    /// Name of the identifier
    /// </summary>
    public string PidTypeIdName { get; set; } = string.Empty;

    /// <summary>
    /// Patient's identifier is a unique
    /// </summary>
    public bool PidTypeIdIsIdentity { get; set; } = true;

    /// <summary>
    /// Well-known identifier, e.g. SSN, EGN, etc.
    /// </summary>
    public string PatientId { get; set; }

    /// <summary>
    /// Gender indicator.
    /// </summary>
    public bool? IsMale { get; set; }

    /// <summary>
    /// Id of a species of the patient. Default (null) means human.
    /// </summary>
    public int? SpeciesId { get; set; }

    /// <summary>
    /// Name of a species of the patient (human, cat, dog, etc.)
    /// </summary>
    public string SpeciesIdName { get; set; } = string.Empty;

    /// <summary>
    /// Date of birth.
    /// </summary>
    [JsonConverter(typeof(IsoDateOnlyConverter))]
    public DateTime? DateOfBirth { get; set; }

    /// <summary>
    /// Indicator whether date of birth is approximate or exact.
    /// </summary>
    [Obsolete("Here is a typo, use IsDobApprox.")]
    public bool? IsDobAprox { get => IsDobApprox; set { IsDobApprox = value; } }

    /// <summary>
    /// Indicator whether date of birth is approximate or exact.
    /// </summary>
    public bool? IsDobApprox { get; set; }

    /// <summary>
    /// Patient age at registration time
    /// </summary>
    [Obsolete("This property will be removed in next version, do not use it.")]
    public string AgeAtRegTimeString { get; set; } = string.Empty;
}
