namespace CED.Data.Entities
{
    public class DebtorOrganizationSummaryStatement
    {
        public Guid DorssId { get; set; }

        public byte[] DorssTimeStamp { get; set; } = null!;

        public Guid DorssDebtorOrganizationRelationId { get; set; }

        public Guid? DorssProductId { get; set; }

        public bool DorssInactive { get; set; }

        public DateTime DorssCreatedDate { get; set; }

        public string? DorssCreatedBy { get; set; }

        public DateTime DorssLastModifiedDate { get; set; }

        public string? DorssLastModifiedBy { get; set; }

        public virtual DebtorOrganizationRelation DorssDebtorOrganizationRelation { get; set; } = null!;

        public virtual Product? DorssProduct { get; set; }
    }
}