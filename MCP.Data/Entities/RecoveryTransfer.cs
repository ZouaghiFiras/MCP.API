namespace CED.Data.Entities
{
    public class RecoveryTransfer
    {
        public Guid RctId { get; set; }

        public byte[] RctTimeStamp { get; set; } = null!;

        public Guid RctRecoveryStatementId { get; set; }

        public decimal RctCreditAmount { get; set; }

        public string RctCurrencyCode { get; set; } = null!;

        public DateTime? RctExecutionDate { get; set; }

        public bool RctUrgentTransfer { get; set; }

        public string? RctAccountNumber { get; set; }

        public string? RctAccountHolderName { get; set; }

        public string? RctAccountAddressLine1 { get; set; }

        public string? RctAccountAddressLine2 { get; set; }

        public string? RctBankName { get; set; }

        public string? RctIban { get; set; }

        public string? RctBic { get; set; }

        public string? RctRemittanceInformation { get; set; }

        public Guid RctCreditTransferId { get; set; }

        public string RctCreditTransferNumber { get; set; } = null!;

        public string? RctEntrySystem { get; set; }

        public string? RctEntryNumber { get; set; }

        public string? RctEntryBatch { get; set; }

        public DateTime RctCreatedDate { get; set; }

        public string? RctCreatedBy { get; set; }

        public DateTime RctLastModifiedDate { get; set; }

        public string? RctLastModifiedBy { get; set; }

        public virtual RecoveryStatement RctRecoveryStatement { get; set; } = null!;
    }
}