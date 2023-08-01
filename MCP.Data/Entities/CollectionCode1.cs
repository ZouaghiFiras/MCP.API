namespace CED.Data.Entities
{
    public class CollectionCode1
    {
        public Guid CcId { get; set; }

        public byte[] CcTimeStamp { get; set; } = null!;

        public string CcCode { get; set; } = null!;

        public string? CcShortName { get; set; }

        public string CcLongName { get; set; } = null!;

        public bool CcInactive { get; set; }

        public Guid? CcLocalizableEntryId { get; set; }

        public DateTime CcCreatedDate { get; set; }

        public string? CcCreatedBy { get; set; }

        public DateTime CcLastModifiedDate { get; set; }

        public string? CcLastModifiedBy { get; set; }
    }
}