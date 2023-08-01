namespace CED.Data.Entities
{
    public class DossierLogHistory
    {
        public Guid DhlId { get; set; }

        public byte[] DhlTimeStamp { get; set; } = null!;

        public Guid DhlDossierId { get; set; }

        public int DhlLineNumber { get; set; }

        public Guid? DhlRoleCodeId { get; set; }

        public Guid? DhlLogHistoryTypeId { get; set; }

        public string? DhlFreeText { get; set; }

        public DateTime DhlCreatedDate { get; set; }

        public string? DhlCreatedBy { get; set; }

        public DateTime DhlLastModifiedDate { get; set; }

        public string? DhlLastModifiedBy { get; set; }

        public virtual Dossier DhlDossier { get; set; } = null!;

        public virtual LogHistoryType? DhlLogHistoryType { get; set; }

        public virtual RoleCode? DhlRoleCode { get; set; }
    }
}