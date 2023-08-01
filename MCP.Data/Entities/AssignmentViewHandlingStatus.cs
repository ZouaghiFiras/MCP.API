namespace CED.Data.Entities
{
    public class AssignmentViewHandlingStatus
    {
        public Guid AssignmentId { get; set; }

        public Guid? EmployeeId { get; set; }

        public string? EmployeeEmail { get; set; }

        public string? Status { get; set; }

        public string? Feature { get; set; }

        public string? QualityCheckStatus { get; set; }
    }
}