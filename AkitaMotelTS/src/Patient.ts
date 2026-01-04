/**
 * Skyware.Lis.AkitaModel
 */

// Ignore Spelling: pid dob

import { PersonBase } from './PersonBase';

/**
 * Patient.
 */
export class Patient extends PersonBase {
  /**
   * Patient's identifier descriptor.
   */
  pidTypeId?: number;

  /**
   * Name of the identifier
   */
  pidTypeIdName: string = '';

  /**
   * Patient's identifier is a unique
   */
  pidTypeIdIsIdentity: boolean = true;

  /**
   * Well-known identifier, e.g. SSN, EGN, etc.
   */
  patientId?: string;

  /**
   * Gender indicator.
   */
  isMale?: boolean;

  /**
   * Id of a species of the patient. Default (null) means human.
   */
  speciesId?: number;

  /**
   * Name of a species of the patient (human, cat, dog, etc.)
   */
  speciesIdName?: string;

  /**
   * Date of birth.
   */
  dateOfBirth?: Date;

  /**
   * Indicator whether date of birth is approximate or exact.
   * @deprecated Here is a typo, use IsDobApprox.
   */
  get isDobAprox(): boolean | undefined {
    return this.isDobApprox;
  }
  set isDobAprox(value: boolean | undefined) {
    this.isDobApprox = value;
  }

  /**
   * Indicator whether date of birth is approximate or exact.
   */
  isDobApprox?: boolean;

  /**
   * Patient age at registration time
   * @deprecated This property will be removed in next version, do not use it.
   */
  ageAtRegTimeString?: string;
}
