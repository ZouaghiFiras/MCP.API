namespace CED.Data.Entities
{
    public class InsurancePolicy
    {
        public Guid IpoId { get; set; }

        public byte[] IpoTimeStamp { get; set; } = null!;

        public Guid? IpoClientId { get; set; }

        public Guid? IpoInsurerId { get; set; }

        public Guid? IpoMandateId { get; set; }

        public Guid? IpoAgentId { get; set; }

        public Guid? IpoDossierInsureeId { get; set; }

        public string IpoContractNumber { get; set; } = null!;

        public DateTime IpoStartDate { get; set; }

        public string? IpoContributionPaid { get; set; }

        public string? IpoPolicyDisbarred { get; set; }

        public DateTime? IpoDateDisbarred { get; set; }

        public string? IpoInsuranceProductType { get; set; }

        public decimal? IpoOwnRisc { get; set; }

        public Guid? IpoChargedExpensesInvoiceRecipientId { get; set; }

        public Guid? IpoFeeInvoiceRecipientId { get; set; }

        public string? IpoUnknownAgentInfo { get; set; }

        public Guid? IpoRoadAuthorityId { get; set; }

        public Guid? IpoAlarmCenterId { get; set; }

        public Guid? IpoLeasingCompanyId { get; set; }

        public string? IpoFreeField1 { get; set; }

        public string? IpoFreeField2 { get; set; }

        public string? IpoFreeField3 { get; set; }

        public string? IpoFreeField4 { get; set; }

        public string? IpoMandateNameFreeText { get; set; }

        public bool IpoInactive { get; set; }

        public DateTime IpoCreatedDate { get; set; }

        public string? IpoCreatedBy { get; set; }

        public DateTime IpoLastModifiedDate { get; set; }

        public string? IpoLastModifiedBy { get; set; }

        public Guid? IpoOwnRiskInvoiceRecipientId { get; set; }

        public Guid? IpoVatdeductableInvoiceRecipientId { get; set; }

        public string? IpoCurrencyCode { get; set; }

        public string? IpoClientCaseNumber { get; set; }

        public string? IpoClientOrderNumber { get; set; }

        public Guid? IpoOptionId { get; set; }

        public virtual ICollection<AdviceDossier> AdviceDossiers { get; } = new List<AdviceDossier>();

        public virtual ICollection<ClaimDossier> ClaimDossiers { get; } = new List<ClaimDossier>();

        public virtual ICollection<InsurancePoliciesCorrectionAuthorization> InsurancePoliciesCorrectionAuthorizations
        {
            get;
        } = new List<InsurancePoliciesCorrectionAuthorization>();

        public virtual ICollection<InvolvedCoverage> InvolvedCoverages { get; } = new List<InvolvedCoverage>();

        public virtual Agent? IpoAgent { get; set; }

        public virtual AlarmCenter? IpoAlarmCenter { get; set; }

        public virtual OrganizationUnit? IpoChargedExpensesInvoiceRecipient { get; set; }

        public virtual Client? IpoClient { get; set; }

        public virtual DossierInsuree? IpoDossierInsuree { get; set; }

        public virtual OrganizationUnit? IpoFeeInvoiceRecipient { get; set; }

        public virtual Insurer? IpoInsurer { get; set; }

        public virtual LeasingCompany? IpoLeasingCompany { get; set; }

        public virtual Mandate? IpoMandate { get; set; }

        public virtual OrganizationUnit? IpoOwnRiskInvoiceRecipient { get; set; }

        public virtual RoadAuthority? IpoRoadAuthority { get; set; }

        public virtual OrganizationUnit? IpoVatdeductableInvoiceRecipient { get; set; }
    }
}