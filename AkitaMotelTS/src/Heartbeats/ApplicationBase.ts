/**
 * Skyware.Lis.AkitaModel.Heartbeats
 */

import { DeviceBase } from './DeviceBase';

/**
 * Represents an application that generates a heartbeat.
 */
export abstract class ApplicationBase {
  /**
   * Name of the application.
   */
  name?: string;

  /**
   * Version of the application.
   */
  version?: string;

  /**
   * Username of the user that is currently logged in the application.
   */
  username?: string;

  /**
   * Uptime of the application (in milliseconds).
   */
  uptime?: number;

  /**
   * List of devices that are available to the application.
   */
  availableDevices: DeviceBase[] = [];
}
