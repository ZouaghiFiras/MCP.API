// Bring in the necessary namespaces for the classes and interfaces used in this code.
using System.Collections.Generic;
using System.Threading.Tasks;
using MCP.Data.Models;

namespace MCP.Data.Interfaces
{
    /// <summary>
    /// Interface defining the contract for a repository that interacts with SharePoint APIs.
    /// </summary>
    public interface ISharePointApiRepository
    {
        /// <summary>
        /// Retrieves the document source from SharePoint asynchronously based on the specified file name.
        /// </summary>
        /// <param name="fileName">The name of the file.</param>
        /// <returns>The document source.</returns>
        Task<string> GetDocumentSourceFromSharePointAsync(string fileName);

        /// <summary>
        /// Retrieves the documents from SharePoint asynchronously based on the specified assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <returns>A collection of documents.</returns>
        Task<IEnumerable<Document>> GetDocumentsFromSharePointAsync(string assignmentNumber);

        /// <summary>
        /// Retrieves the document source from SharePoint asynchronously based on the specified file name.
        /// </summary>
        /// <param name="fileName">The name of the file.</param>
        /// <returns>The document source.</returns>
        Task<string> GetDocumentsSourceFromSharePointAsync(string fileName);
        
        /// <summary>
        /// Retrieves the Token for the sharepoint.
        /// </summary>
        /// <returns>A Token string.</returns>
        Task<string> GetProspectToken();

        /// <summary>
        /// Retrieves the document types from SharePoint asynchronously.
        /// </summary>
        /// <returns>A collection of document types.</returns>
        Task<IEnumerable<string>> GetDocumentTypes();
    }
}
