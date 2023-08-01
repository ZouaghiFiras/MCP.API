namespace CED.Data.Entities
{
    public class DossierStatusesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DstId { get; set; }

        public string? DstCode { get; set; }

        public string? DstShortName { get; set; }

        public string? DstLongName { get; set; }

        public bool? DstInactive { get; set; }

        public string? DstDossierStatusTypeId { get; set; }

        public Guid? DstLocalizableEntryId { get; set; }

        public DateTime? DstCreatedDate { get; set; }

        public string? DstCreatedBy { get; set; }

        public DateTime? DstLastModifiedDate { get; set; }

        public string? DstLastModifiedBy { get; set; }
    }
}