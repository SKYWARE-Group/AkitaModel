using System;
using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Represents Set of tests in lis db
/// </summary>
public class Profile
{
    /// <summary>
    /// PK is LIS Database
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the profile
    /// </summary>
    public string Name { get; set; }

    public string LongName { get; set; }

    public int DepartmentId { get; set; }

    public int Rank { get; set; }

    public int RankGlobal { get; set; }

    public string LoincCode { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastModified { get; set; }

    public List<ProfileItem> Items { get; set; }
}
