namespace CED.Data.Entities
{
    public class DossierAssignmentEmployeeTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? AetId { get; set; }

        public string? AetName { get; set; }

        public bool? AetInactive { get; set; }

        public Guid? AetLocalizableEntryId { get; set; }

        public DateTime? AetCreatedDate { get; set; }

        public string? AetCreatedBy { get; set; }

        public DateTime? AetLastModifiedDate { get; set; }

        public string? AetLastModifiedBy { get; set; }
    }
}