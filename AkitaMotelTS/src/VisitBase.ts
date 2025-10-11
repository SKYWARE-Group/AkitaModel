/**
 * Skyware.Lis.AkitaModel
 */

import { Patient } from './Patient';

/**
 * Patient visit. This is a base class for all types of visits.
 */
export abstract class VisitBase {
  /**
   * PK in LIS iLab.
   */
  id!: number;

  /**
   * Date/time the visit was created.
   */
  date!: Date;

  /**
   * Visiting patient.
   */
  patient?: Patient;
}
