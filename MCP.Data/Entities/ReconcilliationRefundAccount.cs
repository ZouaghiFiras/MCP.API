namespace CED.Data.Entities
{
    public class ReconcilliationRefundAccount
    {
        public Guid RraId { get; set; }

        public byte[] RraTimeStamp { get; set; } = null!;

        public Guid RraReconcilliationBankAccountId { get; set; }

        public Guid RraRefundBankAccountId { get; set; }

        public short RraReconcilliationRefundTypeId { get; set; }

        public DateTime RraCreatedDate { get; set; }

        public string? RraCreatedBy { get; set; }

        public DateTime RraLastModifiedDate { get; set; }

        public string? RraLastModifiedBy { get; set; }

        public virtual BankAccount RraReconcilliationBankAccount { get; set; } = null!;

        public virtual ReconcilliationRefundType RraReconcilliationRefundType { get; set; } = null!;

        public virtual BankAccount RraRefundBankAccount { get; set; } = null!;
    }
}