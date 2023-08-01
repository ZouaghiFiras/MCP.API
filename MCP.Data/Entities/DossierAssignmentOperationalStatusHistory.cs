namespace CED.Data.Entities
{
    public class DossierAssignmentOperationalStatusHistory
    {
        public Guid AshId { get; set; }

        public byte[] AshTimeStamp { get; set; } = null!;

        public Guid AshDossierAssignmentId { get; set; }

        public Guid AshDossierAssignmentOperationalStatusId { get; set; }

        public Guid AshEmployeeId { get; set; }

        public DateTime AshStartDate { get; set; }

        public string? AshStatusChangeReason { get; set; }

        public DateTime AshCreatedDate { get; set; }

        public string? AshCreatedBy { get; set; }

        public DateTime AshLastModifiedDate { get; set; }

        public string? AshLastModifiedBy { get; set; }

        public virtual DossierAssignment AshDossierAssignment { get; set; } = null!;

        public virtual DossierAssignmentOperationalStatus AshDossierAssignmentOperationalStatus { get; set; } = null!;
    }
}