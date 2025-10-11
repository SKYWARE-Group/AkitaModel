/**
 * Skyware.Lis.AkitaModel.Portal
 */

import { Patient } from '../Patient';
import { Test } from '../Test';
import { TestResult } from './TestResult';

/**
 * Represents test results over time for given Patient.
 */
export class TestHistory {
  /**
   * Patient.
   */
  patient?: Patient;

  /**
   * The Test this summary is for.
   */
  test?: Test;

  /**
   * The results of the test.
   */
  results?: TestResult[];
}
