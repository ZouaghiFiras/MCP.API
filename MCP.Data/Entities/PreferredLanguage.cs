namespace CED.Data.Entities
{
    public class PreferredLanguage
    {
        public string PlId { get; set; } = null!;

        public byte[] PlTimeStamp { get; set; } = null!;

        public string PlName { get; set; } = null!;

        public bool PlInactive { get; set; }

        public DateTime PlCreatedDate { get; set; }

        public string? PlCreatedBy { get; set; }

        public DateTime PlLastModifiedDate { get; set; }

        public string? PlLastModifiedBy { get; set; }
    }
}