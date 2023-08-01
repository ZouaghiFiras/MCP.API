namespace CED.Data.Entities
{
    public class DossierAssignmentLogHistory
    {
        public Guid DalhId { get; set; }

        public byte[] DalhTimeStamp { get; set; } = null!;

        public Guid DalhDossierAssignmentId { get; set; }

        public Guid? DalhLogHistoryTypeId { get; set; }

        public string? DalhFreeText { get; set; }

        public DateTime DalhCreatedDate { get; set; }

        public string? DalhCreatedBy { get; set; }

        public DateTime DalhLastModifiedDate { get; set; }

        public string? DalhLastModifiedBy { get; set; }

        public Guid? DalhRoleCodeId { get; set; }

        public int DalhLineNumber { get; set; }

        public virtual DossierAssignment DalhDossierAssignment { get; set; } = null!;

        public virtual LogHistoryType? DalhLogHistoryType { get; set; }

        public virtual RoleCode? DalhRoleCode { get; set; }
    }
}