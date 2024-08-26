namespace Skyware.Lis.AkitaModel.SmartScan.Events;


/// <summary>
/// Interface which all events must implement.
/// </summary>
public interface ITypedEvent
{

    /// <summary>
    /// Default SignalR method name.
    /// </summary>
    string MethodName { get; }

}
