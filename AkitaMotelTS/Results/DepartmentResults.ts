import { Note } from "./Note";
import { ExaminationBase } from "./ExaminationBase";

namespace Skyware.Lis.AkitaModel.Results {
  /**
   * Wrapper class of examination results that follows structure of the printout.
   */
  export class DepartmentResults {
    /**
     * PK of the Department in LIS iLab.
     */
    DepartmentId: number;

    /**
     * Name of the department.
     */
    DepartmentName: string = "";

    /**
     * Rank of the department, use it for sorting.
     */
    Rank: number;

    /**
     * Label for the reference range column for this department.
     */
    RangeLabel: string;

    /**
     * Department-level note.
     */
    Note: Note;

    /**
     * List of examination results.
     */
    Results: ExaminationBase[];
  }
}

export { Skyware.Lis.AkitaModel.Results.DepartmentResults };

