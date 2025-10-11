/**
 * Skyware.Lis.AkitaModel.SmartScan.Events
 */

import { ITypedEvent } from './ITypedEvent';

/**
 * Represents a connection made from browser (mobile) to the server.
 * This is an event payload object (SignalR).
 */
export class Connection implements ITypedEvent {
  /**
   * Public IP address of the connected device.
   */
  ipAddress?: string;

  /**
   * Browser identity of the connected device.
   */
  browser?: string;

  /**
   * Id of a slot to which the client is connected.
   */
  slotId?: string;

  /** @inheritdoc */
  get methodName(): string {
    return 'connection';
  }
}
