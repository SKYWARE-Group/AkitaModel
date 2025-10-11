/**
 * Skyware.Lis.AkitaModel.Results
 */

import { ItemBase } from './ItemBase';

/**
 * Base class for Panel and Test.
 */
export abstract class ExaminationBase extends ItemBase {
  /**
   * If the examination is a panel, this property will be true.
   */
  abstract get isPanel(): boolean;
}
