/**
 * Skyware.Lis.AkitaModel
 */

// Ignore Spelling: uin

import { PersonBase } from './PersonBase';
import { Speciality } from './Speciality';

/**
 * Doctor.
 */
export class Doctor extends PersonBase {
  /**
   * Unique Identification Number. Provided by healthcare authorities, jurisdiction dependent.
   */
  uin?: string;

  /**
   * Title, e.g. "Dr.", "Prof.", etc.
   */
  title?: string;

  /**
   * Speciality
   */
  speciality?: Speciality;

  /**
   * Region.
   */
  region?: string;

  /**
   * City.
   */
  city?: string;

  /**
   * Postal code.
   */
  postalCode?: string;

  /**
   * Business address, usually same as practice address.
   */
  postAddress?: string;

  /**
   * Doctor's information (last name, title, first name, speciality name and job place).
   */
  displayName?: string;
}
