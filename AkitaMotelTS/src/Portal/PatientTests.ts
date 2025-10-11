/**
 * Skyware.Lis.AkitaModel.Portal
 */

import { Patient } from '../Patient';
import { TestSummary } from './TestSummary';

/**
 * Represents a patient and distinct test entries.
 */
export class PatientTests {
  /**
   * Patient.
   */
  patient?: Patient;

  /**
   * The test summaries the patient.
   */
  testSummaries?: TestSummary[];
}
