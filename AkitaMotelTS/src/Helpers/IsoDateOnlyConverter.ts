/**
 * Skyware.Lis.AkitaModel.Helpers
 */

/**
 * ISO-8601 date only converter utilities.
 */
export class IsoDateOnlyConverter {
  /**
   * Converts a Date to ISO date string (yyyy-MM-dd format).
   * @param date Date to convert
   * @returns ISO date string
   */
  static toIsoDateString(date: Date): string {
    const year = date.getFullYear();
    const month = String(date.getMonth() + 1).padStart(2, '0');
    const day = String(date.getDate()).padStart(2, '0');
    return `${year}-${month}-${day}`;
  }

  /**
   * Parses an ISO date string (yyyy-MM-dd format) to Date.
   * @param isoDateString ISO date string
   * @returns Parsed Date
   */
  static fromIsoDateString(isoDateString: string): Date {
    const [year, month, day] = isoDateString.split('-').map(Number);
    return new Date(year, month - 1, day);
  }
}
