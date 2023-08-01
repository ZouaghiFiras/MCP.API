namespace CED.Data.Entities
{
    public class WorkingOrderLineStatusesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WlsId { get; set; }

        public string? WlsCode { get; set; }

        public string? WlsShortName { get; set; }

        public string? WlsLongName { get; set; }

        public bool? WlsInactive { get; set; }

        public string? WlsWorkingOrderLineStatusTypeId { get; set; }

        public Guid? WlsLocalizableEntryId { get; set; }

        public DateTime? WlsCreatedDate { get; set; }

        public string? WlsCreatedBy { get; set; }

        public DateTime? WlsLastModifiedDate { get; set; }

        public string? WlsLastModifiedBy { get; set; }
    }
}