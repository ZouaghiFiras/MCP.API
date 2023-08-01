namespace CED.Data.Entities
{
    public class RepairOrderLineHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? RolId { get; set; }

        public Guid? RolRepairOrderId { get; set; }

        public short? RolNumber { get; set; }

        public Guid? RolDossierLineId { get; set; }

        public DateTime? RolCreatedDate { get; set; }

        public string? RolCreatedBy { get; set; }

        public DateTime? RolLastModifiedDate { get; set; }

        public string? RolLastModifiedBy { get; set; }
    }
}