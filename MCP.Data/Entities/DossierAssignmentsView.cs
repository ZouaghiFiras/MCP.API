namespace CED.Data.Entities
{
    public class DossierAssignmentsView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string AssignmentNumber { get; set; } = null!;

        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public Guid? DepartmentId { get; set; }

        public string? DepartmentCode { get; set; }

        public string? DepartmentAbbreviation { get; set; }

        public string DepartmentName { get; set; } = null!;

        public Guid? PartnerId { get; set; }

        public string? PartnerCode { get; set; }

        public string? PartnerAbbreviation { get; set; }

        public string PartnerName { get; set; } = null!;

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public string? LegalEntityAbbreviation { get; set; }

        public string LegalEntityName { get; set; } = null!;

        public short AssignmentTypeId { get; set; }

        public string AssignmentTypeCode { get; set; } = null!;

        public string? AssignmentTypeAbbreviation { get; set; }

        public string AssignmentTypeName { get; set; } = null!;

        public Guid? AssignmentStatusHistoryId { get; set; }

        public DateTime? AssignmentStatusDate { get; set; }

        public Guid? AssignmentStatusId { get; set; }

        public string? AssignmentStatusCode { get; set; }

        public string? AssignmentStatusAbbreviation { get; set; }

        public string? AssignmentStatusName { get; set; }

        public Guid? AssignmentHandlerEmployeeId { get; set; }

        public DateTime? AssignmentHandlerDate { get; set; }

        public string? AssignmentHandlerName { get; set; }

        public string? AssignmentHandlerPhone { get; set; }

        public string? AssignmentHandlerEmail { get; set; }

        public Guid? ClosingHistoryId { get; set; }

        public DateTime? ClosingDate { get; set; }

        public bool? OperationalClosing { get; set; }

        public bool? FinancialClosing { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}