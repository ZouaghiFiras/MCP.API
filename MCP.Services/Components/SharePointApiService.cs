// Bring in the necessary namespaces for the classes and interfaces used in this code.
using MCP.Data.Helpers.ExternalService;
using MCP.Data.Interfaces;
using MCP.Data.Models;
using MCP.Services.Contracts;
using Microsoft.Extensions.Configuration;
using Nest;
using System.Net.Http;

namespace MCP.Services.Components
{
    /// <summary>
    /// Service class for interacting with SharePoint APIs.
    /// </summary>
    public class SharePointApiService : ISharePointApiService
    {
        private readonly ISharePointApiRepository _sharePointApiRepository;
        private readonly HttpClient _httpClient;
        private readonly string _photoAppSecret;
        private readonly string _prospectAuthApiUrl;
        private readonly string _prospectEmail;
        private readonly string _commonApiUrl;
        private readonly string _dossierApiUrl;
        /// <summary>
        /// Initializes a new instance of the SharePointApiService class.
        /// </summary>
        /// <param name="config">The configuration settings.</param>
        /// <param name="sharePointApiRepository">The repository for SharePoint API operations.</param>
        public SharePointApiService(IConfiguration config, ISharePointApiRepository sharePointApiRepository)
        {
            _sharePointApiRepository =
                sharePointApiRepository ?? throw new ArgumentNullException(nameof(sharePointApiRepository));
            _dossierApiUrl = config["SharePoint:DossierApiUrl"];
            _prospectEmail = config["SharePoint:ProspectEmail"];
            _photoAppSecret = config["SharePoint:PhotoAppSecret"];
            _prospectAuthApiUrl = config["SharePoint:ProspectAuthApiUrl"];
            _commonApiUrl = config["SharePoint:CommonApiUrl"];
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Document>> GetFilesAsync(string assignmentNumber)
        {
            return await _sharePointApiRepository.GetDocumentsFromSharePointAsync(assignmentNumber);
        }

        /// <inheritdoc />
        public async Task<IEnumerable<string>> GetFilesSrcAsync(string assignmentNumber)
        {
            try
            {
                var files = await _sharePointApiRepository.GetDocumentsFromSharePointAsync(assignmentNumber);

                var filesSrcs = new List<string>();

                foreach (var file in files)
                {
                    var fileName = Path.GetFileName(file.Url);
                    var src = await _sharePointApiRepository.GetDocumentsSourceFromSharePointAsync(fileName);
                    filesSrcs.Add(src);
                }

                return filesSrcs;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error in GetFilesSrcAsync: {ex.Message}");
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<string> GetFileSrcAsync(string fileName)
        {
            try
            {
                var src = await _sharePointApiRepository.GetDocumentSourceFromSharePointAsync(fileName);
                return src;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error in GetFileSrcAsync: {ex.Message}");
                throw;
            }
        }

        /// <inheritdoc />
        public async Task<IEnumerable<string>> GetDocumentTypes()
        {
            return await _sharePointApiRepository.GetDocumentTypes();
        }
        /// <inheritdoc />
        public async Task<string> GetProspectToken()
        {
            return await _sharePointApiRepository.GetProspectToken();
        }
        

    }


}
