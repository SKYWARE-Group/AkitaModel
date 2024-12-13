using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Results;

public class Panel : ExaminatioinBase
{

    /// <inheritdoc />
    public override bool IsPanel => false;

    public IList<Test> Tests { get; set; } = [];

}
