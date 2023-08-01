namespace CED.Data.Entities
{
    public class WorkingOrdersSearchView
    {
        public Guid Id { get; set; }

        public string? WorkingOrderNumber { get; set; }

        public Guid? WorkingOrderTypeId { get; set; }

        public string? WorkingOrderTypeCode { get; set; }

        public string? WorkingOrderTypeName { get; set; }

        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid DossierAssignmentId { get; set; }

        public string AssignmentNumber { get; set; } = null!;

        public string LeadCurrencyCode { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}