/**
 * Skyware.Lis.AkitaModel.SmartScan.Events
 */

import { ITypedEvent } from './ITypedEvent';

/**
 * Represents slot for ad hoc client for taking pictures.
 * This is an event payload object (SignalR).
 */
export class SlotStatus implements ITypedEvent {
  /**
   * Id of a slot (encoded in endpoint URL).
   */
  id?: string;

  /**
   * True if slot is available.
   */
  isValid: boolean = false;

  /** @inheritdoc */
  get methodName(): string {
    return 'slot';
  }
}
