namespace CED.Data.Entities
{
    public class RecoveryStatement
    {
        public Guid RcsId { get; set; }

        public byte[] RcsTimeStamp { get; set; } = null!;

        public string RcsStatementNumber { get; set; } = null!;

        public string RcsDossierNumber { get; set; } = null!;

        public DateTime RcsDossierDate { get; set; }

        public DateTime? RcsIncidentDate { get; set; }

        public decimal RcsIncidentAmountPaid { get; set; }

        public decimal RcsOwnRiskAmount { get; set; }

        public decimal? RcsRecoveryAmountExpected { get; set; }

        public string RcsCurrencyCode { get; set; } = null!;

        public string? RcsEntryNumber { get; set; }

        public string? RcsEntrySystem { get; set; }

        public string? RcsEntryBatch { get; set; }

        public bool? RcsIsGuaranteeFund { get; set; }

        public bool? RcsIsInsuredLiable { get; set; }

        public string? RcsInsuranceCoverageCode { get; set; }

        public string? RcsIncidentDescription { get; set; }

        public string? RcsClientProductCode { get; set; }

        public string RcsInsuredPartyName { get; set; } = null!;

        public Guid? RcsInsuredPartyAddressId { get; set; }

        public string? RcsInsuredPartyIban { get; set; }

        public string? RcsInsuredPartyInsurancePolicyNumber { get; set; }

        public string? RcsInsuredPartyIncidentNumber { get; set; }

        public string? RcsInsuredPartyLicensePlate { get; set; }

        public Guid RcsInsuredPartyInsurerId { get; set; }

        public string RcsInsuredPartyInsurerCode { get; set; } = null!;

        public string RcsInsuredPartyInsurerName { get; set; } = null!;

        public Guid? RcsInsuredPartyInsurerAddressId { get; set; }

        public string RcsInsuredPartyInsurerIban { get; set; } = null!;

        public string? RcsLiablePartyName { get; set; }

        public Guid? RcsLiablePartyAddressId { get; set; }

        public string? RcsLiablePartyIban { get; set; }

        public string? RcsLiablePartyInsurancePolicyNumber { get; set; }

        public string? RcsLiablePartyIncidentNumber { get; set; }

        public string? RcsLiablePartyLicensePlate { get; set; }

        public Guid? RcsLiablePartyInsurerId { get; set; }

        public string? RcsLiablePartyInsurerCode { get; set; }

        public string? RcsLiablePartyInsurerName { get; set; }

        public Guid? RcsLiablePartyInsurerAddressId { get; set; }

        public string? RcsLiablePartyInsurerIban { get; set; }

        public Guid? RcsTenantId { get; set; }

        public Guid? RcsLegalEntityId { get; set; }

        public string? RcsDebtorNumber { get; set; }

        public string? RcsCreditorNumber { get; set; }

        public Guid? RcsCostCenterId { get; set; }

        public Guid? RcsCostUnitId { get; set; }

        public Guid? RcsDossierId { get; set; }

        public Guid? RcsDossierAssignmentId { get; set; }

        public Guid? RcsDossierPartyId { get; set; }

        public DateTime RcsCreatedDate { get; set; }

        public string? RcsCreatedBy { get; set; }

        public DateTime RcsLastModifiedDate { get; set; }

        public string? RcsLastModifiedBy { get; set; }

        public virtual ICollection<BankStatementReconcilliation> BankStatementReconcilliations { get; } =
            new List<BankStatementReconcilliation>();

        public virtual ICollection<CreditTransferRecoveryStatement> CreditTransferRecoveryStatements { get; } =
            new List<CreditTransferRecoveryStatement>();

        public virtual CostCenter? RcsCostCenter { get; set; }

        public virtual CostUnit? RcsCostUnit { get; set; }

        public virtual Dossier? RcsDossier { get; set; }

        public virtual DossierAssignment? RcsDossierAssignment { get; set; }

        public virtual DossierParty? RcsDossierParty { get; set; }

        public virtual Address? RcsInsuredPartyAddress { get; set; }

        public virtual Address? RcsInsuredPartyInsurerAddress { get; set; }

        public virtual LegalEntity? RcsLegalEntity { get; set; }

        public virtual Address? RcsLiablePartyAddress { get; set; }

        public virtual Address? RcsLiablePartyInsurerAddress { get; set; }

        public virtual Tenant? RcsTenant { get; set; }

        public virtual ICollection<RecoveryPayment> RecoveryPayments { get; } = new List<RecoveryPayment>();

        public virtual ICollection<RecoveryStatementStatusHistory> RecoveryStatementStatusHistories { get; } =
            new List<RecoveryStatementStatusHistory>();

        public virtual ICollection<RecoveryTransfer> RecoveryTransfers { get; } = new List<RecoveryTransfer>();
    }
}