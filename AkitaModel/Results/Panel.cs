using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Represents a panel of tests (Profile).
/// </summary>
public class Panel : ExaminatioinBase
{

    /// <inheritdoc />
    public override bool IsPanel => true;

    public IList<Test> Tests { get; set; }

}
