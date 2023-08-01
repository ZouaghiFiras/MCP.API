namespace CED.Data.Entities
{
    public class EdiStatus
    {
        public Guid EdiId { get; set; }

        public byte[] EdiTimeStamp { get; set; } = null!;

        public string EdiCode { get; set; } = null!;

        public string? EdiShortName { get; set; }

        public string EdiLongName { get; set; } = null!;

        public bool EdiInactive { get; set; }

        public DateTime EdiCreatedDate { get; set; }

        public string? EdiCreatedBy { get; set; }

        public DateTime EdiLastModifiedDate { get; set; }

        public string? EdiLastModifiedBy { get; set; }
    }
}