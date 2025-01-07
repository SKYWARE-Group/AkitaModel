using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.Results;

namespace ModelExamples.Results;

public class ResultsExample
{

    public static Patient GetDemoPatient() => new()
    {
        Id = 12345,
        PidTypeId = 99,
        PidTypeIdName = "SSN",
        PatientId = "123-45-6789",
        GivenName = "John",
        FamilyName = "Doe",
        DateOfBirth = DateTime.Now.AddYears(-30).AddMonths(-8).AddDays(6),
        IsDobApprox = false,
        IsMale = false,
    };

    public static VisitResults GetDemoVisitResults() => new()
    {
        Id = 654321,
        Patient = GetDemoPatient(),
        Date = DateTime.Now,
        DepartmentResults = [ GetDemoDepartmentResults() ],
    };

    public static VisitBalance GetDemoVisitBalance() => new()
    {
        Id = 654321,
        Patient = GetDemoPatient(),
        Date = DateTime.Now,
        Sales = [ 
            new() {
                Id = 123456,
                Date = DateTime.Now,
                Products = [
                    new() { Id = 789, Name = "CBC", Price = 6.50m },
                    new() { Id = 790, Name = "Glucose", Price = 3.20m },
                ],
                Payments = [
                    new CashPayment() { Id = 987654, Date = DateTime.Now, Amount = 9.70m },
                ],
            }
        ],
    };

    public static DepartmentResults GetDemoDepartmentResults() => new()
    {
        DepartmentId = 15,
        DepartmentName = "Hematology",
        Results = [
            GetDemoPanel(),
            new Skyware.Lis.AkitaModel.Results.Test() { 
                Id = 225544, 
                Name = "Glucose", 
                TextResult = "7.2", 
                Units = "mmol/L",
                FlagLevel = FlagLevels.HIGH,
                FlagText = "↑",
                Rank = 1,
            },
        ],
    };

    public static Panel GetDemoPanel() => new()
    {
        Id = 123456,
        Name = "CBC",
        ProductId = 789,
        Tests = [
            new() { Id = 225544, Name = "HGB", TextResult = "140", Units = "g/L" },
            new() { Id = 225544, Name = "WBC", TextResult = "5.62", FlagLevel = FlagLevels.HIGH, FlagText = "↑", Units = "G/L" },
        ],
    };

}
