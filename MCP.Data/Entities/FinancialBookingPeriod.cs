namespace CED.Data.Entities
{
    public class FinancialBookingPeriod
    {
        public Guid FbpId { get; set; }

        public byte[] FbpTimeStamp { get; set; } = null!;

        public Guid FbpLegalEntityId { get; set; }

        public string FbpFinancialYear { get; set; } = null!;

        public string FbpFinancialPeriod { get; set; } = null!;

        public DateTime FbpDateFrom { get; set; }

        public DateTime FbpDateUntil { get; set; }

        public bool FbpIsClosed { get; set; }

        public DateTime FbpCreatedDate { get; set; }

        public string? FbpCreatedBy { get; set; }

        public DateTime FbpLastModifiedDate { get; set; }

        public string? FbpLastModifiedBy { get; set; }

        public virtual ICollection<CostOfSale> CostOfSales { get; } = new List<CostOfSale>();

        public virtual LegalEntity FbpLegalEntity { get; set; } = null!;

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();
    }
}