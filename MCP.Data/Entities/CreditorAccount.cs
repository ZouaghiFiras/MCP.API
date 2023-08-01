namespace CED.Data.Entities
{
    public class CreditorAccount
    {
        public Guid CraId { get; set; }

        public byte[] CraTimeStamp { get; set; } = null!;

        public Guid CraCreditorId { get; set; }

        public Guid CraBankAccountId { get; set; }

        public DateTime CraEffectiveDate { get; set; }

        public DateTime? CraTerminationDate { get; set; }

        public DateTime CraCreatedDate { get; set; }

        public string? CraCreatedBy { get; set; }

        public DateTime CraLastModifiedDate { get; set; }

        public string? CraLastModifiedBy { get; set; }

        public virtual BankAccount CraBankAccount { get; set; } = null!;

        public virtual Creditor CraCreditor { get; set; } = null!;
    }
}