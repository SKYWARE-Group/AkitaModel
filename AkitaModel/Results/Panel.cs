using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Represents a panel of tests (Profile).
/// </summary>
public class Panel : ExaminationBase
{

    /// <inheritdoc />
    public override bool IsPanel => true;

    /// <summary>
    /// Test items that are part of the panel.
    /// </summary>
    public IList<Test> Tests { get; set; }

}
