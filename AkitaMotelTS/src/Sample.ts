/**
 * Skyware.Lis.AkitaModel
 */

import { SampleBase } from './SampleBase';

/**
 * Sample to be examined.
 */
export class Sample extends SampleBase {
  /**
   * FK to other sample, in case of aliquot or otherwise sample derivate.
   */
  parentId?: number;

  /**
   * FK to Sale/Visit.
   */
  saleId?: number;

  /**
   * FK to Location where sample is located currently.
   */
  currentLocationId?: number;

  /**
   * List of codes printed on sample label, e.g. "BC->MIC->RET".
   * Should be printed on sample label.
   */
  processingPoints?: string;
}
