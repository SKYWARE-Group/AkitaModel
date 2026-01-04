/**
 * Skyware.Lis.AkitaModel.Helpers
 */

/**
 * Standard JSON options for Akita.
 */
export class AkitaJsonOptions {
  /**
   * JSON serialization options for Akita.
   */
  static getOptions(): any {
    return {
      // TypeScript/JavaScript equivalent settings for JSON serialization
      // These would typically be used with JSON.stringify replacer/reviver functions
      writeIndented: true,
      propertyNameCaseInsensitive: true,
      camelCase: true,
      ignoreNull: true,
      handleCircularReferences: true,
      allowNumbersAsStrings: true
    };
  }
}
