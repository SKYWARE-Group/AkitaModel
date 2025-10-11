/**
 * Skyware.Lis.AkitaModel.SmartScan
 */

/**
 * Base class for file description.
 */
export abstract class FileBase {
  /**
   * Id of the file as it is known in the BLOB storage, e.g. '123-456-789.pdf'.
   */
  fileId?: string;

  /**
   * File name as it is known in the file systems, e.g. 'my-doc.docx'.
   */
  name?: string;

  /**
   * Id of a slot to which the client is connected.
   */
  slotId?: string;
}
