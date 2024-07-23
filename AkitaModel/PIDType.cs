namespace Skyware.Lis.AkitaModel;

public class PIDType
{
    public int Id { get; set; }

    public bool EncodesDob { get; set; }

    public bool EncodesSex { get; set; }

    public string CountryCode { get; set; }

    public string Name { get; set; }

    public bool IsIdentity { get; set; }

    public int FixedSpecies { get; set; }

    public int MinIdLen { get; set; }

    public int MaxIdLen { get; set; }

    public bool IsNumOnly { get; set; }

    public bool IsActive { get; set; }

}
