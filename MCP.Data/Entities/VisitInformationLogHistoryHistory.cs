namespace CED.Data.Entities
{
    public class VisitInformationLogHistoryHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? VlhId { get; set; }

        public Guid? VlhVisitInformationId { get; set; }

        public int? VlhLineNumber { get; set; }

        public Guid? VlhRoleCodeId { get; set; }

        public Guid? VlhLogHistoryTypeId { get; set; }

        public string? VlhFreeText { get; set; }

        public DateTime? VlhCreatedDate { get; set; }

        public string? VlhCreatedBy { get; set; }

        public DateTime? VlhLastModifiedDate { get; set; }

        public string? VlhLastModifiedBy { get; set; }
    }
}