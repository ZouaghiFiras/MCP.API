namespace CED.Data.Entities
{
    public class DossiersHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DosId { get; set; }

        public string? DosDossierNumber { get; set; }

        public Guid? DosClientId { get; set; }

        public Guid? DosMandateId { get; set; }

        public Guid? DosAgentId { get; set; }

        public Guid? DosContactPersonId { get; set; }

        public Guid? DosProductId { get; set; }

        public Guid? DosEmployeeId { get; set; }

        public Guid? DosTenantId { get; set; }

        public short? DosDossierTypeId { get; set; }

        public string? DosEntrySystem { get; set; }

        public string? DosEntryNumber { get; set; }

        public string? DosEntryBatch { get; set; }

        public Guid? DosLegalEntityId { get; set; }

        public Guid? DosDepartmentId { get; set; }

        public DateTime? DosCreatedDate { get; set; }

        public string? DosCreatedBy { get; set; }

        public DateTime? DosLastModifiedDate { get; set; }

        public string? DosLastModifiedBy { get; set; }

        public string? DosCurrentStatusCode { get; set; }

        public Guid? DosCurrentStatusHistoryId { get; set; }

        public DateTime? DosCurrentStatusHistoryStartDate { get; set; }

        public Guid? DosDossierPriorityId { get; set; }
    }
}