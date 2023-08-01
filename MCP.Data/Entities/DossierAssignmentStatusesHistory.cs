namespace CED.Data.Entities
{
    public class DossierAssignmentStatusesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? AstId { get; set; }

        public string? AstCode { get; set; }

        public string? AstShortName { get; set; }

        public string? AstLongName { get; set; }

        public bool? AstInactive { get; set; }

        public Guid? AstLocalizableEntryId { get; set; }

        public DateTime? AstCreatedDate { get; set; }

        public string? AstCreatedBy { get; set; }

        public DateTime? AstLastModifiedDate { get; set; }

        public string? AstLastModifiedBy { get; set; }

        public string? AstDossierAssignmentStatusTypeId { get; set; }
    }
}