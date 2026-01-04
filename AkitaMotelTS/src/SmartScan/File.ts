/**
 * Skyware.Lis.AkitaModel.SmartScan
 */

import { FileBase } from './FileBase';

/**
 * Binary file with metadata.
 */
export class File extends FileBase {
  /**
   * Base64 encoded binary data of a file.
   */
  data?: string;
}
