import { ItemBase } from "./ItemBase";

namespace Skyware.Lis.AkitaModel.Results {
  /**
   * Represents an orderable/payable product in Sale.
   */
  export class Product extends ItemBase {
    /**
     * Price of the product, payable by the patient.
     */
    Price: number;
  }
}
