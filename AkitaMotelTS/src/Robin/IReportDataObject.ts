/**
 * Skyware.Lis.AkitaModel.Robin
 */

/**
 * Data object that can be encoded as Base64.
 */
export interface IReportDataObject {
  /**
   * Serialize to JSON and converts it to Base64 string.
   */
  getBase64Data(): string;
}
