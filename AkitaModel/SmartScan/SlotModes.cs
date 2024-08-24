namespace Skyware.Lis.AkitaModel.SmartScan;

/// <summary>
/// Slot modes - instructs the service how to save pictures.
/// </summary>
public enum SlotModes : int
{
    /// <summary>
    /// None, will save files as they are uploaded.
    /// </summary>
    None = 0,

    /// <summary>
    /// Files will be saved as JPEG.
    /// </summary>
    JPEG = 1,

    /// <summary>
    /// Files will be put in PDF document.
    /// </summary>
    PDF = 2
}

