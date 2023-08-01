namespace CED.Data.Entities
{
    public class RecoveryPayment
    {
        public Guid RctId { get; set; }

        public byte[] RctTimeStamp { get; set; } = null!;

        public Guid RctRecoveryStatementId { get; set; }

        public Guid RctBankStatementLineId { get; set; }

        public decimal RctPaymentValue { get; set; }

        public DateTime RctCreatedDate { get; set; }

        public string? RctCreatedBy { get; set; }

        public DateTime RctLastModifiedDate { get; set; }

        public string? RctLastModifiedBy { get; set; }

        public Guid? RctCurrentStatusHistoryId { get; set; }

        public DateTime? RctCurrentStatusHistoryStartDate { get; set; }

        public string? RctCurrentStatusCode { get; set; }

        public virtual BankStatementLine RctBankStatementLine { get; set; } = null!;

        public virtual RecoveryStatement RctRecoveryStatement { get; set; } = null!;

        public virtual ICollection<RecoveryPaymentStatusHistory> RecoveryPaymentStatusHistories { get; } =
            new List<RecoveryPaymentStatusHistory>();
    }
}