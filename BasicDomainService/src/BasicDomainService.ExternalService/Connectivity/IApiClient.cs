using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasicDomainService.ExternalService.Connectivity
{
    public interface IApiClient
    {
        Task<T> GetModelAsync<T>(string endpoint);
    }
}