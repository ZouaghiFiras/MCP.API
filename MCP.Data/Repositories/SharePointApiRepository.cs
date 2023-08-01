// Bring in the necessary namespaces for the classes and interfaces used in this code.
using System.Net.Http.Headers;
using System.Text;
using MCP.Data.Interfaces;
using MCP.Data.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace MCP.Data.Repositories
{
    /// <summary>
    /// Repository for interacting with SharePoint API.
    /// </summary>
    public class SharePointApiRepository : ISharePointApiRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _photoAppSecret;
        private readonly string _prospectAuthApiUrl;
        private readonly string _prospectEmail;
        private readonly string _commonApiUrl;
        private readonly string _dmsServiceUrl;
        private readonly string _dossierApiUrl;

        /// <summary>
        /// Initializes a new instance of the <see cref="SharePointApiRepository"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        /// <param name="config">The configuration.</param>
        public SharePointApiRepository(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _httpClient.Timeout = TimeSpan.FromMinutes(5);
            _dossierApiUrl = config["SharePoint:DossierApiUrl"];
            _prospectEmail = config["SharePoint:ProspectEmail"];
            _photoAppSecret = config["SharePoint:PhotoAppSecret"];
            _prospectAuthApiUrl = config["SharePoint:ProspectAuthApiUrl"];
            _commonApiUrl = config["SharePoint:CommonApiUrl"];
            _dmsServiceUrl = config["SharePoint:DmsServiceUrl"];
        }

        /// <summary>
        /// Retrieves documents from SharePoint based on the assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <returns>A collection of documents.</returns>
        public async Task<IEnumerable<Document>> GetDocumentsFromSharePointAsync(string assignmentNumber)
        {
            var token = await GetProspectToken();

            var api = $"{_dossierApiUrl}Document/{assignmentNumber}";

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.GetAsync(api);
            response.EnsureSuccessStatusCode();
            var jsonString = await response.Content.ReadAsStringAsync();
            var documents = JsonConvert.DeserializeObject<IEnumerable<Document>>(jsonString);
            return documents;
        }

        /// <summary>
        /// Retrieves the source of a document from SharePoint based on the file name.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <returns>The document source as a string.</returns>
        public async Task<string> GetDocumentsSourceFromSharePointAsync(string fileName)
        {
            var token = await GetProspectToken();

            var api = $"{_dmsServiceUrl}Document/Download?fileName={fileName}";

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.GetAsync(api);
            response.EnsureSuccessStatusCode();
            var jsonString = await response.Content.ReadAsStringAsync();
            return jsonString;
        }

        /// <summary>
        /// Retrieves the source of a document from SharePoint based on the file name.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <returns>The document source as a string.</returns>
        public async Task<string> GetDocumentSourceFromSharePointAsync(string fileName)
        {
            var token = await GetProspectToken();

            var api = $"{_dmsServiceUrl}Document/Download?fileName={fileName}";

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.GetAsync(api);
            response.EnsureSuccessStatusCode();
            var jsonString = await response.Content.ReadAsStringAsync();
            return jsonString;
        }

        /// <summary>
        /// Retrieves the prospect token for the given email.
        /// </summary>
        /// <param name="email">The email address.</param>
        /// <returns>The prospect token.</returns>
        public async Task<string> GetProspectToken()
        {
            var model = new CreateApiClientTokenRequest
            {
                Email = _prospectEmail,
                Secret = _photoAppSecret
            };

            var api = $"{_prospectAuthApiUrl}photoApp-token";

            var response = await _httpClient.PostAsync(api, new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json"));
            var token = await response.Content.ReadAsStringAsync();

            return token;
        }
        

        /// <summary>
        /// Retrieves the available document types from SharePoint.
        /// </summary>
        /// <returns>A collection of document types.</returns>
        public async Task<IEnumerable<string>> GetDocumentTypes()
        {
            var token = await GetProspectToken();

            var api = $"{_dmsServiceUrl}Document/Types";

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _httpClient.GetAsync(api);

            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<IEnumerable<string>>(jsonString);
            return result;
        }
    }
}
