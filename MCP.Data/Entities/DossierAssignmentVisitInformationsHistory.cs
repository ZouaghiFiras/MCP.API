namespace CED.Data.Entities
{
    public class DossierAssignmentVisitInformationsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DavId { get; set; }

        public Guid? DavDossierAssignmentId { get; set; }

        public Guid? DavVisitInformationId { get; set; }

        public DateTime? DavCreatedDate { get; set; }

        public string? DavCreatedBy { get; set; }

        public DateTime? DavLastModifiedDate { get; set; }

        public string? DavLastModifiedBy { get; set; }
    }
}