/**
 * Skyware.Lis.AkitaModel.Robin
 */

// Ignore Spelling: bg

import { IReportDataObject } from './IReportDataObject';

/**
 * Payload class for report generation.
 */
export class ReportRequest {
  /**
   * Default c-tor.
   */
  constructor(data?: IReportDataObject) {
    if (data) {
      this.setData(data);
    }
  }

  /**
   * Culture (Locale) of the report, e.g. "en-US", "bg-BG", etc.
   * @remarks
   * This field is optional and if it isn't provided, server's default will be applied.
   */
  culture: string = '';

  /**
   * **Base64 encoded JSON** collection of parameters.
   * @remarks
   * JSON before Base64 encoding is a key-value pair dictionary and looks like this:
   * ```
   * {
   *   "key1": "value1",
   *   "key2": 2,
   *   "key3": 3.14
   * }
   * ```
   * This field is optional.
   */
  parameters: string = '';

  /**
   * **Base64 encoded JSON** with data source.
   * @remarks
   * Consult the report's source for the model.
   * This field is optional.
   */
  data: string = '';

  /**
   * Set data object as Base64 encoded string.
   * @param data Report data object
   */
  setData(data: IReportDataObject): void {
    this.data = data.getBase64Data();
  }
}
