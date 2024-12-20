import { PersonBase } from "./PersonBase";

namespace Skyware.Lis.AkitaModel {
    /**
     * Patient.
     */
    export class Patient extends PersonBase {

      /**
       * Patient's identifier descriptor.
       */
      PidTypeId?: number;
  
      /**
       * Name of the identifier.
       */
      PidTypeIdName: string = "";
  
      /**
       * Patient's identifier is unique.
       */
      PidTypeIdIsIdentity: boolean = true;
  
      /**
       * Well-known identifier, e.g. SSN, EGN, etc.
       */
      PatientId: string;
  
      /**
       * Gender indicator.
       */
      IsMale?: boolean;
  
      /**
       * Id of a species of the patient. Default (null) means human.
       */
      SpeciesId?: number;
  
      /**
       * Name of a species of the patient (human, cat, dog, etc.).
       */
      SpeciesIdName: string = "";
  
      /**
       * Date of birth.
       */
      DateOfBirth?: Date;

  
      /**
       * Indicator whether date of birth is approximate or exact.
       */
      IsDobApprox?: boolean;
    }
  }
  
  export { Skyware.Lis.AkitaModel.Patient };
  