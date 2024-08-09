using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.BgNhis;
using Skyware.Lis.AkitaModel.Flagging;

namespace AkitaModelDemo.Helpers;

public class DataFactory
{

    public static string PID = "1552284828";

    public static string NRN = "24222000000A";

    public static ImportRequest GetImportRequestWithThreeReferrals(IList<string> nrns) => new()
    {
        ApplicationName = string.Empty,
        ProcPointLocationId = "1",
        Schema = new()
        {
            SchemaId = 2,
            FundId = 1,
            Fund2Id = null
        },
        RegLocationId = "1",
        LocationId = "1",
        UserName = string.Empty,
        SaleId = 0,
        Referrals = [
                       new ReferralImportRequest
                        {
                            Nrn = nrns[0],
                            VisitDate = DateTime.Now,
                            SampleDate = DateTime.Now,
                            ResultsDate = DateTime.Now,
                            NhifContract = new()
                            {
                                Doctor = new()
                                {
                                    Id = 0,
                                    GivenName = string.Empty,
                                    MiddleName = string.Empty,
                                    FamilyName = string.Empty,
                                    Uin="2300006463",
                                    Title = string.Empty,
                                    Speciality = new Speciality
                                    {
                                        Id=0,
                                        Name=string.Empty
                                    },
                                    Region=string.Empty,
                                    City=string.Empty,
                                    PostalCode = string.Empty,
                                    PostAddress = string.Empty
                                },
                               Speciality = new()
                               {
                                   NhifCode = "09",
                                   NhisCode = string.Empty,
                                   Name = string.Empty
                               },
                               Practice = new()
                               {
                                   PracticeNumber = "2210131574",
                                   NhifNumber = string.Empty,
                                   Name = string.Empty

                               }
                            },
                        },
                        new ReferralImportRequest
                        {
                            Nrn = nrns[1],
                            VisitDate = DateTime.Now,
                            SampleDate = DateTime.Now,
                            ResultsDate = DateTime.Now,
                            NhifContract = new()
                            {
                                Doctor = new()
                                {
                                    Id = 0,
                                    GivenName = string.Empty,
                                    MiddleName = string.Empty,
                                    FamilyName = string.Empty,
                                    Uin="2300006463",
                                    Title = string.Empty,
                                    Speciality = new Speciality
                                    {
                                        Id=0,
                                        Name=string.Empty
                                    },
                                    Region=string.Empty,
                                    City=string.Empty,
                                    PostalCode = string.Empty,
                                    PostAddress = string.Empty
                                },
                               Speciality = new()
                               {
                                   NhifCode = "09",
                                   NhisCode = string.Empty,
                                   Name = string.Empty
                               },
                               Practice = new()
                               {
                                   PracticeNumber = "2210131574",
                                   NhifNumber = string.Empty,
                                   Name = string.Empty

                               }
                            },
                        },
                        new ReferralImportRequest
                        {
                            Nrn = nrns[2],
                            VisitDate = DateTime.Now,
                            SampleDate = DateTime.Now,
                            ResultsDate = DateTime.Now,
                            NhifContract = new()
                            {
                                Doctor = new()
                                {
                                    Id = 0,
                                    GivenName = string.Empty,
                                    MiddleName = string.Empty,
                                    FamilyName = string.Empty,
                                    Uin="2300006463",
                                    Title = string.Empty,
                                    Speciality = new Speciality
                                    {
                                        Id=0,
                                        Name=string.Empty
                                    },
                                    Region=string.Empty,
                                    City=string.Empty,
                                    PostalCode = string.Empty,
                                    PostAddress = string.Empty
                                },
                               Speciality = new()
                               {
                                   NhifCode = "09",
                                   NhisCode = string.Empty,
                                   Name = string.Empty
                               },
                               Practice = new()
                               {
                                   PracticeNumber = "2210131574",
                                   NhifNumber = string.Empty,
                                   Name = string.Empty

                               }
                            },
                        }
                   ]
    };

    public static ImportRequest GetImportRequestWithSale(int? saleId, string nrn3) => new()
    {
        ApplicationName = string.Empty,
        ProcPointLocationId = "1",
        Schema = new()
        {
            SchemaId = 2,
            FundId = 1,
            Fund2Id = null
        },
        RegLocationId = "1",
        LocationId = "1",
        UserName = string.Empty,
        SaleId = saleId,
        Referrals = [
                        new ReferralImportRequest
                        {
                            Nrn = nrn3,
                            VisitDate = DateTime.Now,
                            SampleDate = DateTime.Now,
                            ResultsDate = DateTime.Now,
                            NhifContract = new()
                            {
                                Doctor = new()
                                {
                                    Id = 0,
                                    GivenName = string.Empty,
                                    MiddleName = string.Empty,
                                    FamilyName = string.Empty,
                                    Uin="2300006463",
                                    Title = string.Empty,
                                    Speciality = new Speciality
                                    {
                                        Id=0,
                                        Name=string.Empty
                                    },
                                    Region=string.Empty,
                                    City=string.Empty,
                                    PostalCode = string.Empty,
                                    PostAddress = string.Empty
                                },
                               Speciality = new()
                               {
                                   NhifCode = "09",
                                   NhisCode = string.Empty,
                                   Name = string.Empty
                               },
                               Practice = new()
                               {
                                   PracticeNumber = "2210131574",
                                   NhifNumber = string.Empty,
                                   Name = string.Empty

                               }
                            },
                        }
                    ]
    };

