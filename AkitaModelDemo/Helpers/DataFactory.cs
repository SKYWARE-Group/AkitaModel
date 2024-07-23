using Skyware.Lis.AkitaModel.Flagging;

namespace AkitaModelDemo.Helpers;

public class DataFactory
{

    public static string PID = "3303234518";

    public static string NRN = "241797000039";

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
