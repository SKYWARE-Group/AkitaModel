import { ItemBase } from "./ItemBase";

namespace Skyware.Lis.AkitaModel.Results {
  /**
   * Base class for Panel and Test.
   */
  export abstract class ExaminationBase extends ItemBase {
    /**
     * If the examination is a panel, this property will be true.
     */
    abstract IsPanel: boolean;
  }
}

export { Skyware.Lis.AkitaModel.Results.ExaminationBase };
