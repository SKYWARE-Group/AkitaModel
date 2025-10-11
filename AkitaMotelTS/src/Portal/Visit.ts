/**
 * Skyware.Lis.AkitaModel.Portal
 */

import { VisitBase } from '../VisitBase';

/**
 * Patient visit.
 * @remarks
 * This class is intended to be used in the portal or similar scenarios.
 * It contains minimum properties and is intended to be used in lists and tables.
 */
export class Visit extends VisitBase {
  /**
   * Total number of ordered tests.
   */
  totalTests!: number;

  /**
   * Number of completed tests.
   */
  readyTests!: number;

  /**
   * Number of flagged tests.
   * @remarks
   * The value here counts only already flagged tests.
   * It does not include tests that could be flagged on the fly.
   */
  flaggedTests!: number;

  /**
   * Percent of completed tests.
   */
  get percentReady(): number {
    return this.totalTests === 0 ? 100 : Math.floor((this.readyTests / this.totalTests) * 100);
  }

  /**
   * Degree of readiness from 0 (none) to 5 (complete).
   */
  get degreeOfReadiness5(): number {
    return this.totalTests === 0 ? 5 : Math.min(5, Math.floor((this.readyTests / this.totalTests) * 5));
  }

  /**
   * Degree of readiness from 0 (none) to 8 (complete).
   */
  get degreeOfReadiness8(): number {
    return this.totalTests === 0 ? 8 : Math.min(8, Math.floor((this.readyTests / this.totalTests) * 8));
  }
}
