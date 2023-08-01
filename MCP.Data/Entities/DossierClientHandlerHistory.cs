namespace CED.Data.Entities
{
    public class DossierClientHandlerHistory
    {
        public Guid DchId { get; set; }

        public byte[] DchTimeStamp { get; set; } = null!;

        public Guid DchDossierId { get; set; }

        public string DchClientHandlerName { get; set; } = null!;

        public string? DchClientHandlerPhone { get; set; }

        public string? DchClientHandlerEmail { get; set; }

        public DateTime DchStartDate { get; set; }

        public DateTime DchCreatedDate { get; set; }

        public string? DchCreatedBy { get; set; }

        public DateTime DchLastModifiedDate { get; set; }

        public string? DchLastModifiedBy { get; set; }

        public virtual Dossier DchDossier { get; set; } = null!;
    }
}