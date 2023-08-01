namespace CED.Data.Entities
{
    public class FailedExactExportCreditorsView
    {
        public Guid Id { get; set; }

        public string CreditorNumber { get; set; } = null!;

        public string CreditorName { get; set; } = null!;

        public string? CreditorName2 { get; set; }

        public string? CreditorName3 { get; set; }

        public string? ExactAdministration { get; set; }

        public DateTime? ExactExportDate { get; set; }

        public string? StatusCode { get; set; }

        public string? StatusName { get; set; }

        public DateTime? StatusDate { get; set; }

        public string? StatusChangeReason { get; set; }

        public string? DossierNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? EntrySystem { get; set; }
    }
}