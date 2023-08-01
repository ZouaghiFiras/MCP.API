namespace CED.Data.Entities
{
    public class LegalEntityAccount
    {
        public Guid LeaId { get; set; }

        public byte[] LeaTimeStamp { get; set; } = null!;

        public Guid LeaLegalEntityId { get; set; }

        public string? LeaDebitLedgerAccount { get; set; }

        public string? LeaCreditLedgerAccount { get; set; }

        public DateTime LeaCreatedDate { get; set; }

        public string? LeaCreatedBy { get; set; }

        public DateTime LeaLastModifiedDate { get; set; }

        public string? LeaLastModifiedBy { get; set; }

        public virtual OrganizationAccount Lea { get; set; } = null!;

        public virtual LegalEntity LeaLegalEntity { get; set; } = null!;
    }
}