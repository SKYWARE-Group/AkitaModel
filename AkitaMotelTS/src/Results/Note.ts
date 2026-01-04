/**
 * Skyware.Lis.AkitaModel.Results
 */

import { NoteBase } from '../NoteBase';
import { NoteLevels } from './NoteLevels';

// Ignore Spelling: Dismissible

/**
 * Represents a note that may appear at visit or department level.
 */
export class Note extends NoteBase {
  /**
   * Level of importance of the note.
   */
  level: NoteLevels = NoteLevels.Info;

  /**
   * True if the note can be dismissed by the user.
   */
  isDismissible: boolean = false;
}
