using Refit;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.Robin;

namespace AkitaModelDemo.Services;

public interface IAkitaApi
{

    //[Get(Constants.URL_CORE_PUBLIC_SPECIES)]
    [Get(Constants.URL_CORE_PART_PUBLIC_SPECIES)]
    Task<IEnumerable<Species>> GetAllSpecies();

    //[Get(Constants.URL_CORE_PUBLIC_TESTS)]
    [Get(Constants.URL_CORE_PART_PUBLIC_TESTS)]
    Task<IEnumerable<Test>> GetAllTests();

    [Get(Constants.URL_CORE_PART_PUBLIC_SAMPLE_TYPES)]
    Task<IEnumerable<SampleType>> GetAllSampleTypes();

    [Get(Constants.URL_CORE_PUBLIC_LOCATIONS)]
    //[Get(Constants.URL_CORE_PART_PUBLIC_LOCATIONS)]
    Task<IEnumerable<Location>> GetAllLocations();

    [Get(Constants.URL_CORE_PART_PUBLIC_DEPARTMENTS)]
    Task<IEnumerable<Department>> GetAllDepartments();

    [Get(Constants.URL_ROBIN_DIRECT_REPORTS)]
    Task<IEnumerable<DirectReport>> GetAllReports();

    [Post(Constants.URL_ROBIN_DIRECT_SIMPLE_REPORT)]
    Task<HttpResponseMessage> GetSimpleReport(string id, [Body] object data);

    [Post(Constants.URL_ROBIN_DIRECT_FULL_REPORT)]
    Task<HttpResponseMessage> GetFullReport(string id, [Body] ReportRequest data);

}
