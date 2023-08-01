namespace CED.Data.Entities
{
    public class KeyPerformanceIndicatorTrigger
    {
        public Guid KpitId { get; set; }

        public byte[] KpitTimeStamp { get; set; } = null!;

        public Guid KpitKpiId { get; set; }

        public Guid KpitDossierId { get; set; }

        public Guid? KpitAssignmentId { get; set; }

        public Guid? KpitProductId { get; set; }

        public bool KpitKpiMet { get; set; }

        public short KpitRepetitionNumber { get; set; }

        public bool KpitInactive { get; set; }

        public DateTime? KpitKpistartTriggerDate { get; set; }

        public long? KpitActualTimeKpitook { get; set; }

        public DateTime KpitCreatedDate { get; set; }

        public string? KpitCreatedBy { get; set; }

        public DateTime KpitLastModifiedDate { get; set; }

        public string? KpitLastModifiedBy { get; set; }

        public virtual DossierAssignment? KpitAssignment { get; set; }

        public virtual Dossier KpitDossier { get; set; } = null!;

        public virtual Product? KpitProduct { get; set; }
    }
}