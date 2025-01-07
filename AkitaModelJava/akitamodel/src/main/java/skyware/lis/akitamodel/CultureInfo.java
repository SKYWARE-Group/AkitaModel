package skyware.lis.akitamodel;

import lombok.Data;


@Data
public class CultureInfo {

    private int id;

    private String currencySymbol;

    private int currencyPosition;

    private String currencyDecSep;

    private String currencyGroupSep;

    private int currencyDecDigits;

    private String numberDecSep;

    private String numberGroupSep;

}
