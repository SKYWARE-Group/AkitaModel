/**
 * Skyware.Lis.AkitaModel
 */

/**
 * Sample type, e.g. Serum, Whole blood, Stool, etc.
 */
export class SampleType {
  /**
   * PK in LIS iLab.
   */
  id?: number;

  /**
   * Name of the sample type, e.g. "Serum", "Whole blood", "Stool", etc.
   */
  name?: string;

  /**
   * Short code, used across the laboratory, e.g. "Serum", "WB", etc.
   * This is the code that usually is printed on sample tubes.
   */
  code?: string;

  /**
   * Red component of the sample color code.
   */
  colorR?: number;

  /**
   * Green component of the sample color code.
   */
  colorG?: number;

  /**
   * Blue component of the sample color code.
   */
  colorB?: number;

  /**
   * Material code, e.g. "WB" (Whole Blood in HL7 table 0487).
   * See http://terminology.hl7.org/CodeSystem/v2-0487
   */
  typeCode?: string;

  /**
   * Sample additive/preservative code, e.g. "EDTK" (Potassium/K EDTA in HL7 table 0371).
   * See http://terminology.hl7.org/CodeSystem/v2-0371
   */
  additiveCode?: string;

  /**
   * Specimen source code, e.g. "BLDV" (Blood  venous in HL7 table 0070).
   * See https://terminology.hl7.org/4.0.0/CodeSystem-v2-0070.html
   */
  specimenSourceCode?: string;
}
