import { SampleType } from "./SampleType";

namespace Skyware.Lis.AkitaModel {
    /**
     * Base class for sample, used in other derived sample types.
     */
    export abstract class SampleBase {
  
      /**
       * PK in LIS iLab.
       */
      Id?: number;  // Optional (nullable)
  
      /**
       * Type of the sample.
       */
      SampleType: SampleType;
  
      /**
       * Barcode on the label.
       */
      Barcode: string;
  
      /**
       * Date and time the sample was taken.
       */
      Taken?: Date;  // Optional (nullable)
  
    }
  }
  
  export { Skyware.Lis.AkitaModel.SampleBase };
  