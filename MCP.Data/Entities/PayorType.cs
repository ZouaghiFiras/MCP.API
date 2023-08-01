namespace CED.Data.Entities
{
    public class PayorType
    {
        public string PotId { get; set; } = null!;

        public byte[] PotTimeStamp { get; set; } = null!;

        public string PotDescription { get; set; } = null!;

        public bool PotInactive { get; set; }

        public Guid? PotLocalizableEntryId { get; set; }

        public DateTime PotCreatedDate { get; set; }

        public string? PotCreatedBy { get; set; }

        public DateTime PotLastModifiedDate { get; set; }

        public string? PotLastModifiedBy { get; set; }

        public virtual LocalizableEntry? PotLocalizableEntry { get; set; }
    }
}