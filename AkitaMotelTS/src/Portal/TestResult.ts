/**
 * Skyware.Lis.AkitaModel.Portal
 */

/**
 * Represents a single test result.
 */
export class TestResult {
  /**
   * Unique identifier of the result (PK).
   */
  id!: number;

  /**
   * Test this result belongs to.
   */
  saleId!: number;

  /**
   * Date/time of the result.
   */
  resultTime!: Date;

  /**
   * Result as text.
   */
  result?: string;

  /**
   * Optional, decimal result.
   */
  numericResult?: number;

  /**
   * Flag, according to reference range (1-7, 10, 11).
   * @remarks
   * 1=ultra low, 2=very low, 3=low, 5=high, 6=very high, 7=ultra high, 10=star.
   * 4=no flag. Null means the flag is not calculated.
   */
  flag?: number;

  /**
   * Flag string, e.g. "↑", "↓↓", etc.
   */
  flagSymbol?: string;

  /**
   * Measurement units.
   */
  units?: string;

  /**
   * Reference range (label) for this patient.
   */
  range?: string;

  /**
   * Ready/Pending flag.
   */
  isReady?: boolean;
}
