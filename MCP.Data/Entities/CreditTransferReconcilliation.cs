namespace CED.Data.Entities
{
    public class CreditTransferReconcilliation
    {
        public Guid CtrId { get; set; }

        public byte[] CtrTimeStamp { get; set; } = null!;

        public Guid CtrCreditTransferId { get; set; }

        public Guid CtrBankStatementReconcilliationId { get; set; }

        public DateTime CtrCreatedDate { get; set; }

        public string? CtrCreatedBy { get; set; }

        public DateTime CtrLastModifiedDate { get; set; }

        public string? CtrLastModifiedBy { get; set; }

        public virtual BankStatementReconcilliation CtrBankStatementReconcilliation { get; set; } = null!;

        public virtual CreditTransfer CtrCreditTransfer { get; set; } = null!;
    }
}