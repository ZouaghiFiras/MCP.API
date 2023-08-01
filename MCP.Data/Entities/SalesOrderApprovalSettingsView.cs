namespace CED.Data.Entities
{
    public class SalesOrderApprovalSettingsView
    {
        public Guid Id { get; set; }

        public bool ApprovedBySystem { get; set; }

        public Guid? ClientId { get; set; }

        public DateTime EffectiveDate { get; set; }

        public string EntrySystem { get; set; } = null!;

        public Guid LegalEntityId { get; set; }

        public DateTime? TerminationDate { get; set; }

        public Guid? ApplicationId { get; set; }

        public string? ApplicationName { get; set; }

        public Guid? DebtorId { get; set; }

        public string? DebtorNumber { get; set; }

        public string? DebtorName { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}