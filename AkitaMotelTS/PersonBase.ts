namespace Skyware.Lis.AkitaModel {
    /**
     * Abstract class for people.
     */
    export abstract class PersonBase {
      /**
       * PK (Primary Key).
       */
      Id?: number;
  
      /**
       * Given (first) name.
       */
      GivenName: string = "";
  
      /**
       * Middle (second) name.
       */
      MiddleName?: string;
  
      /**
       * Family name (surname, last name).
       */
      FamilyName: string = "";
    }
  }
  
  export { Skyware.Lis.AkitaModel.PersonBase };
  