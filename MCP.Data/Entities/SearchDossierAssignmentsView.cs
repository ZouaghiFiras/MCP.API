namespace CED.Data.Entities
{
    public class SearchDossierAssignmentsView
    {
        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid DossierAssignmentId { get; set; }

        public string DossierAssignmentNumber { get; set; } = null!;

        public Guid? DepartmentId { get; set; }

        public string? DepartmentCode { get; set; }

        public string DepartmentName { get; set; } = null!;

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public string LegalEntityName { get; set; } = null!;

        public Guid? ProductId { get; set; }

        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }

        public string? ClientCaseNumber { get; set; }

        public string? ClientOrderNumber { get; set; }

        public string? DossierAssignmentStatusCode { get; set; }

        public string? DossierAssignmentStatusName { get; set; }

        public string? DossierAssignmentStatusTypeId { get; set; }

        public string? DossierAssignmentStatusTypeName { get; set; }

        public string? EntrySystem { get; set; }
    }
}