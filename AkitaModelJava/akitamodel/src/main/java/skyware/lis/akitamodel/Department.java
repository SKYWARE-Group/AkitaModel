package skyware.lis.akitamodel;

import lombok.Data;

/**
 * Department is a group of tests (analytes) and panels/profiles.
 */
@Data
public class Department {

    /**
     * Primary key.
     */
    private int id;

    /**
     * Name of the department.
     */
    private String name;

    /**
     * Label to be shown on results report for items in this department.
     */
    private String rangeText;

    /**
     * Sorting value.
     */
    private int rank;
    
}

