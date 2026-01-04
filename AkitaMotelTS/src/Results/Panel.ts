/**
 * Skyware.Lis.AkitaModel.Results
 */

import { ExaminationBase } from './ExaminationBase';
import { Test } from './Test';

/**
 * Represents a panel of tests (Profile).
 */
export class Panel extends ExaminationBase {
  /** @inheritdoc */
  get isPanel(): boolean {
    return true;
  }

  /**
   * Test items that are part of the panel.
   */
  tests?: Test[];
}
