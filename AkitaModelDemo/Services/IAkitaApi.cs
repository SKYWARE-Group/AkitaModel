using Refit;
using Skyware.Arda.Model;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.BgNhis;
using Skyware.Lis.AkitaModel.Flagging;
using Skyware.Lis.AkitaModel.Robin;

namespace AkitaModelDemo.Services;

public interface IAkitaApi
{

    #region Core-Public

    [Get(Constants.URL_CORE_PUBLIC_SPECIES)]
    Task<IEnumerable<Species>> GetAllSpecies();

    [Get(Constants.URL_CORE_PUBLIC_TESTS)]
    Task<IEnumerable<Test>> GetAllTests([Query] bool? loadRanges = null, [Query] bool? loadSampleType = null, [Query] bool? loadFlagType = null);

    [Get(Constants.URL_CORE_PUBLIC_SINGLE_TEST)]
    Task<Test> GetSingleTest(int id, [Query] bool? loadRanges = null, [Query] bool? loadSampleType = null, [Query] bool? loadFlagType = null);

    [Get(Constants.URL_CORE_PUBLIC_SAMPLE_TYPES)]
    Task<IEnumerable<SampleType>> GetAllSampleTypes();

    [Get(Constants.URL_CORE_PUBLIC_LOCATIONS)]
    Task<IEnumerable<Location>> GetAllLocations();

    [Get(Constants.URL_CORE_PUBLIC_LOCATION_GROUPS)]
    Task<IEnumerable<LocationGroup>> GetAllLocationGroups();

    [Get(Constants.URL_CORE_PUBLIC_PROFILES)]
    Task<IEnumerable<Profile>> GetAllProfiles();

    [Get(Constants.URL_CORE_PUBLIC_SINGLE_PROFILE)]
    Task<Profile> GetSingleProfile(int id);

    [Get(Constants.URL_CORE_PUBLIC_PID_TYPES)]
    Task<IEnumerable<PIDType>> GetAllPIDTypes();

    [Get(Constants.URL_CORE_PUBLIC_CULTURE_INFO)]
    Task<CultureInfo> GetCultureInfo();

    [Get(Constants.URL_CORE_PUBLIC_PRICELIST)]
    Task<IEnumerable<Product>> GetDefaultPricelist();

    [Get(Constants.URL_CORE_PUBLIC_DEPARTMENTS)]
    Task<IEnumerable<Department>> GetAllDepartments();

    #endregion

    #region Core-Sales

    [Post(Constants.URL_CORE_SALES)]
    Task<Sale> CreateSale([Body] Sale visit, [Header(Constants.API_KEY_HEADER)] string apiKey, [Query] bool? genbc = null);

    [Put(Constants.URL_CORE_SINGLE_SALE)]
    Task<Sale> UpadteSale(int id, [Body] Sale visit, [Header(Constants.API_KEY_HEADER)] string apiKey, [Query] bool? genbc = null);

    [Get(Constants.URL_CORE_SINGLE_SALE_SAMPLES)]
    Task<IEnumerable<Sample>> GetSamples(int id, [Header(Constants.API_KEY_HEADER)] string apiKey);

    [Put(Constants.URL_CORE_SINGLE_SALE_ITEMS)]
    Task<SaleItem> SetResult(int id, [Body] SaleItem item, [Header(Constants.API_KEY_HEADER)] string apiKey);

    [Delete(Constants.URL_CORE_SINGLE_SALE_ITEMS_RESULT)]
    Task<SaleItem> UnsetResult(int id, string loincCode, [Header(Constants.API_KEY_HEADER)] string apiKey);

    #endregion

    #region Robin

    [Get(Constants.URL_ROBIN_DIRECT_REPORTS)]
    Task<IEnumerable<DirectReport>> GetAllReports();

    [Post(Constants.URL_ROBIN_DIRECT_SIMPLE_REPORT)]
    Task<HttpResponseMessage> GetSimpleReport(string id, [Body] object data);

    [Post(Constants.URL_ROBIN_DIRECT_FULL_REPORT)]
    Task<HttpResponseMessage> GetFullReport(string id, [Body] ReportRequest data);

    #endregion

    #region Core-Schemas

    [Get(Constants.URL_CORE_SCHMEAS)]
    Task<IEnumerable<Skyware.Lis.AkitaModel.Schema>> GetAllSchemas([Header(Constants.API_KEY_HEADER)] string apiKey);

    [Get(Constants.URL_CORE_PUBLIC_SINGLE_SCHMEA)]
    Task<Skyware.Lis.AkitaModel.Schema> GetSingleSchema(int id, [Header(Constants.API_KEY_HEADER)] string apiKey);

    #endregion

    #region Flagging

    [Get(Constants.URL_FLAGGING_TESTS)]
    Task<IEnumerable<Test>> GetAllTests([Header(Constants.API_KEY_HEADER)] string apiKey);

    [Post(Constants.URL_FLAGGING_TESTS)]
    Task<IEnumerable<ResultResponse>> GetTestResult([Body] IEnumerable<ResultRequest> request, [Header(Constants.API_KEY_HEADER)] string authorization);

    [Get(Constants.URL_FLAGGING_SINGLE_TEST)]
    Task<Test> GetSingleTest(int id, [Header(Constants.API_KEY_HEADER)] string apiKey);

    #endregion

    #region BgNhis

    [Get(Constants.URL_BGNHIS_GET_REFERRAL)]
    Task<Referral?> GetReferral([AliasAs("nrn")] string nrn, [Header(Constants.API_KEY_HEADER)] string apiKey);

    [Get(Constants.URL_BGNHIS_SEARCH_REFERRALS)]
    Task<IEnumerable<Referral>> SearchReferrals([AliasAs("pid")] string pid, [Header(Constants.API_KEY_HEADER)] string apiKey);

    [Get(Constants.URL_BGNHIS_GET_CONTRACTS)]
    Task<IEnumerable<NhifContract>> GetContracts([Header(Constants.API_KEY_HEADER)] string apiKey);

    #endregion
}
