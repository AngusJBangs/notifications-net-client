using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Notify.Interfaces
{
    public interface IBaseClient
    {
        Task<string> GET(string url, CancellationToken cancellationToken);

        Task<string> POST(string url, string json, CancellationToken cancellationToken);

        Task<string> MakeRequest(string url, HttpMethod method, CancellationToken cancellationToken, HttpContent content = null);

        Tuple<string, string> ExtractServiceIdAndApiKey(string fromApiKey);

        Uri ValidateBaseUri(string baseUrl);

		string GetUserAgent();
    }
}
