/**
 * Skyware.Lis.AkitaModel.SmartScan
 */

import { File } from './File';
import { SlotModes } from './SlotModes';
import { FileEvent } from './Events/FileEvent';

/**
 * Represents a slot for uploading files.
 */
export class Slot {
  /**
   * Base URL for subscribe and unsubscribe
   */
  protected readonly _baseUrl?: string;

  /**
   * Default Constructor
   */
  constructor(baseUrl?: string) {
    if (baseUrl) {
      this._baseUrl = baseUrl;
    }
  }

  /**
   * Id of the slot, server generated.
   */
  id?: string;

  /**
   * Collection of files uploaded in this slot.
   */
  files?: File[];

  /**
   * Upload mode, see SlotModes
   */
  mode: SlotModes = SlotModes.PDF;

  /**
   * Subscribe to events.
   * @param onMobileConnected Function to be executed when client is 'connected'.
   * @param onFileCreated Function to be executed when client upload a file.
   */
  subscribe(onMobileConnected?: () => void, onFileCreated?: (event: FileEvent) => void): void {
    // Implementation would depend on SignalR or WebSocket library
  }

  /**
   * Unsubscribe from events.
   */
  unsubscribe(): void {
    // Implementation would depend on SignalR or WebSocket library
  }
}
