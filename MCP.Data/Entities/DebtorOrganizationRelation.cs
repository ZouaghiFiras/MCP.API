namespace CED.Data.Entities
{
    public class DebtorOrganizationRelation
    {
        public Guid DorId { get; set; }

        public byte[] DorTimeStamp { get; set; } = null!;

        public Guid DorDebtorId { get; set; }

        public Guid DorOrganizationUnitId { get; set; }

        public Guid? DorClientMandateId { get; set; }

        public Guid? DorProductId { get; set; }

        public DateTime DorEffectiveDate { get; set; }

        public DateTime DorCreatedDate { get; set; }

        public string? DorCreatedBy { get; set; }

        public DateTime DorLastModifiedDate { get; set; }

        public string? DorLastModifiedBy { get; set; }

        public string? DorSummaryEmail { get; set; }

        public bool DorInactive { get; set; }

        public virtual ICollection<DebtorOrganizationSummaryStatement> DebtorOrganizationSummaryStatements { get; } =
            new List<DebtorOrganizationSummaryStatement>();

        public virtual ClientMandate? DorClientMandate { get; set; }

        public virtual Debtor DorDebtor { get; set; } = null!;

        public virtual OrganizationUnit DorOrganizationUnit { get; set; } = null!;

        public virtual Product? DorProduct { get; set; }
    }
}