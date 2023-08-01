namespace CED.Data.Entities
{
    public class FraudDetectionLog
    {
        public Guid FdlId { get; set; }

        public byte[] FdlTimeStamp { get; set; } = null!;

        public string FdlLogMessage { get; set; } = null!;

        public DateTime FdlCreatedDate { get; set; }

        public string? FdlCreatedBy { get; set; }

        public DateTime FdlLastModifiedDate { get; set; }

        public string? FdlLastModifiedBy { get; set; }

        public Guid? FdlDossierId { get; set; }

        public virtual Dossier? FdlDossier { get; set; }
    }
}