namespace CED.Data.Entities
{
    public class DossierOperationalStatus
    {
        public Guid OpsId { get; set; }

        public byte[] OpsTimeStamp { get; set; } = null!;

        public string OpsCode { get; set; } = null!;

        public string? OpsShortName { get; set; }

        public string OpsLongName { get; set; } = null!;

        public bool OpsInactive { get; set; }

        public string? OpsDossierOperationalStatusTypeId { get; set; }

        public Guid? OpsLocalizableEntryId { get; set; }

        public DateTime OpsCreatedDate { get; set; }

        public string? OpsCreatedBy { get; set; }

        public DateTime OpsLastModifiedDate { get; set; }

        public string? OpsLastModifiedBy { get; set; }

        public virtual ICollection<DossierOperationalStatusHistory> DossierOperationalStatusHistories { get; } =
            new List<DossierOperationalStatusHistory>();

        public virtual DossierOperationalStatusType? OpsDossierOperationalStatusType { get; set; }

        public virtual LocalizableEntry? OpsLocalizableEntry { get; set; }
    }
}