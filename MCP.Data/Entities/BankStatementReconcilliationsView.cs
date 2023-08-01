namespace CED.Data.Entities
{
    public class BankStatementReconcilliationsView
    {
        public Guid Id { get; set; }

        public short ReconcilliationActionTypeId { get; set; }

        public string? ActionTypeAbbreviation { get; set; }

        public string ActionTypeDescription { get; set; } = null!;

        public Guid BankStatementLineId { get; set; }

        public Guid? RecoveryStatementId { get; set; }

        public Guid? SalesInvoiceId { get; set; }

        public Guid? PurchaseInvoiceId { get; set; }

        public Guid? ClientId { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public DateTime MatchDate { get; set; }

        public decimal MatchValue { get; set; }

        public string? Description { get; set; }

        public string LedgerAccount { get; set; } = null!;

        public string? DebtorNumber { get; set; }

        public string? CreditorNumber { get; set; }

        public string? InvoiceNumber { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostUnitCode { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public string? AccountNumber { get; set; }

        public string? AccountHolderName { get; set; }

        public string? AccountAddressLine1 { get; set; }

        public string? AccountAddressLine2 { get; set; }

        public string? BankName { get; set; }

        public string? Iban { get; set; }

        public string? Bic { get; set; }

        public string? Notes { get; set; }

        public Guid BankStatementId { get; set; }

        public int SequenceNumber { get; set; }

        public decimal TransactionValue { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public string? TransactionCode { get; set; }

        public string? TransactionDescription { get; set; }

        public string? ReferenceAccountOwner { get; set; }

        public string? FurtherReferenceInfo { get; set; }

        public string? RemittanceInformation { get; set; }

        public string GeneralLedgerDescription { get; set; } = null!;

        public string? ActionTypeCategory { get; set; }

        public string? DebtorName { get; set; }

        public string? CreditorName { get; set; }

        public string? RelationNumber { get; set; }

        public string? RelationName { get; set; }

        public bool? IsCredit { get; set; }

        public bool HasCorrection { get; set; }

        public string? CorrectionReason { get; set; }

        public bool IsReadonly { get; set; }

        public string? InsuredPartyLicensePlate { get; set; }

        public string? InsuredPartyIncidentNumber { get; set; }

        public string? RecoveryJournalId { get; set; }

        public string? RecoveryLedgerAccount { get; set; }

        public string? ExactAdministration { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}