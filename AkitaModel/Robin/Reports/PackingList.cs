namespace Skyware.Lis.AkitaModel.Robin.Reports;

/// <summary>
/// Data for packing list 
/// </summary>
public class PackingList
{
    /// <summary>
    /// Sender name
    /// </summary>
    public string SenderName { get; set; }

    /// <summary>
    /// Sender location
    /// </summary>
    public string SenderLocation { get; set; }

    /// <summary>
    /// Sender city
    /// </summary>
    public string SenderCity { get; set; }

    /// <summary>
    /// Sender address
    /// </summary>
    public string SenderAddress { get; set; }

    /// <summary>
    /// Receiver name
    /// </summary>
    public string ReceiverName { get; set; }

    /// <summary>
    /// Receiver location
    /// </summary>
    public string ReceiverLocation { get; set; }

    /// <summary>
    /// Receiver address
    /// </summary>
    public string ReceiverAddress { get; set; }

    /// <summary>
    /// Receiver city
    /// </summary>
    public string ReceiverCity { get; set; }

    /// <summary>
    /// Document reference
    /// </summary>
    public string DocumentRef { get; set; }

    /// <summary>
    /// Date sending
    /// </summary>
    public string DateSending { get; set; }

    /// <summary>
    /// Carrier or courier name
    /// </summary>
    public string CarrierCourierName { get; set; }

    /// <summary>
    /// Sender note
    /// </summary>
    public string SenderNote { get; set; }

    /// <summary>
    /// Is carrier
    /// </summary>
    public bool IsCarrier { get; set; }
}