namespace Skyware.Lis.AkitaModel {
    /**
     * Sample type, e.g. Serum, Whole blood, Stool, etc.
     */
    export class SampleType {
  
      /**
       * PK in LIS iLab.
       */
      Id?: number;  // Optional (nullable)
  
      /**
       * Name of the sample type, e.g. "Serum", "Whole blood", "Stool", etc.
       */
      Name: string;
  
      /**
       * Short code, used across the laboratory, e.g. "Serum", "WB", etc.<br/>
       * This is the code that usually is printed on sample tubes.
       */
      Code: string;
  
      /**
       * Red component of the sample color code (optional).
       */
      ColorR?: number;
  
      /**
       * Green component of the sample color code (optional).
       */
      ColorG?: number;
  
      /**
       * Blue component of the sample color code (optional).
       */
      ColorB?: number;
  
      /**
       * Material code, e.g. "WB" (Whole Blood in HL7 table 0487).<br/>
       * See <see href="http://terminology.hl7.org/CodeSystem/v2-0487"/>.
       */
      TypeCode: string;
  
      /**
       * Sample additive/preservative code, e.g. "EDTK" (Potassium/K EDTA in HL7 table 0371).<br/>
       * See <see href="http://terminology.hl7.org/CodeSystem/v2-0371"/>.
       */
      AdditiveCode: string;
  
      /**
       * Specimen source code, e.g. "BLDV" (Blood venous in HL7 table 0070).<br/>
       * See <see href="https://terminology.hl7.org/4.0.0/CodeSystem-v2-0070.html"/>.
       */
      SpecimenSourceCode: string;
    }
  }
  
  export { Skyware.Lis.AkitaModel.SampleType };
  