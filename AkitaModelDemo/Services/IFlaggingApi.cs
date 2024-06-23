using Refit;
using Skyware.Lis.AkitaModel;
using Skyware.Lis.AkitaModel.Flagging;

namespace AkitaModelDemo.Services
{
    internal interface IFlaggingApi
    {
        [Get(Constants.URL_FLAGGING_TESTS)]
        Task<IEnumerable<Test>> GetAllTests([Header(Constants.API_KEY_HEADER)] string authorization);

        [Post(Constants.URL_FLAGGING_TESTS)]
        Task<IEnumerable<ResultResponse>> GetTestResult([Body] IEnumerable<ResultRequest> request,[Header(Constants.API_KEY_HEADER)] string authorization);

        [Get(Constants.URL_FLAGGING_SINGLE_TEST)]
        Task<Test> GetSingleTest(int id,[Header(Constants.API_KEY_HEADER)] string authorization);
    }
}
