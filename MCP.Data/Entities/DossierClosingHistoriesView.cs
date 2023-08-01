namespace CED.Data.Entities
{
    public class DossierClosingHistoriesView
    {
        public Guid Id { get; set; }

        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public string? EntrySystem { get; set; }

        public bool Cancelled { get; set; }

        public DateTime ClosingDate { get; set; }

        public string? ClosingReason { get; set; }

        public bool FinancialClosing { get; set; }

        public bool OperationalClosing { get; set; }

        public string? DossierStatusCode { get; set; }

        public string? DossierStatusName { get; set; }

        public string? DossierStatusType { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}