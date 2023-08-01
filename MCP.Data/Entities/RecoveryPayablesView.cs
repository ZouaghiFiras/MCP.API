namespace CED.Data.Entities
{
    public class RecoveryPayablesView
    {
        public Guid Id { get; set; }

        public string StatementNumber { get; set; } = null!;

        public Guid? DossierId { get; set; }

        public string DossierNumber { get; set; } = null!;

        public DateTime DossierDate { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? AssignmentNumber { get; set; }

        public DateTime? IncidentDate { get; set; }

        public decimal IncidentAmountPaid { get; set; }

        public decimal OwnRiskAmount { get; set; }

        public decimal? RecoveryAmountExpected { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public string? EntryNumber { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryBatch { get; set; }

        public bool? IsGuaranteeFund { get; set; }

        public bool? IsInsuredLiable { get; set; }

        public string? InsuranceCoverageCode { get; set; }

        public string? IncidentDescription { get; set; }

        public string? ClientProductCode { get; set; }

        public string InsuredPartyName { get; set; } = null!;

        public Guid? InsuredPartyAddressId { get; set; }

        public string? InsuredPartyIban { get; set; }

        public string? InsuredPartyInsurancePolicyNumber { get; set; }

        public string? InsuredPartyIncidentNumber { get; set; }

        public string? InsuredPartyLicensePlate { get; set; }

        public Guid InsuredPartyInsurerId { get; set; }

        public string InsuredPartyInsurerCode { get; set; } = null!;

        public string InsuredPartyInsurerName { get; set; } = null!;

        public Guid? InsuredPartyInsurerAddressId { get; set; }

        public string InsuredPartyInsurerIban { get; set; } = null!;

        public string? LiablePartyName { get; set; }

        public Guid? LiablePartyAddressId { get; set; }

        public string? LiablePartyIban { get; set; }

        public string? LiablePartyInsurancePolicyNumber { get; set; }

        public string? LiablePartyIncidentNumber { get; set; }

        public string? LiablePartyLicensePlate { get; set; }

        public Guid? LiablePartyInsurerId { get; set; }

        public string? LiablePartyInsurerCode { get; set; }

        public string? LiablePartyInsurerName { get; set; }

        public Guid? LiablePartyInsurerAddressId { get; set; }

        public string? LiablePartyInsurerIban { get; set; }

        public Guid? TenantId { get; set; }

        public string? TenantCode { get; set; }

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public string LegalEntityName { get; set; } = null!;

        public string? DebtorNumber { get; set; }

        public string? CreditorNumber { get; set; }

        public string? CreditorName { get; set; }

        public Guid? CostCenterId { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostCenterName { get; set; }

        public Guid? CostUnitId { get; set; }

        public string? CostUnitCode { get; set; }

        public string? CostUnitName { get; set; }

        public string? Description { get; set; }

        public string LedgerAccount { get; set; } = null!;

        public string? OurReference { get; set; }

        public string? YourReference { get; set; }

        public DateTime ReceivedDate { get; set; }

        public decimal AmountReceived { get; set; }

        public decimal AmountTransfered { get; set; }

        public decimal AmountOpen { get; set; }

        public string ReceivedCurrencyCode { get; set; } = null!;

        public string StatementStatus { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}