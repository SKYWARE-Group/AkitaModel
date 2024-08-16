using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.BgNhis;

/// <summary>
/// NHIF (НЗОК) contract of a doctor.
/// </summary>
public class NhifContract
{

    /// <summary>
    /// Laboratory doctor.
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

    /// <summary>
    /// Indicates if Rila server endpoint is available and operational.
    /// </summary>
    public bool? IsRilaAvailable { get; set; }

    /// <summary>
    /// Products (examinations) which are allowed by this contract.
    /// </summary>
    public IList<Examination> Examinations { get; set; } = [];

}
