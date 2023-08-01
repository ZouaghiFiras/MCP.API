namespace CED.Data.Entities
{
    public class WorkingOrderLineCostsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WolcId { get; set; }

        public Guid? WolcWorkingOrderLineId { get; set; }

        public string? WolcDescription { get; set; }

        public decimal? WolcAmount { get; set; }

        public Guid? WolcWorkingOrderLineCostTypeId { get; set; }

        public Guid? WolcCostTypeId { get; set; }

        public bool? WolcVat { get; set; }

        public DateTime? WolcCreatedDate { get; set; }

        public string? WolcCreatedBy { get; set; }

        public DateTime? WolcLastModifiedDate { get; set; }

        public string? WolcLastModifiedBy { get; set; }
    }
}