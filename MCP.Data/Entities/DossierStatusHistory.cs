namespace CED.Data.Entities
{
    public class DossierStatusHistory
    {
        public Guid DshId { get; set; }

        public byte[] DshTimeStamp { get; set; } = null!;

        public Guid DshDossierId { get; set; }

        public Guid DshDossierStatusId { get; set; }

        public Guid DshEmployeeId { get; set; }

        public DateTime DshStartDate { get; set; }

        public string? DshStatusChangeReason { get; set; }

        public DateTime DshCreatedDate { get; set; }

        public string? DshCreatedBy { get; set; }

        public DateTime DshLastModifiedDate { get; set; }

        public string? DshLastModifiedBy { get; set; }

        public virtual Dossier DshDossier { get; set; } = null!;

        public virtual DossierStatus DshDossierStatus { get; set; } = null!;
    }
}