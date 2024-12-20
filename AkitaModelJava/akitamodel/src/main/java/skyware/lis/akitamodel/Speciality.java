package skyware.lis.akitamodel;

import lombok.Data;

/**
 * Medical speciality of a doctor, e.g., General practitioner, Surgeon, etc.
 */
@Data
public class Speciality {

    /**
     * PK in LIS iLab.
     */
    private Integer id;

    /**
     * Name of the speciality, e.g., "Surgeon".
     */
    private String name;
    
}
