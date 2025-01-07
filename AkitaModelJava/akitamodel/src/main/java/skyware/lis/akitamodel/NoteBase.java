package skyware.lis.akitamodel;

import lombok.Data;

/**
 * Represents base class for notes.
 */
@Data
public abstract class NoteBase {

    /**
     * PK in LIS iLab.
     */
    private Integer id;

    /**
     * Text of the note.
     */
    private String text = "";
    
}
