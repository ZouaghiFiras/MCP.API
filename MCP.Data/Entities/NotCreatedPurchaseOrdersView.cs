namespace CED.Data.Entities
{
    public class NotCreatedPurchaseOrdersView
    {
        public Guid? Id { get; set; }

        public Guid WorkingOrderLineId { get; set; }

        public Guid DossierId { get; set; }

        public Guid DossierAssignmentId { get; set; }

        public Guid WorkingOrderId { get; set; }

        public DateTime TaskDate { get; set; }

        public string TaskDescription { get; set; } = null!;

        public string? DossierNumber { get; set; }

        public string AssignmentNumber { get; set; } = null!;

        public string? WorkingOrderNumber { get; set; }

        public string? WorkingOrderLineNumber { get; set; }

        public string WorkingOrderLineStatus { get; set; } = null!;

        public string? Reason { get; set; }
    }
}