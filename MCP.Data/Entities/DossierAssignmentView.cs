namespace CED.Data.Entities
{
    public class DossierAssignmentView
    {
        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public string? EntrySystem { get; set; }

        public Guid DossierAssignmentId { get; set; }

        public string Number { get; set; } = null!;

        public Guid? EmployeeId { get; set; }

        public string? EmployeeEmail { get; set; }

        public string? Product { get; set; }

        public string? MainActivityCode { get; set; }

        public string? MainActivityName { get; set; }

        public string? Status { get; set; }

        public string? SubStatus { get; set; }

        public string? Feature { get; set; }

        public string? QualityCheckStatus { get; set; }

        public Guid? QualityCheckerId { get; set; }

        public Guid? HandlerId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}