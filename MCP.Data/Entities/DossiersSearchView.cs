namespace CED.Data.Entities
{
    public class DossiersSearchView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? DossierNumber { get; set; }

        public string? DossierStatusCode { get; set; }

        public string? DossierStatusName { get; set; }

        public string? AssistancePlanNumbers { get; set; }

        public string? InsurancePolicyNumbers { get; set; }

        public string? LicensePlates { get; set; }

        public string? InsureeNames { get; set; }

        public string? InsureePostalCodes { get; set; }

        public string? InsureeHouseNumbers { get; set; }

        public string? SalesInvoiceNumbers { get; set; }

        public DateTime? IncidentDate { get; set; }

        public Guid ClientId { get; set; }

        public string ClientCode { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public string LegalEntityName { get; set; } = null!;

        public Guid? DepartmentId { get; set; }

        public string? DepartmentCode { get; set; }

        public string DepartmentName { get; set; } = null!;

        public string? DossierAssignmentNumbers { get; set; }

        public string? WorkingOrderNumbers { get; set; }

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public string? EntrySystem { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}