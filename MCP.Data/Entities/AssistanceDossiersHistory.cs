namespace CED.Data.Entities
{
    public class AssistanceDossiersHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? AsdId { get; set; }

        public DateTime? AsdIntakeDate { get; set; }

        public DateTime? AsdIncidentDate { get; set; }

        public string? AsdIncidentCountryCode { get; set; }

        public Guid? AsdIncidentLocationId { get; set; }

        public int? AsdNumberOfPassengers { get; set; }

        public bool? AsdPetsInvolved { get; set; }

        public bool? AsdReportedAfterwards { get; set; }

        public bool? AsdLcm { get; set; }

        public bool? AsdAssistanceBeforeConfirmation { get; set; }

        public string? AsdCause { get; set; }

        public string? AsdReason { get; set; }

        public bool? AsdTravellingToAbroad { get; set; }

        public DateTime? AsdCreatedDate { get; set; }

        public string? AsdCreatedBy { get; set; }

        public DateTime? AsdLastModifiedDate { get; set; }

        public string? AsdLastModifiedBy { get; set; }

        public bool? AsdIsOem { get; set; }

        public string? AsdIncidentNumber { get; set; }

        public string? AsdCaseNumberAlarmCenter { get; set; }

        public Guid? AsdOriginalAssistanceDossierId { get; set; }

        public string? AsdExternalComments { get; set; }

        public string? AsdInternalComments { get; set; }

        public Guid? AsdRoadAuthorityId { get; set; }

        public bool? AsdSecurityVehicleRequested { get; set; }

        public bool? AsdIsDuplicate { get; set; }
    }
}