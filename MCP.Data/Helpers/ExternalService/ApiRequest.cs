using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace MCP.Data.Helpers.ExternalService
{
    public static class ApiRequest<T>
    {
        private static JsonSerializerSettings JsonSettings => new()
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        public static T GetRequest<T>(string api)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenHelper.Token);
            var foResponse = httpClient.GetAsync(new Uri(api)).Result;
            var jsonString = foResponse.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<T>(jsonString, JsonSettings);
            return result;
        }

        public static T PostRequest<T>(string api, dynamic? body = null)
        {
            var bodyContent = JsonConvert.SerializeObject(body);
            var buffer = Encoding.UTF8.GetBytes(bodyContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenHelper.Token);
            var foResponse = CallMethod(api, HttpMethods.Post, httpClient, 3, byteContent);
            var jsonString = foResponse.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<T>(jsonString, JsonSettings);
            return result;
        }

        public static T PutRequest(string api, dynamic? body = null)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var bodyContent = JsonConvert.SerializeObject(body);
            var buffer = Encoding.UTF8.GetBytes(bodyContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenHelper.Token);
            var foResponse = CallMethod(api, HttpMethods.Put, httpClient, 3, byteContent);
            var jsonString = foResponse.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<T>(jsonString, JsonSettings);
            return result;
        }

        public static void PostRequestAsync(string api, dynamic? body = null)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var bodyContent = JsonConvert.SerializeObject(body);
            var buffer = Encoding.UTF8.GetBytes(bodyContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenHelper.Token);
            httpClient.PostAsync(new Uri(api), byteContent);
        }

        public static void PostRequestSync(string api, dynamic? body = null)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var bodyContent = JsonConvert.SerializeObject(body);
            var buffer = Encoding.UTF8.GetBytes(bodyContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenHelper.Token);
            CallMethod(api, HttpMethods.Post, httpClient, 3, byteContent);
        }

        private static HttpResponseMessage CallMethod(string api, HttpMethods method, HttpClient httpClient,
            int nbRetry, ByteArrayContent? byteContent = null)
        {
            var i = 0;
            var foResponse = new HttpResponseMessage();
            while (i < nbRetry)
            {
                Task<HttpResponseMessage> call;
                switch (method)
                {
                    case HttpMethods.Get:
                        call = httpClient.GetAsync(new Uri(api));
                        break;

                    case HttpMethods.Post:
                        call = httpClient.PostAsync(new Uri(api), byteContent);
                        break;

                    case HttpMethods.Put:
                        call = httpClient.PutAsync(new Uri(api), byteContent);
                        break;

                    case HttpMethods.Delete:
                        call = httpClient.DeleteAsync(new Uri(api));
                        break;

                    default:
                        throw new Exception("method unspecified");
                }

                foResponse = call.Result;
                if (foResponse.IsSuccessStatusCode)
                {
                    return foResponse;
                }

                Thread.Sleep(100);
                i++;
            }

            throw new Exception(api + "failed with status" + foResponse.StatusCode);
        }
    }
}
