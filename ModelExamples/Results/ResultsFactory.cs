using Microsoft.EntityFrameworkCore;
using Skyware.Lis.AkitaModel.Results;
using Skyware.LisModel;

namespace ModelExamples.Results;

public class ResultsFactory
{

    public static async Task<VisitResults> GetVisitResults(string connectionString, int id)
    {
        DbContextOptions<LisContext> options = new DbContextOptionsBuilder<LisContext>()
            .UseSqlServer(connectionString)
            .Options;
        using LisContext context = new(options);
        
        Sale? sale  = await context.Sales
            .Include(s => s.Patient)
                .ThenInclude(p => p.PidType)
            .Include(s => s.Items)
                .ThenInclude(i => i.Test)
            .Include(s => s.Items)
                .ThenInclude(i => i.Profile)
            .FirstOrDefaultAsync(s => s.Id == id) ?? throw new Exception($"Sale with Id {id} not found.");

        VisitResults visitResults = new()
        {
            Id = sale.Id,
            Patient = new()
            {
                Id = sale.Patient.Id,
                PidTypeId = sale.Patient.PidTypeId,
                PidTypeIdName = sale.Patient.PidType?.Name,
                PatientId = sale.Patient.Pid,
                GivenName = sale.Patient.GivenName,
                FamilyName = sale.Patient.FamilyName,
                DateOfBirth = sale.Patient.Born,
                IsDobApprox = sale.Patient.IsDobApproximate,
                IsMale = sale.Patient.IsMale,
            },
            Date = sale.Created,
            DepartmentResults = [],
        };


        return visitResults;
    }

}
