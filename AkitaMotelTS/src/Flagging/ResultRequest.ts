/**
 * Skyware.Lis.AkitaModel.Flagging
 */

/**
 * Represents DTO for Flagging API call.
 */
export class ResultRequest {
  /**
   * Date of birth of the patient.
   * Default value for is 33 years and 6 months old.
   */
  dateOfBirth?: Date = new Date(new Date().setFullYear(new Date().getFullYear() - 33, new Date().getMonth() - 6));

  /**
   * Gender indicator of the patient. By default is null (Unknown).
   */
  isMale?: boolean; // No default gender

  /**
   * Id of the patient's species. By default is 1 (Human).
   */
  speciesId?: number = 1; // Human in LIS iLab

  /**
   * Date/time the sample was taken.
   */
  sampleDate?: Date = new Date();

  /**
   * References the taken test identifier.
   */
  testId!: number;

  /**
   * Text representation of the test result.
   */
  textResult?: string;

  /**
   * Numeric prefixes of the result.
   */
  numericPrefix?: string;

  /**
   * Numeric result of the test.
   */
  numericResult?: number;

  /**
   * Reference Id, e.g. SaleItemId, Sample barcode, etc.
   */
  refId?: string;
}
