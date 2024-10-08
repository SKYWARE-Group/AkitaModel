﻿using System;
using System.Text.Json.Serialization;

// Ignore Spelling: dob pid

namespace Skyware.Lis.AkitaModel.Robin.Reports.Bg;

/// <summary>
/// Patient (Bulgarian Forms).<br/>
/// Пациент (в документи по НЗОК).
/// </summary>
public class Patient : PersonBase
{

    /// <summary>
    /// National identifier of the patient.<br/>
    /// ЕГН или ЛНЧ на пациента.
    /// </summary>
    [JsonPropertyName("pin")]
    public string NationalIdentifier { get; set; }

    /// <summary>
    /// Patient identifier type.<br/>
    /// Вид на идентификатора на пациента.<br/>
    /// 1 = ЕГН, 2 = ЛНЧ, 3 = Друг (отпечатва се <see cref="Pid"/>).
    /// </summary>
    public byte PidType { get; set; } = 1; //ЕГН

    /// <summary>
    /// Patient identifier, when <see cref="PidType"/> is not 0 or 1.<br/>
    /// Идентификатор на пациента, когато е различен от ЕГН или ЛНЧ.
    /// </summary>
    public string Pid { get; set; } = string.Empty;

    /// <summary>
    /// Regional Health Insurance Fund code.<br/>
    /// Номер на РЗОК.
    /// </summary>
    public string Rhif { get; set; }

    /// <summary>
    /// Health region where the patient resides.<br/>
    /// Здравен регион на пациента.
    /// </summary>
    [JsonPropertyName("hRegion")]
    public string HealthRegion { get; set; }

    /// <summary>
    /// Date Of Birth of the patient.<br/>
    /// Дата на раждане на пациента.
    /// </summary>
    [JsonPropertyName("dob")]
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Country code of the patient's residence.<br/>
    /// Код на държава на гражданство на пациента.
    /// </summary>
    public string Country { get; set; } = "BG";

    /// <summary>
    /// Address of the patient.<br/>
    /// Адрес на пациента по местоживеене.
    /// </summary>
    public Address Address { get; set; }

}