    public static ImportRequest GetImportRequest(string nrn1, string nrn2) => new()
    {
        ApplicationName = string.Empty,
        ProcPointLocationId = "1",
        Schema = new()
        {
            SchemaId = 2,
            FundId = 1,
            Fund2Id = null
        },
        RegLocationId = "1",
        LocationId = "1",
        UserName = string.Empty,
        SaleId = 0,
        Referrals = [
                        new ReferralImportRequest
                        {
                            Nrn = nrn1,
                            VisitDate = DateTime.Now,
                            SampleDate = DateTime.Now,
                            ResultsDate = DateTime.Now,
                            NhifContract = new()
                            {
                                Doctor = new()
                                {                                    
                                    Id = 0,
                                    GivenName = string.Empty,
                                    MiddleName = string.Empty,
                                    FamilyName = string.Empty,
                                    Uin="2300006463",
                                    Title = string.Empty,
                                    Speciality = new Speciality
                                    {
                                        Id=0,
                                        Name=string.Empty
                                    },
                                    Region=string.Empty,
                                    City=string.Empty,
                                    PostalCode = string.Empty,
                                    PostAddress = string.Empty
                                },
                               Speciality = new()
                               {
                                   NhifCode = "09",
                                   NhisCode = string.Empty,
                                   Name = string.Empty
                               },
                               Practice = new()
                               {
                                   PracticeNumber = "2210131574",
                                   NhifNumber = string.Empty,
                                   Name = string.Empty
                                   
                               }
                            },
                        },
                        new ReferralImportRequest
                        {
                            Nrn = nrn2,
                            VisitDate = DateTime.Now,
                            SampleDate = DateTime.Now,
                            ResultsDate = DateTime.Now,
                            NhifContract = new()
                            {
                                Doctor = new()
                                {
                                    Id = 0,
                                    GivenName = string.Empty,
                                    MiddleName = string.Empty,
                                    FamilyName = string.Empty,
                                    Uin="2300006463",
                                    Title = string.Empty,
                                    Speciality = new Speciality
                                    {
                                        Id=0,
                                        Name=string.Empty
                                    },
                                    Region=string.Empty,
                                    City=string.Empty,
                                    PostalCode = string.Empty,
                                    PostAddress = string.Empty
                                },
                               Speciality = new()
                               {
                                   NhifCode = "09",
                                   NhisCode = string.Empty,
                                   Name = string.Empty
                               },
                               Practice = new()
                               {
                                   PracticeNumber = "2210131574",
                                   NhifNumber = string.Empty,
                                   Name = string.Empty

                               }
                            },
                        }
                    ]
    };

    public static Skyware.Lis.AkitaModel.Robin.Reports.Bg.LabReferral GetDemoReferral() => new()
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
            },
        },
        Doctor = new()
        {
            PracticeCode = "0305111422",
            Uin = "0400045236",
            SpecialityCode = "00",
        },
        Examinations = [
            new Skyware.Lis.AkitaModel.Robin.Reports.Bg.ReferralItem()
            {
                NhifCode = "01.01",
                StatisticsCode = "91910-04",
                SpecialtyCode = "14",
                Uin = "1600004145",
            },
            new Skyware.Lis.AkitaModel.Robin.Reports.Bg.ReferralItem()
            {
                NhifCode = "01.03",
                StatisticsCode = "91900-99",
                SpecialtyCode = "14",
                Uin = "1600004145",
            }
        ],
    };

    public static IEnumerable<ResultRequest> GetDemoFlaggingTestResultRequest()
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
            TextResult = "13.38",
        };
    }

    public static Skyware.Lis.AkitaModel.Patient GetBulgarianCitizen() => new()
    {
        PidTypeId = 1, // EGN
        PatientId = "8008075567",
        GivenName = "Явор",
        MiddleName = "Иванов",
        FamilyName = "Илиев",
        DateOfBirth = new DateTime(1980, 8, 7),
        IsDobAprox = false,
        IsMale = true,
    };

    public static Skyware.Lis.AkitaModel.Patient GetJohnDoe() => new()
    {
        PidTypeId = 0, // Anonymous
        GivenName = "John",
        FamilyName = "Doe",
        DateOfBirth = new DateTime(1985, 4, 12),
        IsDobAprox = true,
        IsMale = true,
    };

    public static Skyware.Lis.AkitaModel.Patient GetJaneDoe() => new()
    {
        PidTypeId = 0, // Anonymous
        GivenName = "Jane",
        FamilyName = "Doe",
        DateOfBirth = new DateTime(1990, 8, 22),
        IsDobAprox = false,
        IsMale = false,
    };

    public static Skyware.Lis.AkitaModel.Sale GetBulgarianCitizenVisit(int schemaId, IEnumerable<string> codes) => new()
    {
        Patient = GetBulgarianCitizen(),
        SchemaId = schemaId,
        Items = codes.Select(x => new Skyware.Lis.AkitaModel.SaleItem() { LoincId = x }).ToArray(),
    };

    public static Skyware.Lis.AkitaModel.Sale GetJohnDoeVisit(int schemaId, IEnumerable<string> codes) => new()
    {
        Patient = GetJohnDoe(),
        SchemaId = schemaId,
        IsStat = true,
        Items = codes.Select(x => new Skyware.Lis.AkitaModel.SaleItem() { LoincId = x }).ToArray(),
    };



}
