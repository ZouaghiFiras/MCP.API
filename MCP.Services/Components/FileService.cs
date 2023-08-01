// Bring in the necessary namespaces for the classes and interfaces used in this code.
using Azure.Storage.Blobs;
using MCP.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace MCP.Services.Components
{
    /// <summary>
    /// Service class for file operations using Azure Blob Storage.
    /// </summary>
    public class FileService : IFileService
    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly IConfiguration _configuration;
        private readonly List<string> _documentExtensions;
        private readonly List<string> _photoExtensions;

        /// <summary>
        /// Initializes a new instance of the FileService class.
        /// </summary>
        /// <param name="blobServiceClient">The BlobServiceClient instance for Azure Blob Storage.</param>
        /// <param name="configuration">The configuration settings for the file service.</param>
        public FileService(BlobServiceClient blobServiceClient, IConfiguration configuration)
        {
            _blobServiceClient = blobServiceClient;
            _configuration = configuration;
            _documentExtensions = _configuration.GetSection("DocumentExtensions").Get<List<string>>();
            _photoExtensions = _configuration.GetSection("PhotoExtensions").Get<List<string>>();
        }

        /// <inheritdoc />
        public async Task UploadFiles(string assignmentNumber, List<IFormFile> files)
        {
            var containerName = "uploads";
            var blobContainer = _blobServiceClient.GetBlobContainerClient(containerName);

            // Check if container exists, create if not
            if (!await blobContainer.ExistsAsync())
                await blobContainer.CreateAsync();

            foreach (var file in files)
            {
                var fileName = file.FileName;
                var blobClient = blobContainer.GetBlobClient($"{assignmentNumber}/{fileName}");

                await blobClient.UploadAsync(file.OpenReadStream());
            }
        }

        /// <inheritdoc />
        public async Task UpdateFile(string assignmentNumber, string fileName, IFormFile file)
        {
            var containerName = "uploads";
            var blobContainer = _blobServiceClient.GetBlobContainerClient(containerName);

            // Check if container exists, return if not
            if (!await blobContainer.ExistsAsync())
                return;

            var blobClient = blobContainer.GetBlobClient($"{assignmentNumber}/{fileName}");

            await blobClient.UploadAsync(file.OpenReadStream(), overwrite: true);
        }

        /// <inheritdoc />
        public async Task<Stream> DownloadFile(string assignmentNumber, string fileName)
        {
            var containerName = "uploads";
            var blobContainer = _blobServiceClient.GetBlobContainerClient(containerName);

            // Check if container exists, return null if not
            if (!await blobContainer.ExistsAsync())
                return null;

            var blobClient = blobContainer.GetBlobClient($"{assignmentNumber}/{fileName}");

            var downloadContent = await blobClient.DownloadAsync();
            return downloadContent.Value.Content;
        }

        /// <inheritdoc />
        public async Task<bool> DeleteFile(string assignmentNumber, string fileName)
        {
            var containerName = "uploads";
            var blobContainer = _blobServiceClient.GetBlobContainerClient(containerName);

            // Check if container exists, return false if not
            if (!await blobContainer.ExistsAsync())
                return false;

            var blobClient = blobContainer.GetBlobClient($"{assignmentNumber}/{fileName}");

            return await blobClient.DeleteIfExistsAsync();
        }

        /// <inheritdoc />
        public async Task<IEnumerable<string>> GetAllFiles(string assignmentNumber)
        {
            var containerName = "uploads";
            var blobContainer = _blobServiceClient.GetBlobContainerClient(containerName);

            // Check if container exists, return empty list if not
            if (!await blobContainer.ExistsAsync())
                return Enumerable.Empty<string>();

            var blobs = new List<string>();

            await foreach (var blobItem in blobContainer.GetBlobsAsync(prefix: $"{assignmentNumber}/"))
            {
                blobs.Add(blobItem.Name);
            }

            return blobs;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<string>> GetPhotos(string assignmentNumber)
        {
            var containerName = "uploads";
            var blobContainer = _blobServiceClient.GetBlobContainerClient(containerName);

            // Check if container exists, return empty list if not
            if (!await blobContainer.ExistsAsync())
                return Enumerable.Empty<string>();

            var photos = new List<string>();

            await foreach (var blobItem in blobContainer.GetBlobsAsync(prefix: $"{assignmentNumber}/"))
            {
                if (IsPhotoExtension(blobItem.Name))
                    photos.Add(blobItem.Name);
            }

            return photos;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<string>> GetDocuments(string assignmentNumber)
        {
            var containerName = "uploads";
            var blobContainer = _blobServiceClient.GetBlobContainerClient(containerName);

            // Check if container exists, return empty list if not
            if (!await blobContainer.ExistsAsync())
                return Enumerable.Empty<string>();

            var documents = new List<string>();

            await foreach (var blobItem in blobContainer.GetBlobsAsync(prefix: $"{assignmentNumber}/"))
            {
                if (IsDocumentExtension(blobItem.Name))
                    documents.Add(blobItem.Name);
            }

            return documents;
        }

        private bool IsPhotoExtension(string fileName)
        {
            var extension = Path.GetExtension(fileName)?.ToLowerInvariant();
            return _photoExtensions.Contains(extension);
        }

        private bool IsDocumentExtension(string fileName)
        {
            var extension = Path.GetExtension(fileName)?.ToLowerInvariant();
            return _documentExtensions.Contains(extension);
        }
    }
}
