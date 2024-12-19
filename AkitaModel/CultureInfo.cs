using System;
using System.Collections.Generic;
using System.Text;

namespace Skyware.Lis.AkitaModel;

public class CultureInfo
{

    public static IFormatProvider InvariantCulture { get; internal set; }

    public int Id { get; set; }

    public string CurrencySymbol { get; set; }

    public int CurrencyPosition { get; set; }

    public string CurrencyDecSep { get; set; }

    public string CurrencyGroupSep { get; set; }

    public int CurrencyDecDigits { get; set; }

    public string NumberDecSep { get; set; }

    public string NumberGroupSep { get; set; }

}
