
namespace MCP.Data.Models
{
    /// <summary>
    /// Represents an assignment.
    /// </summary>
    public class Assignment
    {
        /// <summary>
        /// Gets or sets the assignment number.
        /// </summary>
        public string? AssignmentNumber { get; set; }

        /// <summary>
        /// Gets or sets the date of damage.
        /// </summary>
        public DateTime? DamageDate { get; set; }

        /// <summary>
        /// Gets or sets the order number.
        /// </summary>
        public string? OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the case number.
        /// </summary>
        public string? CaseNumber { get; set; }

        /// <summary>
        /// Gets or sets the status of the assignment.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the involved party.
        /// </summary>
        public string? InvolvedParty { get; set; }

        /// <summary>
        /// Gets or sets the department associated with the assignment.
        /// </summary>
        public string? Department { get; set; }
    }
}