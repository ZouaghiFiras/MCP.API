namespace CED.Data.Entities
{
    public class DossierStatusTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public string? DtyId { get; set; }

        public string? DtyName { get; set; }

        public bool? DtyInactive { get; set; }

        public Guid? DtyLocalizableEntryId { get; set; }

        public DateTime? DtyCreatedDate { get; set; }

        public string? DtyCreatedBy { get; set; }

        public DateTime? DtyLastModifiedDate { get; set; }

        public string? DtyLastModifiedBy { get; set; }
    }
}