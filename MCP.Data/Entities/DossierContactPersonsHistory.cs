namespace CED.Data.Entities
{
    public class DossierContactPersonsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? DcpId { get; set; }

        public Guid? DcpDossierId { get; set; }

        public Guid? DcpContactPersonId { get; set; }

        public Guid? DcpContactPersonTypeId { get; set; }

        public DateTime? DcpEffectiveDate { get; set; }

        public DateTime? DcpTerminationDate { get; set; }

        public DateTime? DcpCreatedDate { get; set; }

        public string? DcpCreatedBy { get; set; }

        public DateTime? DcpLastModifiedDate { get; set; }

        public string? DcpLastModifiedBy { get; set; }
    }
}