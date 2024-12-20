import { VisitBase } from "../VisitBase";
import { Note } from "./Note";
import { DepartmentResults } from "./DepartmentResults";
import { Sample } from "./Sample";
import { Footnote } from "../Footnote";

namespace Skyware.Lis.AkitaModel.Results {
  /**
   * Represents a Visit view with structure for results reporting.
   */
  export class VisitResults extends VisitBase {
    /**
     * List of visit-level notes and announcements.
     */
    Notes: Note[] = [];

    /**
     * List of departments with results.
     */
    DepartmentResults: DepartmentResults[] = [];

    /**
     * List of samples used in examinations.
     */
    Samples: Sample[] = [];

    /**
     * Footnotes list.
     */
    Footnotes: Footnote[] = [];
  }
}
