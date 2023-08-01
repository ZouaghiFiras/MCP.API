namespace CED.Data.Entities
{
    public class DossierAssignmentCorrectionApproval
    {
        public Guid DacpId { get; set; }

        public byte[] DacpTimeStamp { get; set; } = null!;

        public Guid DacpDossierAssignmentCorrectionAuthorizationId { get; set; }

        public DateTime DacpApprovalDate { get; set; }

        public bool DacpIsApproved { get; set; }

        public string? DacpComment { get; set; }

        public Guid DacpEmployeeId { get; set; }

        public string DacpAutorizationRoleId { get; set; } = null!;

        public DateTime DacpCreatedDate { get; set; }

        public string? DacpCreatedBy { get; set; }

        public DateTime DacpLastModifiedDate { get; set; }

        public string? DacpLastModifiedBy { get; set; }

        public virtual AuthorizationRole DacpAutorizationRole { get; set; } = null!;

        public virtual DossierAssignmentCorrectionAuthorization DacpDossierAssignmentCorrectionAuthorization
        {
            get;
            set;
        } = null!;

        public virtual Employee DacpEmployee { get; set; } = null!;
    }
}