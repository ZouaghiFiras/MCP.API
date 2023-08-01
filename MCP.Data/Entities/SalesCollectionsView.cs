namespace CED.Data.Entities
{
    public class SalesCollectionsView
    {
        public Guid Id { get; set; }

        public string CollectionNumber { get; set; } = null!;

        public DateTime CollectionDate { get; set; }

        public Guid RecipientDebtorId { get; set; }

        public string RecipientDebtorNumber { get; set; } = null!;

        public string RecipientDebtorName { get; set; } = null!;

        public string? RecipientEmail { get; set; }

        public decimal? NetAmount { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? GrossAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}