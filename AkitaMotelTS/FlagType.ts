namespace Skyware.Lis.AkitaModel {

    /**
     * Represents symbols to be shown or printed for abnormal results.
     */
    export class FlagType {

        /**
         * The value when the result is below the scale, e.g. "<<".
         */
        public belowScale: string;

        /**
         * The value when the result is below alarm 2, e.g. "↓↓↓".
         * This value corresponds to FlagLevels.ULTRA_LOW.
         */
        public ultraLow: string;

        /**
         * The value when the result is below alarm 1, e.g. "↓↓".
         * This value corresponds to FlagLevels.VERY_LOW.
         */
        public veryLow: string;

        /**
         * The value when the result is below the reference range, e.g. "↓".
         * This value corresponds to FlagLevels.LOW.
         */
        public low: string;

        /**
         * The value when the result is above the reference range, e.g. "↑".
         * This value corresponds to FlagLevels.HIGH.
         */
        public high: string;

        /**
         * The value when the result is above alarm 1, e.g. "↑↑".
         * This value corresponds to FlagLevels.VERY_HIGH.
         */
        public veryHigh: string;

        /**
         * The value when the result is above alarm 2, e.g. "↑↑↑".
         * This value corresponds to FlagLevels.ULTRA_HIGH.
         */
        public ultraHigh: string;

        /**
         * The value when the result is above the scale, e.g. ">>".
         */
        public aboveScale: string;

        /**
         * Convenience method to get the flag for the given level.
         * @param flagLevel Result flag level
         * @returns Flag to be shown/printed
         */
        public getFlag(flagLevel: FlagLevels): string {
            switch (flagLevel) {
                case FlagLevels.ULTRA_LOW: return this.ultraLow;
                case FlagLevels.VERY_LOW: return this.veryLow;
                case FlagLevels.LOW: return this.low;
                case FlagLevels.HIGH: return this.high;
                case FlagLevels.VERY_HIGH: return this.veryHigh;
                case FlagLevels.ULTRA_HIGH: return this.ultraHigh;
                default: return '';
            }
        }
    }
}
