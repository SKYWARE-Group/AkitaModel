/**
 * Skyware.Lis.AkitaModel
 */

/**
 * Defines limit of flagging, e.g. up to alarm 1.
 */
export enum FlagLevelLimits {
  /**
   * Do not use flags at all.
   */
  NO_FLAG = 0,

  /**
   * Up to Alarm 1 - High/Low.
   */
  UP_TO_LOW_HIGH = 1,

  /**
   * Up to Alarm 2 - Very High/Low.
   */
  UP_TO_VERY = 2,

  /**
   * Up to Alarm 3 - Ultra High/Low.
   */
  UP_TO_ULTRA = 3
}
