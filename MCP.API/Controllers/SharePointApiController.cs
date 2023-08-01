// Bring in the necessary namespaces for the classes and interfaces used in this code.
using MCP.Data.Models;
using MCP.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MCP.API.Controllers
{
    /// <summary>
    /// This controller handles requests related to SharePoint API.
    /// </summary>
    [Authorize] // Allow authorized access to this controller
    [ApiController] // Indicates that this is an API controller
    [Route("[controller]")] // Route for accessing this controller, where [controller] will be replaced with the name of the controller (SharePointApi in this case)
    public class SharePointApiController : ControllerBase
    {
        private readonly ISharePointApiService _sharePointApiService;

        public SharePointApiController(ISharePointApiService sharePointApiService)
        {
            _sharePointApiService =
                sharePointApiService ?? throw new ArgumentNullException(nameof(sharePointApiService));
        }

        /// <summary>
        ///     Get files for a specific assignment from SharePoint.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number to retrieve files for.</param>
        // [AllowAnonymous]
        [HttpGet("Files/{assignmentNumber}")]
        public async Task<ActionResult<IEnumerable<Document>>> GetFiles(string assignmentNumber)
        {
            try
            {
                // Remove the last 'A' character from the assignment number, if present
                var lastAIndex = assignmentNumber.LastIndexOf('A');
                if (lastAIndex >= 0)
                {
                    assignmentNumber = assignmentNumber.Substring(0, lastAIndex);
                }

                // Call the service to get the files for the assignment
                var fileDocuments = await _sharePointApiService.GetFilesAsync(assignmentNumber);

                // Return the files as a response
                return Ok(fileDocuments);
            }
            catch (Exception ex)
            {
                // Log the error and return an internal server error response
                await Console.Error.WriteLineAsync($"Error in GetFiles: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        ///     Get the source URLs of files for a specific assignment from SharePoint.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number to retrieve file source URLs for.</param>
        // [AllowAnonymous]
        [HttpGet("Files/src/{assignmentNumber}")]
        public async Task<ActionResult<IEnumerable<string>>> GetFilesSrc(string assignmentNumber)
        {
            try
            {
                // Remove the last 'A' character from the assignment number, if present
                var lastAIndex = assignmentNumber.LastIndexOf('A');
                if (lastAIndex >= 0)
                {
                    assignmentNumber = assignmentNumber.Substring(0, lastAIndex);
                }

                // Call the service to get the file source URLs for the assignment
                var filesSrc = await _sharePointApiService.GetFilesSrcAsync(assignmentNumber);

                // Return the file source URLs as a response
                return Ok(filesSrc);
            }
            catch (Exception ex)
            {
                // Log the error and return an internal server error response
                await Console.Error.WriteLineAsync($"Error in GetFilesSrc: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        /// <summary>
        ///     Get the source URL of a specific file for a specific assignment from SharePoint.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number of the file.</param>
        /// <param name="fileName">The name of the file.</param>
        // [AllowAnonymous]
        [HttpGet("Files/src/{assignmentNumber}/{fileName}")]
        public async Task<ActionResult<string>> GetFileSrc(string fileName)
        {
            try
            {
                // Call the service to get the file source URL for the assignment and file name
                var src = await _sharePointApiService.GetFileSrcAsync(fileName);

                // Return the file source URL as a response
                return Ok(src);
            }
            catch (Exception ex)
            {
                // Log the error and return an internal server error response
                await Console.Error.WriteLineAsync($"Error in GetFileSrc: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        /// <summary>
        ///     Get document types from SharePoint API.
        /// </summary>
        // [AllowAnonymous]
        [HttpGet("Token")]
        public async Task<IActionResult> GetProspectToken()
        {
            try
            {
                // Fetch Token for the SharePoint API
                var result = await _sharePointApiService.GetProspectToken();

                // Return the token as response
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log the error and return an internal server error response
                await Console.Error.WriteLineAsync($"Error in GetDocumentTypes: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        
        /// <summary>
        ///     Get document types from SharePoint API.
        /// </summary>
        // [AllowAnonymous]
        [HttpGet("Files/Types")]
        public async Task<IActionResult> GetDocumentTypes()
        {
            try
            {
                // Fetch document types from the SharePoint API
                var result = await _sharePointApiService.GetDocumentTypes();

                // Return the document types as a response
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log the error and return an internal server error response
                await Console.Error.WriteLineAsync($"Error in GetDocumentTypes: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        
    }
}