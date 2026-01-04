/**
 * Skyware.Lis.AkitaModel.BgNhis
 */

import { Schema } from './Schema';
import { ReferralImportRequest } from './ReferralImportRequest';

/**
 * Request for NHIS referrals import.
 */
export class ImportRequest {
  /**
   * Name of requesting application.
   */
  applicationName?: string;

  /**
   * Processing points location Id.
   */
  procPointLocationId?: string;

  /**
   * Sale schema.
   */
  schema?: Schema;

  /**
   * Reception location Id.
   */
  regLocationId?: string;

  /**
   * Location Id.
   */
  locationId?: string;

  /**
   * Application user.
   */
  userName?: string;

  /**
   * Id of the existing Sale the referrals must be added.
   */
  saleId?: number;

  /**
   * Collection of referrals to be imported.
   */
  referrals: ReferralImportRequest[] = [];
}
