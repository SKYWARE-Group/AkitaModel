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
    /// Date of birth.
    /// </summary>
    [JsonConverter(typeof(IsoDateOnlyConverter))]
    public DateTime? DateOfBirth { get; set; }

    /// <summary>
    /// Indicator wheter date of birth is apporximate or exact.
    /// </summary>
    public bool? IsDobAprox { get; set; }

}
