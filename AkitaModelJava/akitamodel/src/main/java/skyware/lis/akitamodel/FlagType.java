package skyware.lis.akitamodel;

import lombok.Data;

/**
 * Represents symbols to be shown or printed for abnormal results.
 */
@Data
public class FlagType {

    /**
     * The value when the result is below the scale, e.g., {@code <<}.
     */
    private String belowScale;

    /**
     * The value when the result is below alarm 2, e.g., {@code ↓↓↓}.
     * <p>
     * This value corresponds to {@link FlagLevels#ULTRA_LOW}.
     * </p>
     */
    private String ultraLow;

    /**
     * The value when the result is below alarm 1, e.g., {@code ↓↓}.
     * <p>
     * This value corresponds to {@link FlagLevels#VERY_LOW}.
     * </p>
     */
    private String veryLow;

    /**
     * The value when the result is below the reference range, e.g., {@code ↓}.
     * <p>
     * This value corresponds to {@link FlagLevels#LOW}.
     * </p>
     */
    private String low;

    /**
     * The value when the result is above the reference range, e.g., {@code ↑}.
     * <p>
     * This value corresponds to {@link FlagLevels#HIGH}.
     * </p>
     */
    private String high;

    /**
     * The value when the result is above alarm 1, e.g., {@code ↑↑}.
     * <p>
     * This value corresponds to {@link FlagLevels#VERY_HIGH}.
     * </p>
     */
    private String veryHigh;

    /**
     * The value when the result is above alarm 2, e.g., {@code ↑↑↑}.
     * <p>
     * This value corresponds to {@link FlagLevels#ULTRA_HIGH}.
     * </p>
     */
    private String ultraHigh;

    /**
     * The value when the result is above the scale, e.g., {@code >>}.
     */
    private String aboveScale;

    /**
     * Convenience method to get the flag for the given level.
     *
     * @param flagLevel Result flag level
     * @return Flag to be shown/printed
     */
    public String getFlag(FlagLevels flagLevel) {
        switch (flagLevel) {
            case ULTRA_LOW:
                return ultraLow;
            case VERY_LOW:
                return veryLow;
            case LOW:
                return low;
            case HIGH:
                return high;
            case VERY_HIGH:
                return veryHigh;
            case ULTRA_HIGH:
                return ultraHigh;
            default:
                return "";
        }
    }
}



