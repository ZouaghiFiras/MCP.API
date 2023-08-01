namespace CED.Data.Entities
{
    public class ClaimReservesView
    {
        public Guid Id { get; set; }

        public string? ClaimReserveNumber { get; set; }

        public DateTime? ClaimReserveDate { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public decimal TotalReservedValue { get; set; }

        public decimal TotalClaimValue { get; set; }

        public decimal? OpenAmount { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public Guid DepartmentId { get; set; }

        public string DepartmentCode { get; set; } = null!;

        public string DepartmentName { get; set; } = null!;

        public Guid ClaimReserveTypeId { get; set; }

        public string ClaimReserveTypeCode { get; set; } = null!;

        public string ClaimReserveTypeName { get; set; } = null!;

        public string ClaimReserveClassificationId { get; set; } = null!;

        public string ClaimReserveClassificationName { get; set; } = null!;

        public Guid InvolvedCoverageId { get; set; }

        public string? InsurancePolicyNumber { get; set; }

        public string? InsurancePolicyFreeField1 { get; set; }

        public string? InsurancePolicyFreeField2 { get; set; }

        public string? InsurancePolicyFreeField3 { get; set; }

        public string? InsurancePolicyFreeField4 { get; set; }

        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public Guid? DossierPartyId { get; set; }

        public string? DossierPartyName { get; set; }

        public string? InsureeCountryCodeIso3 { get; set; }

        public string? InsureeFormattedName { get; set; }

        public string? InsureePolicyNumber { get; set; }

        public string? ClientProductCode { get; set; }

        public Guid ClientId { get; set; }

        public string ClientCode { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public string ClientCurrencyCode { get; set; } = null!;

        public decimal TotalClientReservedValue { get; set; }

        public decimal TotalClientClaimValue { get; set; }

        public decimal? TotalClientOpenAmount { get; set; }

        public string LeadCurrencyCode { get; set; } = null!;

        public decimal TotalLeadReservedValue { get; set; }

        public decimal TotalLeadClaimValue { get; set; }

        public decimal? TotalLeadOpenAmount { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntryBatch { get; set; }

        public Guid? CurrentStatusHistoryId { get; set; }

        public DateTime? CurrentStatusHistoryStartDate { get; set; }

        public string? CurrentStatusCode { get; set; }

        public string? CurrentStatusName { get; set; }

        public Guid? InsurerId { get; set; }

        public string? InsurerCode { get; set; }

        public string InsurerName { get; set; } = null!;

        public Guid? MandateId { get; set; }

        public string? MandateCode { get; set; }

        public string MandateName { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}