/**
 * Skyware.Lis.AkitaModel
 */

/**
 * Represents base class for notes.
 */
export abstract class NoteBase {
  /**
   * PK in LIS iLab.
   */
  id?: number;

  /**
   * Text of the note.
   */
  text: string = '';
}
