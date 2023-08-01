namespace CED.Data.Entities
{
    public class DocumentNumber
    {
        public Guid DonId { get; set; }

        public byte[] DonTimeStamp { get; set; } = null!;

        public string DonName { get; set; } = null!;

        public string? DonDescription { get; set; }

        public string DonNextNumberName { get; set; } = null!;

        public string? DonOutputFormat { get; set; }

        public DateTime DonStartDate { get; set; }

        public DateTime? DonEndDate { get; set; }

        public DateTime DonCreatedDate { get; set; }

        public string? DonCreatedBy { get; set; }

        public DateTime DonLastModifiedDate { get; set; }

        public string? DonLastModifiedBy { get; set; }
    }
}