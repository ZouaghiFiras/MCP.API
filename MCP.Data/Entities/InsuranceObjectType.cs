namespace CED.Data.Entities
{
    public class InsuranceObjectType
    {
        public Guid IotId { get; set; }

        public byte[] IotTimeStamp { get; set; } = null!;

        public string IotCode { get; set; } = null!;

        public string? IotShortName { get; set; }

        public string IotLongName { get; set; } = null!;

        public bool IotInactive { get; set; }

        public Guid? IotLocalizableEntryId { get; set; }

        public DateTime IotCreatedDate { get; set; }

        public string? IotCreatedBy { get; set; }

        public DateTime IotLastModifiedDate { get; set; }

        public string? IotLastModifiedBy { get; set; }

        public virtual ICollection<InsuranceObject> InsuranceObjects { get; } = new List<InsuranceObject>();

        public virtual LocalizableEntry? IotLocalizableEntry { get; set; }
    }
}