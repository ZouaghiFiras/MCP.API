namespace CED.Data.Entities
{
    public class DamageReasonType
    {
        public Guid DrtId { get; set; }

        public byte[] DrtTimeStamp { get; set; } = null!;

        public string DrtName { get; set; } = null!;

        public short DrtGroup { get; set; }

        public bool DrtInactive { get; set; }

        public Guid? DrtLocalizableEntryId { get; set; }

        public DateTime DrtCreatedDate { get; set; }

        public string? DrtCreatedBy { get; set; }

        public DateTime DrtLastModifiedDate { get; set; }

        public string? DrtLastModifiedBy { get; set; }

        public virtual LocalizableEntry? DrtLocalizableEntry { get; set; }
    }
}