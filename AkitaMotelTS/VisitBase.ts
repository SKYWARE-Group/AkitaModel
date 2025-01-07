import { Patient } from "./Patient";

namespace Skyware.Lis.AkitaModel {
  /**
   * Patient visit. This is a base class for all types of visits.
   */
  export abstract class VisitBase {
    /**
     * PK in LIS iLab.
     */
    Id: number;

    /**
     * Date/time the visit was created.
     */
    Date: Date;

    /**
     * Visiting patient.
     */
    Patient: Patient;
  }
}

export { Skyware.Lis.AkitaModel.VisitBase };