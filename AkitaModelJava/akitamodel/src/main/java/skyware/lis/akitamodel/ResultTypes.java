package skyware.lis.akitamodel;

/**
 * Result types.
 */
public enum ResultTypes {

    /**
     * Textual result.
     */
    Text((byte) 4),

    /**
     * Numeric result, usually represents concentration.
     */
    Quantitative((byte) 1),

    /**
     * Semi-quantitative, cut-off result.
     */
    SemiQuantitative((byte) 5),

    /**
     * Ratio, such as 1:2, 2:16, 3:5, etc.
     */
    Ratio((byte) 2),

    /**
     * Value amongst list of allowed values.
     */
    List((byte) 3);

    private final byte value;

    ResultTypes(byte value) {
        this.value = value;
    }

    public byte getValue() {
        return value;
    }
}

