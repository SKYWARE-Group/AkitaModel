/**
 * Skyware.Lis.AkitaModel.Results
 */

import { ExaminationBase } from './ExaminationBase';
import { FlagLevels } from '../FlagLevels';

/**
 * Represents a single test (analyte, assay) result.
 */
export class Test extends ExaminationBase {
  /** @inheritdoc */
  get isPanel(): boolean {
    return false;
  }

  /**
   * The result of the test.
   */
  textResult: string = '';

  /**
   * The numeric result of the test.
   */
  numericResult?: number;

  /**
   * Prefix (leading value modifier), e.g. '<<<', '>=', etc.
   */
  numericPrefix?: string;

  /**
   * Measurement units.
   */
  units?: string;

  /**
   * Applicable reference range.
   */
  referenceRange?: string;

  /**
   * Level of the abnormality flag.
   */
  flagLevel?: FlagLevels;

  /**
   * Text of the abnormality flag.
   */
  flagText?: string;

  /**
   * FK to the footnote in LIS iLab.
   */
  footnoteId?: number;
}
