namespace CED.Data.Entities
{
    public class RepairOrderHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? RohId { get; set; }

        public string? RohNumber { get; set; }

        public DateTime? RohDate { get; set; }

        public Guid? RohRepairerId { get; set; }

        public Guid? RohTenantId { get; set; }

        public DateTime? RohCreatedDate { get; set; }

        public string? RohCreatedBy { get; set; }

        public DateTime? RohLastModifiedDate { get; set; }

        public string? RohLastModifiedBy { get; set; }

        public bool? RohToyRequired { get; set; }

        public bool? RohToyDelivered { get; set; }

        public bool? RohPreventionBoxRequired { get; set; }

        public bool? RohPreventionBoxDelivered { get; set; }

        public bool? RohSuspectingFraud { get; set; }

        public string? RohMaintenanceStatus { get; set; }

        public bool? RohSituationMatchesAssignment { get; set; }

        public bool? RohCauseMatchesAssignment { get; set; }

        public bool? RohIsAdditionalWork { get; set; }

        public decimal? RohFee { get; set; }

        public bool? RohIsContractorModel { get; set; }

        public string? RohCurrentStatusCode { get; set; }

        public Guid? RohCurrentStatusHistoryId { get; set; }

        public DateTime? RohCurrentStatusHistoryStartDate { get; set; }
    }
}