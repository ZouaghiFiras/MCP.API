namespace CED.Data.Entities
{
    public class DossierAssignmentStatusHistory
    {
        public Guid AshId { get; set; }

        public byte[] AshTimeStamp { get; set; } = null!;

        public Guid AshDossierAssignmentId { get; set; }

        public Guid AshDossierAssignmentStatusId { get; set; }

        public Guid AshEmployeeId { get; set; }

        public DateTime AshStartDate { get; set; }

        public DateTime AshCreatedDate { get; set; }

        public string? AshCreatedBy { get; set; }

        public DateTime AshLastModifiedDate { get; set; }

        public string? AshLastModifiedBy { get; set; }

        public string? AshReason { get; set; }

        public virtual DossierAssignment AshDossierAssignment { get; set; } = null!;

        public virtual DossierAssignmentStatus AshDossierAssignmentStatus { get; set; } = null!;

        public virtual ICollection<DossierAssignmentCurrentStatus> DossierAssignmentCurrentStatuses { get; } =
            new List<DossierAssignmentCurrentStatus>();

        //public static implicit operator DossierAssignmentStatusHistory(DossierAssignmentStatusHistory v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}