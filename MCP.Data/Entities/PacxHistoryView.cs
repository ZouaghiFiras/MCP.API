namespace CED.Data.Entities
{
    public class PacxHistoryView
    {
        public Guid Id { get; set; }

        public string PacxCode { get; set; } = null!;

        public DateTime? ValidFromDate { get; set; }

        public DateTime? ValidUntilDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}