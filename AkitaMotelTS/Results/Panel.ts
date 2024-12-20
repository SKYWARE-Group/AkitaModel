import { ExaminationBase } from "./ExaminationBase";
import { Test } from "./Test";

namespace Skyware.Lis.AkitaModel.Results {
  /**
   * Represents a panel of tests (Profile).
   */
  export class Panel extends ExaminationBase {
    /**
     * If the examination is a panel, this property will be true.
     */
    IsPanel: boolean = true;

    /**
     * Test items that are part of the panel.
     */
    Tests: Test[] = [];
  }
}
