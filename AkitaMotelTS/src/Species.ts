/**
 * Skyware.Lis.AkitaModel
 */

/**
 * Species, e.g. Human, Dog, Cat, etc.
 */
export class Species {
  /**
   * Primary key. Value 1 is reserved for "Human".
   */
  id!: number;

  /**
   * Name of the species, e.g. "Human".
   */
  name?: string;
}
