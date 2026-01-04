/**
 * Skyware.Lis.AkitaModel.SmartScan
 */

/**
 * Slot modes - instructs the service how to save pictures.
 */
export enum SlotModes {
  /**
   * None, will save files as they are uploaded.
   */
  None = 0,

  /**
   * Files will be saved as JPEG.
   */
  JPEG = 1,

  /**
   * Files will be put in PDF document.
   */
  PDF = 2
}
