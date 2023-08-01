namespace CED.Data.Entities
{
    public class WorkingOrderLineCostTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WocId { get; set; }

        public string? WocCode { get; set; }

        public string? WocShortName { get; set; }

        public string? WocLongName { get; set; }

        public bool? WocInactive { get; set; }

        public Guid? WocLocalizableEntryId { get; set; }

        public DateTime? WocCreatedDate { get; set; }

        public string? WocCreatedBy { get; set; }

        public DateTime? WocLastModifiedDate { get; set; }

        public string? WocLastModifiedBy { get; set; }
    }
}