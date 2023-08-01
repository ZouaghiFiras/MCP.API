namespace CED.Data.Entities
{
    public class Origin
    {
        public Guid OrId { get; set; }

        public byte[] OrTimeStamp { get; set; } = null!;

        public string OrCode { get; set; } = null!;

        public string? OrShortName { get; set; }

        public string OrLongName { get; set; } = null!;

        public bool OrInactive { get; set; }

        public DateTime OrCreatedDate { get; set; }

        public string? OrCreatedBy { get; set; }

        public DateTime OrLastModifiedDate { get; set; }

        public string? OrLastModifiedBy { get; set; }
    }
}