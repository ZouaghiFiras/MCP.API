namespace CED.Data.Entities
{
    public class DossierWorkActivitiesInvoiceableView
    {
        public Guid DossierWorkActivityId { get; set; }

        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? DossierAssignmentNumber { get; set; }

        public Guid? FeeRecipientId { get; set; }

        public string? FeeRecipientCode { get; set; }

        public string FeeRecipientName { get; set; } = null!;

        public Guid? ClientId { get; set; }

        public string? ClientCode { get; set; }

        public string ClientName { get; set; } = null!;

        public DateTime DossierWorkActivityCreatedDate { get; set; }

        public Guid ProductId { get; set; }

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public Guid? DossierStatusId { get; set; }

        public string? DossierStatusCode { get; set; }

        public string? DossierStatusName { get; set; }

        public Guid? DossierAssignmentStatusId { get; set; }

        public string? DossierAssignmentStatusCode { get; set; }

        public string? DossierAssignmentStatusName { get; set; }

        public Guid WorkActivityId { get; set; }

        public string WorkActivityCode { get; set; } = null!;

        public string WorkActivityName { get; set; } = null!;

        public Guid? ActivityOptionId { get; set; }

        public string? ActivityOptionCode { get; set; }

        public string? ActivityOptionName { get; set; }

        public Guid? ActivityExecutionId { get; set; }

        public string? ActivityExecutionCode { get; set; }

        public string? ActivityExecutionName { get; set; }

        public bool IsUrgent { get; set; }

        public string? EntrySystem { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}