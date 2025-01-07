package skyware.lis.akitamodel;

import lombok.Data;

/**
 * Abstract class for people.
 */
@Data
public abstract class PersonBase {

    /**
     * Unique identifier (PK).
     */
    private Integer id;

    /**
     * Given (first) name.
     */
    private String givenName = "";

    /**
     * Middle (second) name.
     */
    private String middleName;

    /**
     * Family (last) name (Surname).
     */
    private String familyName = "";

}
