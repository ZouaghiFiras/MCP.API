namespace CED.Data.Entities
{
    public class SalesOrderLinesWithAssistancePlansView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public Guid SalesOrderId { get; set; }

        public int LineNumber { get; set; }

        public bool IsCredit { get; set; }

        public bool IsFee { get; set; }

        public bool IsVoided { get; set; }

        public string? AssistancePlanNumber { get; set; }

        public string? AssistancePlanStatusCode { get; set; }

        public string? AssistancePlanStatusName { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}