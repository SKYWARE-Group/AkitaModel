using System;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Describes test decimal values and their alarms for specific gender or both of them
/// </summary>
public class ReferenceRange
{

    /// <summary>
    /// PK in DB.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Species discriminator, e.g. 1=human.
    /// </summary>
    public int SpeciesId { get; set; } = 1;

    /// <summary>
    /// Number of days
    /// </summary>
    public int AgeFrom { get; set; } = Convert.ToInt32(Math.Round((DateTime.Now - DateTime.UtcNow).TotalDays));

    /// <summary>
    /// When true, range is determined by the gender of the patient.<br/>
    /// Even range is gender-dependent, non-gender range will be applied when the gender if the patient is unknown.
    /// </summary>
    public bool IsRangedByGender { get; set; } = false;

    #region Both ganders

    /// <summary>
    /// Low level of both the genders
    /// </summary>
    public decimal? LowValue { get; set; }

    /// <summary>
    /// High level of both of the genders
    /// </summary>
    public decimal? HighValue { get; set; }

    /// <summary>
    /// First low alarm for both genders
    /// </summary>
    public decimal? LowAlarm1 { get; set; }

    /// <summary>
    /// First high alarm for both genders
    /// </summary>
    public decimal? HighAlarm1 { get; set; }

    /// <summary>
    /// Second low alarm for both of the genders
    /// </summary>
    public decimal? LowAlarm2 { get; set; }

    /// <summary>
    /// Second high alarm for both of the genders
    /// </summary>
    public decimal? HighAlarm2 { get; set; }

    /// <summary>
    /// Minimum result value for both of the genders
    /// Every result below this level will be considered as invalid
    /// </summary>
    public decimal? AbsoluteMin { get; set; }

    /// <summary>
    /// Maximum result value for both of the genders
    /// Every result above this level will be considered as invalid
    /// </summary>
    public decimal? AbsoluteMax { get; set; }

    #endregion

    #region Male

    /// <summary>
    /// Male low value
    /// </summary>
    public decimal? MLowValue { get; set; }

    /// <summary>
    /// Male high value
    /// </summary>
    public decimal? MHighValue { get; set; }

    /// <summary>
    /// First low alarm for the male gender
    /// </summary>
    public decimal? MLowAlarm1 { get; set; }

    /// <summary>
    /// First high alarm for the male gender
    /// </summary>
    public decimal? MHighAlarm1 { get; set; }

    /// <summary>
    /// Second low alarm for the male gender
    /// </summary>
    public decimal? MLowAlarm2 { get; set; }

    /// <summary>
    /// Second high alarm for the male gender
    /// </summary>
    public decimal? MHighAlarm2 { get; set; }

    /// <summary>
    /// Absolute minimum for the male gender
    /// Every result below this level will be considered as invalid
    /// </summary>
    public decimal? MAbsoluteMin { get; set; }

    /// <summary>
    /// Absolute maximum for the male gender
    /// Every result above this level will be considered as invalid
    /// </summary>
    public decimal? MAbsoluteMax { get; set; }

    #endregion

    #region Female

    /// <summary>
    /// Female low value
    /// </summary>
    public decimal? FLowValue { get; set; }

    /// <summary>
    /// Female high value
    /// </summary>
    public decimal? FHighValue { get; set; }

    /// <summary>
    /// First low alarm for the female gender
    /// </summary>
    public decimal? FLowAlarm1 { get; set; }

    /// <summary>
    /// First high alarm for the female gender
    /// </summary>
    public decimal? FHighAlarm1 { get; set; }

    /// <summary>
    /// Second low alarm for the female gender
    /// </summary>
    public decimal? FLowAlarm2 { get; set; }

    /// <summary>
    /// Second high alarm for the female gender
    /// </summary>
    public decimal? FHighAlarm2 { get; set; }

    /// <summary>
    /// Absolute minimum for the female gender
    /// Every result below this level will be considered as invalid
    /// </summary>
    public decimal? FAbsoluteMin { get; set; }

    /// <summary>
    /// Absolute maximum for the female gender
    /// Every result above this level will be considered as invalid
    /// </summary>
    public decimal? FAbsoluteMax { get; set; }


    #endregion

}
