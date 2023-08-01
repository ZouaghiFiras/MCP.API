namespace CED.Data.Entities
{
    public class CommunicationType
    {
        public Guid CmtId { get; set; }

        public byte[] CmtTimeStamp { get; set; } = null!;

        public string CmtName { get; set; } = null!;

        public bool CmtInactive { get; set; }

        public Guid? CmtLocalizableEntryId { get; set; }

        public DateTime CmtCreatedDate { get; set; }

        public string? CmtCreatedBy { get; set; }

        public DateTime CmtLastModifiedDate { get; set; }

        public string? CmtLastModifiedBy { get; set; }

        public virtual LocalizableEntry? CmtLocalizableEntry { get; set; }

        public virtual ICollection<Post> Posts { get; } = new List<Post>();
    }
}