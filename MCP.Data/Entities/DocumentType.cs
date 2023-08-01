namespace CED.Data.Entities
{
    public class DocumentType
    {
        public Guid DtId { get; set; }

        public byte[] DtTimeStamp { get; set; } = null!;

        public string DtCode { get; set; } = null!;

        public string? DtShortName { get; set; }

        public string DtLongName { get; set; } = null!;

        public bool DtInactive { get; set; }

        public Guid? DtLocalizableEntryId { get; set; }

        public DateTime DtCreatedDate { get; set; }

        public string? DtCreatedBy { get; set; }

        public DateTime DtLastModifiedDate { get; set; }

        public string? DtLastModifiedBy { get; set; }

        public virtual ICollection<DocumentTypeDepartment> DocumentTypeDepartments { get; } =
            new List<DocumentTypeDepartment>();

        public virtual ICollection<Document> Documents { get; } = new List<Document>();

        public virtual LocalizableEntry? DtLocalizableEntry { get; set; }
    }
}