/**
 * Skyware.Lis.AkitaModel.BgNhis
 */

import { Doctor } from '../Doctor';
import { NhifSpeciality } from './NhifSpeciality';
import { Practice } from './Practice';
import { Examination } from './Examination';

/**
 * NHIF (НЗОК) contract of a doctor.
 */
export class NhifContract {
  /**
   * Laboratory doctor.
   */
  doctor?: Doctor;

  /**
   * Speciality under which the contract is signed.
   */
  speciality?: NhifSpeciality;

  /**
   * Medical practice.
   */
  practice?: Practice;

  /**
   * Indicates if Rila server endpoint is available and operational.
   */
  isRilaAvailable?: boolean;

  /**
   * Products (examinations) which are allowed by this contract.
   */
  examinations: Examination[] = [];
}
