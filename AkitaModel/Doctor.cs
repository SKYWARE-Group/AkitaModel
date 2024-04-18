using Skyware.Lis.AkitaModel.BgNhis;

namespace Skyware.Lis.AkitaModel;

public class Doctor : PersonBase
{

    public string Uin { get; set; } = string.Empty;

    public Speciality Speciality { get; set; }

    public string Region { get; set; }

    public string City { get; set; }

    public string PostalCode { get; set; }

    public string PostAddress { get; set; }

}
