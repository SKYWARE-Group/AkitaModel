﻿using System;
using System.Text.Json.Serialization;

namespace Skyware.Lis.AkitaModel;

/// <summary>
/// Patient visit. This is a base class for all types of visits.
/// </summary>
[JsonDerivedType(typeof(Results.VisitBalance))]
[JsonDerivedType(typeof(Results.VisitResults))]
[JsonDerivedType(typeof(Portal.Visit))]
public abstract class VisitBase
{

    /// <summary>
    /// PK in LIS iLab.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Date/time the visit was created.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Visiting patient.
    /// </summary>
    public Patient Patient { get; set; }

}
