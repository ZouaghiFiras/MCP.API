// Bring in the necessary namespaces for the classes and interfaces used in this code.
using MCP.Data.Models;

namespace MCP.Services.Contracts
{
    /// <summary>
    /// Interface defining the contract for a service that interacts with SharePoint API.
    /// </summary>
    public interface ISharePointApiService
    {
        /// <summary>
        /// Retrieves the source URL of the specified file associated with the assignment number.
        /// </summary>
        /// <param name="fileName">The name of the file.</param>
        /// <returns>The source URL of the file.</returns>
        Task<string> GetFileSrcAsync(string fileName);

        /// <summary>
        /// Retrieves a list of documents associated with the assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <returns>An enumerable collection of documents.</returns>
        Task<IEnumerable<Document>> GetFilesAsync(string assignmentNumber);

        /// <summary>
        /// Retrieves a list of source URLs for files associated with the assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <returns>An enumerable collection of source URLs.</returns>
        Task<IEnumerable<string>> GetFilesSrcAsync(string assignmentNumber);

        /// <summary>
        /// Retrieves a list of document types.
        /// </summary>
        /// <returns>An enumerable collection of document types.</returns>
        Task<IEnumerable<string>> GetDocumentTypes();
        /// <summary>
        /// Retrieves the Token for the sharepoint.
        /// </summary>
        /// <returns>A Token string.</returns>
        Task<string> GetProspectToken();

       
    }
    
}
