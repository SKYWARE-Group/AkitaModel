/**
 * Skyware.Lis.AkitaModel.SmartScan.Events
 */

import { FileBase } from '../FileBase';
import { ITypedEvent } from './ITypedEvent';

/**
 * Represents a file uploaded to BLOB storage.
 * This is an event payload object (SignalR).
 */
export class FileEvent extends FileBase implements ITypedEvent {
  /**
   * Id of the attachment type
   */
  documentTypeId!: number;

  /** @inheritdoc */
  get methodName(): string {
    return 'file';
  }
}
