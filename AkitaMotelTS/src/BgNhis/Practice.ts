/**
 * Skyware.Lis.AkitaModel.BgNhis
 */

/**
 * Medical practice, registered in Bulgaria.
 */
export class Practice {
  /**
   * Practice number (РЦЗ/РЗИ код) of the laboratory, mandatory.
   */
  practiceNumber: string = '';

  /**
   * NHIF number of the practice (НЗОК номер), optional.
   */
  nhifNumber?: string;

  /**
   * Laboratory name, optional.
   */
  name?: string;
}
