namespace CED.Data.Entities
{
    public class CreditorStatus
    {
        public Guid CdsId { get; set; }

        public byte[] CdsTimeStamp { get; set; } = null!;

        public string CdsCode { get; set; } = null!;

        public string? CdsShortName { get; set; }

        public string CdsLongName { get; set; } = null!;

        public bool CdsInactive { get; set; }

        public Guid? CdsLocalizableEntryId { get; set; }

        public DateTime CdsCreatedDate { get; set; }

        public string? CdsCreatedBy { get; set; }

        public DateTime CdsLastModifiedDate { get; set; }

        public string? CdsLastModifiedBy { get; set; }

        public virtual LocalizableEntry? CdsLocalizableEntry { get; set; }

        public virtual ICollection<CreditorStatusHistory> CreditorStatusHistories { get; } =
            new List<CreditorStatusHistory>();
    }
}