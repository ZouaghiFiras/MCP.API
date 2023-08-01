namespace CED.Data.Entities
{
    public class DossierAuthorizationsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DauId { get; set; }

        public Guid? DauDossierId { get; set; }

        public string? DauRequiredAutorizationRoleId { get; set; }

        public DateTime? DauCreatedDate { get; set; }

        public string? DauCreatedBy { get; set; }

        public DateTime? DauLastModifiedDate { get; set; }

        public string? DauLastModifiedBy { get; set; }
    }
}