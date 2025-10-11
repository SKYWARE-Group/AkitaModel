/**
 * Skyware.Lis.AkitaModel
 */

/**
 * Abstract class for people.
 */
export abstract class PersonBase {
  /**
   * PK.
   */
  id?: number;

  /**
   * Given (first) name.
   */
  givenName: string = '';

  /**
   * Middle (second) name.
   */
  middleName?: string;

  /**
   * Family name (surname, last name).
   */
  familyName: string = '';
}
