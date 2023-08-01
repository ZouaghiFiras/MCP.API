// This interface defines the methods that should be implemented by a class that provides contact-related services
// The namespaces used in this code are required to reference the relevant classes and interfaces
using MCP.Services.DTO;

namespace MCP.Services.Contracts
{
    /// <summary>
    /// Interface defining the contract for a service that sends emails.
    /// </summary>
    public interface IContactService
    {
        /// <summary>
        /// Sends an email asynchronously.
        /// </summary>
        /// <param name="request">The EmailDto object containing the email details.</param>
        /// <returns>A boolean value indicating whether the email was sent successfully.</returns>
        Task<bool> SendEmailAsync(EmailDto request);
    }
}
