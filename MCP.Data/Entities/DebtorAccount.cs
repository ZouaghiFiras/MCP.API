namespace CED.Data.Entities
{
    public class DebtorAccount
    {
        public Guid DeaId { get; set; }

        public byte[] DeaTimeStamp { get; set; } = null!;

        public Guid DeaDebtorId { get; set; }

        public Guid DeaBankAccountId { get; set; }

        public DateTime DeaEffectiveDate { get; set; }

        public DateTime? DeaTerminationDate { get; set; }

        public DateTime DeaCreatedDate { get; set; }

        public string? DeaCreatedBy { get; set; }

        public DateTime DeaLastModifiedDate { get; set; }

        public string? DeaLastModifiedBy { get; set; }

        public virtual BankAccount DeaBankAccount { get; set; } = null!;

        public virtual Debtor DeaDebtor { get; set; } = null!;
    }
}