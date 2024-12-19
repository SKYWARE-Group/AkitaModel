package skyware.lis.akitamodel;

/**
 * Possible flag levels.
 */
public enum FlagLevels {

    /**
     * Ultra low results (below alarm 2).
     */
    ULTRA_LOW((byte) 1),

    /**
     * Very low results (below alarm 1).
     */
    VERY_LOW((byte) 2),

    /**
     * Low results (below reference range).
     */
    LOW((byte) 3),

    /**
     * No flag.
     */
    NONE((byte) 4),

    /**
     * High results (above reference range).
     */
    HIGH((byte) 5),

    /**
     * Very high results (above alarm 1).
     */
    VERY_HIGH((byte) 6),

    /**
     * Ultra high results (above alarm 2).
     */
    ULTRA_HIGH((byte) 7),

    /**
     * Abnormal non-numeric result.
     */
    WITH_STAR((byte) 10),

    /**
     * Semi-quantitative result within gray zone.
     */
    SEMI_QUANT_QUESTION((byte) 11);

    private final byte value;

    FlagLevels(byte value) {
        this.value = value;
    }

    /**
     * Gets the byte value associated with the flag level.
     * @return the byte value of the flag level.
     */
    public byte getValue() {
        return value;
    }
    
}
