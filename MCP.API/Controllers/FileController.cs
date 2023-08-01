// Bring in the necessary namespaces for the classes and interfaces used in this code.
using MCP.API.ViewModels;
using MCP.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;

namespace MCP.API.Controllers
{
    /// <summary>
    /// This controller handles requests related to files.
    /// </summary>
    [Authorize] // Allow authorized access to this controller
    [ApiController] // Indicates that this is an API controller
    [Route("[controller]")] // Route for accessing this controller, where [controller] will be replaced with the name of the controller (File in this case)
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FileController(IFileService fileService)
        {
            _fileService = fileService ?? throw new ArgumentNullException(nameof(fileService));
        }

        /// <summary>
        ///     Upload files for an assignment.
        /// </summary>
        /// <param name="request">The upload request containing the assignment number and files to be uploaded.</param>
        // [AllowAnonymous]
        [HttpPost("upload")]
        [AuthorizeForScopes (Scopes = new string[] {"https://portalmcp.onmicrosoft.com/mcp/api/files.write"})]
        public async Task<IActionResult> Upload([FromForm] UploadRequest request)
        {
            if (request.Files == null || request.Files.Count == 0)
                return BadRequest();

            await _fileService.UploadFiles(request.AssignmentNumber, request.Files);

            // Return a success response
            return Ok();
        }

        /// <summary>
        ///     Update a file for an assignment.
        /// </summary>
        /// <param name="request">The update request containing the assignment number, file name, and the file to be updated.</param>
        // [AllowAnonymous]
        [HttpPut("update")]
        // [AuthorizeForScopes (Scopes = new string[] {"https://portalmcp.onmicrosoft.com/mcp/api/files.write"})]
        public async Task<IActionResult> Update([FromForm] UpdateRequest request)
        {
            if (request.File == null)
                return BadRequest();

            await _fileService.UpdateFile(request.AssignmentNumber, request.FileName, request.File);

            // Return a success response
            return Ok();
        }

        /// <summary>
        ///     Download a file for an assignment.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number for the file to be downloaded.</param>
        /// <param name="fileName">The name of the file to be downloaded.</param>
        // [AllowAnonymous]
        [HttpGet("download")]
        // [AuthorizeForScopes (Scopes = new string[] {"https://portalmcp.onmicrosoft.com/mcp/api/files.read"})]
        public async Task<IActionResult> Download(string assignmentNumber, string fileName)
        {
            if (string.IsNullOrEmpty(assignmentNumber) || string.IsNullOrEmpty(fileName))
                return BadRequest();

            var fileStream = await _fileService.DownloadFile(assignmentNumber, fileName);

            if (fileStream == null)
                return NotFound();

            // Return the file as a response
            return File(fileStream, "application/octet-stream", fileName);
        }

        /// <summary>
        ///     Delete a file for an assignment.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number for the file to be deleted.</param>
        /// <param name="fileName">The name of the file to be deleted.</param>
        // [AllowAnonymous]
        [HttpDelete("delete")]
        // [AuthorizeForScopes (Scopes = new string[] {"https://portalmcp.onmicrosoft.com/mcp/api/files.write"})]
        public async Task<IActionResult> Delete(string assignmentNumber, string fileName)
        {
            if (string.IsNullOrEmpty(assignmentNumber) || string.IsNullOrEmpty(fileName))
                return BadRequest();

            var result = await _fileService.DeleteFile(assignmentNumber, fileName);

            if (!result)
                return NotFound();

            // Return a success response
            return Ok();
        }

        /// <summary>
        ///     Get all files for an assignment.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number to retrieve the files for.</param>
        // [AllowAnonymous]
        [HttpGet("getAll")]
        // [AuthorizeForScopes (Scopes = new string[] {"https://portalmcp.onmicrosoft.com/mcp/api/files.write"})]
        public async Task<IActionResult> GetAll(string assignmentNumber)
        {
            if (string.IsNullOrEmpty(assignmentNumber))
                return BadRequest();

            var files = await _fileService.GetAllFiles(assignmentNumber);

            // Return the files as a response
            return Ok(files);
        }

        /// <summary>
        ///     Get all photos for an assignment.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number to retrieve the photos for.</param>
        // [AllowAnonymous]
        [HttpGet("getPhotos")]
        // [AuthorizeForScopes (Scopes = new string[] {"https://portalmcp.onmicrosoft.com/mcp/api/files.write"})]
        public async Task<IActionResult> GetPhotos(string assignmentNumber)
        {
            if (string.IsNullOrEmpty(assignmentNumber))
                return BadRequest();

            var photos = await _fileService.GetPhotos(assignmentNumber);

            // Return the photos as a response
            return Ok(photos);
        }

        /// <summary>
        ///     Get all documents for an assignment.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number to retrieve the documents for.</param>
        // [AllowAnonymous]
        [HttpGet("getDocuments")]
        // [AuthorizeForScopes (Scopes = new string[] {"https://portalmcp.onmicrosoft.com/mcp/api/files.write"})]
        public async Task<IActionResult> GetDocuments(string assignmentNumber)
        {
            if (string.IsNullOrEmpty(assignmentNumber))
                return BadRequest();

            var documents = await _fileService.GetDocuments(assignmentNumber);

            // Return the documents as a response
            return Ok(documents);
        }
    }
}