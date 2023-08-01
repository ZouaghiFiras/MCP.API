namespace CED.Data.Entities
{
    public class DossierAssignmentHandlerHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? AhhId { get; set; }

        public Guid? AhhDossierAssignmentId { get; set; }

        public Guid? AhhEmployeeId { get; set; }

        public string? AhhAssignmentHandlerName { get; set; }

        public string? AhhAssignmentHandlerPhone { get; set; }

        public string? AhhAssignmentHandlerEmail { get; set; }

        public DateTime? AhhStartDate { get; set; }

        public DateTime? AhhCreatedDate { get; set; }

        public string? AhhCreatedBy { get; set; }

        public DateTime? AhhLastModifiedDate { get; set; }

        public string? AhhLastModifiedBy { get; set; }

        public Guid? AhhDossierAssignmentEmployeeTypeId { get; set; }
    }
}