namespace CED.Data.Entities
{
    public class MappingPaymentConditionsView
    {
        public string OldPaymentConditionCode { get; set; } = null!;

        public string NewPaymentConditionCode { get; set; } = null!;

        public Guid OldPaymentConditionId { get; set; }

        public Guid NewPaymentconditionId { get; set; }
    }
}