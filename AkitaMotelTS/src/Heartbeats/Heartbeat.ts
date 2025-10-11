/**
 * Skyware.Lis.AkitaModel.Heartbeats
 */

import { Host } from '../Host';
import { ApplicationBase } from './ApplicationBase';

/**
 * Represents a heartbeat message.
 */
export class Heartbeat {
  /**
   * UTC date/time of the Heartbeat message.
   */
  heartbeatTime: Date = new Date();

  /**
   * Local date/time of the Heartbeat message;
   */
  get localHeartbeatTime(): Date {
    return new Date(this.heartbeatTime.toLocaleString());
  }

  /**
   * Host where the heartbeat was generated.
   */
  host: Host = new Host();

  locationId?: string;

  locationName?: string;

  /**
   * Application that generated the heartbeat.
   */
  application?: ApplicationBase;
}
