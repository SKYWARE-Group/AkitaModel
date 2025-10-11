/**
 * Skyware.Lis.AkitaModel
 */

import { FlagLevels } from './FlagLevels';

/**
 * Allowed result entry.
 */
export class ResultEntry {
  /**
   * Allowed value of the result.
   */
  value?: string;

  /**
   * Corresponding flag for this value.
   */
  flagLevel: FlagLevels = FlagLevels.NONE;
}
