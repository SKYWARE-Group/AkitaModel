using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

// Ignore Spelling: uin// Ignore Spelling: uin бл nrn yyyy dd пре

namespace Skyware.Lis.AkitaModel.Robin.Reports.Bg;


/// <summary>
/// Bulgarian Nhif Laboratory Referral generation.
/// Модел за генериране на Бл. МЗ-НЗОК № 4.
/// </summary>
public class LabReferral : IReportDataObject
{

    /// <summary>
    /// The NRN of the referral.
    /// Номер на НМДД (НРН от НЗИС).
    /// </summary>
    public string Nrn { get; set; }

    /// <summary>
    /// The NRN of the ambulatory sheet.
    /// Номер на амбулаторен лист по който е издадено НМДД (НРН от НЗИС).
    /// </summary>
    [JsonPropertyName("ambNrn")]
    public string AmbulatoryNrn { get; set; }

    /// <summary>
    /// Date of issuing of the referral.
    /// Дата на издаване на НМДД.
    /// </summary>
    [JsonConverter(typeof(IsoDateOnlyConverter))]
    public DateTime Issued { get; set; } = DateTime.Today;

    /// <summary>
    /// Encounter type.
    /// Тип (причина) на направлението по НЗОК.
    /// Повод посещение на ЗОЛ (НРД 2022): 
    /// 1 = С остро заболяване или състояние извън останалите типове
    /// 2 = С хронично заболяване, неподлежащо на диспансерно наблюдение
    /// 3 = Избор (пре-избор) на специалист, извършващ диспансерно наблюдение
    /// 4 = За диспансерно интердисциплинарно наблюдение
    /// 6 = За медицинска експертиза
    /// 7 = Профилактика на ЗОЛ над 18 г.– с рискови фактори за развитие на заболяване
    /// 8 = По искане на ТЕЛК(НЕЛК)
    /// 9 = Избор на специалист АГ - програма „Майчино здравеопазване” 
    /// 10 = Избор на специалист педиатрия - „Детско здравеопазване” 
    /// 11 = Пре-избор на специалист по АГ - програма „Майчино здравеопазване” 
    /// 12 = Пре-избор на специалист педиатрия - „Детско здравеопазване” 
    /// </summary>
    public byte VisitType { get; set; } = 1;

    /// <summary>
    /// Chief complaint diagnosis (ICD-10)
    /// МКБ-10 код на диагнозата, причина за издаване на НМДД.
    /// </summary>
    [JsonPropertyName("mainDiag")]
    public string MainDiagnosis { get; set; }

    /// <summary>
    /// Star diagnosis (complication, dagger-star system, ICD-10, Optional).
    /// МКБ-10 код на усложнения към основната диагноза.
    /// </summary>
    [JsonPropertyName("starDiag")]
    public string StarDiagnosis { get; set; }

    /// <summary>
    /// Laboratory's practice code (MoH).
    /// РЦЗ/ИАМН код на лаборатория-изпълнител на НМДД.
    /// </summary>
    public string LabPracticeCode { get; set; }

    /// <summary>
    /// Laboratory's practice additional NHIF code (Optional).
    /// НЗОК код на лабораторията (при договор в РЗОК, различна от тази по регистрация, опционално).
    /// </summary>
    public string LabNhifCode { get; set; } = string.Empty;

    /// <summary>
    /// Date when patient visits laboratory and signs the referral (Today by default).
    /// Датата, на която пациентът с подписа си удостоверява, че е взет биологичен материал или е извършено образно изследване.
    /// (По подразбиране - днешна дата).
    /// </summary>
    [JsonConverter(typeof(IsoDateOnlyConverter))]
    public DateTime SampleDate { get; set; } = DateTime.Today;

    /// <summary>
    /// Date when the examinations are finished (Today by default).
    /// Дата на завършване на дейността по направлението (По подразбиране - днешна дата).
    /// </summary>
    [JsonPropertyName("performed")]
    [JsonConverter(typeof(IsoDateOnlyConverter))]
    public DateTime ResultsDate { get; set; } = DateTime.Today;

    /// <summary>
    /// Financing source (2=NHIF by default).
    /// Източник на финансиране за направлението.
    /// 1 = Бюджет, 2 = НЗОК, 3 = ДЗОФ, 4 = Пациент, 5 = МЗ.
    /// По подразбиране - 2 (НЗОК).
    /// </summary>
    [JsonPropertyName("financing")]
    public byte FinancingSource { get; set; } = 2; //НЗОК

    /// <summary>
    /// The patient to whom the referral is issued.
    /// Пациент.
    /// </summary>
    public Patient Patient { get; set; }

    /// <summary>
    /// The referral issuer.
    /// Лекар-издател на НМДД.
    /// </summary>
    public Doctor Doctor { get; set; }

    /// <summary>
    /// Referral items (examinations).
    /// Изследвания по НМДД.
    /// </summary>
    public List<ReferralItem> Examinations { get; set; }

    /// <inheritdoc/>
    public string GetBase64Data() => Base64Helper.GetBase64Data(this);

}
