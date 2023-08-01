namespace CED.Data.Entities
{
    public class InsurancePoliciesCorrectionApproval
    {
        public Guid IpapId { get; set; }

        public byte[] IpapTimeStamp { get; set; } = null!;

        public Guid IpapInsurancePolicyAuthorizationId { get; set; }

        public DateTime IpapApprovalDate { get; set; }

        public bool IpapIsApproved { get; set; }

        public string? IpapComment { get; set; }

        public Guid IpapEmployeeId { get; set; }

        public string IpapAutorizationRoleId { get; set; } = null!;

        public DateTime IpapCreatedDate { get; set; }

        public string? IpapCreatedBy { get; set; }

        public DateTime IpapLastModifiedDate { get; set; }

        public string? IpapLastModifiedBy { get; set; }

        public virtual AuthorizationRole IpapAutorizationRole { get; set; } = null!;

        public virtual Employee IpapEmployee { get; set; } = null!;

        public virtual InsurancePoliciesCorrectionAuthorization IpapInsurancePolicyAuthorization { get; set; } = null!;
    }
}