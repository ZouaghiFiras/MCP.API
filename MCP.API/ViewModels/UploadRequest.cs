
namespace MCP.API.ViewModels
{
    /// <summary>
    ///     Represents the upload request for files.
    /// </summary>
    public class UploadRequest
    {
        /// <summary>
        ///     Gets or sets the assignment number.
        /// </summary>
        public string AssignmentNumber { get; set; }

        /// <summary>
        ///     Gets or sets the list of files to upload.
        /// </summary>
        public List<IFormFile> Files { get; set; }
    }
}