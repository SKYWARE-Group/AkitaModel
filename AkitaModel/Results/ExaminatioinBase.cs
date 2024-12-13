namespace Skyware.Lis.AkitaModel.Results;

public abstract class ExaminatioinBase : ItemBase
{

    /// <summary>
    /// If the examination is a panel, this property will be true.
    /// </summary>
    public abstract bool IsPanel { get; }

}
