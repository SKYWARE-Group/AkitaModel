package skyware.lis.akitamodel;

import lombok.Data;

/**
 * Sample type, e.g. Serum, Whole blood, Stool, etc.
 */
@Data
public class SampleType {

    /**
     * PK in LIS iLab.
     */
    private Integer id;

    /**
     * Name of the sample type, e.g. "Serum", "Whole blood", "Stool", etc.
     */
    private String name;

    /**
     * Short code, used across the laboratory, e.g. "Serum", "WB", etc.
     * This is the code that usually is printed on sample tubes.
     */
    private String code;

    /**
     * Red component of the sample color code.
     */
    private Integer colorR;

    /**
     * Green component of the sample color code.
     */
    private Integer colorG;

    /**
     * Blue component of the sample color code.
     */
    private Integer colorB;

    /**
     * Material code, e.g. "WB" (Whole Blood in HL7 table 0487).
     * See http://terminology.hl7.org/CodeSystem/v2-0487
     */
    private String typeCode;

    /**
     * Sample additive/preservative code, e.g. "EDTK" (Potassium/K EDTA in HL7 table 0371).
     * See http://terminology.hl7.org/CodeSystem/v2-0371
     */
    private String additiveCode;

    /**
     * Specimen source code, e.g. "BLDV" (Blood venous in HL7 table 0070).
     * See https://terminology.hl7.org/4.0.0/CodeSystem-v2-0070.html
     */
    private String specimenSourceCode;

}
