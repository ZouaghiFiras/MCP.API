namespace CED.Data.Entities
{
    public class DossierTypesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public short? DotId { get; set; }

        public string? DotCode { get; set; }

        public string? DotShortName { get; set; }

        public string? DotLongName { get; set; }

        public bool? DotInactive { get; set; }

        public DateTime? DotCreatedDate { get; set; }

        public string? DotCreatedBy { get; set; }

        public DateTime? DotLastModifiedDate { get; set; }

        public string? DotLastModifiedBy { get; set; }
    }
}