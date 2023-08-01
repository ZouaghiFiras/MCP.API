namespace CED.Data.Entities
{
    public class DebtorStatusHistory
    {
        public Guid DbshId { get; set; }

        public byte[] DbshTimeStamp { get; set; } = null!;

        public Guid DbshDebtorId { get; set; }

        public Guid DbshDebtorStatusId { get; set; }

        public Guid? DbshEmployeeId { get; set; }

        public DateTime DbshStartDate { get; set; }

        public string? DbshStatusChangeReason { get; set; }

        public short DbshStatusSource { get; set; }

        public DateTime DbshCreatedDate { get; set; }

        public string? DbshCreatedBy { get; set; }

        public DateTime DbshLastModifiedDate { get; set; }

        public string? DbshLastModifiedBy { get; set; }

        public virtual Debtor DbshDebtor { get; set; } = null!;

        public virtual DebtorStatus DbshDebtorStatus { get; set; } = null!;

        public virtual Employee? DbshEmployee { get; set; }
    }
}