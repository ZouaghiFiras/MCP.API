namespace CED.Data.Entities
{
    public class LocalizableType1
    {
        public Guid LltId { get; set; }

        public byte[] LltTimeStamp { get; set; } = null!;

        public string LltCode { get; set; } = null!;

        public string? LltShortName { get; set; }

        public string LltLongName { get; set; } = null!;

        public bool LltInactive { get; set; }

        public DateTime LltCreatedDate { get; set; }

        public string? LltCreatedBy { get; set; }

        public DateTime LltLastModifiedDate { get; set; }

        public string? LltLastModifiedBy { get; set; }
    }
}