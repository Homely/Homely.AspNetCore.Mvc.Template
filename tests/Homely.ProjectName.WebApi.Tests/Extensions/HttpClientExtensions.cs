using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Homely.ProjectName.WebApi.Tests.Extensions
{
    public static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> PostJsonAsync<T>(this HttpClient httpClient, string requestUri,
            T command)
        {
            return httpClient.PostAsync("/test", GetJsonContent(command));
        }

        public static Task<HttpResponseMessage> PutJsonAsync<T>(this HttpClient httpClient, string requestUri,
            T command)
        {
            return httpClient.PutAsync("/test", GetJsonContent(command));
        }

        private static StringContent GetJsonContent<T>(T command)
        {
            return new StringContent(JsonConvert.SerializeObject(command), Encoding.UTF8, "application/json");
        }
    }
}