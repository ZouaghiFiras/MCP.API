namespace CED.Data.Entities
{
    public class CostOfSalesLine
    {
        public Guid CslId { get; set; }

        public byte[] CslTimeStamp { get; set; } = null!;

        public Guid CslCostOfSalesId { get; set; }

        public bool CslIsImported { get; set; }

        public int CslLineNumber { get; set; }

        public Guid CslPurchaseInvoiceLineId { get; set; }

        public decimal CslNetAmount { get; set; }

        public string? CslReason { get; set; }

        public DateTime CslCreatedDate { get; set; }

        public string? CslCreatedBy { get; set; }

        public DateTime CslLastModifiedDate { get; set; }

        public string? CslLastModifiedBy { get; set; }

        public virtual ICollection<CostOfSalesJournalEntryLine> CostOfSalesJournalEntryLines { get; } =
            new List<CostOfSalesJournalEntryLine>();

        public virtual CostOfSale CslCostOfSales { get; set; } = null!;

        public virtual PurchaseInvoiceLine CslPurchaseInvoiceLine { get; set; } = null!;
    }
}