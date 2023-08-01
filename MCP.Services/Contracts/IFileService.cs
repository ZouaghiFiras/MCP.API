// Bring in the necessary namespaces for the classes and interfaces used in this code.
using Microsoft.AspNetCore.Http;

namespace MCP.Services.Contracts
{
    /// <summary>
    /// Interface defining the contract for a service that handles file-related operations.
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Uploads multiple files associated with the specified assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <param name="files">The list of files to upload.</param>
        Task UploadFiles(string assignmentNumber, List<IFormFile> files);

        /// <summary>
        /// Updates the specified file associated with the given assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <param name="fileName">The name of the file to update.</param>
        /// <param name="file">The updated file.</param>
        Task UpdateFile(string assignmentNumber, string fileName, IFormFile file);

        /// <summary>
        /// Downloads the specified file associated with the given assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <param name="fileName">The name of the file to download.</param>
        /// <returns>The stream containing the downloaded file content.</returns>
        Task<Stream> DownloadFile(string assignmentNumber, string fileName);

        /// <summary>
        /// Deletes the specified file associated with the given assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <param name="fileName">The name of the file to delete.</param>
        /// <returns>A boolean value indicating whether the file was deleted successfully.</returns>
        Task<bool> DeleteFile(string assignmentNumber, string fileName);

        /// <summary>
        /// Retrieves the names of all files associated with the specified assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <returns>An enumerable collection of file names.</returns>
        Task<IEnumerable<string>> GetAllFiles(string assignmentNumber);

        /// <summary>
        /// Retrieves the names of all photo files associated with the specified assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <returns>An enumerable collection of photo file names.</returns>
        Task<IEnumerable<string>> GetPhotos(string assignmentNumber);

        /// <summary>
        /// Retrieves the names of all document files associated with the specified assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <returns>An enumerable collection of document file names.</returns>
        Task<IEnumerable<string>> GetDocuments(string assignmentNumber);
    }
}
