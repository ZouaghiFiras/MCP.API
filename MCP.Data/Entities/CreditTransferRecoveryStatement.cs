namespace CED.Data.Entities
{
    public class CreditTransferRecoveryStatement
    {
        public Guid CtrId { get; set; }

        public byte[] CtrTimeStamp { get; set; } = null!;

        public Guid CtrCreditTransferId { get; set; }

        public Guid CtrRecoveryStatementId { get; set; }

        public DateTime CtrCreatedDate { get; set; }

        public string? CtrCreatedBy { get; set; }

        public DateTime CtrLastModifiedDate { get; set; }

        public string? CtrLastModifiedBy { get; set; }

        public virtual CreditTransfer CtrCreditTransfer { get; set; } = null!;

        public virtual RecoveryStatement CtrRecoveryStatement { get; set; } = null!;
    }
}