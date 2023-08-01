namespace CED.Data.Entities
{
    public class SalesCollectionLinesView
    {
        public Guid Id { get; set; }

        public int LineNumber { get; set; }

        public string CollectionNumber { get; set; } = null!;

        public DateTime CollectionDate { get; set; }

        public DateTime? CollectionDueDate { get; set; }

        public Guid SalesCollectionId { get; set; }

        public Guid RecipientDebtorId { get; set; }

        public string RecipientDebtorNumber { get; set; } = null!;

        public string RecipientDebtorName { get; set; } = null!;

        public string? RecipientEmail { get; set; }

        public Guid InvoiceId { get; set; }

        public string InvoiceNumber { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public DateTime? InvoiceDueDate { get; set; }

        public bool IsCredit { get; set; }

        public decimal NetAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal GrossAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public string? LeadCurrencyCode { get; set; }

        public string? Journal { get; set; }

        public string? EntrySystem { get; set; }

        public Guid DebtorId { get; set; }

        public string DebtorName { get; set; } = null!;

        public string? DebtorVatNumber { get; set; }

        public string? DebtorChamberOfCommerceNumber { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public bool IsRemoved { get; set; }

        public DateTime? RemovalDate { get; set; }

        public string? DossierNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}