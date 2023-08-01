namespace CED.Data.Entities
{
    public class DossierAssignmentClosingHistory
    {
        public Guid AchId { get; set; }

        public byte[] AchTimeStamp { get; set; } = null!;

        public Guid AchDossierAssignmentId { get; set; }

        public DateTime AchClosingDate { get; set; }

        public bool? AchOperationalClosing { get; set; }

        public bool AchFinancialClosing { get; set; }

        public DateTime AchCreatedDate { get; set; }

        public string? AchCreatedBy { get; set; }

        public DateTime AchLastModifiedDate { get; set; }

        public string? AchLastModifiedBy { get; set; }

        public virtual DossierAssignment AchDossierAssignment { get; set; } = null!;
    }
}