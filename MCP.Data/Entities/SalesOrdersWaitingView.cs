namespace CED.Data.Entities
{
    public class SalesOrdersWaitingView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string Number { get; set; } = null!;

        public DateTime OrderDate { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryBatch { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal TaxExemptedAmount { get; set; }

        public decimal TaxResversedChargeAmount { get; set; }

        public decimal TaxImportAmount { get; set; }

        public decimal NetAmount { get; set; }

        public decimal Discount { get; set; }

        public DateTime? DueDate { get; set; }

        public string? CurrencyCode { get; set; }

        public double? ExchangeRate { get; set; }

        public bool IsPrinted { get; set; }

        public bool IsImported { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid ClientId { get; set; }

        public string ClientNumber { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public bool IsIntercompany { get; set; }

        public bool IsVoided { get; set; }

        public string? PaymentReference { get; set; }

        public string? LeadCurrencyCode { get; set; }

        public bool IsCredit { get; set; }

        public string? DebitEntryNumber { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public string? AssignmentNumber { get; set; }

        public Guid? DossierPartyId { get; set; }

        public string? DossierPartyName { get; set; }

        public string? SalesOrderStatusCode { get; set; }

        public string? SalesOrderStatusName { get; set; }

        public DateTime? SalesOrderStatusDate { get; set; }

        public Guid? DebtorId { get; set; }

        public string? DebtorNumber { get; set; }

        public string? DebtorName { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}