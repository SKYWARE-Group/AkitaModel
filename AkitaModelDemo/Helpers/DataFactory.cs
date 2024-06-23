﻿using Skyware.Lis.AkitaModel.Flagging;
using Skyware.Lis.AkitaModel.Robin.Reports.Bg;
using System.Runtime.CompilerServices;

namespace AkitaModelDemo.Helpers;

public class DataFactory
{

    public static LabReferral GetDemoReferral() => new()
    {
        Nrn = "23184A000A1F",
        AmbulatoryNrn = "2316A7000AA1",
        Issued = DateTime.Today.AddDays(-3),
        SampleDate = DateTime.Today.AddDays(-2),
        LabPracticeCode = "0302141842",
        MainDiagnosis = "Z00.0",
        Patient = new()
        {
            NationalIdentifier = "9912055612",
            DateOfBirth = new DateTime(1999, 12, 5),
            Rhif = "03",
            HealthRegion = "12",
            GivenName = "Мария",
            MiddleName = "Василева",
            FamilyName = "Борисова",
            Address = new()
            {
                Town = "Варна",
                Area = "Младост",
                Street = "Йонко Вапцаров",
                StreetNumber = "22",
            }
        },
        Doctor = new()
        {
            PracticeCode = "0305111422",
            Uin = "0400045236",
            SpecialityCode = "00",
        },
        Examinations =
            [
                new ReferralItem()
                {
                    NhifCode = "01.01",
                    StatisticsCode = "91910-04",
                    SpecialtyCode = "14",
                    Uin = "1600004145",
                },
                new ReferralItem()
                {
                    NhifCode = "01.03",
                    StatisticsCode = "91900-99",
                    SpecialtyCode = "14",
                    Uin = "1600004145",
                }
            ]
    };

    internal static IEnumerable<ResultRequest> GetDemoFlaggingTestResultRequest()
    {
        yield return new()
        {
            TestId = InternalConstants.FLAGGING_SINGLE_TEST_ID,
            SpeciesId = 1,
            RefId = "S7ENF",
            DateOfBirth = new DateTime(1992, 12, 12),
            IsMale = true,
            NumericPrefix = "",
            NumericResult = 13.38M,
        };
        yield return new()
        {
            TestId = InternalConstants.FLAGGING_SINGLE_TEST_ID,
            SpeciesId = 1,
            RefId = "S7ENE",
            DateOfBirth = new DateTime(1992, 12, 12),
            IsMale = true,
            NumericPrefix = "",
            TextResult = "13.38"
        };
    }
}
