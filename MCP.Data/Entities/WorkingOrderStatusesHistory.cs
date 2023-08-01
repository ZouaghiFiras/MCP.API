namespace CED.Data.Entities
{
    public class WorkingOrderStatusesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WstId { get; set; }

        public string? WstCode { get; set; }

        public string? WstShortName { get; set; }

        public string? WstLongName { get; set; }

        public bool? WstInactive { get; set; }

        public string? WstWorkingOrderStatusTypeId { get; set; }

        public Guid? WstLocalizableEntryId { get; set; }

        public DateTime? WstCreatedDate { get; set; }

        public string? WstCreatedBy { get; set; }

        public DateTime? WstLastModifiedDate { get; set; }

        public string? WstLastModifiedBy { get; set; }
    }
}