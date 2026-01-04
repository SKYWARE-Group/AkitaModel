/**
 * Skyware.Lis.AkitaModel.Portal
 */

import { Test } from '../Test';
import { TestResult } from './TestResult';

/**
 * Entry of the patient's file.
 */
export class TestSummary {
  /**
   * The Test this summary is for.
   */
  test?: Test;

  /**
   * Total number of test results over time.
   */
  numberOfResults!: number;

  /**
   * Latest test result.
   */
  lastResult?: TestResult;
}
