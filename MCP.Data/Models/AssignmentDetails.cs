

namespace MCP.Data.Models
{
    /// <summary>
    /// Represents additional details of an assignment.
    /// </summary>
    public class AssignmentDetails
    {
        /// <summary>
        /// Gets or sets the handler of the assignment.
        /// </summary>
        public string Handler { get; set; }

        /// <summary>
        /// Gets or sets the status of the assignment.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the policy number associated with the assignment.
        /// </summary>
        public string? PolicyNumber { get; set; }

        /// <summary>
        /// Gets or sets the insured amount of the assignment.
        /// </summary>
        public decimal? InsuredAmount { get; set; }

        /// <summary>
        /// Gets or sets the own risk amount of the assignment.
        /// </summary>
        public decimal? OwnRisk { get; set; }

        /// <summary>
        /// Gets or sets the policy conditions of the assignment.
        /// </summary>
        public string? PolicyConditions { get; set; }

        /// <summary>
        /// Gets or sets the damage number associated with the assignment.
        /// </summary>
        public string? DamageNumber { get; set; }

        /// <summary>
        /// Gets or sets the date of damage.
        /// </summary>
        public DateTime? DamageDate { get; set; }

        /// <summary>
        /// Gets or sets the estimated damage amount of the assignment.
        /// </summary>
        public decimal? EstimatedDamageAmount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the assignment involves recovery.
        /// </summary>
        public bool? Recovery { get; set; }

        /// <summary>
        /// Gets or sets the department associated with the assignment.
        /// </summary>
        public string? Department { get; set; }

        /// <summary>
        /// Gets or sets the work activity associated with the assignment.
        /// </summary>
        public string? WorkActivity { get; set; }

        /// <summary>
        /// Gets or sets the execution of the activity.
        /// </summary>
        public string? ActivityExecution { get; set; }

        /// <summary>
        /// Gets or sets the reporting form associated with the assignment.
        /// </summary>
        public string? ReportingForm { get; set; }

        /// <summary>
        /// Gets or sets the object related to the assignment.
        /// </summary>
        public string? Object { get; set; }

        /// <summary>
        /// Gets or sets the cause of the assignment.
        /// </summary>
        public string? Cause { get; set; }

        /// <summary>
        /// Gets or sets the coverage related to the assignment.
        /// </summary>
        public string? Coverage { get; set; }

        /// <summary>
        /// Gets or sets the product associated with the assignment.
        /// </summary>
        public string? Product { get; set; }

        /// <summary>
        /// Gets or sets the client name associated with the assignment.
        /// </summary>
        public string? Client { get; set; }

        /// <summary>
        /// Gets or sets the contact person associated with the assignment.
        /// </summary>
        public string? ContactPerson { get; set; }

        /// <summary>
        /// Gets or sets the email address of the contact person associated with the assignment.
        /// </summary>
        public string? ContactPersonEmail { get; set; }

        /// <summary>
        /// Gets or sets the intake method of the assignment.
        /// </summary>
        public string? IntakeMethod { get; set; }

        /// <summary>
        /// Gets or sets the deed of assignment associated with the assignment.
        /// </summary>
        public string? DeedOfAssignment { get; set; }

        /// <summary>
        /// Gets or sets the expert associated with the assignment.
        /// </summary>
        public string? Expert { get; set; }

        /// <summary>
        /// Gets or sets the visit date related to the assignment.
        /// </summary>
        public DateTime? VisitDate { get; set; }

        /// <summary>
        /// Gets or sets the list of parties associated with the assignment.
        /// </summary>
        public IEnumerable<PartyData> Parties { get; set; }
    }
}
