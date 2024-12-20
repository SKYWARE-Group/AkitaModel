namespace Skyware.Lis.AkitaModel {
  /**
   * Represents base class for notes.
   */
  export abstract class NoteBase {
    /**
     * PK in LIS iLab.
     */
    public Id?: number;

    /**
     * Text of the note.
     */
    public Text: string = "";
  }
}

export { Skyware.Lis.AkitaModel.NoteBase };
