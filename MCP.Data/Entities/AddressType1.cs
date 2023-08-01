namespace CED.Data.Entities
{
    public class AddressType1
    {
        public Guid AdtId { get; set; }

        public byte[] AdtTimeStamp { get; set; } = null!;

        public string AdtCode { get; set; } = null!;

        public string? AdtShortName { get; set; }

        public string AdtLongName { get; set; } = null!;

        public bool AdtInactive { get; set; }

        public Guid? AdtLocalizableEntryId { get; set; }

        public DateTime AdtCreatedDate { get; set; }

        public string? AdtCreatedBy { get; set; }

        public DateTime AdtLastModifiedDate { get; set; }

        public string? AdtLastModifiedBy { get; set; }
    }
}