namespace CED.Data.Entities
{
    public class ClientMandate
    {
        public Guid CmId { get; set; }

        public byte[] CmTimeStamp { get; set; } = null!;

        public string CmCode { get; set; } = null!;

        public string CmLongName { get; set; } = null!;

        public Guid CmClientId { get; set; }

        public Guid CmMandateId { get; set; }

        public bool CmInactive { get; set; }

        public DateTime CmCreatedDate { get; set; }

        public string? CmCreatedBy { get; set; }

        public DateTime CmLastModifiedDate { get; set; }

        public string? CmLastModifiedBy { get; set; }

        public virtual ICollection<ClientMandateContractRelation> ClientMandateContractRelations { get; } =
            new List<ClientMandateContractRelation>();

        public virtual Client CmClient { get; set; } = null!;

        public virtual Mandate CmMandate { get; set; } = null!;

        public virtual ICollection<DebtorOrganizationRelation> DebtorOrganizationRelations { get; } =
            new List<DebtorOrganizationRelation>();
    }
}