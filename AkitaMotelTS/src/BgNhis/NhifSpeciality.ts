/**
 * Skyware.Lis.AkitaModel.BgNhis
 */

/**
 * NHIF/NHIS (НЗОК/НЗИС) speciality.
 */
export class NhifSpeciality {
  /**
   * Code, according to NHIF (НЗОК).
   */
  nhifCode?: string;

  /**
   * Code, according to NHIS (НЗИС), set CL006.
   */
  nhisCode?: string;

  /**
   * Name of the speciality, according to NHIF (НЗОК).
   */
  name?: string;
}
