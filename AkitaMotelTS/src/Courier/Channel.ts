/**
 * Skyware.Lis.AkitaModel.Courier
 */

/**
 * Communication channel.
 */
export class Channel {
  /**
   * PK.
   */
  id!: number;

  /**
   * Human-friendly name.
   */
  name?: string;

  /**
   * Filtering parameter. If null - any schema.
   */
  schemaId?: number;

  /**
   * Filtering parameter. If null - any fund.
   */
  fundId?: number;

  filterScript?: string;

  dialect?: string;

  dialectParams?: any;

  transport?: string;

  transportParams?: any;

  target?: string;

  targetParams?: any;

  isActive: boolean = true;

  /**
   * API key for HTTP GET transport.
   */
  apiKeyGet?: string;

  created: Date = new Date();

  /**
   * Creation time as local date/time.
   */
  get createdLocalTime(): Date {
    return new Date(this.created.toLocaleString());
  }

  modified?: Date;

  /**
   * Modification time as local date/time.
   */
  get modifiedLocalTime(): Date | undefined {
    return this.modified ? new Date(this.modified.toLocaleString()) : undefined;
  }
}
