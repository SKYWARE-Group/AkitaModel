namespace Skyware.Lis.AkitaModel {

    /**
     * Medical speciality of a doctor, e.g. General practitioner, Surgeon, etc.
     */
    export class Speciality {

        /**
         * PK in LIS iLab.
         */
        public id?: number;

        /**
         * Name of the speciality, e.g. "Surgeon".
         */
        public name: string;

    }

}
