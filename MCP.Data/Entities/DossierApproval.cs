namespace CED.Data.Entities
{
    public class DossierApproval
    {
        public Guid DapId { get; set; }

        public byte[] DapTimeStamp { get; set; } = null!;

        public Guid DapDossierAuthorizationId { get; set; }

        public DateTime DapApprovalDate { get; set; }

        public bool DapIsApproved { get; set; }

        public string? DapComment { get; set; }

        public Guid DapEmployeeId { get; set; }

        public string DapAutorizationRoleId { get; set; } = null!;

        public DateTime DapCreatedDate { get; set; }

        public string? DapCreatedBy { get; set; }

        public DateTime DapLastModifiedDate { get; set; }

        public string? DapLastModifiedBy { get; set; }

        public virtual AuthorizationRole DapAutorizationRole { get; set; } = null!;

        public virtual DossierAuthorization DapDossierAuthorization { get; set; } = null!;

        public virtual Employee DapEmployee { get; set; } = null!;
    }
}