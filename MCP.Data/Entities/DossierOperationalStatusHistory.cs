namespace CED.Data.Entities
{
    public class DossierOperationalStatusHistory
    {
        public Guid OshId { get; set; }

        public byte[] OshTimeStamp { get; set; } = null!;

        public Guid OshDossierId { get; set; }

        public Guid OshDossierOperationalStatusId { get; set; }

        public Guid OshEmployeeId { get; set; }

        public DateTime OshStartDate { get; set; }

        public string? OshStatusChangeReason { get; set; }

        public DateTime OshCreatedDate { get; set; }

        public string? OshCreatedBy { get; set; }

        public DateTime OshLastModifiedDate { get; set; }

        public string? OshLastModifiedBy { get; set; }

        public virtual Dossier OshDossier { get; set; } = null!;

        public virtual DossierOperationalStatus OshDossierOperationalStatus { get; set; } = null!;
    }
}