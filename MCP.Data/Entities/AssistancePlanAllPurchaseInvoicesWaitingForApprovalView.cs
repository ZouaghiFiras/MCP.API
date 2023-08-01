namespace CED.Data.Entities
{
    public class AssistancePlanAllPurchaseInvoicesWaitingForApprovalView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}