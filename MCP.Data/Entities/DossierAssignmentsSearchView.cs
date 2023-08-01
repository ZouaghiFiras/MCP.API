namespace CED.Data.Entities
{
    public class DossierAssignmentsSearchView
    {
        public Guid Id { get; set; }

        public string AssignmentNumber { get; set; } = null!;

        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public string LeadCurrencyCode { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}