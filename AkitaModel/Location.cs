using System;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Laboratory location, e.g. "Central lab", "Reception North", etc.
/// </summary>
/// <remarks>
/// Location is a physical place where laboratory performs activities.
/// It could be central laboratory, satellite laboratory or sample collection point.
/// Location is the base concept in sample logistics, analytics, KPI, etc. It also
/// define reports identity, operation limitations, etc.
/// </remarks>
public class Location
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the location, e.g. "Central lab", etc.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Description of the location, e.g. "Sample collection point in Medical Center North.", etc.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Soft delete field.
    /// </summary>
    /// <remarks>
    /// If this field is <b>false</b>, it mustn't be used as shipment destination,
    /// as a location in new visit registrations, etc. 
    /// </remarks>
    public bool IsActive { get; set; } = true;

    public string Code { get; set; }

    //public bool IsMicrobiology { get; set; }

    public int DocumentProfileId { get; set; }

    //public DocumentProfile DocumentProfile { get; set; }

    public int TypeId { get; set; }

    //public LocationType LocationType { get; set; }

    public string City { get; set; }

    public string PostalCode { get; set; }

    public string Address { get; set; }

    public string Phone1 { get; set; }

    public string Phone2 { get; set; }

    public string Email { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public bool WebVisible { get; set; } = true;

    public bool AcceptCards { get; set; } = true;

    public bool DisabilitiesAccess { get; set; } = true;

    public string PublicNote { get; set; }

    public bool PublicNoteMarkup { get; set; } = false;

    //public string InternalNote { get; set; }

    public int GroupId { get; set; }

    /// <summary>
    /// The <see cref="AkitaModel.LocationGroup"/> this location belongs to.
    /// </summary>
    public LocationGroup LocationGroup { get; set; }

    public bool CanReceiveSamples { get; set; } = true;

    public string GlobalId { get; set; }

    public DateTime? Created { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? Modified { get; set; }

    public string ModifiedBy { get; set; }

    //public IList<ProcessingPoint> ProcessingPoints { get; set; }

}
