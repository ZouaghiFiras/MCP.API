namespace CED.Data.Entities
{
    public class RoleCode1
    {
        public Guid RcId { get; set; }

        public byte[] RcTimeStamp { get; set; } = null!;

        public string RcCode { get; set; } = null!;

        public string? RcShortName { get; set; }

        public string RcLongName { get; set; } = null!;

        public bool RcInactive { get; set; }

        public Guid? RcLocalizableEntryId { get; set; }

        public string? RcCreatedBy { get; set; }

        public DateTime RcCreatedDate { get; set; }

        public string? RcLastModifiedBy { get; set; }

        public DateTime RcLastModifiedDate { get; set; }

        public virtual LocalizableEntry? RcLocalizableEntry { get; set; }
    }
}