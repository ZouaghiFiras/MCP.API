namespace CED.Data.Entities
{
    public class FollowTheGenerationOfReverseBillingView
    {
        public Guid? Id { get; set; }

        public DateTime? ActionDate { get; set; }

        public string? DossierNumber { get; set; }

        public string? AssignmentNumber { get; set; }

        public string? WorkingOrderNumber { get; set; }

        public Guid WorkingOrderLineId { get; set; }

        public string WorkingOrderLineNumber { get; set; } = null!;

        public string? WorkingOrderLineStatusType { get; set; }

        public string? SupplierNumber { get; set; }

        public string SupplierName { get; set; } = null!;

        public bool? IsCredit { get; set; }

        public string? ActionWo { get; set; }

        public bool? Picreated { get; set; }

        public bool? PidocumentsCreated { get; set; }

        public bool? PidocumentsSent { get; set; }

        public string? ErrorMessage { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? WorkingOrderId { get; set; }

        public Guid? DossierAssignmentId { get; set; }
    }
}