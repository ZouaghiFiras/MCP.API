namespace MCP.Services.DTO
{
    /// <summary>
    /// Data Transfer Object (DTO) representing an email.
    /// </summary>
    public class EmailDto
    {
        /// <summary>
        /// Gets or sets the email recipient.
        /// </summary>
        public string To { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the email recipient.
        /// </summary>
        public string ToName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the email subject.
        /// </summary>
        public string Subject { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the email body.
        /// </summary>
        public string Body { get; set; } = string.Empty;
    }
}