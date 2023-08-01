
namespace MCP.API.ViewModels
{
    /// <summary>
    ///     Represents the update request for a file.
    /// </summary>
    public class UpdateRequest
    {
        /// <summary>
        ///     Gets or sets the assignment number.
        /// </summary>
        public string AssignmentNumber { get; set; }

        /// <summary>
        ///     Gets or sets the file name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        ///     Gets or sets the file data.
        /// </summary>
        public IFormFile File { get; set; }
    }
}