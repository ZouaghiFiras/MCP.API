// Bring in the necessary namespaces for the classes and interfaces used in this code.
using System.ComponentModel.DataAnnotations;
using MCP.Data.Models;
using MCP.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;

namespace MCP.API.Controllers
{
    /// <summary>
    /// This controller handles requests related to Assignments.
    /// </summary>
    [Authorize] // Allow anonymous access to this controller
    // [AuthorizeForScopes (Scopes = new string[] {"https://portalmcp.onmicrosoft.com/mcp/api/assignments.read"})]
    [ApiController] // Indicates that this is an API controller
    [Route("[controller]")] // Route for accessing this controller, where [controller] will be replaced with the name of the controller (Assignment in this case)
    public class AssignmentController : BaseController
    {
        private readonly IAssignmentService _assignmentService;

        public AssignmentController(IAssignmentService assignmentService)
        {
            // Check for null dependencies
            _assignmentService = assignmentService ?? throw new ArgumentNullException(nameof(assignmentService));
        }

        /// <summary>
        ///     GET all assignments from the database.
        /// </summary>
        /// <param name="cultureCode">The culture code for the language used.</param>
        // [AllowAnonymous]
        [HttpGet("assignments")]
        public IActionResult GetAssignments([FromQuery] [Required] string cultureCode)
        {
            try
            {
                // Get all assignments
                var assignments = _assignmentService.GetAll(cultureCode);

                // Return the assignments
                return Ok(assignments);
            }
            catch (Exception ex)
            {
                // Log the error message and return an Internal Server Error response
                // loggingService.Log(ex);
                return StatusCode(500, $"An error occurred while fetching assignments: {ex.Message}");
            }
        }
        /// <summary>
        ///     Get a list of assignments based on the provided search criteriavalues.
        /// </summary>
        /// <param name="searchCriteria">Object containing the search criteria values to filter the assignments.</param>
        /// <param name="cultureCode">The culture code for the language used.</param>
        // [AllowAnonymous]
        [HttpGet("search")]
        public IActionResult GetSearchResults(
            [FromQuery] [Required] SearchCriteria searchCriteria,
            [FromQuery] [Required] string cultureCode)
        {
            try
            {
                // Get the paginated list of assignments based on search criteria values
                var result = _assignmentService.GetSearchResults(searchCriteria, cultureCode);

                // Return the result
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                // If an ArgumentException is thrown, return a Bad Request response with the exception message
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                // Log the error message and return an Internal Server Error response
                // loggingService.Log(ex);
                return StatusCode(500, $"An error occurred while fetching assignments: {ex.Message}");
            }
        }
        /// <summary>
        ///     Get a list of assignments based on the provided search criteriavalues.
        /// </summary>
        /// <param name="searchCriteria">Object containing the search criteria values to filter the assignments.</param>
        /// <param name="cultureCode">The culture code for the language used.</param>
        // [AllowAnonymous]
        [HttpGet("search/work_in_progress")]
        public IActionResult GetWorkInProgressSearchResults(
            [FromQuery] [Required] SearchCriteria searchCriteria,
            [FromQuery] [Required] string cultureCode)
        {
            try
            {
                // Get the paginated list of assignments based on search criteria values
                var assignments = _assignmentService.GetSearchResults(searchCriteria, cultureCode);
                var result = assignments.Where(x => x.Status == "New"
                                                    || x.Status == "To Plan"
                                                    || x.Status == "Planned"
                                                    || x.Status == "Handling");

                // Return the result
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                // If an ArgumentException is thrown, return a Bad Request response with the exception message
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                // Log the error message and return an Internal Server Error response
                // loggingService.Log(ex);
                return StatusCode(500, $"An error occurred while fetching assignments: {ex.Message}");
            }
        }
        /// <summary>
        ///     Get a paginated list of assignments based on the provided search criteria, skip and take values.
        /// </summary>
        /// <param name="searchCriteria">Object containing the search criteria values to filter the assignments.</param>
        /// <param name="cultureCode">The culture code for the language used.</param>
        /// <param name="skip">Number of items to skip in the result.</param>
        /// <param name="take">Number of items to take from the result.</param>
        // [AllowAnonymous]
        [HttpGet("paging")]
        public IActionResult GetPaginated(
            [FromQuery] [Required] SearchCriteria searchCriteria,
            [FromQuery] [Required] string cultureCode,
            [FromQuery] [Required] int skip,
            [FromQuery] [Required] int take)
        {
            try
            {
                // Get the paginated list of assignments based on search criteria, skip and take values
                var result = _assignmentService.GetPaginatedResults(searchCriteria, cultureCode, skip, take);

                // Return the result
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                // If an ArgumentException is thrown, return a Bad Request response with the exception message
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                // Log the error message and return an Internal Server Error response
                // loggingService.Log(ex);
                return StatusCode(500, $"An error occurred while fetching assignments: {ex.Message}");
            }
        }

        /// <summary>
        ///     Get the details of an assignment by its assignment number.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number to search for.</param>
        /// <param name="cultureCode">The culture code for the language used.</param>
        // [AllowAnonymous]
        [HttpGet("details")]
        public ActionResult<AssignmentDetails> GetAssignmentDetailsByAssignmentNumber(
            [FromQuery] [Required] string assignmentNumber,
            [FromQuery] [Required] string cultureCode)
        {
            try
            {
                // Get the details of the assignment by its assignment number
                var result = _assignmentService.GetAssignmentDetailsByAssignmentNumber(assignmentNumber, cultureCode);

                // Return the details of the assignment
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                // If an ArgumentException is thrown, return a Bad Request
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                // If any other type of exception is thrown, log the error message and return an Internal Server Error response.
                // loggingService.Log(ex);
                return StatusCode(500, $"An error occurred while fetching assignment details: {ex.Message}");
            }
        }
    }
}