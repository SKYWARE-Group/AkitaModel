/**
 * Skyware.Lis.AkitaModel.BgNhis
 */

// Ignore Spelling: lis

/**
 * NHIF covered examination (Изследване, платимо от НЗОК).
 */
export class Examination {
  /**
   * Code according to NHIF (НЗОК).
   */
  nhifCode?: string;

  /**
   * Flag, indicating ordering rules of NHIF (високо-специализирано изследване, ВСД)
   */
  isSpecialized!: boolean;

  /**
   * Code according to NHIS (НЗИС) set CL022.
   */
  nhisCode?: string;

  /**
   * Name of product according to NHIF (НЗОК).
   */
  name?: string;

  /**
   * Mapped LOINC code, according to this laboratory
   */
  loincCode?: string;

  /**
   * Id of the corresponding LIS test
   */
  testId?: number;

  /**
   * Id of the corresponding LIS profile/panel
   */
  profileId?: number;

  /**
   * Examination name, according to laboratory
   */
  lisName?: string;
}
