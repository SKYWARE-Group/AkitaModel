/**
 * Skyware.Lis.AkitaModel
 */

/**
 * API error. Usually sent as content in case of non-success HTTP codes, such as 500, 404, etc.
 */
export class ApiError {
  /**
   * Correlation Identifier.
   */
  correlationId?: string;

  /**
   * Reason of the error.
   */
  message?: string;

  /**
   * Detailed information, e.g. exception stack.
   */
  details?: string;
}
