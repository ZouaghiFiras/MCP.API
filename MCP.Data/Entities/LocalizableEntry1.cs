namespace CED.Data.Entities
{
    public class LocalizableEntry1
    {
        public Guid LleId { get; set; }

        public byte[] LleTimeStamp { get; set; } = null!;

        public Guid LleLocalizableTypeId { get; set; }

        public DateTime LleCreatedDate { get; set; }

        public string? LleCreatedBy { get; set; }

        public DateTime LleLastModifiedDate { get; set; }

        public string? LleLastModifiedBy { get; set; }
    }
}