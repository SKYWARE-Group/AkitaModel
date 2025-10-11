/**
 * Skyware.Lis.AkitaModel.Courier
 */

// Ignore Spelling: hl

/**
 * HL7 syntax dialect.
 */
export class Dialect {
  /**
   * Identifier in the Courier system, e.g. "hl7.251.basic".
   */
  id?: string;

  /**
   * Friendly name, e.g. "HL7 v2.5.1 Basic".
   */
  name?: string;

  /**
   * Base HL7 version, e.g. "2.5.1".
   */
  hl7Version?: string;

  /**
   * Description and further details.
   */
  description?: string;

  /**
   * True if this dialect is default one for Courier system.
   */
  isDefault: boolean = false;
}
