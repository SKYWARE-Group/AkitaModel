/**
 * Skyware.Lis.AkitaModel
 */

import { ReferenceRange } from './ReferenceRange';
import { SampleType } from './SampleType';
import { FlagType } from './FlagType';
import { FlagLevelLimits } from './FlagLevelLimits';
import { ResultTypes } from './ResultTypes';
import { ResultEntry } from './ResultEntry';

/**
 * Test (analyte).
 */
export class Test {
  /**
   * Primary key.
   */
  id!: number;

  /**
   * Name of the test (analyte), e.g. "Glucose".
   */
  name?: string;

  /**
   * Long name of the test (analyte), e.g. "Glucose in Serum".
   */
  longName?: string;

  /**
   * Foreign key to department this test belongs to.
   */
  departmentId?: number;

  /**
   * Sorting value.
   */
  rank?: number;

  /**
   * LOINC code of the test.
   * @see https://loinc.org/
   */
  loincCode?: string;

  /**
   * Measurement units of the test.
   */
  units?: string;

  /**
   * Type of the result (numeric, text, etc.), see ResultTypes.
   */
  resultType: ResultTypes = ResultTypes.Text;

  /**
   * When result type is semiquantitative, this flag show which range stands for negative results.
   * Suppose test is defined as semiquantitative with gray zone 9-11.
   * If this flag is true, then values under 9 will be considered as negative.
   */
  negativeIsLow: boolean = true;

  /**
   * Scale is the number of digits to the right of the decimal point in a number.
   * Applicable only if result type is ResultTypes.Quantitative or ResultTypes.SemiQuantitative.
   */
  scale!: number;

  /**
   * Foreign key to SampleType.
   */
  sampleTypeID?: number;

  /**
   * SampleType of the test.
   */
  sampleType?: SampleType;

  /**
   * Foreign key to Flag Types.
   */
  flagTypeId?: number;

  /**
   * Applicable flags, such as "+", "↑", "3+", etc.
   */
  flagType?: FlagType;

  /**
   * If false, test should be considered as "internal use only" and shouldn't be reported to third parties.
   */
  showInResults?: boolean = true;

  /**
   * Maximum allowed flag level.
   */
  flagLimit: FlagLevelLimits = FlagLevelLimits.UP_TO_ULTRA;

  /**
   * Collection of ReferenceRange for given test.
   * Note that in case of ResultTypes.SemiQuantitative tests, FlagLevels.LOW and FlagLevels.HIGH
   * stand for gray zone and aren't reference range limits!
   */
  ranges: ReferenceRange[] = [];

  // TODO: resultListId
  // TODO: resultList (rename here or in core)

  /**
   * List of allowed values, applicable only if result type is ResultTypes.List.
   * When result is found amongst values, it will be flagged as level, defined in ResultEntry.FlagLevel.
   */
  allowedResults: ResultEntry[] = [];
}
