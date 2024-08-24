using Skyware.Lis.AkitaModel.SmartScan.Events;
using System;
using System.Collections.Generic;

namespace Skyware.Lis.AkitaModel.SmartScan;


/// <summary>
/// Represents a slot for uploading files.
/// </summary>
public class Slot
{

    /// <summary>
    /// Base URL for subscribe and unsubscribe
    /// </summary>
    protected readonly string _baseUrl;

    /// <summary>
    /// Default Constructor
    /// </summary>
    public Slot() { }

    /// <summary>
    /// Additional Constructor for creating Slot
    /// </summary>
    /// <param name="baseUrl">Base URL for the internal subscribe/unsubscribe logic</param>
    internal protected Slot(string baseUrl) : this()
    {
        _baseUrl = baseUrl;
    }

    /// <summary>
    /// Id of the slot, server generated.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Collection of files uploaded in this slot.
    /// </summary>
    public IEnumerable<File> Files { get; set; }

    /// <summary>
    /// Upload mode, <see cref="SlotModes"/>
    /// </summary>
    public SlotModes Mode { get; set; } = SlotModes.PDF;

    /// <summary>
    /// Subscribe to events.
    /// </summary>
    /// <param name="onMobileConnected">Function to be executed when client is 'connected'.</param>
    /// <param name="onFileCreated">Function to be executed when client upload a file.</param>
    public virtual void Subscribe(Action onMobileConnected, Action<FileEvent> onFileCreated) { }

    /// <summary>
    /// Unsubscribe from events.
    /// </summary>
    public virtual void Unsubscirbe() { }

}

