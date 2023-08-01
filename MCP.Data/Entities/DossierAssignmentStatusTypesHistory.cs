namespace CED.Data.Entities
{
    public class DossierAssignmentStatusTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public string? DasId { get; set; }

        public string? DasName { get; set; }

        public bool? DasInactive { get; set; }

        public Guid? DasLocalizableEntryId { get; set; }

        public DateTime? DasCreatedDate { get; set; }

        public string? DasCreatedBy { get; set; }

        public DateTime? DasLastModifiedDate { get; set; }

        public string? DasLastModifiedBy { get; set; }
    }
}