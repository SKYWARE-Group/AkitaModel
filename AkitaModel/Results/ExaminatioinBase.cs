using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel.Results;

/// <summary>
/// Base class for Panel and Test.
/// </summary>
[JsonDerivedType(typeof(Panel))]
[JsonDerivedType(typeof(Test))]
public abstract class ExaminatioinBase : ItemBase
{

    /// <summary>
    /// If the examination is a panel, this property will be true.
    /// </summary>
    public abstract bool IsPanel { get; }

}
