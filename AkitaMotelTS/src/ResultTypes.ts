/**
 * Skyware.Lis.AkitaModel
 */

/**
 * Result types.
 */
export enum ResultTypes {
  /**
   * Textual result.
   */
  Text = 4,

  /**
   * Numeric result, usually represents concentration.
   */
  Quantitative = 1,

  /**
   * Semi-quantitative, cut-off result.
   */
  SemiQuantitative = 5,

  /**
   * Ratio, such as 1:2, 2:16, 3:5, etc.
   */
  Ratio = 2,

  /**
   * Value amongst list of allowed values.
   */
  List = 3
}
