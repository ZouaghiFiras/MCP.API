namespace CED.Data.Entities
{
    public class InsurancePoliciesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? IpoId { get; set; }

        public Guid? IpoClientId { get; set; }

        public Guid? IpoInsurerId { get; set; }

        public Guid? IpoMandateId { get; set; }

        public Guid? IpoAgentId { get; set; }

        public Guid? IpoDossierInsureeId { get; set; }

        public string? IpoContractNumber { get; set; }

        public DateTime? IpoStartDate { get; set; }

        public string? IpoContributionPaid { get; set; }

        public string? IpoPolicyDisbarred { get; set; }

        public DateTime? IpoDateDisbarred { get; set; }

        public string? IpoInsuranceProductType { get; set; }

        public decimal? IpoOwnRisc { get; set; }

        public Guid? IpoChargedExpensesInvoiceRecipientId { get; set; }

        public Guid? IpoFeeInvoiceRecipientId { get; set; }

        public string? IpoUnknownAgentInfo { get; set; }

        public DateTime? IpoCreatedDate { get; set; }

        public string? IpoCreatedBy { get; set; }

        public DateTime? IpoLastModifiedDate { get; set; }

        public string? IpoLastModifiedBy { get; set; }

        public string? IpoFreeField4 { get; set; }

        public Guid? IpoLeasingCompanyId { get; set; }

        public string? IpoMandateNameFreeText { get; set; }

        public string? IpoFreeField3 { get; set; }

        public Guid? IpoAlarmCenterId { get; set; }

        public Guid? IpoRoadAuthorityId { get; set; }

        public string? IpoFreeField2 { get; set; }

        public string? IpoFreeField1 { get; set; }

        public bool? IpoInactive { get; set; }

        public Guid? IpoOwnRiskInvoiceRecipientId { get; set; }

        public Guid? IpoVatdeductableInvoiceRecipientId { get; set; }
    }
}