using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;

namespace BasicDomainService.ExternalService.Connectivity
{
    public class ApiClient : IApiClient
    {
        private readonly IRestClient _client;

        public ApiClient(IRestClient client)
        {
            _client = client;
        }

        public async Task<T> GetModelAsync<T>(string endpoint)
        {
            var request = new RestRequest(endpoint, Method.GET) { RequestFormat = DataFormat.Json };
            var result = await _client.ExecuteGetTaskAsync<T>(request);
            return result.IsSuccessful ? result.Data: default(T);
        }
    }
}