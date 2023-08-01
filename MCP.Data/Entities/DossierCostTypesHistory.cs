namespace CED.Data.Entities
{
    public class DossierCostTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DctId { get; set; }

        public string? DctName { get; set; }

        public bool? DctInactive { get; set; }

        public Guid? DctLocalizableEntryId { get; set; }

        public DateTime? DctCreatedDate { get; set; }

        public string? DctCreatedBy { get; set; }

        public DateTime? DctLastModifiedDate { get; set; }

        public string? DctLastModifiedBy { get; set; }
    }
}