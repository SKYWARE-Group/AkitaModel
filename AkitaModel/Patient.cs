using Skyware.Lis.AkitaModel.Helpers;
using System;
using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel;

public class Patient : PersonBase
{

    public int? PidTypeId { get; set; }

    public string PatientId { get; set; }

    public bool? IsMale { get; set; }

    public int? SpeciesId { get; set; }

    [JsonConverter(typeof(DateOnlyJsonConverter))]
    public DateTime? DateOfBirth { get; set; }

    public bool? IsDobAprox { get; set; }

}
