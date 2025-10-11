/**
 * Skyware.Lis.AkitaModel
 */

import { SampleType } from './SampleType';

export abstract class SampleBase {
  /**
   * PK in LIS iLab.
   */
  id?: number;

  /**
   * Type of the sample.
   */
  sampleType?: SampleType;

  /**
   * Barcode on the label.
   */
  barcode?: string;

  /**
   * Date and time the sample was taken.
   */
  taken?: Date;
}
