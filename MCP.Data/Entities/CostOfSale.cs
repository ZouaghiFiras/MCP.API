namespace CED.Data.Entities
{
    public class CostOfSale
    {
        public Guid CosId { get; set; }

        public byte[] CosTimeStamp { get; set; } = null!;

        public string CosNumber { get; set; } = null!;

        public DateTime CosDocumentDate { get; set; }

        public string? CosEntryNumber { get; set; }

        public string? CosEntrySystem { get; set; }

        public string? CosEntryBatch { get; set; }

        public decimal CosNetAmount { get; set; }

        public bool CosIsImported { get; set; }

        public Guid CosLegalEntityId { get; set; }

        public bool CosIsCredit { get; set; }

        public string? CosDebitEntryNumber { get; set; }

        public Guid? CosTenantId { get; set; }

        public Guid? CosDebitCostOfSaleId { get; set; }

        public string? CosJournalId { get; set; }

        public Guid? CosFinancialBookingPeriodId { get; set; }

        public DateTime CosCreatedDate { get; set; }

        public string? CosCreatedBy { get; set; }

        public DateTime CosLastModifiedDate { get; set; }

        public string? CosLastModifiedBy { get; set; }

        public virtual CostOfSale? CosDebitCostOfSale { get; set; }

        public virtual FinancialBookingPeriod? CosFinancialBookingPeriod { get; set; }

        public virtual Journal? CosJournal { get; set; }

        public virtual LegalEntity CosLegalEntity { get; set; } = null!;

        public virtual Tenant? CosTenant { get; set; }

        public virtual ICollection<CostOfSalesLine> CostOfSalesLines { get; } = new List<CostOfSalesLine>();

        public virtual ICollection<CostOfSale> InverseCosDebitCostOfSale { get; } = new List<CostOfSale>();
    }
}