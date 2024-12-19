namespace Skyware.Lis.AkitaModel {

    /**
     * Possible flag levels.
     */
    export enum FlagLevels {

        /**
         * Ultra low results (below alarm 2).
         */
        ULTRA_LOW = 1,

        /**
         * Very low results (below alarm 1).
         */
        VERY_LOW = 2,

        /**
         * Low results (below reference range).
         */
        LOW = 3,

        /**
         * No flag.
         */
        NONE = 4,

        /**
         * High results (above reference range).
         */
        HIGH = 5,

        /**
         * Very high results (above alarm 1).
         */
        VERY_HIGH = 6,

        /**
         * Ultra high results (above alarm 2).
         */
        ULTRA_HIGH = 7,

        /**
         * Abnormal non-numeric result.
         */
        WITH_STAR = 10,

        /**
         * Semi-quantitative result within gray zone.
         */
        SEMI_QUANT_QUESTION = 11,

    }
}
