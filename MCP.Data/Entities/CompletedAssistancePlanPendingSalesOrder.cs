namespace CED.Data.Entities
{
    public class CompletedAssistancePlanPendingSalesOrder
    {
        public Guid AssistancePlanId { get; set; }

        public string AssistancePlanNumber { get; set; } = null!;

        public Guid CompletedByEmployeeId { get; set; }

        public string AssistancePlanStatus { get; set; } = null!;
    }
}