namespace CED.Data.Entities
{
    public class DossierAssignmentCorrectionAuthorization
    {
        public Guid DacuId { get; set; }

        public byte[] DacuTimeStamp { get; set; } = null!;

        public Guid DacuDossierAssignmentId { get; set; }

        public string DacuRequiredAutorizationRoleId { get; set; } = null!;

        public DateTime DacuCreatedDate { get; set; }

        public string? DacuCreatedBy { get; set; }

        public DateTime DacuLastModifiedDate { get; set; }

        public string? DacuLastModifiedBy { get; set; }

        public virtual DossierAssignment DacuDossierAssignment { get; set; } = null!;

        public virtual AuthorizationRole DacuRequiredAutorizationRole { get; set; } = null!;

        public virtual ICollection<DossierAssignmentCorrectionApproval> DossierAssignmentCorrectionApprovals { get; } =
            new List<DossierAssignmentCorrectionApproval>();
    }
}