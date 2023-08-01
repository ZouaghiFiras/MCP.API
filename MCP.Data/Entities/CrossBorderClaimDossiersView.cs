namespace CED.Data.Entities
{
    public class CrossBorderClaimDossiersView
    {
        public Guid Id { get; set; }

        public DateTime IncidentDate { get; set; }

        public string IncidentCountryCode { get; set; } = null!;

        public string? ClientIncidentNumber { get; set; }

        public string? ClientInvoiceEmail { get; set; }

        public string? GreencardNumber { get; set; }

        public bool IsDomesticClaim { get; set; }

        public string? DossierNumber { get; set; }

        public Guid ClientId { get; set; }

        public string ClientCode { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public Guid? AgentId { get; set; }

        public string? AgentCode { get; set; }

        public string AgentName { get; set; } = null!;

        public Guid? ContactPersonId { get; set; }

        public string? ContactPersonFullName { get; set; }

        public string? ContactPersonEmail { get; set; }

        public string? ContactPersonMobile { get; set; }

        public string? ContactPersonPhone { get; set; }

        public Guid ProductId { get; set; }

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public Guid? EmployeeId { get; set; }

        public Guid? TenantId { get; set; }

        public short? DossierTypeId { get; set; }

        public string? DossierTypeCode { get; set; }

        public string? DossierTypeName { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntryBatch { get; set; }

        public Guid? DossierHandlerId { get; set; }

        public string? DossierHandlerName { get; set; }

        public Guid? DossierStatusId { get; set; }

        public string? DossierStatusCode { get; set; }

        public string? DossierStatusName { get; set; }

        public string? ApplicationName { get; set; }

        public Guid? MandateId { get; set; }

        public string? MandateCode { get; set; }

        public string MandateName { get; set; } = null!;

        public Guid? DepartmentId { get; set; }

        public string? DepartmentCode { get; set; }

        public string DepartmentName { get; set; } = null!;

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public string? LegalEntityName { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}