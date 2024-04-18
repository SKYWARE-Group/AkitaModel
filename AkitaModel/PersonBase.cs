namespace Skyware.Lis.AkitaModel;

public abstract class PersonBase
{

    public int? Id { get; set; }

    public string GivenName { get; set; } = string.Empty;

    public string MiddleName { get; set; }

    public string FamilyName { get; set; } = string.Empty;

}
