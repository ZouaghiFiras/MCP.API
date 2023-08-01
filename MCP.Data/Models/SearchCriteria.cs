namespace MCP.Data.Models
{
    /// <summary>
    /// Represents the search criteria for assignments.
    /// </summary>
    public class SearchCriteria
    {
        /// <summary>
        /// Gets or sets the order number.
        /// </summary>
        public string? OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the policy number.
        /// </summary>
        public string? PolicyNumber { get; set; }

        /// <summary>
        /// Gets or sets the case number.
        /// </summary>
        public string? CaseNumber { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the house number.
        /// </summary>
        public string? HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the assignment number.
        /// </summary>
        public string? AssignmentNumber { get; set; }
    }
}