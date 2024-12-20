import { ExaminationBase } from "./ExaminationBase";
import { FlagLevels } from "../FlagLevels";

namespace Skyware.Lis.AkitaModel.Results {
  /**
   * Represents a single test (analyte, assay) result.
   */
  export class Test extends ExaminationBase {
    /**
     * If the examination is a panel, this property will be false for tests.
     */
    IsPanel: boolean = false;

    /**
     * The result of the test.
     */
    TextResult: string = "";

    /**
     * Measurement units.
     */
    Units?: string;

    /**
     * Applicable reference range.
     */
    ReferenceRange?: string;

    /**
     * Level of the abnormality flag.
     */
    FlagLevel?: FlagLevels;

    /**
     * Text of the abnormality flag.
     */
    FlagText: string = "";

    /**
     * FK to the footnote in LIS iLab.
     */
    FootnoteId?: number;
  }
}

export { Skyware.Lis.AkitaModel.Results.Test };
