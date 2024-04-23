namespace Skyware.Lis.AkitaModel.BgNhis;

/// <summary>
/// NHIF (НЗОК) contract of a doctor.
/// </summary>
public class NhifContract
{

    /// <summary>
    /// Doctor.
    /// </summary>
    public Doctor Doctor { get; set; }

    /// <summary>
    /// Speciality under which the contract is signed.
    /// </summary>
    public NhifSpeciality Speciality { get; set; }

    /// <summary>
    /// Medical practice.
    /// </summary>
    public Practice Practice { get; set; }

}
