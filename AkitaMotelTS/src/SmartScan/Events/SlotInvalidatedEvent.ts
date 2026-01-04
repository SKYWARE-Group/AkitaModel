/**
 * Skyware.Lis.AkitaModel.SmartScan.Events
 */

import { ITypedEvent } from './ITypedEvent';

/**
 * Represents invalidation of a slot.
 * This is an event payload object (SignalR).
 */
export class SlotInvalidatedEvent implements ITypedEvent {
  /**
   * Id of the invalidated slot
   */
  id?: string;

  /** @inheritdoc */
  get methodName(): string {
    return 'slotinvalidated';
  }
}
