namespace CED.Data.Entities
{
    public class ObjectClassification
    {
        public string OclId { get; set; } = null!;

        public byte[] OclTimeStamp { get; set; } = null!;

        public string OclName { get; set; } = null!;

        public bool OclInactive { get; set; }

        public Guid? OclLocalizableEntryId { get; set; }

        public DateTime OclCreatedDate { get; set; }

        public string? OclCreatedBy { get; set; }

        public DateTime OclLastModifiedDate { get; set; }

        public string? OclLastModifiedBy { get; set; }

        public virtual ICollection<InsuranceObject> InsuranceObjects { get; } = new List<InsuranceObject>();

        public virtual LocalizableEntry? OclLocalizableEntry { get; set; }
    }
}