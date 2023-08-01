namespace CED.Data.Entities
{
    public class DossierAssignmentsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DoaId { get; set; }

        public string? DoaAssignmentNumber { get; set; }

        public Guid? DoaDossierId { get; set; }

        public Guid? DoaDepartmentId { get; set; }

        public Guid? DoaPartnerId { get; set; }

        public short? DoaAssignmentTypeId { get; set; }

        public string? DoaCurrencyCode { get; set; }

        public DateTime? DoaCreatedDate { get; set; }

        public string? DoaCreatedBy { get; set; }

        public DateTime? DoaLastModifiedDate { get; set; }

        public string? DoaLastModifiedBy { get; set; }

        public string? DoaCurrentStatusCode { get; set; }

        public Guid? DoaCurrentStatusHistoryId { get; set; }

        public DateTime? DoaCurrentStatusHistoryStartDate { get; set; }

        public Guid? DoaInvolvedObjectId { get; set; }

        public Guid? DoaInvolvedCoverageId { get; set; }

        public Guid? DoaEmployeeId { get; set; }

        public Guid? DoaProductId { get; set; }
    }
}