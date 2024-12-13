using System;

namespace Skyware.Lis.AkitaModel.Robin.Reports;

/// <summary>
/// TO-DO
/// </summary>
public class SamplesLocation
{
    /// <summary>
    /// 
    /// </summary>
    public const int ITEM_TYPE_LOCATION = 0;

    /// <summary>
    /// 
    /// </summary>
    public const int ITEM_TYPE_SHIPMENT = 1;

    /// <summary>
    /// TO-DO
    /// </summary>
    public int ItemType { get; set; }

    /// <summary>
    /// TO-DO
    /// </summary>
    public int ItemId { get; set; }

    /// <summary>
    /// TO-DO
    /// </summary>
    public string ItemName { get; set; }

    /// <summary>
    /// TO-DO
    /// </summary>
    public string Origin { get; set; }

    /// <summary>
    /// TO-DO
    /// </summary>
    public string Destination { get; set; }

    /// <summary>
    /// TO-DO
    /// </summary>
    public int? CarrierId { get; set; }

    /// <summary>
    /// TO-DO
    /// </summary>
    public int? CourierId { get; set; }

    /// <summary>
    /// TO-DO
    /// </summary>
    public string TransportName { get; set; }

    /// <summary>
    /// TO-DO
    /// </summary>
    public DateTime? SentTime { get; set; }

    /// <summary>
    /// TO-DO
    /// </summary>
    public int SamplesCount { get; set; }

    /// <summary>
    /// TO-DO
    /// </summary>
    public int PendingTestsCount { get; set; }


    /// <summary>
    /// TO-DO
    /// </summary>
    public string SamplesText
    {
        get
        {
            if (SamplesCount > 0 && PendingTestsCount > 0)
                return $"{SamplesCount} / {PendingTestsCount}";
            if (SamplesCount > 0 && PendingTestsCount <= 0)
                return $"{SamplesCount} / {0}";
            if (SamplesCount <= 0 && PendingTestsCount > 0)
                return $"{0} / {PendingTestsCount}";
            //return Resources.VarStrings.NoSamples;
            return "No samples";
        }
    }

    //public SolidColorBrush SamplesTextColor
    //{
    //    get
    //    {
    //        if (SamplesCount > 0 && PendingTestsCount > 0 || (SamplesCount > 0 && PendingTestsCount <= 0) || (SamplesCount <= 0 && PendingTestsCount > 0))
    //            return new SolidColorBrush(Color.FromArgb(255, 116, 184, 252)); // Blue
    //        return new SolidColorBrush(Color.FromArgb(255, 68, 119, 68)); // Green
    //    }
    //}

    //public SolidColorBrush SamplesHeaderColor
    //{
    //    get
    //    {
    //        if (ItemType == 0)
    //            return new SolidColorBrush(Color.FromArgb(255, 116, 184, 252)); // Blue
    //        return new SolidColorBrush(Color.FromArgb(255, 127, 127, 127)); // Gray shipment
    //    }
    //}

    /// <summary>
    /// TO-DO
    /// </summary>
    public bool IsEnabledOpen
    {
        get
        {
            if (SamplesCount > 0 && PendingTestsCount > 0 || (SamplesCount > 0 && PendingTestsCount <= 0) || (SamplesCount <= 0 && PendingTestsCount > 0))
                return true;
            return false;
        }
    }

    /// <summary>
    /// TO-DO
    /// </summary>
    public string ItemByTypeText
    {
        get
        {
            if (ItemType == ITEM_TYPE_LOCATION)
                return ItemName;
            if (ItemType == ITEM_TYPE_SHIPMENT)
            {
                //return $"{Resources.VarStrings.ShipmentNum} {ItemId}";
                return $"{"ShipmentNum"} {ItemId}";
            }
            return "";
        }
    }

    /// <summary>
    /// TO-DO
    /// </summary>
    public string OriginText
    {
        get
        {
            if (ItemType == ITEM_TYPE_SHIPMENT)
            {
                //return $"{Resources.VarStrings.FromStr} {Origin}";
                return $"{"From"} {Origin}";
            }
            return "";
        }
    }

    /// <summary>
    /// TO-DO
    /// </summary>
    public string DestinationText
    {
        get
        {
            if (ItemType == ITEM_TYPE_SHIPMENT)
                return $"{"To"} {Destination}";
            return "";
        }
    }

    /// <summary>
    /// TO-DO
    /// </summary>
    public string TransportNameText
    {
        get
        {
            if (ItemType == ITEM_TYPE_SHIPMENT)
                return $"{"Who"} {TransportName}";
            return "";
        }
    }

    /// <summary>
    /// TO-DO
    /// </summary>
    public string SentTimeText
    {
        get
        {
            if (ItemType == ITEM_TYPE_SHIPMENT)
            {
                if (SentTime.HasValue)
                    return $"{"Sent time"} {SentTime.Value:dd MMM}, {SentTime.Value.ToShortTimeString()}";
                return $"{"Sent time"}";
            }
            return string.Empty;
        }
    }
}