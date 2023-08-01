namespace CED.Data.Entities
{
    public class Mandate1
    {
        public Guid MdId { get; set; }

        public byte[] MdTimeStamp { get; set; } = null!;

        public string? MdCultureCodePreferredLanguage { get; set; }

        public bool? MdInactive { get; set; }

        public DateTime MdCreatedDate { get; set; }

        public string? MdCreatedBy { get; set; }

        public DateTime MdLastModifiedDate { get; set; }

        public string? MdLastModifiedBy { get; set; }
    }
}