/**
 * Skyware.Lis.AkitaModel
 */

/**
 * Department is a group of tests (analytes) and panels/profiles.
 */
export class Department {
  /**
   * Primary key.
   */
  id!: number;

  /**
   * Name of the department.
   */
  name?: string;

  /**
   * Label to be shown on results report for items in this department.
   */
  rangeText?: string;

  /**
   * Sorting value.
   */
  rank!: number;
}
