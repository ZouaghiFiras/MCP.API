namespace CED.Data.Entities
{
    public class DossierStatus
    {
        public Guid DstId { get; set; }

        public byte[] DstTimeStamp { get; set; } = null!;

        public string DstCode { get; set; } = null!;

        public string? DstShortName { get; set; }

        public string DstLongName { get; set; } = null!;

        public bool DstInactive { get; set; }

        public string? DstDossierStatusTypeId { get; set; }

        public Guid? DstLocalizableEntryId { get; set; }

        public DateTime DstCreatedDate { get; set; }

        public string? DstCreatedBy { get; set; }

        public DateTime DstLastModifiedDate { get; set; }

        public string? DstLastModifiedBy { get; set; }

        public virtual ICollection<DossierStatusApplication> DossierStatusApplications { get; } =
            new List<DossierStatusApplication>();

        public virtual ICollection<DossierStatusHistory> DossierStatusHistories { get; } =
            new List<DossierStatusHistory>();

        public virtual DossierStatusType? DstDossierStatusType { get; set; }

        public virtual LocalizableEntry? DstLocalizableEntry { get; set; }
    }
}