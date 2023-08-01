namespace CED.Data.Entities
{
    public class FuelTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? FtId { get; set; }

        public string? FtCode { get; set; }

        public string? FtShortName { get; set; }

        public string? FtLongName { get; set; }

        public bool? FtInactive { get; set; }

        public Guid? FtLocalizableEntryId { get; set; }

        public DateTime? FtCreatedDate { get; set; }

        public string? FtCreatedBy { get; set; }

        public DateTime? FtLastModifiedDate { get; set; }

        public string? FtLastModifiedBy { get; set; }
    }
}