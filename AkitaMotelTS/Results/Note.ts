import { NoteLevels } from "./NoteLevels";
import { NoteBase } from "../NoteBase";

namespace Skyware.Lis.AkitaModel.Results {
  /**
   * Represents a note that may appear at visit or department level.
   */
  export class Note extends NoteBase {
    /**
     * Level of importance of the note.
     */
    Level: NoteLevels = NoteLevels.Info;

    /**
     * True if the note can be dismissed by the user.
     */
    IsDismissible: boolean = false;
  }
}


export { Skyware.Lis.AkitaModel.Results.Note };
