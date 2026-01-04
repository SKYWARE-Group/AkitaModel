/**
 * Skyware.Lis.AkitaModel.BgNhis
 */

// Ignore Spelling: nrn

import { NhifContract } from './NhifContract';

/**
 * Referral import request.
 */
export class ReferralImportRequest {
  /**
   * National Reference Number in NHIS (НРН в НЗИС).
   */
  nrn?: string;

  /**
   * Visit date
   */
  visitDate: Date = new Date();

  /**
   * Sample date
   */
  sampleDate: Date = new Date();

  /**
   * Result date
   */
  resultsDate: Date = new Date();

  /**
   * Nhif contract
   */
  nhifContract?: NhifContract;
}
