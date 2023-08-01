namespace CED.Data.Entities
{
    public class CombinedDossierAssignmentStatusHistory
    {
        public Guid Id { get; set; }

        public Guid DossierAssignmentId { get; set; }

        public string? DossierStatusCode { get; set; }

        public string? DossierStatusShortName { get; set; }

        public string? DossierStatusLongName { get; set; }

        public string? DossierStatusType { get; set; }

        public Guid EmployeeId { get; set; }

        public DateTime StartDate { get; set; }

        public string? StatusChangeReason { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}