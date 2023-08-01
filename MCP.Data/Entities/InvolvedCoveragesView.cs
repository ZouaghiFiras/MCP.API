namespace CED.Data.Entities
{
    public class InvolvedCoveragesView
    {
        public Guid Id { get; set; }

        public string? InsurancePolicyNumber { get; set; }

        public string? InsurancePolicyFreeField1 { get; set; }

        public string? InsurancePolicyFreeField2 { get; set; }

        public string? InsurancePolicyFreeField3 { get; set; }

        public string? InsurancePolicyFreeField4 { get; set; }

        public decimal? CoverageAmount { get; set; }

        public string? CoverageCurrencyCode { get; set; }

        public decimal? CoveragePercentage { get; set; }

        public bool? CoverageConfirmed { get; set; }

        public DateTime? ConfirmationDate { get; set; }

        public bool? CoverageInactive { get; set; }

        public Guid InsuranceCoverageId { get; set; }

        public Guid? InsurancePolicyId { get; set; }

        public string InsuranceCoverageCode { get; set; } = null!;

        public string InsuranceCoverageName { get; set; } = null!;

        public Guid DossierId { get; set; }

        public Guid? DossierPartyId { get; set; }

        public string? PolicyHolder { get; set; }

        public DateTime? PolicyHolderDateOfBirth { get; set; }

        public Guid? LiabilityStatusId { get; set; }

        public string? LiabilityStatusCode { get; set; }

        public string? LiabilityStatusShortName { get; set; }

        public string? LiabilityStatusLongName { get; set; }

        public DateTime? LiabilityStatusChangedDate { get; set; }

        public Guid? LiabilityStatusChangedByEmployeeId { get; set; }

        public Guid? ClientId { get; set; }

        public string ClientName { get; set; } = null!;

        public string? ClientCode { get; set; }

        public Guid? InsurerId { get; set; }

        public string InsurerName { get; set; } = null!;

        public string? InsurerCode { get; set; }

        public Guid? MandateId { get; set; }

        public string? MandateName { get; set; }

        public string? MandateCode { get; set; }

        public string? InsuranceProductType { get; set; }

        public Guid? AgentId { get; set; }

        public string AgentName { get; set; } = null!;

        public string? AgentCode { get; set; }

        public string? UnknownAgentInfo { get; set; }

        public Guid? ChargedExpensesInvoiceRecipientId { get; set; }

        public string? ChargedExpensesInvoiceRecipientCode { get; set; }

        public string ChargedExpensesInvoiceRecipientName { get; set; } = null!;

        public Guid? FeeInvoiceRecipientId { get; set; }

        public string? FeeInvoiceRecipientCode { get; set; }

        public string FeeInvoiceRecipientName { get; set; } = null!;

        public Guid? CoverageProductId { get; set; }

        public string? CoverageProductCode { get; set; }

        public string? CoverageProductName { get; set; }

        public Guid? CoverageProductTypeId { get; set; }

        public string? CoverageProductTypeName { get; set; }

        public Guid? AlarmCenterId { get; set; }

        public string AlarmCenterName { get; set; } = null!;

        public string? AlarmCenterCode { get; set; }

        public Guid? RoadAuthorityId { get; set; }

        public string RoadAuthorityName { get; set; } = null!;

        public string? RoadAuthorityCode { get; set; }

        public Guid? LeasingCompanyId { get; set; }

        public string LeasingCompanyName { get; set; } = null!;

        public string? LeasingCompanyCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}