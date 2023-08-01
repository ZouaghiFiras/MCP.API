namespace CED.Data.Entities
{
    public class DebtorOrganizationRelationsView
    {
        public Guid Id { get; set; }

        public Guid OrganizationUnitId { get; set; }

        public Guid? ProductId { get; set; }

        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }

        public Guid DebtorId { get; set; }

        public string DebtorNumber { get; set; } = null!;

        public string DebtorName { get; set; } = null!;

        public string? DebtorPhone { get; set; }

        public string? DebtorVatNumber { get; set; }

        public string? DebtorChamberOfCommerceNumber { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid? ClientMandateId { get; set; }

        public DateTime EffectiveDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public bool Inactive { get; set; }
    }
}