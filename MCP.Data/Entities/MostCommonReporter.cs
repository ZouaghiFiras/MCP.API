namespace CED.Data.Entities
{
    public class MostCommonReporter
    {
        public short McrId { get; set; }

        public byte[] McrTimeStamp { get; set; } = null!;

        public Guid McrReporterId { get; set; }

        public string? McrLogoUrl { get; set; }

        public int McrPosition { get; set; }

        public DateTime McrCreatedDate { get; set; }

        public string? McrCreatedBy { get; set; }

        public DateTime McrLastModifiedDate { get; set; }

        public string? McrLastModifiedBy { get; set; }
    }
}