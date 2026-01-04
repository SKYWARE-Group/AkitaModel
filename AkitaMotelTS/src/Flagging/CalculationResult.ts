/**
 * Skyware.Lis.AkitaModel.Flagging
 */

// Ignore Spelling: hl

import { FlagLevels } from '../FlagLevels';

/**
 * Represents result received from the flagging API
 */
export class CalculationResult {
  /**
   * Text representation of the results as it would be printed, shown on screen, etc.
   */
  textResult: string = '';

  /**
   * Number prefix, e.g. "<", ">>", ">=", etc.
   */
  prefix?: string;

  /**
   * Decimal representation (if available).
   */
  decimalResult?: number;

  /**
   * Flag level of the result (see FlagLevels)
   */
  flagLevel: FlagLevels = FlagLevels.NONE;

  /**
   * Flag, e.g. "↑", "↓↓", "3+", etc.
   */
  flag?: string;

  /**
   * Flag, according to HL7 table 0078.
   */
  hl7Flag?: string;
}
