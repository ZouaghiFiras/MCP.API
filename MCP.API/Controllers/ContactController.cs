// Bring in the necessary namespaces for the classes and interfaces used in this code.
using MCP.Services.Contracts;
using MCP.Services.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;

namespace MCP.API.Controllers
{
    /// <summary>
    ///     This controller handles requests related to sending emails.
    /// </summary>
    [Authorize] // Allow anonymous access to this controller
    // [AuthorizeForScopes (Scopes = new string[] {"https://portalmcp.onmicrosoft.com/mcp/api/email.write"})]
    [ApiController] // Indicates that this is an API controller
    [Route("[controller]")] // Route for accessing this controller, where [controller] will be replaced with the name of the controller (Contact in this case)
    public class ContactController : BaseController
    {
        private readonly IContactService _emailService;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ContactController" /> class.
        /// </summary>
        /// <param name="emailService">The email service.</param>
        public ContactController(IContactService emailService)
        {
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
        }

        /// <summary>
        ///     Sends an email.
        /// </summary>
        /// <param name="request">The email request DTO.</param>
        /// <returns>An IActionResult indicating the status of the email send operation.</returns>
        // [AllowAnonymous]
        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            // Call the email service to send the email asynchronously
            _emailService.SendEmailAsync(request);

            // Return an HTTP 200 status code indicating success
            return Ok();
        }
    }
}