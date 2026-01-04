/**
 * Skyware.Lis.AkitaModel
 */

/**
 * Examination record - test or panel and its results.
 */
export class SaleItem {
  /**
   * PK of the item in LIS iLab.
   */
  id?: number;

  /**
   * FK to Visit
   */
  saleId?: number;

  /**
   * FK to Profile/Panel.
   */
  profileId?: number;

  /**
   * FK to Test.
   */
  testId?: number;

  /**
   * FK to Department.
   */
  departmentId?: number;

  /**
   * Department name.
   */
  departmentName?: string;

  /**
   * Sort order of the department..
   */
  departmentRank?: number;

  /**
   * Note for this sale
   */
  saleDepartmentNote?: string;

  /**
   * LOINC code.
   * @remarks
   * It's laboratory's responsibility to comply with LOINC.
   * Some laboratories may use other coding systems or private codes as well.
   */
  loincId?: string;

  /**
   * Name of the test or panel.
   */
  name?: string;

  /**
   * Sort order among other items.
   */
  rank?: number;

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
   * Version of the record, updated one every change.
   */
  version?: number;

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

  /**
   * Child items, applicable only to panels/profiles.
   */
  children?: SaleItem[];
}
