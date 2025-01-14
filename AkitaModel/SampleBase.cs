﻿using System;
using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel;

[JsonDerivedType(typeof(Sample))]
[JsonDerivedType(typeof(Results.Sample))]
public abstract class SampleBase
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Type of the sample.
    /// </summary>
    public SampleType SampleType { get; set; }

    /// <summary>
    /// Barcode on the label.
    /// </summary>
    public string Barcode { get; set; }

    /// <summary>
    /// Date and time the sample was taken.
    /// </summary>
    public DateTime? Taken { get; set; }

}
