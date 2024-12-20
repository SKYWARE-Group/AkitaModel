namespace Skyware.Lis.AkitaModel {

    /**
     * Represents base class for notes.
     */
    export abstract class NoteBase {

        /**
         * PK in LIS iLab.
         */
        public id?: number;

        /**
         * Text of the note.
         */
        public text: string = '';

    }

}
