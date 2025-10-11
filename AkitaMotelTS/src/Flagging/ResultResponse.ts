/**
 * Skyware.Lis.AkitaModel.Flagging
 */

import { CalculationResult } from './CalculationResult';

/**
 * Represents answer from the flagging service when result flag is requested.
 */
export class ResultResponse {
  /**
   * Default c-tor.
   */
  constructor(referenceId?: string) {
    if (referenceId) {
      this.refId = referenceId;
    }
  }

  /**
   * Calculation result (see CalculationResult).
   */
  calculationResult?: CalculationResult;

  /**
   * If any error occurred when the result is flagged it will be written here.
   */
  error?: string;

  /**
   * Reference like SaleItemId etc.
   */
  refId?: string;
}
