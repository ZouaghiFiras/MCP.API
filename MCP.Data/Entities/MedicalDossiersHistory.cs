namespace CED.Data.Entities
{
    public class MedicalDossiersHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? MedId { get; set; }

        public DateTime? MedIntakeDate { get; set; }

        public DateTime? MedIncidentDate { get; set; }

        public string? MedIncidentCountryCode { get; set; }

        public Guid? MedIncidentLocationId { get; set; }

        public int? MedNumberOfPassengers { get; set; }

        public bool? MedReportedAfterwards { get; set; }

        public bool? MedAssistanceBeforeConfirmation { get; set; }

        public string? MedCause { get; set; }

        public string? MedReason { get; set; }

        public bool? MedTravellingToAbroad { get; set; }

        public string? MedExternalComments { get; set; }

        public string? MedInternalComments { get; set; }

        public DateTime? MedCreatedDate { get; set; }

        public string? MedCreatedBy { get; set; }

        public DateTime? MedLastModifiedDate { get; set; }

        public string? MedLastModifiedBy { get; set; }
    }
}