package skyware.lis.akitamodel;

import lombok.Data;

/**
 * Species, e.g., Human, Dog, Cat, etc.
 */
@Data
public class Species {

    /**
     * Primary key. Value 1 is reserved for "Human".
     */
    private int id;

    /**
     * Name of the species, e.g., "Human".
     */
    private String name;
    
}

