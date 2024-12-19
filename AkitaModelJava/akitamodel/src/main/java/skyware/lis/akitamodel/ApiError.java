package skyware.lis.akitamodel;

import lombok.Data;

/**
 * API error. Usually sent as content in case of non-success HTTP codes, such as
 * 500, 404, etc.
 */
@Data
public class ApiError {

    /**
     * Correlation Identifier.
     */
    private String correlationId;

    /**
     * Reason of the error.
     */
    private String message;

    /**
     * Detailed information, e.g. exception stack.
     */
    private String details;

}
