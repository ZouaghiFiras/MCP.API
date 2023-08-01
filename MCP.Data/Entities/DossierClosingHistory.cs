namespace CED.Data.Entities
{
    public class DossierClosingHistory
    {
        public Guid DchId { get; set; }

        public byte[] DchTimeStamp { get; set; } = null!;

        public Guid DchDossierId { get; set; }

        public DateTime DchClosingDate { get; set; }

        public bool? DchOperationalClosing { get; set; }

        public bool DchFinancialClosing { get; set; }

        public bool DchCancelled { get; set; }

        public string? DchClosingReason { get; set; }

        public DateTime DchCreatedDate { get; set; }

        public string? DchCreatedBy { get; set; }

        public DateTime DchLastModifiedDate { get; set; }

        public string? DchLastModifiedBy { get; set; }

        public virtual Dossier DchDossier { get; set; } = null!;
    }
}