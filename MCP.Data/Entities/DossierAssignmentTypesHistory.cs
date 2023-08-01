namespace CED.Data.Entities
{
    public class DossierAssignmentTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public short? FatId { get; set; }

        public string? FatCode { get; set; }

        public string? FatShortName { get; set; }

        public string? FatLongName { get; set; }

        public bool? FatInactive { get; set; }

        public Guid? FatLocalizableEntryId { get; set; }

        public DateTime? FatCreatedDate { get; set; }

        public string? FatCreatedBy { get; set; }

        public DateTime? FatLastModifiedDate { get; set; }

        public string? FatLastModifiedBy { get; set; }
    }
}