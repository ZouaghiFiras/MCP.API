namespace CED.Data.Entities
{
    public class RepairDossiersHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? RedId { get; set; }

        public DateTime? RedIncidentDate { get; set; }

        public string? RedIncidentStreet { get; set; }

        public string? RedIncidentCity { get; set; }

        public bool? RedHasExpertIntake { get; set; }

        public bool? RedIsExpertiseDossier { get; set; }

        public decimal? RedDamageAmountEstimate { get; set; }

        public decimal? RedDamageAmountFinal { get; set; }

        public string? RedReportingParty { get; set; }

        public DateTime? RedCreatedDate { get; set; }

        public string? RedCreatedBy { get; set; }

        public DateTime? RedLastModifiedDate { get; set; }

        public string? RedLastModifiedBy { get; set; }
    }
}