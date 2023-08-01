namespace CED.Data.Entities
{
    public class InsurancePoliciesCorrectionAuthorization
    {
        public Guid IpcaId { get; set; }

        public byte[] IpcaTimeStamp { get; set; } = null!;

        public Guid IpcaInsurancePolicyId { get; set; }

        public string IpcaRequiredAutorizationRoleId { get; set; } = null!;

        public DateTime IpcaCreatedDate { get; set; }

        public string? IpcaCreatedBy { get; set; }

        public DateTime IpcaLastModifiedDate { get; set; }

        public string? IpcaLastModifiedBy { get; set; }

        public virtual ICollection<InsurancePoliciesCorrectionApproval> InsurancePoliciesCorrectionApprovals { get; } =
            new List<InsurancePoliciesCorrectionApproval>();

        public virtual InsurancePolicy IpcaInsurancePolicy { get; set; } = null!;

        public virtual AuthorizationRole IpcaRequiredAutorizationRole { get; set; } = null!;
    }
}