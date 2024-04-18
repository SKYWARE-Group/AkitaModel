using System;

namespace Skyware.Lis.AkitaModel;

public class Patient : PersonBase
{

    public int? PidTypeId { get; set; }

    public string PatientId { get; set; }

    public bool? IsMale { get; set; }

    public int? SpeciesId { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public bool? IsDobAprox { get; set; }

}
