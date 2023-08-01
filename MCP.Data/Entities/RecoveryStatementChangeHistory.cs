namespace CED.Data.Entities
{
    public class RecoveryStatementChangeHistory
    {
        public Guid RcshId { get; set; }

        public byte[] RcshTimeStamp { get; set; } = null!;

        public Guid RcshRecoveryStatementId { get; set; }

        public string RcshStatementNumber { get; set; } = null!;

        public string RcshDossierNumber { get; set; } = null!;

        public DateTime RcshDossierDate { get; set; }

        public DateTime? RcshIncidentDate { get; set; }

        public decimal RcshIncidentAmountPaid { get; set; }

        public decimal RcshOwnRiskAmount { get; set; }

        public decimal? RcshRecoveryAmountExpected { get; set; }

        public string RcshCurrencyCode { get; set; } = null!;

        public string? RcshEntryNumber { get; set; }

        public string? RcshEntrySystem { get; set; }

        public string? RcshEntryBatch { get; set; }

        public bool? RcshIsGuaranteeFund { get; set; }

        public bool? RcshIsInsuredLiable { get; set; }

        public string? RcshInsuranceCoverageCode { get; set; }

        public string? RcshIncidentDescription { get; set; }

        public string? RcshClientProductCode { get; set; }

        public string RcshInsuredPartyName { get; set; } = null!;

        public Guid? RcshInsuredPartyAddressId { get; set; }

        public string? RcshInsuredPartyIban { get; set; }

        public string? RcshInsuredPartyInsurancePolicyNumber { get; set; }

        public string? RcshInsuredPartyIncidentNumber { get; set; }

        public string? RcshInsuredPartyLicensePlate { get; set; }

        public Guid RcshInsuredPartyInsurerId { get; set; }

        public string RcshInsuredPartyInsurerCode { get; set; } = null!;

        public string RcshInsuredPartyInsurerName { get; set; } = null!;

        public Guid? RcshInsuredPartyInsurerAddressId { get; set; }

        public string RcshInsuredPartyInsurerIban { get; set; } = null!;

        public string? RcshLiablePartyName { get; set; }

        public Guid? RcshLiablePartyAddressId { get; set; }

        public string? RcshLiablePartyIban { get; set; }

        public string? RcshLiablePartyInsurancePolicyNumber { get; set; }

        public string? RcshLiablePartyIncidentNumber { get; set; }

        public string? RcshLiablePartyLicensePlate { get; set; }

        public Guid? RcshLiablePartyInsurerId { get; set; }

        public string? RcshLiablePartyInsurerCode { get; set; }

        public string? RcshLiablePartyInsurerName { get; set; }

        public Guid? RcshLiablePartyInsurerAddressId { get; set; }

        public string? RcshLiablePartyInsurerIban { get; set; }

        public Guid? RcshTenantId { get; set; }

        public Guid? RcshLegalEntityId { get; set; }

        public string? RcshDebtorNumber { get; set; }

        public string? RcshCreditorNumber { get; set; }

        public Guid? RcshCostCenterId { get; set; }

        public Guid? RcshCostUnitId { get; set; }

        public DateTime RcshCreatedDate { get; set; }

        public string? RcshCreatedBy { get; set; }

        public DateTime RcshLastModifiedDate { get; set; }

        public string? RcshLastModifiedBy { get; set; }
    }
}