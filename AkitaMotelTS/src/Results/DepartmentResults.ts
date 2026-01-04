/**
 * Skyware.Lis.AkitaModel.Results
 */

import { ExaminationBase } from './ExaminationBase';
import { Note } from './Note';

/**
 * Wrapper class of examination results that follows structure of the printout.
 */
export class DepartmentResults {
  /**
   * PK of the Department in LIS iLab.
   */
  departmentId!: number;

  /**
   * Name of the department.
   */
  departmentName: string = '';

  /**
   * Rank of the department, use it for sorting.
   */
  rank!: number;

  /**
   * Label for the reference range column for this department.
   */
  rangeLabel?: string;

  /**
   * Department-level note.
   */
  note?: Note;

  /**
   * List of examination results.
   */
  results?: ExaminationBase[];
}
