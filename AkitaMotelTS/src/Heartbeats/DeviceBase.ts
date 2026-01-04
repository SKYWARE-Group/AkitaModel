/**
 * Skyware.Lis.AkitaModel.Heartbeats
 */

// Ignore Spelling: epson

/**
 * Represents a device which is available to the given application.
 */
export abstract class DeviceBase {
  /**
   * Brand of the device, e.g. "Epson", "Datecs", etc.
   */
  brand?: string;

  /**
   * Model of the device, e.g. "TM-T88V", "MP55", etc.
   */
  model?: string;

  /**
   * Serial number or ID of the device, e.g. fiscal memory number, POS terminal Id, etc.
   */
  serialNumberOrId?: string;
}
