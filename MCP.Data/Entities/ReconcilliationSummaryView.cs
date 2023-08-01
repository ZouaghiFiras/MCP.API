namespace CED.Data.Entities
{
    public class ReconcilliationSummaryView
    {
        public Guid Id { get; set; }

        public string LedgerAccount { get; set; } = null!;

        public string? LedgerDescription { get; set; }

        public decimal TotalReconcilliationValue { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}