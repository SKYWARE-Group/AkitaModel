package skyware.lis.akitamodel;

/**
 * Defines limit of flagging, e.g., up to alarm 1.
 */
public enum FlagLevelLimits {

    /**
     * Do not use flags at all.
     */
    NO_FLAG((byte) 0),

    /**
     * Up to Alarm 1 - High/Low.
     */
    UP_TO_LOW_HIGH((byte) 1),

    /**
     * Up to Alarm 2 - Very High/Low.
     */
    UP_TO_VERY((byte) 2),

    /**
     * Up to Alarm 3 - Ultra High/Low.
     */
    UP_TO_ULTRA((byte) 3);

    private final byte value;

    FlagLevelLimits(byte value) {
        this.value = value;
    }

    /**
     * Gets the byte value associated with the flag level limit.
     * @return the byte value of the flag level limit.
     */
    public byte getValue() {
        return value;
    }

}

