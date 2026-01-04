/**
 * Skyware.Lis.AkitaModel
 */

/**
 * Describes test decimal values and their alarms for specific gender or both of them
 */
export class ReferenceRange {
  /**
   * PK in DB.
   */
  id!: number;

  /**
   * Species discriminator, e.g. 1=human.
   */
  speciesId: number = 1;

  /**
   * Number of days
   */
  ageFrom: number = Math.round((new Date().getTime() - Date.UTC(new Date().getUTCFullYear(), new Date().getUTCMonth(), new Date().getUTCDate())) / (1000 * 60 * 60 * 24));

  /**
   * When true, range is determined by the gender of the patient.
   * Even range is gender-dependent, non-gender range will be applied when the gender if the patient is unknown.
   */
  isRangedByGender: boolean = false;

  // #region Both ganders

  /**
   * Low level of both the genders
   */
  lowValue?: number;

  /**
   * High level of both of the genders
   */
  highValue?: number;

  /**
   * First low alarm for both genders
   */
  lowAlarm1?: number;

  /**
   * First high alarm for both genders
   */
  highAlarm1?: number;

  /**
   * Second low alarm for both of the genders
   */
  lowAlarm2?: number;

  /**
   * Second high alarm for both of the genders
   */
  highAlarm2?: number;

  /**
   * Minimum result value for both of the genders
   * Every result below this level will be considered as invalid
   */
  absoluteMin?: number;

  /**
   * Maximum result value for both of the genders
   * Every result above this level will be considered as invalid
   */
  absoluteMax?: number;

  // #endregion

  // #region Male

  /**
   * Male low value
   */
  mLowValue?: number;

  /**
   * Male high value
   */
  mHighValue?: number;

  /**
   * First low alarm for the male gender
   */
  mLowAlarm1?: number;

  /**
   * First high alarm for the male gender
   */
  mHighAlarm1?: number;

  /**
   * Second low alarm for the male gender
   */
  mLowAlarm2?: number;

  /**
   * Second high alarm for the male gender
   */
  mHighAlarm2?: number;

  /**
   * Absolute minimum for the male gender
   * Every result below this level will be considered as invalid
   */
  mAbsoluteMin?: number;

  /**
   * Absolute maximum for the male gender
   * Every result above this level will be considered as invalid
   */
  mAbsoluteMax?: number;

  // #endregion

  // #region Female

  /**
   * Female low value
   */
  fLowValue?: number;

  /**
   * Female high value
   */
  fHighValue?: number;

  /**
   * First low alarm for the female gender
   */
  fLowAlarm1?: number;

  /**
   * First high alarm for the female gender
   */
  fHighAlarm1?: number;

  /**
   * Second low alarm for the female gender
   */
  fLowAlarm2?: number;

  /**
   * Second high alarm for the female gender
   */
  fHighAlarm2?: number;

  /**
   * Absolute minimum for the female gender
   * Every result below this level will be considered as invalid
   */
  fAbsoluteMin?: number;

  /**
   * Absolute maximum for the female gender
   * Every result above this level will be considered as invalid
   */
  fAbsoluteMax?: number;

  // #endregion
}
