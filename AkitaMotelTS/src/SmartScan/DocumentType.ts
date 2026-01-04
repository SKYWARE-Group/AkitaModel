/**
 * Skyware.Lis.AkitaModel.SmartScan
 */

/**
 * Represents the type of the uploaded file.
 */
export class DocumentType {
  /**
   * Id of the document type (local database).
   */
  id!: number;

  /**
   * Name of the document type.
   */
  name?: string;

  /**
   * Amount of days the document will expire.
   */
  expirationDays?: number;

  /**
   * Available file extensions for the document type,
   * comma separated values e.g. 'png,jpeg,jpg,pdf'
   */
  fileExtentions?: string;

  /**
   * Method/Service of storage.
   */
  defaultStorageType?: number;
}
