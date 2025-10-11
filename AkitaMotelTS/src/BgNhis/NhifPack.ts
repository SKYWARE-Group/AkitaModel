/**
 * Skyware.Lis.AkitaModel.BgNhis
 */

import { Examination } from './Examination';

/**
 * NHIF (НЗОК) пакет дейности
 */
export class NhifPack {
  /**
   * NHIF (НЗОК) code.
   */
  code?: string;

  /**
   * Name, according to NHIF (НЗОК).
   */
  name?: string;

  /**
   * Examinations (Изследвания)
   */
  examinations?: Examination[];
}
