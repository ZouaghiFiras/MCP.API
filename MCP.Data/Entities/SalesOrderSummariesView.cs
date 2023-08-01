namespace CED.Data.Entities
{
    public class SalesOrderSummariesView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public DateTime? OrderDate { get; set; }

        public string? EntrySystem { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public Guid? DepartmentId { get; set; }

        public string? DepartmentCode { get; set; }

        public string DepartmentName { get; set; } = null!;

        public Guid? SalesOrderTypeId { get; set; }

        public string? SalesOrderTypeCode { get; set; }

        public string? SalesOrderTypeName { get; set; }

        public Guid ClientId { get; set; }

        public string ClientNumber { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public string? LeadCurrencyCode { get; set; }

        public bool IsCredit { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? AssignmentNumber { get; set; }

        public string? SalesOrderStatusCode { get; set; }

        public string SalesOrderStatusName { get; set; } = null!;

        public DateTime? SalesOrderStatusDate { get; set; }

        public string? SalesInvoiceNumber { get; set; }

        public Guid? SalesInvoiceId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public DateTime? DossierCreationDate { get; set; }

        public DateTime? AssignmentCreationDate { get; set; }
    }
}