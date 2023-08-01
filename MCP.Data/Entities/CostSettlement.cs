namespace CED.Data.Entities
{
    public class CostSettlement
    {
        public Guid CstId { get; set; }

        public byte[] CstTimeStamp { get; set; } = null!;

        public string CstSettlementName { get; set; } = null!;

        public Guid? CstLegalEntityId { get; set; }

        public Guid? CstSupplierId { get; set; }

        public string? CstContractNumber { get; set; }

        public string? CstDiscountCode { get; set; }

        public string? CstEntrySystem { get; set; }

        public DateTime CstCreatedDate { get; set; }

        public string? CstCreatedBy { get; set; }

        public DateTime CstLastModifiedDate { get; set; }

        public string? CstLastModifiedBy { get; set; }

        public virtual ICollection<CostSettlementLine> CostSettlementLines { get; } = new List<CostSettlementLine>();

        public virtual LegalEntity? CstLegalEntity { get; set; }

        public virtual Supplier? CstSupplier { get; set; }
    }
}