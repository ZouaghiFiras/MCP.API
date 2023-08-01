namespace CED.Data.Entities
{
    public class Partner1
    {
        public Guid ParId { get; set; }

        public byte[] ParTimeStamp { get; set; } = null!;

        public string? ParExternalCode { get; set; }

        public string? ParCultureCodePreferredLanguage { get; set; }

        public bool? ParInactive { get; set; }

        public DateTime ParCreatedDate { get; set; }

        public string? ParCreatedBy { get; set; }

        public DateTime ParLastModifiedDate { get; set; }

        public string? ParLastModifiedBy { get; set; }
    }
}