namespace MCP.Data.Models
{
    /// <summary>
    /// Represents a SharePoint document.
    /// </summary>
    public class SPDocument
    {
        /// <summary>
        /// Gets or sets the ID of the document.
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the GUID of the document.
        /// </summary>
        public Guid? Guid { get; set; }

        /// <summary>
        /// Gets or sets the name of the document.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name of the document.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description of the document.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the timestamp of the document.
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the extension of the document.
        /// </summary>
        public string? Extension { get; set; }

        /// <summary>
        /// Gets or sets the size of the document.
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets the username of the user who uploaded the document.
        /// </summary>
        public string? UploadedBy { get; set; }

        /// <summary>
        /// Gets or sets the type of the document.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the content of the document.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the document should be converted to PDF.
        /// </summary>
        public bool ToPdf { get; set; }

        /// <summary>
        /// Gets or sets the URL of the document.
        /// </summary>
        public string? Url { get; set; }
    }
}
