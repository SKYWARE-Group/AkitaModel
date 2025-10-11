/**
 * Skyware.Lis.AkitaModel.Results
 */

import { VisitBase } from '../VisitBase';
import { Note } from './Note';
import { DepartmentResults } from './DepartmentResults';
import { Sample } from './Sample';
import { Footnote } from '../Footnote';

/**
 * Represents a Visit view with structure for results reporting.
 */
export class VisitResults extends VisitBase {
  /**
   * List of visit-level notes and announcements.
   */
  notes?: Note[];

  /**
   * List of departments with results.
   */
  departmentResults?: DepartmentResults[];

  /**
   * List of samples used in examinations.
   */
  samples?: Sample[];

  /**
   * Footnotes list.
   */
  footnotes?: Footnote[];
}
